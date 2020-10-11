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
            toolStripStatusLabelGoodDay.Text = "Good Day! Today is " + DateTime.Now.ToString();
        }

        /**********************************/
        /* Class Variables                */
        /**********************************/
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
            textBoxCalcScreen.Text += "^";
        }

        /**********************************/
        /* Unary Operators                */
        /**********************************/
        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Sqrt(Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ButtonPowerTwo_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Pow(Double.Parse(textBoxCalcScreen.Text), 2).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ButtonPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = (Double.Parse(textBoxCalcScreen.Text) / 100).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ButtonOneOver_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = (1 / Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ButtonSignChange_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = (-1 * Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        /**********************************/
        /* Unary Functions                */
        /**********************************/
        private void ToolStripLeftButtonLog_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Log(Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ToolStripLeftButtonSin_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Sin(Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ToolStripLeftButtonCos_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Cos(Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        private void ToolStripLeftButtonTan_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);
                textBoxCalcScreen.Text = Math.Tan(Double.Parse(textBoxCalcScreen.Text)).ToString();
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
            }
        }

        /**********************************/
        /* Other Functions                */
        /**********************************/
        private void ButtonPeriod_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text += ".";
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
            textBoxCalcScreen.Text = "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxCalcScreen.Text = "";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            // Initializing objects.
            DataTable oDataTable = new DataTable();
            var anyTypeResult = new object();

            // Compute the calculations.
            try
            {
                calculatorHistory.Add(textBoxCalcScreen.Text);

                if (textBoxCalcScreen.Text.Contains("^"))
                {
                    string temp = textBoxCalcScreen.Text;
                    string[] numbers = temp.Split('^');

                    textBoxCalcScreen.Text = Math.Pow(Double.Parse(numbers[0]), Double.Parse(numbers[1])).ToString();
                }
                else
                {
                    anyTypeResult = oDataTable.Compute(textBoxCalcScreen.Text, "");
                    textBoxCalcScreen.Text = anyTypeResult.ToString();
                }
               
                calculatorHistory.Add(textBoxCalcScreen.Text);
            }
            // In case of an error.
            catch (Exception)
            {
                MessageBox.Show("Check Your Input There Is Syntax Error");
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
            SaveFileCalculator.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileCalculator.FileName = "Calculator_History";

            if (SaveFileCalculator.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputFile = new StreamWriter(SaveFileCalculator.OpenFile());
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
            OpenFileCalculator.FileName = "Calculator_History";

            if (OpenFileCalculator.ShowDialog() == DialogResult.OK)
            {
                // Declare a StreamReader variable.
                StreamReader inputFile;
                inputFile = File.OpenText(OpenFileCalculator.FileName);

                // Filetype Validation.
                if (!OpenFileCalculator.ToString().Contains(".txt"))
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
            PrintFileCalculator.Document = PrintDocumentCalculator;
            PrintFileCalculator.AllowSelection = true;
            PrintFileCalculator.AllowSomePages = true;

            if (PrintFileCalculator.ShowDialog() == DialogResult.OK)
            {
                PrintDocumentCalculator.Print();
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
        
        /**********************************/
        /* Graphs Functions               */
        /**********************************/        
        // Reading its matrix representation stored in a .txt file
        private void toolStripRightGraphTXT_Click(object sender, EventArgs e)
        {
            // File Dialog properties setup.
            OpenFileGraph.FileName = "undirectedConnected";
            OpenFileGraph.Filter = "txt files (*.txt)|*.txt";

            if (OpenFileGraph.ShowDialog() == DialogResult.OK)
            {
                graphAlObj.ReadGraphFromTXTFile(OpenFileGraph.FileName);
                ListBoxImport.Items.Add(OpenFileGraph.FileName);
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
            OpenFileGraph.FileName = "undirectedConnected";
            OpenFileGraph.Filter = "csv files (*.csv)|*.csv";

            if (OpenFileGraph.ShowDialog() == DialogResult.OK)
            {
                graphAlObj.ReadGraphFromCSVFile(OpenFileGraph.FileName);
                ListBoxImport.Items.Add(OpenFileGraph.FileName);
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
            OpenFileGraph.FileName = "undirectedConnected";
            OpenFileGraph.Multiselect = true;
            OpenFileGraph.Filter = "all supported(*.csv,*.txt)|*.csv;*.txt|csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";

            if (OpenFileGraph.ShowDialog() == DialogResult.OK)
            {
                // Filetype Validation.
                if (OpenFileGraph.ToString().Contains(".txt"))
                {
                    graphAlObj.ReadGraphFromTXTFile(OpenFileGraph.FileName);
                    ListBoxImport.Items.Add(OpenFileGraph.FileName);
                }
                if (OpenFileGraph.ToString().Contains(".csv"))
                {
                    graphAlObj.ReadGraphFromCSVFile(OpenFileGraph.FileName);
                    ListBoxImport.Items.Add(OpenFileGraph.FileName);
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
            if (SaveFileGraph.ShowDialog() == DialogResult.OK)
            {
                if(ListBoxImport.SelectedItem.ToString().Contains("MST:"))
                {
                    graphAlObj.WriteMSTSolutionTo(SaveFileGraph.FileName, ListBoxImport.SelectedItem.ToString());
                    ListBoxImport.Items.Remove(ListBoxImport.SelectedItem);
                }
                if (ListBoxImport.SelectedItem.ToString().Contains("Shortest Paths:"))
                {
                    graphAlObj.WriteSSSPSolutionTo(SaveFileGraph.OpenFile().ToString(), ListBoxImport.SelectedItem.ToString());
                    ListBoxImport.Items.Remove(ListBoxImport.SelectedItem);
                }
            }
            else
            {
                // Cancel Button.
            }
        }

        /**********************************/
        /* WA Functions.                  */
        /**********************************/  
        /**
         * 1.- Exits Menu.
         */
        private void StripMenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * 1.- The dateTimePickerTo_CloseUp method receives two parameters
         * 2.- creates two variables of type Datetime
         * 3.- converts the values of the two variables to datetime type
         * 4.- calculates the total time substracting to and from date
         * 5.- declares a variable int and converts the value obtaines by calculating the totla time
         */
        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePickerFrom.Text);
            DateTime todate = Convert.ToDateTime(dateTimePickerTo.Text);
            TimeSpan ts = todate.Subtract(fromdate);
            int days = Convert.ToInt16(ts.Days);
            numericUpDownDays.Value = days;
        }
        
        /**
         * 1.- The Numeric_ValueChanged method receives two parameters
         * 2.- changes the values of datetimepickerto according to the user selection
         */
        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerTo.Value = this.dateTimePickerFrom.Value.AddDays((double)numericUpDownDays.Value);
        }

        /**
         * 1.- The BackgroundColorSelector_Click method receives two parameters
         * 2.- create a variable dr of type DialogResult and displays a message to the user.
         * 3.- compares if the value of of the declared variable is ok
         * 4.- if value equals ok , it changes he backcolor
         */
        private void BackgroundColorSelector_Click(object sender, EventArgs e)
        {
            DialogResult dr = BackgroundColorSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tableLayoutPanelCalculator.BackColor = BackgroundColorSelector.Color;
            }
        }
        
        /**
         * 1.- The DayCountertoolStripDropDown_Click method receives two parameters
         * 2.- create a variable dr of type DialogResult and displays a message to the user.
         * 3.- compares if the value of of the declared variable is ok
         * 4.- if value equals ok , it changes he backcolor
         */
        private void DayCountertoolStripDropDown_Click(object sender, EventArgs e)
        {
            DialogResult dr = BackgroundColorSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                splitContainerCalculatorandDayCounter.Panel2.BackColor = BackgroundColorSelector.Color;
            }
        }
        
        /**
         * 1.- The GraphSectiontoolStripDropDown_Click method receives two parameters
         * 2.- create a variable dr of type DialogResult and displays a message to the user.
         * 3.- compares if the value of of the declared variable is ok
         * 4.- if value equals ok , it changes he backcolor
         */
        private void GraphSectiontoolStripDropDown_Click(object sender, EventArgs e)
        {
            DialogResult dr = BackgroundColorSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                splitContainerInside.Panel2.BackColor = BackgroundColorSelector.Color;
            }
        }
        
        /**
         * 1.- The StripMenuAppearanceModifyCalculatorDisplayFont_Click method receives two parameters
         * 2.- create a variable dr of type DialogResult and displays a message to the user.
         * 3.- compares if the value of of the declared variable is ok
         * 4.- if value equals ok , it changes he backcolor
         */
        private void StripMenuAppearanceModifyCalculatorDisplayFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBoxCalcScreen.Font = fontSelector.Font;
            }
        }
        
        /**
         * 1.- The StripMenuAppearanceModifyBackgroundColor_Click method receives two parameters
         * 2.- create a variable dr of type DialogResult and displays a message to the user.
         * 3.- compares if the value of of the declared variable is ok
         * 4.- if value equals ok , it changes he backcolor
         */
        private void StripMenuAppearanceModifyBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = BackgroundColorSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tableLayoutPanelCalculator.BackColor = BackgroundColorSelector.Color;
                splitContainerCalculatorandDayCounter.Panel2.BackColor = BackgroundColorSelector.Color;
                splitContainerCalculatorandDayCounter.Panel1.BackColor = BackgroundColorSelector.Color;
                splitContainerInside.Panel2.BackColor = BackgroundColorSelector.Color;

            }
        }
    }
}
