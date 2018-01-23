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
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
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
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);
            payMachine = new PayMachine(activeTickets);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            ticketValidator.TicketEntered(lstActiveTickets.SelectedIndex);
            UpdateDisplay();
        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void btnDriverInsertsUnpaidTicket_Click(object sender, EventArgs e)
        {
            payMachine.TicketEntered(lstActiveTickets.SelectedIndex);
            UpdateDisplay();
        }

        private void btnDriverPaysFee_Click(object sender, EventArgs e)
        {
            payMachine.PayFee(txtMoney.Text);
            UpdateDisplay();
        }

        private void btnDriverTakesPaidTicket_Click(object sender, EventArgs e)
        {
            payMachine.ClearMachine();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {

            //Machime message retrival
            //Ticket machine
            lblTicketMachine.Text = ticketMachine.GetMessage();
            //Ticket Validator
            lblTicketValidator.Text = ticketValidator.GetMessage();
            //Pay Machine
            lblPayMachine.Text = payMachine.GetMessage();


            lblSpaces.Text = carPark.GetCurrentSpaces().ToString();


            //Entry logic
            if (entryBarrier.IsLifted() == true)
            {
                //Car is ready to enter
                lblEntryBarrier.Text = "True";
                btnDriverPressesForTicket.Visible = false;
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
                    btnDriverPressesForTicket.Visible = true;

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
                btnDriverEntersTicket.Visible = false;
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
                    btnDriverEntersTicket.Visible = true;
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
                btnDriverTakesPaidTicket.Visible = true;
            }
            else
            {
                lblPayMachinePaid.Text = "False";
                if (payMachine.GetTicketIn() == true)
                {
                    lblPayMachineSensor.Text = "True";
                    btnDriverInsertsUnpaidTicket.Visible = false;
                    btnDriverPaysFee.Visible = true;
                }
                else
                {
                    lblPayMachineSensor.Text = "False";
                    btnDriverTakesPaidTicket.Visible = false;
                    btnDriverInsertsUnpaidTicket.Visible = true;
                }
            }

            //Listbox contents
            lstActiveTickets.Items.Clear();

            foreach (Ticket ticket in activeTickets.GetTickets())
            {
                lstActiveTickets.Items.Add("#" + ticket.GetHashCode() + ": " + ticket.IsPaid());
            }

            lblFullSign.Text = fullSign.IsLit().ToString();
            //Fullsign button overrides
            if (fullSign.IsLit() == true)
            {
                btnCarArrivesAtEntrance.Visible = false;
            }

            if (lstActiveTickets.Items.Count == 0)
            {
                btnCarArrivesAtExit.Visible = false;
            }

            if ((entryBarrier.IsLifted() == true) && (entrySensor.IsCarOnSensor() == true) && (lstActiveTickets.Items.Count == 1))
            {
                btnCarArrivesAtExit.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
