namespace RentaBook
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
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.comboBox_Librarie = new System.Windows.Forms.ComboBox();
            this.comboBox_Carte = new System.Windows.Forms.ComboBox();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Inchiriezi = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librarie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteaza carte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume si Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(39, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data returnarii filmului";
            // 
            // label_Mesaj
            // 
            this.label_Mesaj.AutoSize = true;
            this.label_Mesaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Mesaj.Location = new System.Drawing.Point(39, 319);
            this.label_Mesaj.MaximumSize = new System.Drawing.Size(400, 0);
            this.label_Mesaj.Name = "label_Mesaj";
            this.label_Mesaj.Size = new System.Drawing.Size(0, 13);
            this.label_Mesaj.TabIndex = 4;
            // 
            // comboBox_Librarie
            // 
            this.comboBox_Librarie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Librarie.FormattingEnabled = true;
            this.comboBox_Librarie.Items.AddRange(new object[] {
            "-Toate Librariile-",
            "Biblioteca Centrala",
            "Carturesti",
            "Biblioteca de Geografie"});
            this.comboBox_Librarie.Location = new System.Drawing.Point(230, 37);
            this.comboBox_Librarie.Name = "comboBox_Librarie";
            this.comboBox_Librarie.Size = new System.Drawing.Size(252, 21);
            this.comboBox_Librarie.TabIndex = 5;
            // 
            // comboBox_Carte
            // 
            this.comboBox_Carte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Carte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Carte.FormattingEnabled = true;
            this.comboBox_Carte.Location = new System.Drawing.Point(230, 89);
            this.comboBox_Carte.Name = "comboBox_Carte";
            this.comboBox_Carte.Size = new System.Drawing.Size(254, 28);
            this.comboBox_Carte.TabIndex = 6;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(233, 181);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(250, 20);
            this.textBox_Nume.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button_Inchiriezi
            // 
            this.button_Inchiriezi.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Inchiriezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inchiriezi.Location = new System.Drawing.Point(62, 349);
            this.button_Inchiriezi.Name = "button_Inchiriezi";
            this.button_Inchiriezi.Size = new System.Drawing.Size(171, 57);
            this.button_Inchiriezi.TabIndex = 9;
            this.button_Inchiriezi.Text = "Inchiriezi";
            this.button_Inchiriezi.UseVisualStyleBackColor = false;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(385, 349);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(195, 56);
            this.button_Reset.TabIndex = 10;
            this.button_Reset.Text = "Reset selectii";
            this.button_Reset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Inchiriezi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.comboBox_Carte);
            this.Controls.Add(this.comboBox_Librarie);
            this.Controls.Add(this.label_Mesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Mesaj;
        private System.Windows.Forms.ComboBox comboBox_Librarie;
        private System.Windows.Forms.ComboBox comboBox_Carte;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Inchiriezi;
        private System.Windows.Forms.Button button_Reset;
    }
}

