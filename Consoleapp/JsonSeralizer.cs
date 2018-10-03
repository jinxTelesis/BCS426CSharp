using System;
using hwk2Library_Andre_lussier;
using System.Runtime.Serialization.Json; // dll for Json
using System.IO;
using hwk2Library_Andre_lussier;


namespace DresSearlizer
{

    public class JsonSeralizer
    {
        private String filename;
        private FileStream writer;
        private DataContractJsonSerializer ser;
        private Currency curP= new Currency();
        private Language langP = new Language();
        private Country countryP = new Country();

        public JsonSeralizer()
        {

        }
        

        public void setSerilizer(String filename, Object o)
        {
            this.filename = filename;

            writer = new FileStream(filename, FileMode.Create,
                FileAccess.Write);

            if (o.GetType() == curP.GetType())
            {
                o = (Currency)o;
                ser = new DataContractJsonSerializer(typeof(Currency));
                ser.WriteObject(writer, o);
                writer.Close();
            }

            if(o.GetType() == langP.GetType())
            {
                o = (Language)o;
                ser = new DataContractJsonSerializer(typeof(Language));
                ser.WriteObject(writer, o);
                writer.Close();
            }

            if(o.GetType() == countryP.GetType())
            {
                o = (Country)o;
                ser = new DataContractJsonSerializer(typeof(Country));
                ser.WriteObject(writer, o);
                writer.Close();
            }

            


        }
    }

}


