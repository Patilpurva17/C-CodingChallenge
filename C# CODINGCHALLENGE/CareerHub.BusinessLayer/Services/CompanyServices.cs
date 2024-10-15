using CareerHub.BusinessLayer.Repository;
using CareerHub.BusinessLayer.Services;
using CareerHub.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.BusinessLayer.Services
{
    public class CompanyService 
    {
        private readonly ICompanyRepository _repository;

        public CompanyService()
        { 
            _repository = new CompanyRepository();  

           
        }

        public void AddCompany(Company company)
        {
             _repository.InsertCompany(company);
        }

        public List<Company> GetAllCompanies()
        {
            return _repository.GetCompanies();
        }
    }
}
