namespace socketUDP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.envoi = new System.Windows.Forms.RichTextBox();
            this.Recp = new System.Windows.Forms.RichTextBox();
            this.fermerclose = new System.Windows.Forms.Button();
            this.envoyer = new System.Windows.Forms.Button();
            this.Recevoir = new System.Windows.Forms.Button();
            this.creatstoket = new System.Windows.Forms.Button();
            this.CLS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dest.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IPeD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recp.";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IPeR";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Envoi";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // envoi
            // 
            this.envoi.Location = new System.Drawing.Point(117, 134);
            this.envoi.Name = "envoi";
            this.envoi.Size = new System.Drawing.Size(304, 96);
            this.envoi.TabIndex = 10;
            this.envoi.Text = "";
            this.envoi.TextChanged += new System.EventHandler(this.envoi_TextChanged);
            // 
            // Recp
            // 
            this.Recp.Location = new System.Drawing.Point(117, 236);
            this.Recp.Name = "Recp";
            this.Recp.Size = new System.Drawing.Size(217, 182);
            this.Recp.TabIndex = 11;
            this.Recp.Text = "";
            this.Recp.TextChanged += new System.EventHandler(this.Recp_TextChanged);
            // 
            // fermerclose
            // 
            this.fermerclose.Location = new System.Drawing.Point(497, 126);
            this.fermerclose.Name = "fermerclose";
            this.fermerclose.Size = new System.Drawing.Size(159, 34);
            this.fermerclose.TabIndex = 17;
            this.fermerclose.Text = "Fermer Close()";
            this.fermerclose.UseVisualStyleBackColor = true;
            this.fermerclose.Click += new System.EventHandler(this.fermerclose_Click);
            // 
            // envoyer
            // 
            this.envoyer.Location = new System.Drawing.Point(497, 186);
            this.envoyer.Name = "envoyer";
            this.envoyer.Size = new System.Drawing.Size(159, 34);
            this.envoyer.TabIndex = 18;
            this.envoyer.Text = "Envoyer SendTo(IPeD)";
            this.envoyer.UseVisualStyleBackColor = true;
            this.envoyer.Click += new System.EventHandler(this.envoyer_Click);
            // 
            // Recevoir
            // 
            this.Recevoir.Location = new System.Drawing.Point(497, 255);
            this.Recevoir.Name = "Recevoir";
            this.Recevoir.Size = new System.Drawing.Size(159, 34);
            this.Recevoir.TabIndex = 19;
            this.Recevoir.Text = "Recevoir ReceiveFrom Bloqanrt Timeout";
            this.Recevoir.UseVisualStyleBackColor = true;
            this.Recevoir.Click += new System.EventHandler(this.Recevoir_Click);
            // 
            // creatstoket
            // 
            this.creatstoket.Location = new System.Drawing.Point(497, 66);
            this.creatstoket.Name = "creatstoket";
            this.creatstoket.Size = new System.Drawing.Size(159, 34);
            this.creatstoket.TabIndex = 20;
            this.creatstoket.Text = "Créer Socket et Blind(IPeR)";
            this.creatstoket.UseVisualStyleBackColor = true;
            this.creatstoket.Click += new System.EventHandler(this.creatstoket_Click);
            // 
            // CLS
            // 
            this.CLS.Location = new System.Drawing.Point(432, 395);
            this.CLS.Name = "CLS";
            this.CLS.Size = new System.Drawing.Size(52, 23);
            this.CLS.TabIndex = 21;
            this.CLS.Text = "CLS";
            this.CLS.UseVisualStyleBackColor = true;
            this.CLS.Click += new System.EventHandler(this.CLS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CLS);
            this.Controls.Add(this.creatstoket);
            this.Controls.Add(this.Recevoir);
            this.Controls.Add(this.envoyer);
            this.Controls.Add(this.fermerclose);
            this.Controls.Add(this.Recp);
            this.Controls.Add(this.envoi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox envoi;
        private System.Windows.Forms.RichTextBox Recp;
        private System.Windows.Forms.Button fermerclose;
        private System.Windows.Forms.Button envoyer;
        private System.Windows.Forms.Button Recevoir;
        private System.Windows.Forms.Button creatstoket;
        private System.Windows.Forms.Button CLS;
    }
}

