﻿using FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("OdemeTuru Kodu alanı boş geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("OdemeTuru Adı alanı boş geçilemez.");
        }

    }
}
