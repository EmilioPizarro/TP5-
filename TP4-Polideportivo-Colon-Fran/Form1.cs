using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;




//Cambio carlos

namespace Polideportivo_Colón
{
    public partial class Form1 : Form
    {
        int contador_limpiezas = 0;
        //Constantes Eventos
        public const int LLEGADA_FUTBOL = 0;
        public const int LLEGADA_BASKET = 1;
        public const int LLEGADA_HANDBALL = 2;
        public const int FIN_FUTBOL = 3;
        public const int FIN_BASKET = 4;
        public const int FIN_HANDBALL = 5;
        public const int FIN_LIMPIEZA = 6;

        //Constantes Eventos
        public const int FUTBOL = 0;
        public const int BASKET = 1;
        public const int HANDBALL = 2;


        public const int LIBRE = 0;
        public const int OCUPADO = 1;
        public const int LIMPIEZA = 2;

        public const int LIMPIAR = 10000000;

        public Form1()
        {
            InitializeComponent();
            cargarCamposXDefecto();
            cargarTablas();

        }

        private void cargarTablas()
        {
            dtgLlegadas.Rows.Add("Futbol", "Exp.Negativa (hrs)");
            dtgLlegadas.Rows.Add("Hand Ball", "Uniforme AB (hrs)");
            dtgLlegadas.Rows.Add("Basket", "Uniforme AB (hrs)");


            dtgOcupacion.Rows.Add("Futbol", "Uniforme AB (min)");
            dtgOcupacion.Rows.Add("Hand Ball", "Uniforme AB (min)");
            dtgOcupacion.Rows.Add("Basket", "Uniforme AB (min)");
        }



        private void cargarCamposXDefecto()
        {
            int mediaFutbolLllegadaInicial = 10;

            int limiteA_LlegadaHandbal = 10;
            int limiteB_LlegadaHandbal = 14;

            int limiteA_LlegadaBasket = 6;
            int limiteB_LlegadaBasket = 10;

            txtMediaFutbolLlegada.Text = mediaFutbolLllegadaInicial.ToString();
            txtLlegada_A_Handball.Text = limiteA_LlegadaHandbal.ToString();
            txt_Llegada_B_Handball.Text = limiteB_LlegadaHandbal.ToString();
            txt_Llegada_A_Basket.Text = limiteA_LlegadaBasket.ToString();
            txtLlegada_B_Basket.Text = limiteB_LlegadaBasket.ToString();


            int limiteA_OcupacionFutbol = 80;
            int limiteB_OcupacionFutbol = 100;

            int limiteA_OcupacionHandbal = 60;
            int limiteB_OcupacionHandbal = 100;

            int limiteA_OcupacionBasket = 70;
            int limiteB_OcupacionBasket = 130;

            txtOcupacion_A_Futbol.Text = limiteA_OcupacionFutbol.ToString();
            txtOcupacion_B_Futbol.Text = limiteB_OcupacionFutbol.ToString();

            txtOcupacion_A_Handbal.Text = limiteA_OcupacionHandbal.ToString();
            txtOcupacion_B_Handbal.Text = limiteB_OcupacionHandbal.ToString();

            txtOcupacion_A_Basket.Text = limiteA_OcupacionBasket.ToString();
            txtOcupacion_B_Basket.Text = limiteB_OcupacionBasket.ToString();

            int limiteGruposEnCola = 5;
            txtLimiteGruposEnCola.Text = limiteGruposEnCola.ToString();

            double h = 0.1;
            txtPaso_h.Text = h.ToString();

            int D_fut = 100;
            txtDfutbol.Text = D_fut.ToString();

            int D_bas = 300;
            txtDbasket.Text = D_bas.ToString();

            int D_hand = 200;
            txtDhandball.Text = D_hand.ToString();

        }

        private void btnCargaPorDefecto_Click(object sender, EventArgs e)
        {
            cargarCamposXDefecto();

        }


        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            while (dataGridView1.ColumnCount > 28)
            {
                dataGridView1.Columns.RemoveAt(28);
            }

