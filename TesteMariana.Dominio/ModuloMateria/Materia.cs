using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;
using TesteMariana.Dominio.ModuloDisciplina;

namespace TesteMariana.Dominio.ModuloMateria
{
    public class Materia:EntidadeBase<Materia>
    {

        public Materia()
        {

        }        

        public Materia(Disciplina disciplina, string nome, SerieEnum serie)
        {
            this.disciplina = disciplina;
            Nome = nome;
            Serie = serie;
        }



        Disciplina disciplina;
        public string Nome { get; set; }
        public SerieEnum Serie { get; set; }


        public override void Atualizar(Materia registro)
        {
        }

    }
}
