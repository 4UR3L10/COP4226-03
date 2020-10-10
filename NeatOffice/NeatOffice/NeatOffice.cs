using PA3Draft;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeatOffice
{
    public partial class NeatOffice : Form
    {
        /**********************************/
        /* Constructor                    */
        /**********************************/
        /*
            Initialize the form, it makes the
            textBox read-only and empty.
        */
        public NeatOffice()
        {
            // Initialization.
            InitializeComponent();
            textBoxCalcScreen.ReadOnly = true; 
            textBoxCalcScreen.Text = String.Empty;           
            graphAlObj = new GraphAlgorithms(toolStripProgressBar, toolStripStatusLabelReady, statusStripProgressBar);
        }

        /**********************************/
        /* Class Variables                */
        /**********************************/
        public static string answer = String.Empty;
        public static ArrayList calculatorHistory = new ArrayList();
        GraphAlgorithms graphAlObj;

        /**********************************/
        /* Numbers                        */
        /**********************************/
        /*
            Writes the proper number into
            the textbox (Calculator Screen).
        */
        private void ButtonNumberOne_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "1";
        }

        private void ButtonNumberTwo_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "2";
        }

        private void ButtonNumberThree_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "3";
        }

        private void ButtonNumberFour_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "4";
        }

        private void ButtonNumberFive_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "5";
        }

        private void ButtonNumberSix_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "6";
        }

        private void ButtonNumberSeven_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "7";
        }

        private void ButtonNumberEight_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "8";
        }

        private void ButtonNumberNine_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "9";
        }

        private void ButtonNumberZero_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "0";
        }

        /**********************************/
        /* Binary Operators               */
        /**********************************/
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "+";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "-";
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "*";
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "/";
        }

        private void ToolStripLeftButtonXToY_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += " ^ ";
        }

        /**********************************/
        /* Unary Operators                */
        /**********************************/
        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "sqrt("; // LIKE PROFESSOR.
        }

        private void ButtonPowerTwo_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += " ^2 "; // LIKE PROFESSOR.
        }

        private void ButtonPercentage_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "%("; // IMPLEMENT, LIKE PROFESSOR.
        }

        private void ButtonOneOver_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "(1/"; // LIKE PROFESSOR.
        }

        private void ButtonSignChange_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "-"; // IMPLEMENT, LIKE PROFESSOR. 
        }

        /**********************************/
        /* Unary Functions                */
        /**********************************/
        private void ToolStripLeftButtonLog_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "log(";
        }
        private void ToolStripLeftButtonSin_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "sin(";
        }

        private void ToolStripLeftButtonCos_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "cos(";
        }

        private void ToolStripLeftButtonTan_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "tan(";
        }

        /**********************************/
        /* Other Functions                */
        /**********************************/
        private void ButtonPeriod_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += ".";
        }

        private void ButtonOpenParenthesis_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += "(";
        }

        private void ButtonCloseParenthesis_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += ")";
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            // Try to delete the last char of the string.            
            if (textBoxCalcScreen.Text.Length > 0)
            {
                textBoxCalcScreen.Text = textBoxCalcScreen.Text.Remove(textBoxCalcScreen.Text.Length - 1, 1);
            }
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text = answer = String.Empty;
            textBoxCalcScreen.Text = "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text = "";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            // Compute the calculations.
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = RPN.Calculate(textBoxCalcScreen.Text).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            // In case of an error.
            catch (MyException ex)
            {
                textBoxCalcScreen.Text = ex.type;
            }
        }

        /**********************************/
        /* History                        */
        /**********************************/
        // Clear History.
        private void ToolStripLeftButtonDelete_Click(object sender, EventArgs e)
        {
            calculatorHistory.Clear();
        }

        // Save History.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Save the order info to a file using Save Dialog.  
            SaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFile.FileName = "Calculator_History";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputFile = new StreamWriter(SaveFile.OpenFile());
                foreach (String Calculation in calculatorHistory)
                {
                    outputFile.WriteLine(Calculation);
                }
                outputFile.Dispose();
                outputFile.Close();
            }
            else
            {
                // Cancel Button.
            }
        }

        // Load History.
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            // File Dialog properties setup.
            OpenFile.FileName = "Calculator_History";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                // Declare a StreamReader variable.
                StreamReader inputFile;
                inputFile = File.OpenText(OpenFile.FileName);

                // Filetype Validation.
                if (!OpenFile.ToString().Contains(".txt"))
                {
                    MessageBox.Show("That is not a (.txt) file!!!");
                }
                else
                {
                    // Load Calculator History File.
                    if (calculatorHistory.Count == 0)
                    {
                        // Read an item from the file.
                        // Process the item.
                        while (!inputFile.EndOfStream)
                        {
                            // Add the country name to the ListBox.
                            calculatorHistory.Add(inputFile.ReadLine());
                        }
                    }
                    // Calculator History is not empty.
                    else
                    {
                        var result = MessageBox.Show("There is history in the calculator, Are you sure that you want to rewrite it?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // Same LOGIC AS == 0
                            calculatorHistory.Clear();

                            // Read an item from the file.
                            // Process the item.
                            while (!inputFile.EndOfStream)
                            {
                                // Add the country name to the ListBox.
                                calculatorHistory.Add(inputFile.ReadLine());
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                // Close the file.
                inputFile.Close();
            }
            else
            {
                // Cancel Button.
            }
        }


        // Print History.
        private void ToolStripLeftButtonPrint_Click(object sender, EventArgs e)
        {
            PrintFile.Document = PrintDocument;
            PrintFile.AllowSelection = true;
            PrintFile.AllowSomePages = true;

            if (PrintFile.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
        }

        // Print History Setup. 
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String tempFile = "";

            foreach (String Calculation in calculatorHistory)
            {
                tempFile = tempFile + Calculation + "\n";
            }

            e.Graphics.DrawString(tempFile, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(130, 130));
        }

        // Exit Menu.
        private void StripMenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripDropDownButtonTop_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePickerFrom.Text);
            DateTime todate = Convert.ToDateTime(dateTimePickerTo.Text);
            TimeSpan ts = todate.Subtract(fromdate);
            int days = Convert.ToInt16(ts.Days);
            numericUpDownDays.Value = days;
        }
        
        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerTo.Value = this.dateTimePickerFrom.Value.AddDays((double)numericUpDownDays.Value);
        }

        // Reading its matrix representation stored in a .txt file
        private void toolStripRightGraphTXT_Click(object sender, EventArgs e)
        {
            // File Dialog properties setup.
            OpenFile.FileName = "undirectedConnected";
            OpenFile.Filter = "txt files (*.txt)|*.txt";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                graphAlObj.ReadGraphFromTXTFile(OpenFile.FileName);
                ListBoxImport.Items.Add(OpenFile.FileName);
            }
            else
            {
                // Cancel Button.
            }
        }

        // Reading its matrix representation stored in a .csv file.
        private void toolStripRightCSV_Click(object sender, EventArgs e)
        {
            // File Dialog properties setup.
            OpenFile.FileName = "undirectedConnected";
            OpenFile.Filter = "csv files (*.csv)|*.csv";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                graphAlObj.ReadGraphFromCSVFile(OpenFile.FileName);
                ListBoxImport.Items.Add(OpenFile.FileName);
            }
            else
            {
                // Cancel Button.
            }
        }

        // Reading its matrix representation stored in a .txt or .csv files.
        // Finishhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh
        private void toolStripRightUnknown_Click(object sender, EventArgs e)
        {
            // File Dialog properties setup.
            OpenFile.FileName = "undirectedConnected";
            OpenFile.Multiselect = true;
            OpenFile.Filter = "all supported(*.csv,*.txt)|*.csv;*.txt|csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                // Filetype Validation.
                if (OpenFile.ToString().Contains(".txt"))
                {
                    graphAlObj.ReadGraphFromTXTFile(OpenFile.FileName);
                    ListBoxImport.Items.Add(OpenFile.FileName);
                }
                if (OpenFile.ToString().Contains(".csv"))
                {
                    graphAlObj.ReadGraphFromCSVFile(OpenFile.FileName);
                    ListBoxImport.Items.Add(OpenFile.FileName);
                }                
            }
            else
            {
                // Cancel Button.
            }
        }

        // Deletes a selected graph file from the list.
        private void toolStripRightCancel_Click(object sender, EventArgs e)
        {
            ListBoxImport.Items.Remove(ListBoxImport.SelectedItem);            
        }

        // Deletes all graph files from the list.
        private void toolStripRightDelete_Click(object sender, EventArgs e)
        {
            ListBoxImport.Items.Clear();
        }

        // Prim's Algorithm.
        // Validation WHEN NO SELECTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
        private void toolStripRightSaveMinimumSpanTree_Click(object sender, EventArgs e)
        {
            graphAlObj.GetMST(ListBoxImport.SelectedItem.ToString());
            ListBoxResults.Items.Add("MST: " + ListBoxImport.SelectedItem);           
        }

        // Dijkstra’s Algorithm.
        // Validation WHEN NO SELECTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
        private void toolStripRightSaveShortestPath_Click(object sender, EventArgs e)
        {
            graphAlObj.Dijkstra(ListBoxImport.SelectedItem.ToString());
            ListBoxResults.Items.Add("Shortest Paths: " + ListBoxImport.SelectedItem);
        }

        // Saving History 
        // FINISH SAVEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
        // Validation WHEN NO SELECTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
        private void toolStripRightSave_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                if(ListBoxImport.SelectedItem.ToString().Contains("MST:"))
                {
                    graphAlObj.WriteMSTSolutionTo(SaveFile.FileName, ListBoxImport.SelectedItem.ToString());
                    ListBoxImport.Items.Remove(ListBoxImport.SelectedItem);
                }
                if (ListBoxImport.SelectedItem.ToString().Contains("Shortest Paths:"))
                {
                    graphAlObj.WriteSSSPSolutionTo(SaveFile.OpenFile().ToString(), ListBoxImport.SelectedItem.ToString());
                    ListBoxImport.Items.Remove(ListBoxImport.SelectedItem);
                }
            }
            else
            {
                // Cancel Button.
            }
        }
    }
}
