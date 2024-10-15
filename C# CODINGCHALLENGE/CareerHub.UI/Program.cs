using CareerHub.BusinessLayer.Services;
using System;

namespace CareerHub.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobService jobService = new JobService(); // Initialize the job service

            bool continueApp = true;

            while (continueApp)
            {
                Console.Clear();
                Console.WriteLine("Welcome to CareerHub Job Management");
                Console.WriteLine("1. Add Job");
                Console.WriteLine("2. Update Job");
                Console.WriteLine("3. Remove Job");
                Console.WriteLine("4. Delete Job");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddJob(jobService);
                        break;
                    case "2":
                        UpdateJob(jobService);
                        break;
                    case "3":
                        RemoveJob(jobService);
                        break;
                    case "4":
                        DeleteJob(jobService);
                        break;
                    case "5":
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                if (continueApp)
                {
                    Console.WriteLine("\nPress any key to return to the main menu...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Thank you for using CareerHub!");
        }

        static void AddJob(JobService jobService)
        {
            Console.Clear();
            Console.WriteLine("Add a new job");

            JobListing job = new JobListing();
            Console.Write("Enter Job ID: ");
            job.JobID = int.Parse(Console.ReadLine());

            Console.Write("Enter Company ID: ");
            job.CompanyID = int.Parse(Console.ReadLine());

            Console.Write("Enter Job Title: ");
            job.JobTitle = Console.ReadLine();

            Console.Write("Enter Job Description: ");
            job.JobDescription = Console.ReadLine();

            Console.Write("Enter Job Location: ");
            job.JobLocation = Console.ReadLine();

            Console.Write("Enter Salary: ");
            job.Salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Job Type: ");
            job.JobType = Console.ReadLine();

            job.PostedDate = DateTime.Now; // Set the current date as posted date

            bool isAdded = jobService.addJob(job);

            if (isAdded)
            {
                Console.WriteLine("Job added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add job.");
            }
        }

        static void UpdateJob(JobService jobService)
        {
            Console.Clear();
            Console.WriteLine("Update an existing job");

            JobListing job = new JobListing();
            Console.Write("Enter Job ID: ");
            job.JobID = int.Parse(Console.ReadLine());

            Console.Write("Enter Company ID: ");
            job.CompanyID = int.Parse(Console.ReadLine());

            Console.Write("Enter Job Title: ");
            job.JobTitle = Console.ReadLine();

            Console.Write("Enter Job Description: ");
            job.JobDescription = Console.ReadLine();

            Console.Write("Enter Job Location: ");
            job.JobLocation = Console.ReadLine();

            Console.Write("Enter Salary: ");
            job.Salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Job Type: ");
            job.JobType = Console.ReadLine();

            job.PostedDate = DateTime.Now; // Update posted date

            bool isUpdated = jobService.updateJob(job);

            if (isUpdated)
            {
                Console.WriteLine("Job updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update job.");
            }
        }

        static void RemoveJob(JobService jobService)
        {
            Console.Clear();
            Console.WriteLine("Remove (Soft Delete) a job");

            Console.Write("Enter Job ID: ");
            int jobId = int.Parse(Console.ReadLine());

            bool isRemoved = jobService.removeJob(jobId);

            if (isRemoved)
            {
                Console.WriteLine("Job removed (soft deleted) successfully.");
            }
            else
            {
                Console.WriteLine("Failed to remove job.");
            }
        }

        static void DeleteJob(JobService jobService)
        {
            Console.Clear();
            Console.WriteLine("Permanently delete a job");

            Console.Write("Enter Job ID: ");
            int jobId = int.Parse(Console.ReadLine());

            bool isDeleted = jobService.deleteJob(jobId);

            if (isDeleted)
            {
                Console.WriteLine("Job deleted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to delete job.");
            }
        }
    }
}
