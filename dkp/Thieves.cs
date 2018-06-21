using System;
using System.Collections.Generic;

namespace dkp
{
    class Thieves
    {
        private List<Thief> robbers;
        private readonly int defaultpopsize;

        public Thieves(int popsize, int lootsize)
        {
            Random rnd = new Random();
            defaultpopsize = popsize;
            Robbers = new List<Thief>();
            for(int i = 0; i < popsize; i++)
            {
                Robbers.Add(new Thief(lootsize));
            }
        }

        public List<Thief> Robbers { get => robbers; set => robbers = value; }

        public bool IsRefilled => defaultpopsize == robbers.Count;

        public int PopsLeft => robbers.Count;
    }
}