using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerHub.Service.Interfaces;
using CareerHub.BusinessLayer.Repository;
using CareerHub.Entity.Models;

namespace CareerHub.BusinessLayer.Services

{
    public class ApplicantService
    {
        private readonly IApplicantRepository _repository;

        public ApplicantService(IApplicantRepository repository)
        {
            _repository = repository;
        }

        public void AddApplicant(Applicant applicant)
        {
            _repository.AddApplicant(applicant);
        }

        public Applicant GetApplicantById(int applicantId)
        {
            return _repository.GetApplicantById(applicantId);
        }

        public List<Applicant> GetAllApplicants()
        {
            return _repository.GetAllApplicants();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            _repository.UpdateApplicant(applicant);
        }

        public void DeleteApplicant(int applicantId)
        {
            _repository.DeleteApplicant(applicantId);
        }
    }
}
