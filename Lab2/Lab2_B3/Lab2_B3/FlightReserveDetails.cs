using System;
using System.Windows.Forms;

namespace Lab2_B3
{
    public partial class FlightReserveDetails : Form
    {
        public FlightReserveDetails()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtTicketNumber.Text = "";
            txtPassengerName.Text = "";
            txtPassportNumber.Text = "";
            dateFlight.Value = DateTime.Now;
            lstSource.ClearSelected();
            lstDestination.ClearSelected();
            lstClass.ClearSelected();
            for (int index = 0; index <= cblServices.Items.Count - 1; index++)
            {
                if (cblServices.GetItemChecked(index))
                    cblServices.SetItemChecked(index, false);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (lstSource.SelectedItem == lstDestination.SelectedItem)
            {
                MessageBox.Show("Departure city cannot be the same as destination city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string confirmationMessage = $"Booking verified for {txtPassengerName.Text} on {dateFlight.Value.ToShortDateString()}." +
                    $"\nDeparture: {lstSource.SelectedItem}" +
                    $"\nDestination: {lstDestination.SelectedItem}" +
                    $"\nClass: {lstClass.SelectedItem}";
                MessageBox.Show(confirmationMessage, "Booking Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
