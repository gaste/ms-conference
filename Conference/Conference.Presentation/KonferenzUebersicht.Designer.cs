namespace Conference.Presentation
{
    partial class KonferenzUebersicht
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
            this.btnTeilnehmen = new System.Windows.Forms.Button();
            this.btnVerwalten = new System.Windows.Forms.Button();
            this.lvKonferenzen = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnTeilnehmen
            // 
            this.btnTeilnehmen.Location = new System.Drawing.Point(12, 41);
            this.btnTeilnehmen.Name = "btnTeilnehmen";
            this.btnTeilnehmen.Size = new System.Drawing.Size(75, 23);
            this.btnTeilnehmen.TabIndex = 0;
            this.btnTeilnehmen.Text = "Teilnehmen";
            this.btnTeilnehmen.UseVisualStyleBackColor = true;
            // 
            // btnVerwalten
            // 
            this.btnVerwalten.Location = new System.Drawing.Point(12, 12);
            this.btnVerwalten.Name = "btnVerwalten";
            this.btnVerwalten.Size = new System.Drawing.Size(75, 23);
            this.btnVerwalten.TabIndex = 3;
            this.btnVerwalten.Text = "Verwalten";
            this.btnVerwalten.UseVisualStyleBackColor = true;
            this.btnVerwalten.Click += new System.EventHandler(this.btnVerwalten_Click);
            // 
            // lvKonferenzen
            // 
            this.lvKonferenzen.Location = new System.Drawing.Point(93, 12);
            this.lvKonferenzen.Name = "lvKonferenzen";
            this.lvKonferenzen.Size = new System.Drawing.Size(527, 218);
            this.lvKonferenzen.TabIndex = 4;
            this.lvKonferenzen.UseCompatibleStateImageBehavior = false;
            // 
            // KonferenzUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 243);
            this.Controls.Add(this.lvKonferenzen);
            this.Controls.Add(this.btnVerwalten);
            this.Controls.Add(this.btnTeilnehmen);
            this.Name = "KonferenzUebersicht";
            this.Text = "KonferenzUebersicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeilnehmen;
        private System.Windows.Forms.Button btnVerwalten;
        private System.Windows.Forms.ListView lvKonferenzen;
    }
}