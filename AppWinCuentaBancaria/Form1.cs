using AppCuentaBancaria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppWinCuentaBancaria
{
    
    public partial class Form1 : Form
        
    {

        //static int v1;
        //static string v2;
        //static double v3;
        //static string v4;
        public static double cuoto;// cuenta.getCuotaMantenimiento();

        List<Object> list_cuenta = new List<Object>();
        //List<Object> list = new List<Object>();
        public Form1()
        {
            InitializeComponent();
            initio_Cuentas_Statico();
        }


        
  
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNombre = cBoxListCuenta.Text;
            tbNumcuenta.Text = selectedNombre;
            
            
            foreach (CuentaAhorro cuentaAhoro in list_cuenta)
            {
                string nombre = cuentaAhoro.getNombre();
                if (selectedNombre == nombre)
                {

                    int v1 = cuentaAhoro.getNumCuenta();
                    string v2 = cuentaAhoro.getNombre();
                    double v3 = cuentaAhoro.getSaldo();
                    double v4 = cuentaAhoro.getTipoInteres();
                    double v5 = cuentaAhoro.getCuotaMantenimiento();


                    tbNumcuenta.Text = v1+"";
                    tbNombre.Text = v2;
                    tbSaldo.Text = v3 +"";
                    tbTipointeres.Text = v4+"";
                    tbCuoto.Text = v5 +"";

                }

            }
            
        }
        
        private void bNuevo_Click(object sender, EventArgs e)
        {
            bNuevo.Visible = false;
            bGuardar.Visible = true;
            cBoxListCuenta.Visible = false;
            tbMsg.Visible = false;
            tbTipoCuenta.Visible = false;


            //cBoxListCuenta.GetItemText(0);

            //cBoxListCuenta.Text ="Elegir una cuenta";
            //cBoxListCuenta.Enabled = false;
            tbNumcuenta.Clear();
            tbNombre.Clear();
            tbSaldo.Clear();
            tbTipointeres.Clear();
            tbCuoto.Clear();
            tbMsg.Clear();
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            tbTipoCuenta.Visible = true;

            int numeroCuenta = Int32.Parse(tbNumcuenta.Text);
            string nombre = tbNombre.Text;
            double saldo = Double.Parse(tbSaldo.Text);
            double tipo = Double.Parse(tbTipointeres.Text);
            string cuoto1 = tbCuoto.Text+"";

            if (cuoto1 != "")
            {
                
                tbTipoCuenta.Text = "Tipo: Cuenta_Ahorro";
                cuoto = double.Parse(cuoto1);
            }
            else {
                tbTipoCuenta.Text = "Tipo: Cuenta"; 
                cuoto = 0;
            }
            Cuenta cuenta = new Cuenta(numeroCuenta, nombre, saldo, tipo);
            CuentaAhorro newCuentaAhorro = new CuentaAhorro(cuenta, cuoto);

            list_cuenta.Add(newCuentaAhorro);
            cBoxListCuenta.Items.Add(newCuentaAhorro.getNombre());

            tbNumcuenta.Text = newCuentaAhorro.getNumCuenta() + "";
            tbNombre.Text = newCuentaAhorro.getNombre();
            tbSaldo.Text = newCuentaAhorro.getSaldo() + "";
            tbTipointeres.Text = newCuentaAhorro.getTipoInteres() + "";
            tbCuoto.Text = newCuentaAhorro.getCuotaMantenimiento() + "";


            bNuevo.Visible = true;
            bGuardar.Visible = false;
            cBoxListCuenta.Visible = true;
            cBoxListCuenta.Text = newCuentaAhorro.getNombre();
            tbMsg.Visible = true;
            tbMsg.Text = "Registro guardado correctamente";

            /*
            for (int i = 0; i < list_cuenta.Count; i++)
            {
                CuentaAhorro c = list_cuenta[i];
                if (numeroCuenta < c.getNumCuenta() && numeroCuenta == c.getNumCuenta())
                {
                    tbMsg.Text = "Cuenta existe, registro no esta guardado.";
                    //i = list_cuenta.Count;
                    tbNumcuenta.Clear();
                    tbNombre.Text = nombre;
                    tbSaldo.Text = saldo+ "";
                    tbTipointeres.Text = tipo+ "";
                    tbCuoto.Text = cuoto+"";

                }
                else
                {
                    //
                    Cuenta cuenta = new Cuenta(numeroCuenta, nombre, saldo, tipo);
                    CuentaAhorro newCuentaAhorro = new CuentaAhorro(cuenta, cuoto);

                    list_cuenta.Add(newCuentaAhorro);
                    cBoxListCuenta.Items.Add(newCuentaAhorro.getNombre());

                    tbNumcuenta.Text = newCuentaAhorro.getNumCuenta() + "";
                    tbNombre.Text = newCuentaAhorro.getNombre();
                    tbSaldo.Text = newCuentaAhorro.getSaldo() + "";
                    tbTipointeres.Text = newCuentaAhorro.getTipoInteres() + "";
                    tbCuoto.Text = newCuentaAhorro.getCuotaMantenimiento() + "";


                    bNuevo.Visible = true;
                    bGuardar.Visible = false;
                    cBoxListCuenta.Visible = true;
                    cBoxListCuenta.Text = newCuentaAhorro.getNombre();
                    tbMsg.Visible = true;
                    tbMsg.Text = "Registro guardado correctamente";
                    //i = list_cuenta.Count;
                }

            }
            */

        }


        private void initio_Cuentas_Statico()
        {
            //Crea un objeto de la clase Cuenta.
            CuentaAhorro cuenta1 = new CuentaAhorro();
            CuentaAhorro cuenta2 = new CuentaAhorro();

            //Crea un objeto de la clase CuentaAhorro.
            CuentaAhorro cAhorro1 = new CuentaAhorro();
            CuentaAhorro cAhorro2 = new CuentaAhorro();

            //Asigna un número de cuenta, un nombre, un saldo y un tipo de interés. 
            //cuenta1
            cuenta1.setNumCuenta(1);
            cuenta1.setNombre("Amnellah");
            cuenta1.setSaldo(1000);
            cuenta1.setTipoInteres(5.5);
            //cuenta1
            cuenta2.setNumCuenta(2);
            cuenta2.setNombre("Laura");
            cuenta2.setSaldo(2500);
            cuenta2.setTipoInteres(8);

            //Asigna un número de cuenta, un nombre, un saldo, un tipo de interés y una cuota de mantenimiento. 
            //cuentaAhorro1
            cAhorro1.setNumCuenta(3);
            cAhorro1.setNombre("Celia");
            cAhorro1.setSaldo(1200);
            cAhorro1.setTipoInteres(6.2);
            cAhorro1.setCuotaMantenimiento(200);
            //cuentaAhorro2
            cAhorro2.setNumCuenta(4);
            cAhorro2.setNombre("Maitena");
            cAhorro2.setSaldo(1200);
            cAhorro2.setTipoInteres(2.5);
            cAhorro2.setCuotaMantenimiento(100);

            //Muestra el estado de dicha cuenta.
            //Console.WriteLine("ToString: " + cuenta.ToString());
            //Console.WriteLine("ToStringAhorro: " + cAhorro.ToString());
            //Console.ReadKey();

            //List<CuentaAhorro> list_cuenta;// = new List<CuentaAhorro>();

            //Insertar datos en la lista.
            list_cuenta.Add(cuenta1);
            list_cuenta.Add(cuenta2);
            list_cuenta.Add(cAhorro1);
            list_cuenta.Add(cAhorro2);

            //Insertar datos de la lista en el ComboBox del formulario.
            foreach (Cuenta c in list_cuenta)
            {
                _ = cBoxListCuenta.Items.Add(c.getNombre());
            }

        }

       
    }
}
