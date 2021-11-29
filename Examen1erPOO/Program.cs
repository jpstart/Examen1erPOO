using Examen1erPOO.ClaseNegocios;
using System;
using System.Collections.Generic;

namespace Examen1erPOO
{
    class Program
    {
        static List<ProfesorCN> lista = new List<ProfesorCN>();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int contador = 0;
            Profesor_contratoCN ProfesorContrato = new Profesor_contratoCN(
                "Profesor", "Contrato", "mi casita", "1234567890", 340);
            Profesor_horasCN ProfesorHoras = new Profesor_horasCN("Profesor", "Horas",
                "mi casita", "1234567890", 10);
            Profesor_nombramientoCN ProfesorNombreamiento = new Profesor_nombramientoCN("Profesor", "Nombramiento",
                "mi casita", "1234567890", 1500);
            ProfesorContrato.horas_extras = 20;
            ProfesorHoras.total_horas = 300;
            lista.Add(ProfesorContrato);
            lista.Add(ProfesorHoras);
            lista.Add(ProfesorNombreamiento);
            lista.ForEach(item =>
            {
                contador++;
                item.CalcularSueldo();
                Console.WriteLine("*********************************************");
                Console.WriteLine("");
                Console.WriteLine("Datos de Profesor Nº " + contador);
                item.MostrarPropiedades();
                Console.WriteLine("");
                Console.WriteLine("*********************************************");
            });

        }
    }
}
