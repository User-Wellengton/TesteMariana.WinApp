﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Compartilhado;

namespace TesteMariana.Dominio.ModuloDisciplina
{
    public class Disciplina: EntidadeBase<Disciplina>
    {
        public Disciplina()
        {

        }
        

        public Disciplina(string nome)
        {
            Nome = nome;
        }


        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
        }
    }

}
