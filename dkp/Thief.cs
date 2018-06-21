using System;
using System.Collections.Generic;

namespace dkp
{
    class Thief
    {
        private List<int> chromosome;
        private int fitness;

        public Thief(int lootsize)
        {
            Chromosome = new List<int>();
            Random rnd = new Random(); 
            for(var i = 0; i < lootsize; i++)
            {
                Chromosome.Add(rnd.Next(0, 2));
            }
        }

        public List<int> Chromosome { get => chromosome; set => chromosome = value; }
        public int Fitness { get => fitness; set => fitness = value; }
        public Thief Clone()
        {
            Thief clone = new Thief(chromosome.Count);
            for(int i = 0; i < chromosome.Count; i++)
            {
                clone.chromosome[i] = this.chromosome[i];
            }
            clone.fitness = this.fitness;
            return clone;
        }
    }
}