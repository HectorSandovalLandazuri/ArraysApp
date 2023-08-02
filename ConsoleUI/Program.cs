// See https://aka.ms/new-console-template for more information
string[] firstNames= new string[5];
firstNames[0] = "Héctor";
firstNames[1] = "Claudia";
firstNames[2] = "Bob";
firstNames[3] = "Manuel";
firstNames[4] = "Ricardo";
Console.WriteLine($"Mi arreglo es {firstNames[0]},{firstNames[1]},{firstNames[2]},{firstNames[3]},{firstNames[4]}");

string data = "Héctor,Tim,Claudia,Bob,Frank,Claudia";
string[] firstNames1=data.Split(',');
Console.WriteLine($"Mi arreglo es {firstNames1[0]},{firstNames1[1]},{firstNames1[2]},{firstNames1[3]},{firstNames1[4]},{firstNames1[5]}");

int[] ages=new int[3];
ages[0] = 20;
ages[1] = 30;
ages[2] = 15;
Console.WriteLine($"Mi arreglo de números es {ages[0]},{ages[1]},{ages[2]}");

string[] lastNames=new string[] {"Sandoval","Landázuri","Alvarado","Lizárraga"} ;
Console.WriteLine(lastNames[1]);

Console.Write("Son 5 opciones. Escoja un número del 0 al 4: ");
string nombre = Console.ReadLine();
bool nombreValido = int.TryParse(nombre, out int intNombre);
if (nombreValido)
{
    if (intNombre >= 0 && intNombre <= 4)
    {
        Console.WriteLine($"El nombre es {firstNames[intNombre]}");
    }
    else
    {
        Console.WriteLine("El número está fuera de rango");
    }
}else
{
    Console.WriteLine("El nombre seleccionado no es un entero");
}