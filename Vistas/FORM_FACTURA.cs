using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Vistas
{
    public partial class FORM_FACTURA : Form
    {
        public FORM_FACTURA()
        {
            
            InitializeComponent();

            label_numfactura.Text = "FACT N°"  +  FORM_PRINCIPAL.ctl_Factura.num_factura();
            label_fecha.Text = DateTime.Now.ToString();

        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {
            if (txt_cedula.Text.Length ==10 ) 
            {
                Cliente cli = FORM_PRINCIPAL.ctl_cli.Buscar_cedula(txt_cedula.Text);
                if ( cli != null )
                {
                    label_cliente.Text = cli.Nombre + " " + cli.Apellido;

                } 
                else
                {
                    label_cliente.Text = "-";
                }
            
            
            }
            else
            {
                label_cliente.Text = "-";
            }
        }
    }
}
