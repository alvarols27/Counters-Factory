namespace CountersFactory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelSteps = new Label();
            labelMaxLimit = new Label();
            textBoxSteps = new TextBox();
            labelMadeDate = new Label();
            textBoxYear = new TextBox();
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            labelYear = new Label();
            labelDay = new Label();
            labelMonth = new Label();
            buttonDelete = new Button();
            labelDelete = new Label();
            buttonUpdate = new Button();
            labelUpdate = new Label();
            labelSearch = new Label();
            buttonSearch = new Button();
            textBoxMaxLimit = new TextBox();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonPrint = new Button();
            buttonAdd = new Button();
            buttonPrintModuloNCounter = new Button();
            buttonPrintStepCounter = new Button();
            listBoxCounters = new ListBox();
            buttonReadFromXmlFile = new Button();
            buttonWriteToXmlFile = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            groupBoxMadeDate = new GroupBox();
            StepCounterFeature = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxValue = new TextBox();
            textBoxSerialNumber = new TextBox();
            comboBoxColor = new ComboBox();
            comboBoxCounterType = new ComboBox();
            labelValue = new Label();
            labelSerialNumber = new Label();
            labelCounterType = new Label();
            labelColor = new Label();
            groupBoxCounterInfo = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBoxMadeDate.SuspendLayout();
            StepCounterFeature.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxCounterInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelSteps
            // 
            labelSteps.BackColor = Color.Transparent;
            labelSteps.BorderStyle = BorderStyle.Fixed3D;
            labelSteps.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSteps.ForeColor = Color.Black;
            labelSteps.Location = new Point(15, 47);
            labelSteps.Name = "labelSteps";
            labelSteps.Size = new Size(152, 46);
            labelSteps.TabIndex = 8;
            labelSteps.Text = "Steps?";
            labelSteps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMaxLimit
            // 
            labelMaxLimit.BackColor = Color.Transparent;
            labelMaxLimit.BorderStyle = BorderStyle.Fixed3D;
            labelMaxLimit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelMaxLimit.ForeColor = Color.Black;
            labelMaxLimit.Location = new Point(22, 51);
            labelMaxLimit.Name = "labelMaxLimit";
            labelMaxLimit.Size = new Size(152, 46);
            labelMaxLimit.TabIndex = 9;
            labelMaxLimit.Text = "Max Limit?";
            labelMaxLimit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSteps
            // 
            textBoxSteps.Location = new Point(189, 54);
            textBoxSteps.Name = "textBoxSteps";
            textBoxSteps.Size = new Size(141, 35);
            textBoxSteps.TabIndex = 10;
            // 
            // labelMadeDate
            // 
            labelMadeDate.AutoSize = true;
            labelMadeDate.BackColor = Color.Transparent;
            labelMadeDate.BorderStyle = BorderStyle.Fixed3D;
            labelMadeDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelMadeDate.ForeColor = Color.Black;
            labelMadeDate.Location = new Point(81, 63);
            labelMadeDate.Margin = new Padding(5, 0, 5, 0);
            labelMadeDate.Name = "labelMadeDate";
            labelMadeDate.Size = new Size(177, 40);
            labelMadeDate.TabIndex = 13;
            labelMadeDate.Text = "Made Date?";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(154, 228);
            textBoxYear.Margin = new Padding(5, 6, 5, 6);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(169, 35);
            textBoxYear.TabIndex = 24;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(154, 139);
            textBoxDay.Margin = new Padding(5, 6, 5, 6);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(169, 35);
            textBoxDay.TabIndex = 23;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(154, 184);
            textBoxMonth.Margin = new Padding(5, 6, 5, 6);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(169, 35);
            textBoxMonth.TabIndex = 22;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelYear.ForeColor = Color.Black;
            labelYear.Location = new Point(57, 227);
            labelYear.Margin = new Padding(5, 0, 5, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(71, 32);
            labelYear.TabIndex = 21;
            labelYear.Text = "Year? ";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BackColor = Color.Transparent;
            labelDay.BorderStyle = BorderStyle.Fixed3D;
            labelDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDay.ForeColor = Color.Black;
            labelDay.Location = new Point(62, 142);
            labelDay.Margin = new Padding(5, 0, 5, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(67, 32);
            labelDay.TabIndex = 20;
            labelDay.Text = "Day? ";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BackColor = Color.Transparent;
            labelMonth.BorderStyle = BorderStyle.Fixed3D;
            labelMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMonth.ForeColor = Color.Black;
            labelMonth.Location = new Point(38, 184);
            labelMonth.Margin = new Padding(5, 0, 5, 0);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(91, 32);
            labelMonth.TabIndex = 19;
            labelMonth.Text = "Month?";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DimGray;
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Transparent;
            buttonDelete.Location = new Point(1166, 928);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 66);
            buttonDelete.TabIndex = 30;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelDelete
            // 
            labelDelete.BackColor = Color.Transparent;
            labelDelete.BorderStyle = BorderStyle.Fixed3D;
            labelDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelDelete.ForeColor = Color.Black;
            labelDelete.Location = new Point(1167, 867);
            labelDelete.Margin = new Padding(5, 0, 5, 0);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(585, 55);
            labelDelete.TabIndex = 29;
            labelDelete.Text = "Choose a counter to remove from the listBox";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DimGray;
            buttonUpdate.FlatAppearance.BorderColor = Color.Black;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Transparent;
            buttonUpdate.Location = new Point(1166, 760);
            buttonUpdate.Margin = new Padding(5, 6, 5, 6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(118, 66);
            buttonUpdate.TabIndex = 28;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelUpdate
            // 
            labelUpdate.BackColor = Color.Transparent;
            labelUpdate.BorderStyle = BorderStyle.Fixed3D;
            labelUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelUpdate.ForeColor = Color.Black;
            labelUpdate.Location = new Point(1166, 712);
            labelUpdate.Margin = new Padding(5, 0, 5, 0);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(585, 45);
            labelUpdate.TabIndex = 27;
            labelUpdate.Text = "Choose a counter to update from the listBox";
            labelUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.BackColor = Color.Transparent;
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(1167, 552);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(530, 55);
            labelSearch.TabIndex = 26;
            labelSearch.Text = "Search for a counter by the serial number";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DimGray;
            buttonSearch.FlatAppearance.BorderColor = Color.Black;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.Transparent;
            buttonSearch.Location = new Point(1166, 613);
            buttonSearch.Margin = new Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(118, 66);
            buttonSearch.TabIndex = 25;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxMaxLimit
            // 
            textBoxMaxLimit.Location = new Point(196, 58);
            textBoxMaxLimit.Name = "textBoxMaxLimit";
            textBoxMaxLimit.Size = new Size(141, 35);
            textBoxMaxLimit.TabIndex = 31;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DimGray;
            buttonExit.FlatAppearance.BorderColor = Color.Black;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonExit.ForeColor = Color.Transparent;
            buttonExit.Location = new Point(1797, 923);
            buttonExit.Margin = new Padding(5, 6, 5, 6);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(118, 102);
            buttonExit.TabIndex = 32;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.DimGray;
            buttonReset.FlatAppearance.BorderColor = Color.Black;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReset.ForeColor = Color.Transparent;
            buttonReset.Location = new Point(952, 881);
            buttonReset.Margin = new Padding(5, 6, 5, 6);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(118, 70);
            buttonReset.TabIndex = 35;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.DimGray;
            buttonPrint.FlatAppearance.BorderColor = Color.Black;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrint.ForeColor = Color.Transparent;
            buttonPrint.Location = new Point(35, 39);
            buttonPrint.Margin = new Padding(5, 6, 5, 6);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(118, 70);
            buttonPrint.TabIndex = 34;
            buttonPrint.Text = "PRINT Counters";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DimGray;
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.Transparent;
            buttonAdd.Location = new Point(39, 597);
            buttonAdd.Margin = new Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 70);
            buttonAdd.TabIndex = 33;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPrintModuloNCounter
            // 
            buttonPrintModuloNCounter.BackColor = Color.DimGray;
            buttonPrintModuloNCounter.FlatAppearance.BorderColor = Color.Black;
            buttonPrintModuloNCounter.FlatAppearance.BorderSize = 0;
            buttonPrintModuloNCounter.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            buttonPrintModuloNCounter.ForeColor = Color.Transparent;
            buttonPrintModuloNCounter.Location = new Point(348, 39);
            buttonPrintModuloNCounter.Margin = new Padding(5, 6, 5, 6);
            buttonPrintModuloNCounter.Name = "buttonPrintModuloNCounter";
            buttonPrintModuloNCounter.Size = new Size(180, 70);
            buttonPrintModuloNCounter.TabIndex = 37;
            buttonPrintModuloNCounter.Text = "PRINT ModuloN Counters";
            buttonPrintModuloNCounter.UseVisualStyleBackColor = false;
            buttonPrintModuloNCounter.Click += buttonPrintModuloNCounter_Click;
            // 
            // buttonPrintStepCounter
            // 
            buttonPrintStepCounter.BackColor = Color.DimGray;
            buttonPrintStepCounter.FlatAppearance.BorderColor = Color.Black;
            buttonPrintStepCounter.FlatAppearance.BorderSize = 0;
            buttonPrintStepCounter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintStepCounter.ForeColor = Color.Transparent;
            buttonPrintStepCounter.Location = new Point(163, 39);
            buttonPrintStepCounter.Margin = new Padding(5, 6, 5, 6);
            buttonPrintStepCounter.Name = "buttonPrintStepCounter";
            buttonPrintStepCounter.Size = new Size(175, 70);
            buttonPrintStepCounter.TabIndex = 36;
            buttonPrintStepCounter.Text = "PRINT Step Counters";
            buttonPrintStepCounter.UseVisualStyleBackColor = false;
            buttonPrintStepCounter.Click += buttonPrintStepCounter_Click;
            // 
            // listBoxCounters
            // 
            listBoxCounters.BackColor = Color.White;
            listBoxCounters.Font = new Font("Segoe UI", 10F);
            listBoxCounters.ForeColor = Color.Black;
            listBoxCounters.FormattingEnabled = true;
            listBoxCounters.ItemHeight = 31;
            listBoxCounters.Location = new Point(41, 679);
            listBoxCounters.Margin = new Padding(5, 6, 5, 6);
            listBoxCounters.Name = "listBoxCounters";
            listBoxCounters.Size = new Size(1029, 190);
            listBoxCounters.TabIndex = 38;
            listBoxCounters.SelectedIndexChanged += listBoxCounters_SelectedIndexChanged;
            // 
            // buttonReadFromXmlFile
            // 
            buttonReadFromXmlFile.BackColor = Color.DimGray;
            buttonReadFromXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonReadFromXmlFile.FlatAppearance.BorderSize = 0;
            buttonReadFromXmlFile.ForeColor = Color.Transparent;
            buttonReadFromXmlFile.Location = new Point(260, 45);
            buttonReadFromXmlFile.Margin = new Padding(5, 6, 5, 6);
            buttonReadFromXmlFile.Name = "buttonReadFromXmlFile";
            buttonReadFromXmlFile.Size = new Size(206, 71);
            buttonReadFromXmlFile.TabIndex = 40;
            buttonReadFromXmlFile.Text = "Read Xml File";
            buttonReadFromXmlFile.UseVisualStyleBackColor = false;
            buttonReadFromXmlFile.Click += buttonReadFromXmlFile_Click;
            // 
            // buttonWriteToXmlFile
            // 
            buttonWriteToXmlFile.BackColor = Color.DimGray;
            buttonWriteToXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonWriteToXmlFile.FlatAppearance.BorderSize = 0;
            buttonWriteToXmlFile.ForeColor = Color.Transparent;
            buttonWriteToXmlFile.Location = new Point(68, 45);
            buttonWriteToXmlFile.Margin = new Padding(5, 6, 5, 6);
            buttonWriteToXmlFile.Name = "buttonWriteToXmlFile";
            buttonWriteToXmlFile.Size = new Size(182, 71);
            buttonWriteToXmlFile.TabIndex = 39;
            buttonWriteToXmlFile.Text = "Write Xml File";
            buttonWriteToXmlFile.UseVisualStyleBackColor = false;
            buttonWriteToXmlFile.Click += buttonWriteToXmlFile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 201);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 240);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 42;
            label1.Text = "Look at this ones!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1383, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 243);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1304, 68);
            label3.Name = "label3";
            label3.Size = new Size(401, 38);
            label3.TabIndex = 44;
            label3.Text = "We offer many types of counters";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(157, 349);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 224);
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(179, 309);
            label2.Name = "label2";
            label2.Size = new Size(294, 37);
            label2.TabIndex = 46;
            label2.Text = "Check out the best quality";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1662, 240);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 224);
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1678, 467);
            label4.Name = "label4";
            label4.Size = new Size(169, 37);
            label4.TabIndex = 48;
            label4.Text = "Like this one?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxMadeDate
            // 
            groupBoxMadeDate.Controls.Add(labelMadeDate);
            groupBoxMadeDate.Controls.Add(labelMonth);
            groupBoxMadeDate.Controls.Add(labelDay);
            groupBoxMadeDate.Controls.Add(labelYear);
            groupBoxMadeDate.Controls.Add(textBoxMonth);
            groupBoxMadeDate.Controls.Add(textBoxDay);
            groupBoxMadeDate.Controls.Add(textBoxYear);
            groupBoxMadeDate.Location = new Point(962, 12);
            groupBoxMadeDate.Name = "groupBoxMadeDate";
            groupBoxMadeDate.Size = new Size(350, 312);
            groupBoxMadeDate.TabIndex = 49;
            groupBoxMadeDate.TabStop = false;
            groupBoxMadeDate.Text = "Made Date";
            // 
            // StepCounterFeature
            // 
            StepCounterFeature.Controls.Add(labelSteps);
            StepCounterFeature.Controls.Add(textBoxSteps);
            StepCounterFeature.Location = new Point(617, 365);
            StepCounterFeature.Name = "StepCounterFeature";
            StepCounterFeature.Size = new Size(350, 118);
            StepCounterFeature.TabIndex = 50;
            StepCounterFeature.TabStop = false;
            StepCounterFeature.Text = "Step Counter Feature";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonWriteToXmlFile);
            groupBox1.Controls.Add(buttonReadFromXmlFile);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(43, 878);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 147);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serialize/Deserialize XMI File";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(260, 158);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(212, 35);
            textBoxValue.TabIndex = 7;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(260, 110);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(212, 35);
            textBoxSerialNumber.TabIndex = 6;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(260, 206);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(212, 38);
            comboBoxColor.TabIndex = 5;
            // 
            // comboBoxCounterType
            // 
            comboBoxCounterType.FormattingEnabled = true;
            comboBoxCounterType.Location = new Point(260, 58);
            comboBoxCounterType.Name = "comboBoxCounterType";
            comboBoxCounterType.Size = new Size(212, 38);
            comboBoxCounterType.TabIndex = 4;
            comboBoxCounterType.SelectedIndexChanged += comboBoxCounterType_SelectedIndexChanged;
            // 
            // labelValue
            // 
            labelValue.BackColor = Color.Transparent;
            labelValue.BorderStyle = BorderStyle.Fixed3D;
            labelValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelValue.ForeColor = Color.Black;
            labelValue.Location = new Point(25, 152);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(212, 52);
            labelValue.TabIndex = 2;
            labelValue.Text = "Value?";
            labelValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.BackColor = Color.Transparent;
            labelSerialNumber.BorderStyle = BorderStyle.Fixed3D;
            labelSerialNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSerialNumber.ForeColor = Color.Black;
            labelSerialNumber.Location = new Point(25, 100);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(212, 52);
            labelSerialNumber.TabIndex = 1;
            labelSerialNumber.Text = "Serial Number?";
            labelSerialNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCounterType
            // 
            labelCounterType.BackColor = Color.Transparent;
            labelCounterType.BorderStyle = BorderStyle.Fixed3D;
            labelCounterType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelCounterType.ForeColor = Color.Black;
            labelCounterType.Location = new Point(25, 48);
            labelCounterType.Name = "labelCounterType";
            labelCounterType.Size = new Size(212, 52);
            labelCounterType.TabIndex = 0;
            labelCounterType.Text = "Counter Type?";
            labelCounterType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelColor
            // 
            labelColor.BackColor = Color.Transparent;
            labelColor.BorderStyle = BorderStyle.Fixed3D;
            labelColor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelColor.ForeColor = Color.Black;
            labelColor.Location = new Point(25, 200);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(212, 52);
            labelColor.TabIndex = 3;
            labelColor.Text = "Color?";
            labelColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxCounterInfo
            // 
            groupBoxCounterInfo.Controls.Add(labelColor);
            groupBoxCounterInfo.Controls.Add(labelCounterType);
            groupBoxCounterInfo.Controls.Add(labelSerialNumber);
            groupBoxCounterInfo.Controls.Add(labelValue);
            groupBoxCounterInfo.Controls.Add(comboBoxCounterType);
            groupBoxCounterInfo.Controls.Add(comboBoxColor);
            groupBoxCounterInfo.Controls.Add(textBoxSerialNumber);
            groupBoxCounterInfo.Controls.Add(textBoxValue);
            groupBoxCounterInfo.Location = new Point(374, 12);
            groupBoxCounterInfo.Name = "groupBoxCounterInfo";
            groupBoxCounterInfo.Size = new Size(542, 277);
            groupBoxCounterInfo.TabIndex = 51;
            groupBoxCounterInfo.TabStop = false;
            groupBoxCounterInfo.Text = "Counter Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelMaxLimit);
            groupBox2.Controls.Add(textBoxMaxLimit);
            groupBox2.Location = new Point(1000, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 118);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "ModuloNCounter Feature";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonPrintStepCounter);
            groupBox3.Controls.Add(buttonPrint);
            groupBox3.Controls.Add(buttonPrintModuloNCounter);
            groupBox3.Location = new Point(518, 538);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(552, 132);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Text = "Printing Counters";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1923, 1036);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCounterInfo);
            Controls.Add(StepCounterFeature);
            Controls.Add(groupBoxMadeDate);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxCounters);
            Controls.Add(buttonReset);
            Controls.Add(buttonAdd);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(labelDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(labelUpdate);
            Controls.Add(labelSearch);
            Controls.Add(buttonSearch);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Alvaro Limaymanta Soria - 202311145";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBoxMadeDate.ResumeLayout(false);
            groupBoxMadeDate.PerformLayout();
            StepCounterFeature.ResumeLayout(false);
            StepCounterFeature.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBoxCounterInfo.ResumeLayout(false);
            groupBoxCounterInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelSteps;
        private Label labelMaxLimit;
        private TextBox textBoxSteps;
        private Label labelMadeDate;
        private TextBox textBoxYear;
        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private Label labelYear;
        private Label labelDay;
        private Label labelMonth;
        private Button buttonDelete;
        private Label labelDelete;
        private Button buttonUpdate;
        private Label labelUpdate;
        private Label labelSearch;
        private Button buttonSearch;
        private TextBox textBoxMaxLimit;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonPrint;
        private Button buttonAdd;
        private Button buttonPrintModuloNCounter;
        private Button buttonPrintStepCounter;
        private ListBox listBoxCounters;
        private Button buttonReadFromXmlFile;
        private Button buttonWriteToXmlFile;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label4;
        private GroupBox groupBoxMadeDate;
        private GroupBox StepCounterFeature;
        private GroupBox groupBox1;
        private TextBox textBoxValue;
        private TextBox textBoxSerialNumber;
        private ComboBox comboBoxColor;
        private ComboBox comboBoxCounterType;
        private Label labelValue;
        private Label labelSerialNumber;
        private Label labelCounterType;
        private Label labelColor;
        private GroupBox groupBoxCounterInfo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
