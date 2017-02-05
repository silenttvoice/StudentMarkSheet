namespace StudentMarkSheet
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnAddStudentDetails = new System.Windows.Forms.Button();
            this.textAggregatedMark = new System.Windows.Forms.TextBox();
            this.aggregatedMark = new System.Windows.Forms.Label();
            this.textFinalExam = new System.Windows.Forms.TextBox();
            this.textCourseWork2 = new System.Windows.Forms.TextBox();
            this.textCourseWork1 = new System.Windows.Forms.TextBox();
            this.finalExam = new System.Windows.Forms.Label();
            this.courseWork2 = new System.Windows.Forms.Label();
            this.courseWork1 = new System.Windows.Forms.Label();
            this.textEmailAddress = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textSurName = new System.Windows.Forms.TextBox();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.surName = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSortBySurName = new System.Windows.Forms.Button();
            this.btnSortByAggregatedMark = new System.Windows.Forms.Button();
            this.btnImportFromCsvFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.classAverage = new System.Windows.Forms.Label();
            this.textClassAverage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioLetterView = new System.Windows.Forms.RadioButton();
            this.radioNumericView = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVerify = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(731, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.response);
            this.groupBox1.Controls.Add(this.btnVerify);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.btnAddStudentDetails);
            this.groupBox1.Controls.Add(this.textAggregatedMark);
            this.groupBox1.Controls.Add(this.aggregatedMark);
            this.groupBox1.Controls.Add(this.textFinalExam);
            this.groupBox1.Controls.Add(this.textCourseWork2);
            this.groupBox1.Controls.Add(this.textCourseWork1);
            this.groupBox1.Controls.Add(this.finalExam);
            this.groupBox1.Controls.Add(this.courseWork2);
            this.groupBox1.Controls.Add(this.courseWork1);
            this.groupBox1.Controls.Add(this.textEmailAddress);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.textSurName);
            this.groupBox1.Controls.Add(this.textStudentID);
            this.groupBox1.Controls.Add(this.emailAddress);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.surName);
            this.groupBox1.Controls.Add(this.studentID);
            this.groupBox1.Location = new System.Drawing.Point(15, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Student Details and Marks";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(543, 129);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 35);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // btnAddStudentDetails
            // 
            this.btnAddStudentDetails.Location = new System.Drawing.Point(302, 129);
            this.btnAddStudentDetails.Name = "btnAddStudentDetails";
            this.btnAddStudentDetails.Size = new System.Drawing.Size(195, 37);
            this.btnAddStudentDetails.TabIndex = 15;
            this.btnAddStudentDetails.Text = "Add/Update Student Details And Marks";
            this.btnAddStudentDetails.UseVisualStyleBackColor = true;
            this.btnAddStudentDetails.Click += new System.EventHandler(this.btnAddStudentDetails_Click);
            // 
            // textAggregatedMark
            // 
            this.textAggregatedMark.Location = new System.Drawing.Point(456, 103);
            this.textAggregatedMark.Name = "textAggregatedMark";
            this.textAggregatedMark.ReadOnly = true;
            this.textAggregatedMark.Size = new System.Drawing.Size(100, 20);
            this.textAggregatedMark.TabIndex = 14;
            // 
            // aggregatedMark
            // 
            this.aggregatedMark.AutoSize = true;
            this.aggregatedMark.Location = new System.Drawing.Point(365, 106);
            this.aggregatedMark.Name = "aggregatedMark";
            this.aggregatedMark.Size = new System.Drawing.Size(92, 13);
            this.aggregatedMark.TabIndex = 13;
            this.aggregatedMark.Text = "Aggregated Mark:";
            // 
            // textFinalExam
            // 
            this.textFinalExam.Location = new System.Drawing.Point(456, 78);
            this.textFinalExam.Name = "textFinalExam";
            this.textFinalExam.Size = new System.Drawing.Size(100, 20);
            this.textFinalExam.TabIndex = 12;
            this.textFinalExam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFinalExam_KeyPress);
            this.textFinalExam.Validating += new System.ComponentModel.CancelEventHandler(this.textFinalExam_Validating);
            this.textFinalExam.Validated += new System.EventHandler(this.textFinalExam_Validated);
            // 
            // textCourseWork2
            // 
            this.textCourseWork2.Location = new System.Drawing.Point(456, 51);
            this.textCourseWork2.Name = "textCourseWork2";
            this.textCourseWork2.Size = new System.Drawing.Size(100, 20);
            this.textCourseWork2.TabIndex = 12;
            this.textCourseWork2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCourseWork2_KeyPress);
            this.textCourseWork2.Validating += new System.ComponentModel.CancelEventHandler(this.textCourseWork2_Validating);
            this.textCourseWork2.Validated += new System.EventHandler(this.textCourseWork2_Validated);
            // 
            // textCourseWork1
            // 
            this.textCourseWork1.Location = new System.Drawing.Point(456, 25);
            this.textCourseWork1.Name = "textCourseWork1";
            this.textCourseWork1.Size = new System.Drawing.Size(100, 20);
            this.textCourseWork1.TabIndex = 11;
            this.textCourseWork1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCourseWork1_KeyPress);
            this.textCourseWork1.Validating += new System.ComponentModel.CancelEventHandler(this.textCourseWork1_Validating);
            this.textCourseWork1.Validated += new System.EventHandler(this.textCourseWork1_Validated);
            // 
            // finalExam
            // 
            this.finalExam.AutoSize = true;
            this.finalExam.Location = new System.Drawing.Point(365, 81);
            this.finalExam.Name = "finalExam";
            this.finalExam.Size = new System.Drawing.Size(61, 13);
            this.finalExam.TabIndex = 10;
            this.finalExam.Text = "Final Exam:";
            // 
            // courseWork2
            // 
            this.courseWork2.AutoSize = true;
            this.courseWork2.Location = new System.Drawing.Point(365, 54);
            this.courseWork2.Name = "courseWork2";
            this.courseWork2.Size = new System.Drawing.Size(75, 13);
            this.courseWork2.TabIndex = 9;
            this.courseWork2.Text = "Coursework 2:";
            // 
            // courseWork1
            // 
            this.courseWork1.AutoSize = true;
            this.courseWork1.Location = new System.Drawing.Point(365, 28);
            this.courseWork1.Name = "courseWork1";
            this.courseWork1.Size = new System.Drawing.Size(75, 13);
            this.courseWork1.TabIndex = 8;
            this.courseWork1.Text = "Coursework 1:";
            // 
            // textEmailAddress
            // 
            this.textEmailAddress.Location = new System.Drawing.Point(92, 103);
            this.textEmailAddress.Name = "textEmailAddress";
            this.textEmailAddress.Size = new System.Drawing.Size(191, 20);
            this.textEmailAddress.TabIndex = 7;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(92, 77);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(191, 20);
            this.textFirstName.TabIndex = 6;
            this.textFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFirstName_KeyPress);
            // 
            // textSurName
            // 
            this.textSurName.Location = new System.Drawing.Point(92, 51);
            this.textSurName.Name = "textSurName";
            this.textSurName.Size = new System.Drawing.Size(191, 20);
            this.textSurName.TabIndex = 5;
            this.textSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurName_KeyPress);
            // 
            // textStudentID
            // 
            this.textStudentID.Location = new System.Drawing.Point(92, 25);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(191, 20);
            this.textStudentID.TabIndex = 4;
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Location = new System.Drawing.Point(6, 111);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(76, 13);
            this.emailAddress.TabIndex = 3;
            this.emailAddress.Text = "Email Address:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(6, 85);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(55, 13);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "Firstname:";
            // 
            // surName
            // 
            this.surName.AutoSize = true;
            this.surName.Location = new System.Drawing.Point(6, 58);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(52, 13);
            this.surName.TabIndex = 1;
            this.surName.Text = "Surname:";
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(6, 32);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(61, 13);
            this.studentID.TabIndex = 0;
            this.studentID.Text = "Student ID:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(131, 516);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 4;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnSortBySurName
            // 
            this.btnSortBySurName.Location = new System.Drawing.Point(256, 516);
            this.btnSortBySurName.Name = "btnSortBySurName";
            this.btnSortBySurName.Size = new System.Drawing.Size(121, 23);
            this.btnSortBySurName.TabIndex = 5;
            this.btnSortBySurName.Text = "Sort By Surname";
            this.btnSortBySurName.UseVisualStyleBackColor = true;
            this.btnSortBySurName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSortByAggregatedMark
            // 
            this.btnSortByAggregatedMark.Location = new System.Drawing.Point(414, 516);
            this.btnSortByAggregatedMark.Name = "btnSortByAggregatedMark";
            this.btnSortByAggregatedMark.Size = new System.Drawing.Size(191, 23);
            this.btnSortByAggregatedMark.TabIndex = 6;
            this.btnSortByAggregatedMark.Text = "Sort By Aggregated Mark";
            this.btnSortByAggregatedMark.UseVisualStyleBackColor = true;
            this.btnSortByAggregatedMark.Click += new System.EventHandler(this.btnSortByAggregatedMark_Click);
            // 
            // btnImportFromCsvFile
            // 
            this.btnImportFromCsvFile.Location = new System.Drawing.Point(655, 516);
            this.btnImportFromCsvFile.Name = "btnImportFromCsvFile";
            this.btnImportFromCsvFile.Size = new System.Drawing.Size(138, 23);
            this.btnImportFromCsvFile.TabIndex = 7;
            this.btnImportFromCsvFile.Text = "Import from CSV file";
            this.btnImportFromCsvFile.UseVisualStyleBackColor = true;
            this.btnImportFromCsvFile.Click += new System.EventHandler(this.btnImportFromCsvFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(855, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // classAverage
            // 
            this.classAverage.AutoSize = true;
            this.classAverage.Location = new System.Drawing.Point(670, 357);
            this.classAverage.Name = "classAverage";
            this.classAverage.Size = new System.Drawing.Size(78, 13);
            this.classAverage.TabIndex = 9;
            this.classAverage.Text = "Class Average:";
            // 
            // textClassAverage
            // 
            this.textClassAverage.Location = new System.Drawing.Point(671, 380);
            this.textClassAverage.Name = "textClassAverage";
            this.textClassAverage.ReadOnly = true;
            this.textClassAverage.Size = new System.Drawing.Size(75, 20);
            this.textClassAverage.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "PIE CHART";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(754, 354);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(194, 139);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioLetterView);
            this.groupBox2.Controls.Add(this.radioNumericView);
            this.groupBox2.Location = new System.Drawing.Point(788, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 68);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade View";
            // 
            // radioLetterView
            // 
            this.radioLetterView.AutoSize = true;
            this.radioLetterView.Location = new System.Drawing.Point(13, 45);
            this.radioLetterView.Name = "radioLetterView";
            this.radioLetterView.Size = new System.Drawing.Size(78, 17);
            this.radioLetterView.TabIndex = 1;
            this.radioLetterView.TabStop = true;
            this.radioLetterView.Text = "Letter View";
            this.radioLetterView.UseVisualStyleBackColor = true;
            // 
            // radioNumericView
            // 
            this.radioNumericView.AutoSize = true;
            this.radioNumericView.Location = new System.Drawing.Point(13, 22);
            this.radioNumericView.Name = "radioNumericView";
            this.radioNumericView.Size = new System.Drawing.Size(90, 17);
            this.radioNumericView.TabIndex = 0;
            this.radioNumericView.TabStop = true;
            this.radioNumericView.Text = "Numeric View";
            this.radioNumericView.UseVisualStyleBackColor = true;
            this.radioNumericView.CheckedChanged += new System.EventHandler(this.radioNumericView_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(6, 129);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(89, 134);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(0, 13);
            this.response.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textClassAverage);
            this.Controls.Add(this.classAverage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnImportFromCsvFile);
            this.Controls.Add(this.btnSortByAggregatedMark);
            this.Controls.Add(this.btnSortBySurName);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "StudentMarkSheet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label surName;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.Label emailAddress;
        private System.Windows.Forms.Label finalExam;
        private System.Windows.Forms.Label courseWork2;
        private System.Windows.Forms.Label courseWork1;
        private System.Windows.Forms.TextBox textEmailAddress;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textSurName;
        private System.Windows.Forms.TextBox textAggregatedMark;
        private System.Windows.Forms.Label aggregatedMark;
        private System.Windows.Forms.TextBox textFinalExam;
        private System.Windows.Forms.TextBox textCourseWork2;
        private System.Windows.Forms.TextBox textCourseWork1;
        private System.Windows.Forms.Button btnAddStudentDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSortBySurName;
        private System.Windows.Forms.Button btnSortByAggregatedMark;
        private System.Windows.Forms.Button btnImportFromCsvFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label classAverage;
        private System.Windows.Forms.TextBox textClassAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioLetterView;
        private System.Windows.Forms.RadioButton radioNumericView;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.Button btnVerify;
    }
}

