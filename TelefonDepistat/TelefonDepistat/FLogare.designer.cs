namespace TelefonDepistat
{
    partial class FLogare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogare));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelStatutLogare = new System.Windows.Forms.Label();
            this.buttonRevocare = new System.Windows.Forms.Button();
            this.buttonAcceptare = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Utilizator:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUser.Location = new System.Drawing.Point(101, 6);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(165, 22);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.Text = "telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Parola:";
            // 
            // maskedPassword
            // 
            this.maskedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedPassword.Location = new System.Drawing.Point(101, 41);
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.PasswordChar = '*';
            this.maskedPassword.Size = new System.Drawing.Size(165, 22);
            this.maskedPassword.TabIndex = 3;
            this.maskedPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedPassword_MaskInputRejected);
            this.maskedPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedPassword_KeyPress);
            // 
            // labelStatutLogare
            // 
            this.labelStatutLogare.AutoSize = true;
            this.labelStatutLogare.Location = new System.Drawing.Point(62, 74);
            this.labelStatutLogare.Name = "labelStatutLogare";
            this.labelStatutLogare.Size = new System.Drawing.Size(0, 13);
            this.labelStatutLogare.TabIndex = 6;
            // 
            // buttonRevocare
            // 
            this.buttonRevocare.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonRevocare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRevocare.Image = global::TelefonDepistat.Properties.Resources.cancel;
            this.buttonRevocare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRevocare.Location = new System.Drawing.Point(167, 69);
            this.buttonRevocare.Name = "buttonRevocare";
            this.buttonRevocare.Size = new System.Drawing.Size(91, 33);
            this.buttonRevocare.TabIndex = 5;
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
            this.buttonAcceptare.Location = new System.Drawing.Point(15, 69);
            this.buttonAcceptare.Name = "buttonAcceptare";
            this.buttonAcceptare.Size = new System.Drawing.Size(94, 33);
            this.buttonAcceptare.TabIndex = 4;
            this.buttonAcceptare.Text = "Acceptare";
            this.buttonAcceptare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcceptare.UseVisualStyleBackColor = true;
            this.buttonAcceptare.Click += new System.EventHandler(this.buttonAcceptare_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 105);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 7;
            // 
            // FLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 124);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.labelStatutLogare);
            this.Controls.Add(this.buttonRevocare);
            this.Controls.Add(this.buttonAcceptare);
            this.Controls.Add(this.maskedPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneClient V1.0.1 (Cloud) - Made by Cat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.Button buttonAcceptare;
        private System.Windows.Forms.Button buttonRevocare;
        private System.Windows.Forms.Label labelStatutLogare;
        private System.Windows.Forms.Label errorLabel;
    }
}