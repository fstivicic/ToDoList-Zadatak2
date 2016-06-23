using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDo.EF;

namespace ToDo.Desktop
{
    public partial class InsertTask : Form
    {
        TaskEF task = new TaskEF();
        public InsertTask()
        {
            InitializeComponent();
            var dataSource = new List<Type>();
            dataSource.Add(new Type() { Name = "To Do", Short = "T" });
            dataSource.Add(new Type() { Name = "Pending", Short = "P" });
            dataSource.Add(new Type() { Name = "Done", Short = "D" });

            TypeComboBox.DataSource = dataSource;
            TypeComboBox.DisplayMember = "Name";
            TypeComboBox.ValueMember = "Short";

            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public class Type
        {
            public string Name { get; set; }
            public string Short { get; set; }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task();
            newTask.Name = NameTextBox.Text;
            newTask.Details = DetailTextBox.Text;
            newTask.Flag = TypeComboBox.SelectedValue.ToString();
            task.Insert(newTask);
            this.Close();
        }  
    }  
}
