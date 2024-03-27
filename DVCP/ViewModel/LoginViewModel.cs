using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVCP.ViewModel
{
    public class LoginViewModel
    {

        [MaxLength(20)]
        [Required(ErrorMessage = "Bắt buộc phải có tên người dùng")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bắt buộc phải có mật khẩu ")]
        [MaxLength(20)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}