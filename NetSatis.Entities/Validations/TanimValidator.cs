using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Turu alanı boş geçilemez.");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanimi alanı boş geçilemez.");
        }
    }
}
