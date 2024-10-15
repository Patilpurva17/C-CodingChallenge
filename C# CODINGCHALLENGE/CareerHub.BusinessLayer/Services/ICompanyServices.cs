using CareerHub.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Service.Interfaces
{
    public interface ICompanyService
    {
        void AddCompany(Company company);
        List<Company> GetAllCompanies();
    }
}
