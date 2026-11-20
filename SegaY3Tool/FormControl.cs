using System.IO.Ports;
using System.Text;
using Haruka.Arcade.SEGA835Lib.Devices;
using Haruka.Arcade.SEGA835Lib.Devices.Misc;

namespace SegaY3Tool;

public partial class FormControl : Form {
    private const String CONNECT_COM_ENTRY = "CONNECT_COM_ENTRY";

    public enum State {
        Idle,
        Cards,
        Luminance,
        Calibrate,
        Firmware
    }

    private FormRender render;
    public Y3 Y3 { get; private set; }
    public State Mode { get; private set; }

    public FormControl() {
        InitializeComponent();
    }

    private void FormControl_FormClosing(object sender, FormClosingEventArgs e) {
        render?.Close();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
        Application.Exit();
    }

    private void FormControl_Load(object sender, EventArgs e) {
        render = new FormRender(this);
        render.Location = new Point(Location.X + Width, Location.Y);
        render.Show();
    }

    private void boardToolStripMenuItem_Click(object sender, EventArgs e) {
        foreach (ToolStripItem i in connectToolStripMenuItem.DropDownItems.Cast<ToolStripItem>().Where(t => CONNECT_COM_ENTRY.Equals(t.Tag)).ToArray()) {
            connectToolStripMenuItem.DropDownItems.Remove(i);
        }

        foreach (string str in SerialPort.GetPortNames()) {
            connectToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(str, null, (t, _) => { ConnectY3(((ToolStripMenuItem)t).Text); }) {
                Tag = CONNECT_COM_ENTRY
            });
        }
    }

    private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
        DisconnectY3();
    }

    private void radioButtonModeIdle_CheckedChanged(object sender, EventArgs e) {
        if (((RadioButton)sender).Checked) {
            UpdateState(State.Idle);
        }
    }

    private void radioButtonModeReadCards_CheckedChanged(object sender, EventArgs e) {
        if (((RadioButton)sender).Checked) {
            UpdateState(State.Cards);
        }
    }

    private void radioButtonModeLuminance_CheckedChanged(object sender, EventArgs e) {
        if (((RadioButton)sender).Checked) {
            UpdateState(State.Luminance);
        }
    }

    private void radioButtonModeFlashFirmware_CheckedChanged(object sender, EventArgs e) {
        if (((RadioButton)sender).Checked) {
            UpdateState(State.Firmware);
        }
    }

    private void radioButtonModeCalibrate_CheckedChanged(object sender, EventArgs e) {
        if (((RadioButton)sender).Checked) {
            UpdateState(State.Calibrate);
        }
    }

    private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
        if (Y3 != null) {
            DeviceStatus ret = Y3.Reset();
            if (ret == DeviceStatus.Ok) {
                Mode = State.Idle;
                radioButtonModeIdle.Checked = true;
                UpdateBoardInfo();
                MessageBox.Show(this, "Success", Program.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                ReportBoardErrorUi(ret, "reset");
            }
        }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
        MessageBox.Show(this, Program.TITLE, Program.TITLE, MessageBoxButtons.OK);
    }


    private void buttonEditClbMode_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.ClbMode);
    }

    private void buttonEditCardType_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.CardType);
    }

    private void buttonEditCardMode_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.CardMode);
    }

    private void buttonEditProcMode_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.ProcMode);
    }

    private void buttonEditCodeMax_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.CodeMax);
    }

    private void buttonEditDebugMode_Click(object sender, EventArgs e) {
        EditParameter(Y3.ParameterNumber.DebugMode);
    }

    private void playfieldToolStripMenuItem_Click(object sender, EventArgs e) {
        DeviceStatus ret = Y3.SetParamsForPlayfield();
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "setting playfield params");
        }
        UpdateBoardInfo();
    }

    private void printerToolStripMenuItem_Click(object sender, EventArgs e) {
        DeviceStatus ret = Y3.SetParamsForPrinter();
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "setting printer params");
        }
        UpdateBoardInfo();
    }

    private void testResetToolStripMenuItem_Click(object sender, EventArgs e) {
        DeviceStatus ret = Y3.TestReset();
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "test reset");
        }
        UpdateBoardInfo();
    }

    private void ConnectY3(string comPort) {
        Y3 = new Y3(Int32.Parse(comPort.Substring(3)));
        DeviceStatus ret = Y3.Connect();

        if (ret != DeviceStatus.Ok) {
            MessageBox.Show(this, "Failed to connect to " + comPort + "\n" + ret, Program.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ret = Y3.Reset();
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "reset");
            return;
        }

        if (Y3.GetTargetCodeType() == Y3.TargetCodeType.Field) {
            ret = Y3.SetParamsForPlayfield();
        } else if (Y3.GetTargetCodeType() == Y3.TargetCodeType.Printer) {
            ret = Y3.SetParamsForPrinter();
        }
        UpdateBoardInfo();
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "setting parameters for target code");
        }

        Mode = State.Idle;

        disconnectToolStripMenuItem.Enabled = true;
        connectToolStripMenuItem.Enabled = false;
        panelBoardControls.Enabled = true;
        radioButtonModeIdle.Checked = true;
        resetToolStripMenuItem.Enabled = true;
        actionsToolStripMenuItem.Enabled = true;
    }

    private void DisconnectY3() {
        Mode = State.Idle;
        Y3?.Disconnect();
        Y3 = null;
        UpdateBoardInfo();
        disconnectToolStripMenuItem.Enabled = false;
        connectToolStripMenuItem.Enabled = true;
        panelBoardControls.Enabled = false;
        resetToolStripMenuItem.Enabled = false;
        actionsToolStripMenuItem.Enabled = false;
    }

    private void UpdateBoardInfo() {
        labelModelNumber.Text = Y3?.GetDeviceModel() ?? "---";
        labelFirmwareId.Text = (Y3?.FirmwareName ?? "---") + "/" + (Y3?.FirmwareVersion ?? 0);
        labelFirmwareType.Text = Y3?.GetFirmwareType().ToString() ?? "---";
        labelFirmwareDate.Text = Y3?.FirmwareDate.ToString() ?? "---";
        labelTargetCode.Text = Y3?.GetTargetCodeType().ToString() ?? "---";
        labelCalibrationStatus.Text = (Y3 != null ? (!Y3.IsCalibrationNeeded ? "GOOD" : "BAD") : "---");
        labelStatus.Text = Y3?.GetStatus().ToString() ?? "NotConnected";

        if (Y3 != null) {
            uint clbMode = GetParam(Y3.ParameterNumber.ClbMode);
            uint codeMax = GetParam(Y3.ParameterNumber.CodeMax);

            playfieldToolStripMenuItem.Checked = clbMode == 0x0 && codeMax == 16;
            printerToolStripMenuItem.Checked = codeMax == 1;
        }

        SetUiParam(Y3.ParameterNumber.CardMode, labelParamCardMode);
        SetUiParam(Y3.ParameterNumber.CardType, labelParamCardType);
        SetUiParam(Y3.ParameterNumber.ClbMode, labelParamClb);
        SetUiParam(Y3.ParameterNumber.CodeMax, labelParamCodeMax);
        SetUiParam(Y3.ParameterNumber.DebugMode, labelParamDebugMode);
        SetUiParam(Y3.ParameterNumber.ProcMode, labelParamProcMode);
    }

    private uint GetParam(Y3.ParameterNumber param) {
        DeviceStatus ret = Y3.GetParameter(param, out uint value);
        if (ret != DeviceStatus.Ok) {
            ReportBoardErrorUi(ret, "read parameter " + param);
        }
        return value;
    }

    private void SetUiParam(Y3.ParameterNumber param, Label label) {
        if (Y3 != null) {
            DeviceStatus ret = Y3.GetParameter(param, out uint value);
            if (ret == DeviceStatus.Ok) {
                label.Text = value + " (0x" + value.ToString("X") + ")";
            } else {
                ReportBoardErrorUi(ret, "read parameter " + param);
                label.Text = "<error>";
            }
        } else {
            label.Text = "---";
        }
    }

    public void ReportBoardErrorUi(DeviceStatus ret, String message = null) {
        Program.ReportBoardErrorUi(this, ret, Y3, message);
    }

    private void UpdateState(State newState) {
        if (Y3 == null || newState == Mode) {
            return;
        }

        DeviceStatus ret;

        if (Mode == State.Cards) {
            ret = Y3.Stop();
            if (ret != DeviceStatus.Ok) {
                ReportBoardErrorUi(ret, "stop card read");
            }
        } else if (Mode == State.Luminance) {
            ret = Y3.StopLuminanceReporting();
            if (ret != DeviceStatus.Ok) {
                ReportBoardErrorUi(ret, "stop luminance read");
            }
        }

        Y3.Status status;
        do {
            Thread.Sleep(250);
            status = Y3.GetStatus();
        } while (status == Y3.Status.Active || status == Y3.Status.BlockingProcess);

        Mode = newState;

        if (Mode == State.Cards) {
            ret = Y3.Start();
            if (ret != DeviceStatus.Ok) {
                ReportBoardErrorUi(ret, "start card read");
            }
        } else if (Mode == State.Luminance) {
            ret = Y3.StartLuminanceReporting();
            if (ret != DeviceStatus.Ok) {
                ReportBoardErrorUi(ret, "start luminance read");
            }
        } else if (Mode == State.Calibrate) {
            ret = Y3.CalibratePlayfield();
            if (ret == DeviceStatus.Ok) {
                MessageBox.Show(this, "Success", Program.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                ReportBoardErrorUi(ret, "calibration");
            }

            UpdateBoardInfo();
            radioButtonModeIdle.Checked = true;
        } else if (Mode == State.Firmware) {
            if (openFileDialogFirmware.ShowDialog(this) != DialogResult.OK) {
                radioButtonModeIdle.Checked = true;
                return;
            }

            byte[] data = File.ReadAllBytes(openFileDialogFirmware.FileName);
            if (data.IndexOf(Encoding.ASCII.GetBytes("Y3 BOOT LOADER")) == -1) {
                if (MessageBox.Show(this, "Selected file does not look like a Y3 firmware file. Proceed?", Program.TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3) != DialogResult.Yes) {
                    radioButtonModeIdle.Checked = true;
                    return;
                }
            }

            if (MessageBox.Show(this, "Begin Firmware Update?\n" + openFileDialogFirmware.FileName, Program.TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) != DialogResult.Yes) {
                radioButtonModeIdle.Checked = true;
                return;
            }

            panelBoardControls.Enabled = false;
            menuStripMain.Enabled = false;
            new Thread(ExecuteFirmwareUpdateT).Start();
            new Thread(WaitFirmwareUpdateT).Start();
        }

        groupBoxParameters.Enabled = Mode == State.Idle;

        UpdateBoardInfo();
    }

    private void ExecuteFirmwareUpdateT() {
        Y3.UpdateFirmware(openFileDialogFirmware.FileName);
    }

    private void WaitFirmwareUpdateT() {
        do {
            Thread.Sleep(1000);
        } while (Y3 != null && Y3.FirmwareUpdate == null);

        do {
            Thread.Sleep(1000);
        } while ((Y3?.GetStatus() ?? Y3.Status.ErrorOther) == Y3.Status.BlockingProcess);

        Invoke(() => {
            if (Y3 != null) {
                Y3.FirmwareUpdateStatus fw = Y3.FirmwareUpdate;
                do {
                    Thread.Sleep(500);
                } while (fw != null && fw.DeviceStatus == DeviceStatus.Busy);
                if (fw != null) {
                    if (fw.DeviceStatus == DeviceStatus.Ok) {
                        MessageBox.Show(this, "Success", Program.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        ReportBoardErrorUi(fw.DeviceStatus, "firmware update");
                    }
                }

                Y3.Disconnect();
                DeviceStatus ret = Y3.Connect();
                if (ret == DeviceStatus.Ok) {
                    ret = Y3.Reset();
                    if (ret != DeviceStatus.Ok) {
                        ReportBoardErrorUi(ret, "resetting after update");
                    }
                } else {
                    ReportBoardErrorUi(ret, "reconnecting after update");
                }
            }
            
            UpdateBoardInfo();

            radioButtonModeIdle.Checked = true;
            panelBoardControls.Enabled = true;
            menuStripMain.Enabled = true;
        });
    }

    private void EditParameter(Y3.ParameterNumber param) {
        FormEditParam edit = new FormEditParam(this, Y3, param);
        if (edit.ShowDialog(this) == DialogResult.OK) {
            UpdateBoardInfo();
        }
    }
}