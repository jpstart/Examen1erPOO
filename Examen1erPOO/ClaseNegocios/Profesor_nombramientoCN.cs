using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erPOO.ClaseNegocios
{
    public class Profesor_nombramientoCN:ProfesorCN
    {
		public Profesor_nombramientoCN()
		{
		}
		public Profesor_nombramientoCN(String nombre, String apellido, String direccion, String cedula, Double sueldo)
		{
			this.Nombres = nombre;
			this.Apellidos = apellido;
			this.Direccion = direccion;
			this.Cedula = cedula;
			this.Sueldo = sueldo;
		}


		public override Double CalcularSueldo()
		{
			return this.Sueldo;
		}
	}
}
