using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models.ViewModels
{
    public class NewUserModel
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
    }
}
