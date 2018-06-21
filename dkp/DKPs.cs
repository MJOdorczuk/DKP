using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dkp
{
    class DKPs
    {
        private const int MAXVALUE = 100;
        private const int ROULETTE = 0;
        private const int JOUST = 1;
        private const int RANK = 2;
        private Func<Thieves, bool> fitness;
        private Func<Thieves, bool> selection;
        private Func<Thieves, bool> breeder;
        private Func<Thieves, bool> mutator;
        private float breedgrade;
        private float mutategrade;
        internal Thieves pops;
        private List<Tuple<int, int>> loot;
        private int popsize;
        private int bagLimit;
        private int numofgens;
        private int lootsize;
        private int genCnt;
        private int spaceTaken;

        public DKPs()
        {
            Popsize = 100;
            BagLimit = 150;
            Numofgens = 1000;
            Lootsize = 100;
            loot = LootGenerator(Lootsize, BagLimit);
            Fitness = FitnessGenerator(bagLimit, loot.Count);
            Selection = RouletteGenerator();
            Breeder = BreederGenerator(1);
            Mutator = MutatorGenerator(loot.Count / 30);
            Breedgrade = 0.8f;
            Mutategrade = 0.005f;
            GeneratePop(Popsize, Lootsize);
            GenCnt = 0;
        }

        public Func<Thieves, bool> Fitness { get => fitness; set => fitness = value; }
        public Func<Thieves, bool> Selection { get => selection; set => selection = value; }
        public Func<Thieves, bool> Breeder { get => breeder; set => breeder = value; }
        public Func<Thieves, bool> Mutator { get => mutator; set => mutator = value; }
        public float Breedgrade { get => breedgrade; set => breedgrade = value; }
        public float Mutategrade { get => mutategrade; set => mutategrade = value; }
        public List<Tuple<int, int>> Loot { get => loot; set => loot = value; }
        public int Popsize { get => popsize; set => popsize = value; }
        public int BagLimit { get => bagLimit; set => bagLimit = value; }
        public int Numofgens { get => numofgens; set => numofgens = value; }
        public int Lootsize { get => lootsize; set => lootsize = value; }
        public int GenCnt { get => genCnt; set => genCnt = value; }

        public List<Tuple<int, int>> LootGenerator(int n, int maxmass)
        {
            List<Tuple<int, int>> ret = new List<Tuple<int, int>>(); //<weight,value>
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                ret.Add(new Tuple<int, int>(rand.Next(1,(int)(maxmass/50f)), rand.Next(1,MAXVALUE)));
            }
            return ret;
        }
        
        public void GeneratePop(int popsize, int lootsize)
        {
            this.pops = new Thieves(popsize, lootsize);
        }

        public void RefillPop()
        {
            Random rnd = new Random();
            while(!pops.IsRefilled)
            {
                double die = rnd.NextDouble();
                if(die <= breedgrade)
                {
                    Breeder(pops);
                }
                else if(die <= mutategrade + breedgrade)
                {
                    Mutator(pops);
                }
            }
        }

        public Func<Thieves, bool> FitnessGenerator(int maxmass, int lootsize)
        {
            return delegate (Thieves pops)
            {
                foreach(Thief pop in pops.Robbers)
                {
                    int fitness = 0;
                    int weight = 0;
                    for(int i = 0; i < loot.Count; i++)
                    {
                        fitness += loot[i].Item2 * pop.Chromosome[i];
                        weight += loot[i].Item1 * pop.Chromosome[i];
                    }
                    if (weight > BagLimit) fitness = 0;
                    else if (weight > SpaceTaken) SpaceTaken = weight;
                    pop.Fitness = fitness;
                }
                return true;
            };
        }

        public Tuple<int,float> MaxNMed(List<Thief> pops)
        {
            int popsize = pops.Count;
            int max = 0;
            float med = 0;
            foreach(Thief pop in pops)
            {
                if (pop.Fitness > max) max = pop.Fitness;
                med += pop.Fitness / popsize;
            }
            return new Tuple<int, float>(max, med);
        }

        public Func<Thieves, bool> RouletteGenerator()
        {
            return delegate (Thieves pops)
            {
                Random rnd = new Random();
                int totalFitness = 0;
                pops.Robbers.Sort((pop1, pop2) => pop1.Fitness.CompareTo(pop2.Fitness));
                foreach (Thief pop in pops.Robbers)
                {
                    totalFitness += pop.Fitness;
                }
                List<Thief> newpops = new List<Thief>();
                for (int i = 0; i < pops.Robbers.Count / 2; i++)
                {
                    int fitnessleft = (int)(((double)totalFitness) * rnd.NextDouble());
                    int index = -1;
                    while (totalFitness >= 0 && index < pops.Robbers.Count - 1)
                    {
                        index++;
                        fitnessleft -= pops.Robbers[index].Fitness;
                    }
                    if (index < 0) index = 0;
                    newpops.Add(pops.Robbers[index].Clone());
                }
                pops.Robbers = newpops;
                return true;
            };
        }

        public Func<Thieves,bool> JoustGenerator(int probe)
        {
            return delegate (Thieves pops)
            {
                Random rnd = new Random();
                List<Thief> knights;
                List<Thief> newpop = new List<Thief>();
                for(int i = 0; i < pops.Robbers.Count/2; i++)
                {
                    knights = new List<Thief>();
                    for(int j = 0; j < probe; j++)
                    {
                        knights.Add(pops.Robbers[rnd.Next(pops.Robbers.Count)].Clone());
                    }
                    knights.Sort((pop2, pop1) => pop1.Fitness.CompareTo(pop2.Fitness));
                    newpop.Add(knights[0]);
                }
                pops.Robbers = newpop;
                return true;
            };
        }

        public Func<Thieves,bool> RankGenerator()
        {
            return delegate (Thieves pops)
            {
                List<Thief> newpops = new List<Thief>();
                List<Thief> oldpops = pops.Robbers;
                
                oldpops.Sort((pop2, pop1) => pop1.Fitness.CompareTo(pop2.Fitness));
                int toAdd = 1;
                pops.Robbers = newpops;
                while (!pops.IsRefilled)
                {
                    for(int i = 0; i < toAdd && i < oldpops.Count && !pops.IsRefilled; i++)
                    {
                        pops.Robbers.Add(oldpops[i]);
                    }
                    toAdd++;
                }
                
                return true;
            };
        }

        public Func<Thieves, bool> BreederGenerator(int divides)
        {
            return delegate (Thieves pops)
            {
                Random rnd = new Random();
                int lootsize = pops.Robbers[0].Chromosome.Count;
                List<Thief> newpops = new List<Thief>();
                List<Thief> oldpops = pops.Robbers;
                foreach(Thief pop in pops.Robbers)
                {
                    newpops.Add(pop);
                }
                pops.Robbers = newpops;
                while(!pops.IsRefilled)
                {
                    Thief newpop = new Thief(lootsize);
                    Thief mom = oldpops[rnd.Next(0,oldpops.Count -1)];
                    Thief dad = oldpops[rnd.Next(0,oldpops.Count - 1)];
                    int limit = rnd.Next(lootsize);
                    List<int> dividers = new List<int>();
                    int last = 0;
                    for(int i = 0; i < divides; i++)
                    {
                        int newdiv = rnd.Next(last, lootsize);
                        dividers.Add(newdiv);
                        last = newdiv;
                    }
                    for(int i = 0; i < divides; i++)
                    {
                        int tmp = 0;
                        for (int j = tmp; j < dividers[i]; j++)
                        {
                            tmp = j;
                            if(i%2 == 0)
                            {
                                newpop.Chromosome[j] = mom.Chromosome[j];
                            }
                            else
                            {
                                newpop.Chromosome[j] = dad.Chromosome[j];
                            }
                        }
                    }
                    pops.Robbers.Add(newpop);
                }
                return true;
            };
        }

        public Func<Thieves, bool> MutatorGenerator(int mutations)
        {
            return delegate (Thieves pops)
            {
                Random rnd = new Random();
                int lootsize = pops.Robbers[0].Chromosome.Count;
                List<Thief> newpops = new List<Thief>();
                List<Thief> oldpops = pops.Robbers;
                foreach (Thief pop in pops.Robbers)
                {
                    newpops.Add(pop);
                }
                pops.Robbers = newpops;
                while(!pops.IsRefilled)
                {
                    Thief newpop = new Thief(lootsize);
                    Thief mom = pops.Robbers[rnd.Next(pops.Robbers.Count)];
                    for(int i = 0; i < lootsize; i++)
                    {
                        newpop.Chromosome[i] = mom.Chromosome[i];
                    }
                    for(int i = 0; i < mutations; i++)
                    {
                        int index = rnd.Next(lootsize);
                        if (newpop.Chromosome[index] == 0)
                        {
                            newpop.Chromosome[index] = 1;
                        }
                        else newpop.Chromosome[index] = 0;
                    }
                    pops.Robbers.Add(newpop);
                }
                return true;
            };
        }

        public Tuple<int, float> NextStep()
        {
            if(GenCnt < Numofgens)
            {
                RefillPop();
                Fitness(pops);
                Tuple<int, float> ret = MaxNMed(pops.Robbers);
                Selection(pops);
                GenCnt++;
                return ret;
            }
            return null;
        }

        public void Restart()
        {
            loot = LootGenerator(Lootsize, BagLimit);
            GeneratePop(Popsize, Lootsize);
            GenCnt = 0;
        }

        public bool LastGen => GenCnt == Numofgens;

        public int SpaceTaken { get => spaceTaken; set => spaceTaken = value; }
    }
}
