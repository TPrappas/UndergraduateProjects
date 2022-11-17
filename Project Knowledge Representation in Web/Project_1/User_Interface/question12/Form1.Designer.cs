namespace question12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lessonTitleTextBox = new System.Windows.Forms.TextBox();
            this.lessonProfessorTextBox = new System.Windows.Forms.TextBox();
            this.lessonTimeTextBox = new System.Windows.Forms.TextBox();
            this.lessonClassroomTextBox = new System.Windows.Forms.TextBox();
            this.lessonAdd = new System.Windows.Forms.Button();
            this.lessonRead = new System.Windows.Forms.Button();
            this.lessonDataGrid = new System.Windows.Forms.DataGridView();
            this.lessonDayComboBox = new System.Windows.Forms.ComboBox();
            this.lessonSelectDayComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Classroom";
            // 
            // lessonTitleTextBox
            // 
            this.lessonTitleTextBox.Location = new System.Drawing.Point(180, 58);
            this.lessonTitleTextBox.Name = "lessonTitleTextBox";
            this.lessonTitleTextBox.Size = new System.Drawing.Size(162, 23);
            this.lessonTitleTextBox.TabIndex = 5;
            // 
            // lessonProfessorTextBox
            // 
            this.lessonProfessorTextBox.Location = new System.Drawing.Point(180, 89);
            this.lessonProfessorTextBox.Name = "lessonProfessorTextBox";
            this.lessonProfessorTextBox.Size = new System.Drawing.Size(162, 23);
            this.lessonProfessorTextBox.TabIndex = 6;
            // 
            // lessonTimeTextBox
            // 
            this.lessonTimeTextBox.Location = new System.Drawing.Point(180, 149);
            this.lessonTimeTextBox.Name = "lessonTimeTextBox";
            this.lessonTimeTextBox.Size = new System.Drawing.Size(162, 23);
            this.lessonTimeTextBox.TabIndex = 8;
            // 
            // lessonClassroomTextBox
            // 
            this.lessonClassroomTextBox.Location = new System.Drawing.Point(180, 179);
            this.lessonClassroomTextBox.Name = "lessonClassroomTextBox";
            this.lessonClassroomTextBox.Size = new System.Drawing.Size(162, 23);
            this.lessonClassroomTextBox.TabIndex = 9;
            // 
            // lessonAdd
            // 
            this.lessonAdd.Location = new System.Drawing.Point(425, 118);
            this.lessonAdd.Name = "lessonAdd";
            this.lessonAdd.Size = new System.Drawing.Size(75, 23);
            this.lessonAdd.TabIndex = 10;
            this.lessonAdd.Text = "Add";
            this.lessonAdd.UseVisualStyleBackColor = true;
            this.lessonAdd.Click += new System.EventHandler(this.lessonAdd_Click);
            // 
            // lessonRead
            // 
            this.lessonRead.Location = new System.Drawing.Point(677, 415);
            this.lessonRead.Name = "lessonRead";
            this.lessonRead.Size = new System.Drawing.Size(75, 23);
            this.lessonRead.TabIndex = 11;
            this.lessonRead.Text = "Read";
            this.lessonRead.UseVisualStyleBackColor = true;
            this.lessonRead.Click += new System.EventHandler(this.lessonRead_Click);
            // 
            // lessonDataGrid
            // 
            this.lessonDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lessonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonDataGrid.Location = new System.Drawing.Point(56, 248);
            this.lessonDataGrid.Name = "lessonDataGrid";
            this.lessonDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.lessonDataGrid.RowTemplate.Height = 25;
            this.lessonDataGrid.Size = new System.Drawing.Size(696, 150);
            this.lessonDataGrid.TabIndex = 12;
            // 
            // lessonDayComboBox
            // 
            this.lessonDayComboBox.FormattingEnabled = true;
            this.lessonDayComboBox.Location = new System.Drawing.Point(631, 219);
            this.lessonDayComboBox.Name = "lessonDayComboBox";
            this.lessonDayComboBox.Size = new System.Drawing.Size(121, 23);
            this.lessonDayComboBox.TabIndex = 13;
            // 
            // lessonSelectDayComboBox
            // 
            this.lessonSelectDayComboBox.FormattingEnabled = true;
            this.lessonSelectDayComboBox.Location = new System.Drawing.Point(180, 121);
            this.lessonSelectDayComboBox.Name = "lessonSelectDayComboBox";
            this.lessonSelectDayComboBox.Size = new System.Drawing.Size(162, 23);
            this.lessonSelectDayComboBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lessonSelectDayComboBox);
            this.Controls.Add(this.lessonDayComboBox);
            this.Controls.Add(this.lessonDataGrid);
            this.Controls.Add(this.lessonRead);
            this.Controls.Add(this.lessonAdd);
            this.Controls.Add(this.lessonClassroomTextBox);
            this.Controls.Add(this.lessonTimeTextBox);
            this.Controls.Add(this.lessonProfessorTextBox);
            this.Controls.Add(this.lessonTitleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox lessonTitleTextBox;
        private TextBox lessonProfessorTextBox;
        private TextBox lessonTimeTextBox;
        private TextBox lessonClassroomTextBox;
        private Button lessonAdd;
        private Button lessonRead;
        private DataGridView lessonDataGrid;
        private ComboBox lessonDayComboBox;
        private ComboBox lessonSelectDayComboBox;
    }
}