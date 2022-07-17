namespace AceDrones
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
            this.button1 = new System.Windows.Forms.Button();
            this.droneListBox = new System.Windows.Forms.ListBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.engConfigTextBox = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.customersTextBox = new System.Windows.Forms.ListBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.transIDTextBox = new System.Windows.Forms.TextBox();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Drone";
            this.toolTip1.SetToolTip(this.button1, "Click here to add Drone");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddDroneButton);
            // 
            // droneListBox
            // 
            this.droneListBox.FormattingEnabled = true;
            this.droneListBox.Location = new System.Drawing.Point(244, 77);
            this.droneListBox.Name = "droneListBox";
            this.droneListBox.Size = new System.Drawing.Size(226, 316);
            this.droneListBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.droneListBox, "Click on a record and it will populate the other text boxes");
            this.droneListBox.SelectedIndexChanged += new System.EventHandler(this.droneListBox_SelectedIndexChanged);
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(111, 28);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.serialTextBox, "Primary key related with the serial number in the transactions section");
            this.serialTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.serialTextBox_MouseDoubleClick);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(111, 54);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.modelTextBox, "Model of Drone");
            // 
            // engConfigTextBox
            // 
            this.engConfigTextBox.Location = new System.Drawing.Point(111, 81);
            this.engConfigTextBox.Name = "engConfigTextBox";
            this.engConfigTextBox.Size = new System.Drawing.Size(100, 20);
            this.engConfigTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.engConfigTextBox, "Engine configuration");
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.Location = new System.Drawing.Point(111, 107);
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rangeTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.rangeTextBox, "Range of the Drone");
            // 
            // accessoriesTextBox
            // 
            this.accessoriesTextBox.Location = new System.Drawing.Point(111, 134);
            this.accessoriesTextBox.Name = "accessoriesTextBox";
            this.accessoriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.accessoriesTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.accessoriesTextBox, "Accessories for the Drone");
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(111, 161);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.priceTextBox, "Price of the Drone");
            // 
            // purchaseDateTextBox
            // 
            this.purchaseDateTextBox.Location = new System.Drawing.Point(111, 188);
            this.purchaseDateTextBox.Name = "purchaseDateTextBox";
            this.purchaseDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchaseDateTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.purchaseDateTextBox, "When the Drone was purchased");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serial #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Eng Config";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Accessories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Purchase Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accessoriesTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.serialTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.engConfigTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rangeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.purchaseDateTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 274);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drone Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Customer";
            this.toolTip1.SetToolTip(this.button2, "Click here to add a customer");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddCustomerButton);
            // 
            // customersTextBox
            // 
            this.customersTextBox.FormattingEnabled = true;
            this.customersTextBox.Location = new System.Drawing.Point(645, 70);
            this.customersTextBox.Name = "customersTextBox";
            this.customersTextBox.Size = new System.Drawing.Size(143, 134);
            this.customersTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.customersTextBox, "Click on a record and it will populate the other text boxes");
            this.customersTextBox.SelectedIndexChanged += new System.EventHandler(this.customersTextBox_SelectedIndexChanged);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(56, 28);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(96, 20);
            this.customerIDTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.customerIDTextBox, "Right click here to search for a customer record");
            this.customerIDTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerIDTextBox_MouseDoubleClick);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(56, 54);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(96, 20);
            this.fullNameTextBox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.fullNameTextBox, "Your Full Name");
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(56, 80);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(96, 20);
            this.cityTextBox.TabIndex = 21;
            this.toolTip1.SetToolTip(this.cityTextBox, "The city you live in");
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(56, 107);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(96, 20);
            this.countryTextBox.TabIndex = 22;
            this.toolTip1.SetToolTip(this.countryTextBox, "The country you live in");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.countryTextBox);
            this.groupBox2.Controls.Add(this.customerIDTextBox);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(this.fullNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(476, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 138);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "FullName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "CustID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Add Transaction";
            this.toolTip1.SetToolTip(this.button3, "Click here to add a transaction");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddTransaction);
            // 
            // transactionListBox
            // 
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.Location = new System.Drawing.Point(645, 272);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.Size = new System.Drawing.Size(143, 160);
            this.transactionListBox.TabIndex = 25;
            this.transactionListBox.SelectedIndexChanged += new System.EventHandler(this.transactionListBox_SelectedIndexChanged);
            // 
            // transIDTextBox
            // 
            this.transIDTextBox.Location = new System.Drawing.Point(56, 24);
            this.transIDTextBox.Name = "transIDTextBox";
            this.transIDTextBox.Size = new System.Drawing.Size(96, 20);
            this.transIDTextBox.TabIndex = 26;
            this.toolTip1.SetToolTip(this.transIDTextBox, "Unique transaction ID which relates with customer ID and serial number from the D" +
        "rones and Customers sections");
            this.transIDTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.transIDTextBox_MouseDoubleClick);
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.Location = new System.Drawing.Point(56, 51);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.ReadOnly = true;
            this.custIDTextBox.Size = new System.Drawing.Size(96, 20);
            this.custIDTextBox.TabIndex = 27;
            this.toolTip1.SetToolTip(this.custIDTextBox, "Customer ID related to the customer section");
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(56, 78);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.ReadOnly = true;
            this.serialNumberTextBox.Size = new System.Drawing.Size(96, 20);
            this.serialNumberTextBox.TabIndex = 28;
            this.toolTip1.SetToolTip(this.serialNumberTextBox, "Serial number related to the Drone section");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "TransID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "CustID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "SerialNum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serialNumberTextBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.transIDTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.custIDTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(476, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 112);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 29);
            this.label15.TabIndex = 33;
            this.label15.Text = "Drones";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(483, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 29);
            this.label16.TabIndex = 34;
            this.label16.Text = "Customers";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(473, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 29);
            this.label17.TabIndex = 35;
            this.label17.Text = "Transactions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.transactionListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customersTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.droneListBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox droneListBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox engConfigTextBox;
        private System.Windows.Forms.TextBox rangeTextBox;
        private System.Windows.Forms.TextBox accessoriesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox purchaseDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox customersTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox transactionListBox;
        private System.Windows.Forms.TextBox transIDTextBox;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

