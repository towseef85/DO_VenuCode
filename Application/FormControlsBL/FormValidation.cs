using Domain.Domain.Controls;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormControlsBL
{
    public class FormValidation : AbstractValidator<FormControls>
    {
        public FormValidation()
        {
            RuleFor(x => x.ControlName).NotEmpty().NotNull();
            RuleFor(x => x.FieldName).NotEmpty().NotNull();
            RuleFor(x => x.ArbCaption).NotEmpty().NotNull();
            RuleFor(x => x.ControlType).NotEmpty().NotNull();
            RuleFor(x => x.Section).NotEmpty().NotNull();

        }
    }
}
