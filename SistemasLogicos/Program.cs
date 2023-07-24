using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questao1();
            Console.ReadKey();
            Console.Clear();
            Questao2();
            Console.ReadKey();
            Console.Clear();
            Questao3();
            Console.ReadKey();
            Console.Clear();
            Questao4();
            Console.ReadKey();
            Console.Clear();
        }
        public static void Questao1()
        {
            Console.WriteLine("Informe um número para a sequencia Fibonacci:");
            int numFib = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(numFib));

        }
        public static int Fibonacci(int numFib)
        {
            int primNum = 0, segNum = 1, result = 0;

            for (int i = 0; i < numFib; i++)
            {
                result = primNum + segNum;
                primNum = segNum;
                segNum = result;
            }
            return result;
        }
        public static void Questao2()
        {
            Console.WriteLine("Informe o número que deseja fatorar:");
            float numFato = float.Parse(Console.ReadLine());

            Console.WriteLine(Fatorial(numFato));
        }
        public static float Fatorial(float numFato)
        {
            float fatorial = 1;
            for (float i = numFato; i > 1; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }
        public static void Questao3()
        {

            Console.WriteLine("Quantos alunos deseja fazer a media:");
            float numAlunos = int.Parse(Console.ReadLine());
            float mediaArit = 0, maiorMed = float.MinValue, menorMed = float.MaxValue, nota = 0;

            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine("Informe a nota do aluno:");
                nota = float.Parse(Console.ReadLine());
                mediaArit = mediaArit + nota / numAlunos;
                if (nota > maiorMed)
                {
                    maiorMed = nota;

                }
                if (nota < menorMed)
                {
                    menorMed = nota;
                }
            }
            Console.WriteLine($"A maior média foi:{maiorMed}, a menor foi: {menorMed} e a media Aritmetica foi: {mediaArit}");
        }
        public static void Questao4()
        {
            Console.WriteLine("Questão 4");
            int[] vetor = new int[10];
            int maior = 0, menor = int.MaxValue;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um número:");
                int num = int.Parse(Console.ReadLine());
                vetor[i] = num;

                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine($"O maior número é: {maior}, o menor é: {menor}");
            Console.WriteLine("O 5 elemento do vetor é: " + vetor[5]);


        }
    }
}
