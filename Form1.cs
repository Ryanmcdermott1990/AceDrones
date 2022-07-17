using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Author:
// Program Name:
// Program Description: 
/// <summary>
/// this program is for storing information related to the Drones that Ace Drones sells across the world, it allows
/// for the user to load a binary file of previously saved records in to the program and save these values when the
/// user closes the form. Furthermore, the user is able to search for records and clear the records with a double click and
/// right mouse click
/// </summary>
// Program Version: V1.0


namespace AceDrones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Static int max has been declared as a way of hardcoding the maximum amount of values that can be put in to
        // the arrays.
        // 3 arrays have been declared, 2 as instances of the CustomerClass and DroneClass and another as a String 2D array
        // 3 empty pointers have been declared for each of the 3 arrays. 

        static int max = 20;
        CustomerClass[] customerArray = new CustomerClass[max];
        string[,] transactionArray = new string[max, 3];
        DroneClass[] droneArray = new DroneClass[max];
        int transactionEmptyPtr;
        int customerEmptyPtr;
        int droneEmptyPtr;
        // When the form is loaded, 3 methods will be called to load the drone, customer and transaction .dat files.
        private void Form1_Load(object sender, EventArgs e)
        {
            droneLoad();
            customerLoad();
            transactionLoad();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            customerBinary();
        }
        // When the add drone button is pressed it will check if all of the boxes are not empty, if they are empty it will prompt the user to fill in all the text boxes
        // If the boxes are all filled out, a new instance of the DroneClass will be instantiated and the values of the attributes found in the Drone class
        // will be assigned to the corresponding input text boxes.
        // Once this has been done, the droneEmptyPtr will increment by 1 to reflect the array increasing by 1 new value
        // The sort method is then called to sort the elements within the array before the display method is called to display the elements within the array to the list box
        // droneClear will clear the text box items ready for the user to insert a new record.
        private void AddDroneButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serialTextBox.Text) || string.IsNullOrEmpty(modelTextBox.Text) || string.IsNullOrEmpty(engConfigTextBox.Text) || string.IsNullOrEmpty(rangeTextBox.Text) || string.IsNullOrEmpty(accessoriesTextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text) || string.IsNullOrEmpty(purchaseDateTextBox.Text))
            {
                MessageBox.Show("Please fill in all the text boxes");
            }
            else
            {
                DroneClass dronez = new DroneClass();
                dronez.gsSerialNumber = serialTextBox.Text;
                dronez.gsModel = modelTextBox.Text;
                dronez.gsEngineConfig = engConfigTextBox.Text;
                dronez.gsRange = rangeTextBox.Text;
                dronez.gsAccessories = accessoriesTextBox.Text;
                dronez.gsPrice = priceTextBox.Text;
                dronez.gsPurchaseDate = purchaseDateTextBox.Text;
                droneArray[droneEmptyPtr] = dronez;
                droneEmptyPtr++;
                droneSort();
                droneDisplay();
                droneClear();
            }
        }
        // When the add customer button is pressed it will check if all of the boxes are not empty,
        // If the boxes are all filled out, a new instance of the CustomerClass will be instantiated and the values of the attributes found in the Customer class
        // will be assigned to the corresponding input text boxes.
        // If they are empty a dialog box will appear asking the user if they want to create a default user
        // If yes then the text boxes will be populated with C999, unknown, unknown, unknown
        // If the user clicks no, a message will be displayed No default customer has been created.
        // If the text boxes are all filled and the user clicks the add button, the customerEmptyPtr will increment by 1 to reflect the array increasing by 1 new value
        // The sort method is then called to sort the elements within the array before the display method is called to display the elements within the array to the list box
        // customerClear will clear the text box items ready for the user to insert a new record.
        // If the text bo
        private void AddCustomerButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(customerIDTextBox.Text) || !string.IsNullOrEmpty(fullNameTextBox.Text) || !string.IsNullOrEmpty(cityTextBox.Text) || !string.IsNullOrEmpty(countryTextBox.Text))
            {
                CustomerClass customerz = new CustomerClass();
                customerz.gsCustID = customerIDTextBox.Text;
                customerz.gsFullName = fullNameTextBox.Text;
                customerz.gsCity = cityTextBox.Text;
                customerz.gsCountry = countryTextBox.Text;
                customerArray[customerEmptyPtr] = customerz;
                customerEmptyPtr++;
                customerSort();
                customerDisplay();
                customerClear();
            }
            else if (string.IsNullOrEmpty(customerIDTextBox.Text) || string.IsNullOrEmpty(fullNameTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrEmpty(countryTextBox.Text))
            {
                DialogResult defaultcus = MessageBox.Show("Do you want to create a default customer?", "Y/N", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (defaultcus == DialogResult.Yes)
                {
                    customerIDTextBox.Text = "C999";
                    fullNameTextBox.Text = "Unknown";
                    cityTextBox.Text = "Unknown";
                    countryTextBox.Text = "Unknown";
                    CustomerClass customerz = new CustomerClass();
                    customerz.gsCustID = customerIDTextBox.Text;
                    customerz.gsFullName = fullNameTextBox.Text;
                    customerz.gsCity = cityTextBox.Text;
                    customerz.gsCountry = countryTextBox.Text;
                    customerArray[customerEmptyPtr] = customerz;
                    customerEmptyPtr++;
                    customerSort();
                    customerDisplay();
                    customerClear();

                    return;
                }
                else if (defaultcus == DialogResult.No)
                {
                    MessageBox.Show("No default customer has been created.");
                }
            }
        }
        // When the add transaction button is pressed it will check if all of the boxes are not empty, if they are empty it will prompt the user to fill in all the text boxes
        // If the boxes are all filled out, the values of the transaction array will be assigned to the corresponding input text boxes.
        // Once this has been done, the transactionEmptyPtr will increment by 1 to reflect the array increasing by 1 new value
        // The sort method is then called to sort the elements within the array before the display method is called to display the elements within the array to the list box
        // transactionClear will clear the text box items ready for the user to insert a new record.
        private void AddTransaction(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(transIDTextBox.Text))
            {
                MessageBox.Show("Please fill in all the text boxes");
            }
            else
            {
                transactionArray[transactionEmptyPtr, 0] = transIDTextBox.Text;
                transactionArray[transactionEmptyPtr, 1] = custIDTextBox.Text;
                transactionArray[transactionEmptyPtr, 2] = serialNumberTextBox.Text;
                transactionEmptyPtr++;
               // transactionSort();
                transactionDisplay();
                transactionClear();

            }
        }
        // This method first checks if the transID text box is not empty, if so 2 for loops are will iterate until reaching transactionEmptyPtr and transactionEmptyPtr - 1
        // This works as an outer and inner for which the string values, when compared against each other using the compareTo method can be swapped.

        public void transactionSort()

        {
            try
            {
                if (!(string.IsNullOrEmpty(transIDTextBox.Text)))
                {

                    for (int inner = 0; inner < transactionEmptyPtr; inner++)
                    {
                        for (int outer = 0; outer < transactionEmptyPtr - 1; outer++)
                        {
                            int reference = transactionArray[outer, 0].CompareTo(transactionArray[inner, 0]);
                           // int reference = transactionArray[outer, 0].CompareTo(transactionArray[i + 1, 0]);
                            if (reference > 0)
                            {
                                swapTrans(inner, outer);
                            }
                        }
                    }

                }
                
            }
            catch(Exception)
            { 
            }

            
            }

            
             // string tempval = transactionArray[i + 1, 0];
            //transactionArray[i + 1, 0] = transactionArray[i, 0];
            //transactionArray[i, 0] = tempval;
            //catch (Exception)
            // {

           // }
        
        // This method first checks if the serial text box is not empty, if so 2 for loops are will iterate until reaching transactionEmptyPtr and transactionEmptyPtr - 1
        // This works as an outer and inner for which the string values, when compared against each other using the compareTo method can be swapped, using the custom swap method created.

        public void droneSort()

        {
            try
            {
                if (!(string.IsNullOrEmpty(serialTextBox.Text)))
                {

                    for (int inner = 0; inner < droneEmptyPtr; inner++)
                    {
                        for (int outer = 0; outer < droneEmptyPtr - 1; outer++)
                        {
                            int reference = droneArray[outer].gsSerialNumber.CompareTo(droneArray[inner].gsSerialNumber);
                            if (reference > 0)
                            {
                                swap(inner, outer);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        // Custom method which assigns a temp value to the element at index value at the value inner then assigning this value to outer 
        // before asssigning it back to the temp value which has been previously assisgned as inner. In laymans terms this will create a cycle 
        // where the values will jump over one another and will not overwrite due to there being a third value to temporarily store the values
        // This method accepts two integer values, inner and outer which have been declared in the for loops within the sort method
        public void swap(int inner, int outer)
        {

            DroneClass tempval = droneArray[inner];
            droneArray[inner] = droneArray[outer];
            droneArray[outer] = tempval;
        }
        // This method first checks if the customerID text box is not empty, if so 2 for loops are will iterate until reaching customerEmptyPtr and customerEmptyPtr - 1
        // This works as an outer and inner for which the string values, when compared against each other using the compareTo method can be swapped.

        public void swapCust(int inner, int outer)
        {
            CustomerClass tempval2 = customerArray[inner];
            customerArray[inner] = customerArray[outer];
            customerArray[outer] = tempval2;
        }

        public void swapTrans(int inner, int outer)
        {

            string tempval3 = transactionArray[inner, 0];
            transactionArray[inner, 0] = transactionArray[outer, 0];
            transactionArray[outer, 0] = tempval3;
           
        }

        public void customerSort()

        {
            try
            {
                if (!(string.IsNullOrEmpty(customerIDTextBox.Text)))
                {

                    for (int inner = 0; inner < customerEmptyPtr; inner++)
                    {
                        for (int outer = 0; outer < customerEmptyPtr - 1; outer++)
                        {
                            int reference = customerArray[outer].gsCustID.CompareTo(customerArray[inner].gsCustID);
                            if (reference > 0)
                            {
                                swapCust(inner, outer);
                            }
                        }
                    }

                }

            }
            catch (Exception)
            {

            }
        }
        // Custom clear method which clears all the text boxes that appertain the Drone array object
        public void droneClear()
        {
            serialTextBox.Clear();
            modelTextBox.Clear();
            engConfigTextBox.Clear();
            rangeTextBox.Clear();
            accessoriesTextBox.Clear();
            priceTextBox.Clear();
            purchaseDateTextBox.Clear();
        }
        // Custom clear method which clears all the text boxes that appertain the Customer array object

        public void customerClear()
        {
            customerIDTextBox.Clear();
            fullNameTextBox.Clear();
            cityTextBox.Clear();
            countryTextBox.Clear();


        }
        // Custom clear method which clears all the text boxes that appertain the transaction array object

        public void transactionClear()
        {
            transIDTextBox.Clear();
            custIDTextBox.Clear();
            serialNumberTextBox.Clear();
        }
        // Custom clear method which clears all the text boxes that appertain the customer array object

        public void customerDisplay()

        {
            customersTextBox.Items.Clear();
            for (int j = 0; j < customerEmptyPtr; j++)
            {

                customersTextBox.Items.Add(customerArray[j].gsCustID + "-" + customerArray[j].gsFullName + "-" + customerArray[j].gsCity + "-" + customerArray[j].gsCountry);
            }
        }
        // This is used to display the elements within the array by iterating through all of the values and adding them to the listbox seperated by a hyphen
        public void droneDisplay()
        {
            droneListBox.Items.Clear();
            for (int j = 0; j < droneEmptyPtr; j++)
            {

                droneListBox.Items.Add(droneArray[j].gsSerialNumber + "-" + droneArray[j].gsEngineConfig + "-" + droneArray[j].gsPrice);
            }

        }
        // This is used to display the elements within the array by iterating through all of the values and adding them to the listbox seperated by a hyphen
        public void transactionDisplay()
        {
            transactionListBox.Items.Clear();
            for (int j = 0; j < transactionEmptyPtr; j++)
            {
                {

                    transactionListBox.Items.Add(transactionArray[j, 0] + "\t" + transactionArray[j, 1] + "\t" + transactionArray[j, 2]);
                }
            }

        }

        // a method which will read each value within the saved binary file and then display them to the listbox
        public void droneLoad()
        {
            try
            {
                if (File.Exists("drone.dat"))
                {
                    using (BinaryReader bin = new BinaryReader(File.Open("drone.dat", FileMode.Open)))
                    {
                        int fileLength = (int)bin.BaseStream.Length / 7;
                        droneEmptyPtr = 0;
                        for (int i = 0; i < fileLength; i++)
                        {
                            DroneClass droney = new DroneClass();
                            droney.gsSerialNumber = bin.ReadString();
                            droney.gsModel = bin.ReadString();
                            droney.gsEngineConfig = bin.ReadString();
                            droney.gsRange = bin.ReadString();
                            droney.gsAccessories = bin.ReadString();
                            droney.gsPrice = bin.ReadString();
                            droney.gsPurchaseDate = bin.ReadString();

                            droneArray[droneEmptyPtr] = droney;
                            droneListBox.Items.Add(droneArray[i].gsSerialNumber + "-" + droneArray[i].gsEngineConfig + "-" + droneArray[i].gsPrice);
                            droneEmptyPtr++;
                        }
                    }
                }
                // If the file doesn't exist then a message saying, the file doesn't exist will be displayed and a new file will be created
                else if (!(File.Exists("drone.dat")))
                {
                    using (BinaryReader bin = new BinaryReader(File.Open("drone.dat", FileMode.Create)))
                    {
                        MessageBox.Show("Drone file does not currently exist, a new one has been created");
                        return;
                    }
                }
                // If the file path could not be located or anything other than the conditions within the if statements then an error message will be displayed
                else
                {
                    MessageBox.Show("Error loading file");
                }
            }
            catch (Exception)
            {

            }
        }
        // a method which will read each value within the saved binary file and then display them to the listbox
        public void customerLoad()
        {
            try
            {
                if (File.Exists("customer.dat"))
                {

                    using (BinaryReader bin = new BinaryReader(File.Open("customer.dat", FileMode.Open)))
                    {
                        int fileLength = (int)bin.BaseStream.Length / 4;
                        customerEmptyPtr = 0;
                        for (int i = 0; i < fileLength; i++)
                        {
                            CustomerClass custom = new CustomerClass();
                            custom.gsCustID = bin.ReadString();
                            custom.gsFullName = bin.ReadString();
                            custom.gsCity = bin.ReadString();
                            custom.gsCountry = bin.ReadString();


                            customerArray[customerEmptyPtr] = custom;
                            customersTextBox.Items.Add(customerArray[i].gsCustID + "-" + customerArray[i].gsFullName + "-" + customerArray[i].gsCity + "-" + customerArray[i].gsCountry);
                            customerEmptyPtr++;
                        }
                    }
                }
                // If the file doesn't exist then a message saying, the file doesn't exist will be displayed and a new file will be created

                else if (!(File.Exists("customer.dat")))
                {
                    using (BinaryReader bin = new BinaryReader(File.Open("customer.dat", FileMode.Create)))
                    {
                        MessageBox.Show("Customer file does not currently exist");
                        return;
                    }
                }
                // If the file path could not be located or anything other than the conditions within the if statements then an error message will be displayed

                else
                {
                    MessageBox.Show("Error loading file");
                }
            }
            catch (Exception)
            {

            }
        }
        // a method which will read each value within the saved binary file and then display them to the listbox
        public void transactionLoad()
        {
            try
            {
                if (File.Exists("transaction.dat"))
                {

                    using (BinaryReader bin = new BinaryReader(File.Open("transaction.dat", FileMode.Open)))
                    {
                        int fileLength = (int)bin.BaseStream.Length / 3;
                        transactionEmptyPtr = 0;
                        for (int i = 0; i < fileLength; i++)
                        {

                            transactionArray[i, 0] = bin.ReadString();
                            transactionArray[i, 1] = bin.ReadString();
                            transactionArray[i, 2] = bin.ReadString();

                            transactionListBox.Items.Add(transactionArray[i, 0] + "\t" + transactionArray[i, 1] + "\t" + transactionArray[i, 2]);
                            transactionEmptyPtr++;
                        }
                    }
                }
                // If the file doesn't exist then a message saying, the file doesn't exist will be displayed and a new file will be created

                else if (!(File.Exists("transaction.dat")))
                {
                    using (BinaryReader bin = new BinaryReader(File.Open("transaction.dat", FileMode.Create)))
                    {
                        MessageBox.Show("transaction, file does not currently exist");
                        return;

                    }
                }
                // If the file path could not be located or anything other than the conditions within the if statements then an error message will be displayed

                else
                {
                    MessageBox.Show("Error loading file");
                }
            }
            catch (Exception)
            {


            }

        }
        // Binary search for the customer which assigns the highbound as the customerEmptyPtr and the low bound to 0
        // A while loop has been added with the condition of the lowbound being less than or equal to the highbound
        // As long as this is true the mid is assigned as the lowbound + highbound / 2
        // An integer value tgt has been declared and assigned the value of the index value of the integer mid within the customerarray 
        // which is then compared to the customerIDTextBox
        // tgt is compared to 0, (the values of the text box and the target match) then a message will be displayed saying that the 
        // customer has been found at index, (mid). 
        // If when comparing the value of the search target to the text boxes the target is less than the value in the text box, then
        // the highbound is assigned as mid minus one, (basically splitting the search zone in half)
        // Inversely if the search target is more than the value of the text box then the lowbound is assigned as the mid plus 1
        // If the customerEmptyPtr is more than the highbound, (search has exhausted all the records and still hasn't found the record), then 
        // then a message saying record not found is displayed 
        public void customerBinary()
        {
            int mid = 0;
            int lowBound = 0;
            int highBound = customerEmptyPtr;

            try
            {
                while (lowBound <= highBound)
                {
                    mid = (lowBound + highBound) / 2;
                    int tgt = customerArray[mid].gsCustID.CompareTo(customerIDTextBox.Text);
                    if (tgt == 0)
                    {
                        MessageBox.Show("Customer found at index + [" + mid + "]");
                        break;
                    }
                    else if (tgt > 0)
                    {
                        highBound = mid - 1;
                    }
                    else
                    {
                        lowBound = mid + 1;
                    }

                    if (customerEmptyPtr > lowBound)

                        MessageBox.Show("Record not found");
                    break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, record not found please try again");
            }
        }
        // This method will assign the values in the drone array and write them to a binary file
        // The empty ptr is set to 0 so that there isn't any residual values that were not meant to be stored
        // a for loop will iterate through all the current values within the array until the empty + 1 making sure that 
        // there is not a null reference exception and then for each of the values added the empty ptr will increment higher by
        // 1
      
        public void droneSave()
        {
            try
            {
                if (File.Exists("drone.dat"))
                {
                    using (BinaryWriter bin = new BinaryWriter(File.Open("drone.dat", FileMode.OpenOrCreate)))
                    {
                        droneEmptyPtr = 0;
                        for (int i = 0; i < droneEmptyPtr + 1; i++)
                        {
                            if (droneArray[i] != null)
                            {
                                DroneClass drone = droneArray[i];
                                bin.Write(drone.gsSerialNumber);
                                bin.Write(drone.gsModel);
                                bin.Write(drone.gsEngineConfig);
                                bin.Write(drone.gsRange);
                                bin.Write(drone.gsAccessories);
                                bin.Write(drone.gsPrice);
                                bin.Write(drone.gsPurchaseDate);
                                droneEmptyPtr++;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Error drone");

                }
            }
            catch (Exception)
            {

            }
        }
        // This method will assign the values in the customer array and write them to a binary file
        // The empty ptr is set to 0 so that there isn't any residual values that were not meant to be stored
        // a for loop will iterate through all the current values within the array until the empty + 1 making sure that 
        // there is not a null reference exception and then for each of the values added the empty ptr will increment higher by
        // 1
        public void customerSave()
        {
            {
                try
                {
                    if (File.Exists("customer.dat"))
                    {
                        using (BinaryWriter bin = new BinaryWriter(File.Open("customer.dat", FileMode.OpenOrCreate)))
                        {
                            customerEmptyPtr = 0;
                            for (int i = 0; i < customerEmptyPtr + 1; i++)
                            {
                                if (customerArray[i] != null)
                                {
                                    CustomerClass custom = customerArray[i];

                                    bin.Write(custom.gsCustID);
                                    bin.Write(custom.gsFullName);
                                    bin.Write(custom.gsCity);
                                    bin.Write(custom.gsCountry);
                                    customerEmptyPtr++;

                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error cust");

                    }
                }
                catch (Exception)
                {

                }


            }
        }
        // This method will assign the values in the transaction array and write them to a binary file
        // The empty ptr is set to 0 so that there isn't any residual values that were not meant to be stored
        // a for loop will iterate through all the current values within the array until the empty + 1 making sure that 
        // there is not a null reference exception and then for each of the values added the empty ptr will increment higher by
        // 1
        public void transactionSave()
        {
            try
            {
                if (File.Exists("transaction.dat"))
                {
                    using (BinaryWriter bin = new BinaryWriter(File.Open("transaction.dat", FileMode.OpenOrCreate)))
                    {
                        transactionEmptyPtr = 0;
                        for (int i = 0; i < transactionEmptyPtr + 1; i++)
                        {
                            if (transactionArray[i, 0] != null)
                            {
                                bin.Write(transactionArray[transactionEmptyPtr, 0]);
                                bin.Write(transactionArray[transactionEmptyPtr, 1]);
                                bin.Write(transactionArray[transactionEmptyPtr, 2]);

                                transactionEmptyPtr++;

                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error trans");

                }
            }
            catch (Exception)
            {

            }
        }
        // This is an event when the user selects an index value within the list box
        // If this occurs firstly the existing text boxes are cleared before they are assigned to 
        // each value of the array at the selected index
        private void droneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                droneClear();
                DroneClass droney = droneArray[droneListBox.SelectedIndex];

                serialTextBox.Text = droney.gsSerialNumber;
                modelTextBox.Text = droney.gsModel;
                engConfigTextBox.Text = droney.gsEngineConfig;
                rangeTextBox.Text = droney.gsRange;
                accessoriesTextBox.Text = droney.gsAccessories;
                priceTextBox.Text = droney.gsPrice;
                purchaseDateTextBox.Text = droney.gsPurchaseDate;

                serialNumberTextBox.Text = droney.gsSerialNumber;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error please try again");
            }
        }
        // This is an event when the user selects an index value within the list box
        // If this occurs firstly the existing text boxes are cleared before they are assigned to 
        // each value of the array at the selected index
        private void customersTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                customerClear();

                CustomerClass custom = customerArray[customersTextBox.SelectedIndex];

                customerIDTextBox.Text = custom.gsCustID;
                fullNameTextBox.Text = custom.gsFullName;
                cityTextBox.Text = custom.gsCity;
                countryTextBox.Text = custom.gsCountry;
                custIDTextBox.Text = custom.gsCustID;
            }
            catch (Exception)
            {
                MessageBox.Show("Error please try again");
            }

        }
        // This is an event when the user selects an index value within the list box
        // If this occurs firstly the existing text boxes are cleared before they are assigned to 
        // each value of the array at the selected index
        private void transactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionClear();
            transIDTextBox.Text = transactionArray[transactionListBox.SelectedIndex, 0];
            custIDTextBox.Text = transactionArray[transactionListBox.SelectedIndex, 1];
            serialNumberTextBox.Text = transactionArray[transactionListBox.SelectedIndex, 2];
             DroneClass custom = droneArray[transactionListBox.SelectedIndex];
           serialTextBox.Text = custom.gsSerialNumber;
           modelTextBox.Text = custom.gsModel;
            engConfigTextBox.Text = custom.gsEngineConfig;
            rangeTextBox.Text = custom.gsRange;
            accessoriesTextBox.Text = custom.gsAccessories;
            priceTextBox.Text = custom.gsPrice;
            purchaseDateTextBox.Text = custom.gsPurchaseDate;
            CustomerClass customer = customerArray[transactionListBox.SelectedIndex];
            customerIDTextBox.Text = customer.gsCustID;
            fullNameTextBox.Text = customer.gsFullName;
            cityTextBox.Text = customer.gsCity;
            countryTextBox.Text = customer.gsCountry;

           
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        // When the user double clicks the customer clear function is called clearing the text boxes
        private void customerIDTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customerClear();
        }
        // When the user double clicks the drone clear function is called clearing the text boxes
        private void serialTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            droneClear();
        }
        // When the user double clicks the transaction clear function is called clearing the text boxes
        private void transIDTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            transactionClear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerBinary();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            droneSave();
            customerSave();
            transactionSave();
        }
    }
}














