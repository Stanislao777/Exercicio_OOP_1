using System;

class Mujer:Persona
{
	public override void saludar()
	{
		Console.WriteLine("Hello, nice to meet you, my name is: " + this.nombre);
		Console.WriteLine("- Ella es bilingüe");
	}
}