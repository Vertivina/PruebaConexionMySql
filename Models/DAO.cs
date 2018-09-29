using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace demowebmvc.Models
{
    public class DAO 
    {

        MySqlConnection conectar;
        Conexion con;
        String sql="";
        MySqlDataReader dr;
        MySqlCommand comando;
        
        
       
        public void registrar(String nom)
        {
            try
            {
                conectar = con.Conectar();
                conectar.Open();
                sql = "Insert into  (tabla) values (?,?,?,?)";
                //A diferencia de java, solo es necesario un string para hacer el comando              

                MySqlDataAdapter adaptador= new MySqlDataAdapter();
                comando = new MySqlCommand(sql,conectar);
                dr = comando.ExecuteReader();

                conectar.Close();
            }
            catch (Exception e)
            {
                String mens = e.StackTrace;
            }
           
            

        }

        public void registrarCita(Cita c)
        {
            try
            {
                if (c.direccion!= null)
                {
                    conectar = con.Conectar();
                    conectar.Open();
                    sql = "Insert into Cita values ('" + c.nombre + "','" + c.mascota + "','" + c.numTelefono + "','" + c.doctor
                        + "','" + c.hora + "','" + c.fecha + "','" + c.tipoM + "','" + c.tipoCita + "','" +c.direccion + "');";
                    //A diferencia de java, solo es necesario un string para hacer el comando              
                    comando = new MySqlCommand(sql, conectar);
                    dr = comando.ExecuteReader();
                }
                else
                {
                    conectar = con.Conectar();
                    conectar.Open();
                    sql = "Insert into Cita values ('"+c.nombre+"','"+c.mascota + "','" +c.numTelefono + "','" +c.doctor
                        + "','" +c.hora + "','" +c.fecha + "','" +c.tipoM + "','" +c.tipoCita+"');";
                    //A diferencia de java, solo es necesario un string para hacer el comando              
                    comando = new MySqlCommand(sql, conectar);
                    dr = comando.ExecuteReader();
                }
                

                conectar.Close();
            }
            catch (Exception e)
            {
                String mens = e.StackTrace;
            }



        }

        public void modificar()
        {
            try
            {
                sql = "Update (tabla) set v1=?, v2=?..... where cod=?";
                conectar = con.Conectar();
                conectar.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                comando = new MySqlCommand(sql, conectar);
                dr = comando.ExecuteReader();
                conectar.Close();


            }
            catch (Exception e)
            {
                String mens =e.StackTrace;
               

            }
           

        }

        public void eliminar(int cod)
        {
            try
            {
                
                conectar = con.Conectar();
                conectar.Open();
                sql = "Delete * from  (tabla) where cod= "+cod;

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                /*adaptador.selectCommand= comando; : el adaptador asigna su comando
                 DataTable d= new DataTable();: asigna una tabla nueva
                 adaptador.fill(d);:llena la tabla
                 [atributo].datasource=d; : asigna la fuente de informacion 
                 */
                comando = new MySqlCommand(sql, conectar);
                dr = comando.ExecuteReader();
                conectar.Close();

            }
            catch (Exception e)
            {
                String mens = e.StackTrace;
            }
           

        }





    }
}
