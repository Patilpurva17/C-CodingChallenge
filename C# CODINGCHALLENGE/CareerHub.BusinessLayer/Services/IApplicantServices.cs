using CareerHub.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Service
{
    public interface IApplicantService
    {
        void AddApplicant(Applicant applicant);
        Applicant GetApplicantById(int applicantId);
        List<Applicant> GetAllApplicants();
        void UpdateApplicant(Applicant applicant);
        void DeleteApplicant(int applicantId);
    }
}