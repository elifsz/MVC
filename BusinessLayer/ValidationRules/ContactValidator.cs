﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi adı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 50 karakter girişi yapın");        }
    }
}
