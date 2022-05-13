using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;
using TesteMariana.Dominio.ModuloDisciplina;
using TesteMariana.Dominio.ModuloMateria;

namespace TesteMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Questao()
        {
        }


        public Questao(Disciplina disciplina, Materia materia, string enunciado, string resposta)
        {
            this.disciplina = disciplina;
            this.materia = materia;
            Enunciado = enunciado;
            Resposta = resposta;
        }


        Disciplina disciplina;
        Materia materia;
        public string  Enunciado { get; set; }
        public string  Resposta { get; set; }

        

        public override void Atualizar(Questao registro)
        {
        }

    }
}
