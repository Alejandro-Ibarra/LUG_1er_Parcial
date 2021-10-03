
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
            this.DataGridView_Tarjeta_De_Cliente = new System.Windows.Forms.DataGridView();
            this.Button_Asignar = new System.Windows.Forms.Button();
            this.Button_Borrar_Asignacion = new System.Windows.Forms.Button();
            this.DataGridView_Tarjetas_Disponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Clientes
            // 
            this.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Clientes.Location = new System.Drawing.Point(13, 13);
            this.DataGridView_Clientes.Name = "DataGridView_Clientes";
            this.DataGridView_Clientes.Size = new System.Drawing.Size(315, 291);
            this.DataGridView_Clientes.TabIndex = 0;
            // 
            // DataGridView_Tarjeta_De_Cliente
            // 
            this.DataGridView_Tarjeta_De_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjeta_De_Cliente.Location = new System.Drawing.Point(334, 13);
            this.DataGridView_Tarjeta_De_Cliente.Name = "DataGridView_Tarjeta_De_Cliente";
            this.DataGridView_Tarjeta_De_Cliente.Size = new System.Drawing.Size(454, 54);
            this.DataGridView_Tarjeta_De_Cliente.TabIndex = 1;
            // 
            // Button_Asignar
            // 
            this.Button_Asignar.Location = new System.Drawing.Point(527, 267);
            this.Button_Asignar.Name = "Button_Asignar";
            this.Button_Asignar.Size = new System.Drawing.Size(75, 23);
            this.Button_Asignar.TabIndex = 2;
            this.Button_Asignar.Text = "Asociar tarjeta";
            this.Button_Asignar.UseVisualStyleBackColor = true;
            // 
            // Button_Borrar_Asignacion
            // 
            this.Button_Borrar_Asignacion.Location = new System.Drawing.Point(436, 267);
            this.Button_Borrar_Asignacion.Name = "Button_Borrar_Asignacion";
            this.Button_Borrar_Asignacion.Size = new System.Drawing.Size(75, 23);
            this.Button_Borrar_Asignacion.TabIndex = 3;
            this.Button_Borrar_Asignacion.Text = "Desasociar";
            this.Button_Borrar_Asignacion.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Tarjetas_Disponibles
            // 
            this.DataGridView_Tarjetas_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tarjetas_Disponibles.Location = new System.Drawing.Point(334, 83);
            this.DataGridView_Tarjetas_Disponibles.Name = "DataGridView_Tarjetas_Disponibles";
            this.DataGridView_Tarjetas_Disponibles.Size = new System.Drawing.Size(454, 159);
            this.DataGridView_Tarjetas_Disponibles.TabIndex = 4;
            // 
            // GUI_ClientesXTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.DataGridView_Tarjetas_Disponibles);
            this.Controls.Add(this.Button_Borrar_Asignacion);
            this.Controls.Add(this.Button_Asignar);
            this.Controls.Add(this.DataGridView_Tarjeta_De_Cliente);
            this.Controls.Add(this.DataGridView_Clientes);
            this.Name = "GUI_ClientesXTarjetas";
            this.Text = "GUI_ClientesXTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjeta_De_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tarjetas_Disponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Clientes;
        private System.Windows.Forms.DataGridView DataGridView_Tarjeta_De_Cliente;
        private System.Windows.Forms.Button Button_Asignar;
        private System.Windows.Forms.Button Button_Borrar_Asignacion;
        private System.Windows.Forms.DataGridView DataGridView_Tarjetas_Disponibles;
    }
}