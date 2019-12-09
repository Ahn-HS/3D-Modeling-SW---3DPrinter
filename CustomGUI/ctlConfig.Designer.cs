namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlConfig
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlConfig));
            this.buttShowMachineConfig = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlShowSliceConfig = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttShowMachineConfig
            // 
            resources.ApplyResources(this.buttShowMachineConfig, "buttShowMachineConfig");
            this.buttShowMachineConfig.BackColor = System.Drawing.Color.Navy;
            this.buttShowMachineConfig.Checked = false;
            this.buttShowMachineConfig.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttShowMachineConfig.Gapx = 5;
            this.buttShowMachineConfig.Gapy = 5;
            this.buttShowMachineConfig.GLBackgroundImage = null;
            this.buttShowMachineConfig.GLImage = null;
            this.buttShowMachineConfig.GLVisible = false;
            this.buttShowMachineConfig.GuiAnchor = null;
            this.buttShowMachineConfig.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttShowMachineConfig.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMachineConfig;
            this.buttShowMachineConfig.Name = "buttShowMachineConfig";
            this.buttShowMachineConfig.OnClickCallback = "ShowMachineConfig";
            this.buttShowMachineConfig.StyleName = null;
            this.buttShowMachineConfig.Tag = "";
            this.buttShowMachineConfig.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlShowSliceConfig
            // 
            resources.ApplyResources(this.ctlShowSliceConfig, "ctlShowSliceConfig");
            this.ctlShowSliceConfig.BackColor = System.Drawing.Color.Navy;
            this.ctlShowSliceConfig.Checked = false;
            this.ctlShowSliceConfig.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlShowSliceConfig.Gapx = 5;
            this.ctlShowSliceConfig.Gapy = 5;
            this.ctlShowSliceConfig.GLBackgroundImage = null;
            this.ctlShowSliceConfig.GLImage = null;
            this.ctlShowSliceConfig.GLVisible = false;
            this.ctlShowSliceConfig.GuiAnchor = null;
            this.ctlShowSliceConfig.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlShowSliceConfig.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttSliceConf;
            this.ctlShowSliceConfig.Name = "ctlShowSliceConfig";
            this.ctlShowSliceConfig.OnClickCallback = "ShowSliceConfig";
            this.ctlShowSliceConfig.StyleName = null;
            this.ctlShowSliceConfig.Tag = "";
            this.ctlShowSliceConfig.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel5.Controls.Add(this.buttShowMachineConfig);
            this.flowLayoutPanel5.Controls.Add(this.ctlShowSliceConfig);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // ctlConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.lblTitle);
            this.Name = "ctlConfig";
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlImageButton buttShowMachineConfig;
        private ctlImageButton ctlShowSliceConfig;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}
