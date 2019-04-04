namespace CollegeRegistration
{
     partial class MajorForm
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
               this.MajorNameListBox = new System.Windows.Forms.ListBox();
               this.MajorCollegeListBox = new System.Windows.Forms.ListBox();
               this.MajorNameLabel = new System.Windows.Forms.Label();
               this.MajorNameTextBox = new System.Windows.Forms.TextBox();
               this.MajorCollegeTextBox = new System.Windows.Forms.TextBox();
               this.MajorAddButton = new System.Windows.Forms.Button();
               this.DeleteMajorButton = new System.Windows.Forms.Button();
               this.ChooseCollegeLabel = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // MajorNameListBox
               // 
               this.MajorNameListBox.FormattingEnabled = true;
               this.MajorNameListBox.Location = new System.Drawing.Point(88, 141);
               this.MajorNameListBox.Name = "MajorNameListBox";
               this.MajorNameListBox.Size = new System.Drawing.Size(200, 147);
               this.MajorNameListBox.TabIndex = 0;
               this.MajorNameListBox.SelectedIndexChanged += new System.EventHandler(this.MajorNameListBox_SelectedIndexChanged);
               // 
               // MajorCollegeListBox
               // 
               this.MajorCollegeListBox.FormattingEnabled = true;
               this.MajorCollegeListBox.Location = new System.Drawing.Point(440, 141);
               this.MajorCollegeListBox.Name = "MajorCollegeListBox";
               this.MajorCollegeListBox.Size = new System.Drawing.Size(212, 147);
               this.MajorCollegeListBox.TabIndex = 1;
               this.MajorCollegeListBox.SelectedIndexChanged += new System.EventHandler(this.MajorCollegeListBox_SelectedIndexChanged);
               // 
               // MajorNameLabel
               // 
               this.MajorNameLabel.AutoSize = true;
               this.MajorNameLabel.Location = new System.Drawing.Point(18, 55);
               this.MajorNameLabel.Name = "MajorNameLabel";
               this.MajorNameLabel.Size = new System.Drawing.Size(64, 13);
               this.MajorNameLabel.TabIndex = 2;
               this.MajorNameLabel.Text = "Add a Major";
               // 
               // MajorNameTextBox
               // 
               this.MajorNameTextBox.Location = new System.Drawing.Point(88, 55);
               this.MajorNameTextBox.Name = "MajorNameTextBox";
               this.MajorNameTextBox.Size = new System.Drawing.Size(100, 20);
               this.MajorNameTextBox.TabIndex = 3;
               // 
               // MajorCollegeTextBox
               // 
               this.MajorCollegeTextBox.Location = new System.Drawing.Point(468, 55);
               this.MajorCollegeTextBox.Name = "MajorCollegeTextBox";
               this.MajorCollegeTextBox.Size = new System.Drawing.Size(100, 20);
               this.MajorCollegeTextBox.TabIndex = 4;
               // 
               // MajorAddButton
               // 
               this.MajorAddButton.Location = new System.Drawing.Point(88, 101);
               this.MajorAddButton.Name = "MajorAddButton";
               this.MajorAddButton.Size = new System.Drawing.Size(75, 23);
               this.MajorAddButton.TabIndex = 6;
               this.MajorAddButton.Text = "Add Major";
               this.MajorAddButton.UseVisualStyleBackColor = true;
               this.MajorAddButton.Click += new System.EventHandler(this.MajorAddButton_Click);
               // 
               // DeleteMajorButton
               // 
               this.DeleteMajorButton.Location = new System.Drawing.Point(197, 101);
               this.DeleteMajorButton.Name = "DeleteMajorButton";
               this.DeleteMajorButton.Size = new System.Drawing.Size(75, 23);
               this.DeleteMajorButton.TabIndex = 8;
               this.DeleteMajorButton.Text = "Delete Major";
               this.DeleteMajorButton.UseVisualStyleBackColor = true;
               this.DeleteMajorButton.Click += new System.EventHandler(this.DeleteMajorButton_Click);
               // 
               // ChooseCollegeLabel
               // 
               this.ChooseCollegeLabel.AutoSize = true;
               this.ChooseCollegeLabel.Location = new System.Drawing.Point(372, 58);
               this.ChooseCollegeLabel.Name = "ChooseCollegeLabel";
               this.ChooseCollegeLabel.Size = new System.Drawing.Size(90, 13);
               this.ChooseCollegeLabel.TabIndex = 9;
               this.ChooseCollegeLabel.Text = "Choose a College";
               // 
               // MajorForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.ChooseCollegeLabel);
               this.Controls.Add(this.DeleteMajorButton);
               this.Controls.Add(this.MajorAddButton);
               this.Controls.Add(this.MajorCollegeTextBox);
               this.Controls.Add(this.MajorNameTextBox);
               this.Controls.Add(this.MajorNameLabel);
               this.Controls.Add(this.MajorCollegeListBox);
               this.Controls.Add(this.MajorNameListBox);
               this.Name = "MajorForm";
               this.Text = "MajorForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox MajorNameListBox;
          private System.Windows.Forms.ListBox MajorCollegeListBox;
          private System.Windows.Forms.Label MajorNameLabel;
          private System.Windows.Forms.TextBox MajorNameTextBox;
          private System.Windows.Forms.TextBox MajorCollegeTextBox;
          private System.Windows.Forms.Button MajorAddButton;
          private System.Windows.Forms.Button DeleteMajorButton;
          private System.Windows.Forms.Label ChooseCollegeLabel;
     }
}