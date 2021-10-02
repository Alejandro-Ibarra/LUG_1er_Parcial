﻿
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
            this.DataGrid_ABM_Tarjeta = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_ABM_Cliente
            // 
            this.DataGrid_ABM_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ABM_Cliente.Location = new System.Drawing.Point(12, 118);
            this.DataGrid_ABM_Cliente.Name = "DataGrid_ABM_Cliente";
            this.DataGrid_ABM_Cliente.Size = new System.Drawing.Size(507, 310);
            this.DataGrid_ABM_Cliente.TabIndex = 0;
            // 
            // DataGrid_ABM_Tarjeta
            // 
            this.DataGrid_ABM_Tarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ABM_Tarjeta.Location = new System.Drawing.Point(593, 118);
            this.DataGrid_ABM_Tarjeta.Name = "DataGrid_ABM_Tarjeta";
            this.DataGrid_ABM_Tarjeta.Size = new System.Drawing.Size(507, 310);
            this.DataGrid_ABM_Tarjeta.TabIndex = 1;
            // 
            // TextBox_DNI
            // 
            this.TextBox_DNI.Location = new System.Drawing.Point(25, 82);
            this.TextBox_DNI.Multiline = true;
            this.TextBox_DNI.Name = "TextBox_DNI";
            this.TextBox_DNI.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DNI.TabIndex = 5;
            // 
            // DateTimePicker_Cliente
            // 
            this.DateTimePicker_Cliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_Cliente.Location = new System.Drawing.Point(173, 82);
            this.DateTimePicker_Cliente.Name = "DateTimePicker_Cliente";
            this.DateTimePicker_Cliente.Size = new System.Drawing.Size(100, 20);
            this.DateTimePicker_Cliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // TextBox_Numero
            // 
            this.TextBox_Numero.Location = new System.Drawing.Point(593, 39);
            this.TextBox_Numero.Multiline = true;
            this.TextBox_Numero.Name = "TextBox_Numero";
            this.TextBox_Numero.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Numero.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // DateTimePicker_Tarjeta
            // 
            this.DateTimePicker_Tarjeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_Tarjeta.Location = new System.Drawing.Point(593, 79);
            this.DateTimePicker_Tarjeta.Name = "DateTimePicker_Tarjeta";
            this.DateTimePicker_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.DateTimePicker_Tarjeta.TabIndex = 13;
            // 
            // ComboBox_Rubro
            // 
            this.ComboBox_Rubro.FormattingEnabled = true;
            this.ComboBox_Rubro.Location = new System.Drawing.Point(723, 81);
            this.ComboBox_Rubro.Name = "ComboBox_Rubro";
            this.ComboBox_Rubro.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_Rubro.TabIndex = 33;
            // 
            // ComboBox_Provincia
            // 
            this.ComboBox_Provincia.FormattingEnabled = true;
            this.ComboBox_Provincia.Location = new System.Drawing.Point(845, 82);
            this.ComboBox_Provincia.Name = "ComboBox_Provincia";
            this.ComboBox_Provincia.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_Provincia.TabIndex = 34;
            // 
            // ComboBox_Pais
            // 
            this.ComboBox_Pais.FormattingEnabled = true;
            this.ComboBox_Pais.Location = new System.Drawing.Point(845, 38);
            this.ComboBox_Pais.Name = "ComboBox_Pais";
            this.ComboBox_Pais.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_Pais.TabIndex = 35;
            // 
            // TextBox_Monto
            // 
            this.TextBox_Monto.Location = new System.Drawing.Point(723, 39);
            this.TextBox_Monto.Multiline = true;
            this.TextBox_Monto.Name = "TextBox_Monto";
            this.TextBox_Monto.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Monto.TabIndex = 36;
            // 
            // Button_Baja_Cliente
            // 
            this.Button_Baja_Cliente.Location = new System.Drawing.Point(301, 84);
            this.Button_Baja_Cliente.Name = "Button_Baja_Cliente";
            this.Button_Baja_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Baja_Cliente.TabIndex = 39;
            this.Button_Baja_Cliente.Text = "Borrar";
            this.Button_Baja_Cliente.UseVisualStyleBackColor = true;
            // 
            // Button_Borrar_Tarjeta
            // 
            this.Button_Borrar_Tarjeta.Location = new System.Drawing.Point(985, 84);
            this.Button_Borrar_Tarjeta.Name = "Button_Borrar_Tarjeta";
            this.Button_Borrar_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Borrar_Tarjeta.TabIndex = 42;
            this.Button_Borrar_Tarjeta.Text = "Borrar";
            this.Button_Borrar_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // Button_Modificar_Tarjeta
            // 
            this.Button_Modificar_Tarjeta.Location = new System.Drawing.Point(985, 62);
            this.Button_Modificar_Tarjeta.Name = "Button_Modificar_Tarjeta";
            this.Button_Modificar_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Modificar_Tarjeta.TabIndex = 41;
            this.Button_Modificar_Tarjeta.Text = "Modificar";
            this.Button_Modificar_Tarjeta.UseVisualStyleBackColor = true;
            this.Button_Modificar_Tarjeta.Click += new System.EventHandler(this.Button_Modificar_Tarjeta_Click);
            // 
            // Button_Alta_Tarjeta
            // 
            this.Button_Alta_Tarjeta.Location = new System.Drawing.Point(985, 40);
            this.Button_Alta_Tarjeta.Name = "Button_Alta_Tarjeta";
            this.Button_Alta_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.Button_Alta_Tarjeta.TabIndex = 40;
            this.Button_Alta_Tarjeta.Text = "Alta";
            this.Button_Alta_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Rubro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(842, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "País";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(842, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Provincia";
            // 
            // TextBox_Tarj_Menor_Imp
            // 
            this.TextBox_Tarj_Menor_Imp.Location = new System.Drawing.Point(593, 444);
            this.TextBox_Tarj_Menor_Imp.Multiline = true;
            this.TextBox_Tarj_Menor_Imp.Name = "TextBox_Tarj_Menor_Imp";
            this.TextBox_Tarj_Menor_Imp.Size = new System.Drawing.Size(507, 20);
            this.TextBox_Tarj_Menor_Imp.TabIndex = 48;
            // 
            // TextBox_Tarj_Mayor_Desc
            // 
            this.TextBox_Tarj_Mayor_Desc.Location = new System.Drawing.Point(593, 470);
            this.TextBox_Tarj_Mayor_Desc.Multiline = true;
            this.TextBox_Tarj_Mayor_Desc.Name = "TextBox_Tarj_Mayor_Desc";
            this.TextBox_Tarj_Mayor_Desc.Size = new System.Drawing.Size(507, 20);
            this.TextBox_Tarj_Mayor_Desc.TabIndex = 49;
            // 
            // Button_Alta_Cliente
            // 
            this.Button_Alta_Cliente.Location = new System.Drawing.Point(301, 39);
            this.Button_Alta_Cliente.Name = "Button_Alta_Cliente";
            this.Button_Alta_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Alta_Cliente.TabIndex = 37;
            this.Button_Alta_Cliente.Text = "Alta";
            this.Button_Alta_Cliente.UseVisualStyleBackColor = true;
            // 
            // Button_Mod_Cliente
            // 
            this.Button_Mod_Cliente.Location = new System.Drawing.Point(301, 62);
            this.Button_Mod_Cliente.Name = "Button_Mod_Cliente";
            this.Button_Mod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Button_Mod_Cliente.TabIndex = 38;
            this.Button_Mod_Cliente.Text = "Modificar";
            this.Button_Mod_Cliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(25, 39);
            this.TextBox_Nombre.Multiline = true;
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 2;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Location = new System.Drawing.Point(173, 39);
            this.TextBox_Apellido.Multiline = true;
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Apellido.TabIndex = 3;
            // 
            // GUI_ABMClientesTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 506);
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
            this.Controls.Add(this.DataGrid_ABM_Tarjeta);
            this.Controls.Add(this.DataGrid_ABM_Cliente);
            this.Name = "GUI_ABMClientesTarjetas";
            this.Text = "GUI_ABMClientesTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ABM_Tarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_ABM_Cliente;
        private System.Windows.Forms.DataGridView DataGrid_ABM_Tarjeta;
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
    }
}