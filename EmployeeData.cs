using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;

namespace LoginandCreateacountCsharp
{
     class EmployeeData
    {
       
        public int Id { get; set; }
        public string EmployeeId {  get; set; }
        public string Name { get; set; }
        public string gender { get; set; } 
        public string contact { get; set; }
        public string position { get; set; }
        public string image {  get; set; }
        public int salary {  get; set; }
        public string status { get; set; }
        

        
        
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\\SQLEXPRESS;Initial Catalog=AccountLogin;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
       
        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string SelectData = "Select * From Employees where delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData employeedata = new EmployeeData();
                            employeedata.Id = (int)reader["id"];
                            employeedata.EmployeeId = reader["employee_id"].ToString();
                            employeedata.Name = reader["full_name"].ToString();
                            employeedata.gender = reader["gender"].ToString();
                            employeedata.contact = reader["contact_number"].ToString();
                           employeedata.position = reader["position"].ToString();
                           employeedata.image = reader["image"].ToString();
                            employeedata.salary = (int)reader["salary"];
                            employeedata.status = reader["status"].ToString();


                            listdata.Add(employeedata);


                        }
                    }
;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);

                }
                finally
                {
                    connect.Close();
                }
                
            }
            return listdata;
        }
    
    
    
    }
}
