namespace CarParkSimulation
{
    partial class SimulatorInterface
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPayMachine = new System.Windows.Forms.Label();
            this.btnDriverTakesPaidTicket = new System.Windows.Forms.Button();
            this.btnDriverPaysFee = new System.Windows.Forms.Button();
            this.btnDriverInsertsUnpaidTicket = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPayMachinePaid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayMachineSensor = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstActiveTickets = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.lblEntrySensor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtMoney);
            this.groupBox7.Controls.Add(this.lblMoney);
            this.groupBox7.Controls.Add(this.lblPayMachine);
            this.groupBox7.Controls.Add(this.btnDriverTakesPaidTicket);
            this.groupBox7.Controls.Add(this.btnDriverPaysFee);
            this.groupBox7.Controls.Add(this.btnDriverInsertsUnpaidTicket);
            this.groupBox7.Location = new System.Drawing.Point(569, 180);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(267, 293);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Payment simulator";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(125, 144);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(132, 22);
            this.txtMoney.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(8, 148);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(105, 17);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Money Inserted";
            // 
            // lblPayMachine
            // 
            this.lblPayMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblPayMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPayMachine.Location = new System.Drawing.Point(8, 25);
            this.lblPayMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMachine.Name = "lblPayMachine";
            this.lblPayMachine.Size = new System.Drawing.Size(250, 38);
            this.lblPayMachine.TabIndex = 1;
            this.lblPayMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDriverTakesPaidTicket
            // 
            this.btnDriverTakesPaidTicket.Location = new System.Drawing.Point(8, 218);
            this.btnDriverTakesPaidTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverTakesPaidTicket.Name = "btnDriverTakesPaidTicket";
            this.btnDriverTakesPaidTicket.Size = new System.Drawing.Size(251, 66);
            this.btnDriverTakesPaidTicket.TabIndex = 2;
            this.btnDriverTakesPaidTicket.Text = "Driver takes paid ticket";
            this.btnDriverTakesPaidTicket.UseVisualStyleBackColor = true;
            this.btnDriverTakesPaidTicket.Visible = false;
            // 
            // btnDriverPaysFee
            // 
            this.btnDriverPaysFee.Location = new System.Drawing.Point(8, 176);
            this.btnDriverPaysFee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverPaysFee.Name = "btnDriverPaysFee";
            this.btnDriverPaysFee.Size = new System.Drawing.Size(251, 34);
            this.btnDriverPaysFee.TabIndex = 1;
            this.btnDriverPaysFee.Text = "Driver pays fee";
            this.btnDriverPaysFee.UseVisualStyleBackColor = true;
            this.btnDriverPaysFee.Visible = false;
            // 
            // btnDriverInsertsUnpaidTicket
            // 
            this.btnDriverInsertsUnpaidTicket.Location = new System.Drawing.Point(8, 70);
            this.btnDriverInsertsUnpaidTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverInsertsUnpaidTicket.Name = "btnDriverInsertsUnpaidTicket";
            this.btnDriverInsertsUnpaidTicket.Size = new System.Drawing.Size(251, 66);
            this.btnDriverInsertsUnpaidTicket.TabIndex = 0;
            this.btnDriverInsertsUnpaidTicket.Text = "Driver inserts unpaid ticket";
            this.btnDriverInsertsUnpaidTicket.UseVisualStyleBackColor = true;
            this.btnDriverInsertsUnpaidTicket.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSpaces);
            this.groupBox3.Controls.Add(this.lblFullSign);
            this.groupBox3.Location = new System.Drawing.Point(844, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(437, 373);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.lblPayMachinePaid);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.lblPayMachineSensor);
            this.groupBox8.Location = new System.Drawing.Point(15, 203);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(188, 82);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Pay Machine";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayMachinePaid
            // 
            this.lblPayMachinePaid.BackColor = System.Drawing.Color.White;
            this.lblPayMachinePaid.Location = new System.Drawing.Point(80, 50);
            this.lblPayMachinePaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMachinePaid.Name = "lblPayMachinePaid";
            this.lblPayMachinePaid.Size = new System.Drawing.Size(93, 25);
            this.lblPayMachinePaid.TabIndex = 0;
            this.lblPayMachinePaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Paid";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayMachineSensor
            // 
            this.lblPayMachineSensor.BackColor = System.Drawing.Color.White;
            this.lblPayMachineSensor.Location = new System.Drawing.Point(80, 20);
            this.lblPayMachineSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMachineSensor.Name = "lblPayMachineSensor";
            this.lblPayMachineSensor.Size = new System.Drawing.Size(93, 25);
            this.lblPayMachineSensor.TabIndex = 0;
            this.lblPayMachineSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveTickets);
            this.groupBox6.Location = new System.Drawing.Point(228, 25);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(192, 340);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active Tickets";
            // 
            // lstActiveTickets
            // 
            this.lstActiveTickets.FormattingEnabled = true;
            this.lstActiveTickets.ItemHeight = 16;
            this.lstActiveTickets.Location = new System.Drawing.Point(8, 23);
            this.lstActiveTickets.Margin = new System.Windows.Forms.Padding(4);
            this.lstActiveTickets.Name = "lstActiveTickets";
            this.lstActiveTickets.Size = new System.Drawing.Size(175, 292);
            this.lstActiveTickets.TabIndex = 0;
            this.lstActiveTickets.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(15, 113);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(188, 82);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(80, 50);
            this.lblExitBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(93, 25);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(80, 20);
            this.lblExitSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(93, 25);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(15, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(188, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(80, 50);
            this.lblEntryBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(93, 25);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(80, 20);
            this.lblEntrySensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(93, 25);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Spaces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Sign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaces
            // 
            this.lblSpaces.BackColor = System.Drawing.Color.White;
            this.lblSpaces.Location = new System.Drawing.Point(95, 330);
            this.lblSpaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(93, 25);
            this.lblSpaces.TabIndex = 0;
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(95, 289);
            this.lblFullSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(93, 25);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 100);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(536, 66);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 65);
            this.label3.TabIndex = 10;
            this.label3.Text = "Car Park Simulator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersTicket);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(294, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 293);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketValidator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketValidator.Location = new System.Drawing.Point(8, 25);
            this.lblTicketValidator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(250, 38);
            this.lblTicketValidator.TabIndex = 1;
            this.lblTicketValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(8, 218);
            this.btnCarExitsCarPark.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(251, 66);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            // 
            // btnDriverEntersTicket
            // 
            this.btnDriverEntersTicket.Location = new System.Drawing.Point(8, 144);
            this.btnDriverEntersTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverEntersTicket.Name = "btnDriverEntersTicket";
            this.btnDriverEntersTicket.Size = new System.Drawing.Size(251, 66);
            this.btnDriverEntersTicket.TabIndex = 1;
            this.btnDriverEntersTicket.Text = "Driver enters ticket";
            this.btnDriverEntersTicket.UseVisualStyleBackColor = true;
            this.btnDriverEntersTicket.Visible = false;
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(8, 70);
            this.btnCarArrivesAtExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(251, 66);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car arrives at exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForTicket);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(9, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketMachine.Location = new System.Drawing.Point(8, 25);
            this.lblTicketMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(250, 38);
            this.lblTicketMachine.TabIndex = 1;
            this.lblTicketMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(8, 218);
            this.btnCarEntersCarPark.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(251, 66);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            // 
            // btnDriverPressesForTicket
            // 
            this.btnDriverPressesForTicket.Location = new System.Drawing.Point(8, 144);
            this.btnDriverPressesForTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverPressesForTicket.Name = "btnDriverPressesForTicket";
            this.btnDriverPressesForTicket.Size = new System.Drawing.Size(251, 66);
            this.btnDriverPressesForTicket.TabIndex = 1;
            this.btnDriverPressesForTicket.Text = "Driver presses for ticket";
            this.btnDriverPressesForTicket.UseVisualStyleBackColor = true;
            this.btnDriverPressesForTicket.Visible = false;
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(8, 70);
            this.btnCarArrivesAtEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(251, 66);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 483);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimulatorInterface";
            this.Text = "SimulatorInterface";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPayMachine;
        private System.Windows.Forms.Button btnDriverTakesPaidTicket;
        private System.Windows.Forms.Button btnDriverPaysFee;
        private System.Windows.Forms.Button btnDriverInsertsUnpaidTicket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPayMachinePaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPayMachineSensor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstActiveTickets;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTicketValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersTicket;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTicketMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForTicket;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
    }
}