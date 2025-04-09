namespace ToDoList1
{
    partial class frmToDoList
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(20, 20);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(320, 22);
            this.txtTask.TabIndex = 0;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 16;
            this.lstTasks.Location = new System.Drawing.Point(20, 48);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(450, 196);
            this.lstTasks.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(180, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DeleteTask";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Location = new System.Drawing.Point(340, 300);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(180, 30);
            this.btnMarkComplete.TabIndex = 5;
            this.btnMarkComplete.Text = "MarkCompleted";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.Location = new System.Drawing.Point(20, 340);
            this.lblTotalTasks.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblTotalTasks.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(250, 30);
            this.lblTotalTasks.TabIndex = 6;
            this.lblTotalTasks.Text = "Total Tasks: 0";
            this.lblTotalTasks.Click += new System.EventHandler(this.lblTotalTasks_Click);
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.txtTask);
            this.Name = "frmToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Label lblTotalTasks;
    }
}

