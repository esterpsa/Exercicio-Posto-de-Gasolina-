using System;

namespace Exercicio_Posto_de_Gasolina_
{
    class Program
    {
        static void Main(string[] args)
        {
            double litro = 0;
    
            Console.WriteLine("Posto de Gasolina");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Escolha um combustível: G - Gasolina e A - Alcool");
            string resposta = Console.ReadLine();

            while(resposta != "G" && resposta != "A" ){
                Console.WriteLine("Tente novamente, opção inválida");
                Console.WriteLine("Selecione G para gasolina ou A para alcool");
                

            }

            Console.WriteLine("Informe a quantidade de litros: ");
            litro = double.Parse(Console.ReadLine());

            switch(resposta){

                case "G":
                if(litro <=20){
                double calculo = litro * 5.30;
                double desconto = calculo * 0.04;
                double reajuste = calculo - desconto;
                Console.WriteLine($"Parabéns! Você recebeu um desconto de 4%: ");
                Console.WriteLine("O valor a ser pago seria: "+calculo);
                Console.WriteLine("O valor do desconto é: "+desconto);
                Console.WriteLine("O valor a ser pago é: "+reajuste);
                }else{
                double calculo = litro * 5.30;
                double desconto = calculo * 0.06;
                double reajuste = calculo - desconto;
                Console.WriteLine("Parabéns! Você recebeu um desconto de 6%");
                Console.WriteLine("O valor a ser pago seria: "+calculo);
                Console.WriteLine("O valor do desconto é: "+desconto);
                Console.WriteLine("O valor a ser pago é: "+reajuste);
                }
                break;

                 case "A":
                if(litro <=20){
                double calculo = litro * 4.90;
                double desconto = calculo * 0.03;
                double reajuste = calculo - desconto;
                Console.WriteLine($"Parabéns! Você recebeu um desconto de 3%: ");
                Console.WriteLine("O valor a ser pago seria: "+calculo);
                Console.WriteLine("O valor do desconto é: "+desconto);
                Console.WriteLine("O valor a ser pago é: "+reajuste);
                }else{
                double calculo = litro * 4.90;
                double desconto = calculo * 0.05;
                double reajuste = calculo - desconto;
                Console.WriteLine("Parabéns! Você recebeu um desconto de 5%");
                Console.WriteLine("O valor a ser pago seria: "+calculo);
                Console.WriteLine("O valor do desconto é: "+desconto);
                Console.WriteLine("O valor a ser pago é: "+reajuste);
                }
                break;   
            }

        }
    }
}
