using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Attributes
{
    public class AllowedExtentions : ValidationAttribute
    {
        private readonly string _allowedExtentions;

        public AllowedExtentions(string allowedExtentions)
        {
            _allowedExtentions = allowedExtentions;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as List<IFormFile>; 
            if (file != null) { 
                var extension = Path.GetExtension(file[0].FileName);
                var isAllowed = _allowedExtentions.Split(",").Contains(extension,StringComparer.OrdinalIgnoreCase) ; 
                if (!isAllowed) {
                    return new ValidationResult($"Only {_allowedExtentions} are available");
                }
            }
            return ValidationResult.Success;
           
        }

    }
}
