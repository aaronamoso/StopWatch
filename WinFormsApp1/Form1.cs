using Microsoft.VisualBasic.Devices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DateTime - is a struct: start, stop, elapsedTime are all declared
        DateTime start;
        DateTime stop;
        TimeSpan elapsedTime;

        //Exits the program when this btn is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString(); //shows on the txt box ToLongTimeString shows the time--string method
            txtStop.Text = ""; // this becomes an empty string with start button is clicked -- pretty much resets the time
            txtElapsed.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now; // Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.
            txtStop.Text = stop.ToLongTimeString();
            elapsedTime= stop - start;
            txtElapsed.Text = elapsedTime.Seconds.ToString();
        }
    }
}
