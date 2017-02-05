using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentMarkSheet
{
    public partial class Form1 : Form
    {
        // This ArrayList is to store all the student objects
        ArrayList StudentList = new ArrayList();

        // Method
        public Form1()
        {
            this.InitializeComponent();
        }

        // Method for sorting by student's surname
        private void button1_Click(object sender, EventArgs e)
        {
            this.StudentList.Sort();
            this.radioNumericView.Select();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.StudentList;
        }

        // Method to add new student to the dataGridView
        private void btnAddStudentDetails_Click(object sender, EventArgs e)
        {
            // Check the new student ID - must be unique
            foreach (object obj2 in this.StudentList)
            {
                string str = ((Student)obj2).StudentID.ToUpper();

                // If found an existing student with the same ID
                if (str.CompareTo(this.textStudentID.Text.ToUpper()) == 0)
                {
                    string text = "Student with ID " + str + " already exists!\n Do you really want to update this student's record with new details?";
                    string caption = "Student already exists!";
                    MessageBoxButtons yesNo = MessageBoxButtons.YesNo;

                    if (MessageBox.Show(text, caption, yesNo) == DialogResult.Yes)
                    {
                        // Update the student record
                        ((Student)obj2).SurName = this.textSurName.Text;
                        ((Student)obj2).FirstName = this.textFirstName.Text;
                        ((Student)obj2).EmailAddress = this.emailAddress.Text;
                        ((Student)obj2).CourseWork1 = Convert.ToDouble(this.textCourseWork1.Text);
                        ((Student)obj2).CourseWork2 = Convert.ToDouble(this.textCourseWork2.Text);
                        ((Student)obj2).FinalExam = Convert.ToDouble(this.textFinalExam.Text);
                        this.textAggregatedMark.Text = ((Student)obj2).CourseMark().ToString();

                        MessageBox.Show(((Student)obj2).SurName + "record has been updated with new details, excepth the ID");

                        // Refresh the display
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = this.StudentList;
                        this.textClassAverage.Text = this.CalClassAverageMark();
                        this.DisplayBarChart();
                    }
                    return;
                }
            }

            // The value of the entered student ID in the textbox is new
            // Create a new student object
            Student student = new Student(this.textStudentID.Text)
            {
                SurName = this.textSurName.Text,
                FirstName = this.textFirstName.Text,
                EmailAddress = this.textEmailAddress.Text,
                CourseWork1 = Convert.ToDouble(this.textCourseWork1.Text),
                CourseWork2 = Convert.ToDouble(this.textCourseWork2.Text),
                FinalExam = Convert.ToDouble(this.textFinalExam.Text)
            };

            this.textAggregatedMark.Text = student.CourseMark().ToString();
            this.StudentList.Add(student);

            MessageBox.Show(student.SurName + " has been added to the student list");

            // Refresh the display
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.StudentList;
            this.textClassAverage.Text = this.CalClassAverageMark();
            this.DisplayBarChart();
        }

        // Method to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method to save the information
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create the file 
            Stream serializationStream = File.Open("studentDetails.dat", FileMode.Create);
            new BinaryFormatter().Serialize(serializationStream, this.StudentList);
            serializationStream.Close();
            MessageBox.Show("Students and Marks Data saved to file");
        }

        // Calculating the class average from the details entered so far
        private string CalClassAverageMark()
        {
            double num2 = 0.0;
            foreach (Student student in this.StudentList)
            {
                num2 += student.CourseMark();
            }
            return Math.Round((double)(num2 / ((double)this.StudentList.Count)), 2).ToString();
        }

        // Sorting by aggregated mark
        private void btnSortByAggregatedMark_Click(object sender, EventArgs e)
        {
            this.StudentList.Sort(Student.sortByCourseMark());

            // Refresh the display
            this.radioNumericView.Select();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.StudentList;
        }

        // Retrieve from file
        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the file from written above and read the values from it
                Stream serializationStream = File.Open("studentDetails.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                // Reading the student information
                this.StudentList = (ArrayList)formatter.Deserialize(serializationStream);
                serializationStream.Close();

                // Refresh the view
                this.radioNumericView.Select();
                this.dataGridView1.Columns.Clear();
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.StudentList;
                this.textClassAverage.Text = this.CalClassAverageMark();
                this.DisplayBarChart();
                MessageBox.Show("Student details and marks data retrieved from file");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR reading file!");
            }
        }

        // Method for displaying the chart in pie chart form
        private void DisplayBarChart()
        {
            int num;
            int[] source = new int[6];
            for (num = 0; num < this.StudentList.Count; num++)
            {
                string str4 = this.LetterGrade(((Student)this.StudentList[num]).CourseMark());
                if (str4 != null)
                {
                    if (!(str4 == "A"))
                    {
                        if (str4 == "B")
                        {
                            goto Label_001;
                        }
                        if (str4 == "C")
                        {
                            goto Label_002;
                        }
                        if (str4 == "D")
                        {
                            goto Label_003;
                        }
                        if (str4 == "E")
                        {
                            goto Label_004;
                        }
                        if (str4 == "F")
                        {
                            goto Label_005;
                        }
                    }
                    else
                    {
                        source[0]++;
                    }
                }
                continue;
            Label_001:
                source[1]++;
                continue;
            Label_002:
                source[2]++;
                continue;
            Label_003:
                source[3]++;
                continue;
            Label_004:
                source[4]++;
                continue;
            Label_005:
                source[5]++;
            }

            // Setting the properties for a pie chart
            this.chart1.Series.Clear();
            this.chart1.Palette = ChartColorPalette.Bright;
            this.chart1.BackColor = Color.White;
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Student's Grades");
            this.chart1.ChartAreas[0].BackColor = Color.Transparent;
            Series item = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = Color.Blue,
                ChartType = SeriesChartType.Pie
            };
            this.chart1.Series.Add(item);
            for (num = 0; num < source.Count<int>(); num++)
            {
                item.Points.Add(new double[] { (double)source[num] });
                DataPoint point = item.Points[num];
                point.AxisLabel = source[num].ToString();
                string str3 = "";
                switch (num)
                {
                    case 0:
                        str3 = "A";
                        break;

                    case 1:
                        str3 = "B";
                        break;

                    case 2:
                        str3 = "C";
                        break;

                    case 3:
                        str3 = "D";
                        break;

                    case 4:
                        str3 = "E";
                        break;

                    case 5:
                        str3 = "F";
                        break;
                }
                point.LegendText = str3;
                this.chart1.Series[0].Points[num].ToolTip = str3;
                this.chart1.Series[0].LegendToolTip = "#VAL students achieved #LEGENDTEXT";
            }
            this.chart1.Invalidate();
        }

        // Method for the grade for the range of marks that can be achieved
        private string LetterGrade(double grade)
        {
            if (grade < 40.0)
            {
                return "F";
            }
            if (grade < 43.0)
            {
                return "E";
            }
            if (grade < 50.0)
            {
                return "D";
            }
            if (grade < 60.0)
            {
                return "C";
            }
            if (grade < 70.0)
            {
                return "B";
            }
            return "A";
        }

        // Importing the CSV file from the system
        private void btnImportFromCsvFile_Click(object sender, EventArgs e)
        {
            string text = "Do you want to replace the current data?";
            string caption = "Import from CSV file";
            MessageBoxButtons yesNo = MessageBoxButtons.YesNo;
            if (MessageBox.Show(text, caption, yesNo) == DialogResult.Yes)
            {
                this.StudentList.Clear();
                string path = "Students.csv";
                string str4 = "";
                using (StreamReader reader = new StreamReader(File.OpenRead(path)))
                {
                    str4 = reader.ReadToEnd();
                }
                string[] strArray = str4.Replace("\r", "").Split(new char[] { '\n' });
                foreach (string str5 in strArray)
                {
                    if(!string.IsNullOrEmpty(str5))
                    {
                        string[] strArray2 = str5.Split(new char[] { ',' });
                        Student student = new Student("")
                        {
                            StudentID = strArray2[0],
                            SurName = strArray2[1],
                            FirstName = strArray2[2],
                            EmailAddress = strArray2[3],
                            CourseWork1 = Convert.ToDouble(strArray2[4]),
                            CourseWork2 = Convert.ToDouble(strArray2[5]),
                            FinalExam = Convert.ToDouble(strArray2[6])
                        };
                        this.StudentList.Add(student);
                    }
                }
                // Refresh the views
                this.radioNumericView.Select();
                this.dataGridView1.Columns.Clear();
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.StudentList;
                this.textClassAverage.Text = this.CalClassAverageMark();
                this.DisplayBarChart();
                this.textStudentID.Text = "";
                this.textSurName.Text = "";
                this.textFirstName.Text = "";
                this.textCourseWork1.Text = "";
                this.textCourseWork2.Text = "";
                this.textFinalExam.Text = "";
            }
        }

        // Method for the radiobuttons to see the garde in numeric of letter view
        private void radioNumericView_CheckedChanged(object sender, EventArgs e)
        {
            // If letter radio button is checked
            if (this.radioLetterView.Checked)
            {
                MessageBox.Show("Show Letter Grade"); // Show the message
                this.dataGridView1.DataSource = null; // Refresh the view

                // Adding the names for each columns
                this.dataGridView1.Columns.Add("studentID", "StudentID");
                this.dataGridView1.Columns.Add("surName", "SurName");
                this.dataGridView1.Columns.Add("firstName", "FirstName");
                this.dataGridView1.Columns.Add("emailAddress", "EmailAddress");
                this.dataGridView1.Columns.Add("courseWork1", "CourseWork1");
                this.dataGridView1.Columns.Add("courseWork2", "CourseWork2");
                this.dataGridView1.Columns.Add("finalExam", "FinalExam");

                for(int i = 0; i < this.StudentList.Count; i++)
                {
                    // Adding the values to each rows considering the lettergrade for cw1, cw2 and final exam showing in letter
                    this.dataGridView1.Rows.Add(new object[] 
                    { ((Student)this.StudentList[i]).StudentID, 
                        ((Student)this.StudentList[i]).SurName, 
                        ((Student)this.StudentList[i]).FirstName,
                        ((Student)this.StudentList[i]).EmailAddress, 
                        this.LetterGrade(((Student)this.StudentList[i]).CourseWork1), 
                        this.LetterGrade(((Student)this.StudentList[i]).CourseWork2), 
                        this.LetterGrade(((Student)this.StudentList[i]).FinalExam) });
                }
                this.dataGridView1.Refresh();
            }
            // If the numeric radio button is checked
            if(this.radioNumericView.Checked)
            {
                MessageBox.Show("Show Numeric Grade"); // Show the message

                // Refresh the view in numbers 
                this.dataGridView1.Columns.Clear();
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.StudentList;
                this.textClassAverage.Text = this.CalClassAverageMark();
            }
        }

        // Method for clearing out the all the textboxes
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textStudentID.Text = "";
            this.textSurName.Text = "";
            this.textFirstName.Text = "";
            this.textEmailAddress.Text = "";
            this.textCourseWork1.Text = "";
            this.textCourseWork2.Text = "";
            this.textFinalExam.Text = "";
            this.textAggregatedMark.Text = "";
            this.textClassAverage.Text = "";
        }

        // VALIDATIONS
        // Validation for coursework 1 field
        private void textCourseWork1_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textCourseWork1, "");
        }

        private void textCourseWork1_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textCourseWork1.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textCourseWork1.Select(0, this.textCourseWork1.Text.Length);
                string str = "Please enter a number between 0 and 100";
                this.errorProvider1.SetError(this.textCourseWork1, str);
            }
        }

        // Validation for coursework 2 field
        private void textCourseWork2_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textCourseWork2, "");
        }

        private void textCourseWork2_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textCourseWork2.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textCourseWork2.Select(0, this.textCourseWork2.Text.Length);
                string str = "Please enter a number between 0 and 100";
                this.errorProvider1.SetError(this.textCourseWork2, str);
            }
        }

        // Validation for final exam field
        private void textFinalExam_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textFinalExam, "");
        }

        private void textFinalExam_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textFinalExam.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textFinalExam.Select(0, this.textFinalExam.Text.Length); 
                string str = "Please enter a number between 0 and 100"; // Display message
                this.errorProvider1.SetError(this.textFinalExam, str); 
            }
        }

        // Validation for surname textbox using keypress
        private void textSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar==8 || e.KeyChar==32) // Lets the user use letter, backspace and the space key
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Validation for firstname textbox using keypress
        private void textFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar==32) // Lets the user use letter, backspace and the space key
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Validation for textbox of coursework 1 using keypress
        private void textCourseWork1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8) // Lets the user use number and backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Validation for textbox of coursework 2 using keypress
        private void textCourseWork2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8) // Lets the user use number and backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Validation for textbox of final exam using keypress
        private void textFinalExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8) // Lets the user use number and backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Validation button for verifying email address
        private void btnVerify_Click(object sender, EventArgs e)
        {
            string email = textEmailAddress.Text;
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1) // "@" and "." not included
            {
                this.response.Text = "Invalid Email";
            }
            else
            {
                this.response.Text = "Valid Email Address";
            }
        }
    }
}
