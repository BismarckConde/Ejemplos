int a, b;

Console.WriteLine(" ESCRIBA EL PRIMER NUMERO DEL 1 AL 100 ");
a= int.Parse(Console.ReadLine());

Console.WriteLine(" ESCRIBA EL SEGUNDO NUMERO DEL 1 AL 100 ");
b= int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine(" EL NUMERO {0} ES MAYOR QUE {1} " ,a,b);
}
if (a == b)
{
    Console.WriteLine(" EL NUMERO {0} ES IGUAL QUE {1} ", a, b);
}
else 
{
    Console.WriteLine(" EL NUMERO {0} ES MENOR QUE {1} " ,b,a);
}
Console.WriteLine(" FIN DEL PROGRAMA....");
Console.ReadKey();



