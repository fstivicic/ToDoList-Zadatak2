namespace ToDo.Desktop
{
    partial class TaskList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PendingListTab = new System.Windows.Forms.TabPage();
            this.PendingListBox = new System.Windows.Forms.ListBox();
            this.ToDoList = new System.Windows.Forms.TabPage();
            this.ToDoListBox = new System.Windows.Forms.ListBox();
            this.DoneList = new System.Windows.Forms.TabPage();
            this.DoneListBox = new System.Windows.Forms.ListBox();
            this.DetailsText = new System.Windows.Forms.RichTextBox();
            this.PendingButton = new System.Windows.Forms.Button();
            this.ToDoButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PendingListTab.SuspendLayout();
            this.ToDoList.SuspendLayout();
            this.DoneList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PendingListTab);
            this.tabControl1.Controls.Add(this.ToDoList);
            this.tabControl1.Controls.Add(this.DoneList);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 176);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabSelected);
            // 
            // PendingListTab
            // 
            this.PendingListTab.Controls.Add(this.PendingListBox);
            this.PendingListTab.Location = new System.Drawing.Point(4, 22);
            this.PendingListTab.Name = "PendingListTab";
            this.PendingListTab.Padding = new System.Windows.Forms.Padding(3);
            this.PendingListTab.Size = new System.Drawing.Size(251, 150);
            this.PendingListTab.TabIndex = 0;
            this.PendingListTab.Text = "Pending";
            this.PendingListTab.UseVisualStyleBackColor = true;
            // 
            // PendingListBox
            // 
            this.PendingListBox.FormattingEnabled = true;
            this.PendingListBox.Location = new System.Drawing.Point(-3, 0);
            this.PendingListBox.Name = "PendingListBox";
            this.PendingListBox.Size = new System.Drawing.Size(259, 147);
            this.PendingListBox.TabIndex = 0;
            this.PendingListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedTaskP);
            // 
            // ToDoList
            // 
            this.ToDoList.Controls.Add(this.ToDoListBox);
            this.ToDoList.Location = new System.Drawing.Point(4, 22);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Padding = new System.Windows.Forms.Padding(3);
            this.ToDoList.Size = new System.Drawing.Size(251, 150);
            this.ToDoList.TabIndex = 1;
            this.ToDoList.Text = "To Do";
            this.ToDoList.UseVisualStyleBackColor = true;
            // 
            // ToDoListBox
            // 
            this.ToDoListBox.FormattingEnabled = true;
            this.ToDoListBox.Location = new System.Drawing.Point(-4, 0);
            this.ToDoListBox.Name = "ToDoListBox";
            this.ToDoListBox.Size = new System.Drawing.Size(259, 147);
            this.ToDoListBox.TabIndex = 1;
            this.ToDoListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedTaskT);
            // 
            // DoneList
            // 
            this.DoneList.Controls.Add(this.DoneListBox);
            this.DoneList.Location = new System.Drawing.Point(4, 22);
            this.DoneList.Name = "DoneList";
            this.DoneList.Padding = new System.Windows.Forms.Padding(3);
            this.DoneList.Size = new System.Drawing.Size(251, 150);
            this.DoneList.TabIndex = 2;
            this.DoneList.Text = "Done";
            this.DoneList.UseVisualStyleBackColor = true;
            // 
            // DoneListBox
            // 
            this.DoneListBox.FormattingEnabled = true;
            this.DoneListBox.Location = new System.Drawing.Point(-4, 0);
            this.DoneListBox.Name = "DoneListBox";
            this.DoneListBox.Size = new System.Drawing.Size(259, 147);
            this.DoneListBox.TabIndex = 1;
            this.DoneListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedTaskD);
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(12, 194);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(340, 56);
            this.DetailsText.TabIndex = 1;
            this.DetailsText.Text = "";
            // 
            // PendingButton
            // 
            this.PendingButton.Location = new System.Drawing.Point(277, 34);
            this.PendingButton.Name = "PendingButton";
            this.PendingButton.Size = new System.Drawing.Size(75, 23);
            this.PendingButton.TabIndex = 2;
            this.PendingButton.Text = "Pending";
            this.PendingButton.UseVisualStyleBackColor = true;
            this.PendingButton.Click += new System.EventHandler(this.ChangeToPending);
            // 
            // ToDoButton
            // 
            this.ToDoButton.Location = new System.Drawing.Point(277, 63);
            this.ToDoButton.Name = "ToDoButton";
            this.ToDoButton.Size = new System.Drawing.Size(75, 23);
            this.ToDoButton.TabIndex = 3;
            this.ToDoButton.Text = "To Do";
            this.ToDoButton.UseVisualStyleBackColor = true;
            this.ToDoButton.Click += new System.EventHandler(this.ChangeToToDo);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(277, 92);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.ChangeToDone);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(277, 121);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertSelected);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(277, 150);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteTask);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ToDoButton);
            this.Controls.Add(this.PendingButton);
            this.Controls.Add(this.DetailsText);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskList";
            this.Text = "ToDoList";
            this.tabControl1.ResumeLayout(false);
            this.PendingListTab.ResumeLayout(false);
            this.ToDoList.ResumeLayout(false);
            this.DoneList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PendingListTab;
        private System.Windows.Forms.TabPage ToDoList;
        private System.Windows.Forms.ListBox PendingListBox;
        private System.Windows.Forms.ListBox ToDoListBox;
        private System.Windows.Forms.ListBox DoneListBox;
        private System.Windows.Forms.RichTextBox DetailsText;
        private System.Windows.Forms.TabPage DoneList;
        private System.Windows.Forms.Button PendingButton;
        private System.Windows.Forms.Button ToDoButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

