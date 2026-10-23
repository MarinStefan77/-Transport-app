using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieTransport
{
    public class TransportRepository
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TransportDB.mdf;Integrated Security=True";
        public List<Sofer> GetSoferi()
        {
            List<Sofer> lista = new List<Sofer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nume, NumarPermis, Telefon FROM Soferi", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Sofer
                        {
                            Id = (int)reader["Id"],
                            Nume = reader["Nume"].ToString(),
                            NumarPermis = reader["NumarPermis"].ToString(),
                            Telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : ""
                        });
                    }
                }
            }
            return lista;
        }
        public void AddSofer(Sofer s)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Soferi (Nume, NumarPermis, Telefon) VALUES (@nume, @permis, @telefon)", conn);
                cmd.Parameters.AddWithValue("@nume", s.Nume);
                cmd.Parameters.AddWithValue("@permis", s.NumarPermis);
                cmd.Parameters.AddWithValue("@telefon", (object)s.Telefon ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Masina> GetMasini()
        {
            List<Masina> lista = new List<Masina>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, NumarInmatriculare, Marca, SoferId FROM Masini", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Masina
                        {
                            Id = (int)reader["Id"],
                            NumarInmatriculare = reader["NumarInmatriculare"].ToString(),
                            Marca = reader["Marca"].ToString(),
                            SoferId = reader["SoferId"] != DBNull.Value ? (int?)reader["SoferId"] : null
                        });
                    }
                }
            }
            return lista;
        }
        public void AddMasina(Masina m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Masini (NumarInmatriculare, Marca, SoferId) VALUES (@nr, @marca, @sid)", conn);
                cmd.Parameters.AddWithValue("@nr", m.NumarInmatriculare);
                cmd.Parameters.AddWithValue("@marca", m.Marca);
                cmd.Parameters.AddWithValue("@sid", (object)m.SoferId ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddRuta(Ruta r)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rute (Destinatie, DistantaKm, MasinaId) VALUES (@dest, @dist, @mid)", conn);
                cmd.Parameters.AddWithValue("@dest", r.Destinatie);
                cmd.Parameters.AddWithValue("@dist", r.DistantaKm);
                cmd.Parameters.AddWithValue("@mid", r.MasinaId);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddMarfa(Marfa m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Marfa (Denumire, GreutateKg, RutaId) VALUES (@den, @gr, @rid)", conn);
                cmd.Parameters.AddWithValue("@den", m.Denumire);
                cmd.Parameters.AddWithValue("@gr", m.GreutateKg);
                cmd.Parameters.AddWithValue("@rid", m.RutaId);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Ruta> GetRute()
        {
            List<Ruta> lista = new List<Ruta>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Destinatie, DistantaKm, MasinaId FROM Rute", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Ruta
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Destinatie = reader["Destinatie"].ToString(),
                            DistantaKm = Convert.ToInt32(reader["DistantaKm"]),
                            MasinaId = Convert.ToInt32(reader["MasinaId"])
                        });
                    }
                }
            }
            return lista;
        }
        public List<Marfa> GetMarfa()
        {
            List<Marfa> lista = new List<Marfa>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Denumire, GreutateKg, RutaId FROM Marfa", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Marfa
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Denumire = reader["Denumire"].ToString(),
                            GreutateKg = Convert.ToDouble(reader["GreutateKg"]),
                            RutaId = Convert.ToInt32(reader["RutaId"])
                        });
                    }
                }
            }
            return lista;
        }
        public void DeleteSofer(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Soferi WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMasina(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Masini WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteRuta(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Rute WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteMarfa(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Marfa WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateSofer(Sofer s)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Soferi SET Nume=@nume, NumarPermis=@permis, Telefon=@telefon WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", s.Id);
                cmd.Parameters.AddWithValue("@nume", s.Nume);
                cmd.Parameters.AddWithValue("@permis", s.NumarPermis);
                cmd.Parameters.AddWithValue("@telefon", (object)s.Telefon ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateMasina(Masina m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Masini SET NumarInmatriculare=@nr, Marca=@marca, SoferId=@sid WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@nr", m.NumarInmatriculare);
                cmd.Parameters.AddWithValue("@marca", m.Marca);
                cmd.Parameters.AddWithValue("@sid", (object)m.SoferId ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateRuta(Ruta r)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Rute SET Destinatie=@dest, DistantaKm=@dist, MasinaId=@mid WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", r.Id);
                cmd.Parameters.AddWithValue("@dest", r.Destinatie);
                cmd.Parameters.AddWithValue("@dist", r.DistantaKm);
                cmd.Parameters.AddWithValue("@mid", r.MasinaId);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateMarfa(Marfa m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Marfa SET Denumire=@den, GreutateKg=@gr, RutaId=@rid WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@den", m.Denumire);
                cmd.Parameters.AddWithValue("@gr", m.GreutateKg);
                cmd.Parameters.AddWithValue("@rid", m.RutaId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}