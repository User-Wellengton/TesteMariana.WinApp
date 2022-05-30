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

        private const string sqlInserirAlternativas =
            @"INSERT INTO [TBALTERNATIVA]

                ([Opção],
                [Correta],
                [Questao_Numero])

            VALUES

                (@Opção],
                 @Correta],
                 @Questao_Numero]);

            SELECT SCOPE_IDENTITY();";



        private const string sqlEditar =
           @"UPDATE [TBQuestao]

		   SET

			       [ENUNCIADO] = @ENUNCIADO,
			       [DISCIPLINA_NUMERO] = @DISCIPLINA_NUMERO,
                   [MATERIA_NUMERO] = @MATERIA_NUMERO

		   WHERE

			        [NUMERO] = @NUMERO";

        private const string sqlEditarAlternativa =
            @"UPDATE [TBALTERNATIVA]
                
            SET
                    OPCAO = @OPCAO,
                    CORRETA = @CORRETA,
                    QUESTAO_NUMERO = @QUESTAO_NUMERO

                WHERE
                    NUMERO = @NUMERO";



        private const string sqlExcluir =
            @"DELETE FROM [TBQuestao]

		        WHERE

			        [NUMERO] = @NUMERO";

        private const string sqlExcluirAlternativas =
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
                    M.TITULO AS MATERIA_NOME

              FROM 

                  TBQUESTAO AS Q INNER JOIN TBDISCIPLINA AS D ON
                  Q.DISCIPLINA_NUMERO = D.ID,

                  TBQUESTAO AS QT INNER JOIN TBMATERIA AS M ON
                  QT.MATERIA_NUMERO = M.NUMERO";




        private const string sqlSelecionarPorNumero =
           @"SELECT 
		            Q.NUMERO,
                    Q.ENUNCIADO,
                    Q.DISCIPLINA_NUMERO,
                    Q.MATERIA_NUMERO,
                    
                    D.ID AS DISCIPLINA_NUMERO,
		            D.TITULO AS DISCIPLINA_NOME,

                    M.NUMERO AS MATERIA_NUMERO,
                    M.TITULO AS MATERIA_NOME

              FROM 

                  TBQUESTAO AS Q INNER JOIN TBDISCIPLINA AS D ON
                  Q.DISCIPLINA_NUMERO = D.ID,

                 TBQUESTAO AS QT INNER JOIN TBMATERIA AS M ON
                 QT.MATERIA_NUMERO = M.NUMERO

            WHERE
                    Q.NUMERO = @NUMERO";


        private const string sqlSelecionarAlternativasDaQuestao =
            @"SELECT
                    A.NUMERO AS NUMERO,
	                A.OPCAO AS OPCAO,
	                A.CORRETA AS CORRETA,
                    Q.NUMERO AS NUMEROQUESTAO
                FROM 
	                TBQUESTAO AS Q
                INNER JOIN TBALTERNATIVA AS A
	                ON A.QUESTAO_NUMERO = Q.NUMERO";




        #endregion

        public ValidationResult Inserir(Questao questao)
        {

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosQuestao(questao, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            questao.Id = Convert.ToInt32(id);

            SqlCommand comandoInsercaoAlternativa = new SqlCommand(sqlInserirAlternativas, conexaoComBanco);
            int i = 0;
            foreach (var alternativa in questao.alternativas)
            {
                comandoInsercaoAlternativa.Parameters.Clear();
                ConfirugarParametrosAlternativas(alternativa, questao, comandoInsercaoAlternativa);
                var idAlternativa = comandoInsercaoAlternativa.ExecuteScalar(); 
                questao.alternativas[i].Id = Convert.ToInt32(idAlternativa);

                i++;
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

            SqlCommand comandoEdicaoQuestao = new SqlCommand(sqlEditar, conexaoComBanco);

            SqlCommand comandoEdicaoAlternativa = new SqlCommand(sqlEditarAlternativa, conexaoComBanco);

            ConfigurarParametrosQuestao(questao, comandoEdicaoQuestao);

            conexaoComBanco.Open();

            foreach (var alternativa in questao.alternativas)
            {
                comandoEdicaoAlternativa.Parameters.Clear();
                ConfirugarParametrosAlternativas(alternativa, questao, comandoEdicaoAlternativa);
                comandoEdicaoAlternativa.ExecuteNonQuery();
            }


            comandoEdicaoQuestao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

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

        public List<Alternativas> AdicionarAlternativa(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection (enderecoBanco);

            SqlCommand comandoSelecaoAlternativas = new SqlCommand (sqlSelecionarAlternativasDaQuestao, conexaoComBanco);

            comandoSelecaoAlternativas.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();

            SqlDataReader leitorAlternativa = comandoSelecaoAlternativas.ExecuteReader();

            List<Alternativas> alternativas = new ();
            while (leitorAlternativa.Read())
                alternativas.Add(ConverterParaAlternativas(leitorAlternativa));

            conexaoComBanco.Close();

            return alternativas;
        }


        private Alternativas ConverterParaAlternativas(SqlDataReader leitorAlternativa)
        {
            int numeroAlternativa = Convert.ToInt32(leitorAlternativa["NUMERO"]);
            string opcaoAlternativa = Convert.ToString(leitorAlternativa["OPÇÃO"]);
            bool corretaAlternativa = Convert.ToBoolean(leitorAlternativa["CORRETA"]);

            int numeroQuestao = Convert.ToInt32(leitorAlternativa["NUMEROQUESTAO"]);

            return new Alternativas
            {
                Id = numeroAlternativa,
                Opcao = opcaoAlternativa,
                Correta = corretaAlternativa,

                Questao = new Questao
                {
                    Id = numeroQuestao,
                }
            };


        }



        private static Questao ConverterParaQuestao(SqlDataReader leitorQuestao)
        {
            int numero = Convert.ToInt32(leitorQuestao["NUMERO"]);
            string titulo = Convert.ToString(leitorQuestao["ENUNCIADO"]);
            

            int numeroDisciplina = Convert.ToInt32(leitorQuestao["DISCIPLINA_NUMERO"]);
            string nomeDisciplina = Convert.ToString(leitorQuestao["DISCIPLINA_NOME"]);

            int numeroMateria = Convert.ToInt32(leitorQuestao["MATERIA_NUMERO"]);
            string nomeMateria = Convert.ToString(leitorQuestao["MATERIA_NOME"]);


            List<Alternativas> alternativas = AdicionarAlternativa(numero);

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
                    Nome = nomeMateria
                },

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

        private void ConfirugarParametrosAlternativas(Alternativas alternativa, Questao questao, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", alternativa.Id);
            comando.Parameters.AddWithValue("OPÇÃO", alternativa.Opcao);
            comando.Parameters.AddWithValue("CORRETA", alternativa.Correta);
            comando.Parameters.AddWithValue("QUESTAO_NUMERO", questao.Id);
        }


    }
}
