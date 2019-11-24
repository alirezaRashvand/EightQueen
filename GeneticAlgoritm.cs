using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueen
{
    struct chromosome
    {
        public int[] gene;
        public int fitness;
    }
    class GeneticAlgoritm
    {
        private Random random;
        private List<chromosome> population;
        private bool Optimized_mode;

        public GeneticAlgoritm()
        {
            random = new Random();
        }

        public List<chromosome> Get_population()
        {
            return population;
        }

        public void Start(int Popsize, int Generation, double CrossProb, double MutationProb, bool isOptimized)
        {
            Optimized_mode = isOptimized;
            population = GetInitialPopulation(Popsize);
            CalcuteFitness(ref population);
            for (int i = 0; i < Generation; i++)
            {
                if (population[0].fitness == 0)
                    break;
                crossover(ref population, CrossProb);
                Mutation(ref population, MutationProb);
                CalcuteFitness(ref population);
            }
        }


        public List<chromosome> GetInitialPopulation(int popsize)
        {
            List<chromosome> initpop = new List<chromosome>();
            if (!Optimized_mode)
            {
                for (int i = 0; i < popsize; i++)
                {
                    chromosome ch = new chromosome();
                    ch.gene = new int[8];
                    for (int k = 0; k < 8; k++)
                        ch.gene[k] = random.Next(8);
                    initpop.Add(ch);
                }
            }
            else
            {
                for (int i = 0; i < popsize; i++)
                {
                    List<int> t = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
                    chromosome ch = new chromosome();
                    ch.gene = new int[8];
                    for (int k = 0; k < 8; k++)
                    {
                        int x = random.Next(t.Count);
                        ch.gene[k] = t[x];
                        t.RemoveAt(x);
                    }
                    initpop.Add(ch);
                }
            }
            return initpop;
        }

        private void CalcuteFitness(ref List<chromosome> pop)
        {
            int collisions = 0;
            for (int k = 0; k < pop.Count; k++)
            {
                for (int i = 0; i < pop[k].gene.Length; i++)
                {
                    int m = i + pop[k].gene[i];
                    int n = i - pop[k].gene[i];
                    for (int j = 0; j < pop[k].gene.Length; j++)
                    {
                        if (j == i)
                            continue;

                        if (!Optimized_mode)
                            if (pop[k].gene[i] == pop[k].gene[j])
                                collisions++;

                        if (j + pop[k].gene[j] == m || j - pop[k].gene[j] == n)
                            collisions++;
                    }
                }

                chromosome temp = pop[k];
                temp.fitness = collisions;
                pop[k] = temp;
                collisions = 0;
            }
            pop.Sort(new FitnessComparator());
        }

        private void crossover(ref List<chromosome> Pop, double prob)
        {
            List<chromosome> tempPop = new List<chromosome>();

            for (int i = 0; i < Pop.Count; i++)
            {
                if (Compare_with_random_value(prob))
                {
                    chromosome x = get_Parents(Pop);
                    chromosome y = get_Parents(Pop);
                    chromosome child = new chromosome();
                    child.gene = new int[8];

                    if (!Optimized_mode)
                    {
                        int n = random.Next(8);
                        for (int p = 0; p < n; p++)
                            child.gene[p] = x.gene[p];
                        for (int q = n; q < child.gene.Length; q++)
                            child.gene[q] = y.gene[q];

                        tempPop.Add(child);
                    }
                    else
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (Compare_with_random_value(0.5))
                            {
                                for (int j = 0; j < x.gene.Length; j++)
                                    if (!child.gene.Contains(x.gene[j]))
                                    {
                                        child.gene[k] = x.gene[j];
                                        break;
                                    }
                            }
                            else
                            {
                                for (int j = 0; j < y.gene.Length; j++)
                                    if (!child.gene.Contains(y.gene[j]))
                                    {
                                        child.gene[k] = y.gene[j];
                                        break;
                                    }
                            }
                        }

                        tempPop.Add(child);
                    }
                }
                else
                {
                    chromosome z = get_Parents(Pop);
                    tempPop.Add(z);
                }
            }
            while (tempPop.Count > Pop.Count)
                tempPop.RemoveAt(random.Next(tempPop.Count));

            Pop = tempPop;
        }

        private void Mutation(ref List<chromosome> Pop, double prob)
        {
            List<chromosome> tempPop = new List<chromosome>();

            for (int i = 0; i < Pop.Count; i++)
            {
                chromosome temp = Pop[i];
                for (int j = 0; j < temp.gene.Length; j++)
                {
                    if (Compare_with_random_value(prob))
                    {
                        if (!Optimized_mode)
                        {
                            int p = random.Next(temp.gene.Length);
                            temp.gene[j] = p;
                        }
                        else
                        {
                            int p = random.Next(temp.gene.Length);
                            while (p == j)
                                p = random.Next(temp.gene.Length);

                            int t = temp.gene[j];
                            temp.gene[j] = temp.gene[p];
                            temp.gene[p] = t;
                        }
                    }
                }
                tempPop.Add(temp);
            }
            Pop = tempPop;
        }

        private chromosome get_Parents(List<chromosome> pop)
        {
            int index = random.Next(pop.Count / 2);
            return pop[index];
        }

        public bool Compare_with_random_value(double p)
        {
            if (random.NextDouble() <= p)
                return true;

            return false;
        }

        class FitnessComparator : Comparer<chromosome>
        {
            public override int Compare(chromosome x, chromosome y)
            {
                if (x.fitness == y.fitness)
                    return 0;
                else if (x.fitness < y.fitness)
                    return -1;
                else
                    return 1;
            }
        }
    }
}
