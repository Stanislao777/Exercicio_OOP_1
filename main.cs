using System;

class Program
{
	static void Main(string[] args)
	{
		Mujer Empleada = new Mujer();
		Empleada.nombre="Geraldine Tapia";
		Empleada.direccion = "Av. Ayacucho Calle 2-x z.15, Bolivia";
		Empleada.telefono = "78483148";

		Console.WriteLine("El nombre de la empleada es: " +Empleada.nombre);
		Console.WriteLine("La dirección de la empleada es: " +Empleada.direccion);
		Console.WriteLine("El telefono de la empleada es: " +Empleada.telefono);
		Console.WriteLine("Saludo---------:");

		Empleada.saludar();

		Console.WriteLine("\n**************************");
		Console.WriteLine("**************************\n");

		Hombre Cliente = new Hombre();
		Cliente.nombre="Estaban Cardenas Ticona";
		Cliente.direccion = "Av. Aniceto Arce Calle 2 z.108, Bolivia";
		Cliente.telefono = "12345878";

		Console.WriteLine("El nombre del cliente es: " +Cliente.nombre);
		Console.WriteLine("La dirección del cliente es: " +Cliente.direccion);
		Console.WriteLine("El telefono del cliente es: " +Cliente.telefono);
		Console.WriteLine("Saludo---------:");

		Cliente.saludar();

		Console.ReadKey();				
	}
}