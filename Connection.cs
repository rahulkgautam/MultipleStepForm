using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Multi_StepRegistrationForm
{
    public static class Connection
    {
       public static bool Save(string query)
        {

            string conString = @"Data Source =(localdb)\MSSQLLocalDB; database=MultiStepForm;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
               return 0< cmd.ExecuteNonQuery();
            }
        }
    }
}