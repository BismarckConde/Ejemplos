int N;
Console.WriteLine(" INGRESE UN NUMERO  ");
N=int.Parse(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine(" EL NUMERO QUE INGRESO ES NEGATIVO... POR FAVOR INGRESE UN NUMERO POSITIVO ");
}
if (N == 0)
{
    Console.WriteLine(" LA DIVISION ENTRE 0 NO EXISTE... POR FAVOR INGRESE UN NUMERO MAYOR QUE 0");
}
else if (N % 2 == 0)
{
    Console.WriteLine(" EL NUMERO " + N + " ES PAR ");
    if (N >= 10 && N <= 100)
    {
        Console.WriteLine(" EL NUMERO "+N+ " ESTA EN EL RANGO DE 10 A 100");
    }
    else
    {
       Console.WriteLine(" EL NUMERO "+N+ " NO ESTA EN EL RANGO DE 10 A 100");
    }
}
else
{
    Console.WriteLine(" EL NUMERO "+N+ " ES IMPAR");
}
Console.ReadKey();