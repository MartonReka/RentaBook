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
            this.label5_Mesaj = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enciclopediiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurnaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papetarieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precomenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.la30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 184);
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
            this.label2.Location = new System.Drawing.Point(26, 221);
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
            this.label3.Location = new System.Drawing.Point(26, 280);
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
            this.label4.Location = new System.Drawing.Point(26, 332);
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
            this.comboBox_Librarie.Location = new System.Drawing.Point(217, 183);
            this.comboBox_Librarie.Name = "comboBox_Librarie";
            this.comboBox_Librarie.Size = new System.Drawing.Size(252, 21);
            this.comboBox_Librarie.TabIndex = 5;
            this.comboBox_Librarie.SelectedIndexChanged += new System.EventHandler(this.comboBox_Librarie_SelectedIndexChanged);
            // 
            // comboBox_Carte
            // 
            this.comboBox_Carte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Carte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Carte.FormattingEnabled = true;
            this.comboBox_Carte.Location = new System.Drawing.Point(217, 221);
            this.comboBox_Carte.Name = "comboBox_Carte";
            this.comboBox_Carte.Size = new System.Drawing.Size(254, 28);
            this.comboBox_Carte.TabIndex = 6;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(252, 280);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(250, 20);
            this.textBox_Nume.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button_Inchiriezi
            // 
            this.button_Inchiriezi.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Inchiriezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inchiriezi.Location = new System.Drawing.Point(52, 456);
            this.button_Inchiriezi.Name = "button_Inchiriezi";
            this.button_Inchiriezi.Size = new System.Drawing.Size(171, 57);
            this.button_Inchiriezi.TabIndex = 9;
            this.button_Inchiriezi.Text = "Inchiriezi";
            this.button_Inchiriezi.UseVisualStyleBackColor = false;
            this.button_Inchiriezi.Click += new System.EventHandler(this.button_Inchiriezi_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(341, 456);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(195, 56);
            this.button_Reset.TabIndex = 10;
            this.button_Reset.Text = "Reset selectii";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label5_Mesaj
            // 
            this.label5_Mesaj.AutoSize = true;
            this.label5_Mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_Mesaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5_Mesaj.Location = new System.Drawing.Point(39, 413);
            this.label5_Mesaj.MaximumSize = new System.Drawing.Size(400, 0);
            this.label5_Mesaj.Name = "label5_Mesaj";
            this.label5_Mesaj.Size = new System.Drawing.Size(0, 20);
            this.label5_Mesaj.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem,
            this.papetarieToolStripMenuItem,
            this.promotiiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carteToolStripMenuItem
            // 
            this.carteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioBooksToolStripMenuItem,
            this.enciclopediiToolStripMenuItem,
            this.revisteToolStripMenuItem,
            this.jurnaleToolStripMenuItem});
            this.carteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteToolStripMenuItem.Name = "carteToolStripMenuItem";
            this.carteToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.carteToolStripMenuItem.Text = "Carte";
            // 
            // audioBooksToolStripMenuItem
            // 
            this.audioBooksToolStripMenuItem.Name = "audioBooksToolStripMenuItem";
            this.audioBooksToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.audioBooksToolStripMenuItem.Text = "AudioBooks";
            // 
            // enciclopediiToolStripMenuItem
            // 
            this.enciclopediiToolStripMenuItem.Name = "enciclopediiToolStripMenuItem";
            this.enciclopediiToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.enciclopediiToolStripMenuItem.Text = "Enciclopedii";
            // 
            // revisteToolStripMenuItem
            // 
            this.revisteToolStripMenuItem.Name = "revisteToolStripMenuItem";
            this.revisteToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.revisteToolStripMenuItem.Text = "Reviste";
            // 
            // jurnaleToolStripMenuItem
            // 
            this.jurnaleToolStripMenuItem.Name = "jurnaleToolStripMenuItem";
            this.jurnaleToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.jurnaleToolStripMenuItem.Text = "Jurnale";
            // 
            // papetarieToolStripMenuItem
            // 
            this.papetarieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendareToolStripMenuItem,
            this.agendeToolStripMenuItem,
            this.scrisToolStripMenuItem});
            this.papetarieToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.papetarieToolStripMenuItem.Name = "papetarieToolStripMenuItem";
            this.papetarieToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.papetarieToolStripMenuItem.Text = "Papetarie";
            // 
            // calendareToolStripMenuItem
            // 
            this.calendareToolStripMenuItem.Name = "calendareToolStripMenuItem";
            this.calendareToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.calendareToolStripMenuItem.Text = "Calendare";
            // 
            // agendeToolStripMenuItem
            // 
            this.agendeToolStripMenuItem.Name = "agendeToolStripMenuItem";
            this.agendeToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.agendeToolStripMenuItem.Text = "Agende";
            // 
            // scrisToolStripMenuItem
            // 
            this.scrisToolStripMenuItem.Name = "scrisToolStripMenuItem";
            this.scrisToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.scrisToolStripMenuItem.Text = "Scris";
            // 
            // promotiiToolStripMenuItem
            // 
            this.promotiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.precomenziToolStripMenuItem,
            this.la30ToolStripMenuItem});
            this.promotiiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotiiToolStripMenuItem.Name = "promotiiToolStripMenuItem";
            this.promotiiToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.promotiiToolStripMenuItem.Text = "Promotii";
            // 
            // precomenziToolStripMenuItem
            // 
            this.precomenziToolStripMenuItem.Name = "precomenziToolStripMenuItem";
            this.precomenziToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.precomenziToolStripMenuItem.Text = "Precomenzi";
            // 
            // la30ToolStripMenuItem
            // 
            this.la30ToolStripMenuItem.Name = "la30ToolStripMenuItem";
            this.la30ToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.la30ToolStripMenuItem.Text = "La 30%";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Location = new System.Drawing.Point(532, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "English";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(649, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Romana";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(767, 62);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Maghiara";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(318, 115);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton2.Location = new System.Drawing.Point(409, 115);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NU";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(83, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Actualizare profil personal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(100, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 79);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rent a Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(894, 560);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5_Mesaj);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label5_Mesaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enciclopediiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurnaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papetarieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precomenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem la30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

