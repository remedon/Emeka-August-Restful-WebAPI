using System.ComponentModel.DataAnnotations;

namespace Austine.Test.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}