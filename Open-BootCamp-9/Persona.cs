using System;
namespace Open_BootCamp_9
{
    public class Persona
    {
        public int Edad;
        public string Nombre;
        public string Telefono;

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, " +
                $"Edad: {this.Edad} " +
                $"Telefono: {this.Telefono}";
        }
    }
}

