using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.ModuloQuestao;
using TesteMariana.Dominio.ModuloTeste;

namespace TesteMariana.Infra.BancoDados.ModuloTeste
{
    public class RepositorioTesteEmBancoDados
    {
        private const string enderecoBanco =
              "Data Source=(LocalDB)\\MSSqlLocalDB;" +
              "Initial Catalog=MarianaDb;" +
              "Integrated Security=True;" +
              "Pooling=False";

        private const string sqlInserir =
           @"INSERT INTO TBTESTE
                (
                    NOME,
                    QUANTIDADE_QUESTOES,
                    DISCIPLINA_NUMERO,
                    MATERIA_NUMERO,
                    DATA_CRIACAO
                )
                    VALUES
                (
                    @NOME,
                    @QUANTIDADE_QUESTOES,
                    @DISCIPLINA_NUMERO,
                    @MATERIA_NUMERO,
                    @DATA_CRIACAO
                ); SELECT SCOPE_IDENTITY();";

        private const string sqlEditarTeste =
           @"UPDATE TBTESTE
                SET
                    NOME = @NOME,
                    QUANTIDADE_QUESTOES = @QUANTIDADE_QUESTOES,
                    DISCIPLINA_NUMERO = @DISCIPLINA_NUMERO,
                    MATERIA_NUMERO = @MATERIA_NUMERO,
                    DATA_CRIACAO = DATA_CRIACAO
                WHERE
                    NUMERO = @ESCOLHA";

        private const string sqlExcluir =
            @"DELETE FROM TBTESTE
                WHERE
                    NUMERO = @NUMERO";

        private const string sqlSelecionarTodos =
            @"SELECT
	            T.NOME AS NOME,
                T.NUMERO AS NUMERO,
	            D.NOME AS NOMEDISCIPLINA,
	            D.ID AS NUMERODISCIPLINA,
	            M.NOME AS NOMEMATERIA,
	            M.NUMERO AS NUMEROMATERIA,
	            T.QUANTIDADE_QUESTOES AS QUANTIDADE_QUESTOES,
	            T.DATA_CRIACAO AS DATA_CRIACAO
            FROM
	            TBTESTE AS T
	            INNER JOIN TBDISCIPLINA AS D
	            ON T.DISCIPLINA_NUMERO = D.ID
	            INNER JOIN TBMATERIA AS M
	            ON T.MATERIA_NUMERO = M.NUMERO";

        private const string sqlSelecionarPorNumero =
            @"SELECT
	            T.NOME AS NOME,
                T.NUMERO AS NUMERO,
	            D.NOME AS NOMEDISCIPLINA,
	            D.ID AS NUMERODISCIPLINA,
	            M.NOME AS NOMEMATERIA,
	            M.NUMERO AS NUMEROMATERIA,
	            T.QUANTIDADE_QUESTOES AS QUANTIDADE_QUESTOES,
	            T.DATA_CRIACAO AS DATA_CRIACAO
            FROM
	            TBTESTE AS T
	            INNER JOIN TBDISCIPLINA AS D
	            ON T.DISCIPLINA_NUMERO = D.Numero
	            INNER JOIN TBMATERIA AS M
	            ON T.MATERIA_NUMERO = M.NUMERO
            WHERE
                T.NUMERO = @NUMERO";



        

        private void ConfigurarParametrosTeste(Teste teste, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", teste.Id);
            comando.Parameters.AddWithValue("NOME", teste.Titulo);
            comando.Parameters.AddWithValue("QUANTIDADE_QUESTOES", teste.NumeroQuestoes);
            comando.Parameters.AddWithValue("DATA_CRIACAO", teste.DataCriacao);

            comando.Parameters.AddWithValue("DISCIPLINA_ID", teste.Disciplina.Id);
            comando.Parameters.AddWithValue("MATERIA_ID", teste.Materia.Id);
        }

    }
}
