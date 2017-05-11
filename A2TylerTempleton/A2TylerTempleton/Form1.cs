using A2TylerTempleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2TylerTempleton
{// Assignment 2 made by Tyler Templeton 
    public partial class WageForm : Form
    {//initialize employee object list
        List<Employee> employee = new List<Employee>();

        public WageForm()
        {
            
            InitializeComponent();
            
        }

        private void WageForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//on close button click bring up popup to confirm closure
            comfirmationPopup popup = new comfirmationPopup();
            DialogResult dialog = popup.ShowDialog();
            if (popup.close == 1)
            {
                Close();
            }
            else { };

        }

        private void button1_Click(object sender, EventArgs e)
        {//checks form for it being filled and valid
            if (IsFilled(nameBox.Text))
            {
                if (IsFilled(wageBox.Text))
                {
                    if (IsFilled(hoursBox.Text))

                        if (intCheck())
                        {
                            Calculate();
                            InsertEmployee();
                            DropListBox();
                        }
                        else
                        {
                            Clear();
                        }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {// clears off form data
            Clear();
        }
        private void Calculate()
        {//calcuations  for empolyees and managers

            Double hours, rate, netGross, fwt, net, overtime, manager;
            hours = Convert.ToDouble(hoursBox.Text);
            rate = Convert.ToDouble(wageBox.Text);
            overtime = 1;
            manager = 1;
            //manager checking
            if (managerBox.Checked)
            {
                manager = 1.2;
            }
            if (hours > 40)
            {
                overtime = (hours - 40) * (rate * 1.5);
                if (managerBox.Checked)
                {
                    overtime = 1;
                }
            }

            netGross = hours * rate * manager + overtime;
            fwt = netGross * 0.15;
            net = netGross - fwt;
            earningsBox.Text = Convert.ToString(netGross);
            fwtBox.Text = Convert.ToString(fwt);
            netBox.Text = Convert.ToString(net);

        }

        private Boolean intCheck()
        {// check string value of forms to doubles to see if they are numbers
            String hours = hoursBox.Text, wageRate = wageBox.Text;
            Double hoursWorked, rate;
            bool parsed = Double.TryParse(hours, out hoursWorked);
            bool parsed2 = Double.TryParse(wageRate, out rate);
            if (!parsed || !parsed2)
            {// popup when it is not a number
                errorPopup error = new errorPopup();
                DialogResult dialog = error.ShowDialog();
                error.Dispose();
                return false;
            }
            return true;
        }
        public void Clear()
        {// clear off form data
            hoursBox.Text = null;
            wageBox.Text = null;
            nameBox.Text = null;
            earningsBox.Text = null;
            fwtBox.Text = null;
            netBox.Text = null;

        }

        private bool IsFilled(string s)
        {//form text area checker
            if (s != "")
            { return true; }
            else
            { return false; }
        }

        private void InsertEmployee()
        {// saving employee data to emplloyee list
            employee.Add(new Employee() { name = nameBox.Text.ToString(), hourly_Wage = Convert.ToInt32(wageBox.Text), hours_Worked = Convert.ToInt32(hoursBox.Text) });


        }



        private void DropListBox()
        {
            // Clear the listbox
            employeeBox.Items.Clear();

            // Loop through the List<> and add each item to listbox
            foreach (var Empname in employee)
            {
                employeeBox.Items.Add(Empname.name);
            }
        }

        private void employeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {//on clicking a name on the dropdown box retrives data and fills form with it
            getEmployee();
            Calculate();

        }

        private String getEmployee()
        {//select employee Item from drop down box
            var User = employee.Where(t => t.name == employeeBox.SelectedItem).FirstOrDefault(); ;
            if (User != null) {
               // Console.WriteLine(User.name, User.hours_Worked, User.hourly_Wage);

                //put item value into form sheet
            nameBox.Text = User.name;
            wageBox.Text = User.hourly_Wage.ToString();
            hoursBox.Text = User.hours_Worked.ToString();
            return User.name;
        }
            else  //user not found
                Console.WriteLine("ya broke it");
            return null;//throw exception


        }




    }
}

