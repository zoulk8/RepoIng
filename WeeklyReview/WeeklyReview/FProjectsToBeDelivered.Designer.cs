namespace WeeklyReview
{
    partial class FProjectsToBeDelivered
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
            this.DTPDateFinalProj = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBNameProj = new System.Windows.Forms.TextBox();
            this.txtBDescProj = new System.Windows.Forms.TextBox();
            this.DTPDateInitProj = new System.Windows.Forms.DateTimePicker();
            this.txtBCommentsProj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorNameProj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescProj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate1Proj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate2Proj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCommentsProj = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1Proj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2Proj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCommentsProj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DTPDateFinalProj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBNameProj);
            this.groupBox1.Controls.Add(this.txtBDescProj);
            this.groupBox1.Controls.Add(this.DTPDateInitProj);
            this.groupBox1.Controls.Add(this.txtBCommentsProj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Project To Be Delivered";
            // 
            // DTPDateFinalProj
            // 
            this.DTPDateFinalProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateFinalProj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDateFinalProj.Location = new System.Drawing.Point(66, 240);
            this.DTPDateFinalProj.Name = "DTPDateFinalProj";
            this.DTPDateFinalProj.Size = new System.Drawing.Size(103, 20);
            this.DTPDateFinalProj.TabIndex = 11;
            this.DTPDateFinalProj.Value = new System.DateTime(2017, 11, 23, 15, 15, 12, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Al:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Del:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBNameProj
            // 
            this.txtBNameProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNameProj.Location = new System.Drawing.Point(6, 32);
            this.txtBNameProj.Name = "txtBNameProj";
            this.txtBNameProj.Size = new System.Drawing.Size(277, 20);
            this.txtBNameProj.TabIndex = 7;
            // 
            // txtBDescProj
            // 
            this.txtBDescProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDescProj.Location = new System.Drawing.Point(9, 93);
            this.txtBDescProj.Multiline = true;
            this.txtBDescProj.Name = "txtBDescProj";
            this.txtBDescProj.Size = new System.Drawing.Size(274, 78);
            this.txtBDescProj.TabIndex = 6;
            // 
            // DTPDateInitProj
            // 
            this.DTPDateInitProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateInitProj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDateInitProj.Location = new System.Drawing.Point(66, 211);
            this.DTPDateInitProj.Name = "DTPDateInitProj";
            this.DTPDateInitProj.Size = new System.Drawing.Size(103, 20);
            this.DTPDateInitProj.TabIndex = 5;
            this.DTPDateInitProj.Value = new System.DateTime(2017, 11, 23, 15, 15, 12, 0);
            this.DTPDateInitProj.ValueChanged += new System.EventHandler(this.DTPDateInitProj_ValueChanged);
            // 
            // txtBCommentsProj
            // 
            this.txtBCommentsProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCommentsProj.Location = new System.Drawing.Point(6, 311);
            this.txtBCommentsProj.Multiline = true;
            this.txtBCommentsProj.Name = "txtBCommentsProj";
            this.txtBCommentsProj.Size = new System.Drawing.Size(277, 84);
            this.txtBCommentsProj.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observaciones: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Planeada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 77);
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
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Proyecto:";
            // 
            // errorNameProj
            // 
            this.errorNameProj.ContainerControl = this;
            // 
            // errorDescProj
            // 
            this.errorDescProj.ContainerControl = this;
            // 
            // errorDate1Proj
            // 
            this.errorDate1Proj.ContainerControl = this;
            // 
            // errorDate2Proj
            // 
            this.errorDate2Proj.ContainerControl = this;
            // 
            // errorCommentsProj
            // 
            this.errorCommentsProj.ContainerControl = this;
            // 
            // FProjectsToBeDelivered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "FProjectsToBeDelivered";
            this.Text = "ProjectsToBeDelivered";
            this.Load += new System.EventHandler(this.FProjectsToBeDelivered_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate1Proj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate2Proj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCommentsProj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBNameProj;
        private System.Windows.Forms.TextBox txtBDescProj;
        private System.Windows.Forms.DateTimePicker DTPDateInitProj;
        private System.Windows.Forms.TextBox txtBCommentsProj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPDateFinalProj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorNameProj;
        private System.Windows.Forms.ErrorProvider errorDescProj;
        private System.Windows.Forms.ErrorProvider errorDate1Proj;
        private System.Windows.Forms.ErrorProvider errorDate2Proj;
        private System.Windows.Forms.ErrorProvider errorCommentsProj;
    }
}