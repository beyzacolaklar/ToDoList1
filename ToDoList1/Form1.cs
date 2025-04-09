using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList1
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
                UpdateTaskCount();
            }
        }

        private void UpdateTaskCount()
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                txtTask.Text = lstTasks.SelectedItem.ToString();
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
                UpdateTaskCount();
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
        }

        private void btnMarkComplete_Click1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                string task = lstTasks.SelectedItem.ToString();
                lstTasks.Items[lstTasks.SelectedIndex] = $"✔ {task}";
                UpdateTaskCount();
            }
        }

        private void lblTotalTasks_Click(object sender, EventArgs e)
        {
        }
    }
}

