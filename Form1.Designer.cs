namespace FormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>

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
            txt_Search_By_Name = new TextBox();
            label1 = new Label();
            btn_searchByName = new Button();
            FindAllPatients_Btn = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txt_identity = new Label();
            label4 = new Label();
            txt_fname = new TextBox();
            txt_LastName = new TextBox();
            txt_Email = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_Search_By_Name
            // 
            txt_Search_By_Name.Location = new Point(232, 85);
            txt_Search_By_Name.Margin = new Padding(4, 5, 4, 5);
            txt_Search_By_Name.Name = "txt_Search_By_Name";
            txt_Search_By_Name.Size = new Size(285, 27);
            txt_Search_By_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient_Name";
            // 
            // btn_searchByName
            // 
            btn_searchByName.Location = new Point(544, 82);
            btn_searchByName.Margin = new Padding(4, 5, 4, 5);
            btn_searchByName.Name = "btn_searchByName";
            btn_searchByName.Size = new Size(100, 35);
            btn_searchByName.TabIndex = 2;
            btn_searchByName.Text = "Search";
            btn_searchByName.UseVisualStyleBackColor = true;
            btn_searchByName.Click += Find_Patient_Btn_Click;
            // 
            // FindAllPatients_Btn
            // 
            FindAllPatients_Btn.Location = new Point(128, 183);
            FindAllPatients_Btn.Margin = new Padding(4, 5, 4, 5);
            FindAllPatients_Btn.Name = "FindAllPatients_Btn";
            FindAllPatients_Btn.Size = new Size(783, 35);
            FindAllPatients_Btn.TabIndex = 3;
            FindAllPatients_Btn.Text = "List_Patients";
            FindAllPatients_Btn.UseVisualStyleBackColor = true;
            FindAllPatients_Btn.Click += Find_All_Patients_Btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 228);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 338);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 603);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "FirstName";
            // 
            // txt_identity
            // 
            txt_identity.AutoSize = true;
            txt_identity.Location = new Point(125, 714);
            txt_identity.Margin = new Padding(4, 0, 4, 0);
            txt_identity.Name = "txt_identity";
            txt_identity.Size = new Size(46, 20);
            txt_identity.TabIndex = 6;
            txt_identity.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 658);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "LastName";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(273, 598);
            txt_fname.Margin = new Padding(4, 5, 4, 5);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(184, 27);
            txt_fname.TabIndex = 8;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(273, 648);
            txt_LastName.Margin = new Padding(4, 5, 4, 5);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(184, 27);
            txt_LastName.TabIndex = 9;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(273, 709);
            txt_Email.Margin = new Padding(4, 5, 4, 5);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(184, 27);
            txt_Email.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(492, 598);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 11;
            button3.Text = "Add_Patient";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Add_Patient_Btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(652, 82);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Update_Patient_Btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(784, 82);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(127, 35);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete_Patient_Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 769);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txt_Email);
            Controls.Add(txt_LastName);
            Controls.Add(txt_fname);
            Controls.Add(label4);
            Controls.Add(txt_identity);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(FindAllPatients_Btn);
            Controls.Add(btn_searchByName);
            Controls.Add(label1);
            Controls.Add(txt_Search_By_Name);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Search_By_Name;
        private Label label1;
        private Button btn_searchByName;
        private Button FindAllPatients_Btn;
        private DataGridView dataGridView1;
        private Label label2;
        private Label txt_identity;
        private Label label4;
        private TextBox txt_fname;
        private TextBox txt_LastName;
        private TextBox txt_Email;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}
