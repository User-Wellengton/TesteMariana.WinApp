using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;
using TesteMariana.Dominio.ModuloDisciplina;
using TesteMariana.Dominio.ModuloQuestao;

namespace TesteMariana.Dominio.ModuloMateria
{
    public class Materia:EntidadeBase<Materia>
    {

        public Disciplina disciplina { get; set; }
        public List<Questao> questoes { get; set; }
        public SerieEnum Serie { get; set; }
        public string Nome { get; set; }
        

        public override void Atualizar(Materia registro)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Materia materia &&
                   Id == materia.Id &&
               
                   Serie == materia.Serie &&
                   Nome == materia.Nome;
        }

        public override string ToString()
        {
            return Nome;
        }


    }
}
