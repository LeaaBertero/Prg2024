namespace PrgIni2024
{
    partial class PrgIni
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
            tSalir = new Button();
            btCargar = new Button();
            btMostrar = new Button();
            TxNombre = new TextBox();
            Txedad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbLista = new Label();
            label4 = new Label();
            txDocumento = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // tSalir
            // 
            tSalir.BackColor = Color.LawnGreen;
            tSalir.Cursor = Cursors.Hand;
            tSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tSalir.Location = new Point(637, 303);
            tSalir.Name = "tSalir";
            tSalir.Size = new Size(94, 29);
            tSalir.TabIndex = 0;
            tSalir.Text = "Salir";
            tSalir.UseVisualStyleBackColor = false;
            tSalir.Click += tSalir_Click;
            // 
            // btCargar
            // 
            btCargar.BackColor = Color.LawnGreen;
            btCargar.Cursor = Cursors.Hand;
            btCargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCargar.Location = new Point(184, 170);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 1;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.LawnGreen;
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btMostrar.Location = new Point(285, 170);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 2;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // TxNombre
            // 
            TxNombre.BackColor = Color.LawnGreen;
            TxNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxNombre.ForeColor = SystemColors.Desktop;
            TxNombre.Location = new Point(254, 30);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(125, 27);
            TxNombre.TabIndex = 3;
            // 
            // Txedad
            // 
            Txedad.BackColor = Color.LawnGreen;
            Txedad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Txedad.ForeColor = SystemColors.Desktop;
            Txedad.Location = new Point(254, 69);
            Txedad.Name = "Txedad";
            Txedad.Size = new Size(125, 27);
            Txedad.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.BackColor = Color.LawnGreen;
            lbLista.Location = new Point(419, 76);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 7;
            lbLista.Text = "label3";
            lbLista.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.BackColor = Color.LawnGreen;
            txDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txDocumento.ForeColor = SystemColors.Desktop;
            txDocumento.Location = new Point(254, 113);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 33);
            label5.Name = "label5";
            label5.Size = new Size(187, 20);
            label5.TabIndex = 10;
            label5.Text = "Lista de personas cargadas";
            // 
            // PrgIni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(743, 344);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txDocumento);
            Controls.Add(lbLista);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txedad);
            Controls.Add(TxNombre);
            Controls.Add(btMostrar);
            Controls.Add(btCargar);
            Controls.Add(tSalir);
            Name = "PrgIni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrgIni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tSalir;
        private Button btCargar;
        private Button btMostrar;
        private TextBox TxNombre;
        private TextBox Txedad;
        private Label label1;
        private Label label2;
        private Label lbLista;
        private Label label4;
        private TextBox txDocumento;
        private Label label5;
    }
}