int numero, resultado = 0;
int NumeroTabuada()
{
    Console.Write("Digite um número inteiro de 1 a 9, que você gostaria de saber a tabuada, e depois digite enter: ");
   
    return int.Parse(Console.ReadLine());

}


void ValorTabuada()
{
    numero = NumeroTabuada();
    Console.WriteLine("A tabuada desejada é: ");

    for (int i = 0; i <= 10; i++)
    {
        resultado = i * numero;

        Console.WriteLine($"{i} * {numero} = {resultado}");
    }
}


ValorTabuada();