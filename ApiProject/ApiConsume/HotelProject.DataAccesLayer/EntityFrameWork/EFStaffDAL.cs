using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFrameWork
{
	public class EFStaffDAL:GenericRepository<Staff>,IStaffDAL
	{
		public EFStaffDAL(Context context) : base(context) { }

        public List<Staff> GetLastFourStaff()
        {
            using (var context = new Context())
            {
                var values = context.Staffs.OrderByDescending(x=>x.StaffId).Take(4).ToList();
                return values;
            }
        }

        public int StaffCount()
        {
           var context=new Context();
            var values = context.Staffs.Count();
            return values;
        }
    }
}
