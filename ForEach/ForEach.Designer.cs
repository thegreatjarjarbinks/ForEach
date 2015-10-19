namespace ForEach
{
    partial class frmForEach
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
            this.btnThisOne = new System.Windows.Forms.Button();
            this.btnNoMe = new System.Windows.Forms.Button();
            this.btnDoMe = new System.Windows.Forms.Button();
            this.btnCoolButton = new System.Windows.Forms.Button();
            this.lblPickWisely = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThisOne
            // 
            this.btnThisOne.Location = new System.Drawing.Point(140, 12);
            this.btnThisOne.Name = "btnThisOne";
            this.btnThisOne.Size = new System.Drawing.Size(75, 23);
            this.btnThisOne.TabIndex = 0;
            this.btnThisOne.Text = "Choose me";
            this.btnThisOne.UseVisualStyleBackColor = true;
            this.btnThisOne.Click += new System.EventHandler(this.btnThisOne_Click);
            // 
            // btnNoMe
            // 
            this.btnNoMe.Location = new System.Drawing.Point(127, 229);
            this.btnNoMe.Name = "btnNoMe";
            this.btnNoMe.Size = new System.Drawing.Size(90, 23);
            this.btnNoMe.TabIndex = 1;
            this.btnNoMe.Text = "No choose me!";
            this.btnNoMe.UseVisualStyleBackColor = true;
            this.btnNoMe.Click += new System.EventHandler(this.btnNoMe_Click);
            // 
            // btnDoMe
            // 
            this.btnDoMe.Location = new System.Drawing.Point(266, 113);
            this.btnDoMe.Name = "btnDoMe";
            this.btnDoMe.Size = new System.Drawing.Size(75, 23);
            this.btnDoMe.TabIndex = 2;
            this.btnDoMe.Text = "Use me!";
            this.btnDoMe.UseVisualStyleBackColor = true;
            this.btnDoMe.Click += new System.EventHandler(this.btnDoMe_Click);
            // 
            // btnCoolButton
            // 
            this.btnCoolButton.Location = new System.Drawing.Point(13, 113);
            this.btnCoolButton.Name = "btnCoolButton";
            this.btnCoolButton.Size = new System.Drawing.Size(75, 23);
            this.btnCoolButton.TabIndex = 3;
            this.btnCoolButton.Text = "I\'m Cool";
            this.btnCoolButton.UseVisualStyleBackColor = true;
            this.btnCoolButton.Click += new System.EventHandler(this.btnCoolButton_Click);
            // 
            // lblPickWisely
            // 
            this.lblPickWisely.AutoSize = true;
            this.lblPickWisely.Location = new System.Drawing.Point(140, 122);
            this.lblPickWisely.Name = "lblPickWisely";
            this.lblPickWisely.Size = new System.Drawing.Size(77, 13);
            this.lblPickWisely.TabIndex = 4;
            this.lblPickWisely.Text = "Choose Wisely";
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 264);
            this.Controls.Add(this.lblPickWisely);
            this.Controls.Add(this.btnCoolButton);
            this.Controls.Add(this.btnDoMe);
            this.Controls.Add(this.btnNoMe);
            this.Controls.Add(this.btnThisOne);
            this.Name = "frmForEach";
            this.Text = "For Each";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThisOne;
        private System.Windows.Forms.Button btnNoMe;
        private System.Windows.Forms.Button btnDoMe;
        private System.Windows.Forms.Button btnCoolButton;
        private System.Windows.Forms.Label lblPickWisely;
    }
}

