using TesteMariana.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.ModuloMateria;
using TesteMariana.Dominio.ModuloDisciplina;

namespace TesteMariana.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public Teste()
        {

        }

        public Teste(Disciplina disciplina, Materia materia, string titulo, DateTime data, int numeroQuestoes)
        {
            this.disciplina = disciplina;
            this.materia = materia;
            Titulo = titulo;
            Data = data;
            NumeroQuestoes = numeroQuestoes;
        }

        Disciplina disciplina;
        Materia materia;
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int NumeroQuestoes { get; set; }
          

        public override void Atualizar(Teste registro)
        {
        }

    }
}
