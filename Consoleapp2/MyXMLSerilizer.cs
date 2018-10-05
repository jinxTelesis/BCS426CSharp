using System;
using hwk2Library_Andre_lussier;
using System.Runtime.Serialization; // dll for Json
using System.IO;


namespace MyXMLSerNamespace
{
    namespace DresSearlizer
    {

        public class MyXMLSerilizer
        {
            private String filename;
            private FileStream writer;
            private DataContractSerializer ser;
            private Currency curP = new Currency();
            private Language langP = new Language();
            private Country countryP = new Country();

            public MyXMLSerilizer()
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
                    ser = new DataContractSerializer(typeof(Currency));
                    ser.WriteObject(writer, o);
                    writer.Close();
                }

                if (o.GetType() == langP.GetType())
                {
                    o = (Language)o;
                    ser = new DataContractSerializer(typeof(Language));
                    ser.WriteObject(writer, o);
                    writer.Close();
                }

                if (o.GetType() == countryP.GetType())
                {
                    o = (Country)o;
                    ser = new DataContractSerializer(typeof(Country));
                    ser.WriteObject(writer, o);
                    writer.Close();
                }




            }
        }

    }
}


