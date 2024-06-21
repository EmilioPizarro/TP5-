namespace Polideportivo_Colón
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTiempoTotal = new TextBox();
            txtTotalIteraciones = new TextBox();
            txtIteracionesMostrar = new TextBox();
            txtHoraDesde = new TextBox();
            dtgLlegadas = new DataGridView();
            Disciplina = new DataGridViewTextBoxColumn();
            Llegadas = new DataGridViewTextBoxColumn();
            lalbel6 = new Label();
            txtMediaFutbolLlegada = new TextBox();
            txtLlegada_A_Handball = new TextBox();
            txt_Llegada_B_Handball = new TextBox();
            txt_Llegada_A_Basket = new TextBox();
            txtLlegada_B_Basket = new TextBox();
            txtOcupacion_B_Basket = new TextBox();
            txtOcupacion_A_Basket = new TextBox();
            txtOcupacion_B_Handbal = new TextBox();
            txtOcupacion_A_Handbal = new TextBox();
            label6 = new Label();
            dtgOcupacion = new DataGridView();
            Disiplina = new DataGridViewTextBoxColumn();
            Ocupacion = new DataGridViewTextBoxColumn();
            txtOcupacion_B_Futbol = new TextBox();
            txtOcupacion_A_Futbol = new TextBox();
            label7 = new Label();
            txtLimiteGruposEnCola = new TextBox();
            label8 = new Label();
            txtTiempoLimpieza = new TextBox();
            btnCargaPorDefecto = new Button();
            btnSimulacion = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtPromedioEsperaFutbol = new TextBox();
            txtPromedioEsperaHandbal = new TextBox();
            txtPromedioEsperaBasket = new TextBox();
            label13 = new Label();
            txtPromedioLibreCancha = new TextBox();
            Evento = new DataGridViewTextBoxColumn();
            Reloj = new DataGridViewTextBoxColumn();
            RND_Llegadas = new DataGridViewTextBoxColumn();
            TiempoEntreLlegadasFutbol = new DataGridViewTextBoxColumn();
            ProximaLlegadaFutbol = new DataGridViewTextBoxColumn();
            TiempoEntreLlegadasHandball = new DataGridViewTextBoxColumn();
            ProximaLlegadaHandball = new DataGridViewTextBoxColumn();
            TiempoEntreLlegadasBasket = new DataGridViewTextBoxColumn();
            ProximaLlegadaBasket = new DataGridViewTextBoxColumn();
            RND_Fin_Ocupacion = new DataGridViewTextBoxColumn();
            TiempoOcupacionFutbol = new DataGridViewTextBoxColumn();
            TiempoOcupacionHandball = new DataGridViewTextBoxColumn();
            TiempoOcupacionBasquet = new DataGridViewTextBoxColumn();
            FinFutbol = new DataGridViewTextBoxColumn();
            FinHandball = new DataGridViewTextBoxColumn();
            FinBasquet = new DataGridViewTextBoxColumn();
            FinLimpieza = new DataGridViewTextBoxColumn();
            EstadoCancha = new DataGridViewTextBoxColumn();
            ColaCancha = new DataGridViewTextBoxColumn();
            EstadoLimpiador = new DataGridViewTextBoxColumn();
            CEF = new DataGridViewTextBoxColumn();
            CEH = new DataGridViewTextBoxColumn();
            CEB = new DataGridViewTextBoxColumn();
            AC_TiempoEsperaFutbol = new DataGridViewTextBoxColumn();
            AC_TiempoEsperaHandball = new DataGridViewTextBoxColumn();
            AC_TiempoEsperaBasquet = new DataGridViewTextBoxColumn();
            AC_TiempoLibreCancha = new DataGridViewTextBoxColumn();
            ContadorDias = new DataGridViewTextBoxColumn();
            Estado1 = new DataGridViewTextBoxColumn();
            Disciplina1 = new DataGridViewTextBoxColumn();
            HoraLlegada1 = new DataGridViewTextBoxColumn();
            Estado2 = new DataGridViewTextBoxColumn();
            Disciplina2 = new DataGridViewTextBoxColumn();
            HoraLlegada2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgLlegadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgOcupacion).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Evento, Reloj, RND_Llegadas, TiempoEntreLlegadasFutbol, ProximaLlegadaFutbol, TiempoEntreLlegadasHandball, ProximaLlegadaHandball, TiempoEntreLlegadasBasket, ProximaLlegadaBasket, RND_Fin_Ocupacion, TiempoOcupacionFutbol, TiempoOcupacionHandball, TiempoOcupacionBasquet, FinFutbol, FinHandball, FinBasquet, FinLimpieza, EstadoCancha, ColaCancha, EstadoLimpiador, CEF, CEH, CEB, AC_TiempoEsperaFutbol, AC_TiempoEsperaHandball, AC_TiempoEsperaBasquet, AC_TiempoLibreCancha, ContadorDias });
            dataGridView1.Location = new Point(12, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1518, 478);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 1;
            label1.Text = "Parametros de Simulacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 25);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 2;
            label2.Text = "Tiempo de Simulacion (Reloj):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad de Iterciones a Realizar (N):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 52);
            label4.Name = "label4";
            label4.Size = new Size(201, 15);
            label4.TabIndex = 4;
            label4.Text = "Cantidad de Iteraciones a Mostrar (i):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 78);
            label5.Name = "label5";
            label5.Size = new Size(185, 15);
            label5.TabIndex = 5;
            label5.Text = "Hora de inicio de Visualizacion (j):";
            // 
            // txtTiempoTotal
            // 
            txtTiempoTotal.Location = new Point(533, 17);
            txtTiempoTotal.Name = "txtTiempoTotal";
            txtTiempoTotal.Size = new Size(100, 23);
            txtTiempoTotal.TabIndex = 6;
            // 
            // txtTotalIteraciones
            // 
            txtTotalIteraciones.Location = new Point(250, 82);
            txtTotalIteraciones.Name = "txtTotalIteraciones";
            txtTotalIteraciones.Size = new Size(100, 23);
            txtTotalIteraciones.TabIndex = 7;
            // 
            // txtIteracionesMostrar
            // 
            txtIteracionesMostrar.Location = new Point(533, 44);
            txtIteracionesMostrar.Name = "txtIteracionesMostrar";
            txtIteracionesMostrar.Size = new Size(100, 23);
            txtIteracionesMostrar.TabIndex = 8;
            // 
            // txtHoraDesde
            // 
            txtHoraDesde.Location = new Point(533, 73);
            txtHoraDesde.Name = "txtHoraDesde";
            txtHoraDesde.Size = new Size(100, 23);
            txtHoraDesde.TabIndex = 9;
            // 
            // dtgLlegadas
            // 
            dtgLlegadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLlegadas.Columns.AddRange(new DataGridViewColumn[] { Disciplina, Llegadas });
            dtgLlegadas.Location = new Point(666, 17);
            dtgLlegadas.Name = "dtgLlegadas";
            dtgLlegadas.RowHeadersWidth = 51;
            dtgLlegadas.Size = new Size(267, 136);
            dtgLlegadas.TabIndex = 10;
            // 
            // Disciplina
            // 
            Disciplina.HeaderText = "Disciplina";
            Disciplina.MinimumWidth = 6;
            Disciplina.Name = "Disciplina";
            Disciplina.ReadOnly = true;
            Disciplina.Width = 125;
            // 
            // Llegadas
            // 
            Llegadas.HeaderText = "Llegadas";
            Llegadas.MinimumWidth = 6;
            Llegadas.Name = "Llegadas";
            Llegadas.ReadOnly = true;
            Llegadas.Width = 120;
            // 
            // lalbel6
            // 
            lalbel6.AutoSize = true;
            lalbel6.BackColor = SystemColors.ControlLightLight;
            lalbel6.Location = new Point(939, 11);
            lalbel6.Name = "lalbel6";
            lalbel6.Size = new Size(132, 30);
            lalbel6.TabIndex = 11;
            lalbel6.Text = "Parametros de Llegadas\n en Horas";
            // 
            // txtMediaFutbolLlegada
            // 
            txtMediaFutbolLlegada.Location = new Point(939, 45);
            txtMediaFutbolLlegada.Name = "txtMediaFutbolLlegada";
            txtMediaFutbolLlegada.PlaceholderText = "Media en hrs";
            txtMediaFutbolLlegada.Size = new Size(138, 23);
            txtMediaFutbolLlegada.TabIndex = 12;
            // 
            // txtLlegada_A_Handball
            // 
            txtLlegada_A_Handball.Location = new Point(942, 74);
            txtLlegada_A_Handball.Name = "txtLlegada_A_Handball";
            txtLlegada_A_Handball.PlaceholderText = "A en hrs";
            txtLlegada_A_Handball.Size = new Size(63, 23);
            txtLlegada_A_Handball.TabIndex = 13;
            // 
            // txt_Llegada_B_Handball
            // 
            txt_Llegada_B_Handball.Location = new Point(1016, 74);
            txt_Llegada_B_Handball.Name = "txt_Llegada_B_Handball";
            txt_Llegada_B_Handball.PlaceholderText = "B en hrs";
            txt_Llegada_B_Handball.Size = new Size(61, 23);
            txt_Llegada_B_Handball.TabIndex = 14;
            // 
            // txt_Llegada_A_Basket
            // 
            txt_Llegada_A_Basket.Location = new Point(942, 104);
            txt_Llegada_A_Basket.Name = "txt_Llegada_A_Basket";
            txt_Llegada_A_Basket.PlaceholderText = "A en hrs";
            txt_Llegada_A_Basket.Size = new Size(63, 23);
            txt_Llegada_A_Basket.TabIndex = 15;
            // 
            // txtLlegada_B_Basket
            // 
            txtLlegada_B_Basket.Location = new Point(1016, 104);
            txtLlegada_B_Basket.Name = "txtLlegada_B_Basket";
            txtLlegada_B_Basket.PlaceholderText = "B en hrs";
            txtLlegada_B_Basket.Size = new Size(61, 23);
            txtLlegada_B_Basket.TabIndex = 16;
            // 
            // txtOcupacion_B_Basket
            // 
            txtOcupacion_B_Basket.Location = new Point(1451, 98);
            txtOcupacion_B_Basket.Name = "txtOcupacion_B_Basket";
            txtOcupacion_B_Basket.PlaceholderText = "B en hrs";
            txtOcupacion_B_Basket.Size = new Size(61, 23);
            txtOcupacion_B_Basket.TabIndex = 23;
            // 
            // txtOcupacion_A_Basket
            // 
            txtOcupacion_A_Basket.Location = new Point(1378, 98);
            txtOcupacion_A_Basket.Name = "txtOcupacion_A_Basket";
            txtOcupacion_A_Basket.PlaceholderText = "A en hrs";
            txtOcupacion_A_Basket.Size = new Size(63, 23);
            txtOcupacion_A_Basket.TabIndex = 22;
            // 
            // txtOcupacion_B_Handbal
            // 
            txtOcupacion_B_Handbal.Location = new Point(1451, 69);
            txtOcupacion_B_Handbal.Name = "txtOcupacion_B_Handbal";
            txtOcupacion_B_Handbal.PlaceholderText = "B en hrs";
            txtOcupacion_B_Handbal.Size = new Size(61, 23);
            txtOcupacion_B_Handbal.TabIndex = 21;
            // 
            // txtOcupacion_A_Handbal
            // 
            txtOcupacion_A_Handbal.Location = new Point(1378, 69);
            txtOcupacion_A_Handbal.Name = "txtOcupacion_A_Handbal";
            txtOcupacion_A_Handbal.PlaceholderText = "A en hrs";
            txtOcupacion_A_Handbal.Size = new Size(63, 23);
            txtOcupacion_A_Handbal.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Location = new Point(1374, 9);
            label6.Name = "label6";
            label6.Size = new Size(144, 30);
            label6.TabIndex = 18;
            label6.Text = "Parametros de Ocupacion\n en Minutos";
            // 
            // dtgOcupacion
            // 
            dtgOcupacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOcupacion.Columns.AddRange(new DataGridViewColumn[] { Disiplina, Ocupacion });
            dtgOcupacion.Location = new Point(1102, 11);
            dtgOcupacion.Name = "dtgOcupacion";
            dtgOcupacion.RowHeadersWidth = 51;
            dtgOcupacion.Size = new Size(267, 144);
            dtgOcupacion.TabIndex = 17;
            // 
            // Disiplina
            // 
            Disiplina.HeaderText = "Disciplina";
            Disiplina.MinimumWidth = 6;
            Disiplina.Name = "Disiplina";
            Disiplina.ReadOnly = true;
            Disiplina.Width = 125;
            // 
            // Ocupacion
            // 
            Ocupacion.HeaderText = "Ocupacion";
            Ocupacion.MinimumWidth = 6;
            Ocupacion.Name = "Ocupacion";
            Ocupacion.ReadOnly = true;
            Ocupacion.Width = 120;
            // 
            // txtOcupacion_B_Futbol
            // 
            txtOcupacion_B_Futbol.Location = new Point(1451, 40);
            txtOcupacion_B_Futbol.Name = "txtOcupacion_B_Futbol";
            txtOcupacion_B_Futbol.PlaceholderText = "B en hrs";
            txtOcupacion_B_Futbol.Size = new Size(61, 23);
            txtOcupacion_B_Futbol.TabIndex = 25;
            // 
            // txtOcupacion_A_Futbol
            // 
            txtOcupacion_A_Futbol.Location = new Point(1378, 40);
            txtOcupacion_A_Futbol.Name = "txtOcupacion_A_Futbol";
            txtOcupacion_A_Futbol.PlaceholderText = "A en hrs";
            txtOcupacion_A_Futbol.Size = new Size(63, 23);
            txtOcupacion_A_Futbol.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 112);
            label7.Name = "label7";
            label7.Size = new Size(213, 15);
            label7.TabIndex = 26;
            label7.Text = "Limite de Grupos para esperar en Cola: ";
            // 
            // txtLimiteGruposEnCola
            // 
            txtLimiteGruposEnCola.Location = new Point(533, 104);
            txtLimiteGruposEnCola.Name = "txtLimiteGruposEnCola";
            txtLimiteGruposEnCola.Size = new Size(100, 23);
            txtLimiteGruposEnCola.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 140);
            label8.Name = "label8";
            label8.Size = new Size(212, 15);
            label8.TabIndex = 28;
            label8.Text = "Tiempo de Limpieza de Cancha (Mins):";
            // 
            // txtTiempoLimpieza
            // 
            txtTiempoLimpieza.Location = new Point(533, 133);
            txtTiempoLimpieza.Name = "txtTiempoLimpieza";
            txtTiempoLimpieza.Size = new Size(100, 23);
            txtTiempoLimpieza.TabIndex = 29;
            // 
            // btnCargaPorDefecto
            // 
            btnCargaPorDefecto.Location = new Point(12, 52);
            btnCargaPorDefecto.Name = "btnCargaPorDefecto";
            btnCargaPorDefecto.Size = new Size(150, 32);
            btnCargaPorDefecto.TabIndex = 30;
            btnCargaPorDefecto.Text = "Cargar Por Defecto";
            btnCargaPorDefecto.UseVisualStyleBackColor = true;
            btnCargaPorDefecto.Click += btnCargaPorDefecto_Click;
            // 
            // btnSimulacion
            // 
            btnSimulacion.Location = new Point(12, 98);
            btnSimulacion.Name = "btnSimulacion";
            btnSimulacion.Size = new Size(150, 32);
            btnSimulacion.TabIndex = 30;
            btnSimulacion.Text = "Iniciar Simulacion";
            btnSimulacion.UseVisualStyleBackColor = true;
            btnSimulacion.Click += btnSimulacion_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 674);
            label9.Name = "label9";
            label9.Size = new Size(235, 15);
            label9.TabIndex = 31;
            label9.Text = "Tiempos Promedio de espera Por Disciplina";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 696);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 32;
            label10.Text = "Futbol";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(200, 696);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 33;
            label11.Text = "Basket";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 722);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 34;
            label12.Text = "Handball";
            // 
            // txtPromedioEsperaFutbol
            // 
            txtPromedioEsperaFutbol.Location = new Point(79, 691);
            txtPromedioEsperaFutbol.Margin = new Padding(3, 2, 3, 2);
            txtPromedioEsperaFutbol.Name = "txtPromedioEsperaFutbol";
            txtPromedioEsperaFutbol.ReadOnly = true;
            txtPromedioEsperaFutbol.Size = new Size(110, 23);
            txtPromedioEsperaFutbol.TabIndex = 35;
            // 
            // txtPromedioEsperaHandbal
            // 
            txtPromedioEsperaHandbal.Location = new Point(79, 716);
            txtPromedioEsperaHandbal.Margin = new Padding(3, 2, 3, 2);
            txtPromedioEsperaHandbal.Name = "txtPromedioEsperaHandbal";
            txtPromedioEsperaHandbal.ReadOnly = true;
            txtPromedioEsperaHandbal.Size = new Size(110, 23);
            txtPromedioEsperaHandbal.TabIndex = 36;
            // 
            // txtPromedioEsperaBasket
            // 
            txtPromedioEsperaBasket.Location = new Point(250, 691);
            txtPromedioEsperaBasket.Margin = new Padding(3, 2, 3, 2);
            txtPromedioEsperaBasket.Name = "txtPromedioEsperaBasket";
            txtPromedioEsperaBasket.ReadOnly = true;
            txtPromedioEsperaBasket.Size = new Size(110, 23);
            txtPromedioEsperaBasket.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 674);
            label13.Name = "label13";
            label13.Size = new Size(246, 15);
            label13.TabIndex = 38;
            label13.Text = "Promedio de Tiempo libre diario de la cancha";
            // 
            // txtPromedioLibreCancha
            // 
            txtPromedioLibreCancha.Location = new Point(590, 668);
            txtPromedioLibreCancha.Margin = new Padding(3, 2, 3, 2);
            txtPromedioLibreCancha.Name = "txtPromedioLibreCancha";
            txtPromedioLibreCancha.ReadOnly = true;
            txtPromedioLibreCancha.Size = new Size(110, 23);
            txtPromedioLibreCancha.TabIndex = 39;
            // 
            // Evento
            // 
            Evento.HeaderText = "Evento";
            Evento.MinimumWidth = 6;
            Evento.Name = "Evento";
            Evento.ReadOnly = true;
            Evento.Width = 125;
            // 
            // Reloj
            // 
            Reloj.HeaderText = "Reloj";
            Reloj.MinimumWidth = 6;
            Reloj.Name = "Reloj";
            Reloj.ReadOnly = true;
            Reloj.Width = 125;
            // 
            // RND_Llegadas
            // 
            RND_Llegadas.HeaderText = "RND_Llegadas";
            RND_Llegadas.MinimumWidth = 6;
            RND_Llegadas.Name = "RND_Llegadas";
            RND_Llegadas.ReadOnly = true;
            RND_Llegadas.Width = 125;
            // 
            // TiempoEntreLlegadasFutbol
            // 
            TiempoEntreLlegadasFutbol.HeaderText = "TiempoEntreLlegadasFutbol";
            TiempoEntreLlegadasFutbol.MinimumWidth = 6;
            TiempoEntreLlegadasFutbol.Name = "TiempoEntreLlegadasFutbol";
            TiempoEntreLlegadasFutbol.ReadOnly = true;
            TiempoEntreLlegadasFutbol.Width = 170;
            // 
            // ProximaLlegadaFutbol
            // 
            ProximaLlegadaFutbol.HeaderText = "ProximaLlegadaFutbol";
            ProximaLlegadaFutbol.MinimumWidth = 6;
            ProximaLlegadaFutbol.Name = "ProximaLlegadaFutbol";
            ProximaLlegadaFutbol.ReadOnly = true;
            ProximaLlegadaFutbol.Width = 170;
            // 
            // TiempoEntreLlegadasHandball
            // 
            TiempoEntreLlegadasHandball.HeaderText = "TiempoEntreLlegadasHandball";
            TiempoEntreLlegadasHandball.MinimumWidth = 6;
            TiempoEntreLlegadasHandball.Name = "TiempoEntreLlegadasHandball";
            TiempoEntreLlegadasHandball.ReadOnly = true;
            TiempoEntreLlegadasHandball.Width = 170;
            // 
            // ProximaLlegadaHandball
            // 
            ProximaLlegadaHandball.HeaderText = "ProximaLlegadaHandball";
            ProximaLlegadaHandball.MinimumWidth = 6;
            ProximaLlegadaHandball.Name = "ProximaLlegadaHandball";
            ProximaLlegadaHandball.ReadOnly = true;
            ProximaLlegadaHandball.Width = 170;
            // 
            // TiempoEntreLlegadasBasket
            // 
            TiempoEntreLlegadasBasket.HeaderText = "TiempoEntreLlegadasBasket";
            TiempoEntreLlegadasBasket.MinimumWidth = 6;
            TiempoEntreLlegadasBasket.Name = "TiempoEntreLlegadasBasket";
            TiempoEntreLlegadasBasket.ReadOnly = true;
            TiempoEntreLlegadasBasket.Width = 170;
            // 
            // ProximaLlegadaBasket
            // 
            ProximaLlegadaBasket.HeaderText = "ProximaLlegadaBasket";
            ProximaLlegadaBasket.MinimumWidth = 6;
            ProximaLlegadaBasket.Name = "ProximaLlegadaBasket";
            ProximaLlegadaBasket.ReadOnly = true;
            ProximaLlegadaBasket.Width = 170;
            // 
            // RND_Fin_Ocupacion
            // 
            RND_Fin_Ocupacion.HeaderText = "RND_Fin_Ocupacion";
            RND_Fin_Ocupacion.MinimumWidth = 6;
            RND_Fin_Ocupacion.Name = "RND_Fin_Ocupacion";
            RND_Fin_Ocupacion.ReadOnly = true;
            RND_Fin_Ocupacion.Width = 125;
            // 
            // TiempoOcupacionFutbol
            // 
            TiempoOcupacionFutbol.HeaderText = "TiempoOcupacionFutbol";
            TiempoOcupacionFutbol.MinimumWidth = 6;
            TiempoOcupacionFutbol.Name = "TiempoOcupacionFutbol";
            TiempoOcupacionFutbol.ReadOnly = true;
            TiempoOcupacionFutbol.Width = 170;
            // 
            // TiempoOcupacionHandball
            // 
            TiempoOcupacionHandball.HeaderText = "TiempoOcupacionHandball";
            TiempoOcupacionHandball.MinimumWidth = 6;
            TiempoOcupacionHandball.Name = "TiempoOcupacionHandball";
            TiempoOcupacionHandball.ReadOnly = true;
            TiempoOcupacionHandball.Width = 170;
            // 
            // TiempoOcupacionBasquet
            // 
            TiempoOcupacionBasquet.HeaderText = "TiempoOcupacionBasquet";
            TiempoOcupacionBasquet.MinimumWidth = 6;
            TiempoOcupacionBasquet.Name = "TiempoOcupacionBasquet";
            TiempoOcupacionBasquet.ReadOnly = true;
            TiempoOcupacionBasquet.Width = 170;
            // 
            // FinFutbol
            // 
            FinFutbol.HeaderText = "FinFutbol";
            FinFutbol.MinimumWidth = 6;
            FinFutbol.Name = "FinFutbol";
            FinFutbol.ReadOnly = true;
            FinFutbol.Width = 125;
            // 
            // FinHandball
            // 
            FinHandball.HeaderText = "FinHandball";
            FinHandball.MinimumWidth = 6;
            FinHandball.Name = "FinHandball";
            FinHandball.ReadOnly = true;
            FinHandball.Width = 125;
            // 
            // FinBasquet
            // 
            FinBasquet.HeaderText = "FinBasquet";
            FinBasquet.MinimumWidth = 6;
            FinBasquet.Name = "FinBasquet";
            FinBasquet.ReadOnly = true;
            FinBasquet.Width = 125;
            // 
            // FinLimpieza
            // 
            FinLimpieza.HeaderText = "FinLimpieza";
            FinLimpieza.MinimumWidth = 6;
            FinLimpieza.Name = "FinLimpieza";
            FinLimpieza.ReadOnly = true;
            FinLimpieza.Width = 125;
            // 
            // EstadoCancha
            // 
            EstadoCancha.HeaderText = "EstadoCancha";
            EstadoCancha.MinimumWidth = 6;
            EstadoCancha.Name = "EstadoCancha";
            EstadoCancha.ReadOnly = true;
            EstadoCancha.Width = 125;
            // 
            // ColaCancha
            // 
            ColaCancha.HeaderText = "ColaCancha";
            ColaCancha.MinimumWidth = 6;
            ColaCancha.Name = "ColaCancha";
            ColaCancha.ReadOnly = true;
            ColaCancha.Width = 125;
            // 
            // EstadoLimpiador
            // 
            EstadoLimpiador.HeaderText = "EstadoLimpiador";
            EstadoLimpiador.MinimumWidth = 6;
            EstadoLimpiador.Name = "EstadoLimpiador";
            EstadoLimpiador.ReadOnly = true;
            EstadoLimpiador.Width = 125;
            // 
            // CEF
            // 
            CEF.HeaderText = "Contador Equipos Futbol";
            CEF.Name = "CEF";
            // 
            // CEH
            // 
            CEH.HeaderText = "Contador Equipos Handball";
            CEH.Name = "CEH";
            // 
            // CEB
            // 
            CEB.HeaderText = "Contador Equipos Basquet";
            CEB.Name = "CEB";
            // 
            // AC_TiempoEsperaFutbol
            // 
            AC_TiempoEsperaFutbol.HeaderText = "AC_TiempoEsperaFutbol";
            AC_TiempoEsperaFutbol.MinimumWidth = 6;
            AC_TiempoEsperaFutbol.Name = "AC_TiempoEsperaFutbol";
            AC_TiempoEsperaFutbol.ReadOnly = true;
            AC_TiempoEsperaFutbol.Width = 170;
            // 
            // AC_TiempoEsperaHandball
            // 
            AC_TiempoEsperaHandball.HeaderText = "AC_TiempoEsperaHandball";
            AC_TiempoEsperaHandball.MinimumWidth = 6;
            AC_TiempoEsperaHandball.Name = "AC_TiempoEsperaHandball";
            AC_TiempoEsperaHandball.ReadOnly = true;
            AC_TiempoEsperaHandball.Width = 170;
            // 
            // AC_TiempoEsperaBasquet
            // 
            AC_TiempoEsperaBasquet.HeaderText = "AC_TiempoEsperaBasquet";
            AC_TiempoEsperaBasquet.MinimumWidth = 6;
            AC_TiempoEsperaBasquet.Name = "AC_TiempoEsperaBasquet";
            AC_TiempoEsperaBasquet.ReadOnly = true;
            AC_TiempoEsperaBasquet.Width = 170;
            // 
            // AC_TiempoLibreCancha
            // 
            AC_TiempoLibreCancha.HeaderText = "AC_TiempoLibreCancha";
            AC_TiempoLibreCancha.MinimumWidth = 6;
            AC_TiempoLibreCancha.Name = "AC_TiempoLibreCancha";
            AC_TiempoLibreCancha.ReadOnly = true;
            AC_TiempoLibreCancha.Width = 170;
            // 
            // ContadorDias
            // 
            ContadorDias.HeaderText = "ContadorDias";
            ContadorDias.MinimumWidth = 6;
            ContadorDias.Name = "ContadorDias";
            ContadorDias.ReadOnly = true;
            ContadorDias.Width = 125;
            // 
            // Estado1
            // 
            Estado1.HeaderText = "Estado1";
            Estado1.MinimumWidth = 6;
            Estado1.Name = "Estado1";
            Estado1.ReadOnly = true;
            Estado1.Width = 125;
            // 
            // Disciplina1
            // 
            Disciplina1.HeaderText = "Disciplina1";
            Disciplina1.MinimumWidth = 6;
            Disciplina1.Name = "Disciplina1";
            Disciplina1.ReadOnly = true;
            Disciplina1.Width = 125;
            // 
            // HoraLlegada1
            // 
            HoraLlegada1.HeaderText = "HoraLlegada1";
            HoraLlegada1.MinimumWidth = 6;
            HoraLlegada1.Name = "HoraLlegada1";
            HoraLlegada1.ReadOnly = true;
            HoraLlegada1.Width = 125;
            // 
            // Estado2
            // 
            Estado2.HeaderText = "Estado2";
            Estado2.MinimumWidth = 6;
            Estado2.Name = "Estado2";
            Estado2.ReadOnly = true;
            Estado2.Width = 125;
            // 
            // Disciplina2
            // 
            Disciplina2.HeaderText = "Disciplina2";
            Disciplina2.MinimumWidth = 6;
            Disciplina2.Name = "Disciplina2";
            Disciplina2.ReadOnly = true;
            Disciplina2.Width = 125;
            // 
            // HoraLlegada2
            // 
            HoraLlegada2.HeaderText = "HoraLlegada2";
            HoraLlegada2.MinimumWidth = 6;
            HoraLlegada2.Name = "HoraLlegada2";
            HoraLlegada2.ReadOnly = true;
            HoraLlegada2.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 765);
            Controls.Add(txtPromedioLibreCancha);
            Controls.Add(label13);
            Controls.Add(txtPromedioEsperaBasket);
            Controls.Add(txtPromedioEsperaHandbal);
            Controls.Add(txtPromedioEsperaFutbol);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnCargaPorDefecto);
            Controls.Add(btnSimulacion);
            Controls.Add(txtTiempoLimpieza);
            Controls.Add(label8);
            Controls.Add(txtLimiteGruposEnCola);
            Controls.Add(label7);
            Controls.Add(txtOcupacion_B_Futbol);
            Controls.Add(txtOcupacion_A_Futbol);
            Controls.Add(txtOcupacion_B_Basket);
            Controls.Add(txtOcupacion_A_Basket);
            Controls.Add(txtOcupacion_B_Handbal);
            Controls.Add(txtOcupacion_A_Handbal);
            Controls.Add(label6);
            Controls.Add(dtgOcupacion);
            Controls.Add(txtLlegada_B_Basket);
            Controls.Add(txt_Llegada_A_Basket);
            Controls.Add(txt_Llegada_B_Handball);
            Controls.Add(txtLlegada_A_Handball);
            Controls.Add(txtMediaFutbolLlegada);
            Controls.Add(lalbel6);
            Controls.Add(dtgLlegadas);
            Controls.Add(txtHoraDesde);
            Controls.Add(txtIteracionesMostrar);
            Controls.Add(txtTiempoTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgLlegadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgOcupacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTiempoTotal;
        private TextBox txtTotalIteraciones;
        private TextBox txtIteracionesMostrar;
        private TextBox txtHoraDesde;
        private DataGridView dtgLlegadas;
        private Label lalbel6;
        private TextBox txtMediaFutbolLlegada;
        private TextBox txtLlegada_A_Handball;
        private TextBox txt_Llegada_B_Handball;
        private TextBox txt_Llegada_A_Basket;
        private TextBox txtLlegada_B_Basket;
        private DataGridViewTextBoxColumn Disciplina;
        private DataGridViewTextBoxColumn Llegadas;
        private TextBox txtOcupacion_B_Basket;
        private TextBox txtOcupacion_A_Basket;
        private TextBox txtOcupacion_B_Handbal;
        private TextBox txtOcupacion_A_Handbal;
        private Label label6;
        private DataGridView dtgOcupacion;
        private DataGridViewTextBoxColumn Disiplina;
        private DataGridViewTextBoxColumn Ocupacion;
        private TextBox txtOcupacion_B_Futbol;
        private TextBox txtOcupacion_A_Futbol;
        private Label label7;
        private TextBox txtLimiteGruposEnCola;
        private Label label8;
        private TextBox txtTiempoLimpieza;
        private Button btnCargaPorDefecto;
         private Button btnSimulacion;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtPromedioEsperaFutbol;
        private TextBox txtPromedioEsperaHandbal;
        private TextBox txtPromedioEsperaBasket;
        private Label label13;
        private TextBox txtPromedioLibreCancha;
        private DataGridViewTextBoxColumn Evento;
        private DataGridViewTextBoxColumn Reloj;
        private DataGridViewTextBoxColumn RND_Llegadas;
        private DataGridViewTextBoxColumn TiempoEntreLlegadasFutbol;
        private DataGridViewTextBoxColumn ProximaLlegadaFutbol;
        private DataGridViewTextBoxColumn TiempoEntreLlegadasHandball;
        private DataGridViewTextBoxColumn ProximaLlegadaHandball;
        private DataGridViewTextBoxColumn TiempoEntreLlegadasBasket;
        private DataGridViewTextBoxColumn ProximaLlegadaBasket;
        private DataGridViewTextBoxColumn RND_Fin_Ocupacion;
        private DataGridViewTextBoxColumn TiempoOcupacionFutbol;
        private DataGridViewTextBoxColumn TiempoOcupacionHandball;
        private DataGridViewTextBoxColumn TiempoOcupacionBasquet;
        private DataGridViewTextBoxColumn FinFutbol;
        private DataGridViewTextBoxColumn FinHandball;
        private DataGridViewTextBoxColumn FinBasquet;
        private DataGridViewTextBoxColumn FinLimpieza;
        private DataGridViewTextBoxColumn EstadoCancha;
        private DataGridViewTextBoxColumn ColaCancha;
        private DataGridViewTextBoxColumn EstadoLimpiador;
        private DataGridViewTextBoxColumn CEF;
        private DataGridViewTextBoxColumn CEH;
        private DataGridViewTextBoxColumn CEB;
        private DataGridViewTextBoxColumn AC_TiempoEsperaFutbol;
        private DataGridViewTextBoxColumn AC_TiempoEsperaHandball;
        private DataGridViewTextBoxColumn AC_TiempoEsperaBasquet;
        private DataGridViewTextBoxColumn AC_TiempoLibreCancha;
        private DataGridViewTextBoxColumn ContadorDias;
        private DataGridViewTextBoxColumn Estado1;
        private DataGridViewTextBoxColumn Disciplina1;
        private DataGridViewTextBoxColumn HoraLlegada1;
        private DataGridViewTextBoxColumn Estado2;
        private DataGridViewTextBoxColumn Disciplina2;
        private DataGridViewTextBoxColumn HoraLlegada2;
    }
}
