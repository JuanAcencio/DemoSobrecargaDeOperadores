using DemoSobrecargaDeOperadores_;

Console.WriteLine("Demostracion de la clase contador y el uso de la sobrecarga  de operadores.\n");

Contador c1 = new Contador(5); //El conteo inicia en 5
Console.WriteLine($"conteo actual de c1:{c1.Conteo}");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Siguiente valor de c1:{c1.GetNextValue()}");
}
Console.WriteLine($"Conteo actual de c1:{c1.Conteo}");

Contador c2 = new Contador(8);
Console.WriteLine($"conteo actual de c2:{c2.Conteo}");

Contador c3 = c1 + c2;
Console.WriteLine($"conteo actual de c3:{c3.Conteo}");

Contador c4 = c3 - c2;
Console.WriteLine($"conteo actual de c4:{c4.Conteo}");