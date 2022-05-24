using FluentValidation.Results;
using TesteMariana.Dominio.ModuloDisciplina;
using TesteMariana.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteMariana.Infra.BancoDados.ModuloDisciplina
{
    public class RepositorioDisciplinaEmBancoDados : IRepositorioDisciplina
    {

        private const string enderecoBanco =
               "Data Source=(LocalDB)\\MSSqlLocalDB;" +
               "Initial Catalog=MarianaDb;" +
               "Integrated Security=True;" +
               "Pooling=False";

        #region Sql Queries
        private const string sqlInserir =
            @"INSERT INTO [TBDISCIPLINA] 
                (
                    [TITULO]
                  
	            )
	            VALUES
                (
                    @TITULO                   
                );SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
           @"UPDATE [TBDisciplina]	
		        SET
			        [TITULO] = @TITULO
			       
		        WHERE
			        [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBDisciplina]
		        WHERE
			        [ID] = @ID";

        private const string sqlSelecionarTodos =
           @"SELECT 
		            [ID], 
		            [TITULO] 
		          
	            FROM 
		            [TBDisciplina]";

        private const string sqlSelecionarPorNumero =
           @"SELECT 
		                [ID], 
		                [TITULO] 
		         
	                FROM 
		                [TBDisciplina]
		            WHERE
                        [ID] = @ID";

        #endregion

        public ValidationResult Inserir(Disciplina novaDisciplina)
        {
            var validador = new ValidadorDisciplina();

            var resultadoValidacao = validador.Validate(novaDisciplina);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosDisciplina(novaDisciplina, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            novaDisciplina.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }
        public ValidationResult Editar(Disciplina disciplina)
        {
            var validador = new ValidadorDisciplina();

            var resultadoValidacao = validador.Validate(disciplina);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            ConfigurarParametrosDisciplina(disciplina, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Disciplina disciplina)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", disciplina.Id);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public List<Disciplina> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            List<Disciplina> disciplinas = new List<Disciplina>();

            while (leitorDisciplina.Read())
            {
                Disciplina disciplina = ConverterParaDisciplina(leitorDisciplina);

                disciplinas.Add(disciplina);
            }

            conexaoComBanco.Close();

            return disciplinas;
        }
        public Disciplina SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            Disciplina disciplina = null;
            if (leitorDisciplina.Read())
                disciplina = ConverterParaDisciplina(leitorDisciplina);

            conexaoComBanco.Close();

            return disciplina;
        }

        private static Disciplina ConverterParaDisciplina(SqlDataReader leitorDisciplina)
        {
            int numero = Convert.ToInt32(leitorDisciplina["ID"]);
            string titulo = Convert.ToString(leitorDisciplina["TITULO"]);


            var disciplina = new Disciplina
            {
                Id = numero,
                Nome = titulo,

            };

            return disciplina;
        }

        private static void ConfigurarParametrosDisciplina(Disciplina novaDisciplina, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", novaDisciplina.Id);
            comando.Parameters.AddWithValue("TITULO", novaDisciplina.Nome);

        }

        public List<Questao> SelecionarQuestoes()
        {
            throw new NotImplementedException();
        }


    }
}
