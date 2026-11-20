using Haruka.Arcade.SEGA835Lib.Devices;
using Haruka.Arcade.SEGA835Lib.Devices.Misc;

namespace SegaY3Tool;

public partial class FormEditParam : Form {
    private readonly FormControl parent;
    private readonly Y3 y3;
    private readonly Y3.ParameterNumber param;

    public FormEditParam(FormControl parent, Y3 y3, Y3.ParameterNumber param) {
        this.parent = parent;
        this.y3 = y3;
        this.param = param;
        InitializeComponent();
    }

    private void buttonOK_Click(object sender, EventArgs e) {
        DeviceStatus ret = y3.SetParameter(param, (uint)numericUpDownValue.Value);
        if (ret != DeviceStatus.Ok) {
            Program.ReportBoardErrorUi(this, ret, y3, "updating parameter");
            CancelAndClose();
            return;
        }
        
        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
        CancelAndClose();
    }

    private void CancelAndClose() {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void FormEditParam_Load(object sender, EventArgs e) {
        Text = param.ToString();
        DeviceStatus ret = y3.GetParameter(param, out uint value);
        if (ret != DeviceStatus.Ok) {
            Program.ReportBoardErrorUi(this, ret, y3, "getting parameter");
            CancelAndClose();
            return;
        }

        numericUpDownValue.Value = value;
    }
}