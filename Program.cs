﻿using System;
using System.Collections.Generic;

namespace csPrac
{
    public class Un
    {
        // properties
        public List<string> Countries;

        //fields
        private List<String> _baddies = new List<string>();

        //constructor
        public Un(List<string> members)
        {
            Countries = members;
        }

        //methods
        public void admitBaddies(List<string> bads)
        {
            foreach (string evilPeep in bads)
            {
                _baddies.Add(evilPeep);
            }

            foreach (string nat in _baddies)
            {
                Console.WriteLine(nat);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
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

            for (int i = 0; i < 10; i++)
            {
                if (nums.Length < i)
                {
                    throw new Exception("outpaced array size");
                }
            }

        }
    }
}