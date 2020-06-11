using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;

namespace TedarikYonetim.Model
{
    public class SubCategory : IVeri
    {
        public int SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public string SubCategoryName{ get; set; }
        public string SubCategoryCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
