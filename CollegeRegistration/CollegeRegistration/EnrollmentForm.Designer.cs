namespace CollegeRegistration
{
     partial class EnrollmentForm
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
               this.EnrollStudentIDLabel = new System.Windows.Forms.Label();
               this.EnrollListBox = new System.Windows.Forms.ListBox();
               this.EnrollStudentIDTextBox = new System.Windows.Forms.TextBox();
               this.EnrollSectionIDTextBox = new System.Windows.Forms.TextBox();
               this.EnrollSectionIDLabel = new System.Windows.Forms.Label();
               this.EnrollGradeTextBox = new System.Windows.Forms.TextBox();
               this.EnrollGradeLabel = new System.Windows.Forms.Label();
               this.AddStudentIDButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // EnrollStudentIDLabel
               // 
               this.EnrollStudentIDLabel.AutoSize = true;
               this.EnrollStudentIDLabel.Location = new System.Drawing.Point(34, 85);
               this.EnrollStudentIDLabel.Name = "EnrollStudentIDLabel";
               this.EnrollStudentIDLabel.Size = new System.Drawing.Size(58, 13);
               this.EnrollStudentIDLabel.TabIndex = 0;
               this.EnrollStudentIDLabel.Text = "Student ID";
               // 
               // EnrollListBox
               // 
               this.EnrollListBox.FormattingEnabled = true;
               this.EnrollListBox.Location = new System.Drawing.Point(37, 166);
               this.EnrollListBox.Name = "EnrollListBox";
               this.EnrollListBox.Size = new System.Drawing.Size(338, 160);
               this.EnrollListBox.TabIndex = 1;
               this.EnrollListBox.SelectedIndexChanged += new System.EventHandler(this.EnrollListBox_SelectedIndexChanged);
               // 
               // EnrollStudentIDTextBox
               // 
               this.EnrollStudentIDTextBox.Location = new System.Drawing.Point(98, 82);
               this.EnrollStudentIDTextBox.Name = "EnrollStudentIDTextBox";
               this.EnrollStudentIDTextBox.Size = new System.Drawing.Size(100, 20);
               this.EnrollStudentIDTextBox.TabIndex = 2;
               // 
               // EnrollSectionIDTextBox
               // 
               this.EnrollSectionIDTextBox.Location = new System.Drawing.Point(326, 82);
               this.EnrollSectionIDTextBox.Name = "EnrollSectionIDTextBox";
               this.EnrollSectionIDTextBox.Size = new System.Drawing.Size(100, 20);
               this.EnrollSectionIDTextBox.TabIndex = 5;
               // 
               // EnrollSectionIDLabel
               // 
               this.EnrollSectionIDLabel.AutoSize = true;
               this.EnrollSectionIDLabel.Location = new System.Drawing.Point(262, 85);
               this.EnrollSectionIDLabel.Name = "EnrollSectionIDLabel";
               this.EnrollSectionIDLabel.Size = new System.Drawing.Size(57, 13);
               this.EnrollSectionIDLabel.TabIndex = 3;
               this.EnrollSectionIDLabel.Text = "Section ID";
               // 
               // EnrollGradeTextBox
               // 
               this.EnrollGradeTextBox.Location = new System.Drawing.Point(530, 82);
               this.EnrollGradeTextBox.Name = "EnrollGradeTextBox";
               this.EnrollGradeTextBox.Size = new System.Drawing.Size(100, 20);
               this.EnrollGradeTextBox.TabIndex = 8;
               // 
               // EnrollGradeLabel
               // 
               this.EnrollGradeLabel.AutoSize = true;
               this.EnrollGradeLabel.Location = new System.Drawing.Point(488, 85);
               this.EnrollGradeLabel.Name = "EnrollGradeLabel";
               this.EnrollGradeLabel.Size = new System.Drawing.Size(36, 13);
               this.EnrollGradeLabel.TabIndex = 6;
               this.EnrollGradeLabel.Text = "Grade";
               // 
               // AddStudentIDButton
               // 
               this.AddStudentIDButton.Location = new System.Drawing.Point(37, 127);
               this.AddStudentIDButton.Name = "AddStudentIDButton";
               this.AddStudentIDButton.Size = new System.Drawing.Size(115, 23);
               this.AddStudentIDButton.TabIndex = 9;
               this.AddStudentIDButton.Text = "Add Student ID";
               this.AddStudentIDButton.UseVisualStyleBackColor = true;
               this.AddStudentIDButton.Click += new System.EventHandler(this.AddStudentIDButton_Click);
               // 
               // EnrollmentForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.AddStudentIDButton);
               this.Controls.Add(this.EnrollGradeTextBox);
               this.Controls.Add(this.EnrollGradeLabel);
               this.Controls.Add(this.EnrollSectionIDTextBox);
               this.Controls.Add(this.EnrollSectionIDLabel);
               this.Controls.Add(this.EnrollStudentIDTextBox);
               this.Controls.Add(this.EnrollListBox);
               this.Controls.Add(this.EnrollStudentIDLabel);
               this.Name = "EnrollmentForm";
               this.Text = "EnrollmentForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label EnrollStudentIDLabel;
          private System.Windows.Forms.ListBox EnrollListBox;
          private System.Windows.Forms.TextBox EnrollStudentIDTextBox;
          private System.Windows.Forms.TextBox EnrollSectionIDTextBox;
          private System.Windows.Forms.Label EnrollSectionIDLabel;
          private System.Windows.Forms.TextBox EnrollGradeTextBox;
          private System.Windows.Forms.Label EnrollGradeLabel;
          private System.Windows.Forms.Button AddStudentIDButton;
     }
}