using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var linhas = File.ReadAllLines("contas.txt").ToList();

            linhas.ForEach(l => Console.WriteLine(l));

            Console.ReadLine();
        }

    }
}
