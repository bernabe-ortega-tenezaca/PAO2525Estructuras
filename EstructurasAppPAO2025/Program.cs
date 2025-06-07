Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================");
Console.WriteLine();

Console.WriteLine("el perimetro de un cuadrado de lado 5 es " + perimetroCuadrado(5));
Console.WriteLine("el área de un cuadrado de lado 5 es " + areaCuadrado(5));

//int a = 56;
//int b = -20;
//Console.WriteLine(a + b);
//System.Console.WriteLine(suma(3, 4));
//System.Console.WriteLine(suma(4, 7));
//System.Console.WriteLine("La suma es: " + suma(2, 1));
//System.Console.WriteLine("La suma de " + a + " y " + b + " es: " + suma(a, b));


//Crear una función de suma
//int suma (int a, int b)
//{
//    return a + b;
//}

//función para calcular el perimetro de un cuadrado o rectangulo
double perimetroCuadrado(double lado)
{
    return lado + lado + lado + lado;
}

double areaCuadrado(double lado)
{
    return lado * lado;
}