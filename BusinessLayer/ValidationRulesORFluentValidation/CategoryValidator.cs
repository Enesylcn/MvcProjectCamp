using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulesORFluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En az 3 karakter olmalıdır!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı En fazla 20 karakter olmalıdır!");
            RuleFor(x => x.CategoryDescription).MinimumLength(5).WithMessage("Kategori Açıklaması En az 5 karakter olmalıdır!");
        }
    }
}
