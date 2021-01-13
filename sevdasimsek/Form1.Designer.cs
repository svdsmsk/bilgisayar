
namespace sevdasimsek
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_ram = new System.Windows.Forms.TextBox();
            this.textbox_hdd = new System.Windows.Forms.TextBox();
            this.textbox_psuwatt = new System.Windows.Forms.TextBox();
            this.textbox_ekrankarti = new System.Windows.Forms.TextBox();
            this.textbox_anakart = new System.Windows.Forms.TextBox();
            this.buton_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HDD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PSU WATT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EKRAN KARTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ANAKART:";
            // 
            // textbox_ram
            // 
            this.textbox_ram.Location = new System.Drawing.Point(377, 98);
            this.textbox_ram.Name = "textbox_ram";
            this.textbox_ram.Size = new System.Drawing.Size(100, 20);
            this.textbox_ram.TabIndex = 6;
            // 
            // textbox_hdd
            // 
            this.textbox_hdd.Location = new System.Drawing.Point(377, 120);
            this.textbox_hdd.Name = "textbox_hdd";
            this.textbox_hdd.Size = new System.Drawing.Size(100, 20);
            this.textbox_hdd.TabIndex = 7;
            // 
            // textbox_psuwatt
            // 
            this.textbox_psuwatt.Location = new System.Drawing.Point(377, 145);
            this.textbox_psuwatt.Name = "textbox_psuwatt";
            this.textbox_psuwatt.Size = new System.Drawing.Size(100, 20);
            this.textbox_psuwatt.TabIndex = 8;
            // 
            // textbox_ekrankarti
            // 
            this.textbox_ekrankarti.Location = new System.Drawing.Point(377, 171);
            this.textbox_ekrankarti.Name = "textbox_ekrankarti";
            this.textbox_ekrankarti.Size = new System.Drawing.Size(100, 20);
            this.textbox_ekrankarti.TabIndex = 9;
            // 
            // textbox_anakart
            // 
            this.textbox_anakart.Location = new System.Drawing.Point(377, 197);
            this.textbox_anakart.Name = "textbox_anakart";
            this.textbox_anakart.Size = new System.Drawing.Size(100, 20);
            this.textbox_anakart.TabIndex = 10;
            // 
            // buton_kaydet
            // 
            this.buton_kaydet.Location = new System.Drawing.Point(298, 244);
            this.buton_kaydet.Name = "buton_kaydet";
            this.buton_kaydet.Size = new System.Drawing.Size(75, 23);
            this.buton_kaydet.TabIndex = 11;
            this.buton_kaydet.Text = "KAYDET";
            this.buton_kaydet.UseVisualStyleBackColor = true;
            this.buton_kaydet.Click += new System.EventHandler(this.buton_kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 377);
            this.Controls.Add(this.buton_kaydet);
            this.Controls.Add(this.textbox_anakart);
            this.Controls.Add(this.textbox_ekrankarti);
            this.Controls.Add(this.textbox_psuwatt);
            this.Controls.Add(this.textbox_hdd);
            this.Controls.Add(this.textbox_ram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bilgisayar Bilgileri";
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
        private System.Windows.Forms.TextBox textbox_ram;
        private System.Windows.Forms.TextBox textbox_hdd;
        private System.Windows.Forms.TextBox textbox_psuwatt;
        private System.Windows.Forms.TextBox textbox_ekrankarti;
        private System.Windows.Forms.TextBox textbox_anakart;
        private System.Windows.Forms.Button buton_kaydet;
    }
}

