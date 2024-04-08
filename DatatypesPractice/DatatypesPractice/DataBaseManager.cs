using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatatypesPractice
{
    public class DataBaseManager
    {
        // Connection string
        private string connectionString = @"Data Source=C:\poojitha\Datatypepractice.db;Version=3;";
        public void DataBaseConnection()
        {
            // Create connection
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // Connection successful, perform database operations here

                    Console.WriteLine("Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void CreateTable()
        {
            //string createTableQuere = @"
            //CREATE TABLE IF NOT EXISTS MyTable (
            //    Id INTEGER PRIMARY KEY,
            //    Name TEXT NOT NULL,
            //    Age INTEGER
            //)";

            string createTableQuereEmployees = @"
            CREATE TABLE IF NOT EXISTS Employees (
                EmployeeId INTEGER PRIMARY KEY,
                DepartmentId INTEGER,
                Name TEXT,
                PhoneNumber TEXT,
                DateOfBirth TEXT,
                Salary REAL
            );";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(createTableQuereEmployees, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Table created successfully!");

        }
        public void CreateNewRecord(List<string> commands)
        {
            string insertQuery = "INSERT INTO MyTable (Name,Age) VALUES (@Name,@Age)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                foreach (var query in commands)
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                }

            }
            Console.WriteLine("Record inserted successfully:");
        }
        public void DeleteRecord(int id)
        {
            string deleteQuery = "DELETE FROM MyTable WHERE Id =@Id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

        }

        public void ReadRecord()
        {
            string selectQuery = "SELECT * FROM MyTable";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age:{reader["Age"]}");
                        }
                    }
                }
            }

        }
        public Employee ReadAt(int id)
        {
            string readAtQuery = "SELECT Id, Name, Age FROM MyTable WHERE Id = @Id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(readAtQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //if (reader.Read())
                        //{
                        //    var EmployeeId = reader.GetInt32(0); // Assuming Id is stored as INTEGER
                        //    var DepartmentId
                        //    var Name = reader.GetString(1);
                        //    var DateOfBirth = reader.GetDateTime(2);
                        //    // Read data from the reader and create an Employee object
                        //    Employee employee = new Employee(EmployeeId, Name, DateOfBirth)
                        //    //{
                        //    //    EmployeeId = reader.GetInt32(0), // Assuming Id is stored as INTEGER
                        //    //    Name = reader.GetString(1),
                        //    //    DateOfBirth = reader.GetDateTime(2), // Assuming Age is stored as DateOfBirth
                        //    //                                         // You need to set other properties of the Employee object here
                        //    //};

                        //    return employee;
                        //}
                        //else
                        //{
                        //    // If no record is found, return null or throw an exception as per your requirement
                        //    return null;
                        //}

                        return null;
                    }


                }
            }
        }




    }
}
