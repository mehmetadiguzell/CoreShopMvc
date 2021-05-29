using System.ComponentModel.DataAnnotations;

namespace CoreShopMvc.Data.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Kullanıcı adı 20 karekterden fazla olamaz")]
        public string UserName { get; set; }
        [StringLength(20, ErrorMessage = "Şifre 20 karekterden fazla olamaz")]
        public string Password { get; set; }
    }
}
