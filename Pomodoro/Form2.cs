using System;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form2 : Form
    {
        System.Timers.Timer t;
        int mn, uni_mn, br, ss, sc, currentSession;
        public Form2(string s, string brk, string m)
        {
            InitializeComponent();
            this.TopMost = true;
            if (string.IsNullOrEmpty(m)) { m = "25"; }
            mn = int.Parse(m);    // Work session minutes
            uni_mn = mn;
            if (string.IsNullOrEmpty(brk)) { brk = "5"; }
            br = int.Parse(brk);// Break session minutes
            ss = int.Parse(s);     // Total number of sessions
            currentSession = 1;    // Start with the first session
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;  // Set the timer interval to 1 second
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private bool isWorkSession = true; // Track if it's a work session

        private void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                sc--;  // Decrease the seconds
                if (sc < 0)
                {
                    mn--;  // Decrease minutes if seconds go below 0
                    if (mn >= 0)
                    {
                        sc = 59;  // Reset seconds to 59 when a minute is subtracted
                    }
                }

                if (mn < 0) // Session complete (work or break)
                {
                    t.Stop(); // Stop the timer when a session ends

                    if (isWorkSession) // If it's a work session
                    {
                        MessageBox.Show("Work session complete! Starting break.");
                        sessionLabel.Text = $"Break({currentSession})";
                        mn = br; // Set minutes to break duration
                        sc = 0;
                        isWorkSession = false; // Switch to break session
                        currentSession++;
                    }
                    else // If it's a break session
                    {
                        MessageBox.Show("Break session complete! Back to work.");
                        sessionLabel.Text = $"Session- {currentSession}";
                        mn = uni_mn; // Set minutes back to work session duration
                        sc = 0;
                        isWorkSession = true; // Switch back to work session
                    }

                    // If we've completed all sessions, stop the timer and show a final message
                    if (currentSession > ss)
                    {
                        MessageBox.Show("All sessions complete!");
                        t.Stop(); // Stop the timer after all sessions are done
                        this.Close(); // Optionally close the form
                    }
                    else
                    {
                        t.Start(); // Restart the timer for the next session
                    }
                    
                }

                // Update the clock label with formatted time
                clock.Text = String.Format("{0:D2} : {1:D2}", mn, sc);
            }));
        }

        // Ensure the timer is stopped when the form is closed
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
            {
                t.Stop(); // Stop the timer
                t.Dispose(); // Dispose of the timer resources
            }
        }
    }
}
