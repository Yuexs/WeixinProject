using System.ComponentModel.DataAnnotations;

namespace WeixinProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}