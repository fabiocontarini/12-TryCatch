//Exemplo de TryCatch com numerador e denominador
//O bloco try-catch em c# permite que você execute um bloco de código
//(try) que pode gerar excessões. Se uma excessão ocorrer, ela irá ser tratada no bloco catch



//exemplo 1 com valores inteiros

//try
//{
//    Console.Write("Digite o numerador: ");  // string "5" == int 5 
//    int numerador = int.Parse(Console.ReadLine());

//    Console.Write("Digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int resultado = numerador / denominador;
//    Console.WriteLine($"\nO resultado da divisão é: {resultado}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("\nERRO: Não é possível dividir por zero");
//}

//catch (FormatException)
//{
//    Console.WriteLine("\nERRO: Por favor digite numeros válidos");
//}

//exemplo 2 com casas decimais utilizando double e convertendo esses valores com o TryParse
using System.Globalization;

try
{
    Console.Write("Digite o numerador: ");  // string "5" == double 5 
    double numerador;
    //! Significa diferente
    while(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador ))
    {
        Console.WriteLine("ERRO: Digite um número válido.");
        Console.Write("\nDigite um número válido: ");
    }

    Console.Write("Digite o denominador: ");
    double denominador;

    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("ERRO: Digite um número válido.");
        Console.Write("\nDigite um número válido: ");
    }

    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double resultado = numerador / denominador;
    Console.WriteLine($"\nO resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\nERRO: Não é possível dividir por zero");
}

catch (FormatException)
{
    Console.WriteLine("\nERRO: Por favor digite numeros válidos");
}

Console.ReadKey();  