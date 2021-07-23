using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Extensora
    {

        /// <summary>
        /// Crea un backupXML pasandole una lista de automoviles como parametro
        /// </summary>
        /// <param name="path"></param>
        /// <param name="autos"></param>
        /// <returns></returns>
        public static bool crearBackUpXml(this string path, List<Automoviles> autos)        
        {
            Serializadora<List<string>> cars = new Serializadora<List<string>>();
            List<string> lista = new List<string>();
            foreach (Automoviles item in autos)
            {
                lista.Add(item.Informacion());              
            }
            if (path != "")
            {
                if (cars.Guardar(path + ".xml", lista))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            } else
            {
                if (cars.Guardar("Informe de las " + DateTime.Now.Hour.ToString() + ".xml", lista))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}