            if (CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del m�todo sin continuar la simulaci�n
            }
            iniciar_simulacion();
        }

        private bool CamposVacios()
        {
            // Verificar si alguno de los campos de texto est� vac�o
            return
                string.IsNullOrWhiteSpace(txt_Llegada_A_Basket.Text) ||
                string.IsNullOrWhiteSpace(txt_Llegada_B_Handball.Text) ||
                string.IsNullOrWhiteSpace(txtHoraDesde.Text) ||
                string.IsNullOrWhiteSpace(txtIteracionesMostrar.Text) ||
                string.IsNullOrWhiteSpace(txtLimiteGruposEnCola.Text) ||
                string.IsNullOrWhiteSpace(txtLlegada_A_Handball.Text) ||
                string.IsNullOrWhiteSpace(txtLlegada_B_Basket.Text) ||
                string.IsNullOrWhiteSpace(txtMediaFutbolLlegada.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_A_Basket.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_A_Futbol.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_A_Handbal.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_B_Basket.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_B_Futbol.Text) ||
                string.IsNullOrWhiteSpace(txtOcupacion_B_Handbal.Text) ||
                string.IsNullOrWhiteSpace(txtTiempoTotal.Text);

        }

        private void iniciar_simulacion()
        {
            //Inicio Simulacion
            string[] eventos = {
                                "Llegada Futbol",
                                "Llegada Basket",
                                "Llegada Handball",
                                "Fin Ocupacion Futbol",
                                "Fin Ocupacion Basket",
                                "Fin Ocupacion Handball",
                                "Fin Limpieza",
                                "Inicio"

            };

            string[] disciplinas = {
                                "Futbol",
                                "Basket",
                                "Handball",

            };

            string[] estados_cancha = {
                                        "Libre",
                                        "Ocupado",
                                        "Limpieza"
            };

            double[] Tiempos_Limpieza = {
                double.Parse(txtDfutbol.Text),
                double.Parse(txtDbasket.Text),
                double.Parse(txtDhandball.Text)
            };

            double tiempo_max = double.Parse(txtTiempoTotal.Text);
            int maximo_cola = int.Parse(txtLimiteGruposEnCola.Text);
            int IteracionesMostrar = int.Parse(txtIteracionesMostrar.Text);
            double horaInicio = double.Parse(txtHoraDesde.Text);
            double tiempo_proximo_evento = 0;
            Random rand = new Random();

            //Variables para calculo llegadas
            double media_llegada_futbol = double.Parse(txtMediaFutbolLlegada.Text);
            double Llegada_A_Handball = double.Parse(txtLlegada_A_Handball.Text);
            double Llegada_B_Handball = double.Parse(txt_Llegada_B_Handball.Text);
            double Llegada_A_Basket = double.Parse(txt_Llegada_A_Basket.Text);
            double Llegada_B_Basket = double.Parse(txtLlegada_B_Basket.Text);

            //Variables para calculo fin de ocupacion como son en minutos se los divide por 60
            //Son todas distribuciones uniforme
            double[] Uniforme_A =   {
                                        double.Parse(txtOcupacion_A_Futbol.Text)/60,
                                        double.Parse(txtOcupacion_A_Basket.Text)/60,
                                        double.Parse(txtOcupacion_A_Handbal.Text)/60
                                    };
            double[] Uniforme_B =   {
                                        double.Parse(txtOcupacion_B_Futbol.Text)/60,
                                        double.Parse(txtOcupacion_B_Basket.Text)/60,
                                        double.Parse(txtOcupacion_B_Handbal.Text)/60
                                    };





            //Estados Iniciales
            string proximo_evento = eventos[7];
            string estado_actual = estados_cancha[0];

            //Ramndons 
            double RND_Lleg = 0;
            double RND_Ocup = 0;

            //Contadores y acumuladores
            int[] Contador_equipos = { 0, 0, 0 }; // Futbol - Handball - Basquet
            double[] AC_Tiempo_espera = { 0, 0, 0 };
            int Contador_dias = 1;
            double AC_tiempo_libre = 0;
            double tiempo_actual = 0;

            Queue ColaActual = new Queue();
            Grupo grupo_actual = new Grupo("", 0, 0, 0);
            ColaActual.Clear();

            double[] tiempo_proximos_eventos = new double[7]; //Esto crea un arreglo de double con 7 elementos iniciales
            double[] tiempo_entre_evento = new double[7]; //Idem

            int contador_equipos_salida = 0;
            int numeroFila = 0;

            //Tiempo de limpieza como son en minutos se los divide por 60
                double tiempo_limp = 0;
            contador_limpiezas = 0;

            // Realizar la simulaci�n para cada d�a
            for (int i = 0; i <= 100000; i += 1)
            {
                

                tiempo_actual = tiempo_proximo_evento;
                string evento_actual = proximo_evento;
                if (tiempo_actual >= 24 * Contador_dias)
                {
                    Contador_dias += 1;
                }
                switch (evento_actual)
                {
                    case "Inicio":
                        //Se calculan todas las proximas llegadas
                        RND_Lleg = rand.NextDouble();
                        RND_Lleg = Math.Round(RND_Lleg, 4);
                        tiempo_entre_evento[LLEGADA_FUTBOL] = Math.Round(media_llegada_futbol * Math.Log(1 - RND_Lleg) * (-1), 4);       //Calculo Futbol
                        tiempo_entre_evento[LLEGADA_BASKET] = Math.Round(Llegada_A_Basket + RND_Lleg * (Llegada_B_Basket - Llegada_A_Basket), 4);      //Caluclo Basket
                        tiempo_entre_evento[LLEGADA_HANDBALL] = Math.Round(Llegada_A_Handball + RND_Lleg * (Llegada_B_Handball - Llegada_A_Handball), 4);//Calculo Handball

                        for (int j = 0; j < 3; j += 1)
                        {
                            tiempo_proximos_eventos[j] = Math.Round(tiempo_entre_evento[j] + tiempo_actual, 4);
                        }

                        break;

                    case "Llegada Futbol":

                        Grupo grupo_nuevo = new Grupo($"Equipo {sumar_contador(Contador_equipos)}", FUTBOL, tiempo_actual, sumar_contador(Contador_equipos) - 1);
                        if (ColaActual.Count < maximo_cola)
                        {
                            Contador_equipos[FUTBOL] += 1;
                            ColaActual.Enqueue(grupo_nuevo);
                            sumar_columnas_equipos(sumar_contador(Contador_equipos));
                        }

                        RND_Lleg = rand.NextDouble();
                        RND_Lleg = Math.Round(RND_Lleg, 4);
                        tiempo_entre_evento[LLEGADA_FUTBOL] = Math.Round(-media_llegada_futbol * Math.Log(1 - RND_Lleg), 4);
                        tiempo_proximos_eventos[LLEGADA_FUTBOL] = Math.Round(tiempo_entre_evento[LLEGADA_FUTBOL] + tiempo_actual, 4);


                        break;

                    case "Llegada Basket":

                        grupo_nuevo = new Grupo($"Equipo {sumar_contador(Contador_equipos)}", BASKET, tiempo_actual, sumar_contador(Contador_equipos) - 1);
                        if (ColaActual.Count < maximo_cola)
                        {
                            Contador_equipos[BASKET] += 1;
                            ColaActual.Enqueue(grupo_nuevo);
                            sumar_columnas_equipos(sumar_contador(Contador_equipos));
                        }

                        RND_Lleg = rand.NextDouble();
                        RND_Lleg = Math.Round(RND_Lleg, 4);
                        tiempo_entre_evento[LLEGADA_BASKET] = Math.Round(Llegada_A_Basket + RND_Lleg * (Llegada_B_Basket - Llegada_A_Basket), 4);
                        tiempo_proximos_eventos[LLEGADA_BASKET] = Math.Round(tiempo_entre_evento[LLEGADA_BASKET] + tiempo_actual, 4);

                        break;

                    case "Llegada Handball":

                        grupo_nuevo = new Grupo($"Equipo {sumar_contador(Contador_equipos)}", HANDBALL, tiempo_actual, sumar_contador(Contador_equipos) - 1);
                        if (ColaActual.Count < maximo_cola)
                        {
                            Contador_equipos[HANDBALL] += 1;
                            ColaActual.Enqueue(grupo_nuevo);
                            sumar_columnas_equipos(sumar_contador(Contador_equipos));
                        }

                        RND_Lleg = rand.NextDouble();
                        RND_Lleg = Math.Round(RND_Lleg, 4);
                        tiempo_entre_evento[LLEGADA_HANDBALL] = Math.Round(Llegada_A_Handball + RND_Lleg * (Llegada_B_Handball - Llegada_A_Handball), 4);
                        tiempo_proximos_eventos[LLEGADA_HANDBALL] = Math.Round(tiempo_entre_evento[LLEGADA_HANDBALL] + tiempo_actual, 4);

                        break;

                    case "Fin Ocupacion Futbol":
                        contador_equipos_salida += 1;
                        estado_actual = estados_cancha[LIMPIEZA];
                        tiempo_entre_evento[FIN_FUTBOL] = 0;
                        tiempo_proximos_eventos[FIN_FUTBOL] = 0;
                        tiempo_limp = calcular_tiempo_limpieza(Tiempos_Limpieza[FUTBOL],contador_limpiezas)/60;
                        tiempo_proximos_eventos[FIN_LIMPIEZA] = Math.Round(tiempo_actual + tiempo_limp, 4);
                        grupo_actual.Estado = "DESTRUIDO";
                        break;

                    case "Fin Ocupacion Basket":
                        contador_equipos_salida += 1;
                        estado_actual = estados_cancha[LIMPIEZA];
                        tiempo_entre_evento[FIN_BASKET] = 0;
                        tiempo_proximos_eventos[FIN_BASKET] = 0;
                        tiempo_limp = calcular_tiempo_limpieza(Tiempos_Limpieza[BASKET],contador_limpiezas)/60;
                        tiempo_proximos_eventos[FIN_LIMPIEZA] = Math.Round(tiempo_actual + tiempo_limp, 4);
                        grupo_actual.Estado = "DESTRUIDO";
                        break;

                    case "Fin Ocupacion Handball":
                        contador_equipos_salida += 1;
                        estado_actual = estados_cancha[LIMPIEZA];
                        tiempo_entre_evento[FIN_HANDBALL] = 0;
                        tiempo_proximos_eventos[FIN_HANDBALL] = 0;
                        tiempo_limp = calcular_tiempo_limpieza(Tiempos_Limpieza[HANDBALL],contador_limpiezas)/60;
                        tiempo_proximos_eventos[FIN_LIMPIEZA] = Math.Round(tiempo_actual + tiempo_limp, 4);
                        grupo_actual.Estado = "DESTRUIDO";
                        break;

                    case "Fin Limpieza":
                        estado_actual = estados_cancha[LIBRE];
                        tiempo_proximos_eventos[FIN_LIMPIEZA] = 0;
                        contador_limpiezas+= 1;
                        break;

                    default:
                        Console.WriteLine($"Estado Incorrecto.");
                        break;
                }

                //Acumulador horas de espera de equipos pendientes
                foreach (Grupo equipo in ColaActual)
                {
                    AC_Tiempo_espera[equipo.Disciplina] += Math.Round(equipo.calcularTiempoEspera(tiempo_actual), 4);
                }

                if (estado_actual == estados_cancha[LIBRE])
                {
                    if (ColaActual.Count > 0)
                    {
                        RND_Ocup = rand.NextDouble();
                        RND_Ocup = Math.Round(RND_Ocup, 4);

                        grupo_actual = (Grupo)ColaActual.Dequeue();
                        grupo_actual.Estado = "En Cancha";
                        estado_actual = estados_cancha[OCUPADO];
                        tiempo_entre_evento[grupo_actual.Disciplina + FIN_FUTBOL] = Math.Round(Uniforme_A[grupo_actual.Disciplina] + RND_Ocup * (Uniforme_B[grupo_actual.Disciplina] - Uniforme_A[grupo_actual.Disciplina]), 4);
                        tiempo_proximos_eventos[grupo_actual.Disciplina + FIN_FUTBOL] = Math.Round(tiempo_entre_evento[grupo_actual.Disciplina + FIN_FUTBOL] + tiempo_actual, 4);
                    }
                }
                //Mostrar 


                //Calcular tiempo de Proximos Eventos 

                //Agregar fila a DataGridView solo si el d�a es mayor o igual a desdeDia
                if (tiempo_actual >= horaInicio && IteracionesMostrar >= 0)
                {
                    IteracionesMostrar -= 1;
                    dataGridView1.Rows.Add(evento_actual, tiempo_actual, RND_Lleg, tiempo_entre_evento[LLEGADA_FUTBOL], tiempo_proximos_eventos[LLEGADA_FUTBOL],
                                            tiempo_entre_evento[LLEGADA_HANDBALL], tiempo_proximos_eventos[LLEGADA_HANDBALL], tiempo_entre_evento[LLEGADA_BASKET],
                                            tiempo_proximos_eventos[LLEGADA_BASKET], RND_Ocup, tiempo_entre_evento[FIN_FUTBOL],
                                            tiempo_entre_evento[FIN_HANDBALL], tiempo_entre_evento[FIN_BASKET], tiempo_proximos_eventos[FIN_FUTBOL], tiempo_proximos_eventos[FIN_HANDBALL],
                                            tiempo_proximos_eventos[FIN_BASKET],tiempo_limp ,tiempo_proximos_eventos[FIN_LIMPIEZA], estado_actual, ColaActual.Count,contador_limpiezas, Contador_equipos[FUTBOL],
                                            Contador_equipos[HANDBALL], Contador_equipos[BASKET], AC_Tiempo_espera[FUTBOL], AC_Tiempo_espera[HANDBALL], AC_Tiempo_espera[BASKET],
                                            AC_tiempo_libre, Contador_dias);
                    if (sumar_contador(Contador_equipos) > 0)
                    {
                        dataGridView1.Rows[numeroFila].Cells[grupo_actual.NumeroGrupo * 3 + 31].Value = grupo_actual.Estado;
                        dataGridView1.Rows[numeroFila].Cells[grupo_actual.NumeroGrupo * 3 + 31 + 1].Value = disciplinas[grupo_actual.Disciplina];
                        dataGridView1.Rows[numeroFila].Cells[grupo_actual.NumeroGrupo * 3 + 31 + 2].Value = grupo_actual.TiempoLlegada;
                    }
                    foreach (Grupo equipo in ColaActual)
                    {
                        dataGridView1.Rows[numeroFila].Cells[equipo.NumeroGrupo * 3 + 31].Value = equipo.Estado;
                        dataGridView1.Rows[numeroFila].Cells[equipo.NumeroGrupo * 3 + 31 + 1].Value = disciplinas[equipo.Disciplina];
                        dataGridView1.Rows[numeroFila].Cells[equipo.NumeroGrupo * 3 + 31 + 2].Value = equipo.TiempoLlegada;
                    }
                    numeroFila += 1;

                }

                //Limpiar Campos 
                for (int j = 0; j < tiempo_entre_evento.Length; j += 1)
                {
                    tiempo_entre_evento[j] = 0;
                }
                tiempo_limp = 0;
                RND_Lleg = 0;
                RND_Ocup = 0;

                //Calculo del siguiente Evento
                int indice_proximo_evento = Calcular_Poscicion_Mininimo(tiempo_proximos_eventos);
                tiempo_proximo_evento = tiempo_proximos_eventos[indice_proximo_evento];
                proximo_evento = eventos[indice_proximo_evento];


                if (estado_actual == estados_cancha[LIBRE])
                {
                    AC_tiempo_libre += tiempo_proximo_evento - tiempo_actual;
                    if (ColaActual.Count > 0)
                    {

                    }
                }
                if (tiempo_proximo_evento > tiempo_max)
                {
                    break;
                }
            }

            //Fila con Totales
            dataGridView1.Rows.Add("TOTALES", "", "", "", tiempo_proximos_eventos[LLEGADA_FUTBOL],
                                            "", tiempo_proximos_eventos[LLEGADA_HANDBALL], "",
                                            tiempo_proximos_eventos[LLEGADA_BASKET], "", "",
                                            "", "", tiempo_proximos_eventos[FIN_FUTBOL], tiempo_proximos_eventos[FIN_HANDBALL],
                                            tiempo_proximos_eventos[FIN_BASKET],"", tiempo_proximos_eventos[FIN_LIMPIEZA], estado_actual, ColaActual.Count, contador_limpiezas, Contador_equipos[FUTBOL],
                                            Contador_equipos[HANDBALL], Contador_equipos[BASKET], AC_Tiempo_espera[FUTBOL], AC_Tiempo_espera[HANDBALL], AC_Tiempo_espera[BASKET],
                                            AC_tiempo_libre, Contador_dias);



            //Mostrar Resultados
            txtPromedioEsperaFutbol.Text = Math.Round(AC_Tiempo_espera[FUTBOL] / Contador_equipos[FUTBOL], 4).ToString();
            txtPromedioEsperaBasket.Text = Math.Round(AC_Tiempo_espera[BASKET] / Contador_equipos[BASKET], 4).ToString();
            txtPromedioEsperaHandbal.Text = Math.Round(AC_Tiempo_espera[HANDBALL] / Contador_equipos[HANDBALL], 4).ToString();

            txtPromedioLibreCancha.Text = Math.Round(AC_tiempo_libre / Contador_dias, 4).ToString();

            // Limpiar los cuadros de texto
            // LimpiarCampos();
        }

