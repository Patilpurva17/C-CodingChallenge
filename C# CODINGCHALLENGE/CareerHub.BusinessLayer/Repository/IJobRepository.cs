using CareerHub.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.BusinessLayer.Repository
{
    internal interface IJobRepository
    {
        bool addJob( JobListing job );
        bool removeJob(int id );
        bool updateJob( JobListing job );
        bool deleteJob(int job );
    }
}
