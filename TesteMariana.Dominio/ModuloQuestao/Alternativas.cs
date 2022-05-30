using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;

namespace TesteMariana.Dominio.ModuloQuestao
{
    public  class Alternativas : EntidadeBase<Alternativas>
    {
        public string Opcao { get; set; }
        public bool Correta { get; set; }
        public Questao Questao { get; set; }

        public override void Atualizar(Alternativas registro)
        {
            this.Opcao = registro.Opcao;
            this.Correta = registro.Correta;
        }

        public override string ToString()
        {
            return Opcao;
        }
    }
}
