using CountersFactory.bus;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;

namespace CountersFactory
{
    public partial class Form1 : Form
    {
        //declare and create 3 lists
        List<Counter>? listOfCounters = new List<Counter>();
        List<StepCounter>? listOfStepCounters = new List<StepCounter>();
        List<ModuloNCounter>? listOfModuloNCounters = new List<ModuloNCounter>();

        //declare 3 instances (3 objects or 3 references variables)
        Counter currentCounter;
        StepCounter currentStepCounter;
        ModuloNCounter currentModuloNCounter;

        //declare an instance of the date class (an object of the datatype)
        Date currentMadeDate;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //variables declaration
            int serialNumber;
            int value;
            int currentDay, currentMonth, currentYear;

            try
            {
                currentMadeDate = new Date();

                //counter type 
                EnumCounterType currentCounterType;
                Enum.TryParse(this.comboBoxCounterType.Text, out currentCounterType);

                //color
                EnumColor currentColor;
                Enum.TryParse(this.comboBoxColor.Text, out currentColor);

                //serial number and values
                serialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                value = Convert.ToInt32(this.textBoxValue.Text);

                //Made date
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);

                currentMadeDate.Day = currentDay;
                currentMadeDate.Month = currentMonth;
                currentMadeDate.Year = currentYear;

