using CareerHub.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.BusinessLayer.Repository

{
    public class CompanyRepository : ICompanyRepository
    {
        public void InsertCompany(Company company)
        {
            // Database logic for inserting a company
        }

        public List<Company> GetCompanies()
        {
            // Fetch companies from database
            return new List<Company>();
        }
    }
}