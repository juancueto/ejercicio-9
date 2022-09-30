using System;
namespace Open_BootCamp_9
{
    public class Trabajador: Persona
    {
        public decimal Salario;

        public override string ToString()
        {
            return base.ToString() + $", Salario: {this.Salario}";
        }
    }
}

