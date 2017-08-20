using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class dbHelper
    {
        SqlConnection conn = DBConnection.Instance.getConn();

        public dbHelper()
        {
            conn.Open();
        }

        /*
          EmployeeId 
          Firstname 
          Surname 
          CellphoneNumber 
          EmailAddress 
          Address 
         */
        public void createEmployee(Employee emp)
        {
            //using EF
            var db = new GlamDataContext();
            db.Employees.Add(emp);
            db.SaveChanges();

            //DOING MANUAL WAY

          /*  using(SqlCommand sqlCommand = new SqlCommand("insert into EMPLOYEE (EmployeeName,EmployeeSurname,EmployeePhone,EmployeeAddress,EmployeeEmail) values" +
                "(@Firstname,@Surname,@CellphoneNumber,@EmailAddress,@Address)", conn))
                {
                sqlCommand.Parameters.AddWithValue("@Firstname",emp.Firstname);
                sqlCommand.Parameters.AddWithValue("@Surname", emp.Surname);
                sqlCommand.Parameters.AddWithValue("@CellPhoneNumber", emp.CellphoneNumber);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emp.EmailAddress);
                sqlCommand.Parameters.AddWithValue("@Address", emp.Address);

                var result = sqlCommand.ExecuteScalar();
            }*/
        }

        public void updateEmployee()
        {

        }

        public DataSet getEmployee(Employee emp) {
            DBConnection.Instance.getConn();
     
                var conn = DBConnection.Instance.getConn();
                conn.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * from EMPLOYEE", conn))// where EmployeeName like "+emp.Firstname+" AND EmployeeSurname like "+ emp.Surname
            {
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    return ds;
                }
        }

        public DataSet getAllEmployees()
        {
            DBConnection.Instance.getConn();

            var conn = DBConnection.Instance.getConn();
            conn.Open();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * from EMPLOYEE", conn))// where EmployeeName like "+emp.Firstname+" AND EmployeeSurname like "+ emp.Surname
            {
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
        }
    }
}
