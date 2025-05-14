Console.Clear();

double numero, resultado;

Console.Write("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());

resultado = numero % 2;

if (resultado != 0){
    Console.WriteLine($"{numero} é ímpar");
}
else
{
     Console.WriteLine($"{numero} é par");
}
