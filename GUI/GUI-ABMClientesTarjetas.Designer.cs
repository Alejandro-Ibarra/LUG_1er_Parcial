
namespace GUI
{
    partial class GUI_ABMClientesTarjetas
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
            this.DataGrid_ABM_Cliente = new System.Windows.Forms.DataGridView();
            this.DataGrid_ABM_Tarjeta_Nac = new System.Windows.Forms.DataGridView();
            this.TextBox_DNI = new System.Windows.Forms.TextBox();
            this.DateTimePicker_Cliente = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePicker_Tarjeta = new System.Windows.Forms.DateTimePicker();
            this.ComboBox_Rubro = new System.Windows.Forms.ComboBox();
            this.ComboBox_Provincia = new System.Windows.Forms.ComboBox();
            this.ComboBox_Pais = new System.Windows.Forms.ComboBox();
            this.TextBox_Monto = new System.Windows.Forms.TextBox();
            this.Button_Baja_Cliente = new System.Windows.Forms.Button();
            this.Button_Borrar_Tarjeta = new System.Windows.Forms.Button();
            this.Button_Modificar_Tarjeta = new System.Windows.Forms.Button();
            this.Button_Alta_Tarjeta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_Tarj_Menor_Imp = new System.Windows.Forms.TextBox();
            this.TextBox_Tarj_Mayor_Desc = new System.Windows.Forms.TextBox();
            this.Button_Alta_Cliente = new System.Windows.Forms.Button();
            this.Button_Mod_Cliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Apellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_Cod_Cliente = new System.Windows.Forms.TextBox();
            this.DataGrid_ABM_Tarjeta_Int = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_Cod_tarjeta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonMenorSaldo = new System.Windows.Forms.Button();
            this.Button_Mayores_Descuentos = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta_Nac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta_Int)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_ABM_Cliente
            // 
            this.DataGrid_ABM_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ABM_Cliente.Location = new System.Drawing.Point(12, 118);
            this.DataGrid_ABM_Cliente.MultiSelect = false;
            this.DataGrid_ABM_Cliente.Name = "DataGrid_ABM_Cliente";
            this.DataGrid_ABM_Cliente.ReadOnly = true;
            this.DataGrid_ABM_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Cliente.Size = new System.Drawing.Size(425, 310);
            this.DataGrid_ABM_Cliente.TabIndex = 0;
            this.DataGrid_ABM_Cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_ABM_Cliente_MouseClick);
            // 
            // DataGrid_ABM_Tarjeta_Nac
            // 
            this.DataGrid_ABM_Tarjeta_Nac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ABM_Tarjeta_Nac.Location = new System.Drawing.Point(513, 134);
            this.DataGrid_ABM_Tarjeta_Nac.MultiSelect = false;
            this.DataGrid_ABM_Tarjeta_Nac.Name = "DataGrid_ABM_Tarjeta_Nac";
            this.DataGrid_ABM_Tarjeta_Nac.ReadOnly = true;
            this.DataGrid_ABM_Tarjeta_Nac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta_Nac.Size = new System.Drawing.Size(587, 131);
            this.DataGrid_ABM_Tarjeta_Nac.TabIndex = 1;
            this.DataGrid_ABM_Tarjeta_Nac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_ABM_Tarjeta_Nac_MouseClick);
            // 
            // TextBox_DNI
            // 
            this.TextBox_DNI.Location = new System.Drawing.Point(12, 83);
            this.TextBox_DNI.Multiline = true;
            this.TextBox_DNI.Name = "TextBox_DNI";
            this.TextBox_DNI.Size = new System.Drawing.Size(90, 21);
            this.TextBox_DNI.TabIndex = 5;
            // 
            // DateTimePicker_Cliente
            // 
            this.DateTimePicker_Cliente.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker_Cliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_Cliente.Location = new System.Drawing.Point(125, 83);
            this.DateTimePicker_Cliente.Name = "DateTimePicker_Cliente";
            this.DateTimePicker_Cliente.Size = new System.Drawing.Size(90, 20);
            this.DateTimePicker_Cliente.TabIndex = 6;
            this.DateTimePicker_Cliente.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // TextBox_Numero
            // 
            this.TextBox_Numero.Location = new System.Drawing.Point(643, 47);
            this.TextBox_Numero.Multiline = true;
            this.TextBox_Numero.Name = "TextBox_Numero";
            this.TextBox_Numero.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Numero.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Venc.";
            // 
            // DateTimePicker_Tarjeta
            // 
            this.DateTimePicker_Tarjeta.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker_Tarjeta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_Tarjeta.Location = new System.Drawing.Point(513, 84);
            this.DateTimePicker_Tarjeta.Name = "DateTimePicker_Tarjeta";
            this.DateTimePicker_Tarjeta.Size = new System.Drawing.Size(90, 20);
            this.DateTimePicker_Tarjeta.TabIndex = 13;
            // 
            // ComboBox_Rubro
            // 
            this.ComboBox_Rubro.FormattingEnabled = true;
            this.ComboBox_Rubro.Location = new System.Drawing.Point(774, 86);
            this.ComboBox_Rubro.Name = "ComboBox_Rubro";
            this.ComboBox_Rubro.Size = new System.Drawing.Size(90, 21);
            this.ComboBox_Rubro.TabIndex = 33;
            // 
            // ComboBox_Provincia
            // 
            this.ComboBox_Provincia.FormattingEnabled = true;
            this.ComboBox_Provincia.Location = new System.Drawing.Point(895, 86);
            this.ComboBox_Provincia.Name = "ComboBox_Provincia";
            this.ComboBox_Provincia.Size = new System.Drawing.Size(90, 21);
            this.ComboBox_Provincia.TabIndex = 34;
            // 
            // ComboBox_Pais
            // 
            this.ComboBox_Pais.FormattingEnabled = true;
            this.ComboBox_Pais.Location = new System.Drawing.Point(774, 45);
            this.ComboBox_Pais.Name = "ComboBox_Pais";
            this.ComboBox_Pais.Size = new System.Drawing.Size(90, 21);
            this.ComboBox_Pais.TabIndex = 35;
            this.ComboBox_Pais.SelectedValueChanged += new System.EventHandler(this.ComboBox_Pais_SelectedValueChanged);
            // 
            // TextBox_Monto
            // 
            this.TextBox_Monto.Location = new System.Drawing.Point(643, 84);
            this.TextBox_Monto.Multiline = true;
            this.TextBox_Monto.Name = "TextBox_Monto";
            this.TextBox_Monto.ReadOnly = true;
            this.TextBox_Monto.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Monto.TabIndex = 36;
            // 
            // Button_Baja_Cliente
            // 
            this.Button_Baja_Cliente.Location = new System.Drawing.Point(337, 84);
            this.Button_Baja_Cliente.Name = "Button_Baja_Cliente";
            this.Button_Baja_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Baja_Cliente.TabIndex = 39;
            this.Button_Baja_Cliente.Text = "Borrar";
            this.Button_Baja_Cliente.UseVisualStyleBackColor = true;
            this.Button_Baja_Cliente.Click += new System.EventHandler(this.Button_Baja_Cliente_Click);
            // 
            // Button_Borrar_Tarjeta
            // 
            this.Button_Borrar_Tarjeta.Location = new System.Drawing.Point(1000, 83);
            this.Button_Borrar_Tarjeta.Name = "Button_Borrar_Tarjeta";
            this.Button_Borrar_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Borrar_Tarjeta.TabIndex = 42;
            this.Button_Borrar_Tarjeta.Text = "Borrar";
            this.Button_Borrar_Tarjeta.UseVisualStyleBackColor = true;
            this.Button_Borrar_Tarjeta.Click += new System.EventHandler(this.Button_Borrar_Tarjeta_Click);
            // 
            // Button_Modificar_Tarjeta
            // 
            this.Button_Modificar_Tarjeta.Location = new System.Drawing.Point(1000, 61);
            this.Button_Modificar_Tarjeta.Name = "Button_Modificar_Tarjeta";
            this.Button_Modificar_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Modificar_Tarjeta.TabIndex = 41;
            this.Button_Modificar_Tarjeta.Text = "Modificar";
            this.Button_Modificar_Tarjeta.UseVisualStyleBackColor = true;
            this.Button_Modificar_Tarjeta.Click += new System.EventHandler(this.Button_Modificar_Tarjeta_Click);
            // 
            // Button_Alta_Tarjeta
            // 
            this.Button_Alta_Tarjeta.Location = new System.Drawing.Point(1000, 39);
            this.Button_Alta_Tarjeta.Name = "Button_Alta_Tarjeta";
            this.Button_Alta_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Alta_Tarjeta.TabIndex = 40;
            this.Button_Alta_Tarjeta.Text = "Alta";
            this.Button_Alta_Tarjeta.UseVisualStyleBackColor = true;
            this.Button_Alta_Tarjeta.Click += new System.EventHandler(this.Button_Alta_Tarjeta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(771, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Rubro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(771, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "País";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(892, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Provincia";
            // 
            // TextBox_Tarj_Menor_Imp
            // 
            this.TextBox_Tarj_Menor_Imp.Location = new System.Drawing.Point(513, 444);
            this.TextBox_Tarj_Menor_Imp.Multiline = true;
            this.TextBox_Tarj_Menor_Imp.Name = "TextBox_Tarj_Menor_Imp";
            this.TextBox_Tarj_Menor_Imp.Size = new System.Drawing.Size(587, 20);
            this.TextBox_Tarj_Menor_Imp.TabIndex = 48;
            // 
            // TextBox_Tarj_Mayor_Desc
            // 
            this.TextBox_Tarj_Mayor_Desc.Location = new System.Drawing.Point(513, 470);
            this.TextBox_Tarj_Mayor_Desc.Multiline = true;
            this.TextBox_Tarj_Mayor_Desc.Name = "TextBox_Tarj_Mayor_Desc";
            this.TextBox_Tarj_Mayor_Desc.Size = new System.Drawing.Size(587, 20);
            this.TextBox_Tarj_Mayor_Desc.TabIndex = 49;
            // 
            // Button_Alta_Cliente
            // 
            this.Button_Alta_Cliente.Location = new System.Drawing.Point(337, 39);
            this.Button_Alta_Cliente.Name = "Button_Alta_Cliente";
            this.Button_Alta_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Alta_Cliente.TabIndex = 37;
            this.Button_Alta_Cliente.Text = "Alta";
            this.Button_Alta_Cliente.UseVisualStyleBackColor = true;
            this.Button_Alta_Cliente.Click += new System.EventHandler(this.Button_Alta_Cliente_Click);
            // 
            // Button_Mod_Cliente
            // 
            this.Button_Mod_Cliente.Location = new System.Drawing.Point(337, 62);
            this.Button_Mod_Cliente.Name = "Button_Mod_Cliente";
            this.Button_Mod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Mod_Cliente.TabIndex = 38;
            this.Button_Mod_Cliente.Text = "Modificar";
            this.Button_Mod_Cliente.UseVisualStyleBackColor = true;
            this.Button_Mod_Cliente.Click += new System.EventHandler(this.Button_Mod_Cliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(12, 40);
            this.TextBox_Nombre.Multiline = true;
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Nombre.TabIndex = 2;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Location = new System.Drawing.Point(125, 42);
            this.TextBox_Apellido.Multiline = true;
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Apellido.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Codigo";
            // 
            // TextBox_Cod_Cliente
            // 
            this.TextBox_Cod_Cliente.Location = new System.Drawing.Point(236, 42);
            this.TextBox_Cod_Cliente.Multiline = true;
            this.TextBox_Cod_Cliente.Name = "TextBox_Cod_Cliente";
            this.TextBox_Cod_Cliente.ReadOnly = true;
            this.TextBox_Cod_Cliente.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Cod_Cliente.TabIndex = 50;
            // 
            // DataGrid_ABM_Tarjeta_Int
            // 
            this.DataGrid_ABM_Tarjeta_Int.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ABM_Tarjeta_Int.Location = new System.Drawing.Point(514, 297);
            this.DataGrid_ABM_Tarjeta_Int.MultiSelect = false;
            this.DataGrid_ABM_Tarjeta_Int.Name = "DataGrid_ABM_Tarjeta_Int";
            this.DataGrid_ABM_Tarjeta_Int.ReadOnly = true;
            this.DataGrid_ABM_Tarjeta_Int.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta_Int.Size = new System.Drawing.Size(587, 131);
            this.DataGrid_ABM_Tarjeta_Int.TabIndex = 54;
            this.DataGrid_ABM_Tarjeta_Int.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_ABM_Tarjeta_Int_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Codigo";
            // 
            // TextBox_Cod_tarjeta
            // 
            this.TextBox_Cod_tarjeta.Enabled = false;
            this.TextBox_Cod_tarjeta.Location = new System.Drawing.Point(514, 48);
            this.TextBox_Cod_tarjeta.Multiline = true;
            this.TextBox_Cod_tarjeta.Name = "TextBox_Cod_tarjeta";
            this.TextBox_Cod_tarjeta.Size = new System.Drawing.Size(90, 21);
            this.TextBox_Cod_tarjeta.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(511, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Tarjetas Nacionales";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(511, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Tarjetas Internacionales";
            // 
            // ButtonMenorSaldo
            // 
            this.ButtonMenorSaldo.Location = new System.Drawing.Point(432, 442);
            this.ButtonMenorSaldo.Name = "ButtonMenorSaldo";
            this.ButtonMenorSaldo.Size = new System.Drawing.Size(75, 23);
            this.ButtonMenorSaldo.TabIndex = 59;
            this.ButtonMenorSaldo.Text = "Calcular";
            this.ButtonMenorSaldo.UseVisualStyleBackColor = true;
            this.ButtonMenorSaldo.Click += new System.EventHandler(this.ButtonMenorSaldo_Click);
            // 
            // Button_Mayores_Descuentos
            // 
            this.Button_Mayores_Descuentos.Location = new System.Drawing.Point(431, 467);
            this.Button_Mayores_Descuentos.Name = "Button_Mayores_Descuentos";
            this.Button_Mayores_Descuentos.Size = new System.Drawing.Size(75, 23);
            this.Button_Mayores_Descuentos.TabIndex = 60;
            this.Button_Mayores_Descuentos.Text = "Calcular";
            this.Button_Mayores_Descuentos.UseVisualStyleBackColor = true;
            this.Button_Mayores_Descuentos.Click += new System.EventHandler(this.Button_Mayores_Descuentos_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(310, 447);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Tarjeta menor Saldo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 472);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Tarjeta Mayor descuento";
            // 
            // GUI_ABMClientesTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 506);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Button_Mayores_Descuentos);
            this.Controls.Add(this.ButtonMenorSaldo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TextBox_Cod_tarjeta);
            this.Controls.Add(this.DataGrid_ABM_Tarjeta_Int);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBox_Cod_Cliente);
            this.Controls.Add(this.TextBox_Tarj_Mayor_Desc);
            this.Controls.Add(this.TextBox_Tarj_Menor_Imp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_Borrar_Tarjeta);
            this.Controls.Add(this.Button_Modificar_Tarjeta);
            this.Controls.Add(this.Button_Alta_Tarjeta);
            this.Controls.Add(this.Button_Baja_Cliente);
            this.Controls.Add(this.Button_Mod_Cliente);
            this.Controls.Add(this.Button_Alta_Cliente);
            this.Controls.Add(this.TextBox_Monto);
            this.Controls.Add(this.ComboBox_Pais);
            this.Controls.Add(this.ComboBox_Provincia);
            this.Controls.Add(this.ComboBox_Rubro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimePicker_Tarjeta);
            this.Controls.Add(this.TextBox_Numero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker_Cliente);
            this.Controls.Add(this.TextBox_DNI);
            this.Controls.Add(this.TextBox_Apellido);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.DataGrid_ABM_Tarjeta_Nac);
            this.Controls.Add(this.DataGrid_ABM_Cliente);
            this.Name = "GUI_ABMClientesTarjetas";
            this.Text = "GUI_ABMClientesTarjetas";
            this.Load += new System.EventHandler(this.GUI_ABMClientesTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta_Nac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta_Int)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_ABM_Cliente;
        private System.Windows.Forms.DataGridView DataGrid_ABM_Tarjeta_Nac;
        private System.Windows.Forms.TextBox TextBox_DNI;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Tarjeta;
        private System.Windows.Forms.ComboBox ComboBox_Rubro;
        private System.Windows.Forms.ComboBox ComboBox_Provincia;
        private System.Windows.Forms.ComboBox ComboBox_Pais;
        private System.Windows.Forms.TextBox TextBox_Monto;
        private System.Windows.Forms.Button Button_Baja_Cliente;
        private System.Windows.Forms.Button Button_Borrar_Tarjeta;
        private System.Windows.Forms.Button Button_Modificar_Tarjeta;
        private System.Windows.Forms.Button Button_Alta_Tarjeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_Tarj_Menor_Imp;
        private System.Windows.Forms.TextBox TextBox_Tarj_Mayor_Desc;
        private System.Windows.Forms.Button Button_Alta_Cliente;
        private System.Windows.Forms.Button Button_Mod_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Apellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox_Cod_Cliente;
        private System.Windows.Forms.DataGridView DataGrid_ABM_Tarjeta_Int;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBox_Cod_tarjeta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ButtonMenorSaldo;
        private System.Windows.Forms.Button Button_Mayores_Descuentos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}