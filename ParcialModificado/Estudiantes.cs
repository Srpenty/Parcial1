using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialModificado
{
    class Estudiantes
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private double _promedio;

        public Estudiantes(string nombre, string apellido, int edad, double promedio)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _promedio = promedio;
        }

        public string getdata()
        {
            return "Nombre: " + _nombre + " Apellido: " + _apellido + " Edad: " + _edad + " Nota: " + _promedio;
        }
    }
}
