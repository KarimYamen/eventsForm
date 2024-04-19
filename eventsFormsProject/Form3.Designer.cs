namespace eventsFormsProject
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxUserIdToDelete = new System.Windows.Forms.TextBox();
            this.eventsDBDataSet1 = new eventsFormsProject.eventsDBDataSet();
            this.usersTableAdapter1 = new eventsFormsProject.eventsDBDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager1 = new eventsFormsProject.eventsDBDataSetTableAdapters.TableAdapterManager();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDeleteUser = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(52, 179);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(75, 22);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "User ID:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(78, 236);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 39);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxUserIdToDelete
            // 
            this.textBoxUserIdToDelete.Location = new System.Drawing.Point(135, 179);
            this.textBoxUserIdToDelete.Name = "textBoxUserIdToDelete";
            this.textBoxUserIdToDelete.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserIdToDelete.TabIndex = 2;
            // 
            // eventsDBDataSet1
            // 
            this.eventsDBDataSet1.DataSetName = "eventsDBDataSet";
            this.eventsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.adminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = eventsFormsProject.eventsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExit.Location = new System.Drawing.Point(47, 35);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 37);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDeleteUser
            // 
            this.labelDeleteUser.AutoSize = true;
            this.labelDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteUser.Location = new System.Drawing.Point(40, 113);
            this.labelDeleteUser.Name = "labelDeleteUser";
            this.labelDeleteUser.Size = new System.Drawing.Size(215, 42);
            this.labelDeleteUser.TabIndex = 24;
            this.labelDeleteUser.Text = "Delete User";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.eventsDBDataSet1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDeleteUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxUserIdToDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDelete);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.eventsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxUserIdToDelete;
        private eventsDBDataSet eventsDBDataSet1;
        private eventsDBDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private eventsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDeleteUser;
        private System.Windows.Forms.BindingSource usersBindingSource;
    }
}