        private int Calcular_Poscicion_Mininimo(double[] Valores)
        {
            double menor = 1000000;
            int poscicion_menor = 0;
            for (int i = 0; i < Valores.Length; i += 1)
            {
                if (Valores[i] < menor && Valores[i] != 0)
                {
                    poscicion_menor = i;
                    menor = Valores[i];
                }
            }
            return poscicion_menor;
        }

        private int sumar_contador(int[] contador)
        {
            int contador_total = 0;
            foreach (int i in contador)
            {
                contador_total += i;
            }
            return contador_total;
        }
        private void sumar_columnas_equipos(int numero)
        {
            DataGridViewTextBoxColumn estado = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn disciplina = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn horallegada = new DataGridViewTextBoxColumn();
            estado.HeaderText = $"Estado {numero}";
            estado.Width = 120;
            disciplina.HeaderText = $"disciplina {numero}";
            disciplina.Width = 120;
            horallegada.HeaderText = $"horaLlegada {numero}";
            horallegada.Width = 120;

            dataGridView1.Columns.Add(estado);
            dataGridView1.Columns.Add(disciplina);
            dataGridView1.Columns.Add(horallegada);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_Euler_Click(object sender, EventArgs e)
        {
            VtnEuler ventanaEuler = new VtnEuler();
            ventanaEuler.h_paso = txtPaso_h.Text;
            ventanaEuler.d_basket = txtDbasket.Text;
            ventanaEuler.d_futbol = txtDfutbol.Text;
            ventanaEuler.d_handball = txtDhandball.Text;

            ventanaEuler.Show();
            ventanaEuler.cargar_dtg();
            

            




        }
        private double calcular_tiempo_limpieza(double D, int C){
            double Di = 0;
            double Di_1 = 0;
            double h = double.Parse(txtPaso_h.Text);
            double t = 0;
            for(t=0; Di < D; t+=h){
                Di_1 = Di + (0.6*C+(t))*h;
                Di= Di_1;
            }

            return t;
        }
    }
}
