using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;
using TesteMariana.Dominio.ModuloMateria;

namespace TesteMariana.Dominio.ModuloDisciplina
{
    public class Disciplina: EntidadeBase<Disciplina>
    {


        public List<Materia> materias { get; set; }

        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Disciplina disciplina &&
                   Id == disciplina.Id &&
                 
                   Nome == disciplina.Nome;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }


    }

}