                //steps and maxlimit
                if (currentCounterType == EnumCounterType.StepCounter)
                {
                    currentStepCounter = new StepCounter();

                    currentStepCounter.Type = currentCounterType;
                    currentStepCounter.SerialNumber = serialNumber;
                    currentStepCounter.Value = value;
                    currentStepCounter.Color = currentColor;
                    currentStepCounter.MadeDate = currentMadeDate;

                    try
                    {
                        currentStepCounter.Steps = Convert.ToInt32(this.textBoxSteps.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.GetCounterList() != null)
                    {
                        DataCollection.Add(currentStepCounter);
                    }
                }

                else if (currentCounterType == EnumCounterType.ModuloNCounter)
                {
                    currentModuloNCounter = new ModuloNCounter();

                    currentModuloNCounter.Type = currentCounterType;
                    currentModuloNCounter.SerialNumber = serialNumber;
                    currentModuloNCounter.Value = value;
                    currentModuloNCounter.Color = currentColor;
                    currentModuloNCounter.MadeDate = currentMadeDate;

                    try
                    {
                        currentModuloNCounter.MaxLimit = Convert.ToInt32(this.textBoxMaxLimit.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.ListOfCounters != null)
                    {
                        DataCollection.Add(currentModuloNCounter);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \t You must input a valid data");
                this.textBoxSerialNumber.Focus();
            }

            this.buttonAdd.Enabled = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.listBoxCounters.Items.Clear();

            if (DataCollection.GetCounterList != null && DataCollection.GetCounterList().Count > 0 && this.listBoxCounters.Items.Count == 0)
            {
                foreach (Counter currentCounter in DataCollection.GetCounterList())
                {
                    if (currentCounter is StepCounter)
                    {
                        currentStepCounter = (StepCounter)currentCounter;

                        this.listBoxCounters.Items.Add(currentStepCounter.GetState());
                    }

                    else if (currentCounter is ModuloNCounter)
                    {
                        currentModuloNCounter = (ModuloNCounter)currentCounter;

                        this.listBoxCounters.Items.Add(currentModuloNCounter.GetState());
                    }
                }
            }

            else
            {
                MessageBox.Show("The list of counters are already printed in the listBox or the list of item in memory is empty...");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.comboBoxCounterType.Text = EnumCounterType.Undefined.ToString();

            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);

            this.textBoxSerialNumber.Text = string.Empty;
            this.textBoxValue.Text = string.Empty;

            this.textBoxDay.Text = string.Empty;
            this.textBoxMonth.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;

            this.textBoxSteps.Text = string.Empty;
            this.textBoxMaxLimit.Text = string.Empty;

            this.textBoxSteps.Enabled = true;
            this.textBoxMaxLimit.Enabled = true;

            this.textBoxSerialNumber.Focus();

            this.listBoxCounters.Items.Clear();

            this.buttonAdd.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Alvaro Limaymanta Soria", "Event Programming with C#",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Counter counterToSearch = null;

            StepCounter currentStepCounter;
            ModuloNCounter currentModuloNCounter;

            if (DataCollection.GetCounterList != null)
            {
                foreach (Counter currentCounter in DataCollection.GetCounterList())
                {
                    if (currentCounter.SerialNumber == Convert.ToInt32(this.textBoxSerialNumber.Text))
                    {
                        found = true;
                        counterToSearch = currentCounter;
                        break;
                    }
                }
            }

            if (found)
            {
                if (counterToSearch.Type == EnumCounterType.StepCounter)
                {
                    currentStepCounter = (StepCounter)counterToSearch; // casting

                    MessageBox.Show("Counter found!" + currentStepCounter.GetState(),
                    "Evenet Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxCounters.Items.Add(currentStepCounter.GetState());
                }

                else if (counterToSearch.Type == EnumCounterType.ModuloNCounter)
                {
                    currentModuloNCounter = (ModuloNCounter)counterToSearch; // casting

                    MessageBox.Show("Counter found!" + currentModuloNCounter.GetState(),
                    "Evenet Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxCounters.Items.Add(currentModuloNCounter.GetState());
                }
            }

            else
            {
                MessageBox.Show("Item not found...",
                "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumColor counter in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(counter);
            }

            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);

            foreach (EnumCounterType counter in Enum.GetValues(typeof(EnumCounterType)))
            {
                this.comboBoxCounterType.Items.Add(counter);
            }

            this.comboBoxCounterType.Text = Convert.ToString(EnumCounterType.Undefined);
        }

        int currentIndex = -1;
        private void listBoxCounters_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = this.listBoxCounters.SelectedIndex;

            EnumCounterType currentCounterType;

            this.listOfCounters = DataCollection.GetCounterList();

            if (this.listOfCounters != null)
            {
                currentCounterType = this.listOfCounters[currentIndex].Type;

                this.comboBoxCounterType.Text = Convert.ToString(currentCounterType);

                if (currentIndex >= 0 && currentCounterType == EnumCounterType.StepCounter)
                {
                    StepCounter currentStepCounter = new StepCounter();

                    currentStepCounter = (StepCounter)this.listOfCounters[currentIndex];

                    this.textBoxSerialNumber.Text = currentStepCounter.SerialNumber.ToString();
                    this.textBoxValue.Text = currentStepCounter.Value.ToString();

                    this.comboBoxColor.Text = currentStepCounter.Color.ToString();

                    this.textBoxDay.Text = currentStepCounter.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentStepCounter.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentStepCounter.MadeDate.Year.ToString();

                    this.textBoxSteps.Text = currentStepCounter.Steps.ToString();
                }

                else if (currentIndex >= 0 && currentCounterType == EnumCounterType.ModuloNCounter)
                {
                    ModuloNCounter currentModuloNCounter = new ModuloNCounter();

                    currentModuloNCounter = (ModuloNCounter)this.listOfCounters[currentIndex];

                    this.textBoxSerialNumber.Text = currentModuloNCounter.SerialNumber.ToString();
                    this.textBoxValue.Text = currentModuloNCounter.Value.ToString();

                    this.comboBoxColor.Text = currentModuloNCounter.Color.ToString();

                    this.textBoxDay.Text = currentModuloNCounter.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentModuloNCounter.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentModuloNCounter.MadeDate.Year.ToString();

                    this.textBoxMaxLimit.Text = currentModuloNCounter.MaxLimit.ToString();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EnumCounterType currentCounterType;
            Enum.TryParse(this.comboBoxCounterType.Text, out currentCounterType);

            if (DataCollection.ListOfCounters != null && currentIndex >= 0 && currentIndex < DataCollection.ListOfCounters.Count) //if we do not select a counter the message will appear without errors
            {
                currentCounterType = DataCollection.ListOfCounters[currentIndex].Type;
            }

            if (currentIndex >= 0 && listOfCounters != null)
            {
                if (currentCounterType == EnumCounterType.StepCounter)
                {
                    StepCounter currentStepCounter = new StepCounter();

                    currentStepCounter.Type = currentCounterType;
                    currentStepCounter.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentStepCounter.Value = Convert.ToInt32(this.textBoxValue.Text);

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentStepCounter.Color = currentColor;

                    Date currentDate = new Date();
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentStepCounter.MadeDate = currentDate;

                    currentStepCounter.Steps = Convert.ToInt32(this.textBoxSteps.Text);

                    //remove the step counter at the current index
                    DataCollection.RemoveAt(currentIndex);

                    //Insert the updated step counter at the currenIndex
                    DataCollection.InsertAt(currentIndex, currentStepCounter);
                }

                else if (currentCounterType == EnumCounterType.ModuloNCounter)
                {
                    ModuloNCounter currentModuloNCounter = new ModuloNCounter();

                    currentModuloNCounter.Type = currentCounterType;
                    currentModuloNCounter.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentModuloNCounter.Value = Convert.ToInt32(this.textBoxValue.Text);

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentModuloNCounter.Color = currentColor;

                    Date currentDate = new Date();
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentModuloNCounter.MadeDate = currentDate;

                    currentModuloNCounter.MaxLimit = Convert.ToInt32(this.textBoxMaxLimit.Text);

                    DataCollection.RemoveAt(currentIndex);
                    DataCollection.InsertAt(currentIndex, currentModuloNCounter);
                }
            }

            else
            {
                MessageBox.Show("Select from the listBox the item to Update");
            }
            this.listBoxCounters.Items.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && this.listOfCounters != null)
            {
                DataCollection.ListOfCounters.RemoveAt(currentIndex);
                MessageBox.Show("The selected item has been removed from the list of counters in memory");
                this.listBoxCounters.Items.Clear();
            }

            else
            {
                MessageBox.Show("Choose from the listBox the counter to Remove");
            }
            this.listBoxCounters.Items.Clear();
        }

        private void buttonWriteToXmlFile_Click(object sender, EventArgs e)
        {
            if (DataCollection.ListOfCounters != null)
            {
                FileManager.WriteToXmlFile(DataCollection.ListOfCounters);
            }
        }

        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {
            this.listOfCounters.Clear();

            DataCollection.ListOfCounters = FileManager.ReadFromXmlFile();

            if ((DataCollection.ListOfCounters = FileManager.ReadFromXmlFile()) != null)
            {
                foreach (Counter currentCounter in DataCollection.ListOfCounters)
                {
                    if (currentCounter is StepCounter)
                    {
                        currentStepCounter = (StepCounter)currentCounter;

                        this.listBoxCounters.Items.Add(currentStepCounter.GetState());
                    }

                    else if (currentCounter is ModuloNCounter)
                    {
                        currentModuloNCounter = (ModuloNCounter)currentCounter;

                        this.listBoxCounters.Items.Add(currentModuloNCounter.GetState());
                    }
                }
            }
        }

        private void comboBoxCounterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumCounterType currentCounterType;

            Enum.TryParse(this.comboBoxCounterType.Text, out currentCounterType);

            if (currentCounterType == EnumCounterType.StepCounter)
            {
                this.textBoxSteps.Enabled = true;
                this.textBoxMaxLimit.Enabled = false;
            }

            else if (currentCounterType == EnumCounterType.ModuloNCounter)
            {
                this.textBoxSteps.Enabled = false;
                this.textBoxMaxLimit.Enabled = true;
            }

            else if (currentCounterType == EnumCounterType.Undefined)
            {
                this.textBoxSteps.Enabled = false;
                this.textBoxMaxLimit.Enabled = false;
            }
        }

        private void buttonPrintStepCounter_Click(object sender, EventArgs e)
        {
            this.listBoxCounters.Items.Clear();

            foreach (StepCounter currentStepCounter in DataCollection.GetStepCounterList())
            {
                this.listBoxCounters.Items.Add(currentStepCounter.GetState());
            }
        }

        private void buttonPrintModuloNCounter_Click(object sender, EventArgs e)
        {
            this.listBoxCounters.Items.Clear();

            foreach (ModuloNCounter currentModuloNCounter in DataCollection.GetModuloNCountersList())
            {
                this.listBoxCounters.Items.Add(currentModuloNCounter.GetState());
            }
        }
    }
}