namespace Conference.Presentation
{
    partial class KonferenzVerwalten
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAendern = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAendern);
            this.groupBox1.Controls.Add(this.btnLoeschen);
            this.groupBox1.Controls.Add(this.btnNeu);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konferenzen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 141);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAendern
            // 
            this.btnAendern.Location = new System.Drawing.Point(604, 167);
            this.btnAendern.Name = "btnAendern";
            this.btnAendern.Size = new System.Drawing.Size(75, 23);
            this.btnAendern.TabIndex = 3;
            this.btnAendern.Text = "Ändern";
            this.btnAendern.UseVisualStyleBackColor = true;
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(523, 167);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoeschen.TabIndex = 2;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(442, 167);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(75, 23);
            this.btnNeu.TabIndex = 1;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(701, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adressdetails";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // KonferenzVerwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KonferenzVerwalten";
            this.Text = "KonferenzVerwalten";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAendern;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}