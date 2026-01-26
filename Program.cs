using System; //importa a biblioteca principal do windows para comandos de entrada e saida
class Program 
{
    static void Main()// este é o ponto de entrada: onde o computador começa a ler seu programa
    {

        //exibe uma mensagem de titulo na tela
        Console.WriteLine("--- Calculadora de Média Escolar---");


        //escreve na tela, mas deixa o cursor na mesma linha para você digitar na frente
        Console.Write("Digite o nome do aluno: ");
        // string: define que a variável 'nome' guardará um texto
        // Console.ReadLine(): pausa o programa e espera o usuário digitar algo e dar Enter
        string nome = Console.ReadLine();



        Console.Write("Digite a Nota 1: ");
         // double: define um número que pode ter vírgula (ex: 7.5)
        // double.Parse: transforma o TEXTO digitado pelo usuário em um NÚMERO real
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());


        // Realiza o cálculo matemático. Os parênteses garantem que a soma seja feita antes da divisão
        double media = (n1 + n2) / 2;


        // O símbolo '$' antes das aspas permite usar variáveis dentro do texto usando { }
        // O ':F2' dentro da chave formata o número para ter apenas 2 casas decimais
        Console.WriteLine($"\n0 aluno {nome} ficou com média {media:F2}");


        // IF/ELSE: Estrutura de decisão (Lógica Condicional)
        if (media >= 6 )
        {
            // Se a condição (media >= 6) for verdadeira, executa isso:
            Console.WriteLine("Situação: APROVADO!🚀");
        }
        else
        {
            // Se a condição for falsa, executa isso:
            Console.WriteLine("Situação: REPROVADO!📚 ");
        }
    }
}