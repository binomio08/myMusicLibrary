using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;
using System.Data.SqlClient;

namespace business
{
    public class DiscoService
    {
        public List<Disco> discoList()
        {
            List<Disco> discoList = new List<Disco>();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa FROM DISCOS";
                cmd.Connection = conn;  

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)reader["Id"];
                    aux.Title = (string)reader["Titulo"];
                    aux.LaunchDate = (DateTime)reader["FechaLanzamiento"];
                    aux.NumberTrack = (int)reader["CantidadCanciones"];
                    aux.UrlImage = (string)reader["UrlImagenTapa"];

                    discoList.Add(aux);
                }

                conn.Close();
                return discoList;
            }
            catch (Exception)
            {

                throw;
            }
        }            
    }
}
