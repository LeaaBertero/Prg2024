namespace PrgIni2024
{
    partial class Conversiones
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
            btConvertir = new Button();
            btcerrar = new Button();
            txNumero1 = new TextBox();
            lbRes = new Label();
            txNumero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btConvertir
            // 
            btConvertir.Cursor = Cursors.Hand;
            btConvertir.Location = new Point(150, 106);
            btConvertir.Name = "btConvertir";
            btConvertir.Size = new Size(94, 29);
            btConvertir.TabIndex = 0;
            btConvertir.Text = "Convertir";
            btConvertir.UseVisualStyleBackColor = true;
            btConvertir.Click += btConvertir_Click;
            // 
            // btcerrar
            // 
            btcerrar.Location = new Point(694, 12);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 1;
            btcerrar.Text = "salir";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // txNumero1
            // 
            txNumero1.Location = new Point(273, 108);
            txNumero1.Name = "txNumero1";
            txNumero1.Size = new Size(125, 27);
            txNumero1.TabIndex = 2;
            // 
            // lbRes
            // 
            lbRes.AutoSize = true;
            lbRes.Location = new Point(603, 110);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(50, 20);
            lbRes.TabIndex = 3;
            lbRes.Text = "label1";
            lbRes.Visible = false;
            // 
            // txNumero2
            // 
            txNumero2.Location = new Point(424, 108);
            txNumero2.Name = "txNumero2";
            txNumero2.Size = new Size(125, 27);
            txNumero2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 85);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 85);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Numero 2";
            // 
            // Conversiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 292);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txNumero2);
            Controls.Add(lbRes);
            Controls.Add(txNumero1);
            Controls.Add(btcerrar);
            Controls.Add(btConvertir);
            Name = "Conversiones";
            Text = "Conversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConvertir;
        private Button btcerrar;
        private TextBox txNumero1;
        private Label lbRes;
        private TextBox txNumero2;
        private Label label1;
        private Label label2;
    }
}