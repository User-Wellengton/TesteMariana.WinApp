using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMariana.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Enunciado)
                .NotNull().NotEmpty(); // metodo para nao deixar o campo Enunciado vazio nem nulo

            RuleFor(x => x.Resposta)
                .NotNull().NotEmpty(); // metodo para nao deixar o campo Resposta vazio nem nulo

        }


    }
}
