namespace TransportApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combVon = new System.Windows.Forms.ComboBox();
            this.combNach = new System.Windows.Forms.ComboBox();
            this.btnNachsteStation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnIdSuchen = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gridAbfahrten = new System.Windows.Forms.DataGridView();
            this.btnAufKarteAnzeigen = new System.Windows.Forms.Button();
            this.btnMailSenden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbfahrten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nach:";
            // 
            // combVon
            // 
            this.combVon.FormattingEnabled = true;
            this.combVon.Location = new System.Drawing.Point(55, 6);
            this.combVon.Name = "combVon";
            this.combVon.Size = new System.Drawing.Size(224, 28);
            this.combVon.TabIndex = 2;
            // 
            // combNach
            // 
            this.combNach.FormattingEnabled = true;
            this.combNach.Location = new System.Drawing.Point(337, 6);
            this.combNach.Name = "combNach";
            this.combNach.Size = new System.Drawing.Size(224, 28);
            this.combNach.TabIndex = 3;
            // 
            // btnNachsteStation
            // 
            this.btnNachsteStation.Location = new System.Drawing.Point(55, 40);
            this.btnNachsteStation.Name = "btnNachsteStation";
            this.btnNachsteStation.Size = new System.Drawing.Size(224, 27);
            this.btnNachsteStation.TabIndex = 4;
            this.btnNachsteStation.Text = "Suche nächste Station";
            this.btnNachsteStation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wann";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(588, 6);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(94, 61);
            this.btnSuchen.TabIndex = 7;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnIdSuchen
            // 
            this.btnIdSuchen.Location = new System.Drawing.Point(37, 73);
            this.btnIdSuchen.Name = "btnIdSuchen";
            this.btnIdSuchen.Size = new System.Drawing.Size(615, 42);
            this.btnIdSuchen.TabIndex = 8;
            this.btnIdSuchen.Text = "Per ID suchen";
            this.btnIdSuchen.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // gridAbfahrten
            // 
            this.gridAbfahrten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAbfahrten.Location = new System.Drawing.Point(37, 121);
            this.gridAbfahrten.Name = "gridAbfahrten";
            this.gridAbfahrten.RowHeadersWidth = 51;
            this.gridAbfahrten.RowTemplate.Height = 29;
            this.gridAbfahrten.Size = new System.Drawing.Size(615, 462);
            this.gridAbfahrten.TabIndex = 10;
            // 
            // btnAufKarteAnzeigen
            // 
            this.btnAufKarteAnzeigen.Location = new System.Drawing.Point(37, 589);
            this.btnAufKarteAnzeigen.Name = "btnAufKarteAnzeigen";
            this.btnAufKarteAnzeigen.Size = new System.Drawing.Size(242, 29);
            this.btnAufKarteAnzeigen.TabIndex = 11;
            this.btnAufKarteAnzeigen.Text = "Auf der Karte anzeigen";
            this.btnAufKarteAnzeigen.UseVisualStyleBackColor = true;
            // 
            // btnMailSenden
            // 
            this.btnMailSenden.Location = new System.Drawing.Point(410, 589);
            this.btnMailSenden.Name = "btnMailSenden";
            this.btnMailSenden.Size = new System.Drawing.Size(242, 29);
            this.btnMailSenden.TabIndex = 12;
            this.btnMailSenden.Text = "Per Mail versenden";
            this.btnMailSenden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 630);
            this.Controls.Add(this.btnMailSenden);
            this.Controls.Add(this.btnAufKarteAnzeigen);
            this.Controls.Add(this.gridAbfahrten);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIdSuchen);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNachsteStation);
            this.Controls.Add(this.combNach);
            this.Controls.Add(this.combVon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAbfahrten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combVon;
        private ComboBox combNach;
        private Button btnNachsteStation;
        private Label label3;
        private Button btnSuchen;
        private Button btnIdSuchen;
        private DateTimePicker dateTimePicker1;
        private DataGridView gridAbfahrten;
        private Button btnAufKarteAnzeigen;
        private Button btnMailSenden;
    }
}