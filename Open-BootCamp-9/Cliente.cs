using System;
namespace Open_BootCamp_9
{
    public class Cliente : Persona
    {
        public decimal Credito;

        public override string ToString()
        {
            return base.ToString() + $", Credito: {this.Credito}";
        }
    }
}