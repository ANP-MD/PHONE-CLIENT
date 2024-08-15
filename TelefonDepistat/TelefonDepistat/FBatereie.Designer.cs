namespace TelefonDepistat
{
    partial class FBatereie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRevocare = new System.Windows.Forms.Button();
            this.buttonAcceptare = new System.Windows.Forms.Button();
            this.groupBoxTelefon = new System.Windows.Forms.GroupBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPenitenciar = new System.Windows.Forms.TextBox();
            this.buttonPenitenciar = new System.Windows.Forms.Button();
            this.dateTimePickerDataDepistare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxTelefon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRevocare);
            this.panel1.Controls.Add(this.buttonAcceptare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 49);
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
            // groupBoxTelefon
            // 
            this.groupBoxTelefon.Controls.Add(this.panel1);
            this.groupBoxTelefon.Controls.Add(this.textBoxNumber);
            this.groupBoxTelefon.Controls.Add(this.label5);
            this.groupBoxTelefon.Controls.Add(this.label2);
            this.groupBoxTelefon.Controls.Add(this.textBoxPenitenciar);
            this.groupBoxTelefon.Controls.Add(this.buttonPenitenciar);
            this.groupBoxTelefon.Controls.Add(this.dateTimePickerDataDepistare);
            this.groupBoxTelefon.Controls.Add(this.label1);
            this.groupBoxTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTelefon.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTelefon.Name = "groupBoxTelefon";
            this.groupBoxTelefon.Size = new System.Drawing.Size(340, 286);
            this.groupBoxTelefon.TabIndex = 12;
            this.groupBoxTelefon.TabStop = false;
            this.groupBoxTelefon.Text = "Batereie";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumber.Location = new System.Drawing.Point(87, 116);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(203, 22);
            this.textBoxNumber.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nr/Cod:";
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
            this.buttonPenitenciar.Location = new System.Drawing.Point(257, 61);
            this.buttonPenitenciar.Name = "buttonPenitenciar";
            this.buttonPenitenciar.Size = new System.Drawing.Size(33, 32);
            this.buttonPenitenciar.TabIndex = 49;
            this.buttonPenitenciar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataDepistare
            // 
            this.dateTimePickerDataDepistare.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataDepistare.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataDepistare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataDepistare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataDepistare.Location = new System.Drawing.Point(107, 30);
            this.dateTimePickerDataDepistare.Name = "dateTimePickerDataDepistare";
            this.dateTimePickerDataDepistare.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerDataDepistare.TabIndex = 13;
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
            // FBatereie
            // 
            this.AcceptButton = this.buttonAcceptare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonRevocare;
            this.ClientSize = new System.Drawing.Size(340, 286);
            this.Controls.Add(this.groupBoxTelefon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FBatereie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batereie";
            this.panel1.ResumeLayout(false);
            this.groupBoxTelefon.ResumeLayout(false);
            this.groupBoxTelefon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRevocare;
        private System.Windows.Forms.Button buttonAcceptare;
        private System.Windows.Forms.GroupBox groupBoxTelefon;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPenitenciar;
        private System.Windows.Forms.Button buttonPenitenciar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDepistare;
        private System.Windows.Forms.Label label1;
    }
}