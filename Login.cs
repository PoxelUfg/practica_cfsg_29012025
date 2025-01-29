using System;

class Program
{
    static void Main()
    {
        string username = "usuario";
        string password = "contraseña123";

        Console.WriteLine("Ingrese su nombre de usuario:");
        string inputUsername = Console.ReadLine();

        Console.WriteLine("Ingrese su contraseña:");
        string inputPassword = Console.ReadLine();

        if (inputUsername == username && inputPassword == password)
        {
            Console.WriteLine("Inicio de sesión exitoso.");
        }
        else
        {
            Console.WriteLine("Error de inicio de sesión. Usuario o contraseña incorrectos.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}