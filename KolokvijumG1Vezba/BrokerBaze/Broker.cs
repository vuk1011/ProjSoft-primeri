using Domen;
using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace BrokerBaze
{
    public class Broker
    {
        private const string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vezba;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void VratiSveProfesore(BindingList<Profesor> profesori)
        {
            using SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from profesori";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Profesor p = new Profesor();
                    p.Id = (long)reader["id"];
                    p.Ime = (string)reader["ime"];
                    p.Prezime = (string)reader["prezime"];
                    p.Zvanje = (string)reader["zvanje"];
                    p.Status = (string)reader["status"];

                    profesori.Add(p);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void UpdateProfesor(long id, string ime, string prezime, string zvanje)
        {
            using SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"update profesori set ime='{ime}', prezime='{prezime}', zvanje='{zvanje}' where id={id}";
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void VratiSvePredmete(BindingList<Predmet> predmeti)
        {
            using SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from predmeti";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Predmet p = new();
                    p.Id = (long)reader["id"];
                    p.Naziv = (string)reader["naziv"];
                    p.Espb = (int)reader["espb"];
                    predmeti.Add(p);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void VratiSvePP(BindingList<PP> ppovi, List<Predmet> predmeti, List<Profesor> profesori)
        {
            using SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from pp";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    long profesorId = (long)reader["profesor"];
                    long predmetId = (long)reader["predmet"];
                    PP pp = new();
                    pp.Predmet = predmeti.Find(pred => pred.Id == predmetId);
                    pp.Profesor = profesori.Find(prof => prof.Id == profesorId);
                    ppovi.Add(pp);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
