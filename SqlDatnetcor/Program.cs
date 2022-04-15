using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlDatnetcor
{
    class Program
    {
        private static string connectionString = @"Server=DESKTOP-8UR34SM;Database=Cinema;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //GetActorsById(1);

            //CreateActors("Shemi", "Amanov", 19);
            //DeleteActors(2);
            //GetGeneresById(3);
            //DeleteGenerec(2);
            CreateHalls("zal15", 13);

        }
        static void GetActorsById(int Id)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SqlCommand comm = new SqlCommand();
                conn.Open();
                string commit = $"SELECT * FROM Actors WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    string result = comm.ExecuteNonQuery().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void CreateActors(string name, string surname, int age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commit = $"INSERT INTO Actors VALUES(N'{name}',N'{surname}',N'{age}')";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    Console.WriteLine(comm.ExecuteNonQuery());
                }
            }
        }
        static void SelectActors(string name, string surname, int age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commit = $"SELCT *FROM Actors";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    Console.WriteLine();
                }
            }
        }
        static void DeleteActors(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String command = $"DELETE Actors WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    try
                    {
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Actors deletd");
                        }

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("Actor not found");
                    }
                }
            }
        }
        static void GetGeneresById(int Id)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SqlCommand comm = new SqlCommand();
                conn.Open();
                string commit = $"SELECT * FROM Generec WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {

                    string result = comm.ExecuteNonQuery().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void CreateGenerec(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commit = $"INSSERT INTO Generec values(N'{name})'";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    string result = comm.ExecuteNonQuery().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void DeleteGenerec(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String command = $"DELETE Generec WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    try
                    {
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Generec deletd");
                        }

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("Generec not found");
                    }
                }
            }
        }
        static void SelectGenerec(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commit = $"SELECT * FROM Generec";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetInt32("Id")+"." +reader.GetString("Name"));
                        }
                    }
                }
            }
        }
        static void GetHallsById(int Id)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SqlCommand comm = new SqlCommand();
                conn.Open();
                string commit = $"SELECT * FROM Halls WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    string result = comm.ExecuteNonQuery().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void CreateHalls(string name,  int SeatCount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commit = $"INSERT INTO Halls VALUES(N'{name}',N'{SeatCount}')";
                using (SqlCommand comm = new SqlCommand(commit, conn))
                {
                    Console.WriteLine(comm.ExecuteNonQuery());
                }
            }
        }
        static void DeleteHalls(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String command = $"DELETE Halls WHERE Id={Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    try
                    {
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Halls deletd");
                        }

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("Halls not found");
                    }
                }
            }
        }
        static void GetUpdateHalls(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String command = $"UPDATE Halls SET Name='QALA' WHERE Id={Id}";
                 using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    Console.WriteLine(comm.ExecuteNonQuery());
                }
            }
        }
    }
}
