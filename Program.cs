using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
        }
        static void Ex1()
        {
            int num;
            int maior, menor;
            int i = 1;
            float md = 0;

            Console.WriteLine("Insira entre com um valor");
            num = int.Parse(Console.ReadLine());
            maior = num;
            menor = num;
            md = md + num;
            while (i <123)
            {
                Console.WriteLine("Insira entre com um valor");
                num = int.Parse(Console.ReadLine());
                if (maior < num) { 
                    maior = num;                    
                }
                if (menor > num)
                {
                    menor = num;                    
                }
                i++;           
                md = md + num;               
            }
            md = (md / 123);
            Console.WriteLine("O maior valor e: {0} e o menor valor foi: {1} e a media dos valores foi: {2}", maior, menor, md);
            Console.ReadKey();
        }
        static void Ex2()
        {
            int num;
            int i = 1;
            float md = 0;

            Console.WriteLine("Insira entre com um valor");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                md = md + num;
                Console.WriteLine("Insira entre com um valor");
                num = int.Parse(Console.ReadLine());
                i++;
            }
            md = md / (i - 1);
            Console.WriteLine("A media dos valores foi {0}", md);
            Console.ReadKey();
        }
        static void Ex3()
        {
            int X, Y;

            Console.WriteLine("Insira um valor de inicio:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor para o final");
            Y = int.Parse(Console.ReadLine());
            if (Y < X) {
                do {
                    Console.WriteLine("O valor para o final precisa ser maior que o inicial, insira novamente um valor");
                    Y = int.Parse(Console.ReadLine());
                } while (Y < X);
            }
            while (X <= Y) {
                if (X % 7 == 3)/*24*/ {
                    Console.WriteLine("{0}", X);
                }
                X++;
            }
            Console.ReadKey();
        }
        static void Ex4()
        {
            int i, a;
            int par = 0;
            int impar = 0;
            for (i = 1; i <= 97; i++) {
                Console.WriteLine("Insira os valores :\n");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                    par = par + a;
                if (a % 2 != 0)
                    impar = impar + a;
            }
            Console.WriteLine("A soma dos valores pares foi {0} e a soma dos valores impares foi {1}", par, impar);
            Console.ReadKey();
        }
        static void Ex5()
        {
            int P, i;
            Console.WriteLine("Insira um valor");
            P = int.Parse(Console.ReadLine());
            i = P;
            P = P * P;
            while (i <= P) {
                if (i % 2 != 0) {
                    if (i % 3 == 0 && i % 6 != 0) {
                        Console.WriteLine("{0}", i);
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
        static void Ex6()
        { 
            int x;
            char sim;
            int i=1;
            int j = 1;
            Console.WriteLine("Insira quantas repetições voce quer:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sera o simbolo:");
            sim = char.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (i=1; i <= x;i++)
            {
                for (j=1;j <= i;j++)
                {
                    Console.Write(sim);                   
                }
               Console.WriteLine("");                           
            }
            Console.ReadKey();
        } 
    }
}

