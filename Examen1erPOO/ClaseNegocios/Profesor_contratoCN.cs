using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erPOO.ClaseNegocios
{
    public class Profesor_contratoCN:ProfesorCN
    {
        public double horas_extras { get; set; }
        public double total_salario { get; set; }
        public Profesor_contratoCN()
        {
        }
        public Profesor_contratoCN(String nombre, String apellido, String direccion, String cedula, Double sueldo)
        {
            this.Nombres = nombre;
            this.Apellidos = apellido;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Sueldo = sueldo;
        }

        public override Double CalcularSueldo()
        {
            this.total_salario = this.Sueldo + (this.Sueldo * this.horas_extras);
            return this.total_salario;
        }
    }
}
