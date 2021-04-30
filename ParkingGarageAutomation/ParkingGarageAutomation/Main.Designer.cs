
namespace ParkingGarageAutomation
{
    partial class Main
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
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.parkingSpotLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTextBox.Location = new System.Drawing.Point(202, 164);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.fNameTextBox.TabIndex = 2;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTextBox.Location = new System.Drawing.Point(202, 200);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.lNameTextBox.TabIndex = 3;
            // 
            // checkInButton
            // 
            this.checkInButton.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInButton.Location = new System.Drawing.Point(359, 239);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(94, 34);
            this.checkInButton.TabIndex = 4;
            this.checkInButton.Text = "Check in";
            this.checkInButton.UseVisualStyleBackColor = true;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(359, 279);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(94, 34);
            this.checkOutButton.TabIndex = 5;
            this.checkOutButton.Text = "Check out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receiptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptLabel.Location = new System.Drawing.Point(476, 9);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(204, 353);
            this.receiptLabel.TabIndex = 6;
            this.receiptLabel.Text = "label3";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(598, 376);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(82, 30);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // parkingSpotLabel
            // 
            this.parkingSpotLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.parkingSpotLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parkingSpotLabel.Location = new System.Drawing.Point(59, 249);
            this.parkingSpotLabel.Name = "parkingSpotLabel";
            this.parkingSpotLabel.Size = new System.Drawing.Size(157, 157);
            this.parkingSpotLabel.TabIndex = 8;
            this.parkingSpotLabel.Text = "label3";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 431);
            this.Controls.Add(this.parkingSpotLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Parking Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label parkingSpotLabel;
    }
}

