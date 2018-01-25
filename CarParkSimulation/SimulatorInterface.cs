using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkSimulation
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TokenMachine tokenMachine;
        private ActiveTokens activeTokens;
        private TokenValidator tokenValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FrontSign frontSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        private PayMachine payMachine;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void btnReset_Click(object sender, EventArgs e)
        {
            activeTokens = new ActiveTokens();
            tokenMachine = new TokenMachine(activeTokens);
            tokenValidator = new TokenValidator(activeTokens);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            frontSign = new FrontSign();
            carPark = new CarPark(tokenMachine, tokenValidator, frontSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);
            payMachine = new PayMachine(activeTokens);

            tokenMachine.AssignCarPark(carPark);
            tokenValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForToken.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersToken.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void btnCarArrivesAtEntrance_Click(object sender, EventArgs e)
        {
            entrySensor.CarDetected();
            UpdateDisplay();
        }

        private void btnDriverPressesForTicket_Click(object sender, EventArgs e)
        {
            if (rbtnDisabled.Checked == true)
            {
                tokenMachine.GiveToken(1, false); //Disabled bay
            }
            else if (rbtnFamily.Checked == true)
            {
                tokenMachine.GiveToken(2, false); //Family bay
            }
            else
            {
                tokenMachine.GiveToken(0, false); //Regular bay, the default option if none is selected
            }
            UpdateDisplay();
        }

        private void btnDriverEntersPrepaid_Click(object sender, EventArgs e)
        {
            if (rbtnDisabled.Checked == true)
            {
                tokenMachine.GiveToken(1, true); //Disabled bay
            }
            else if (rbtnFamily.Checked == true)
            {
                tokenMachine.GiveToken(2, true); //Family bay
            }
            else
            {
                tokenMachine.GiveToken(0, true); //Regular bay, the default option if none is selected
            }
            UpdateDisplay();
        }

        private void btnCarEntersCarPark_Click(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void btnCarArrivesAtExit_Click(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            UpdateDisplay();
        }

        private void btnDriverEntersTicket_Click(object sender, EventArgs e)
        {
            tokenValidator.TokenEntered(lstActiveTokens.SelectedIndex);
            UpdateDisplay();
        }

        private void btnCarExitsCarPark_Click(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void btnDriverInsertsUnpaidTicket_Click_1(object sender, EventArgs e)
        {
            payMachine.TokenEntered(lstActiveTokens.SelectedIndex);
            UpdateDisplay();
        }

        private void btnDriverPaysFee_Click_1(object sender, EventArgs e)
        {
            payMachine.PayFee(txtMoney.Text);
            UpdateDisplay();
        }

        private void btnDriverTakesPaidTicket_Click_1(object sender, EventArgs e)
        {
            payMachine.ClearMachine();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {

            //Machime message retrival
            //Ticket machine
            lblTicketMachine.Text = tokenMachine.GetMessage();
            //Ticket Validator
            lblTicketValidator.Text = tokenValidator.GetMessage();
            //Pay Machine
            lblPayMachine.Text = payMachine.GetMessage();



            lblRegular.Text = carPark.GetCurrentNormal().ToString();
            lblDisabled.Text = carPark.GetCurrentDisabled().ToString();
            lblFamily.Text = carPark.GetCurrentFamily().ToString();


            //Entry logic
            if (entryBarrier.IsLifted() == true)
            {
                //Car is ready to enter
                lblEntryBarrier.Text = "True";
                btnDriverPressesForToken.Visible = false;
                btnDriverEntersPrepaid.Visible = false;
                btnCarEntersCarPark.Visible = true;
            }
            else
            {
                lblEntryBarrier.Text = "False";
                if (entrySensor.IsCarOnSensor() == true)
                {
                    //New car at machine
                    lblEntrySensor.Text = "True";
                    btnCarArrivesAtEntrance.Visible = false;
                    btnDriverPressesForToken.Visible = true;
                    btnDriverEntersPrepaid.Visible = true;

                }
                else
                {
                    //No car at machine
                    lblEntrySensor.Text = "False";
                    btnCarArrivesAtEntrance.Visible = true;
                    btnCarEntersCarPark.Visible = false;
                }
            }

            //Exit logic
            if (exitBarrier.IsLifted() == true)
            {
                //Car is ready to enter
                lblExitBarrier.Text = "True";
                btnDriverEntersToken.Visible = false;
                btnCarExitsCarPark.Visible = true;
            }
            else
            {
                lblExitBarrier.Text = "False";
                if (exitSensor.IsCarOnSensor() == true)
                {
                    //New car at machine
                    lblExitSensor.Text = "True";
                    btnCarArrivesAtExit.Visible = false;
                    btnDriverEntersToken.Visible = true;
                }
                else
                {
                    //No car at machine
                    lblExitSensor.Text = "False";
                    btnCarArrivesAtExit.Visible = true;
                    btnCarExitsCarPark.Visible = false;
                }
            }

            //Pay Machine Logic
            if (payMachine.GetFeePaid() == true)
            {
                lblPayMachinePaid.Text = "True";
                btnDriverPaysFee.Visible = false;
                btnDriverInsertsUnpaidToken.Visible = false;
                btnDriverTakesPaidToken.Visible = true;
            }
            else
            {
                lblPayMachinePaid.Text = "False";
                if (payMachine.GetTicketIn() == true)
                {
                    lblPayMachineSensor.Text = "True";
                    btnDriverInsertsUnpaidToken.Visible = false;
                    btnDriverPaysFee.Visible = true;
                }
                else
                {
                    lblPayMachineSensor.Text = "False";
                    btnDriverTakesPaidToken.Visible = false;
                    btnDriverInsertsUnpaidToken.Visible = true;
                }
            }

            //Listbox contents
            lstActiveTokens.Items.Clear();

            foreach (Token token in activeTokens.GetTokens())
            {
                lstActiveTokens.Items.Add("#" + token.GetHashCode() + ": " + token.GetBayType() + " " + token.IsPrepaid() + " " + token.IsPaid());
            }

            //Fullsign button overrides

            if (lstActiveTokens.Items.Count == 0)
            {
                btnCarArrivesAtExit.Visible = false;
            }

            if ((entryBarrier.IsLifted() == true) && (entrySensor.IsCarOnSensor() == true) && (lstActiveTokens.Items.Count == 1))
            {
                btnCarArrivesAtExit.Visible = false;
            }
        }
    }
}
