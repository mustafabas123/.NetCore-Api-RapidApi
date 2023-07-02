using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Abstract
{
	public interface IStaffDAL:IGenericDAL<Staff>
	{
		int StaffCount();
		List<Staff> GetLastFourStaff();	
	}
}
