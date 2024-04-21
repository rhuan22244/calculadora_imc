using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Solicitar o nome da pessoa
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            // Solicitar a idade da pessoa
            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            // Solicitar a altura da pessoa em metros
            Console.Write("Digite a altura da pessoa em metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Solicitar o peso da pessoa em quilogramas
            Console.Write("Digite o peso da pessoa em quilogramas: ");
            double peso = double.Parse(Console.ReadLine());

            // Calcular o IMC
            double imc = peso / (altura * altura);

            // Determinar a categoria de IMC
            string categoriaIMC;
            if (imc < 18.5)
            {
                categoriaIMC = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                categoriaIMC = "Normal";
            }
            else if (imc < 30)
            {
                categoriaIMC = "Sobrepeso";
            }
            else
            {
                categoriaIMC = "Obeso";
            }

            // Determinar a faixa etária
            string faixaEtaria;
            if (idade < 10)
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 20)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            // Mostrar o relatório
            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} - {categoriaIMC}");
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

            // Perguntar ao usuário se deseja gerar outro relatório
            Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() != "s")
            {
                break; // Encerrar o loop se a resposta não for "s"
            }

        } while (true);

        Console.WriteLine("Programa encerrado.");
    }
}
