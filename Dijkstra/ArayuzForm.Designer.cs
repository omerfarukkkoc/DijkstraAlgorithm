namespace Dijkstra
{
    partial class ArayuzForm
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
            this.panMap = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.comboBoxDen = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxe = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAgirlik = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMap.Location = new System.Drawing.Point(12, 12);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(530, 338);
            this.panMap.TabIndex = 1;
            this.panMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panMap_MouseClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(557, 210);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(161, 23);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Ağırlık Oluştur";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(557, 260);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(161, 47);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Çalıştır";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(557, 327);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(161, 23);
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "Sıfırla";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxDen
            // 
            this.comboBoxDen.FormattingEnabled = true;
            this.comboBoxDen.ItemHeight = 23;
            this.comboBoxDen.Location = new System.Drawing.Point(559, 125);
            this.comboBoxDen.Name = "comboBoxDen";
            this.comboBoxDen.Size = new System.Drawing.Size(42, 29);
            this.comboBoxDen.TabIndex = 17;
            this.comboBoxDen.UseSelectable = true;
            this.comboBoxDen.SelectedIndexChanged += new System.EventHandler(this.comboBoxDen_SelectedIndexChanged);
            // 
            // comboBoxe
            // 
            this.comboBoxe.FormattingEnabled = true;
            this.comboBoxe.ItemHeight = 23;
            this.comboBoxe.Location = new System.Drawing.Point(651, 125);
            this.comboBoxe.Name = "comboBoxe";
            this.comboBoxe.Size = new System.Drawing.Size(42, 29);
            this.comboBoxe.TabIndex = 18;
            this.comboBoxe.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(607, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "\'den";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(699, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "\'e";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(560, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Ağırlık: ";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Lines = new string[0];
            this.txtAgirlik.Location = new System.Drawing.Point(629, 169);
            this.txtAgirlik.MaxLength = 32767;
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.PasswordChar = '\0';
            this.txtAgirlik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgirlik.SelectedText = "";
            this.txtAgirlik.Size = new System.Drawing.Size(81, 23);
            this.txtAgirlik.TabIndex = 22;
            this.txtAgirlik.UseSelectable = true;
            this.txtAgirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgirlik_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(557, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(169, 76);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Düğüm Oluşturmak İçin \r\nSolda Bulunan Panel \r\nÜzerinde Fare İle \r\nTıklama Yapınız" +
    ".";
            // 
            // ArayuzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 363);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboBoxe);
            this.Controls.Add(this.comboBoxDen);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArayuzForm";
            this.Resizable = false;
            this.Text = "C# Dial\'s Algorithm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_FormClosed);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroComboBox comboBoxDen;
        private MetroFramework.Controls.MetroComboBox comboBoxe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAgirlik;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}