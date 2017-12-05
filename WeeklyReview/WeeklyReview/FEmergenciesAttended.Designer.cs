namespace WeeklyReview
{
    partial class FEmergenciesAttended
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPDateFinalUrg = new System.Windows.Forms.DateTimePicker();
            this.DTPDateInital = new System.Windows.Forms.DateTimePicker();
            this.cmBTypeUrg = new System.Windows.Forms.ComboBox();
            this.wRTTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DataSetTypeUrgency = new WeeklyReview.BD_DataSetTypeUrgency();
            this.txtBDescUrg = new System.Windows.Forms.TextBox();
            this.txtBNameUrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wRCatTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorNameUrg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescUrg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTypeUrg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate1Urg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate2Urg = new System.Windows.Forms.ErrorProvider(this.components);
            this.wRTTypeTableAdapter = new WeeklyReview.BD_DataSetTypeUrgencyTableAdapters.WRTTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRTTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetTypeUrgency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1Urg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2Urg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DTPDateFinalUrg);
            this.groupBox1.Controls.Add(this.DTPDateInital);
            this.groupBox1.Controls.Add(this.cmBTypeUrg);
            this.groupBox1.Controls.Add(this.txtBDescUrg);
            this.groupBox1.Controls.Add(this.txtBNameUrg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddEmergenyAttended";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Al:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Del:";
            // 
            // DTPDateFinalUrg
            // 
            this.DTPDateFinalUrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateFinalUrg.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDateFinalUrg.Location = new System.Drawing.Point(38, 281);
            this.DTPDateFinalUrg.Name = "DTPDateFinalUrg";
            this.DTPDateFinalUrg.Size = new System.Drawing.Size(105, 20);
            this.DTPDateFinalUrg.TabIndex = 8;
            // 
            // DTPDateInital
            // 
            this.DTPDateInital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateInital.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDateInital.Location = new System.Drawing.Point(38, 253);
            this.DTPDateInital.Name = "DTPDateInital";
            this.DTPDateInital.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPDateInital.Size = new System.Drawing.Size(105, 20);
            this.DTPDateInital.TabIndex = 7;
            this.DTPDateInital.ValueChanged += new System.EventHandler(this.DTPDateInital_ValueChanged);
            // 
            // cmBTypeUrg
            // 
            this.cmBTypeUrg.DataSource = this.wRTTypeBindingSource;
            this.cmBTypeUrg.DisplayMember = "TTypeDesc";
            this.cmBTypeUrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmBTypeUrg.FormattingEnabled = true;
            this.cmBTypeUrg.Location = new System.Drawing.Point(9, 194);
            this.cmBTypeUrg.Name = "cmBTypeUrg";
            this.cmBTypeUrg.Size = new System.Drawing.Size(153, 21);
            this.cmBTypeUrg.TabIndex = 6;
            this.cmBTypeUrg.ValueMember = "TTypeId";
            // 
            // wRTTypeBindingSource
            // 
            this.wRTTypeBindingSource.DataMember = "WRTType";
            this.wRTTypeBindingSource.DataSource = this.bD_DataSetTypeUrgency;
            // 
            // bD_DataSetTypeUrgency
            // 
            this.bD_DataSetTypeUrgency.DataSetName = "BD_DataSetTypeUrgency";
            this.bD_DataSetTypeUrgency.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBDescUrg
            // 
            this.txtBDescUrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBDescUrg.Location = new System.Drawing.Point(9, 105);
            this.txtBDescUrg.Multiline = true;
            this.txtBDescUrg.Name = "txtBDescUrg";
            this.txtBDescUrg.Size = new System.Drawing.Size(245, 47);
            this.txtBDescUrg.TabIndex = 5;
            // 
            // txtBNameUrg
            // 
            this.txtBNameUrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBNameUrg.Location = new System.Drawing.Point(9, 46);
            this.txtBNameUrg.Name = "txtBNameUrg";
            this.txtBNameUrg.Size = new System.Drawing.Size(245, 20);
            this.txtBNameUrg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo Utilizado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Urgencia:";
            // 
            // wRCatTypeBindingSource
            // 
            this.wRCatTypeBindingSource.DataMember = "WRCatType";
            // 
            // errorNameUrg
            // 
            this.errorNameUrg.ContainerControl = this;
            // 
            // errorDescUrg
            // 
            this.errorDescUrg.ContainerControl = this;
            // 
            // errorTypeUrg
            // 
            this.errorTypeUrg.ContainerControl = this;
            // 
            // errorDate1Urg
            // 
            this.errorDate1Urg.ContainerControl = this;
            // 
            // errorDate2Urg
            // 
            this.errorDate2Urg.ContainerControl = this;
            // 
            // wRTTypeTableAdapter
            // 
            this.wRTTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FEmergenciesAttended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 400);
            this.Controls.Add(this.groupBox1);
            this.Name = "FEmergenciesAttended";
            this.Text = "EmergenciesAttended";
            this.Load += new System.EventHandler(this.FEmergenciesAttended_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRTTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DataSetTypeUrgency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRCatTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1Urg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2Urg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPDateFinalUrg;
        private System.Windows.Forms.DateTimePicker DTPDateInital;
        private System.Windows.Forms.ComboBox cmBTypeUrg;
        private System.Windows.Forms.TextBox txtBDescUrg;
        private System.Windows.Forms.TextBox txtBNameUrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorNameUrg;
        private System.Windows.Forms.ErrorProvider errorDescUrg;
        private System.Windows.Forms.ErrorProvider errorTypeUrg;
        private System.Windows.Forms.ErrorProvider errorDate1Urg;
        private System.Windows.Forms.ErrorProvider errorDate2Urg;
        private System.Windows.Forms.BindingSource wRCatTypeBindingSource;
        private BD_DataSetTypeUrgency bD_DataSetTypeUrgency;
        private System.Windows.Forms.BindingSource wRTTypeBindingSource;
        private BD_DataSetTypeUrgencyTableAdapters.WRTTypeTableAdapter wRTTypeTableAdapter;
        
    }
}