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
    public partial class TaskList : Form
    {
        TaskEF task = new TaskEF();
        public TaskList()
        {
            InitializeComponent();
            Fetch();
            DetailsText.Text = "Choose task for details.";
            PendingButton.Enabled = false;
            DoneButton.Enabled = true;
            ToDoButton.Enabled = true;
            DetailsText.ReadOnly = true;
            try { PendingListBox.SetSelected(0, true); }
            catch {
            }
        }
        public void Fetch()
        {

            BindingList<Task> tasks = new BindingList<Task>(task.fetchKind("P"));
            PendingListBox.DataSource = tasks;
            PendingListBox.DisplayMember = "Name";
            PendingListBox.ValueMember = "ID";
            tasks = new BindingList<Task>(task.fetchKind("T"));
            ToDoListBox.DataSource = tasks;
            ToDoListBox.DisplayMember = "Name";
            ToDoListBox.ValueMember = "ID";
            tasks = new BindingList<Task>(task.fetchKind("D"));
            DoneListBox.DataSource = tasks;
            DoneListBox.DisplayMember = "Name";
            DoneListBox.ValueMember = "ID";
        }

        private void SelectedTaskP(object sender, EventArgs e)
        {
            try
            {
                DetailsText.Text = task.fetchDetails(Convert.ToInt32(PendingListBox.SelectedValue.ToString()));

            }
            catch {
            }
        }
        private void SelectedTaskT(object sender, EventArgs e)
        {
            try
            {
                DetailsText.Text = task.fetchDetails(Convert.ToInt32(ToDoListBox.SelectedValue.ToString()));

            }
            catch{
            }
        }
        private void SelectedTaskD(object sender, EventArgs e)
        {
            try
            {
                DetailsText.Text = task.fetchDetails(Convert.ToInt32(DoneListBox.SelectedValue.ToString()));
            }
            catch {
            }
        }

        private void ChangeToPending(object sender, EventArgs e)
        {
            Task t = new Task();
            if (tabControl1.SelectedTab.Name.Equals("ToDoList"))
            {
                t.ID = Convert.ToInt32(ToDoListBox.SelectedValue.ToString());
                t.Flag = "P";
                task.Update(t);
            }
            else
            {
                t.ID = Convert.ToInt32(DoneListBox.SelectedValue.ToString());
                t.Flag = "P";
                task.Update(t);
            }
            Fetch();
        }

        private void ChangeToToDo(object sender, EventArgs e)
        {
            Task t = new Task();
            if (tabControl1.SelectedTab.Name.Equals("PendingListTab"))
            {
                t.ID = Convert.ToInt32(PendingListBox.SelectedValue.ToString());
                t.Flag = "T";
                task.Update(t);
            }
            else
            {
                t.ID = Convert.ToInt32(DoneListBox.SelectedValue.ToString());
                t.Flag = "T";
                task.Update(t);
            }
            Fetch();
        }

        private void ChangeToDone(object sender, EventArgs e)
        {
            Task t = new Task();
            if (tabControl1.SelectedTab.Name.Equals("ToDoList"))
            {
                t.ID = Convert.ToInt32(ToDoListBox.SelectedValue.ToString());
                t.Flag = "D";
                task.Update(t);
            }
            else
            {
                t.ID = Convert.ToInt32(PendingListBox.SelectedValue.ToString());
                t.Flag = "D";
                task.Update(t);
            }
            Fetch();
        }

        private void TabSelected(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["PendingListTab"])
            {
                PendingButton.Enabled = false;
                DoneButton.Enabled = true;
                ToDoButton.Enabled = true;
                try
                {
                    PendingListBox.SetSelected(0, true);
                }
                catch {
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["DoneList"])
            {
                PendingButton.Enabled = true;
                DoneButton.Enabled = false;
                ToDoButton.Enabled = true;
                try
                {
                    DoneListBox.SetSelected(0, true);
                }
                catch { 
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["ToDoList"])
            {
                PendingButton.Enabled = true;
                DoneButton.Enabled = true;
                ToDoButton.Enabled = false;
                try
                {
                    ToDoListBox.SetSelected(0, true);
                }
                catch {
                }
            }
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tabControl1.SelectedTab.Name.Equals("PendingListTab"))
                {
                    task.Delete(Convert.ToInt32(PendingListBox.SelectedValue.ToString()));
                }
                if (tabControl1.SelectedTab.Name.Equals("DoneList"))
                {
                    task.Delete(Convert.ToInt32(DoneListBox.SelectedValue.ToString()));
                }
                if (tabControl1.SelectedTab.Name.Equals("ToDoList"))
                {
                    task.Delete(Convert.ToInt32(ToDoListBox.SelectedValue.ToString()));
                }
                Fetch();
            }
        }
        private void InsertSelected(Object sender, EventArgs e)
        {

            InsertTask insertForm = new InsertTask();
            insertForm.FormClosing += new FormClosingEventHandler(InsertTaskClosing);
            insertForm.Show();
        }
        private void InsertTaskClosing(object sender, FormClosingEventArgs e)
        {
            Fetch();
        }
    }
}
