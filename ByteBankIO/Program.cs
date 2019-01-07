using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankIO.Modelos;

namespace ByteBankIO
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoarquivo = "contas.txt";

            var contas = new List<ContaCorrente>();

            using (var fluxo = new FileStream(enderecoDoarquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    contas.Add(ConverterStreamParaContaCorrente(linha));
                    Console.WriteLine(linha);
                }
            }
            Separador();

            contas.ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }


        static ContaCorrente ConverterStreamParaContaCorrente(string linha)
        {
            var campos = linha.Split(' ');
            return new ContaCorrente(
                agencia: int.Parse(campos[0]),
                numero: int.Parse(campos[1]),
                saldo: double.Parse(campos[2]),
                titular: new Cliente(nome: campos[3])
                );
        }

    }
}
