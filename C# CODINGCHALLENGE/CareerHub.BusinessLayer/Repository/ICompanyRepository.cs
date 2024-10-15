using CareerHub.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.BusinessLayer.Repository
{
    internal interface ICompanyRepository
    {
        void InsertCompany(Company company);

        List<Company> GetCompanies();


    }
}
