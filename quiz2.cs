using System;
using System.Collections.Generic;

namespace quiz2
{
    class Rose
    {
        public int RoseID;
        public string rose;
        public string rosedescription;
        public int totalrose;
        public string roseheight;
        public string rosecircum;
        public List<Rose> Roses;
        public Rose(int ValueRoseID, string Valuerose, string Valuerosedescription, 
            int Valuetotalrose, string Valueroseheight, string Valuerosecircum)
        {
            RoseID = ValueRoseID;
            rose = Valuerose;
            rosedescription = Valuerosedescription;
            totalrose = Valuetotalrose;
            roseheight = Valueroseheight;
            rosecircum = Valuerosecircum;
            Roses = new List<Rose>();
        }
        public void sent()
        {
            Console.WriteLine("ID : {0}",this.RoseID);
            Console.WriteLine("rose : {0}", this.rose);
            Console.WriteLine("description : {0}", this.rosedescription);
            Console.WriteLine("amout : {0}", this.totalrose);
            Console.WriteLine("height : {0}", this.roseheight);
            Console.WriteLine("circum : {0}", this.rosecircum);
        }
    }
    class Sunflower
    {
        public int SunflowerID;
        public string sunflower;
        public string sfdescription;
        public int totalsf;
        public string sfheight;
        public string sfcircum;
        public List<Sunflower> Sunflowers;
        public Sunflower(int ValueSunflowerID, string Valuesunflower, string Valuesfdescription, 
            int Valuetotalsf, string Valuesfheight, string Valuesfcircum)
        {
            SunflowerID = ValueSunflowerID;
            sunflower = Valuesunflower;
            sfdescription = Valuesfdescription;
            totalsf = Valuetotalsf;
            sfheight = Valuesfheight;
            sfcircum = Valuesfcircum;
            Sunflowers = new List<Sunflower>();
        }
        public void sent()
        {
            Console.WriteLine("ID : {0}", this.SunflowerID);
            Console.WriteLine("rose : {0}", this.sunflower);
            Console.WriteLine("description : {0}", this.sfdescription);
            Console.WriteLine("amout : {0}", this.totalsf);
            Console.WriteLine("height : {0}", this.sfheight);
            Console.WriteLine("circum : {0}", this.sfcircum);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input total rose :");
        }
    }
}
