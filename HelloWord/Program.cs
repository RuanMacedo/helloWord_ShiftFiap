using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario; //declarando uma variável do tipo string cujo nome é nomeUsuario.

            Console.WriteLine("Insira seu nome e pressione ENTER");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine("{0} parabéns pelo seu primeiro código!", nomeUsuario);

            
            // Segundo código

            string nomeFilme,sala,hora,data;

            Console.WriteLine("Insira o nome do filme:");
            nomeFilme = Console.ReadLine();

            Console.WriteLine("Insira a sala:");
            sala = Console.ReadLine();

            Console.WriteLine("Qual o horário do filme");
            hora = Console.ReadLine();

            Console.WriteLine("Data:");
            data = Console.ReadLine();

            Console.WriteLine("Seu ingresso para o filme {0}, sala {1}, no dia {2} às {3} foi confirmato!", nomeFilme, sala, data, hora);

        }
    }
}
