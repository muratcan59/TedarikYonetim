using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class SupplierRepository : EFBaseRepository<TedarikYonetimContext, Supplier>, ISupplierRepository
    {
        public SupplierRepository(TedarikYonetimContext _context) : base(_context)
        {
            
        }

        public ResultMessage<Supplier> ActiveOrPassive(int id)
        {
            try
            {

                var data = context.Set<Supplier>().Find(id);

                var stateData = context.Entry(data);
                if (data.State == "Aktif")
                {
                    data.State = "Pasif";
                }
                else
                {
                    data.State = "Aktif";
                }
                stateData.State = Microsoft.EntityFrameworkCore.EntityState.Modified;


                return new ResultMessage<Supplier> { BasariliMi = true, Data = data, Mesaj = "Kayıt silinmeye hazır." };

            }
            catch (Exception ex)
            {
                return new ResultMessage<Supplier> { BasariliMi = false, Data = null, Mesaj = ex.Message };
            }
        }
    }
}
