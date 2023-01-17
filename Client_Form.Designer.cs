namespace IndividualWork
{
    partial class Client_Form
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
            this.listBox_all = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_show_all_apartments = new System.Windows.Forms.Button();
            this.button_grade = new System.Windows.Forms.Button();
            this.button_show_lease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_all
            // 
            this.listBox_all.FormattingEnabled = true;
            this.listBox_all.Location = new System.Drawing.Point(12, 67);
            this.listBox_all.Name = "listBox_all";
            this.listBox_all.Size = new System.Drawing.Size(441, 82);
            this.listBox_all.TabIndex = 9;
            this.listBox_all.SelectedIndexChanged += new System.EventHandler(this.listBox_all_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список квартир (выберите, чтобы оформить аренду)";
            // 
            // button_show_all_apartments
            // 
            this.button_show_all_apartments.Location = new System.Drawing.Point(12, 12);
            this.button_show_all_apartments.Name = "button_show_all_apartments";
            this.button_show_all_apartments.Size = new System.Drawing.Size(240, 23);
            this.button_show_all_apartments.TabIndex = 10;
            this.button_show_all_apartments.Text = "Отобразить все квартиры";
            this.button_show_all_apartments.UseVisualStyleBackColor = true;
            this.button_show_all_apartments.Click += new System.EventHandler(this.button_show_all_apartments_Click);
            // 
            // button_grade
            // 
            this.button_grade.Location = new System.Drawing.Point(275, 12);
            this.button_grade.Name = "button_grade";
            this.button_grade.Size = new System.Drawing.Size(240, 23);
            this.button_grade.TabIndex = 11;
            this.button_grade.Text = "Оценить квартиру";
            this.button_grade.UseVisualStyleBackColor = true;
            this.button_grade.Click += new System.EventHandler(this.button_grade_Click);
            // 
            // button_show_lease
            // 
            this.button_show_lease.Location = new System.Drawing.Point(123, 155);
            this.button_show_lease.Name = "button_show_lease";
            this.button_show_lease.Size = new System.Drawing.Size(268, 58);
            this.button_show_lease.TabIndex = 12;
            this.button_show_lease.Text = "Просмотреть договор";
            this.button_show_lease.UseVisualStyleBackColor = true;
            this.button_show_lease.Click += new System.EventHandler(this.button_show_lease_Click);
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 225);
            this.Controls.Add(this.button_show_lease);
            this.Controls.Add(this.button_grade);
            this.Controls.Add(this.button_show_all_apartments);
            this.Controls.Add(this.listBox_all);
            this.Controls.Add(this.label1);
            this.Name = "Client_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_show_all_apartments;
        private System.Windows.Forms.Button button_grade;
        private System.Windows.Forms.Button button_show_lease;
    }
}