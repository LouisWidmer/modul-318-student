﻿namespace TransportApp
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.gridAbfahrten = new System.Windows.Forms.DataGridView();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStationBoard = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbfahrten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStationBoard)).BeginInit();
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
            this.combVon.TabIndex = 1;
            this.combVon.DropDown += new System.EventHandler(this.combVon_DropDown);
            // 
            // combNach
            // 
            this.combNach.FormattingEnabled = true;
            this.combNach.Location = new System.Drawing.Point(337, 6);
            this.combNach.Name = "combNach";
            this.combNach.Size = new System.Drawing.Size(224, 28);
            this.combNach.TabIndex = 2;
            this.combNach.DropDown += new System.EventHandler(this.combNach_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
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
            this.btnSuchen.TabIndex = 5;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(55, 38);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(276, 27);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // gridAbfahrten
            // 
            this.gridAbfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAbfahrten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAbfahrten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gleis,
            this.Abfahrt,
            this.Ankunft,
            this.Dauer});
            this.gridAbfahrten.Location = new System.Drawing.Point(37, 71);
            this.gridAbfahrten.Name = "gridAbfahrten";
            this.gridAbfahrten.RowHeadersWidth = 51;
            this.gridAbfahrten.RowTemplate.Height = 29;
            this.gridAbfahrten.Size = new System.Drawing.Size(615, 277);
            this.gridAbfahrten.TabIndex = 10;
            // 
            // Gleis
            // 
            this.Gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.MinimumWidth = 6;
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            this.Gleis.Width = 70;
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.ReadOnly = true;
            // 
            // Ankunft
            // 
            this.Ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 6;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            // 
            // Dauer
            // 
            this.Dauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 6;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            this.Dauer.Width = 78;
            // 
            // gridStationBoard
            // 
            this.gridStationBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.dataGridViewTextBoxColumn1});
            this.gridStationBoard.Location = new System.Drawing.Point(37, 71);
            this.gridStationBoard.Name = "gridStationBoard";
            this.gridStationBoard.RowHeadersWidth = 51;
            this.gridStationBoard.RowTemplate.Height = 29;
            this.gridStationBoard.Size = new System.Drawing.Size(615, 277);
            this.gridStationBoard.TabIndex = 13;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            this.Von.ReadOnly = true;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nach.HeaderText = "Nach";
            this.Nach.MinimumWidth = 6;
            this.Nach.Name = "Nach";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(337, 38);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(224, 27);
            this.txtTime.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 360);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.gridStationBoard);
            this.Controls.Add(this.gridAbfahrten);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combNach);
            this.Controls.Add(this.combVon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAbfahrten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStationBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combVon;
        private ComboBox combNach;
        private Label label3;
        private Button btnSuchen;
        private DateTimePicker datePicker;
        private DataGridView gridAbfahrten;
        private DataGridView gridStationBoard;
        private DataGridViewTextBoxColumn Von;
        private DataGridViewTextBoxColumn Nach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtTime;
        private DataGridViewTextBoxColumn Gleis;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Dauer;
    }
}