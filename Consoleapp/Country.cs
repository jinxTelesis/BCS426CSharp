using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace hwk2Library_Andre_lussier
{
    [DataContract]
    public class Country
    {
        private string name;
        private string capital;
        private string region;
        private string subregion;
        private double population;
        private Currency currency;
        private Language language;

        public Country()
        {
            this.name = "United States";
            this.capital = "Washington DC";
            this.region = "North America";
            this.subregion = "Blank";
            this.population = 300;
            this.currency = new Currency();
            this.language = new Language();
        }

        public Country(Currency cur, Language lang)
        {
            this.name = "United States";
            this.capital = "Washington DC";
            this.region = "North America";
            this.subregion = "Blank";
            this.population = 300;
            this.currency = cur;
            this.language = lang;
        }

        public Country(String name, String cap, String reg,
            String sub, double pop, Currency cur, Language lang)
        {
            this.name = name;
            this.capital = cap;
            this.region = reg;
            this.subregion = sub;
            this.population = pop;
            this.currency = cur;
            this.language = lang;
        }


        [DataMember(Name="speed")]
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

        [DataMember(Name="capital")]
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

        [DataMember(Name="Region")]
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

        [DataMember(Name="subregion")]
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

        [DataMember(Name="population")]
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

        public override string ToString()
        {
            return "Country: " + this.name +
                "Capital: " + this.capital +
                "region: " + this.subregion +
                "subRegion " + this.subregion +
                "population " + this.population +
                currency.ToString() + language.ToString();
 
        }

    }
}
