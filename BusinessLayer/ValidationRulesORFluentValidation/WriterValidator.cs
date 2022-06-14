using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulesORFluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(x => x.WriterNameSurname).NotEmpty().WithMessage("Yazar soy adını boş geçemezsiniz!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz!"); // Ödev Hakkında kısmında mutlaka "a" harfi içeren bir kelime olmak zorunda
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar Adı En az 2 karakter olmalıdır!");
            RuleFor(x => x.WriterNameSurname).MinimumLength(2).WithMessage("Yazar soy adı En az 2 karakter olmalıdır!");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Yazar Adı En fazla 20 karakter olmalıdır!");
            RuleFor(x => x.WriterNameSurname).MaximumLength(20).WithMessage("Yazar soy adı En fazla 20 karakter olmalıdır!");
        }
    }
}
