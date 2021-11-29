using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1erPOO.ClaseNegocios
{
    public class Profesor_horasCN:ProfesorCN
    {
        public double total_horas { get; set; }
        public double total_salario_horas { get; set; }
        public Profesor_horasCN()
        {
        }
        public Profesor_horasCN(String nombre, String apellido, String direccion, String cedula, Double sueldo)
        {
            this.Nombres = nombre;
            this.Apellidos = apellido;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Sueldo = sueldo;
        }

        public override Double CalcularSueldo()
        {
            this.total_salario_horas = this.Sueldo * this.total_horas;
            return this.total_salario_horas;
        }
    }
}
