using System.Security.Cryptography.X509Certificates;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1, val2;

            Console.WriteLine("Escreva a operação que deseja fazer: (adi) ou (sub)");
            string escolhaOperacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            val2 = double.Parse(Console.ReadLine());


            double sub = (int)val1 - val2;
            double adi = (int)val1 + val2;

            if (escolhaOperacao == "adi")
            {
                Console.WriteLine("A soma dos números é: " + adi);
            }
            else 
            {
                Console.WriteLine("A subtração dos números é: " + sub );
            }
        }
        


    }
}
