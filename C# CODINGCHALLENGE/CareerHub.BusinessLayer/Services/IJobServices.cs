using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Service.Interfaces
{
    public interface IJobListingService
    {
        void PostJob(JobListing job);
        List<JobListing> GetAllJobs();
    }
}

