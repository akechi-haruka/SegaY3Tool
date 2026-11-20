using System.ComponentModel;

namespace SegaY3Tool;

partial class FormEditParam {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        numericUpDownValue = new System.Windows.Forms.NumericUpDown();
        buttonOK = new System.Windows.Forms.Button();
        buttonCancel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
        SuspendLayout();
        // 
        // numericUpDownValue
        // 
        numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        numericUpDownValue.Location = new System.Drawing.Point(12, 12);
        numericUpDownValue.Name = "numericUpDownValue";
        numericUpDownValue.Size = new System.Drawing.Size(177, 31);
        numericUpDownValue.TabIndex = 0;
        // 
        // buttonOK
        // 
        buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        buttonOK.AutoSize = true;
        buttonOK.Location = new System.Drawing.Point(12, 53);
        buttonOK.Name = "buttonOK";
        buttonOK.Size = new System.Drawing.Size(75, 35);
        buttonOK.TabIndex = 1;
        buttonOK.Text = "OK";
        buttonOK.UseVisualStyleBackColor = true;
        buttonOK.Click += buttonOK_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        buttonCancel.AutoSize = true;
        buttonCancel.Location = new System.Drawing.Point(114, 53);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new System.Drawing.Size(75, 35);
        buttonCancel.TabIndex = 2;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // FormEditParam
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(201, 100);
        Controls.Add(buttonCancel);
        Controls.Add(buttonOK);
        Controls.Add(numericUpDownValue);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Edit Parameter";
        Load += FormEditParam_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonOK;

    private System.Windows.Forms.Button buttonCancel;

    private System.Windows.Forms.NumericUpDown numericUpDownValue;

    #endregion
}