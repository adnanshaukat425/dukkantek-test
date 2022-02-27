using IMS.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace IMS.Attributes
{
    public class ValidateCatagoryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ICatagoryRepository _statusRepository = (ICatagoryRepository)validationContext.GetService(typeof(ICatagoryRepository));
            var res = _statusRepository.GetById((int)value).Result;
            if (res != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid catagory provided");
        }
    }
}
