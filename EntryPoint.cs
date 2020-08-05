// <copyright file="EntryPoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantumDie
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.Quantum.Simulation.Core;
    using Microsoft.Quantum.Simulation.Simulators;

    /// <summary>
    /// Entry point of the quantum host.
    /// </summary>
    public class EntryPoint
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        public static void Main()
        {
            int[] counts = new int[6];
            using (var qsim = new QuantumSimulator())
            {
                for (int i = 0; i < 600; i++)
                {
                    int result = (int)QuantumDie.Run(qsim).Result;
                    counts[result]++;
                }
            }

            int n = 0;
            foreach (int count in counts)
            {
                Console.WriteLine("{0} = {1} / 600", ++n, count);
            }
        }
    }
}
