﻿using System;
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
            int contadorInicial = 0;    
            txt_cont_Limpieza.Text = contadorInicial.ToString();



        }

        public void btnCargarTablas_Click(object sender, EventArgs e){
            limpiarDTG();
            double Di = 0;
            double Di_1 = 0;
            double h = double.Parse(h_paso);
            int C = int.Parse(txt_cont_Limpieza.Text);
            double t=0;
            for( t=0; Di < double.Parse(d_futbol); t+=h){
                Di_1 = Math.Round(Di +(0.6*C+(t))*h,4);
                dtg_euler_futbol.Rows.Add(Math.Round(t,4),Di,Math.Round(0.6*C+(t),4),Math.Round(t+h,4),Di_1);
                Di= Di_1;
            }
            dtg_euler_futbol.Rows.Add(Math.Round(t,4),Di,"","","");
            Di = 0;
            Di_1 = 0;
            for( t=0; Di < double.Parse(d_basket); t+=h){
                Di_1 = Math.Round(Di +(0.6*C+(t))*h,4);
                dtg_euler_basket.Rows.Add(Math.Round(t,4),Di,Math.Round(0.6*C+(t),4),Math.Round(t+h,4),Di_1);
                Di= Di_1;
            }
            dtg_euler_basket.Rows.Add(Math.Round(t,4),Di,"","","");
             Di = 0;
             Di_1 = 0;
            for(t=0; Di < double.Parse(d_handball); t+=h){
                Di_1 =  Math.Round(Di + (0.6*C+(t))*h,4);
                dtg_euler_handball.Rows.Add(Math.Round(t,4),Di,Math.Round(0.6*C+(t),4),Math.Round(t+h,4),Di_1);
                Di= Di_1;
            }
             dtg_euler_handball.Rows.Add(Math.Round(t,4),Di,"","","");
        }

        public void limpiarDTG(){
            dtg_euler_basket.Rows.Clear();
            dtg_euler_futbol.Rows.Clear();
            dtg_euler_handball.Rows.Clear();
        }
    }
}
