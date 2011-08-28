using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PrimeNumberGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            bitLengthComboBox.SelectedIndex = 3;
        }

        /*
         * TODO:
         * 1. Timestamp, how long(i.e the primes took to generate / How many primes were generated)
         */

        private void smallPrimesTabPage_Enter(object sender, EventArgs e) {
            this.Height = 327;
            if(Primes.PrimeCount != 0) {
                toolStripStatusLabel1.Text = " Primes found: " + Primes.PrimeCount.ToString();
            } else {
                toolStripStatusLabel1.Text = "";
            }
        }

        private void generatePrimesButton_Click(object sender, EventArgs e) {
            try {
                if(string.IsNullOrEmpty(numOfPrimesTextBox.Text)) {
                    MessageBox.Show("Number of primes field is empty, enter the number of primes to generate", "Empty Field");
                } else if((Int32.Parse(numOfPrimesTextBox.Text) > 2) && (Int32.Parse(numOfPrimesTextBox.Text) <= 1000000)) {
                    primeListTextBox.Enabled = true;
                    resetButton1.Enabled = true;
                    primeListTextBox.BackColor = Color.White;
                    
                    primeListTextBox.Text = Primes.GeneratePrimeList(Int32.Parse(numOfPrimesTextBox.Text));
                    toolStripStatusLabel1.Text = " Primes found: " + Primes.PrimeCount.ToString();
                } else if(!(Int32.Parse(numOfPrimesTextBox.Text) >= 2) || !(Int32.Parse(numOfPrimesTextBox.Text) <= 1000000)) {
                    MessageBox.Show("Prime number range must be between 2 and 1,000,000", "Input: " + numOfPrimesTextBox.Text);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetButton1_Click(object sender, EventArgs e) {
            primeListTextBox.Text = "";
            primeListTextBox.BackColor = Control.DefaultBackColor;
            primeListTextBox.Enabled = false;

            numOfPrimesTextBox.Text = "200";
            resetButton1.Enabled = false;

            Primes.PrimeCount = 0;
            toolStripStatusLabel1.Text = "";
        }

        private void numOfPrimesTextBox_TextChanged(object sender, EventArgs e) {
            resetButton1.Enabled = true;
        }


        private void pseudorandomPrimeTabPage_Enter(object sender, EventArgs e) {
            if(this.Height != 327) this.Height = 327;

            if(!primeTextBox.Enabled) {
                toolStripStatusLabel1.Text = "";
            } else {
                toolStripStatusLabel1.Text = "Prime Generated";
            }
            
        }


        private void generatePseudoPrimeButton_Click(object sender, EventArgs e) {
            try {
                toolStripStatusLabel1.Text = "Generating Prime...";
                backgroundWorker2.RunWorkerAsync(bitLengthComboBox.SelectedItem);
                cancelButton.Enabled = true;

                primeTextBox.Enabled = true;
                primeTextBox.BackColor = Color.White;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = Primes.GenerateLargePseudoPrime(UInt16.Parse(e.Argument.ToString()), bw);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            toolStripStatusLabel1.Text = "Prime Generated";
            cancelButton.Enabled = false;
            resetButton2.Enabled = true;
            primeTextBox.Text = e.Result.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            backgroundWorker2.CancelAsync();
            primeTextBox.Text = "";
            primeTextBox.Enabled = false;
            primeTextBox.BackColor = Control.DefaultBackColor;
            resetButton2.Enabled = false;
        }

        private void resetButton2_Click(object sender, EventArgs e) {
            primeTextBox.Text = "";
            primeTextBox.Enabled = false;
            primeTextBox.BackColor = Control.DefaultBackColor;
            bitLengthComboBox.SelectedIndex = 3;
            resetButton2.Enabled = false;
            toolStripStatusLabel1.Text = "";

        }

        private void primalityTestTabPage_Enter(object sender, EventArgs e) {
            this.Height = 237;
            toolStripStatusLabel1.Text = "";
        }

        private void testPrimeButton_Click(object sender, EventArgs e) {
            try {
                if(!(string.Compare(isPrimeTextBox.Text, " e.g 331163628450422933897854183047337139561") == 0) && !(string.IsNullOrEmpty(isPrimeTextBox.Text))) {
                    ulong b = UInt64.Parse(isPrimeTextBox.Text);
                    ulong limit = UInt64.MaxValue;
                    if((b >= 3) && (b <= limit)) {
                        backgroundWorker3.RunWorkerAsync(isPrimeTextBox.Text);
                        cancelButton2.Enabled = true;
                    } else if(!(b >= 3)) {
                        MessageBox.Show("Input range must be between 3 and " + UInt64.MaxValue, "Invalid Input");
                    }
                } else {
                    MessageBox.Show("Input field empty, enter a prime you wish to test", "No Input");
                }
            } catch(FormatException) {
                MessageBox.Show("Input field must be a valid whole number", "Invalid Input");
            } catch(OverflowException) {
                MessageBox.Show("Input range must be between 3 and " + UInt64.MaxValue, "Invalid Input");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = Primes.IsPrime(e.Argument.ToString(), bw);
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            isPrimeResultLabel.Text = (Boolean.Parse(e.Result.ToString()) ? "Yes" : "No");
            cancelButton2.Enabled = false;
            resetButton3.Enabled = true;
        }

        private void cancelButton2_Click(object sender, EventArgs e) {
            backgroundWorker3.CancelAsync();
            cancelButton2.Enabled = false;
        }

        private void resetButton3_Click(object sender, EventArgs e) {
            isPrimeTextBox.ForeColor = Color.Gray;
            isPrimeTextBox.Text = " e.g 331163628450422933897854183047337139561";
            isPrimeResultLabel.Text = "    ";
            cancelButton2.Enabled = false;
            resetButton3.Enabled = false;
        }

        private void isPrimeTextBox_Enter(object sender, EventArgs e) {
            if(string.Compare(isPrimeTextBox.Text, " e.g 331163628450422933897854183047337139561") == 0) {
                isPrimeTextBox.ForeColor = Color.Black;
                isPrimeTextBox.Text = "";
            }
        }

        private void isPrimeTextBox_TextChanged(object sender, EventArgs e) {
            resetButton3.Enabled = true;
        }
    }
}
