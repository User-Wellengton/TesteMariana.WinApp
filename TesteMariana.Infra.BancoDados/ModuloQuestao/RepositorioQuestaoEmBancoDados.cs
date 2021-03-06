using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.ModuloDisciplina;
using TesteMariana.Dominio.ModuloMateria;
using TesteMariana.Dominio.ModuloQuestao;

namespace TesteMariana.Infra.BancoDados.ModuloQuestao
{
    public class RepositorioQuestaoEmBancoDados  : IRepositorioQuestao
    {

        private const string enderecoBanco =
               "Data Source=(LocalDB)\\MSSqlLocalDB;" +
               "Initial Catalog=MarianaDb;" +
               "Integrated Security=True;" +
               "Pooling=False";

        #region Sql Queries
        private const string sqlInserir =
            @"INSERT INTO [TBQUESTAO]
            
                    ([Enunciado]
                    ,[Disciplina_Numero]
                    ,[Materia_Numero])

            VALUES

                (@Enunciado,
                @Disciplina_Numero,
                @Materia_Numero);

            SELECT SCOPE_IDENTITY();";

        private const string sqlInserirAlternativa =
            @"INSERT INTO [TBALTERNATIVA]

                ([QUESTAO_NUMERO],
                [OPCAO],
                [CORRETA])

            VALUES

                (@QUESTAO_NUMERO,
                @OPCAO,
                 @CORRETA);

            SELECT SCOPE_IDENTITY();";



        private const string sqlEditar =
           @"UPDATE [TBQuestao]

		   SET

			       [ENUNCIADO] = @ENUNCIADO,
			       [DISCIPLINA_NUMERO] = @DISCIPLINA_NUMERO,
                   [MATERIA_NUMERO] = @MATERIA_NUMERO

		   WHERE

			        [NUMERO] = @NUMERO";

       
        private const string sqlExcluir =
            @"DELETE FROM [TBQuestao]

		        WHERE

			        [NUMERO] = @NUMERO";

        private const string sqlExcluirAlternativa =
            @"DELETE FROM [TBALTERNATIVA]
                WHERE
                    QUESTAO_NUMERO = @NUMERO";


        private const string sqlSelecionarTodos =
           @"SELECT 
                    Q.NUMERO,
                    Q.ENUNCIADO,
                    Q.DISCIPLINA_NUMERO,
                    Q.MATERIA_NUMERO,
                    
                    D.ID AS DISCIPLINA_NUMERO,
		            D.TITULO AS DISCIPLINA_NOME,

                    M.NUMERO AS MATERIA_NUMERO,
                    M.TITULO AS MATERIA_NOME,
                    M.SERIE AS MATERIA_SERIE

              FROM 

                  TBQUESTAO AS Q INNER JOIN TBMATERIA AS M ON
                  Q.MATERIA_NUMERO = M.Numero
				  INNER JOIN TBDISCIPLINA AS D ON
                  D.Id = M.Disciplina_Numero";




        private const string sqlSelecionarPorNumero =
           @"SELECT 
		            Q.NUMERO,
                    Q.ENUNCIADO,
                    Q.DISCIPLINA_NUMERO,
                    Q.MATERIA_NUMERO,
                    
                    D.ID AS DISCIPLINA_NUMERO,
		            D.TITULO AS DISCIPLINA_NOME,

                    M.NUMERO AS MATERIA_NUMERO,
                    M.TITULO AS MATERIA_NOME,
                    M.SERIE AS MATERIA_SERIE

              FROM 
                    
                    TBQUESTAO AS Q INNER JOIN TBMATERIA AS M ON
                    Q.MATERIA_NUMERO = M.Numero
				    INNER JOIN TBDISCIPLINA AS D ON
                    D.Id = M.Disciplina_Numero

            WHERE
                    Q.NUMERO = @NUMERO";


        

        #endregion

        public ValidationResult Inserir(Questao questao)
        {

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            SqlCommand comandoInsercaoAlternativa = new SqlCommand(sqlInserirAlternativa, conexaoComBanco);

            ConfigurarParametrosQuestao(questao, comandoInsercao);

            conexaoComBanco.Open();
            var _id = comandoInsercao.ExecuteScalar();
            int id = Convert.ToInt32(_id);
            questao.Id = id;
            foreach (var alternativa in questao.alternativas)
            {
                alternativa.Id = id;
                comandoInsercaoAlternativa.Parameters.Clear();
                ConfigurarParametrosAlternativa(alternativa, comandoInsercaoAlternativa);
                comandoInsercaoAlternativa.ExecuteScalar();
            }

            conexaoComBanco.Close();

            return new ValidationResult();
        }

