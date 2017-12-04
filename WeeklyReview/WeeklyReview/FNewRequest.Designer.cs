namespace WeeklyReview
{
    partial class FNewRequest
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
            this.dateTPFinalReq = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmBUsuAsignedReq = new System.Windows.Forms.ComboBox();
            this.dateTPInitReq = new System.Windows.Forms.DateTimePicker();
            this.cmBPriorityReq = new System.Windows.Forms.ComboBox();
            this.cmBSolReq = new System.Windows.Forms.ComboBox();
            this.txtBDescReq = new System.Windows.Forms.TextBox();
            this.txtBNameReq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wRCatAsocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_BIPlatformDataSet3 = new WeeklyReview.BD_BIPlatformDataSet3();
            this.wRCatPriorityReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_BIPlatformDataSet1 = new WeeklyReview.BD_BIPlatformDataSet1();
            this.wRCatAsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_BIPlatformDataSet = new WeeklyReview.BD_BIPlatformDataSet();
            this.wRCatAsocTableAdapter = new WeeklyReview.BD_BIPlatformDataSetTableAdapters.WRCatAsocTableAdapter();
            this.wRCatPriorityReqTableAdapter = new WeeklyReview.BD_BIPlatformDataSet1TableAdapters.WRCatPriorityReqTableAdapter();
            this.wRCatAsocTableAdapter1 = new WeeklyReview.BD_BIPlatformDataSet3TableAdapters.WRCatAsocTableAdapter();
            this.errorNameReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDReq1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDReq2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNameSol = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPriority = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUserAssigned = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatPriorityReqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDReq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDReq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserAssigned)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTPFinalReq);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmBUsuAsignedReq);
            this.groupBox1.Controls.Add(this.dateTPInitReq);
            this.groupBox1.Controls.Add(this.cmBPriorityReq);
            this.groupBox1.Controls.Add(this.cmBSolReq);
            this.groupBox1.Controls.Add(this.txtBDescReq);
            this.groupBox1.Controls.Add(this.txtBNameReq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Request";
            // 
            // dateTPFinalReq
            // 
            this.dateTPFinalReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTPFinalReq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPFinalReq.Location = new System.Drawing.Point(41, 265);
            this.dateTPFinalReq.Name = "dateTPFinalReq";
            this.dateTPFinalReq.Size = new System.Drawing.Size(101, 20);
            this.dateTPFinalReq.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Al:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Del:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(81, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmBUsuAsignedReq
            // 
            this.cmBUsuAsignedReq.DataSource = this.wRCatAsocBindingSource1;
            this.cmBUsuAsignedReq.DisplayMember = "AsocName";
            this.cmBUsuAsignedReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBUsuAsignedReq.FormattingEnabled = true;
            this.cmBUsuAsignedReq.Location = new System.Drawing.Point(6, 375);
            this.cmBUsuAsignedReq.Name = "cmBUsuAsignedReq";
            this.cmBUsuAsignedReq.Size = new System.Drawing.Size(233, 21);
            this.cmBUsuAsignedReq.TabIndex = 11;
            this.cmBUsuAsignedReq.ValueMember = "AsocId";
            // 
            // dateTPInitReq
            // 
            this.dateTPInitReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTPInitReq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPInitReq.Location = new System.Drawing.Point(41, 239);
            this.dateTPInitReq.Name = "dateTPInitReq";
            this.dateTPInitReq.Size = new System.Drawing.Size(101, 20);
            this.dateTPInitReq.TabIndex = 10;
            this.dateTPInitReq.ValueChanged += new System.EventHandler(this.dateTPInitReq_ValueChanged);
            // 
            // cmBPriorityReq
            // 
            this.cmBPriorityReq.DataSource = this.wRCatPriorityReqBindingSource;
            this.cmBPriorityReq.DisplayMember = "PriorityRDesc";
            this.cmBPriorityReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBPriorityReq.FormattingEnabled = true;
            this.cmBPriorityReq.Location = new System.Drawing.Point(6, 320);
            this.cmBPriorityReq.Name = "cmBPriorityReq";
            this.cmBPriorityReq.Size = new System.Drawing.Size(236, 21);
            this.cmBPriorityReq.TabIndex = 9;
            this.cmBPriorityReq.ValueMember = "PriorityRId";
            this.cmBPriorityReq.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmBSolReq
            // 
            this.cmBSolReq.DataSource = this.wRCatAsocBindingSource;
            this.cmBSolReq.DisplayMember = "AsocName";
            this.cmBSolReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBSolReq.FormattingEnabled = true;
            this.cmBSolReq.Location = new System.Drawing.Point(6, 181);
            this.cmBSolReq.Name = "cmBSolReq";
            this.cmBSolReq.Size = new System.Drawing.Size(245, 21);
            this.cmBSolReq.TabIndex = 8;
            this.cmBSolReq.ValueMember = "AsocId";
            // 
            // txtBDescReq
            // 
            this.txtBDescReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBDescReq.Location = new System.Drawing.Point(6, 96);
            this.txtBDescReq.Multiline = true;
            this.txtBDescReq.Name = "txtBDescReq";
            this.txtBDescReq.Size = new System.Drawing.Size(245, 56);
            this.txtBDescReq.TabIndex = 7;
            // 
            // txtBNameReq
            // 
            this.txtBNameReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBNameReq.Location = new System.Drawing.Point(6, 42);
            this.txtBNameReq.Multiline = true;
            this.txtBNameReq.Name = "txtBNameReq";
            this.txtBNameReq.Size = new System.Drawing.Size(245, 20);
            this.txtBNameReq.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asociado a asignar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prioridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo Estimado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solicita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Solicitud:";
            // 
            // wRCatAsocBindingSource1
            // 
            this.wRCatAsocBindingSource1.DataMember = "WRCatAsoc";
            this.wRCatAsocBindingSource1.DataSource = this.bD_BIPlatformDataSet3;
            // 
            // bD_BIPlatformDataSet3
            // 
            this.bD_BIPlatformDataSet3.DataSetName = "BD_BIPlatformDataSet3";
            this.bD_BIPlatformDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wRCatPriorityReqBindingSource
            // 
            this.wRCatPriorityReqBindingSource.DataMember = "WRCatPriorityReq";
            this.wRCatPriorityReqBindingSource.DataSource = this.bD_BIPlatformDataSet1;
            // 
            // bD_BIPlatformDataSet1
            // 
            this.bD_BIPlatformDataSet1.DataSetName = "BD_BIPlatformDataSet1";
            this.bD_BIPlatformDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wRCatAsocBindingSource
            // 
            this.wRCatAsocBindingSource.DataMember = "WRCatAsoc";
            this.wRCatAsocBindingSource.DataSource = this.bD_BIPlatformDataSet;
            // 
            // bD_BIPlatformDataSet
            // 
            this.bD_BIPlatformDataSet.DataSetName = "BD_DataSetSolicita";
            this.bD_BIPlatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wRCatAsocTableAdapter
            // 
            this.wRCatAsocTableAdapter.ClearBeforeFill = true;
            // 
            // wRCatPriorityReqTableAdapter
            // 
            this.wRCatPriorityReqTableAdapter.ClearBeforeFill = true;
            // 
            // wRCatAsocTableAdapter1
            // 
            this.wRCatAsocTableAdapter1.ClearBeforeFill = true;
            // 
            // errorNameReq
            // 
            this.errorNameReq.ContainerControl = this;
            this.errorNameReq.RightToLeftChanged += new System.EventHandler(this.button1_Click);
            // 
            // errorDescReq
            // 
            this.errorDescReq.ContainerControl = this;
            this.errorDescReq.RightToLeftChanged += new System.EventHandler(this.button1_Click);
            // 
            // errorDReq1
            // 
            this.errorDReq1.ContainerControl = this;
            // 
            // errorDReq2
            // 
            this.errorDReq2.ContainerControl = this;
            // 
            // errorNameSol
            // 
            this.errorNameSol.ContainerControl = this;
            // 
            // errorPriority
            // 
            this.errorPriority.ContainerControl = this;
            // 
            // errorUserAssigned
            // 
            this.errorUserAssigned.ContainerControl = this;
            // 
            // FNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 494);
            this.Controls.Add(this.groupBox1);
            this.Name = "FNewRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Request";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatPriorityReqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BIPlatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDReq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDReq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserAssigned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPInitReq;
        private System.Windows.Forms.ComboBox cmBPriorityReq;
        private System.Windows.Forms.ComboBox cmBSolReq;
        private System.Windows.Forms.TextBox txtBDescReq;
        private System.Windows.Forms.TextBox txtBNameReq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmBUsuAsignedReq;
        private System.Windows.Forms.DateTimePicker dateTPFinalReq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private BD_BIPlatformDataSet bD_BIPlatformDataSet;
        private System.Windows.Forms.BindingSource wRCatAsocBindingSource;
        private BD_BIPlatformDataSetTableAdapters.WRCatAsocTableAdapter wRCatAsocTableAdapter;
        private BD_BIPlatformDataSet1 bD_BIPlatformDataSet1;
        private System.Windows.Forms.BindingSource wRCatPriorityReqBindingSource;
        private BD_BIPlatformDataSet1TableAdapters.WRCatPriorityReqTableAdapter wRCatPriorityReqTableAdapter;
        private BD_BIPlatformDataSet3 bD_BIPlatformDataSet3;
        private System.Windows.Forms.BindingSource wRCatAsocBindingSource1;
        private BD_BIPlatformDataSet3TableAdapters.WRCatAsocTableAdapter wRCatAsocTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorNameReq;
        private System.Windows.Forms.ErrorProvider errorDescReq;
        private System.Windows.Forms.ErrorProvider errorDReq1;
        private System.Windows.Forms.ErrorProvider errorDReq2;
        private System.Windows.Forms.ErrorProvider errorNameSol;
        private System.Windows.Forms.ErrorProvider errorPriority;
        private System.Windows.Forms.ErrorProvider errorUserAssigned;
    }
}