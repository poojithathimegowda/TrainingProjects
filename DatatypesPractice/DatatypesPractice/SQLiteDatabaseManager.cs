


using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DatatypesPractice
{

    public class SQLiteDatabaseManager
    {
        private string connectionString = @"Data Source=C:\poojitha\Datatypepractice.db;Version=3;";

        public SQLiteDatabaseManager()
        {

        }

        protected void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        protected List<Dictionary<string, object>> ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            results.Add(row);
                        }
                    }
                }
            }
            return results;
        }

        protected void ExecuteUpdate(string query, Dictionary<string, object> parameters = null)
        {
            ExecuteNonQuery(query, parameters);
        }

        protected void ExecuteDelete(string query, Dictionary<string, object> parameters = null)
        {
            ExecuteNonQuery(query, parameters);
        }






        protected List<T> ExecuteQueryInClassType<T>(string query, Dictionary<string, object> parameters = null)
        {
            List<T> results = new List<T>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are any rows to read
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                T resultObject = Activator.CreateInstance<T>();
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    prop.SetValue(resultObject, Convert.ChangeType(reader[prop.Name], prop.PropertyType));
                                }
                                results.Add(resultObject);
                            }
                        }
                    }
                }
            }
            return results;
        }


    }
}
