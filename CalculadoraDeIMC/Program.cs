using System;
namespace CalculadoraDeIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Calculadora de IMC! Vejamos se você está com o físico em dia!");
            Console.WriteLine("Primeiramente digite seu Peso em KG (exemplo: 60kg e 500g digitar: 60.5)");
            //pergunta sobre quilôgrama e posteriormente a entrada de dados
            string KG = Console.ReadLine();
            //pergunta sobre a altura
            Console.WriteLine("Digite sua altura em metros (exemplo: 1m e 70cm digitar: 1.70");
            string Metros = Console.ReadLine();
            //realizando calculo do IMC
            //passando strings para inteiros
            decimal kg;
            decimal metros;
            //
            if(!decimal.TryParse(KG, out kg) || kg <= 0)
            {
                Console.WriteLine("Por favor, digite um número verdadeiro!");
                return;
            };
            if (!decimal.TryParse(Metros, out metros) || metros <= 0)
            {
                Console.WriteLine("Por favor, digite um número verdadeiro!");
                return;
            };
            //verificando transferencia
            
            //verificando resultados
            Console.WriteLine(kg);
            Console.WriteLine(metros);
            decimal IMC = (kg / (metros * metros))*1000m;
            //esse vezes 1000 serve para deixar na casa certa!
            //encontrando a situação física do usuário
            // o m é para indicar que se trata de decimal
            if (IMC < 18.5m)
            {
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra abaixo do peso!");
            }
            else if(IMC >= 18.5m && IMC <= 24.99m)
            {
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra em um peso adequado!");
            }
            else if(IMC >= 25 && IMC <= 29.99m)
            {
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra em sobrepeso!");
            }
            else if(IMC >= 30 && IMC <= 34.99m ){
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra em obesidade grau I!!");
            }
            else if(IMC >= 35 && IMC < 39.99m)
            {
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra em obesidade grau II!");
            }
            else
            {
                Console.WriteLine("Seu IMC é de:" + IMC + " Você se encontra em obesidade grau III!");
            }

        }
    }
}
