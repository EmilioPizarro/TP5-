using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo_Colón
{
    public partial class VtnEuler : Form
    {
        public VtnEuler()
        {
            InitializeComponent();
        }


        //Recibir los datos
        public string h_paso { get; set; }
        public string d_futbol { get; set; }
        public string d_basket { get; set; }
        public string d_handball { get; set; }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VtnEuler_Load(object sender, EventArgs e)
        {
            txth_paso_read.Text = h_paso;
            txt_d_basket_read.Text = d_basket;
            txt_d_futbol_read.Text = d_futbol;
            txt_d_handball_read.Text = d_handball;


        }
    }
}
