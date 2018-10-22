using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using System.Text; // this is needed for encoding 
//using hwk2Library_Andre_lussier;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Country countryTest = new Country();

            String filename = ""; // test
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read); // test
            StreamReader streamReader = new StreamReader(reader,Encoding.UTF8);
            string jsonString = streamReader.ReadToEnd();

            byte[] byteArray = Encoding.UTF8.GetBytes(jsonString);
            MemoryStream stream = new MemoryStream(byteArray);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Country));
            countryTest = (Country)inputSerializer.ReadObject(stream);
            stream.Close();




            Language sp = new Language();
            Language sp1 = new Language();

            Currency c1 = new Currency();
            Currency c2 = new Currency();

            //Console.WriteLine(sp.ToString());
            //Console.WriteLine(c1.ToString());


            List<Language> testLang = new List<Language>(10);
            testLang.Add(sp);
            testLang.Add(sp1);

            List<Currency> testCurr = new List<Currency>(10);
            testCurr.Add(c1);
            testCurr.Add(c2);

            Country testCuuntry = new Country("Texas", "Austin","North America","non",300,testCurr, testLang);

            //(String name, String cap, String reg,
            //String sub, double pop, List<Currency> cur, List<Language> lang)

            Console.WriteLine(testCuuntry.ToString());

            //country.langs = sp;
            //country.langs[1] = sp1;
            //country.curces[0] = c1;
            //country.curces[1] = c2;

            //Console.WriteLine(country.ToString());
            Console.ReadKey();
        }
    }

    
    public class Language
    {
        #region private member variables
        private string name;
        private string nativeName;
        private string iso639_1;
        private string iso639_2;

        #endregion

        //*********************************
        // default constructor for language
        // sets defaults to english 
        // and spanish as second
        //**********************************

        public Language()
        {
            this.name = "English";
            this.nativeName = "English2";
            this.iso639_1 = "en";
            this.iso639_2 = "es";
        }

        #region properties of Language
        /// <summary>
        ///  Properties for Language
        ///  basically getters and setter shorthand
        ///  for name
        /// </summary>

        
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        ///  Properties for Language
        ///  basically getters and setter shorthand
        ///  for nativeName
        /// </summary>

 
        public string NativeName
        {
            get
            {
                return this.nativeName;
            }

            set
            {
                this.nativeName = value;
            }
        }

        /// <summary>
        ///  Properties for Language
        ///  basically getters and setter shorthand
        ///  for .iso639_1
        /// </summary>


        public string Iso639_1
        {
            get
            {
                return this.iso639_1;
            }

            set
            {
                this.iso639_1 = value;
            }
        }

        /// <summary>
        ///  Properties for Language
        ///  basically getters and setter shorthand
        ///  for iso639_2;
        /// </summary>


        public string Iso639_2
        {
            get
            {
                return this.iso639_2;
            }

            set
            {
                this.iso639_2 = value;
            }
        }

        #endregion

        #region methods of Language

        /// <summary>
        ///  Method: ToString 
        ///  
        /// Purpose: Override of the objects default
        /// sets string to human readable form for name,
        /// nativeName, iso639_1, is0639_2
        /// updated to print unknown if null encountered
        /// will not throw exceptions
        /// null conditional check added to values that might not be null
        /// for consistency 
        /// 
        /// </summary>


        public override string ToString()
        {

            String s = "";

            if (this.name != null)
            {
                s += "Language name: " + this.name + "\n";
            }
            else
            {
                s += "Language name: unknown " + "\n";
            }

            if (this.NativeName != null)
            {
                s += "nativeName: " + this.nativeName + "\n";
            }
            else
            {
                s += "nativeName: unknown " + "\n";
            }

            if (this.Iso639_1 != null)
            {
                s += "iso639_1 is set to: " + this.iso639_1 + "\n";
            }
            else
            {
                s += "iso639_1 is set to: unknown " + "\n";
            }

            if (this.iso639_2 != null)
            {
                s += "iso639_2 is set to: " + this.iso639_2 + "\n";
            }
            else
            {
                s += "iso639_2 is set to: unknown " + "\n";
            }

            return s;
        }

        #endregion

    }


    public class Currency
    {
        #region private member variables
        private string code;
        private string name;
        private string symbol;

        #endregion
        //***********************
        // default constructor
        // sets values to U.S. defaults
        //
        //****************************
        public Currency()
        {
            this.code = "1"; // personally perfer always using this not matter the language
            this.name = "Dollars";
            this.symbol = "$";

        }

        #region properties of Currency

        //*********************************************
        // properties for Code shorthand getter/setter
        //*********************************************
        public string Code
        {

            get
            {
                return this.code;
            }

            set
            {
                this.code = value;
            }

        }

        //*********************************************
        // properties for Name shorthand getter/setter
        //*********************************************
        public string Name
        {

            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }

        //*********************************************
        // properties for Symbol shorthand getter/setter
        //*********************************************
        public string Symbol
        {

            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }

        }

        #endregion

        #region methods of Currency

        //******************************************
        // Method: ToString
        //
        // Purpose: to show code, name and symbol
        // to a string in an human readable form
        // will print out unknown if null values are found
        /// will not throw exceptions
        /// null conditional check added to values that might not be null
        // overrides object ToString
        //*******************************************

        public override string ToString()
        {
            String s = "";

            if (this.code != null)
            {
                s += "currency : " + this.code + "\n";
            }
            else
            {
                s += "currency code : unknown " + "\n";
            }

            if (this.name != null)
            {
                s += "currency name: " + this.name + "\n";
            }
            else
            {
                s += "currency symbol: unknown " + "\n";
            }

            if (this.symbol != null)
            {
                s += "currency symbol: " + this.symbol + "\n";
            }
            else
            {
                s += "currency symbol: unknown" + "\n";
            }

            return s;
        }

        #endregion

    }

   
    public class Country
    {
        /// <summary>
        /// the data members currency and language are user defined
        /// classes within the same project 
        /// 
        /// </summary>
        #region Private member variables of Country
        private string name;
        private string capital;
        private string region;
        private string subregion;
        private double population;
        private List<Currency> cur;
        private List<Language> lang;
        private Currency curObj;
        //private Currency curObj2;
        private Language langObj;
        
        
        #endregion end of Private member variables of Country
        /// <summary>
        /// Default constructor
        /// 
        /// Contains two user defined classe as well as the classes own properties
        /// User defined class currencies and languages
        /// </summary>

        public Country()
        {
            this.name = "United States";
            this.capital = "Washington DC";
            this.region = "North America";
            this.subregion = "Blank";
            this.population = 300;

            this.curObj = new Currency();
            this.langObj = new Language();
            cur = new List<Currency>();
            lang = new List<Language>();

        //this.curObj2 = new Currency();

            cur.Add(curObj);
            lang.Add(langObj);

        }

       
        /// <summary>
        /// Constructor that takes full input on each of the class members variables
        /// as well as object for the composition 
        /// </summary>
        /// <param name="name">sets name parameter</param> 
        /// <param name="cap">sets captial parameter</param>  
        /// <param name="reg">sets region parameter</param> 
        /// <param name="sub">sets subregion paramenter</param> 
        /// <param name="pop">sets population parameter</param> 
        /// <param name="csize">used to set amount of currenices in country constructor</param> 
        /// <param name="lsize">used to set amount of languages in country constructor</param> 
        /// 


        public Country(String name, String cap, String reg,
            String sub, double pop, List<Currency> cur, List<Language> lang)
        {
            this.name = name;
            this.capital = cap;
            this.region = reg;
            this.subregion = sub;
            this.population = pop;
            this.cur = cur;
            this.lang = lang;
           
        }

        

        /// <summary>
        ///  Properties for Country
        ///  basically getters and setter shorthand
        ///  for name
        /// </summary>
        /// 
        #region properties for Country

        /// <summary>
        ///  Properties for Country
        ///  basically getters and setter shorthand
        ///  for captial
        /// </summary>


        public string Capitial
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }

        }

        /// <summary>
        ///  Properties for Country
        ///  basically getters and setter shorthand
        ///  for Region
        /// </summary>

        
        public string Region
        {

            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }

        }

        /// <summary>
        ///  Properties for Country
        ///  basically getters and setter shorthand
        ///  for Subregion
        /// </summary>

        
        public string Subregion
        {

            get
            {
                return this.subregion;
            }

            set
            {
                this.subregion = value;
            }

        }

        /// <summary>
        ///  Properties for Country
        ///  basically getters and setter shorthand
        ///  for Population
        /// </summary>

       
        public double Population
        {

            get
            {
                return this.population;
            }

            set
            {
                this.population = value;
            }

        }

        /// <summary>
        ///  Auto-implemented Properties for Country
        ///  basically getters and setter shorthand
        ///  for the composition object ArrayList currencies of type Currency
        /// </summary>

        
        public Currency Currencies { get; set; }

        /// <summary>
        ///  Auto-implemented Properties for Country
        ///  basically getters and setter shorthand
        ///  for the composition object Arraylist lang of type Language
        /// </summary>

        
        public Language Languages { get; set; }

        /// <summary>
        ///  Method: ToString 
        ///  
        /// Purpose: Override of the objects default
        /// sets string to human readable form for name, captial
        /// subregion, population. calls currecy's ToString and languages.ToString
        /// for brevity
        /// realize some of the listed data was not declared to be null
        /// but thought it was more robust to always be able to address
        /// although null for the country name seems more questionable
        /// 
        /// </summary>

        #endregion end of properties for Country

        #region Methods of Country

        public override string ToString() // need to do null checking
        {
            String s = "";

            if (this.name != null)
            {
                s += "Country: " + this.name + "\n";
            }
            else
            {
                s += "Country: unknown \n";
            }

            if (this.capital != null)
            {
                s += "Capital: " + this.capital + "\n";
            }
            else
            {
                s += "Capital: unknown" + this.name +"\n";
            }

            if (this.region != null)
            {
                s += "region: " + this.region + "\n";
            }
            else
            {
                s += "region: unknown \n";
            }

            if (this.subregion != null)
            {
                s += "subregion: " + this.subregion + "\n";
            }
            else
            {
                s += "subregion: unknown \n";
            }

            s += "population " + this.population + "\n";

            //        foreach (Currency x in currencies)
            //        {
            //            s += x.ToString();
            //        }

            //        foreach (Language x in languages)
            //        {
            //            s += x.ToString();
            //        }


            foreach(Currency x in cur)
            {
                s += x.ToString();
            }

            foreach(Language y in lang)
            {
                s += y.ToString();
            }
            
            return s;
            //currency.ToString() + language.ToString();

        }

        #endregion end of Methods for Country

    }


}
