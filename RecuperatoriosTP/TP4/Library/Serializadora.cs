using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class Serializadora<T>
    {

        /// <summary>
        /// Serializador para guardar un archivo xml
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Guardar(string ruta, T t)
        {
            bool retorno = false;
            try
            {
                Xml<T> guardarT = new Xml<T>();
                guardarT.WriteXML(t, AppDomain.CurrentDomain.BaseDirectory + ruta);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        /// <summary>
        /// Serializador para leer un archivo xml
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public T Leer(string ruta)
        {
            T t = default(T);
            try
            {
                Xml<T> leerT = new Xml<T>();
                t = leerT.ReadXML(AppDomain.CurrentDomain.BaseDirectory + ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return t;
        }
    }
}
