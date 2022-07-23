using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número Binario: ");
            string numBinario = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}O decimal do binario digitado é: {parseBinToDec(numBinario)}");
        }

        static int parseBinToDec(string binario)
        {
            int atual = 0;
            int aux = 0;
            do
            {
                atual = (atual * 2) + int.Parse(binario[aux].ToString());
                aux++;
            } while (aux < binario.Length);

            return atual;
        }

    }
}
