using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_master_detail_AndreLussier
{
    public class Movie
    {
        public string Name { get; set; }
        public int RottenTomatoesScore { get; set; }
        public string Review { get; set; }

        public override string ToString()
        {
            return Name; 
        }
    }
}
