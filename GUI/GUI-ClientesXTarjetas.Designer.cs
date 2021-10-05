
namespace GUI
{
    partial class GUI_ClientesXTarjetas
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
            this.DataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.DataGridView_Tarjeta_De_Cliente_Nac = new System.Windows.Forms.DataGridView();
            this.Button_Asignar = new System.Windows.Forms.Button();
            this.Button_Borrar_Asignacion = new System.Windows.Forms.Button();
            this.DataGridView_Tarjetas_Nac_Disponibles = new System.Windows.Forms.DataGridView();
            this.DataGridView_Tarjeta_De_Cliente_Int = new System.Windows.Forms.DataGridView();
            this.DataGridView_Tarjetas_Int_Disponibles = new System.Windows.Forms.DataGridView();
            this.TextBox_Monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente_Nac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Nac_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente_Int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Int_Disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Clientes
            // 
            this.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Clientes.Location = new System.Drawing.Point(13, 13);
            this.DataGridView_Clientes.MultiSelect = false;
            this.DataGridView_Clientes.Name = "DataGridView_Clientes";
            this.DataGridView_Clientes.ReadOnly = true;
            this.DataGridView_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Clientes.Size = new System.Drawing.Size(315, 489);
            this.DataGridView_Clientes.TabIndex = 0;
            this.DataGridView_Clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Clientes_MouseClick);
            // 
            // DataGridView_Tarjeta_De_Cliente_Nac
            // 
            this.DataGridView_Tarjeta_De_Cliente_Nac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjeta_De_Cliente_Nac.Location = new System.Drawing.Point(334, 13);
            this.DataGridView_Tarjeta_De_Cliente_Nac.MultiSelect = false;
            this.DataGridView_Tarjeta_De_Cliente_Nac.Name = "DataGridView_Tarjeta_De_Cliente_Nac";
            this.DataGridView_Tarjeta_De_Cliente_Nac.ReadOnly = true;
            this.DataGridView_Tarjeta_De_Cliente_Nac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tarjeta_De_Cliente_Nac.Size = new System.Drawing.Size(700, 110);
            this.DataGridView_Tarjeta_De_Cliente_Nac.TabIndex = 1;
            this.DataGridView_Tarjeta_De_Cliente_Nac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Tarjeta_De_Cliente_Nac_MouseClick);
            // 
            // Button_Asignar
            // 
            this.Button_Asignar.Location = new System.Drawing.Point(13, 508);
            this.Button_Asignar.Name = "Button_Asignar";
            this.Button_Asignar.Size = new System.Drawing.Size(118, 23);
            this.Button_Asignar.TabIndex = 2;
            this.Button_Asignar.Text = "Asociar tarjeta";
            this.Button_Asignar.UseVisualStyleBackColor = true;
            this.Button_Asignar.Click += new System.EventHandler(this.Button_Asignar_Click);
            // 
            // Button_Borrar_Asignacion
            // 
            this.Button_Borrar_Asignacion.Location = new System.Drawing.Point(13, 548);
            this.Button_Borrar_Asignacion.Name = "Button_Borrar_Asignacion";
            this.Button_Borrar_Asignacion.Size = new System.Drawing.Size(118, 23);
            this.Button_Borrar_Asignacion.TabIndex = 3;
            this.Button_Borrar_Asignacion.Text = "Desasociar Tarjeta";
            this.Button_Borrar_Asignacion.UseVisualStyleBackColor = true;
            this.Button_Borrar_Asignacion.Click += new System.EventHandler(this.Button_Borrar_Asignacion_Click);
            // 
            // DataGridView_Tarjetas_Nac_Disponibles
            // 
            this.DataGridView_Tarjetas_Nac_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjetas_Nac_Disponibles.Location = new System.Drawing.Point(334, 300);
            this.DataGridView_Tarjetas_Nac_Disponibles.MultiSelect = false;
            this.DataGridView_Tarjetas_Nac_Disponibles.Name = "DataGridView_Tarjetas_Nac_Disponibles";
            this.DataGridView_Tarjetas_Nac_Disponibles.ReadOnly = true;
            this.DataGridView_Tarjetas_Nac_Disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tarjetas_Nac_Disponibles.Size = new System.Drawing.Size(700, 110);
            this.DataGridView_Tarjetas_Nac_Disponibles.TabIndex = 4;
            this.DataGridView_Tarjetas_Nac_Disponibles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Tarjetas_Nac_Disponibles_MouseClick);
            // 
            // DataGridView_Tarjeta_De_Cliente_Int
            // 
            this.DataGridView_Tarjeta_De_Cliente_Int.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjeta_De_Cliente_Int.Location = new System.Drawing.Point(334, 155);
            this.DataGridView_Tarjeta_De_Cliente_Int.MultiSelect = false;
            this.DataGridView_Tarjeta_De_Cliente_Int.Name = "DataGridView_Tarjeta_De_Cliente_Int";
            this.DataGridView_Tarjeta_De_Cliente_Int.ReadOnly = true;
            this.DataGridView_Tarjeta_De_Cliente_Int.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tarjeta_De_Cliente_Int.Size = new System.Drawing.Size(700, 110);
            this.DataGridView_Tarjeta_De_Cliente_Int.TabIndex = 5;
            this.DataGridView_Tarjeta_De_Cliente_Int.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Tarjeta_De_Cliente_Int_MouseClick);
            // 
            // DataGridView_Tarjetas_Int_Disponibles
            // 
            this.DataGridView_Tarjetas_Int_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjetas_Int_Disponibles.Location = new System.Drawing.Point(334, 441);
            this.DataGridView_Tarjetas_Int_Disponibles.MultiSelect = false;
            this.DataGridView_Tarjetas_Int_Disponibles.Name = "DataGridView_Tarjetas_Int_Disponibles";
            this.DataGridView_Tarjetas_Int_Disponibles.ReadOnly = true;
            this.DataGridView_Tarjetas_Int_Disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tarjetas_Int_Disponibles.Size = new System.Drawing.Size(700, 110);
            this.DataGridView_Tarjetas_Int_Disponibles.TabIndex = 6;
            this.DataGridView_Tarjetas_Int_Disponibles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Tarjetas_Int_Disponibles_MouseClick);
            // 
            // TextBox_Monto
            // 
            this.TextBox_Monto.Location = new System.Drawing.Point(155, 548);
            this.TextBox_Monto.Multiline = true;
            this.TextBox_Monto.Name = "TextBox_Monto";
            this.TextBox_Monto.Size = new System.Drawing.Size(129, 23);
            this.TextBox_Monto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(169, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el monto a cargar en la tarjeta";
            // 
            // GUI_ClientesXTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Monto);
            this.Controls.Add(this.DataGridView_Tarjetas_Int_Disponibles);
            this.Controls.Add(this.DataGridView_Tarjeta_De_Cliente_Int);
            this.Controls.Add(this.DataGridView_Tarjetas_Nac_Disponibles);
            this.Controls.Add(this.Button_Borrar_Asignacion);
            this.Controls.Add(this.Button_Asignar);
            this.Controls.Add(this.DataGridView_Tarjeta_De_Cliente_Nac);
            this.Controls.Add(this.DataGridView_Clientes);
            this.Name = "GUI_ClientesXTarjetas";
            this.Text = "GUI_ClientesXTarjetas";
            this.Load += new System.EventHandler(this.GUI_ClientesXTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente_Nac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Nac_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente_Int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Int_Disponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Clientes;
        private System.Windows.Forms.DataGridView DataGridView_Tarjeta_De_Cliente_Nac;
        private System.Windows.Forms.Button Button_Asignar;
        private System.Windows.Forms.Button Button_Borrar_Asignacion;
        private System.Windows.Forms.DataGridView DataGridView_Tarjetas_Nac_Disponibles;
        private System.Windows.Forms.DataGridView DataGridView_Tarjeta_De_Cliente_Int;
        private System.Windows.Forms.DataGridView DataGridView_Tarjetas_Int_Disponibles;
        private System.Windows.Forms.TextBox TextBox_Monto;
        private System.Windows.Forms.Label label1;
    }
}