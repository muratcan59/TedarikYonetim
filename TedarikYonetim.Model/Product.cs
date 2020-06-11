using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;

namespace TedarikYonetim.Model
{
    public class Product : IVeri
    {
        public int ProductId { get; set; }
        public int UpperCategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public string SupplierGetType { get; set; }
        public double BuyPrice { get; set; }
        public string Picture { get; set; }
        public string Material { get; set; }
        public string Pattern { get; set; }
        public string Color { get; set; }
        public string PacketContent { get; set; }
        public string Description { get; set; }
        public string ProductFix { get; set; }
        public int UserId { get; set; }
        public string ProductState { get; set; }
        public int ProductWidth { get; set; }
        public int ProductDepth { get; set; }
        public int ProductHeight { get; set; }
        public double ProductWeight { get; set; }
        public double ModuleCBM { get; set; }
        public double KDV { get; set; }
        public int PacketAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
