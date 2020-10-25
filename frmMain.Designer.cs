namespace App
{
    partial class frmMain
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
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtSatoD = new System.Windows.Forms.TextBox();
            this.txtSkywalkerD = new System.Windows.Forms.TextBox();
            this.txtKenobiD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSatoM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSkywalkerM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKenobiM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.txtSatoD);
            this.groupBox1.Controls.Add(this.txtSkywalkerD);
            this.groupBox1.Controls.Add(this.txtKenobiD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de coordenadas";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(145, 87);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 13);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "Y: ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(145, 61);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 13);
            this.lblX.TabIndex = 12;
            this.lblX.Text = "X: ";
            // 
            // txtSatoD
            // 
            this.txtSatoD.Location = new System.Drawing.Point(85, 84);
            this.txtSatoD.Name = "txtSatoD";
            this.txtSatoD.Size = new System.Drawing.Size(45, 20);
            this.txtSatoD.TabIndex = 9;
            this.txtSatoD.TextChanged += new System.EventHandler(this.NewDistance);
            // 
            // txtSkywalkerD
            // 
            this.txtSkywalkerD.Location = new System.Drawing.Point(85, 58);
            this.txtSkywalkerD.Name = "txtSkywalkerD";
            this.txtSkywalkerD.Size = new System.Drawing.Size(45, 20);
            this.txtSkywalkerD.TabIndex = 7;
            this.txtSkywalkerD.TextChanged += new System.EventHandler(this.NewDistance);
            // 
            // txtKenobiD
            // 
            this.txtKenobiD.Location = new System.Drawing.Point(85, 32);
            this.txtKenobiD.Name = "txtKenobiD";
            this.txtKenobiD.Size = new System.Drawing.Size(45, 20);
            this.txtKenobiD.TabIndex = 5;
            this.txtKenobiD.TextChanged += new System.EventHandler(this.NewDistance);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skywalker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kenobi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Controls.Add(this.txtSatoM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSkywalkerM);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKenobiM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de mensaje";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 122);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 14;
            // 
            // txtSatoM
            // 
            this.txtSatoM.Location = new System.Drawing.Point(85, 84);
            this.txtSatoM.Name = "txtSatoM";
            this.txtSatoM.Size = new System.Drawing.Size(160, 20);
            this.txtSatoM.TabIndex = 16;
            this.txtSatoM.TextChanged += new System.EventHandler(this.NewMessage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mensaje";
            // 
            // txtSkywalkerM
            // 
            this.txtSkywalkerM.Location = new System.Drawing.Point(85, 58);
            this.txtSkywalkerM.Name = "txtSkywalkerM";
            this.txtSkywalkerM.Size = new System.Drawing.Size(160, 20);
            this.txtSkywalkerM.TabIndex = 15;
            this.txtSkywalkerM.TextChanged += new System.EventHandler(this.NewMessage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sato";
            // 
            // txtKenobiM
            // 
            this.txtKenobiM.Location = new System.Drawing.Point(85, 32);
            this.txtKenobiM.Name = "txtKenobiM";
            this.txtKenobiM.Size = new System.Drawing.Size(160, 20);
            this.txtKenobiM.TabIndex = 14;
            this.txtKenobiM.TextChanged += new System.EventHandler(this.NewMessage);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kenobi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Skywalker";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "MeliApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtSatoD;
        private System.Windows.Forms.TextBox txtSkywalkerD;
        private System.Windows.Forms.TextBox txtKenobiD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtSatoM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSkywalkerM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKenobiM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}