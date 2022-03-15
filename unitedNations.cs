using System;
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
}