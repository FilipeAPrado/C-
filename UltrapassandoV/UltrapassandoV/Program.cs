/**********************************************************************************************
 *
 * 3/5 - Ultrapassando V  
 *
 ******************************** Desafio:
 *
 *      Como um bom desenvolvedor, você precisa fazer um programa que leia dois ingeiros: R e V 
 * (devem ser lidos tantos valores para V quantos necessários, até que seja digitado um valor 
 * maior do que R para ele). Conte quantos números inteiros devem ser somados em sequência 
 * (considerando o R nesta soma) para que a soma ultrapasse a V o mínimo possível. Escreva o 
 * valor final da contagem.
 *
 *      A entrada pode conter, por exemplo, os valores 21 21 15 30. Neste caso, é então assumido 
 * o valor 21 para R enquanto os valores 21 e 15 devem ser desconsiderados pois são menores ou 
 * iguais a R. Como o valor 30 está dentro da especificação (maior do que R) ele será válido e 
 * então deve-se processar os cálculos para apresentar na saída o valor 2, pois é a quantidade 
 * de valores somados para se produzir um valor maior do que 30 (21 + 22).
 *
 ******************************** Entrada:
 *
 *      A entrada contém somente valores inteiros, um por linha, podendo ser positivos ou 
 * negativos. O primeiro valor da entrada será o valor de R. A próxima linha da entrada irá 
 * conter V. Se V não atender a especificação do problema, ele deverá ser lido novamente, tantas 
 * vezes quantas forem necessárias.
 *
 ******************************** Saída:
 *
 *      Imprima uma linha com um número inteiro que representa a quantidade de números inteiros 
 * que devem ser somadas, de acordo com a especificação acima.
 *
 **********************************************************************************************/
using System;

namespace UltrapassandoV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for R: ");
            int r = Int32.Parse(Console.ReadLine());
            int v = 0;


            do
            {
                Console.WriteLine("Enter a number for V: ");
                v = Int32.Parse(Console.ReadLine());

            } while (r >= v);

            int result = 1;
            int sumOfR = r;

            while(sumOfR <= v)
            {
                r = r + 1;
                sumOfR = sumOfR + r ;
                result++;

            }

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
