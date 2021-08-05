
namespace EventsDemo
{
    partial class DashboardForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.appName = new System.Windows.Forms.Label();
            this.transactionsListBox = new System.Windows.Forms.ListBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.processInfoLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appName.Location = new System.Drawing.Point(13, 13);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(65, 31);
            this.appName.TabIndex = 0;
            this.appName.Text = "App";
            // 
            // transactionsListBox
            // 
            this.transactionsListBox.FormattingEnabled = true;
            this.transactionsListBox.Location = new System.Drawing.Point(28, 70);
            this.transactionsListBox.Name = "transactionsListBox";
            this.transactionsListBox.Size = new System.Drawing.Size(264, 212);
            this.transactionsListBox.TabIndex = 1;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountLabel.Location = new System.Drawing.Point(418, 70);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(176, 18);
            this.accountLabel.TabIndex = 2;
            this.accountLabel.Text = "Your account balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balanceLabel.Location = new System.Drawing.Point(600, 70);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(79, 18);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "<Balance>";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(418, 134);
            this.errorLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(140, 18);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "<Error message>";
            this.errorLabel.Visible = false;
            // 
            // processInfoLabel
            // 
            this.processInfoLabel.AutoSize = true;
            this.processInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.processInfoLabel.Location = new System.Drawing.Point(418, 107);
            this.processInfoLabel.Name = "processInfoLabel";
            this.processInfoLabel.Size = new System.Drawing.Size(124, 18);
            this.processInfoLabel.TabIndex = 5;
            this.processInfoLabel.Text = "<Process info>";
            this.processInfoLabel.Visible = false;
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buyButton.Location = new System.Drawing.Point(421, 212);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(258, 70);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy something!";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 303);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.processInfoLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.transactionsListBox);
            this.Controls.Add(this.appName);
            this.Name = "DashboardForm";
            this.Text = "Your Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.ListBox transactionsListBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label processInfoLabel;
        private System.Windows.Forms.Button buyButton;
    }
}

