
namespace Disegnoapp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fogliodidisegno = new System.Windows.Forms.PictureBox();
            this.SalvaBTN = new System.Windows.Forms.Button();
            this.Grandezza = new System.Windows.Forms.Label();
            this.Txtgrandezze = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Esci = new System.Windows.Forms.ToolStripMenuItem();
            this.Modifica = new System.Windows.Forms.ToolStripMenuItem();
            this.Ripulisci = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.ColoriBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fogliodidisegno)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fogliodidisegno
            // 
            this.Fogliodidisegno.BackColor = System.Drawing.SystemColors.Control;
            this.Fogliodidisegno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fogliodidisegno.Location = new System.Drawing.Point(12, 52);
            this.Fogliodidisegno.Name = "Fogliodidisegno";
            this.Fogliodidisegno.Size = new System.Drawing.Size(1104, 685);
            this.Fogliodidisegno.TabIndex = 0;
            this.Fogliodidisegno.TabStop = false;
            this.Fogliodidisegno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fogliodidisegno_MouseDown);
            this.Fogliodidisegno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fogliodidisegno_MouseMove);
            this.Fogliodidisegno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fogliodidisegno_MouseUp);
            // 
            // SalvaBTN
            // 
            this.SalvaBTN.Location = new System.Drawing.Point(1178, 409);
            this.SalvaBTN.Name = "SalvaBTN";
            this.SalvaBTN.Size = new System.Drawing.Size(75, 23);
            this.SalvaBTN.TabIndex = 1;
            this.SalvaBTN.Text = "Salva";
            this.SalvaBTN.UseVisualStyleBackColor = true;
            this.SalvaBTN.Click += new System.EventHandler(this.SalvaBTN_Click);
            // 
            // Grandezza
            // 
            this.Grandezza.AutoSize = true;
            this.Grandezza.Location = new System.Drawing.Point(1116, 320);
            this.Grandezza.Name = "Grandezza";
            this.Grandezza.Size = new System.Drawing.Size(58, 13);
            this.Grandezza.TabIndex = 2;
            this.Grandezza.Text = "Grandezza";
            // 
            // Txtgrandezze
            // 
            this.Txtgrandezze.FormattingEnabled = true;
            this.Txtgrandezze.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48"});
            this.Txtgrandezze.Location = new System.Drawing.Point(1181, 320);
            this.Txtgrandezze.Name = "Txtgrandezze";
            this.Txtgrandezze.Size = new System.Drawing.Size(121, 21);
            this.Txtgrandezze.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Modifica});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Esci});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 22);
            this.File.Text = "File";
            // 
            // Esci
            // 
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(94, 22);
            this.Esci.Text = "Esci";
            // 
            // Modifica
            // 
            this.Modifica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ripulisci});
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(66, 22);
            this.Modifica.Text = "Modifica";
            // 
            // Ripulisci
            // 
            this.Ripulisci.Name = "Ripulisci";
            this.Ripulisci.Size = new System.Drawing.Size(118, 22);
            this.Ripulisci.Text = "Ripulisci";
            this.Ripulisci.Click += new System.EventHandler(this.Ripulisci_Click);
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(1162, 657);
            this.txt_color.Margin = new System.Windows.Forms.Padding(2);
            this.txt_color.Name = "txt_color";
            this.txt_color.ReadOnly = true;
            this.txt_color.Size = new System.Drawing.Size(92, 26);
            this.txt_color.TabIndex = 7;
            // 
            // ColoriBTN
            // 
            this.ColoriBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoriBTN.Location = new System.Drawing.Point(1162, 568);
            this.ColoriBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ColoriBTN.Name = "ColoriBTN";
            this.ColoriBTN.Size = new System.Drawing.Size(91, 85);
            this.ColoriBTN.TabIndex = 6;
            this.ColoriBTN.Text = "Colore";
            this.ColoriBTN.UseVisualStyleBackColor = true;
            this.ColoriBTN.Click += new System.EventHandler(this.ColoriBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.ColoriBTN);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Txtgrandezze);
            this.Controls.Add(this.Grandezza);
            this.Controls.Add(this.SalvaBTN);
            this.Controls.Add(this.Fogliodidisegno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Fogliodidisegno)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fogliodidisegno;
        private System.Windows.Forms.Button SalvaBTN;
        private System.Windows.Forms.Label Grandezza;
        private System.Windows.Forms.ComboBox Txtgrandezze;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Esci;
        private System.Windows.Forms.ToolStripMenuItem Modifica;
        private System.Windows.Forms.ToolStripMenuItem Ripulisci;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Button ColoriBTN;
    }
}

