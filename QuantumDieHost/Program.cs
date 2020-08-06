using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using PereyraGamboa.Quantum.QuantumDieLib;

namespace QuantumDieHost
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            int[] res = new int[6];
            
            if (args == null || args.Length == 0 || !int.TryParse(args[0], out times)) {
                times = 1000;
            }

            using (var qsim = new QuantumSimulator())
            {
                for (int i = 0; i < times; i++)
                {
                    int die = (int)QuantumDie.Run(qsim).Result;
                    res[die]++;
                }
            }

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(
                    "{0} = {1} / {2} ({3:0.00%)}", 
                    i + 1, res[i], times, (float)res[i] / times);
            }
        }
    }
}
