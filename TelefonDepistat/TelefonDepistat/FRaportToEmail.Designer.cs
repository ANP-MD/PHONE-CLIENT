namespace TelefonDepistat
{
    partial class FRaportToEmail
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
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listViewRezultatCaut = new System.Windows.Forms.ListView();
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImei = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNrTelefoane = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail :";
            // 
            // textBoxTo
            // 
            this.textBoxTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTo.Location = new System.Drawing.Point(209, 34);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(380, 22);
            this.textBoxTo.TabIndex = 2;
            this.textBoxTo.Text = "dico@igp.gov.md";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intervalul :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(327, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = " - ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(351, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // listViewRezultatCaut
            // 
            this.listViewRezultatCaut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderData,
            this.columnHeaderImei,
            this.columnHeaderModel});
            this.listViewRezultatCaut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewRezultatCaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewRezultatCaut.FullRowSelect = true;
            this.listViewRezultatCaut.GridLines = true;
            this.listViewRezultatCaut.Location = new System.Drawing.Point(0, 142);
            this.listViewRezultatCaut.MultiSelect = false;
            this.listViewRezultatCaut.Name = "listViewRezultatCaut";
            this.listViewRezultatCaut.Size = new System.Drawing.Size(601, 343);
            this.listViewRezultatCaut.TabIndex = 7;
            this.listViewRezultatCaut.UseCompatibleStateImageBehavior = false;
            this.listViewRezultatCaut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 70;
            // 
            // columnHeaderImei
            // 
            this.columnHeaderImei.Text = "IMEI";
            this.columnHeaderImei.Width = 200;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 150;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNrTelefoane});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Total:";
            // 
            // toolStripStatusLabelNrTelefoane
            // 
            this.toolStripStatusLabelNrTelefoane.Name = "toolStripStatusLabelNrTelefoane";
            this.toolStripStatusLabelNrTelefoane.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonSend
            // 
            this.buttonSend.Image = global::TelefonDepistat.Properties.Resources.expedieremail48;
            this.buttonSend.Location = new System.Drawing.Point(4, 29);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 90);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Expediere";
            this.buttonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCautare
            // 
            this.buttonCautare.Image = global::TelefonDepistat.Properties.Resources.cautare;
            this.buttonCautare.Location = new System.Drawing.Point(209, 96);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(260, 40);
            this.buttonCautare.TabIndex = 9;
            this.buttonCautare.Text = "Cautare";
            this.buttonCautare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // FRaportToEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 507);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.listViewRezultatCaut);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRaportToEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raportare pe E-mail";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView listViewRezultatCaut;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderImei;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNrTelefoane;
    }
}