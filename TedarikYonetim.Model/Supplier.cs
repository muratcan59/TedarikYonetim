using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;

namespace TedarikYonetim.Model
{
    public class Supplier : IVeri
    {
        public int SupplierId { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public int MobilePhone { get; set; }
        public string WebUrl { get; set; }
        public string EMail { get; set; }
        public string State { get; set; }
        public string TaxPlace { get; set; }
        public int TaxNo { get; set; }
        public string DeliveryType { get; set; }
        public string PayType { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
