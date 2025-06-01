namespace FinalC_
{
    partial class MainFormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormP));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addBtn = new Button();
            delBtn = new Button();
            edtBtn = new Button();
            label4 = new Label();
            txtFName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(506, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 321);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Patients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Doctors";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Visits";
            label3.Click += label3_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LimeGreen;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(506, 438);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(180, 40);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Crimson;
            delBtn.FlatAppearance.BorderSize = 0;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(692, 438);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(189, 40);
            delBtn.TabIndex = 8;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // edtBtn
            // 
            edtBtn.BackColor = Color.Gold;
            edtBtn.FlatAppearance.BorderSize = 0;
            edtBtn.FlatStyle = FlatStyle.Flat;
            edtBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edtBtn.Location = new Point(887, 438);
            edtBtn.Name = "edtBtn";
            edtBtn.Size = new Size(185, 40);
            edtBtn.TabIndex = 9;
            edtBtn.Text = "Edit";
            edtBtn.UseVisualStyleBackColor = false;
            edtBtn.Click += edtBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 173);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 10;
            label4.Text = "Full Name";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.Location = new Point(150, 197);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(234, 33);
            txtFName.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 264);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(150, 240);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 13;
            label5.Text = "Birth Date";
            // 
            // MainFormP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(txtFName);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(edtBtn);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainFormP";
            Text = "MainForm";
            Load += MainFormP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addBtn;
        private Button delBtn;
        private Button edtBtn;
        private Label label4;
        private TextBox txtFName;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}