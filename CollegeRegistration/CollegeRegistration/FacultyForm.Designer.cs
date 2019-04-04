namespace CollegeRegistration
{
     partial class FacultyForm
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
               this.FacultyNameTextbox = new System.Windows.Forms.TextBox();
               this.FacultyNameAddButton = new System.Windows.Forms.Button();
               this.FacultyNameLabel = new System.Windows.Forms.Label();
               this.FacultyPhoneNumberTextBox = new System.Windows.Forms.TextBox();
               this.FacultyPhoneNumberLabel = new System.Windows.Forms.Label();
               this.FacultyNameListBox = new System.Windows.Forms.ListBox();
               this.DeleteFacultyButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // FacultyNameTextbox
               // 
               this.FacultyNameTextbox.Location = new System.Drawing.Point(185, 72);
               this.FacultyNameTextbox.Name = "FacultyNameTextbox";
               this.FacultyNameTextbox.Size = new System.Drawing.Size(100, 20);
               this.FacultyNameTextbox.TabIndex = 2;
               this.FacultyNameTextbox.TextChanged += new System.EventHandler(this.FacultyNameTextbox_TextChanged);
               // 
               // FacultyNameAddButton
               // 
               this.FacultyNameAddButton.Location = new System.Drawing.Point(50, 166);
               this.FacultyNameAddButton.Name = "FacultyNameAddButton";
               this.FacultyNameAddButton.Size = new System.Drawing.Size(75, 23);
               this.FacultyNameAddButton.TabIndex = 4;
               this.FacultyNameAddButton.Text = "Add Faculty";
               this.FacultyNameAddButton.UseVisualStyleBackColor = true;
               this.FacultyNameAddButton.Click += new System.EventHandler(this.facultyNameAddButton_Click);
               // 
               // FacultyNameLabel
               // 
               this.FacultyNameLabel.AutoSize = true;
               this.FacultyNameLabel.Location = new System.Drawing.Point(47, 72);
               this.FacultyNameLabel.Name = "FacultyNameLabel";
               this.FacultyNameLabel.Size = new System.Drawing.Size(72, 13);
               this.FacultyNameLabel.TabIndex = 5;
               this.FacultyNameLabel.Text = "Faculty Name";
               // 
               // FacultyPhoneNumberTextBox
               // 
               this.FacultyPhoneNumberTextBox.Location = new System.Drawing.Point(185, 117);
               this.FacultyPhoneNumberTextBox.Name = "FacultyPhoneNumberTextBox";
               this.FacultyPhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
               this.FacultyPhoneNumberTextBox.TabIndex = 6;
               this.FacultyPhoneNumberTextBox.TextChanged += new System.EventHandler(this.FacultyPhoneNumberTextBox_TextChanged);
               // 
               // FacultyPhoneNumberLabel
               // 
               this.FacultyPhoneNumberLabel.AutoSize = true;
               this.FacultyPhoneNumberLabel.Location = new System.Drawing.Point(47, 117);
               this.FacultyPhoneNumberLabel.Name = "FacultyPhoneNumberLabel";
               this.FacultyPhoneNumberLabel.Size = new System.Drawing.Size(115, 13);
               this.FacultyPhoneNumberLabel.TabIndex = 7;
               this.FacultyPhoneNumberLabel.Text = "Faculty Phone Number";
               this.FacultyPhoneNumberLabel.Click += new System.EventHandler(this.FacultyPhoneNumberLabel_Click);
               // 
               // FacultyNameListBox
               // 
               this.FacultyNameListBox.FormattingEnabled = true;
               this.FacultyNameListBox.Location = new System.Drawing.Point(50, 221);
               this.FacultyNameListBox.Name = "FacultyNameListBox";
               this.FacultyNameListBox.Size = new System.Drawing.Size(276, 134);
               this.FacultyNameListBox.TabIndex = 9;
               this.FacultyNameListBox.SelectedIndexChanged += new System.EventHandler(this.FacultyNameListBox_SelectedIndexChanged);
               // 
               // DeleteFacultyButton
               // 
               this.DeleteFacultyButton.Location = new System.Drawing.Point(356, 221);
               this.DeleteFacultyButton.Name = "DeleteFacultyButton";
               this.DeleteFacultyButton.Size = new System.Drawing.Size(102, 23);
               this.DeleteFacultyButton.TabIndex = 10;
               this.DeleteFacultyButton.Text = "Delete Faculty";
               this.DeleteFacultyButton.UseVisualStyleBackColor = true;
               this.DeleteFacultyButton.Click += new System.EventHandler(this.DeleteFacultyButton_Click);
               // 
               // FacultyForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.DeleteFacultyButton);
               this.Controls.Add(this.FacultyNameListBox);
               this.Controls.Add(this.FacultyPhoneNumberLabel);
               this.Controls.Add(this.FacultyPhoneNumberTextBox);
               this.Controls.Add(this.FacultyNameLabel);
               this.Controls.Add(this.FacultyNameAddButton);
               this.Controls.Add(this.FacultyNameTextbox);
               this.Name = "FacultyForm";
               this.Text = "FacultyForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.TextBox FacultyNameTextbox;
          private System.Windows.Forms.Button FacultyNameAddButton;
          private System.Windows.Forms.Label FacultyNameLabel;
          private System.Windows.Forms.TextBox FacultyPhoneNumberTextBox;
          private System.Windows.Forms.Label FacultyPhoneNumberLabel;
          private System.Windows.Forms.ListBox FacultyNameListBox;
          private System.Windows.Forms.Button DeleteFacultyButton;
     }
}