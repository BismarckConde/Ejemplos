using System.ComponentModel.Design;

double n1=0, n2=0;

Console.WriteLine(" INGRESA EL PRIMER NUMERO ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine(" INGRESA EL SEGUNDO NUMERO ");
n2 = double.Parse(Console.ReadLine());

if (n1 > n2)
{
    double suma = n1 + n2;
    double resta = n1 - n2;

    Console.WriteLine(" LA SUMA ES : " + suma);
    Console.WriteLine(" LA RESTA ES : " + resta);
}
else
{
    double pro = n1 * n2;
    if (n1 == 0 || n2 == 0)
    {
        Console.WriteLine(" LA DIVISION ENTRE 0 NO EXISTE...");
    }
    if (n1 !=0 && n2 != 0)
    {
        double divi = n1 / n2;
        Console.WriteLine(" LA DIVISION ES : "+divi);
       
    }
    Console.WriteLine(" EL PRODUCTO ES : " + pro);
    
}

