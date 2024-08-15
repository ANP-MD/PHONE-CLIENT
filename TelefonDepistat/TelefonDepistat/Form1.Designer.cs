namespace TelefonDepistat
{
    partial class FormMainTelefon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTelefon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddTelefon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFindDuplicate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRaportToEmail = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.achizitiiPubliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diviziuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelCautare = new System.Windows.Forms.Panel();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPenitenciar = new System.Windows.Forms.TextBox();
            this.buttonPenitenciar = new System.Windows.Forms.Button();
            this.groupBoxPerioada = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPer2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPer1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRezultatCautare = new System.Windows.Forms.Panel();
            this.listViewRezultatCaut = new System.Windows.Forms.ListView();
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStapin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPenitenciarul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripTelefon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxImei = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelCautare.SuspendLayout();
            this.groupBoxPerioada.SuspendLayout();
            this.panelRezultatCautare.SuspendLayout();
            this.contextMenuStripTelefon.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddTelefon,
            this.toolStripSeparator1,
            this.toolStripFindDuplicate,
            this.toolStripButtonRaportToEmail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 71);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddTelefon
            // 
            this.toolStripButtonAddTelefon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddTelefon.Image = global::TelefonDepistat.Properties.Resources.telefon;
            this.toolStripButtonAddTelefon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTelefon.Name = "toolStripButtonAddTelefon";
            this.toolStripButtonAddTelefon.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonAddTelefon.Text = "Adaug Telefon";
            this.toolStripButtonAddTelefon.Click += new System.EventHandler(this.toolStripButtonAddTelefon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripFindDuplicate
            // 
            this.toolStripFindDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFindDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFindDuplicate.Image")));
            this.toolStripFindDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFindDuplicate.Name = "toolStripFindDuplicate";
            this.toolStripFindDuplicate.Size = new System.Drawing.Size(68, 68);
            this.toolStripFindDuplicate.Text = "Duplicate";
            this.toolStripFindDuplicate.Click += new System.EventHandler(this.toolStripFindDuplicate_Click);
            // 
            // toolStripButtonRaportToEmail
            // 
            this.toolStripButtonRaportToEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRaportToEmail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRaportToEmail.Image")));
            this.toolStripButtonRaportToEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRaportToEmail.Name = "toolStripButtonRaportToEmail";
            this.toolStripButtonRaportToEmail.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonRaportToEmail.Text = "Expediere E-mail";
            this.toolStripButtonRaportToEmail.Click += new System.EventHandler(this.toolStripButtonRaportToEmail_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achizitiiPubliceToolStripMenuItem,
            this.clasificatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Achizitii Publice";
            // 
            // achizitiiPubliceToolStripMenuItem
            // 
            this.achizitiiPubliceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.achizitiiPubliceToolStripMenuItem.Name = "achizitiiPubliceToolStripMenuItem";
            this.achizitiiPubliceToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.achizitiiPubliceToolStripMenuItem.Text = "Telefon Depistat";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // clasificatorToolStripMenuItem
            // 
            this.clasificatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diviziuniToolStripMenuItem});
            this.clasificatorToolStripMenuItem.Name = "clasificatorToolStripMenuItem";
            this.clasificatorToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.clasificatorToolStripMenuItem.Text = "Clasificator";
            // 
            // diviziuniToolStripMenuItem
            // 
            this.diviziuniToolStripMenuItem.Name = "diviziuniToolStripMenuItem";
            this.diviziuniToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.diviziuniToolStripMenuItem.Text = "Diviziuni";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelCautare
            // 
            this.panelCautare.Controls.Add(this.buttonCautare);
            this.panelCautare.Controls.Add(this.label3);
            this.panelCautare.Controls.Add(this.textBoxPenitenciar);
            this.panelCautare.Controls.Add(this.buttonPenitenciar);
            this.panelCautare.Controls.Add(this.groupBoxPerioada);
            this.panelCautare.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCautare.Location = new System.Drawing.Point(0, 96);
            this.panelCautare.Name = "panelCautare";
            this.panelCautare.Size = new System.Drawing.Size(242, 389);
            this.panelCautare.TabIndex = 5;
            // 
            // buttonCautare
            // 
            this.buttonCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCautare.Image = global::TelefonDepistat.Properties.Resources.cautare;
            this.buttonCautare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCautare.Location = new System.Drawing.Point(15, 243);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(182, 42);
            this.buttonCautare.TabIndex = 55;
            this.buttonCautare.Text = "Cautare";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Penitenciar:";
            // 
            // textBoxPenitenciar
            // 
            this.textBoxPenitenciar.Location = new System.Drawing.Point(15, 172);
            this.textBoxPenitenciar.MaxLength = 25;
            this.textBoxPenitenciar.Multiline = true;
            this.textBoxPenitenciar.Name = "textBoxPenitenciar";
            this.textBoxPenitenciar.ReadOnly = true;
            this.textBoxPenitenciar.Size = new System.Drawing.Size(182, 54);
            this.textBoxPenitenciar.TabIndex = 53;
            // 
            // buttonPenitenciar
            // 
            this.buttonPenitenciar.Image = global::TelefonDepistat.Properties.Resources.add24;
            this.buttonPenitenciar.Location = new System.Drawing.Point(203, 165);
            this.buttonPenitenciar.Name = "buttonPenitenciar";
            this.buttonPenitenciar.Size = new System.Drawing.Size(33, 32);
            this.buttonPenitenciar.TabIndex = 52;
            this.buttonPenitenciar.UseVisualStyleBackColor = true;
            this.buttonPenitenciar.Click += new System.EventHandler(this.buttonPenitenciar_Click);
            // 
            // groupBoxPerioada
            // 
            this.groupBoxPerioada.Controls.Add(this.textBoxImei);
            this.groupBoxPerioada.Controls.Add(this.dateTimePickerPer2);
            this.groupBoxPerioada.Controls.Add(this.label5);
            this.groupBoxPerioada.Controls.Add(this.dateTimePickerPer1);
            this.groupBoxPerioada.Controls.Add(this.label2);
            this.groupBoxPerioada.Controls.Add(this.label1);
            this.groupBoxPerioada.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPerioada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPerioada.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPerioada.Name = "groupBoxPerioada";
            this.groupBoxPerioada.Size = new System.Drawing.Size(242, 142);
            this.groupBoxPerioada.TabIndex = 0;
            this.groupBoxPerioada.TabStop = false;
            this.groupBoxPerioada.Text = "Perioada de Cautare";
            // 
            // dateTimePickerPer2
            // 
            this.dateTimePickerPer2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerPer2.Checked = false;
            this.dateTimePickerPer2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerPer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerPer2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPer2.Location = new System.Drawing.Point(59, 65);
            this.dateTimePickerPer2.Name = "dateTimePickerPer2";
            this.dateTimePickerPer2.ShowCheckBox = true;
            this.dateTimePickerPer2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerPer2.TabIndex = 7;
            // 
            // dateTimePickerPer1
            // 
            this.dateTimePickerPer1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerPer1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerPer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerPer1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPer1.Location = new System.Drawing.Point(59, 27);
            this.dateTimePickerPer1.Name = "dateTimePickerPer1";
            this.dateTimePickerPer1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerPer1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "pina la:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "de la:";
            // 
            // panelRezultatCautare
            // 
            this.panelRezultatCautare.Controls.Add(this.listViewRezultatCaut);
            this.panelRezultatCautare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRezultatCautare.Location = new System.Drawing.Point(242, 96);
            this.panelRezultatCautare.Name = "panelRezultatCautare";
            this.panelRezultatCautare.Size = new System.Drawing.Size(598, 389);
            this.panelRezultatCautare.TabIndex = 6;
            // 
            // listViewRezultatCaut
            // 
            this.listViewRezultatCaut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderData,
            this.columnHeaderTelefon,
            this.columnHeaderStapin,
            this.columnHeaderPenitenciarul});
            this.listViewRezultatCaut.ContextMenuStrip = this.contextMenuStripTelefon;
            this.listViewRezultatCaut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRezultatCaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewRezultatCaut.FullRowSelect = true;
            this.listViewRezultatCaut.GridLines = true;
            this.listViewRezultatCaut.Location = new System.Drawing.Point(0, 0);
            this.listViewRezultatCaut.MultiSelect = false;
            this.listViewRezultatCaut.Name = "listViewRezultatCaut";
            this.listViewRezultatCaut.Size = new System.Drawing.Size(598, 389);
            this.listViewRezultatCaut.TabIndex = 3;
            this.listViewRezultatCaut.UseCompatibleStateImageBehavior = false;
            this.listViewRezultatCaut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 70;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 350;
            // 
            // columnHeaderStapin
            // 
            this.columnHeaderStapin.Text = "Stapin";
            this.columnHeaderStapin.Width = 256;
            // 
            // columnHeaderPenitenciarul
            // 
            this.columnHeaderPenitenciarul.Text = "Penitenciarul";
            this.columnHeaderPenitenciarul.Width = 250;
            // 
            // contextMenuStripTelefon
            // 
            this.contextMenuStripTelefon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.toolStripSeparator2,
            this.stergeToolStripMenuItem});
            this.contextMenuStripTelefon.Name = "contextMenuStripTelefon";
            this.contextMenuStripTelefon.Size = new System.Drawing.Size(118, 54);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            // 
            // textBoxImei
            // 
            this.textBoxImei.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxImei.Location = new System.Drawing.Point(59, 99);
            this.textBoxImei.Name = "textBoxImei";
            this.textBoxImei.Size = new System.Drawing.Size(177, 22);
            this.textBoxImei.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "IMEI:";
            // 
            // FormMainTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 507);
            this.Controls.Add(this.panelRezultatCautare);
            this.Controls.Add(this.panelCautare);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainTelefon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Depistat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCautare.ResumeLayout(false);
            this.panelCautare.PerformLayout();
            this.groupBoxPerioada.ResumeLayout(false);
            this.groupBoxPerioada.PerformLayout();
            this.panelRezultatCautare.ResumeLayout(false);
            this.contextMenuStripTelefon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTelefon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem achizitiiPubliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diviziuniToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelCautare;
        private System.Windows.Forms.GroupBox groupBoxPerioada;
        private System.Windows.Forms.DateTimePicker dateTimePickerPer2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRezultatCautare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPenitenciar;
       private System.Windows.Forms.Button buttonPenitenciar;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.ListView listViewRezultatCaut;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderStapin;
        private System.Windows.Forms.ColumnHeader columnHeaderPenitenciarul;
        private System.Windows.Forms.ToolStripButton toolStripFindDuplicate;
        private System.Windows.Forms.ToolStripButton toolStripButtonRaportToEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTelefon;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxImei;
        private System.Windows.Forms.Label label5;
    }
}

