using System;

abstract class Persona
{
	private string _nombre, _direccion;

	public virtual void saludar()
	{
		Console.WriteLine("Hola, un gusto saludarte, mi nombre es " + this.nombre);
	}

	public string telefono{set;get;}		

	public string direccion
	{
		set
		{
			this._direccion = value;
		}
		get
		{
			return this._direccion;
		}
	}

	public string nombre
	{
		set 
		{
			this._nombre = value;
		}
		get
		{
			return this._nombre;
		}
	}

}