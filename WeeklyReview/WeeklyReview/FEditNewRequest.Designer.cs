namespace WeeklyReview
{
    partial class FEditNewRequest
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
            this.cmBStatusReq = new System.Windows.Forms.ComboBox();
            this.wRCatStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DataSetEditStatusReq = new WeeklyReview.BD_DataSetEditStatusReq();
            this.cmBPriorityReq = new System.Windows.Forms.ComboBox();
            this.wRCatPriorityReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DataSetEditPriorityReq = new WeeklyReview.BD_DataSetEditPriorityReq();
            this.TPFinalDate = new System.Windows.Forms.DateTimePicker();
            this.TPdateInitial = new System.Windows.Forms.DateTimePicker();
            this.cmBSolReq = new System.Windows.Forms.ComboBox();
            this.wRCatAsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DataSetNameAsoc = new WeeklyReview.BD_DataSetNameAsoc();
            this.txtBDescReq = new System.Windows.Forms.TextBox();
            this.cmBNameReq = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wRCatAsocTableAdapter = new WeeklyReview.BD_DataSetNameAsocTableAdapters.WRCatAsocTableAdapter();
            this.wRCatPriorityReqTableAdapter = new WeeklyReview.BD_DataSetEditPriorityReqTableAdapters.WRCatPriorityReqTableAdapter();
            this.wRCatStatusTableAdapter = new WeeklyReview.BD_DataSetEditStatusReqTableAdapters.WRCatStatusTableAdapter();
            this.errorNameReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSolReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPriorityReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatusReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetEditStatusReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatPriorityReqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetEditPriorityReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetNameAsoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPriorityReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatusReq)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmBStatusReq);
            this.groupBox1.Controls.Add(this.cmBPriorityReq);
            this.groupBox1.Controls.Add(this.TPFinalDate);
            this.groupBox1.Controls.Add(this.TPdateInitial);
            this.groupBox1.Controls.Add(this.cmBSolReq);
            this.groupBox1.Controls.Add(this.txtBDescReq);
            this.groupBox1.Controls.Add(this.cmBNameReq);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
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
            this.groupBox1.Size = new System.Drawing.Size(339, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit New Request";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Acept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmBStatusReq
            // 
            this.cmBStatusReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBStatusReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmBStatusReq.FormattingEnabled = true;
            this.cmBStatusReq.Location = new System.Drawing.Point(10, 349);
            this.cmBStatusReq.Name = "cmBStatusReq";
            this.cmBStatusReq.Size = new System.Drawing.Size(260, 21);
            this.cmBStatusReq.TabIndex = 14;
            // 
            // wRCatStatusBindingSource
            // 
            this.wRCatStatusBindingSource.DataMember = "WRCatStatus";
            this.wRCatStatusBindingSource.DataSource = this.bD_DataSetEditStatusReq;
            // 
            // bD_DataSetEditStatusReq
            // 
            this.bD_DataSetEditStatusReq.DataSetName = "BD_DataSetEditStatusReq";
            this.bD_DataSetEditStatusReq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmBPriorityReq
            // 
            this.cmBPriorityReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBPriorityReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmBPriorityReq.FormattingEnabled = true;
            this.cmBPriorityReq.Location = new System.Drawing.Point(10, 298);
            this.cmBPriorityReq.Name = "cmBPriorityReq";
            this.cmBPriorityReq.Size = new System.Drawing.Size(260, 21);
            this.cmBPriorityReq.TabIndex = 13;
            // 
            // wRCatPriorityReqBindingSource
            // 
            this.wRCatPriorityReqBindingSource.DataMember = "WRCatPriorityReq";
            this.wRCatPriorityReqBindingSource.DataSource = this.bD_DataSetEditPriorityReq;
            // 
            // bD_DataSetEditPriorityReq
            // 
            this.bD_DataSetEditPriorityReq.DataSetName = "BD_DataSetEditPriorityReq";
            this.bD_DataSetEditPriorityReq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TPFinalDate
            // 
            this.TPFinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TPFinalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TPFinalDate.Location = new System.Drawing.Point(45, 249);
            this.TPFinalDate.Name = "TPFinalDate";
            this.TPFinalDate.Size = new System.Drawing.Size(106, 20);
            this.TPFinalDate.TabIndex = 12;
            // 
            // TPdateInitial
            // 
            this.TPdateInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TPdateInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TPdateInitial.Location = new System.Drawing.Point(45, 223);
            this.TPdateInitial.Name = "TPdateInitial";
            this.TPdateInitial.Size = new System.Drawing.Size(106, 20);
            this.TPdateInitial.TabIndex = 11;
            this.TPdateInitial.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmBSolReq
            // 
            this.cmBSolReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBSolReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmBSolReq.FormattingEnabled = true;
            this.cmBSolReq.Location = new System.Drawing.Point(11, 160);
            this.cmBSolReq.Name = "cmBSolReq";
            this.cmBSolReq.Size = new System.Drawing.Size(260, 21);
            this.cmBSolReq.TabIndex = 10;
            // 
            // wRCatAsocBindingSource
            // 
            this.wRCatAsocBindingSource.DataMember = "WRCatAsoc";
            this.wRCatAsocBindingSource.DataSource = this.bD_DataSetNameAsoc;
            // 
            // bD_DataSetNameAsoc
            // 
            this.bD_DataSetNameAsoc.DataSetName = "BD_DataSetNameAsoc";
            this.bD_DataSetNameAsoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBDescReq
            // 
            this.txtBDescReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBDescReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBDescReq.Location = new System.Drawing.Point(12, 73);
            this.txtBDescReq.Multiline = true;
            this.txtBDescReq.Name = "txtBDescReq";
            this.txtBDescReq.Size = new System.Drawing.Size(308, 59);
            this.txtBDescReq.TabIndex = 9;
            // 
            // cmBNameReq
            // 
            this.cmBNameReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBNameReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmBNameReq.FormattingEnabled = true;
            this.cmBNameReq.Location = new System.Drawing.Point(60, 19);
            this.cmBNameReq.Name = "cmBNameReq";
            this.cmBNameReq.Size = new System.Drawing.Size(260, 21);
            this.cmBNameReq.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(7, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estatus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prioridad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Al:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Del:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo Estimado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solicita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // wRCatAsocTableAdapter
            // 
            this.wRCatAsocTableAdapter.ClearBeforeFill = true;
            // 
            // wRCatPriorityReqTableAdapter
            // 
            this.wRCatPriorityReqTableAdapter.ClearBeforeFill = true;
            // 
            // wRCatStatusTableAdapter
            // 
            this.wRCatStatusTableAdapter.ClearBeforeFill = true;
            // 
            // errorNameReq
            // 
            this.errorNameReq.ContainerControl = this;
            // 
            // errorDescReq
            // 
            this.errorDescReq.ContainerControl = this;
            // 
            // errorSolReq
            // 
            this.errorSolReq.ContainerControl = this;
            // 
            // errorDate1
            // 
            this.errorDate1.ContainerControl = this;
            // 
            // errorDate2
            // 
            this.errorDate2.ContainerControl = this;
            // 
            // errorPriorityReq
            // 
            this.errorPriorityReq.ContainerControl = this;
            // 
            // errorStatusReq
            // 
            this.errorStatusReq.ContainerControl = this;
            // 
            // FEditNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 452);
            this.Controls.Add(this.groupBox1);
            this.Name = "FEditNewRequest";
            this.Text = "FEditNewRequest";
            this.Load += new System.EventHandler(this.FEditNewRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetEditStatusReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatPriorityReqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetEditPriorityReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatAsocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetNameAsoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPriorityReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatusReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmBStatusReq;
        private System.Windows.Forms.ComboBox cmBPriorityReq;
        private System.Windows.Forms.DateTimePicker TPFinalDate;
        private System.Windows.Forms.DateTimePicker TPdateInitial;
        private System.Windows.Forms.ComboBox cmBSolReq;
        private System.Windows.Forms.TextBox txtBDescReq;
        private System.Windows.Forms.ComboBox cmBNameReq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BD_DataSetNameAsoc bD_DataSetNameAsoc;
        private System.Windows.Forms.BindingSource wRCatAsocBindingSource;
        private BD_DataSetNameAsocTableAdapters.WRCatAsocTableAdapter wRCatAsocTableAdapter;
        private BD_DataSetEditPriorityReq bD_DataSetEditPriorityReq;
        private System.Windows.Forms.BindingSource wRCatPriorityReqBindingSource;
        private BD_DataSetEditPriorityReqTableAdapters.WRCatPriorityReqTableAdapter wRCatPriorityReqTableAdapter;
        private BD_DataSetEditStatusReq bD_DataSetEditStatusReq;
        private System.Windows.Forms.BindingSource wRCatStatusBindingSource;
        private BD_DataSetEditStatusReqTableAdapters.WRCatStatusTableAdapter wRCatStatusTableAdapter;
        private System.Windows.Forms.ErrorProvider errorNameReq;
        private System.Windows.Forms.ErrorProvider errorDescReq;
        private System.Windows.Forms.ErrorProvider errorSolReq;
        private System.Windows.Forms.ErrorProvider errorDate1;
        private System.Windows.Forms.ErrorProvider errorDate2;
        private System.Windows.Forms.ErrorProvider errorPriorityReq;
        private System.Windows.Forms.ErrorProvider errorStatusReq;
    }
}