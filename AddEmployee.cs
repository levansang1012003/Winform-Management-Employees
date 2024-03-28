using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

    
using System.IO;

namespace LoginandCreateacountCsharp
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-SPDRSA1L\SQLEXPRESS;Initial Catalog=AccountLogin;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        public AddEmployee()
        {
            InitializeComponent();


            //To Display The data from database to your data grid view

            displayEmployeeData();
        }
         public void displayEmployeeData()
        {
            DataTable dt = new DataTable();

            try
            {
                // Open connection
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                // Replace with your actual SQL query to retrieve employee data
                string query = "SELECT * FROM Employees"; // Example query

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
            }

            dataGridView1.DataSource = dt;
        }




        private List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listData = new List<EmployeeData>();
            // Thực hiện truy vấn cơ sở dữ liệu để lấy dữ liệu nhân viên
            // Ví dụ: SELECT * FROM Employees
            // Điền dữ liệu vào listData
            return listData;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployee_Addbtn_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(addEmployee_ID.Text) ||
        string.IsNullOrWhiteSpace(addEmployee_FullName.Text) ||
        string.IsNullOrWhiteSpace(addEmployee_Gender.Text) ||
        string.IsNullOrWhiteSpace(addEmployee_PhoneNumber.Text) ||
        string.IsNullOrWhiteSpace(addEmployee_Status.Text) ||
        addEmployee_Picture.Image == null)
    {
        MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Mở kết nối
    if (connect.State != ConnectionState.Open)
        connect.Open();

    // Kiểm tra xem ID nhân viên đã tồn tại chưa
    string checkEmId = "SELECT Count(*) FROM Employees WHERE employee_id = @emID";
    using (SqlCommand CheckEm = new SqlCommand(checkEmId, connect))
    {
        CheckEm.Parameters.AddWithValue("@emID", addEmployee_ID.Text.Trim());

        int count = (int)CheckEm.ExecuteScalar();
        if (count >= 1)
        {
            MessageBox.Show(addEmployee_ID.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
    

    // Chèn dữ liệu nhân viên mới
    string insertData = "INSERT INTO Employees (employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status) " +
                        "VALUES (@employeeId, @fullname, @gender, @contactNum, @position, @image, @salary, @insertDate, @status)";

    using (SqlCommand command = new SqlCommand(insertData, connect))
    {
        // Chuyển hình ảnh thành mảng byte
        MemoryStream ms = new MemoryStream();
        addEmployee_Picture.Image.Save(ms, addEmployee_Picture.Image.RawFormat);
        byte[] imageBytes = ms.ToArray();

        // Thêm các tham số vào lệnh SqlCommand
        command.Parameters.AddWithValue("@employeeId", addEmployee_ID.Text.Trim());
        command.Parameters.AddWithValue("@fullname", addEmployee_FullName.Text.Trim());
        command.Parameters.AddWithValue("@gender", addEmployee_Gender.Text.Trim());
        command.Parameters.AddWithValue("@contactNum", addEmployee_PhoneNumber.Text.Trim());
        command.Parameters.AddWithValue("@position", Addemployee_BtnPosition.Text.Trim()); // Giả định rằng bạn có một ComboBox hoặc một TextBox có tên là addEmployee_Position
        command.Parameters.AddWithValue("@image", imageBytes);
        command.Parameters.AddWithValue("@salary",0); // Giả định rằng bạn có một NumericUpDown có tên là numericUpDownSalary
        command.Parameters.AddWithValue("@insertDate", DateTime.Now);
        command.Parameters.AddWithValue("@status", addEmployee_Status.Text.Trim());

        command.ExecuteNonQuery();

        
    }

    // Đóng kết nối
    connect.Close();

    // Cập nhật DataGridView
    displayEmployeeData();

    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        

        private void addEmployee_Importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "image files (*.jpg; *.png) | *.jpg; *.png";

                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    addEmployee_Picture.ImageLocation = imagePath;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex,"Error Message"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            displayEmployeeData();


        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
