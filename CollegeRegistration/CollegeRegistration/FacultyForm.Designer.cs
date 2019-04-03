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
               this.FacultyListBox = new System.Windows.Forms.ListBox();
               this.facultyNameAddButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // FacultyNameTextbox
               // 
               this.FacultyNameTextbox.Location = new System.Drawing.Point(50, 133);
               this.FacultyNameTextbox.Name = "FacultyNameTextbox";
               this.FacultyNameTextbox.Size = new System.Drawing.Size(100, 20);
               this.FacultyNameTextbox.TabIndex = 2;
               this.FacultyNameTextbox.TextChanged += new System.EventHandler(this.FacultyNameTextbox_TextChanged);
               // 
               // FacultyListBox
               // 
               this.FacultyListBox.FormattingEnabled = true;
               this.FacultyListBox.Location = new System.Drawing.Point(50, 234);
               this.FacultyListBox.Name = "FacultyListBox";
               this.FacultyListBox.Size = new System.Drawing.Size(120, 95);
               this.FacultyListBox.TabIndex = 3;
               // 
               // facultyNameAddButton
               // 
               this.facultyNameAddButton.Location = new System.Drawing.Point(50, 187);
               this.facultyNameAddButton.Name = "facultyNameAddButton";
               this.facultyNameAddButton.Size = new System.Drawing.Size(75, 23);
               this.facultyNameAddButton.TabIndex = 4;
               this.facultyNameAddButton.Text = "button1";
               this.facultyNameAddButton.UseVisualStyleBackColor = true;
               this.facultyNameAddButton.Click += new System.EventHandler(this.facultyNameAddButton_Click);
               // 
               // FacultyForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.facultyNameAddButton);
               this.Controls.Add(this.FacultyListBox);
               this.Controls.Add(this.FacultyNameTextbox);
               this.Name = "FacultyForm";
               this.Text = "FacultyForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.TextBox FacultyNameTextbox;
          private System.Windows.Forms.ListBox FacultyListBox;
          private System.Windows.Forms.Button facultyNameAddButton;
     }
}