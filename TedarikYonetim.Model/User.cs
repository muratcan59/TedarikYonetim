using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;

namespace TedarikYonetim.Model
{
    public class User : IVeri
    {
        public int UserId { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
