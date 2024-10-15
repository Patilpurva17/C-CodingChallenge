using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerHub.Entity.Models;

namespace CareerHub.BusinessLayer.Repository
{
    public class JobRepository : IJobRepository
    {
        public bool addJob(JobListing job)
        {
            string query = "INSERT INTO JobListing (CompanyID, JobTitle, JobDescription, JobLocation, Salary, JobType, PostedDate) " +
                           "VALUES (@CompanyID, @JobTitle, @JobDescription, @JobLocation, @Salary, @JobType, @PostedDate)";

            using (SqlConnection conn = DBUtil.GetConnnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters with values (excluding JobID because it's auto-generated)
                        cmd.Parameters.AddWithValue("@CompanyID", job.CompanyID);
                        cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                        cmd.Parameters.AddWithValue("@JobDescription", job.JobDescription);
                        cmd.Parameters.AddWithValue("@JobLocation", job.JobLocation);
                        cmd.Parameters.AddWithValue("@Salary", job.Salary);
                        cmd.Parameters.AddWithValue("@JobType", job.JobType);
                        cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                      
                        int rowsAffected = cmd.ExecuteNonQuery();  // Executes the insert
                        return rowsAffected > 0; // Return true if rows were affected
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public bool deleteJob(int id)
        {
            string query = "DELETE FROM JobListings WHERE JobID = @JobID";

            using (SqlConnection conn = DBUtil.GetConnnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@JobID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Executes the delete query

                        // If at least one row was deleted, return true
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        public bool updateJob(JobListing job)
        {
            string query = "UPDATE JobListings SET CompanyID = @CompanyID, JobTitle = @JobTitle, JobDescription = @JobDescription, " +
                           "JobLocation = @JobLocation, Salary = @Salary, JobType = @JobType, PostedDate = @PostedDate " +
                           "WHERE JobID = @JobID";

            using (SqlConnection conn = DBUtil.GetConnnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters with values
                    cmd.Parameters.AddWithValue("@JobID", job.JobID);
                    cmd.Parameters.AddWithValue("@CompanyID", job.CompanyID);
                    cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                    cmd.Parameters.AddWithValue("@JobDescription", job.JobDescription);
                    cmd.Parameters.AddWithValue("@JobLocation", job.JobLocation);
                    cmd.Parameters.AddWithValue("@Salary", job.Salary);
                    cmd.Parameters.AddWithValue("@JobType", job.JobType);
                    cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Executes the update query

                        // If at least one row was updated, return true
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        public bool removeJob(int id)
        {
            string query = "UPDATE JobListings SET IsDeleted = 1 WHERE JobID = @JobID"; // Assuming there is an 'IsDeleted' column

            using (SqlConnection conn = DBUtil.GetConnnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@JobID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Executes the soft delete (update)

                        // If at least one row was affected, return true
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

    }
}