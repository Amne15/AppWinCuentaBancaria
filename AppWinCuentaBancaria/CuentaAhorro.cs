using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuentaBancaria.Clases
{
    internal class CuentaAhorro : Cuenta
    {
        //private Cuenta cuenta;
        private double cuotaMantenimiento;
        

        /**/
        public CuentaAhorro() : base()
        {
        }

        /**/
        public CuentaAhorro(Cuenta cuenta, double cuotaMantenimiento) 
        : base(cuenta.getNumCuenta(), cuenta.getNombre(), cuenta.getSaldo(), cuenta.getTipoInteres())

        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        /**/
        public double getCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }

        /**/
        public void setCuotaMantenimiento(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public override string ToString()
        {
            //return base.ToString();
            
            return base.ToString() +", Cuota Mantenimiento: " + cuotaMantenimiento +" !!";
        }
    }
}
