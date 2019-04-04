namespace CollegeRegistration
{
     partial class SectionForm
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
               this.sectionTextBox = new System.Windows.Forms.TextBox();
               this.sectionListBox = new System.Windows.Forms.ListBox();
               this.AddSectionButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // sectionTextBox
               // 
               this.sectionTextBox.Location = new System.Drawing.Point(75, 65);
               this.sectionTextBox.Name = "sectionTextBox";
               this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
               this.sectionTextBox.TabIndex = 5;
               this.sectionTextBox.TextChanged += new System.EventHandler(this.sectionTextBox_TextChanged);
               // 
               // sectionListBox
               // 
               this.sectionListBox.FormattingEnabled = true;
               this.sectionListBox.Location = new System.Drawing.Point(60, 126);
               this.sectionListBox.Name = "sectionListBox";
               this.sectionListBox.Size = new System.Drawing.Size(120, 95);
               this.sectionListBox.TabIndex = 4;
               // 
               // AddSectionButton
               // 
               this.AddSectionButton.Location = new System.Drawing.Point(75, 97);
               this.AddSectionButton.Name = "AddSectionButton";
               this.AddSectionButton.Size = new System.Drawing.Size(75, 23);
               this.AddSectionButton.TabIndex = 3;
               this.AddSectionButton.Text = "Add Section";
               this.AddSectionButton.UseVisualStyleBackColor = true;
               // 
               // SectionForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.sectionTextBox);
               this.Controls.Add(this.sectionListBox);
               this.Controls.Add(this.AddSectionButton);
               this.Name = "SectionForm";
               this.Text = "SectionForm";
               this.Load += new System.EventHandler(this.SectionForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox sectionTextBox;
          private System.Windows.Forms.ListBox sectionListBox;
          private System.Windows.Forms.Button AddSectionButton;
     }
}