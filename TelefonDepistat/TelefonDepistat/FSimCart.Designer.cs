namespace TelefonDepistat
{
    partial class FSimCart
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
            this.groupBoxTelefon = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRevocare = new System.Windows.Forms.Button();
            this.buttonAcceptare = new System.Windows.Forms.Button();
            this.textBoxNrSim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPenitenciar = new System.Windows.Forms.TextBox();
            this.buttonPenitenciar = new System.Windows.Forms.Button();
            this.dateTimePickerAch1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.groupBoxTelefon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTelefon
            // 
            this.groupBoxTelefon.Controls.Add(this.comboBoxOperator);
            this.groupBoxTelefon.Controls.Add(this.label3);
            this.groupBoxTelefon.Controls.Add(this.panel1);
            this.groupBoxTelefon.Controls.Add(this.textBoxNrSim);
            this.groupBoxTelefon.Controls.Add(this.label5);
            this.groupBoxTelefon.Controls.Add(this.label2);
            this.groupBoxTelefon.Controls.Add(this.textBoxPenitenciar);
            this.groupBoxTelefon.Controls.Add(this.buttonPenitenciar);
            this.groupBoxTelefon.Controls.Add(this.dateTimePickerAch1);
            this.groupBoxTelefon.Controls.Add(this.label1);
            this.groupBoxTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTelefon.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTelefon.Name = "groupBoxTelefon";
            this.groupBoxTelefon.Size = new System.Drawing.Size(306, 256);
            this.groupBoxTelefon.TabIndex = 11;
            this.groupBoxTelefon.TabStop = false;
            this.groupBoxTelefon.Text = "SIM-CART";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Operator:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRevocare);
            this.panel1.Controls.Add(this.buttonAcceptare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 49);
            this.panel1.TabIndex = 61;
            // 
            // buttonRevocare
            // 
            this.buttonRevocare.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonRevocare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRevocare.Image = global::TelefonDepistat.Properties.Resources.cancel;
            this.buttonRevocare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRevocare.Location = new System.Drawing.Point(174, 6);
            this.buttonRevocare.Name = "buttonRevocare";
            this.buttonRevocare.Size = new System.Drawing.Size(93, 33);
            this.buttonRevocare.TabIndex = 53;
            this.buttonRevocare.Text = "Revocare";
            this.buttonRevocare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRevocare.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptare
            // 
            this.buttonAcceptare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAcceptare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcceptare.Image = global::TelefonDepistat.Properties.Resources.ok;
            this.buttonAcceptare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcceptare.Location = new System.Drawing.Point(12, 6);
            this.buttonAcceptare.Name = "buttonAcceptare";
            this.buttonAcceptare.Size = new System.Drawing.Size(96, 33);
            this.buttonAcceptare.TabIndex = 52;
            this.buttonAcceptare.Text = "Acceptare";
            this.buttonAcceptare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcceptare.UseVisualStyleBackColor = true;
            this.buttonAcceptare.Click += new System.EventHandler(this.buttonAcceptare_Click);
            // 
            // textBoxNrSim
            // 
            this.textBoxNrSim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNrSim.Location = new System.Drawing.Point(87, 147);
            this.textBoxNrSim.Name = "textBoxNrSim";
            this.textBoxNrSim.Size = new System.Drawing.Size(203, 22);
            this.textBoxNrSim.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nr-SIM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Penitenciar:";
            // 
            // textBoxPenitenciar
            // 
            this.textBoxPenitenciar.Location = new System.Drawing.Point(87, 66);
            this.textBoxPenitenciar.MaxLength = 25;
            this.textBoxPenitenciar.Name = "textBoxPenitenciar";
            this.textBoxPenitenciar.ReadOnly = true;
            this.textBoxPenitenciar.Size = new System.Drawing.Size(171, 22);
            this.textBoxPenitenciar.TabIndex = 50;
            // 
            // buttonPenitenciar
            // 
            this.buttonPenitenciar.Image = global::TelefonDepistat.Properties.Resources.add24;
            this.buttonPenitenciar.Location = new System.Drawing.Point(257, 61);
            this.buttonPenitenciar.Name = "buttonPenitenciar";
            this.buttonPenitenciar.Size = new System.Drawing.Size(33, 32);
            this.buttonPenitenciar.TabIndex = 49;
            this.buttonPenitenciar.UseVisualStyleBackColor = true;
            this.buttonPenitenciar.Click += new System.EventHandler(this.buttonPenitenciar_Click);
            // 
            // dateTimePickerAch1
            // 
            this.dateTimePickerAch1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerAch1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerAch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerAch1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAch1.Location = new System.Drawing.Point(107, 30);
            this.dateTimePickerAch1.Name = "dateTimePickerAch1";
            this.dateTimePickerAch1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerAch1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data depistarii:";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "ORANGE",
            "MOLDCELL",
            "UNITE"});
            this.comboBoxOperator.Location = new System.Drawing.Point(87, 106);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(203, 24);
            this.comboBoxOperator.TabIndex = 65;
            // 
            // FSimCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 256);
            this.Controls.Add(this.groupBoxTelefon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FSimCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SIM-CART";
            this.groupBoxTelefon.ResumeLayout(false);
            this.groupBoxTelefon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTelefon;
        private System.Windows.Forms.TextBox textBoxNrSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPenitenciar;
        private System.Windows.Forms.Button buttonPenitenciar;
        private System.Windows.Forms.DateTimePicker dateTimePickerAch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRevocare;
        private System.Windows.Forms.Button buttonAcceptare;
        private System.Windows.Forms.ComboBox comboBoxOperator;
    }
}