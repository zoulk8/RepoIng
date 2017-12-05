namespace WeeklyReview
{
    partial class FWMTasks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmBTypeTask = new System.Windows.Forms.ComboBox();
            this.wRTTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DataSetTypeTasks = new WeeklyReview.BD_DataSetTypeTasks();
            this.txtBDescTask = new System.Windows.Forms.TextBox();
            this.txtBNameTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorDescTask = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNameTask = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTypeTask = new System.Windows.Forms.ErrorProvider(this.components);
            this.wRTTypeTableAdapter = new WeeklyReview.BD_DataSetTypeTasksTableAdapters.WRTTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRTTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetTypeTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmBTypeTask);
            this.groupBox1.Controls.Add(this.txtBDescTask);
            this.groupBox1.Controls.Add(this.txtBNameTask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Weekly/Monthly Tasks";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Acept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmBTypeTask
            // 
            this.cmBTypeTask.DataSource = this.wRTTypeBindingSource;
            this.cmBTypeTask.DisplayMember = "TTypeDesc";
            this.cmBTypeTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBTypeTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBTypeTask.FormattingEnabled = true;
            this.cmBTypeTask.Location = new System.Drawing.Point(9, 197);
            this.cmBTypeTask.Name = "cmBTypeTask";
            this.cmBTypeTask.Size = new System.Drawing.Size(183, 21);
            this.cmBTypeTask.TabIndex = 5;
            this.cmBTypeTask.ValueMember = "TTypeId";
            // 
            // wRTTypeBindingSource
            // 
            this.wRTTypeBindingSource.DataMember = "WRTType";
            this.wRTTypeBindingSource.DataSource = this.bD_DataSetTypeTasks;
            // 
            // bD_DataSetTypeTasks
            // 
            this.bD_DataSetTypeTasks.DataSetName = "BD_DataSetTypeTasks";
            this.bD_DataSetTypeTasks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBDescTask
            // 
            this.txtBDescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDescTask.Location = new System.Drawing.Point(7, 100);
            this.txtBDescTask.Multiline = true;
            this.txtBDescTask.Name = "txtBDescTask";
            this.txtBDescTask.Size = new System.Drawing.Size(247, 57);
            this.txtBDescTask.TabIndex = 4;
            // 
            // txtBNameTask
            // 
            this.txtBNameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNameTask.Location = new System.Drawing.Point(7, 33);
            this.txtBNameTask.Name = "txtBNameTask";
            this.txtBNameTask.Size = new System.Drawing.Size(247, 20);
            this.txtBNameTask.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Tarea:";
            // 
            // errorDescTask
            // 
            this.errorDescTask.ContainerControl = this;
            // 
            // errorNameTask
            // 
            this.errorNameTask.ContainerControl = this;
            // 
            // errorTypeTask
            // 
            this.errorTypeTask.ContainerControl = this;
            // 
            // wRTTypeTableAdapter
            // 
            this.wRTTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FWMTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 347);
            this.Controls.Add(this.groupBox1);
            this.Name = "FWMTasks";
            this.Text = "Weekly/Monthly Tasks";
            this.Load += new System.EventHandler(this.FWMTasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRTTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetTypeTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmBTypeTask;
        private System.Windows.Forms.TextBox txtBDescTask;
        private System.Windows.Forms.TextBox txtBNameTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorDescTask;
        private System.Windows.Forms.ErrorProvider errorNameTask;
        private System.Windows.Forms.ErrorProvider errorTypeTask;
        private BD_DataSetTypeTasks bD_DataSetTypeTasks;
        private System.Windows.Forms.BindingSource wRTTypeBindingSource;
        private BD_DataSetTypeTasksTableAdapters.WRTTypeTableAdapter wRTTypeTableAdapter;
    }
}