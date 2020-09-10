using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XyzOfficeEmployeeTrackerr.Models;

namespace XyzOfficeEmployeeTrackerr.Repository
{
    public interface iEmployeeRep
    {
        public List<Employee> GetDetails();
        public Employee GetDetail(int id);
        public int AddDetail(Employee emp);
        public int UpdateDetail(int id, Employee emp);
        public int Delete(int id);
    }
}
