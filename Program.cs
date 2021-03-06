using System;
using System.Collections.Generic;
using System.Linq;

namespace csPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            // united  nations section/////////////////////////////////////////////////////////////////////////////////////////
            List<string> countries = new List<string>()
            {
                "Afghanistan","Albania","Algeria","Andorra","Angola","Antigua & Deps","Argentina","Armenia","Australia",
                "Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belgium","Belize","Benin","Bhutan",
                "Bolivia","Bosnia Herzegovina","Botswana","Brazil","Brunei","Bulgaria","Burkina","Burundi","Cambodia","Cameroon",
                "Canada","Cape Verde","Central African Rep","Chad","Chile","China","Colombia","Comoros","Congo","Congo {Democratic Rep}",
                "Costa Rica","Croatia","Cuba","Cyprus","Czech Republic","Denmark","Djibouti","Dominica","Dominican Republic","East Timor",
                "Ecuador","Egypt","El Salvador","Equatorial Guinea","Eritrea","Estonia","Ethiopia","Fiji","Finland","France","Gabon",
                "Gambia","Georgia","Germany","Ghana","Greece","Grenada","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Honduras",
                "Hungary","Iceland","India","Indonesia","Iran","Iraq","Ireland {Republic}","Israel","Italy","Ivory Coast","Jamaica",
                "Japan","Jordan","Kazakhstan","Kenya","Kiribati","Korea North","Korea South","Kosovo","Kuwait","Kyrgyzstan","Laos",
                "Latvia","Lebanon","Lesotho","Liberia","Libya","Liechtenstein","Lithuania","Luxembourg","Macedonia","Madagascar",
                "Malawi","Malaysia","Maldives","Mali","Malta","Marshall Islands","Mauritania","Mauritius","Mexico","Micronesia",
                "Moldova","Monaco","Mongolia","Montenegro","Morocco","Mozambique","Myanmar, {Burma}","Namibia","Nauru","Nepal",
                "Netherlands","New Zealand","Nicaragua","Niger","Nigeria","Norway","Oman","Pakistan","Palau","Panama","Papua New Guinea",
                "Paraguay","Peru","Philippines","Poland","Portugal","Qatar","Romania","Russian Federation","Rwanda","St Kitts & Nevis",
                "St Lucia","Saint Vincent & the Grenadines","Samoa","San Marino","Sao Tome & Principe","Saudi Arabia","Senegal","Serbia",
                "Seychelles","Sierra Leone","Singapore","Slovakia","Slovenia","Solomon Islands","Somalia","South Africa","South Sudan",
                "Spain","Sri Lanka","Sudan","Suriname","Swaziland","Sweden","Switzerland","Syria","Taiwan","Tajikistan","Tanzania",
                "Thailand","Togo","Tonga","Trinidad & Tobago","Tunisia","Turkey","Turkmenistan","Tuvalu","Uganda","Ukraine",
                "United Arab Emirates","United Kingdom","United States","Uruguay","Uzbekistan","Vanuatu","Vatican City","Venezuela",
                "Vietnam","Yemen","Zambia","Zimbabwe"
            };

            Un unitedNations = new Un(countries);

            List<string> BadActors = new List<string>()
            {
                "Russia", "China", "Iran", "North Korea", "Venezuela", "Cuba", "Pakistan", "Saudi Arabia", "Azerbaijan"
            };

            unitedNations.admitBaddies(BadActors);
            Console.WriteLine("\n\n");
            foreach (string name in unitedNations.Countries)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n\n");

            int[] nums = { 1, 2, 3 };
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(nums[i]);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message + "\n");
                }
            }

            /* for (int i = 0; i < 10; i++)
             {
                 if (nums.Length < i)
                 {
                     throw new Exception("outpaced array size");
                 }
             } */


            // animals section ///////////////////////////////////////////////////////////////////////////////////////////////////
            Tiger tony = new Tiger();
            tony.Name = "Tony";

            tony.speak();

            // transformers section -//////////////////-//////////////////////////////////////////////////////////////////////////////////////            
            AutoBot optimusPrime = new AutoBot("Optimus Prime");
            optimusPrime.Shape = "Truck";

            Decepticon megatron = new Decepticon()
            {
                Name = "Megatron",
                Shape = "Plane"
            };

            optimusPrime.Transform();
            megatron.Transform();

            Voltron voltron = new Voltron()
            {
                Name = "Voltron",
                Shape = "space ship"
            };

            voltron.Transform();
            // table and seating lightning exercise ////////////////////////////////////////////////////////////////////////////////////////

            Loveseat loveSeat = new Loveseat()
            {
                Name = "Herman's big chance"
            };
            DiningChair chaire = new DiningChair()
            {
                Name = "tossed salad feasting seat"
            };

            Nightstand one = new Nightstand()
            {
                Name = "uno"
            };
            DiningTable feast = new DiningTable()
            {
                Name = "Jeffery's minor delights table"
            };

            List<ISeating> chairs = new List<ISeating>()
            {
                loveSeat, chaire
            };
            List<ITable> tables = new List<ITable>()
            {
                one, feast
            };
            List<Furniture> furn = new List<Furniture>()
            {
                loveSeat, chaire, one, feast
            };

            foreach (ISeating seat in chairs)
            {
                Console.WriteLine(seat.hasArmRest);
            }
            foreach (ITable table in tables)
            {
                Console.WriteLine(table.width);
            }
            foreach (Furniture item in furn)
            {
                Console.WriteLine(item.Name);
            }
            // dictionaries //////////////////////////////////////////////////////////////////////////////////////////////////////
            Dictionary<string, int> ret = new Dictionary<string, int>()
            {
                {"Alfred" , 1},
                {"Bruce" , 2},
                {"Carrie", 3}
            };

            ret.Add("d", 4);


            foreach (KeyValuePair<string, int> i in ret)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }

            // Linq methods /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // iphone
            Iphone six = new Iphone(6.4);

            six.playSong();

            Jerry.terry();

            Crooner.jimmyJazz();

            Crooner x = new Crooner();
            x.bass();












        }
    }
}
