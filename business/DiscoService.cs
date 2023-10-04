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
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("SELECT Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa FROM DISCOS");
                data.execRead();

                while (data.Reader.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Title = (string)data.Reader["Titulo"];
                    aux.LaunchDate = (DateTime)data.Reader["FechaLanzamiento"];
                    aux.NumberTrack = (int)data.Reader["CantidadCanciones"];
                    aux.UrlImage = (string)data.Reader["UrlImagenTapa"];

                    discoList.Add(aux);
                }

                return discoList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConn();
            }
        }            
    }
}
