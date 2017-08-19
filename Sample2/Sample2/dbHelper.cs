using System;
using System.Collections.Generic;
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
        public void createEmployee(employee emp)
        {
            using(SqlCommand sqlCommand = new SqlCommand("insert into EMPLOYEE (EmployeeName,EmployeeSurname,EmployeePhone,EmployeeAddress,EmployeeEmail) values" +
                "(@Firstname,@Surname,@CellphoneNumber,@EmailAddress,@Address)", conn))
                {
                sqlCommand.Parameters.AddWithValue("@Firstname",emp.Firstname);
                sqlCommand.Parameters.AddWithValue("@Surname", emp.Surname);
                sqlCommand.Parameters.AddWithValue("@CellPhoneNumber", emp.CellphoneNumber);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emp.EmailAddress);
                sqlCommand.Parameters.AddWithValue("@Address", emp.Address);

                var result = sqlCommand.ExecuteScalar();
            }
        }

        public void updateEmployee()
        {

        }

        public void getEmplyoyee() {

        }

        public void getAllEmployees()
        {

        }
    }
}
