using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Examen1erPOO.ClaseNegocios
{
    public abstract class ProfesorCN
    {

        public String Nombres { get; set; }
		public String Apellidos { get; set; }
		public String Direccion { get; set; }
		public String Cedula { get; set; }
		public Double Sueldo { get; set; }

		public ProfesorCN()
		{
		}
		public ProfesorCN(String nombre, String apellido, String direccion, String cedula, Double sueldo)
		{
			this.Nombres = nombre;
			this.Apellidos = apellido;
			this.Direccion = direccion;
			this.Cedula = cedula;
			this.Sueldo = sueldo;
		}


		public void MostrarPropiedades()
		{
			foreach (PropertyInfo prop in this.GetType().GetProperties())
			{
				Console.WriteLine($"{prop.Name}: {prop.GetValue(this, null)}");
			}
		}

		public abstract Double CalcularSueldo();
	}
}
