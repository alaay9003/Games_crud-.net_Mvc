using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Attributes
{
    public class AllowedSize : ValidationAttribute
    {
        private readonly int _allowedSize;

        public AllowedSize(int allowedSize)
        {
            _allowedSize = allowedSize;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as List<IFormFile>;
            if (file != null)
            {

                if (file[0].Length > _allowedSize)
                {
                    return new ValidationResult($"Only {_allowedSize} byte Are available");
                }
            }
            return ValidationResult.Success;

        }

    }
}
