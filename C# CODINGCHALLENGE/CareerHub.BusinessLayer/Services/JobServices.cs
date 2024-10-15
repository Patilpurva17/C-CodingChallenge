using CareerHub.BusinessLayer.Repository;
using System;

namespace CareerHub.BusinessLayer.Services
{
    public class JobService
    {
        private readonly JobRepository _repository;

        // Constructor to initialize JobRepository
        public JobService()
        {
            _repository = new JobRepository();
        }

        public bool addJob(JobListing jobListing)
        {
            return _repository.addJob(jobListing);
        }

        public bool removeJob(int id)
        {
            return _repository.removeJob(id);
        }

        public bool updateJob(JobListing job)
        {
            return _repository.updateJob(job);
        }

        public bool deleteJob(int id)
        {
            return _repository.deleteJob(id);
        }
    }
}
