namespace IndividualWork
{
    partial class Add_Apartment_Form
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
            this.label_rp = new System.Windows.Forms.Label();
            this.button_add_apartment = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_ps = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.textBox_chsum = new System.Windows.Forms.TextBox();
            this.textBox_cs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_rp);
            this.groupBox1.Controls.Add(this.button_add_apartment);
            this.groupBox1.Controls.Add(this.textBox_address);
            this.groupBox1.Controls.Add(this.textBox_ps);
            this.groupBox1.Controls.Add(this.textBox_desc);
            this.groupBox1.Controls.Add(this.textBox_chsum);
            this.groupBox1.Controls.Add(this.textBox_cs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление квартиры";
            this.groupBox1.UseWaitCursor = true;
            // 
            // label_rp
            // 
            this.label_rp.AutoSize = true;
            this.label_rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rp.Location = new System.Drawing.Point(6, 282);
            this.label_rp.Name = "label_rp";
            this.label_rp.Size = new System.Drawing.Size(126, 20);
            this.label_rp.TabIndex = 15;
            this.label_rp.Text = "return квартира";
            this.label_rp.UseWaitCursor = true;
            this.label_rp.Visible = false;
            // 
            // button_add_apartment
            // 
            this.button_add_apartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_apartment.Location = new System.Drawing.Point(147, 215);
            this.button_add_apartment.Name = "button_add_apartment";
            this.button_add_apartment.Size = new System.Drawing.Size(170, 44);
            this.button_add_apartment.TabIndex = 6;
            this.button_add_apartment.Text = "Добавить квартиру";
            this.button_add_apartment.UseVisualStyleBackColor = true;
            this.button_add_apartment.UseWaitCursor = true;
            this.button_add_apartment.Click += new System.EventHandler(this.button_add_apartment_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_address.Location = new System.Drawing.Point(186, 32);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(236, 26);
            this.textBox_address.TabIndex = 1;
            this.textBox_address.UseWaitCursor = true;
            // 
            // textBox_ps
            // 
            this.textBox_ps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ps.Location = new System.Drawing.Point(186, 64);
            this.textBox_ps.Name = "textBox_ps";
            this.textBox_ps.Size = new System.Drawing.Size(236, 26);
            this.textBox_ps.TabIndex = 2;
            this.textBox_ps.UseWaitCursor = true;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_desc.Location = new System.Drawing.Point(186, 160);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(236, 26);
            this.textBox_desc.TabIndex = 5;
            this.textBox_desc.UseWaitCursor = true;
            // 
            // textBox_chsum
            // 
            this.textBox_chsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_chsum.Location = new System.Drawing.Point(186, 128);
            this.textBox_chsum.Name = "textBox_chsum";
            this.textBox_chsum.Size = new System.Drawing.Size(236, 26);
            this.textBox_chsum.TabIndex = 4;
            this.textBox_chsum.UseWaitCursor = true;
            // 
            // textBox_cs
            // 
            this.textBox_cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cs.Location = new System.Drawing.Point(186, 96);
            this.textBox_cs.Name = "textBox_cs";
            this.textBox_cs.Size = new System.Drawing.Size(236, 26);
            this.textBox_cs.TabIndex = 3;
            this.textBox_cs.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Описание";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость за сутки";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество комнат";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            this.label1.UseWaitCursor = true;
            // 
            // Add_Apartment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 362);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Apartment_Form";
            this.Text = "Add_Apartment_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_rp;
        private System.Windows.Forms.Button button_add_apartment;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_ps;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_chsum;
        private System.Windows.Forms.TextBox textBox_cs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}