using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwk2Library_Andre_lussier;
using System.Runtime.Serialization.Json; // dll for Json
using System.IO;
using DresSearlizer;
using DresDesearlizer;

namespace CountryConsoleAppAndreLussier_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency cu = new Currency();

            

            Language lang = new Language();

            Country country = new Country();
/*
            Country country = new Country
            {
                Name = "United States",
                Capitial = "Washington DC",
                Region = "North America",
                Subregion = "blank",
                CurrenyP = new Currency
                {
                    Code = "1",
                    Name = "Dollars",
                    Symbol = "$",
                },
                languageP = new Language
                {
                    Name = "English",
                    NativeName = "English",
                    Iso639_1 = "en",
                    Iso639_2 = "sp",
                },
            };
*/




            String filename = "TestCountry4.json";
            JsonSeralizer jw = new JsonSeralizer(); // could have kept it a normal type but that might be confusing
            jw.setSerilizer(filename, country);


            /*
                        FileStream writer = new FileStream(filename, FileMode.Create,
                            FileAccess.Write);

                        DataContractJsonSerializer ser;

                        ser = new DataContractJsonSerializer(typeof(Country));

                        ser.WriteObject(writer, country);
                        writer.Close();
                        */

            Country country2 = new Country();

            String filename2 = filename;

            JsonDseralizer myDese = new JsonDseralizer();

            myDese.setdeserilizer(filename2, country2); // needs type so this can't be uninitialized
            Console.WriteLine(country2.Region);


            /*
            FileStream reader = new FileStream(filename2, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Country));

            country2 = (Country)inputSerializer.ReadObject(reader);
            reader.Close();

            Console.WriteLine(country2.Region);
            */

            Console.ReadLine();
        }
    }
}
