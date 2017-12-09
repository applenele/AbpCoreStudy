using System.ComponentModel.DataAnnotations;

namespace AbpCoreStudy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}