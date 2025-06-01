namespace FinalC_
{
    partial class VisitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            edtBtn = new Button();
            delBtn = new Button();
            addBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            doctorBox = new ComboBox();
            patientBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtFee = new TextBox();
            label7 = new Label();
            doctorFilterBox = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 6);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 11;
            label3.Text = "Visits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 6);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 10;
            label2.Text = "Doctors";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 9;
            label1.Text = "Patients";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 248);
            dataGridView1.TabIndex = 8;
            // 
            // edtBtn
            // 
            edtBtn.BackColor = Color.Gold;
            edtBtn.FlatAppearance.BorderSize = 0;
            edtBtn.FlatStyle = FlatStyle.Flat;
            edtBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edtBtn.Location = new Point(861, 379);
            edtBtn.Name = "edtBtn";
            edtBtn.Size = new Size(185, 40);
            edtBtn.TabIndex = 14;
            edtBtn.Text = "Edit";
            edtBtn.UseVisualStyleBackColor = false;
            edtBtn.Click += edtBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Crimson;
            delBtn.FlatAppearance.BorderSize = 0;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(666, 379);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(189, 40);
            delBtn.TabIndex = 13;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LimeGreen;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(480, 379);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(180, 40);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 125);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 15;
            label4.Text = "Doctor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 186);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 16;
            label5.Text = "Patient";
            // 
            // doctorBox
            // 
            doctorBox.FormattingEnabled = true;
            doctorBox.Location = new Point(107, 149);
            doctorBox.Name = "doctorBox";
            doctorBox.Size = new Size(234, 23);
            doctorBox.TabIndex = 17;
            // 
            // patientBox
            // 
            patientBox.FormattingEnabled = true;
            patientBox.Location = new Point(107, 210);
            patientBox.Name = "patientBox";
            patientBox.Size = new Size(234, 23);
            patientBox.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 250);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 20;
            label6.Text = "Visit Date";
            // 
            // txtFee
            // 
            txtFee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(107, 340);
            txtFee.Multiline = true;
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(234, 33);
            txtFee.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 316);
            label7.Name = "label7";
            label7.Size = new Size(36, 21);
            label7.TabIndex = 21;
            label7.Text = "Fee";
            // 
            // doctorFilterBox
            // 
            doctorFilterBox.FormattingEnabled = true;
            doctorFilterBox.Location = new Point(480, 96);
            doctorFilterBox.Name = "doctorFilterBox";
            doctorFilterBox.Size = new Size(180, 23);
            doctorFilterBox.TabIndex = 23;
            doctorFilterBox.SelectedIndexChanged += doctorFilterBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(480, 72);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 24;
            label8.Text = "Filter By Doctor";
            // 
            // VisitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 570);
            Controls.Add(label8);
            Controls.Add(doctorFilterBox);
            Controls.Add(txtFee);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(patientBox);
            Controls.Add(doctorBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(edtBtn);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisitForm";
            Text = "VisitForm";
            Load += VisitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button edtBtn;
        private Button delBtn;
        private Button addBtn;
        private Label label4;
        private Label label5;
        private ComboBox doctorBox;
        private ComboBox patientBox;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtFee;
        private Label label7;
        private ComboBox doctorFilterBox;
        private Label label8;
    }
}