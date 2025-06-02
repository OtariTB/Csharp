namespace FinalC_
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            pageLabel = new Label();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Visits";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Doctors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Patients";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(777, 286);
            dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(453, 62);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 8;
            label4.Text = "Available Doctors";
            // 
            // pageLabel
            // 
            pageLabel.AutoSize = true;
            pageLabel.Location = new Point(526, 419);
            pageLabel.Name = "pageLabel";
            pageLabel.Size = new Size(13, 15);
            pageLabel.TabIndex = 9;
            pageLabel.Text = "1";
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(495, 415);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(25, 23);
            btnPrevPage.TabIndex = 10;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(545, 415);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(25, 23);
            btnNextPage.TabIndex = 11;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 568);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(pageLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label pageLabel;
        private Button btnPrevPage;
        private Button btnNextPage;
    }
}