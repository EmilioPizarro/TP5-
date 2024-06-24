namespace Polideportivo_Colón
{
    partial class VtnEuler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txth_paso_read = new TextBox();
            txt_d_futbol_read = new TextBox();
            txt_d_basket_read = new TextBox();
            txt_d_handball_read = new TextBox();
            dtg_euler_futbol = new DataGridView();
            t = new DataGridViewTextBoxColumn();
            D = new DataGridViewTextBoxColumn();
            h_dDdT = new DataGridViewTextBoxColumn();
            t_1 = new DataGridViewTextBoxColumn();
            D_1 = new DataGridViewTextBoxColumn();
            dtg_euler_basket = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dtg_euler_handball = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txt_cont_Limpieza = new TextBox();
            btn_cargarTablas = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_euler_futbol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_euler_basket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_euler_handball).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "h (Paso)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Futbol";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Basket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(959, 77);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Handball";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 115);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 4;
            label5.Text = "D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 112);
            label6.Name = "label6";
            label6.Size = new Size(20, 20);
            label6.TabIndex = 5;
            label6.Text = "D";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(959, 112);
            label7.Name = "label7";
            label7.Size = new Size(20, 20);
            label7.TabIndex = 6;
            label7.Text = "D";
            // 
            // txth_paso_read
            // 
            txth_paso_read.Location = new Point(80, 12);
            txth_paso_read.Name = "txth_paso_read";
            txth_paso_read.ReadOnly = true;
            txth_paso_read.Size = new Size(73, 27);
            txth_paso_read.TabIndex = 7;
            // 
            // txt_d_futbol_read
            // 
            txt_d_futbol_read.Location = new Point(33, 108);
            txt_d_futbol_read.Name = "txt_d_futbol_read";
            txt_d_futbol_read.ReadOnly = true;
            txt_d_futbol_read.Size = new Size(73, 27);
            txt_d_futbol_read.TabIndex = 8;
            // 
            // txt_d_basket_read
            // 
            txt_d_basket_read.Location = new Point(515, 105);
            txt_d_basket_read.Name = "txt_d_basket_read";
            txt_d_basket_read.ReadOnly = true;
            txt_d_basket_read.Size = new Size(73, 27);
            txt_d_basket_read.TabIndex = 9;
            // 
            // txt_d_handball_read
            // 
            txt_d_handball_read.Location = new Point(985, 105);
            txt_d_handball_read.Name = "txt_d_handball_read";
            txt_d_handball_read.ReadOnly = true;
            txt_d_handball_read.Size = new Size(73, 27);
            txt_d_handball_read.TabIndex = 10;
            // 
            // dtg_euler_futbol
            // 
            dtg_euler_futbol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_euler_futbol.Columns.AddRange(new DataGridViewColumn[] { t, D, h_dDdT, t_1, D_1 });
            dtg_euler_futbol.Location = new Point(12, 149);
            dtg_euler_futbol.Name = "dtg_euler_futbol";
            dtg_euler_futbol.RowHeadersWidth = 51;
            dtg_euler_futbol.Size = new Size(456, 507);
            dtg_euler_futbol.TabIndex = 11;
            // 
            // t
            // 
            t.HeaderText = "t";
            t.MinimumWidth = 6;
            t.Name = "t";
            t.ReadOnly = true;
            t.Width = 80;
            // 
            // D
            // 
            D.HeaderText = "D";
            D.MinimumWidth = 6;
            D.Name = "D";
            D.ReadOnly = true;
            D.Width = 80;
            // 
            // h_dDdT
            // 
            h_dDdT.HeaderText = "h_dDdT";
            h_dDdT.MinimumWidth = 6;
            h_dDdT.Name = "h_dDdT";
            h_dDdT.ReadOnly = true;
            h_dDdT.Width = 80;
            // 
            // t_1
            // 
            t_1.HeaderText = "t_1";
            t_1.MinimumWidth = 6;
            t_1.Name = "t_1";
            t_1.ReadOnly = true;
            t_1.Width = 80;
            // 
            // D_1
            // 
            D_1.HeaderText = "D_1";
            D_1.MinimumWidth = 6;
            D_1.Name = "D_1";
            D_1.ReadOnly = true;
            D_1.Width = 80;
            // 
            // dtg_euler_basket
            // 
            dtg_euler_basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_euler_basket.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dtg_euler_basket.Location = new Point(488, 149);
            dtg_euler_basket.Name = "dtg_euler_basket";
            dtg_euler_basket.RowHeadersWidth = 51;
            dtg_euler_basket.Size = new Size(456, 507);
            dtg_euler_basket.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "t";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "D";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "h_dDdT";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "t_1";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "D_1";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dtg_euler_handball
            // 
            dtg_euler_handball.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_euler_handball.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dtg_euler_handball.Location = new Point(961, 149);
            dtg_euler_handball.Name = "dtg_euler_handball";
            dtg_euler_handball.RowHeadersWidth = 51;
            dtg_euler_handball.Size = new Size(456, 507);
            dtg_euler_handball.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "t";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "D";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "h_dDdT";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "t_1";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "D_1";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(172, 19);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 14;
            label8.Text = "Cont Limpieza (C)";
            // 
            // txt_cont_Limpieza
            // 
            txt_cont_Limpieza.Location = new Point(305, 16);
            txt_cont_Limpieza.Name = "txt_cont_Limpieza";
            txt_cont_Limpieza.Size = new Size(125, 27);
            txt_cont_Limpieza.TabIndex = 15;
            // 
            // btn_cargarTablas
            // 
            btn_cargarTablas.Location = new Point(447, 14);
            btn_cargarTablas.Name = "btn_cargarTablas";
            btn_cargarTablas.Size = new Size(119, 29);
            btn_cargarTablas.TabIndex = 16;
            btn_cargarTablas.Text = "Cargar Tablas";
            btn_cargarTablas.UseVisualStyleBackColor = true;
            btn_cargarTablas.Click += btnCargarTablas_Click;
            // 
            // VtnEuler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 706);
            Controls.Add(btn_cargarTablas);
            Controls.Add(txt_cont_Limpieza);
            Controls.Add(label8);
            Controls.Add(dtg_euler_handball);
            Controls.Add(dtg_euler_basket);
            Controls.Add(dtg_euler_futbol);
            Controls.Add(txt_d_handball_read);
            Controls.Add(txt_d_basket_read);
            Controls.Add(txt_d_futbol_read);
            Controls.Add(txth_paso_read);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VtnEuler";
            Text = "VtnRk";
            Load += VtnEuler_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_euler_futbol).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_euler_basket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_euler_handball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txth_paso_read;
        private TextBox txt_d_futbol_read;
        private TextBox txt_d_basket_read;
        private TextBox txt_d_handball_read;
        private DataGridView dtg_euler_futbol;
        private DataGridViewTextBoxColumn t;
        private DataGridViewTextBoxColumn D;
        private DataGridViewTextBoxColumn h_dDdT;
        private DataGridViewTextBoxColumn t_1;
        private DataGridViewTextBoxColumn D_1;
        private DataGridView dtg_euler_basket;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dtg_euler_handball;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label8;
        private TextBox txt_cont_Limpieza;
        private Button btn_cargarTablas;
    }
}