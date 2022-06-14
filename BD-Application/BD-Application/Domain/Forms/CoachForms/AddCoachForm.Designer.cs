﻿namespace BD_Application.Domain.Forms.CoachForms {
    partial class AddCoachForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCoachButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.BirthdayBox = new System.Windows.Forms.DateTimePicker();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddCoachButton);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.BirthdayLabel);
            this.panel1.Controls.Add(this.NickNameLabel);
            this.panel1.Controls.Add(this.BirthdayBox);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 172);
            this.panel1.TabIndex = 0;
            // 
            // AddCoachButton
            // 
            this.AddCoachButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCoachButton.Location = new System.Drawing.Point(6, 126);
            this.AddCoachButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddCoachButton.Name = "AddCoachButton";
            this.AddCoachButton.Size = new System.Drawing.Size(378, 37);
            this.AddCoachButton.TabIndex = 22;
            this.AddCoachButton.Text = "Add Coach";
            this.AddCoachButton.UseVisualStyleBackColor = true;
            this.AddCoachButton.Click += new System.EventHandler(this.AddCoachButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(84, 46);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 22);
            this.NameBox.TabIndex = 19;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(6, 78);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(70, 22);
            this.BirthdayLabel.TabIndex = 21;
            this.BirthdayLabel.Text = "Birthday";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.Location = new System.Drawing.Point(6, 14);
            this.NickNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(70, 22);
            this.NickNameLabel.TabIndex = 16;
            this.NickNameLabel.Text = "Nickname";
            this.NickNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayBox.Location = new System.Drawing.Point(84, 78);
            this.BirthdayBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(300, 22);
            this.BirthdayBox.TabIndex = 20;
            this.BirthdayBox.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // NickNameBox
            // 
            this.NickNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NickNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickNameBox.Location = new System.Drawing.Point(84, 14);
            this.NickNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(300, 22);
            this.NickNameBox.TabIndex = 17;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(6, 46);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 22);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 196);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(430, 235);
            this.Name = "AddCoachForm";
            this.Text = "Add Coach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCoachButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.DateTimePicker BirthdayBox;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Label NameLabel;
    }
}