using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 


namespace LoginandCreateacountCsharp
{
     class Modify
    {

        public Modify() 
        
        {
          
        }

        SqlCommand sqlCommand; // dung truy van cac cau lenh insert , update , delete , .....
        SqlDataReader dataReader;// dung de doc du~ lieu trong bang


        public List<Taikhoan> taikhoans(string query)
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();


            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    taikhoans.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnection.Close();

            }
            
            return taikhoans;
        }
        public void Command(string query) // dung de dang ky tai khoan 
        {
        
        using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                sqlConnection.Close () ;

            }
        
        
        
        }
}
}
