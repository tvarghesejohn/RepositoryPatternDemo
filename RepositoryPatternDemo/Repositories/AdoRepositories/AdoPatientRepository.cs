using Microsoft.Data.SqlClient;
using RepositoryPatternDemo.IRepositories;
using System.Collections.Generic;

namespace RepositoryPatternDemo.AdoRepositories
{
    public class AdoPatientRepository<Patient> 
    {
        public List<Patient> Add(Patient entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Patient> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Patient> GetAll()
        {
            throw new System.NotImplementedException();
        }

        //public List<Patient> GetAllPatients()
        //{
        //    var connectionString = "Server=localhost\\SQLEXPRESS;Database=HOSPITALSYSTEM;Trusted_Connection=True;";
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    conn.Open();
        //    var query = "Select * from Patients;";
        //    SqlCommand cmd = new SqlCommand(query, conn);

        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            var patient = new Patient { FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString(), Id = (int)reader["Id"] };
        //            patients.Add(patient);
        //        }
        //    }

        //    conn.Close();
        //}

        public List<Patient> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Patient> Update(Patient entity)
        {
            throw new System.NotImplementedException();
        }

        //Patient IBaseRepository<Patient>.GetById(int id)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
