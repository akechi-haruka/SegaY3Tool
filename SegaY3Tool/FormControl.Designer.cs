namespace SegaY3Tool;

partial class FormControl {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        menuStripMain = new System.Windows.Forms.MenuStrip();
        programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        boardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        availablePortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        setParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        playfieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        testResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        panelBoardControls = new System.Windows.Forms.Panel();
        groupBoxParameters = new System.Windows.Forms.GroupBox();
        buttonEditDebugMode = new System.Windows.Forms.Button();
        buttonEditCodeMax = new System.Windows.Forms.Button();
        buttonEditProcMode = new System.Windows.Forms.Button();
        buttonEditCardMode = new System.Windows.Forms.Button();
        buttonEditCardType = new System.Windows.Forms.Button();
        buttonEditClbMode = new System.Windows.Forms.Button();
        labelParamDebugMode = new System.Windows.Forms.Label();
        labelParamCodeMax = new System.Windows.Forms.Label();
        labelParamProcMode = new System.Windows.Forms.Label();
        labelParamCardMode = new System.Windows.Forms.Label();
        labelParamCardType = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        labelParamClb = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        labelFirmwareDate = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        labelCalibrationStatus = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        labelFirmwareId = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        labelStatus = new System.Windows.Forms.Label();
        labelTargetCode = new System.Windows.Forms.Label();
        labelFirmwareType = new System.Windows.Forms.Label();
        labelModelNumber = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        radioButtonModeCalibrate = new System.Windows.Forms.RadioButton();
        radioButtonModeFlashFirmware = new System.Windows.Forms.RadioButton();
        radioButtonModeLuminance = new System.Windows.Forms.RadioButton();
        radioButtonModeReadCards = new System.Windows.Forms.RadioButton();
        radioButtonModeIdle = new System.Windows.Forms.RadioButton();
        openFileDialogFirmware = new System.Windows.Forms.OpenFileDialog();
        menuStripMain.SuspendLayout();
        panelBoardControls.SuspendLayout();
        groupBoxParameters.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { programToolStripMenuItem, boardToolStripMenuItem, toolStripMenuItem1 });
        menuStripMain.Location = new System.Drawing.Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new System.Drawing.Size(592, 33);
        menuStripMain.TabIndex = 0;
        menuStripMain.Text = "menuStrip1";
        // 
        // programToolStripMenuItem
        // 
        programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
        programToolStripMenuItem.Name = "programToolStripMenuItem";
        programToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
        programToolStripMenuItem.Text = "Program";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // boardToolStripMenuItem
        // 
        boardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { connectToolStripMenuItem, actionsToolStripMenuItem, resetToolStripMenuItem, disconnectToolStripMenuItem });
        boardToolStripMenuItem.Name = "boardToolStripMenuItem";
        boardToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
        boardToolStripMenuItem.Text = "Board";
        boardToolStripMenuItem.Click += boardToolStripMenuItem_Click;
        // 
        // connectToolStripMenuItem
        // 
        connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { availablePortsToolStripMenuItem, toolStripSeparator1 });
        connectToolStripMenuItem.Name = "connectToolStripMenuItem";
        connectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        connectToolStripMenuItem.Text = "Connect";
        // 
        // availablePortsToolStripMenuItem
        // 
        availablePortsToolStripMenuItem.Enabled = false;
        availablePortsToolStripMenuItem.Name = "availablePortsToolStripMenuItem";
        availablePortsToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
        availablePortsToolStripMenuItem.Text = "Available Ports:";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
        // 
        // resetToolStripMenuItem
        // 
        resetToolStripMenuItem.Enabled = false;
        resetToolStripMenuItem.Name = "resetToolStripMenuItem";
        resetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        resetToolStripMenuItem.Text = "Reset";
        resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
        // 
        // disconnectToolStripMenuItem
        // 
        disconnectToolStripMenuItem.Enabled = false;
        disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
        disconnectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        disconnectToolStripMenuItem.Text = "Disconnect";
        disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
        // 
        // actionsToolStripMenuItem
        // 
        actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { setParametersToolStripMenuItem, testResetToolStripMenuItem });
        actionsToolStripMenuItem.Enabled = false;
        actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
        actionsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        actionsToolStripMenuItem.Text = "Actions";
        // 
        // setParametersToolStripMenuItem
        // 
        setParametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { playfieldToolStripMenuItem, printerToolStripMenuItem });
        setParametersToolStripMenuItem.Name = "setParametersToolStripMenuItem";
        setParametersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        setParametersToolStripMenuItem.Text = "Set Parameters";
        // 
        // playfieldToolStripMenuItem
        // 
        playfieldToolStripMenuItem.Name = "playfieldToolStripMenuItem";
        playfieldToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
        playfieldToolStripMenuItem.Text = "Playfield";
        playfieldToolStripMenuItem.Click += playfieldToolStripMenuItem_Click;
        // 
        // printerToolStripMenuItem
        // 
        printerToolStripMenuItem.Name = "printerToolStripMenuItem";
        printerToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
        printerToolStripMenuItem.Text = "Printer";
        printerToolStripMenuItem.Click += printerToolStripMenuItem_Click;
        // 
        // testResetToolStripMenuItem
        // 
        testResetToolStripMenuItem.Name = "testResetToolStripMenuItem";
        testResetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        testResetToolStripMenuItem.Text = "TestReset";
        testResetToolStripMenuItem.Click += testResetToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(36, 29);
        toolStripMenuItem1.Text = "?";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
        aboutToolStripMenuItem.Text = "About";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // panelBoardControls
        // 
        panelBoardControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panelBoardControls.Controls.Add(groupBoxParameters);
        panelBoardControls.Controls.Add(groupBox2);
        panelBoardControls.Controls.Add(groupBox1);
        panelBoardControls.Enabled = false;
        panelBoardControls.Location = new System.Drawing.Point(12, 36);
        panelBoardControls.Name = "panelBoardControls";
        panelBoardControls.Size = new System.Drawing.Size(568, 514);
        panelBoardControls.TabIndex = 1;
        // 
        // groupBoxParameters
        // 
        groupBoxParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBoxParameters.Controls.Add(buttonEditDebugMode);
        groupBoxParameters.Controls.Add(buttonEditCodeMax);
        groupBoxParameters.Controls.Add(buttonEditProcMode);
        groupBoxParameters.Controls.Add(buttonEditCardMode);
        groupBoxParameters.Controls.Add(buttonEditCardType);
        groupBoxParameters.Controls.Add(buttonEditClbMode);
        groupBoxParameters.Controls.Add(labelParamDebugMode);
        groupBoxParameters.Controls.Add(labelParamCodeMax);
        groupBoxParameters.Controls.Add(labelParamProcMode);
        groupBoxParameters.Controls.Add(labelParamCardMode);
        groupBoxParameters.Controls.Add(labelParamCardType);
        groupBoxParameters.Controls.Add(label13);
        groupBoxParameters.Controls.Add(label12);
        groupBoxParameters.Controls.Add(label11);
        groupBoxParameters.Controls.Add(label10);
        groupBoxParameters.Controls.Add(label8);
        groupBoxParameters.Controls.Add(labelParamClb);
        groupBoxParameters.Controls.Add(label9);
        groupBoxParameters.Location = new System.Drawing.Point(291, 220);
        groupBoxParameters.Name = "groupBoxParameters";
        groupBoxParameters.Size = new System.Drawing.Size(274, 291);
        groupBoxParameters.TabIndex = 7;
        groupBoxParameters.TabStop = false;
        groupBoxParameters.Text = "Parameters";
        // 
        // buttonEditDebugMode
        // 
        buttonEditDebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditDebugMode.AutoSize = true;
        buttonEditDebugMode.Location = new System.Drawing.Point(234, 232);
        buttonEditDebugMode.Name = "buttonEditDebugMode";
        buttonEditDebugMode.Size = new System.Drawing.Size(34, 35);
        buttonEditDebugMode.TabIndex = 22;
        buttonEditDebugMode.Text = "...";
        buttonEditDebugMode.UseVisualStyleBackColor = true;
        buttonEditDebugMode.Click += buttonEditDebugMode_Click;
        // 
        // buttonEditCodeMax
        // 
        buttonEditCodeMax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditCodeMax.AutoSize = true;
        buttonEditCodeMax.Location = new System.Drawing.Point(234, 191);
        buttonEditCodeMax.Name = "buttonEditCodeMax";
        buttonEditCodeMax.Size = new System.Drawing.Size(34, 35);
        buttonEditCodeMax.TabIndex = 21;
        buttonEditCodeMax.Text = "...";
        buttonEditCodeMax.UseVisualStyleBackColor = true;
        buttonEditCodeMax.Click += buttonEditCodeMax_Click;
        // 
        // buttonEditProcMode
        // 
        buttonEditProcMode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditProcMode.AutoSize = true;
        buttonEditProcMode.Location = new System.Drawing.Point(234, 150);
        buttonEditProcMode.Name = "buttonEditProcMode";
        buttonEditProcMode.Size = new System.Drawing.Size(34, 35);
        buttonEditProcMode.TabIndex = 20;
        buttonEditProcMode.Text = "...";
        buttonEditProcMode.UseVisualStyleBackColor = true;
        buttonEditProcMode.Click += buttonEditProcMode_Click;
        // 
        // buttonEditCardMode
        // 
        buttonEditCardMode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditCardMode.AutoSize = true;
        buttonEditCardMode.Location = new System.Drawing.Point(234, 109);
        buttonEditCardMode.Name = "buttonEditCardMode";
        buttonEditCardMode.Size = new System.Drawing.Size(34, 35);
        buttonEditCardMode.TabIndex = 19;
        buttonEditCardMode.Text = "...";
        buttonEditCardMode.UseVisualStyleBackColor = true;
        buttonEditCardMode.Click += buttonEditCardMode_Click;
        // 
        // buttonEditCardType
        // 
        buttonEditCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditCardType.AutoSize = true;
        buttonEditCardType.Location = new System.Drawing.Point(234, 68);
        buttonEditCardType.Name = "buttonEditCardType";
        buttonEditCardType.Size = new System.Drawing.Size(34, 35);
        buttonEditCardType.TabIndex = 18;
        buttonEditCardType.Text = "...";
        buttonEditCardType.UseVisualStyleBackColor = true;
        buttonEditCardType.Click += buttonEditCardType_Click;
        // 
        // buttonEditClbMode
        // 
        buttonEditClbMode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        buttonEditClbMode.AutoSize = true;
        buttonEditClbMode.Location = new System.Drawing.Point(234, 27);
        buttonEditClbMode.Name = "buttonEditClbMode";
        buttonEditClbMode.Size = new System.Drawing.Size(34, 35);
        buttonEditClbMode.TabIndex = 17;
        buttonEditClbMode.Text = "...";
        buttonEditClbMode.UseVisualStyleBackColor = true;
        buttonEditClbMode.Click += buttonEditClbMode_Click;
        // 
        // labelParamDebugMode
        // 
        labelParamDebugMode.AutoSize = true;
        labelParamDebugMode.Location = new System.Drawing.Point(146, 237);
        labelParamDebugMode.Name = "labelParamDebugMode";
        labelParamDebugMode.Size = new System.Drawing.Size(33, 25);
        labelParamDebugMode.TabIndex = 16;
        labelParamDebugMode.Text = "---";
        // 
        // labelParamCodeMax
        // 
        labelParamCodeMax.AutoSize = true;
        labelParamCodeMax.Location = new System.Drawing.Point(146, 196);
        labelParamCodeMax.Name = "labelParamCodeMax";
        labelParamCodeMax.Size = new System.Drawing.Size(33, 25);
        labelParamCodeMax.TabIndex = 15;
        labelParamCodeMax.Text = "---";
        // 
        // labelParamProcMode
        // 
        labelParamProcMode.AutoSize = true;
        labelParamProcMode.Location = new System.Drawing.Point(146, 155);
        labelParamProcMode.Name = "labelParamProcMode";
        labelParamProcMode.Size = new System.Drawing.Size(33, 25);
        labelParamProcMode.TabIndex = 14;
        labelParamProcMode.Text = "---";
        // 
        // labelParamCardMode
        // 
        labelParamCardMode.AutoSize = true;
        labelParamCardMode.Location = new System.Drawing.Point(146, 114);
        labelParamCardMode.Name = "labelParamCardMode";
        labelParamCardMode.Size = new System.Drawing.Size(33, 25);
        labelParamCardMode.TabIndex = 13;
        labelParamCardMode.Text = "---";
        // 
        // labelParamCardType
        // 
        labelParamCardType.AutoSize = true;
        labelParamCardType.Location = new System.Drawing.Point(146, 73);
        labelParamCardType.Name = "labelParamCardType";
        labelParamCardType.Size = new System.Drawing.Size(33, 25);
        labelParamCardType.TabIndex = 12;
        labelParamCardType.Text = "---";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new System.Drawing.Point(6, 237);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(117, 25);
        label13.TabIndex = 11;
        label13.Text = "DebugMode:";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new System.Drawing.Point(8, 196);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(91, 25);
        label12.TabIndex = 10;
        label12.Text = "CodeMax:";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new System.Drawing.Point(8, 155);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(98, 25);
        label11.TabIndex = 9;
        label11.Text = "ProcMode:";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new System.Drawing.Point(6, 114);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 25);
        label10.TabIndex = 8;
        label10.Text = "CardMode:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new System.Drawing.Point(6, 73);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(90, 25);
        label8.TabIndex = 7;
        label8.Text = "CardType:";
        // 
        // labelParamClb
        // 
        labelParamClb.AutoSize = true;
        labelParamClb.Location = new System.Drawing.Point(146, 32);
        labelParamClb.Name = "labelParamClb";
        labelParamClb.Size = new System.Drawing.Size(33, 25);
        labelParamClb.TabIndex = 6;
        labelParamClb.Text = "---";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new System.Drawing.Point(8, 32);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(89, 25);
        label9.TabIndex = 5;
        label9.Text = "ClbMode:";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        groupBox2.Controls.Add(labelFirmwareDate);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(labelCalibrationStatus);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(labelFirmwareId);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(labelStatus);
        groupBox2.Controls.Add(labelTargetCode);
        groupBox2.Controls.Add(labelFirmwareType);
        groupBox2.Controls.Add(labelModelNumber);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new System.Drawing.Point(9, 220);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(276, 291);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Info";
        // 
        // labelFirmwareDate
        // 
        labelFirmwareDate.AutoSize = true;
        labelFirmwareDate.Location = new System.Drawing.Point(166, 166);
        labelFirmwareDate.Name = "labelFirmwareDate";
        labelFirmwareDate.Size = new System.Drawing.Size(33, 25);
        labelFirmwareDate.TabIndex = 13;
        labelFirmwareDate.Text = "---";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(6, 166);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(130, 25);
        label1.TabIndex = 12;
        label1.Text = "Firmware Date:";
        // 
        // labelCalibrationStatus
        // 
        labelCalibrationStatus.AutoSize = true;
        labelCalibrationStatus.Location = new System.Drawing.Point(166, 201);
        labelCalibrationStatus.Name = "labelCalibrationStatus";
        labelCalibrationStatus.Size = new System.Drawing.Size(33, 25);
        labelCalibrationStatus.TabIndex = 11;
        labelCalibrationStatus.Text = "---";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(6, 201);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(154, 25);
        label7.TabIndex = 10;
        label7.Text = "Calibration Status:";
        // 
        // labelFirmwareId
        // 
        labelFirmwareId.AutoSize = true;
        labelFirmwareId.Location = new System.Drawing.Point(166, 131);
        labelFirmwareId.Name = "labelFirmwareId";
        labelFirmwareId.Size = new System.Drawing.Size(33, 25);
        labelFirmwareId.TabIndex = 9;
        labelFirmwareId.Text = "---";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(6, 131);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(88, 25);
        label6.TabIndex = 8;
        label6.Text = "Firmware:";
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Location = new System.Drawing.Point(90, 250);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new System.Drawing.Size(127, 25);
        labelStatus.TabIndex = 7;
        labelStatus.Text = "NotConnected";
        // 
        // labelTargetCode
        // 
        labelTargetCode.AutoSize = true;
        labelTargetCode.Location = new System.Drawing.Point(166, 95);
        labelTargetCode.Name = "labelTargetCode";
        labelTargetCode.Size = new System.Drawing.Size(33, 25);
        labelTargetCode.TabIndex = 6;
        labelTargetCode.Text = "---";
        // 
        // labelFirmwareType
        // 
        labelFirmwareType.AutoSize = true;
        labelFirmwareType.Location = new System.Drawing.Point(166, 61);
        labelFirmwareType.Name = "labelFirmwareType";
        labelFirmwareType.Size = new System.Drawing.Size(33, 25);
        labelFirmwareType.TabIndex = 5;
        labelFirmwareType.Text = "---";
        // 
        // labelModelNumber
        // 
        labelModelNumber.AutoSize = true;
        labelModelNumber.Location = new System.Drawing.Point(166, 27);
        labelModelNumber.Name = "labelModelNumber";
        labelModelNumber.Size = new System.Drawing.Size(33, 25);
        labelModelNumber.TabIndex = 4;
        labelModelNumber.Text = "---";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(6, 250);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(64, 25);
        label5.TabIndex = 3;
        label5.Text = "Status:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(6, 95);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(111, 25);
        label4.TabIndex = 2;
        label4.Text = "Target Code:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(6, 61);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(130, 25);
        label3.TabIndex = 1;
        label3.Text = "Firmware Type:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(6, 27);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(137, 25);
        label2.TabIndex = 0;
        label2.Text = "Model Number:";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox1.Controls.Add(radioButtonModeCalibrate);
        groupBox1.Controls.Add(radioButtonModeFlashFirmware);
        groupBox1.Controls.Add(radioButtonModeLuminance);
        groupBox1.Controls.Add(radioButtonModeReadCards);
        groupBox1.Controls.Add(radioButtonModeIdle);
        groupBox1.Location = new System.Drawing.Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(562, 211);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Mode";
        // 
        // radioButtonModeCalibrate
        // 
        radioButtonModeCalibrate.AutoSize = true;
        radioButtonModeCalibrate.Location = new System.Drawing.Point(6, 135);
        radioButtonModeCalibrate.Name = "radioButtonModeCalibrate";
        radioButtonModeCalibrate.Size = new System.Drawing.Size(122, 29);
        radioButtonModeCalibrate.TabIndex = 4;
        radioButtonModeCalibrate.Text = "Calibration";
        radioButtonModeCalibrate.UseVisualStyleBackColor = true;
        radioButtonModeCalibrate.CheckedChanged += radioButtonModeCalibrate_CheckedChanged;
        // 
        // radioButtonModeFlashFirmware
        // 
        radioButtonModeFlashFirmware.AutoSize = true;
        radioButtonModeFlashFirmware.Location = new System.Drawing.Point(6, 170);
        radioButtonModeFlashFirmware.Name = "radioButtonModeFlashFirmware";
        radioButtonModeFlashFirmware.Size = new System.Drawing.Size(172, 29);
        radioButtonModeFlashFirmware.TabIndex = 3;
        radioButtonModeFlashFirmware.Text = "Firmware Update";
        radioButtonModeFlashFirmware.UseVisualStyleBackColor = true;
        radioButtonModeFlashFirmware.CheckedChanged += radioButtonModeFlashFirmware_CheckedChanged;
        // 
        // radioButtonModeLuminance
        // 
        radioButtonModeLuminance.AutoSize = true;
        radioButtonModeLuminance.Location = new System.Drawing.Point(6, 100);
        radioButtonModeLuminance.Name = "radioButtonModeLuminance";
        radioButtonModeLuminance.Size = new System.Drawing.Size(121, 29);
        radioButtonModeLuminance.TabIndex = 2;
        radioButtonModeLuminance.Text = "Luminance";
        radioButtonModeLuminance.UseVisualStyleBackColor = true;
        radioButtonModeLuminance.CheckedChanged += radioButtonModeLuminance_CheckedChanged;
        // 
        // radioButtonModeReadCards
        // 
        radioButtonModeReadCards.AutoSize = true;
        radioButtonModeReadCards.Location = new System.Drawing.Point(6, 65);
        radioButtonModeReadCards.Name = "radioButtonModeReadCards";
        radioButtonModeReadCards.Size = new System.Drawing.Size(126, 29);
        radioButtonModeReadCards.TabIndex = 1;
        radioButtonModeReadCards.Text = "Read Cards";
        radioButtonModeReadCards.UseVisualStyleBackColor = true;
        radioButtonModeReadCards.CheckedChanged += radioButtonModeReadCards_CheckedChanged;
        // 
        // radioButtonModeIdle
        // 
        radioButtonModeIdle.AutoSize = true;
        radioButtonModeIdle.Checked = true;
        radioButtonModeIdle.Location = new System.Drawing.Point(6, 30);
        radioButtonModeIdle.Name = "radioButtonModeIdle";
        radioButtonModeIdle.Size = new System.Drawing.Size(66, 29);
        radioButtonModeIdle.TabIndex = 0;
        radioButtonModeIdle.TabStop = true;
        radioButtonModeIdle.Text = "Idle";
        radioButtonModeIdle.UseVisualStyleBackColor = true;
        radioButtonModeIdle.CheckedChanged += radioButtonModeIdle_CheckedChanged;
        // 
        // openFileDialogFirmware
        // 
        openFileDialogFirmware.AddToRecent = false;
        openFileDialogFirmware.Filter = "*.bin|*.bin";
        openFileDialogFirmware.Title = "Select Firmware File";
        // 
        // FormControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(592, 562);
        Controls.Add(panelBoardControls);
        Controls.Add(menuStripMain);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStripMain;
        MaximizeBox = false;
        Text = "Control";
        FormClosing += FormControl_FormClosing;
        Load += FormControl_Load;
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        panelBoardControls.ResumeLayout(false);
        groupBoxParameters.ResumeLayout(false);
        groupBoxParameters.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setParametersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem playfieldToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem testResetToolStripMenuItem;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelFirmwareDate;

    private System.Windows.Forms.Button buttonEditClbMode;

    private System.Windows.Forms.Button buttonEditCardMode;
    private System.Windows.Forms.Button buttonEditProcMode;
    private System.Windows.Forms.Button buttonEditCodeMax;
    private System.Windows.Forms.Button buttonEditDebugMode;

    private System.Windows.Forms.Button buttonEditCardType;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    private System.Windows.Forms.RadioButton radioButtonModeCalibrate;

    private System.Windows.Forms.OpenFileDialog openFileDialogFirmware;

    private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label labelParamCardType;
    private System.Windows.Forms.Label labelParamCardMode;
    private System.Windows.Forms.Label labelParamProcMode;
    private System.Windows.Forms.Label labelParamCodeMax;
    private System.Windows.Forms.Label labelParamDebugMode;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label labelParamClb;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.GroupBox groupBoxParameters;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label labelCalibrationStatus;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label labelFirmwareId;

    private System.Windows.Forms.Label labelModelNumber;
    private System.Windows.Forms.Label labelFirmwareType;
    private System.Windows.Forms.Label labelTargetCode;
    private System.Windows.Forms.Label labelStatus;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.RadioButton radioButtonModeFlashFirmware;
    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.RadioButton radioButtonModeReadCards;
    private System.Windows.Forms.RadioButton radioButtonModeLuminance;

    private System.Windows.Forms.RadioButton radioButtonModeIdle;
    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    private System.Windows.Forms.Panel panelBoardControls;

    private System.Windows.Forms.ToolStripMenuItem boardToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem availablePortsToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStripMain;
    private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    #endregion
}