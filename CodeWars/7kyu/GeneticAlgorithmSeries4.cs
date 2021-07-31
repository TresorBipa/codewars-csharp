/*
https://www.codewars.com/kata/567b468357ed7411be00004a/csharp

7 kyu
Genetic Algorithm Series - #4 Get population and fitnesses

In a genetic algorithm, a population is a collection of candidates that may evolve toward a better solution.

We determine how close a chromosome is to a ideal solution by calculating its fitness. 
https://www.codewars.com/kata/567b468357ed7411be00004a/train You are given two parameters, 
the population containing all individuals and a function fitness that determines how close to the solution a chromosome is.

Your task is to return a collection containing an object with the chromosome and the calculated fitness.

[
  { chromosome: c, fitness: f },
  { chromosome: c, fitness: f },
  ...
]
Note: you have a pre-loaded class ChromosomeWrap and you should return a collection of it instead.

public class ChromosomeWrap
{
    public string Chromosome { get; set; }
    public double Fitness { get; set; }
}
See other katas from this series
Genetic Algorithm Series - #1 Generate
Genetic Algorithm Series - #2 Mutation
Genetic Algorithm Series - #3 Crossover
Genetic Algorithm Series - #4 Get population and fitnesses
Genetic Algorithm Series - #5 Roulette wheel selection
This kata is a piece of Binary Genetic Algorithm
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class GeneticAlgorithmSeries4
    {
        public class ChromosomeWrap
        {
            public string Chromosome { get; set; }
            public double Fitness { get; set; }
        }


        public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population,
            Func<string, double> fitness)
        {
            return population.Select(s => new ChromosomeWrap {Chromosome = s, Fitness = fitness(s)});
        }

        // public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population,
        //     Func<string, double> fitness)
        // {
        //     return population.Select(chromosome => new ChromosomeWrap()
        //     {
        //         Chromosome = chromosome,
        //         Fitness = fitness(chromosome)
        //     });
        // }
    }
}