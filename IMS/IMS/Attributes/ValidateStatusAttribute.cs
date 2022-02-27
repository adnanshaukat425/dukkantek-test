using IMS.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace IMS.Attributes
{
    public sealed class ValidateStatusAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IStatusRepository _statusRepository = (IStatusRepository)validationContext.GetService(typeof(IStatusRepository));
            var res = _statusRepository.GetById((int)value).Result;
            if (res != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid status provided");
        }
    }
}
