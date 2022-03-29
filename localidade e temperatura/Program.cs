using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localidade_e_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0; 
            int n1 = 0;
            string local = "";
            string localmaior = "";
            int conttempmaior = 0;
            int conttempmenor = 0;
            int tempmaior = 0;
            int média = 0;

            Console.WriteLine("Introduz a quantidade de localidades e temperatura: ");
            n1 = int.Parse(Console.ReadLine());

            for(int i = 0; i < n1; i++)
            {

                Console.WriteLine("introduz a localidade: ");
                local = string.Format(Console.ReadLine());

                Console.WriteLine("Introduz a temperatura: ");
                temp = int.Parse(Console.ReadLine());
               
                if (temp >= 0)
                {
                    conttempmaior++;
                }   
                if(temp < 0)
                {
                    conttempmenor++;
                }
                if(temp > tempmaior)
                {
                    tempmaior = temp;
                    localmaior = local;
                }
                
            }
            média = média / 5;

            Console.WriteLine($"Foram introduzidas {conttempmaior} temperaturas superiores ou iguais");
            Console.WriteLine($"A temperatura menor é: {conttempmenor}");
            Console.WriteLine("A média das temperaturas é: " + média);
            Console.WriteLine("O local com maior temperatura é: " + localmaior);

            Console.ReadKey();


        }
    }
}