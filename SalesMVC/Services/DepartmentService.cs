using SalesMVC.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesMVCContext _context;

        public DepartmentService(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
