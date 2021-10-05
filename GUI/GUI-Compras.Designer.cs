
namespace GUI
{
    partial class GUI_Compras
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBox_Monto_compra = new System.Windows.Forms.TextBox();
            this.Button_Realizar_Compra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Numero_Tarjeta = new System.Windows.Forms.TextBox();
            this.TextBox_Saldo_Tarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Clientes
            // 
            this.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Clientes.Location = new System.Drawing.Point(12, 12);
            this.DataGridView_Clientes.Name = "DataGridView_Clientes";
            this.DataGridView_Clientes.Size = new System.Drawing.Size(442, 302);
            this.DataGridView_Clientes.TabIndex = 0;
            this.DataGridView_Clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_Clientes_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(491, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // TextBox_Monto_compra
            // 
            this.TextBox_Monto_compra.Location = new System.Drawing.Point(622, 35);
            this.TextBox_Monto_compra.Name = "TextBox_Monto_compra";
            this.TextBox_Monto_compra.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Monto_compra.TabIndex = 3;
            // 
            // Button_Realizar_Compra
            // 
            this.Button_Realizar_Compra.Location = new System.Drawing.Point(513, 170);
            this.Button_Realizar_Compra.Name = "Button_Realizar_Compra";
            this.Button_Realizar_Compra.Size = new System.Drawing.Size(144, 53);
            this.Button_Realizar_Compra.TabIndex = 4;
            this.Button_Realizar_Compra.Text = "Ingresar compra";
            this.Button_Realizar_Compra.UseVisualStyleBackColor = true;
            this.Button_Realizar_Compra.Click += new System.EventHandler(this.Button_Realizar_Compra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero Tarjeta";
            // 
            // TextBox_Numero_Tarjeta
            // 
            this.TextBox_Numero_Tarjeta.Location = new System.Drawing.Point(491, 104);
            this.TextBox_Numero_Tarjeta.Name = "TextBox_Numero_Tarjeta";
            this.TextBox_Numero_Tarjeta.ReadOnly = true;
            this.TextBox_Numero_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Numero_Tarjeta.TabIndex = 8;
            // 
            // TextBox_Saldo_Tarjeta
            // 
            this.TextBox_Saldo_Tarjeta.Location = new System.Drawing.Point(625, 104);
            this.TextBox_Saldo_Tarjeta.Name = "TextBox_Saldo_Tarjeta";
            this.TextBox_Saldo_Tarjeta.ReadOnly = true;
            this.TextBox_Saldo_Tarjeta.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Saldo_Tarjeta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto Tarjeta";
            // 
            // GUI_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Saldo_Tarjeta);
            this.Controls.Add(this.TextBox_Numero_Tarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Realizar_Compra);
            this.Controls.Add(this.TextBox_Monto_compra);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DataGridView_Clientes);
            this.Name = "GUI_Compras";
            this.Text = "GUI_Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Clientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TextBox_Monto_compra;
        private System.Windows.Forms.Button Button_Realizar_Compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Numero_Tarjeta;
        private System.Windows.Forms.TextBox TextBox_Saldo_Tarjeta;
        private System.Windows.Forms.Label label4;
    }
}