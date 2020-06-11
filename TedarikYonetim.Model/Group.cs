using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;

namespace TedarikYonetim.Model
{
    public class Group : IVeri
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int UpperCategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
