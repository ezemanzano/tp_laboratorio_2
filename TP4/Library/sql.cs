using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class mySql
    {

        /// <summary>
        /// Limpia la tabla en la base de datos
        /// </summary>
        public static void LimpiarTabla()
        {
            SqlConnection connection = new SqlConnection(@" Server= . ;
               Database = TP_4  ; Trusted_connection = true; "); ;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();
                command.CommandText = "DELETE from tp4";
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Guarda el automovil en la base de datos
        /// </summary>
        /// <param name="Modelo"></param>
        /// <param name="Tipo"></param>
        /// <param name="Cilindrada"></param>
        /// <param name="Color"></param>
        /// <param name="Motor"></param>
        /// <param name="Tipo_modelo"></param>
        public static void Guardar(string Modelo, Automoviles.Tipo Tipo, int Cilindrada,  string Color, Automoviles.Motor Motor, Automoviles.TipoModelo Tipo_modelo)
        {
            SqlConnection connection = new SqlConnection(@" Server= . ;
               Database = TP_4  ; Trusted_connection = true; "); ;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();               
                command.CommandText = "INSERT INTO tp4 (Modelo, Tipo , Cilindrada, Color, Motor, Tipo_Modelo) VALUES (@Modelo, @Tipo , @Cilindrada,  @Color, @Motor, @Tipo_Modelo )";
                command.Parameters.AddWithValue("@Modelo", Modelo);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.Parameters.AddWithValue("@Cilindrada", Cilindrada);               
                command.Parameters.AddWithValue("@Color", Color);
                command.Parameters.AddWithValue("@Motor", Motor);
                command.Parameters.AddWithValue("@Tipo_Modelo", Tipo_modelo);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
            }

        }

     

      /// <summary>
      /// Lee un automovil de la base de datos
      /// </summary>
      /// <returns></returns>

        public static List<Automoviles> LeerAutomoviles()
        {
            List<Automoviles> automoviles = new List<Automoviles>();
            String connectionStr = @" Server= . ;
               Database = TP_4  ; Trusted_connection = true; ";
            Automoviles aux;
            Automoviles.Motor auxMotor;           
            Automoviles.TipoModelo auxTipoModelo;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT * FROM tp4");

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read() != false)
                    {
                        
                        int aux1 = ((int)dataReader["Tipo_modelo"]);
                        
                        if (aux1 == 0)
                        {
                            auxTipoModelo = Automoviles.TipoModelo.Base;
                        } else {
                            auxTipoModelo = Automoviles.TipoModelo.Full;
                        }

                        if ((int)dataReader["Motor"] == 0)
                        {
                            auxMotor = Automoviles.Motor.Nafta;
                        }
                        else if ((int)dataReader["Motor"] == 1)
                        {
                            auxMotor = Automoviles.Motor.Diesel;
                        }
                        else
                        {
                            auxMotor = Automoviles.Motor.Electrico;
                        }

                        if ((int)dataReader["Tipo"] == 0)
                        {
                          
                            aux = new Auto(dataReader["Modelo"].ToString(), dataReader["Color"].ToString(), (int)dataReader["Cilindrada"], Automoviles.Tipo.Auto, auxTipoModelo, auxMotor );                            
                        }
                        else if ((int)dataReader["Tipo"] == 1)
                        {
                            aux = new Suv(dataReader["Modelo"].ToString(), dataReader["Color"].ToString(), (int)dataReader["Cilindrada"], Automoviles.Tipo.Suv, auxTipoModelo, auxMotor);                        
                        }
                        else
                        {
                            aux = new Moto(dataReader["Modelo"].ToString(), dataReader["Color"].ToString(), (int)dataReader["Cilindrada"], Automoviles.Tipo.Moto, auxTipoModelo, auxMotor);                         
                        }

                        automoviles.Add(aux);
                    }
                    dataReader.Close();
                }
                return automoviles;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



    }
}
