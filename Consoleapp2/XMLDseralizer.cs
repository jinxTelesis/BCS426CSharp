using System;
using hwk2Library_Andre_lussier;
using System.Runtime.Serialization; // dll for Json
using System.IO;


namespace MyXMLDeSerNamespace {

    public class JsonDseralizer
    {
        private String filename;
        private FileStream reader;
        //private DataContractJsonSerializer ser;
        private Currency curP = new Currency(); // these are for the type comparison, think this should be reflections? 
        private Language langP = new Language(); // but I don't know about that yet, just coded a lot of dynamic type checking
        private Country countryP = new Country(); // python so this felt right



        public JsonDseralizer()
        {

        }

        public void setdeserilizer(String filename, Object o)
        {
            this.filename = filename;

            reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            if (o.GetType() == curP.GetType())
            {
                o = (Currency)o;
                DataContractSerializer inputSerializer;
                inputSerializer = new DataContractSerializer(typeof(Currency));

                curP = (Currency)inputSerializer.ReadObject(reader);
                reader.Close();


            }

            if (o.GetType() == langP.GetType())
            {
                o = (Language)o;
                DataContractSerializer inputSerializer;
                inputSerializer = new DataContractSerializer(typeof(Language));
                langP = (Language)inputSerializer.ReadObject(reader);
                reader.Close();

            }

            if (o.GetType() == countryP.GetType())
            {
                o = (Country)o;
                DataContractSerializer inputSerializer;
                inputSerializer = new DataContractSerializer(typeof(Country));
                countryP = (Country)inputSerializer.ReadObject(reader);
                reader.Close();

            }


        }

    }
}


