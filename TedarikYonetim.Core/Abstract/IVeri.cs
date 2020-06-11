using System;
using System.Collections.Generic;
using System.Text;

namespace TedarikYonetim.Core.Abstract
{
    public interface IVeri
    {
        //bu interfaceden kalıtım alarak oluşturulan tüm classlar veritabanı için kullanılmaktadır.
        bool? IsDelete { get; set; }
    }
}
