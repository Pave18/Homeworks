using System;
using System.Data.SqlClient;

namespace hw1_Staff.Datebase_
{
    public class DatabaseStaff
    {

        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        private SqlConnection connection = new SqlConnection();

        public DatabaseStaff()
        {
            builder.InitialCatalog = "staff";
            builder.IntegratedSecurity = true;
            builder.DataSource = @"ASUS-K56CB\HOMESERVER";
            
            connection.ConnectionString = builder.ConnectionString;
        }

        protected void Open()
        {
            connection.Open();
        }
        protected void Close()
        {
            connection.Close();
        }

        protected void Reader(SqlDataReader Reader)
        {
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; i++)
                    Console.WriteLine("{0}: {1}", Reader.GetName(i), Reader.GetValue(i));
                Console.WriteLine();
            };
        }

        public void ShowAllEmployee()
        {
            Open();

            SqlCommand command = new SqlCommand("AllEmployee", connection);
            Reader(command.ExecuteReader());

            Close();
        }

    }
}


