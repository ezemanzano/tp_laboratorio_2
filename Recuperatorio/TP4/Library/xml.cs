using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Library
{
    public class Xml<T>
    {
        public void WriteXML(T objeto, string rutaCompleta)
        {

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(rutaCompleta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, objeto);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public T ReadXML(string rutaCompleta)
        {
            
            try
            {
                using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    return (T)ser.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}


  


