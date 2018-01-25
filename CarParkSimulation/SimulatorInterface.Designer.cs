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
            this.btnDriverTakesPaidToken = new System.Windows.Forms.Button();
            this.btnDriverPaysFee = new System.Windows.Forms.Button();
            this.btnDriverInsertsUnpaidToken = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPayMachinePaid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayMachineSensor = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstActiveTokens = new System.Windows.Forms.ListBox();
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
            this.lblRegular = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersToken = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDriverEntersPrepaid = new System.Windows.Forms.Button();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForToken = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.rbtnDisabled = new System.Windows.Forms.RadioButton();
            this.rbtnFamily = new System.Windows.Forms.RadioButton();
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
            this.groupBox7.Controls.Add(this.btnDriverTakesPaidToken);
            this.groupBox7.Controls.Add(this.btnDriverPaysFee);
            this.groupBox7.Controls.Add(this.btnDriverInsertsUnpaidToken);
            this.groupBox7.Location = new System.Drawing.Point(427, 146);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 238);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Payment simulator";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(94, 117);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 20);
            this.txtMoney.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(6, 120);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(80, 13);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Money Inserted";
            // 
            // lblPayMachine
            // 
            this.lblPayMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblPayMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPayMachine.Location = new System.Drawing.Point(6, 20);
            this.lblPayMachine.Name = "lblPayMachine";
            this.lblPayMachine.Size = new System.Drawing.Size(188, 31);
            this.lblPayMachine.TabIndex = 1;
            this.lblPayMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDriverTakesPaidToken
            // 
            this.btnDriverTakesPaidToken.Location = new System.Drawing.Point(6, 177);
            this.btnDriverTakesPaidToken.Name = "btnDriverTakesPaidToken";
            this.btnDriverTakesPaidToken.Size = new System.Drawing.Size(188, 54);
            this.btnDriverTakesPaidToken.TabIndex = 2;
            this.btnDriverTakesPaidToken.Text = "Driver takes paid token";
            this.btnDriverTakesPaidToken.UseVisualStyleBackColor = true;
            this.btnDriverTakesPaidToken.Visible = false;
            this.btnDriverTakesPaidToken.Click += new System.EventHandler(this.btnDriverTakesPaidTicket_Click_1);
            // 
            // btnDriverPaysFee
            // 
            this.btnDriverPaysFee.Location = new System.Drawing.Point(6, 143);
            this.btnDriverPaysFee.Name = "btnDriverPaysFee";
            this.btnDriverPaysFee.Size = new System.Drawing.Size(188, 28);
            this.btnDriverPaysFee.TabIndex = 1;
            this.btnDriverPaysFee.Text = "Driver pays fee";
            this.btnDriverPaysFee.UseVisualStyleBackColor = true;
            this.btnDriverPaysFee.Visible = false;
            this.btnDriverPaysFee.Click += new System.EventHandler(this.btnDriverPaysFee_Click_1);
            // 
            // btnDriverInsertsUnpaidToken
            // 
            this.btnDriverInsertsUnpaidToken.Location = new System.Drawing.Point(6, 57);
            this.btnDriverInsertsUnpaidToken.Name = "btnDriverInsertsUnpaidToken";
            this.btnDriverInsertsUnpaidToken.Size = new System.Drawing.Size(188, 54);
            this.btnDriverInsertsUnpaidToken.TabIndex = 0;
            this.btnDriverInsertsUnpaidToken.Text = "Driver inserts unpaid token";
            this.btnDriverInsertsUnpaidToken.UseVisualStyleBackColor = true;
            this.btnDriverInsertsUnpaidToken.Visible = false;
            this.btnDriverInsertsUnpaidToken.Click += new System.EventHandler(this.btnDriverInsertsUnpaidTicket_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblDisabled);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblFamily);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblRegular);
            this.groupBox3.Location = new System.Drawing.Point(633, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 441);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(11, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Disabled";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisabled
            // 
            this.lblDisabled.BackColor = System.Drawing.Color.White;
            this.lblDisabled.Location = new System.Drawing.Point(71, 257);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(70, 20);
            this.lblDisabled.TabIndex = 6;
            this.lblDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Family";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamily
            // 
            this.lblFamily.BackColor = System.Drawing.Color.White;
            this.lblFamily.Location = new System.Drawing.Point(71, 281);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(70, 20);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.lblPayMachinePaid);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.lblPayMachineSensor);
            this.groupBox8.Location = new System.Drawing.Point(11, 165);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(141, 67);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Pay Machine";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayMachinePaid
            // 
            this.lblPayMachinePaid.BackColor = System.Drawing.Color.White;
            this.lblPayMachinePaid.Location = new System.Drawing.Point(60, 41);
            this.lblPayMachinePaid.Name = "lblPayMachinePaid";
            this.lblPayMachinePaid.Size = new System.Drawing.Size(70, 20);
            this.lblPayMachinePaid.TabIndex = 0;
            this.lblPayMachinePaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Paid";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayMachineSensor
            // 
            this.lblPayMachineSensor.BackColor = System.Drawing.Color.White;
            this.lblPayMachineSensor.Location = new System.Drawing.Point(60, 16);
            this.lblPayMachineSensor.Name = "lblPayMachineSensor";
            this.lblPayMachineSensor.Size = new System.Drawing.Size(70, 20);
            this.lblPayMachineSensor.TabIndex = 0;
            this.lblPayMachineSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveTokens);
            this.groupBox6.Location = new System.Drawing.Point(171, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 414);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active Tickets";
            // 
            // lstActiveTokens
            // 
            this.lstActiveTokens.FormattingEnabled = true;
            this.lstActiveTokens.Location = new System.Drawing.Point(6, 19);
            this.lstActiveTokens.Name = "lstActiveTokens";
            this.lstActiveTokens.Size = new System.Drawing.Size(132, 381);
            this.lstActiveTokens.TabIndex = 0;
            this.lstActiveTokens.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(11, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 67);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(60, 16);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(70, 20);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(11, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 67);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(60, 16);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(70, 20);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Regular";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegular
            // 
            this.lblRegular.BackColor = System.Drawing.Color.White;
            this.lblRegular.Location = new System.Drawing.Point(71, 235);
            this.lblRegular.Name = "lblRegular";
            this.lblRegular.Size = new System.Drawing.Size(70, 20);
            this.lblRegular.TabIndex = 0;
            this.lblRegular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(402, 54);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Car Park Simulator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersToken);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(220, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketValidator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketValidator.Location = new System.Drawing.Point(6, 20);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(188, 31);
            this.lblTicketValidator.TabIndex = 1;
            this.lblTicketValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(6, 177);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            this.btnCarExitsCarPark.Click += new System.EventHandler(this.btnCarExitsCarPark_Click);
            // 
            // btnDriverEntersToken
            // 
            this.btnDriverEntersToken.Location = new System.Drawing.Point(6, 117);
            this.btnDriverEntersToken.Name = "btnDriverEntersToken";
            this.btnDriverEntersToken.Size = new System.Drawing.Size(188, 54);
            this.btnDriverEntersToken.TabIndex = 1;
            this.btnDriverEntersToken.Text = "Driver enters token";
            this.btnDriverEntersToken.UseVisualStyleBackColor = true;
            this.btnDriverEntersToken.Visible = false;
            this.btnDriverEntersToken.Click += new System.EventHandler(this.btnDriverEntersTicket_Click);
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(6, 57);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car arrives at exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            this.btnCarArrivesAtExit.Click += new System.EventHandler(this.btnCarArrivesAtExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFamily);
            this.groupBox1.Controls.Add(this.btnDriverEntersPrepaid);
            this.groupBox1.Controls.Add(this.rbtnDisabled);
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Controls.Add(this.rbtnRegular);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForToken);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(7, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 307);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // btnDriverEntersPrepaid
            // 
            this.btnDriverEntersPrepaid.Location = new System.Drawing.Point(103, 186);
            this.btnDriverEntersPrepaid.Name = "btnDriverEntersPrepaid";
            this.btnDriverEntersPrepaid.Size = new System.Drawing.Size(91, 54);
            this.btnDriverEntersPrepaid.TabIndex = 4;
            this.btnDriverEntersPrepaid.Text = "Driver inserts prepaid";
            this.btnDriverEntersPrepaid.UseVisualStyleBackColor = true;
            this.btnDriverEntersPrepaid.Visible = false;
            this.btnDriverEntersPrepaid.Click += new System.EventHandler(this.btnDriverEntersPrepaid_Click);
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketMachine.Location = new System.Drawing.Point(6, 20);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(188, 31);
            this.lblTicketMachine.TabIndex = 1;
            this.lblTicketMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(6, 246);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            this.btnCarEntersCarPark.Click += new System.EventHandler(this.btnCarEntersCarPark_Click);
            // 
            // btnDriverPressesForToken
            // 
            this.btnDriverPressesForToken.Location = new System.Drawing.Point(6, 186);
            this.btnDriverPressesForToken.Name = "btnDriverPressesForToken";
            this.btnDriverPressesForToken.Size = new System.Drawing.Size(91, 54);
            this.btnDriverPressesForToken.TabIndex = 1;
            this.btnDriverPressesForToken.Text = "Driver presses for token";
            this.btnDriverPressesForToken.UseVisualStyleBackColor = true;
            this.btnDriverPressesForToken.Visible = false;
            this.btnDriverPressesForToken.Click += new System.EventHandler(this.btnDriverPressesForTicket_Click);
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(6, 57);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            this.btnCarArrivesAtEntrance.Click += new System.EventHandler(this.btnCarArrivesAtEntrance_Click);
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(6, 117);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(83, 17);
            this.rbtnRegular.TabIndex = 5;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular Bay";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // rbtnDisabled
            // 
            this.rbtnDisabled.AutoSize = true;
            this.rbtnDisabled.Location = new System.Drawing.Point(6, 140);
            this.rbtnDisabled.Name = "rbtnDisabled";
            this.rbtnDisabled.Size = new System.Drawing.Size(87, 17);
            this.rbtnDisabled.TabIndex = 11;
            this.rbtnDisabled.TabStop = true;
            this.rbtnDisabled.Text = "Disabled Bay";
            this.rbtnDisabled.UseVisualStyleBackColor = true;
            // 
            // rbtnFamily
            // 
            this.rbtnFamily.AutoSize = true;
            this.rbtnFamily.Location = new System.Drawing.Point(6, 163);
            this.rbtnFamily.Name = "rbtnFamily";
            this.rbtnFamily.Size = new System.Drawing.Size(75, 17);
            this.rbtnFamily.TabIndex = 12;
            this.rbtnFamily.TabStop = true;
            this.rbtnFamily.Text = "Family Bay";
            this.rbtnFamily.UseVisualStyleBackColor = true;
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 461);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPayMachine;
        private System.Windows.Forms.Button btnDriverTakesPaidToken;
        private System.Windows.Forms.Button btnDriverPaysFee;
        private System.Windows.Forms.Button btnDriverInsertsUnpaidToken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPayMachinePaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPayMachineSensor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstActiveTokens;
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
        private System.Windows.Forms.Label lblRegular;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTicketValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersToken;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTicketMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForToken;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDisabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.Button btnDriverEntersPrepaid;
        private System.Windows.Forms.RadioButton rbtnDisabled;
        private System.Windows.Forms.RadioButton rbtnFamily;
    }
}