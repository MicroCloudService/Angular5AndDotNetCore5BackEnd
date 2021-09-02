using System.ComponentModel.DataAnnotations;

namespace Angular5AndDotNetCore5.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}