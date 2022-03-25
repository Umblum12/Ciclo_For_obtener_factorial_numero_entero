// See https://aka.ms/new-console-template for more information
int n, cont, fact;
Console.WriteLine("Digite el valor de n: ");
n = Convert.ToInt32(Console.ReadLine());
if(n == 0)
{
    Console.WriteLine("El factorial de {0} es 1", n);
}
else
{
    fact = n;
    for (cont = n; cont > 1; cont--)
    {
        fact = fact * (cont - 1);
    }
    Console.WriteLine("El factorial de {0} es {1}", n, fact);
}
Console.ReadKey(true);