        public ValidationResult Editar(Questao questao)
        {
            var validador = new ValidadorQuestao();

            var resultadoValidacao = validador.Validate(questao);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            SqlCommand comandoExcluirAlternativa = new SqlCommand(sqlExcluirAlternativa, conexaoComBanco);

            SqlCommand comandoInserirAlternativa = new SqlCommand(sqlInserirAlternativa, conexaoComBanco);

            
            conexaoComBanco.Open();

            comandoExcluirAlternativa.Parameters.AddWithValue("NUMERO_QUESTAO", questao.Id);
            comandoExcluirAlternativa.ExecuteNonQuery();

            ConfigurarParametrosQuestao(questao, comandoEdicao);


            foreach (var alternativa in questao.alternativas)
            {
                alternativa.Id = questao.Id;
                ConfigurarParametrosAlternativa(alternativa, comandoInserirAlternativa);
                comandoInserirAlternativa.ExecuteNonQuery();
                comandoInserirAlternativa.Parameters.Clear();
            }


            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            SqlCommand comandoExclusaoAlternativa = new SqlCommand(sqlExcluirAlternativa, conexaoComBanco);

            comandoExclusaoAlternativa.Parameters.AddWithValue("NUMERO_QUESTAO", questao.Id);

            comandoExclusao.Parameters.AddWithValue("NUMERO", questao.Id);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();

            return resultadoValidacao;
        }
        public List<Questao> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorQuestao = comandoSelecao.ExecuteReader();

            List<Questao> questoes = new List<Questao>();

            while (leitorQuestao.Read())
            {
                Questao questao = ConverterParaQuestao(leitorQuestao);

                questoes.Add(questao);
            }

            conexaoComBanco.Close();

            return questoes;
        }

        public Questao SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorQuestao = comandoSelecao.ExecuteReader();

            Questao questao = null;
            if (leitorQuestao.Read())
                questao = ConverterParaQuestao(leitorQuestao);

            conexaoComBanco.Close();

            return questao;
        }   


        private static Questao ConverterParaQuestao(SqlDataReader leitorQuestao)
        {
            int numero = Convert.ToInt32(leitorQuestao["NUMERO"]);
            string titulo = Convert.ToString(leitorQuestao["ENUNCIADO"]);
            

            int numeroDisciplina = Convert.ToInt32(leitorQuestao["DISCIPLINA_NUMERO"]);
            string nomeDisciplina = Convert.ToString(leitorQuestao["DISCIPLINA_NOME"]);

            int numeroMateria = Convert.ToInt32(leitorQuestao["MATERIA_NUMERO"]);
            string nomeMateria = Convert.ToString(leitorQuestao["MATERIA_NOME"]);
            int serieMateria = Convert.ToInt32(leitorQuestao["MATERIA_SERIE"]);


           

            var questao = new Questao
            {
                Id = numero,
                Nome = titulo,

                disciplina = new Disciplina
                {
                    Id = numeroDisciplina,
                    Nome = nomeDisciplina
                },

                materia = new Materia
                {
                    Id = numeroMateria,
                    Nome = nomeMateria,
                    Serie = (SerieEnum)serieMateria
                },

                alternativas = new List<Alternativas>()
            };

            return questao;
        }

        private static void ConfigurarParametrosQuestao(Questao questao, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("NUMERO", questao.Id);
            comandoInsercao.Parameters.AddWithValue("ENUNCIADO", questao.Nome);
            
            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_NUMERO", questao.disciplina.Id);
            comandoInsercao.Parameters.AddWithValue("MATERIA_NUMERO", questao.materia.Id);

        }

        private void ConfigurarParametrosAlternativa(Alternativas alternativa, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("QUESTAO_NUMERO", alternativa.Id);
            comandoInsercao.Parameters.AddWithValue("OPCAO", alternativa.Opcao);
            comandoInsercao.Parameters.AddWithValue("CORRETA", alternativa.Correta);
           

        }


    }
}
