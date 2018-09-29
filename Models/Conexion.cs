using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.Protocol;
using MySql.Data.Common;

namespace demowebmvc.Models
{
    public class Conexion
    {
        
        String url;
        MySqlConnection conection;

        public MySqlConnection Conectar()
        {

            try
            {
                url = "Server=(servidor); Port=(Numero de puerto); User=(Usuario); Password=(Contraseña); Database=(Base de datos)";
                conection = new MySqlConnection(url);
                return conection;
            }
            catch (Exception e)
            {
               String p= e.StackTrace;
                return null;
            }



            /* En caso se use SQL server:
            try
            {
                
                url = "DataSource=(Nombre del servidor);InitialCatalog=(Nombre de base de datos);User ID=(Nombre de usuario);Password=(Contraseña) ";
                connect = new SqlConnection(url);
                return connect;
            }
            catch (Exception e)
            {
                String p=  e.StackTrace;

                return null;
            }
            */
            
        }


    }
}
