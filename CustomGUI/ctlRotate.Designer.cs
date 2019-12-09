namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlRotate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlRotate));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttRotateXMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateXPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttRotateYMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateYPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttRotateZMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateZPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel2.Controls.Add(this.ctlTitle1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // ctlTitle1
            // 
            resources.ApplyResources(this.ctlTitle1, "ctlTitle1");
            this.ctlTitle1.Checked = false;
            this.ctlTitle1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttStateTrig;
            this.ctlTitle1.Gapx = 0;
            this.ctlTitle1.Gapy = 0;
            this.ctlTitle1.GLBackgroundImage = null;
            this.ctlTitle1.GLVisible = false;
            this.ctlTitle1.GuiAnchor = null;
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRotate;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // flowLayoutPanel7
            // 
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.buttRotateXMinus);
            this.flowLayoutPanel7.Controls.Add(this.textRotateX);
            this.flowLayoutPanel7.Controls.Add(this.buttRotateXPlus);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // buttRotateXMinus
            // 
            resources.ApplyResources(this.buttRotateXMinus, "buttRotateXMinus");
            this.buttRotateXMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateXMinus.Checked = false;
            this.buttRotateXMinus.CheckImage = null;
            this.buttRotateXMinus.Gapx = 5;
            this.buttRotateXMinus.Gapy = 5;
            this.buttRotateXMinus.GLBackgroundImage = null;
            this.buttRotateXMinus.GLImage = null;
            this.buttRotateXMinus.GLVisible = false;
            this.buttRotateXMinus.GuiAnchor = null;
            this.buttRotateXMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateXMinus.Name = "buttRotateXMinus";
            this.buttRotateXMinus.StyleName = null;
            this.buttRotateXMinus.Tag = "";
            this.buttRotateXMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXMinus.Click += new System.EventHandler(this.buttRotateXMinus_Click);
            this.buttRotateXMinus.DoubleClick += new System.EventHandler(this.buttRotateXMinus_Click);
            // 
            // textRotateX
            // 
            resources.ApplyResources(this.textRotateX, "textRotateX");
            this.textRotateX.BackColor = System.Drawing.Color.Navy;
            this.textRotateX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateX.ErrorColor = System.Drawing.Color.Red;
            this.textRotateX.FloatVal = 90F;
            this.textRotateX.ForeColor = System.Drawing.Color.White;
            this.textRotateX.IntVal = 1;
            this.textRotateX.MaxFloat = 360F;
            this.textRotateX.MaxInt = 1000;
            this.textRotateX.MinFloat = 0F;
            this.textRotateX.MinInt = 1;
            this.textRotateX.Name = "textRotateX";
            this.textRotateX.ValidColor = System.Drawing.Color.White;
            this.textRotateX.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateXPlus
            // 
            resources.ApplyResources(this.buttRotateXPlus, "buttRotateXPlus");
            this.buttRotateXPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateXPlus.Checked = false;
            this.buttRotateXPlus.CheckImage = null;
            this.buttRotateXPlus.Gapx = 5;
            this.buttRotateXPlus.Gapy = 5;
            this.buttRotateXPlus.GLBackgroundImage = null;
            this.buttRotateXPlus.GLImage = null;
            this.buttRotateXPlus.GLVisible = false;
            this.buttRotateXPlus.GuiAnchor = null;
            this.buttRotateXPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateXPlus.Name = "buttRotateXPlus";
            this.buttRotateXPlus.StyleName = null;
            this.buttRotateXPlus.Tag = "";
            this.buttRotateXPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXPlus.Click += new System.EventHandler(this.buttRotateXPlus_Click);
            this.buttRotateXPlus.DoubleClick += new System.EventHandler(this.buttRotateXPlus_Click);
            // 
            // flowLayoutPanel8
            // 
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel8.Controls.Add(this.label10);
            this.flowLayoutPanel8.Controls.Add(this.buttRotateYMinus);
            this.flowLayoutPanel8.Controls.Add(this.textRotateY);
            this.flowLayoutPanel8.Controls.Add(this.buttRotateYPlus);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // buttRotateYMinus
            // 
            resources.ApplyResources(this.buttRotateYMinus, "buttRotateYMinus");
            this.buttRotateYMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateYMinus.Checked = false;
            this.buttRotateYMinus.CheckImage = null;
            this.buttRotateYMinus.Gapx = 5;
            this.buttRotateYMinus.Gapy = 5;
            this.buttRotateYMinus.GLBackgroundImage = null;
            this.buttRotateYMinus.GLImage = null;
            this.buttRotateYMinus.GLVisible = false;
            this.buttRotateYMinus.GuiAnchor = null;
            this.buttRotateYMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateYMinus.Name = "buttRotateYMinus";
            this.buttRotateYMinus.StyleName = null;
            this.buttRotateYMinus.Tag = "";
            this.buttRotateYMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYMinus.Click += new System.EventHandler(this.buttRotateYMinus_Click);
            this.buttRotateYMinus.DoubleClick += new System.EventHandler(this.buttRotateYMinus_Click);
            // 
            // textRotateY
            // 
            resources.ApplyResources(this.textRotateY, "textRotateY");
            this.textRotateY.BackColor = System.Drawing.Color.Navy;
            this.textRotateY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateY.ErrorColor = System.Drawing.Color.Red;
            this.textRotateY.FloatVal = 90F;
            this.textRotateY.ForeColor = System.Drawing.Color.White;
            this.textRotateY.IntVal = 1;
            this.textRotateY.MaxFloat = 360F;
            this.textRotateY.MaxInt = 1000;
            this.textRotateY.MinFloat = 0F;
            this.textRotateY.MinInt = 1;
            this.textRotateY.Name = "textRotateY";
            this.textRotateY.ValidColor = System.Drawing.Color.White;
            this.textRotateY.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateYPlus
            // 
            resources.ApplyResources(this.buttRotateYPlus, "buttRotateYPlus");
            this.buttRotateYPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateYPlus.Checked = false;
            this.buttRotateYPlus.CheckImage = null;
            this.buttRotateYPlus.Gapx = 5;
            this.buttRotateYPlus.Gapy = 5;
            this.buttRotateYPlus.GLBackgroundImage = null;
            this.buttRotateYPlus.GLImage = null;
            this.buttRotateYPlus.GLVisible = false;
            this.buttRotateYPlus.GuiAnchor = null;
            this.buttRotateYPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateYPlus.Name = "buttRotateYPlus";
            this.buttRotateYPlus.StyleName = null;
            this.buttRotateYPlus.Tag = "";
            this.buttRotateYPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYPlus.Click += new System.EventHandler(this.buttRotateYPlus_Click);
            this.buttRotateYPlus.DoubleClick += new System.EventHandler(this.buttRotateYPlus_Click);
            // 
            // flowLayoutPanel10
            // 
            resources.ApplyResources(this.flowLayoutPanel10, "flowLayoutPanel10");
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel10.Controls.Add(this.label11);
            this.flowLayoutPanel10.Controls.Add(this.buttRotateZMinus);
            this.flowLayoutPanel10.Controls.Add(this.textRotateZ);
            this.flowLayoutPanel10.Controls.Add(this.buttRotateZPlus);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // buttRotateZMinus
            // 
            resources.ApplyResources(this.buttRotateZMinus, "buttRotateZMinus");
            this.buttRotateZMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateZMinus.Checked = false;
            this.buttRotateZMinus.CheckImage = null;
            this.buttRotateZMinus.Gapx = 5;
            this.buttRotateZMinus.Gapy = 5;
            this.buttRotateZMinus.GLBackgroundImage = null;
            this.buttRotateZMinus.GLImage = null;
            this.buttRotateZMinus.GLVisible = false;
            this.buttRotateZMinus.GuiAnchor = null;
            this.buttRotateZMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateZMinus.Name = "buttRotateZMinus";
            this.buttRotateZMinus.StyleName = null;
            this.buttRotateZMinus.Tag = "";
            this.buttRotateZMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZMinus.Click += new System.EventHandler(this.buttRotateZMinus_Click);
            this.buttRotateZMinus.DoubleClick += new System.EventHandler(this.buttRotateZMinus_Click);
            // 
            // textRotateZ
            // 
            resources.ApplyResources(this.textRotateZ, "textRotateZ");
            this.textRotateZ.BackColor = System.Drawing.Color.Navy;
            this.textRotateZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateZ.ErrorColor = System.Drawing.Color.Red;
            this.textRotateZ.FloatVal = 90F;
            this.textRotateZ.ForeColor = System.Drawing.Color.White;
            this.textRotateZ.IntVal = 1;
            this.textRotateZ.MaxFloat = 360F;
            this.textRotateZ.MaxInt = 1000;
            this.textRotateZ.MinFloat = 0F;
            this.textRotateZ.MinInt = 1;
            this.textRotateZ.Name = "textRotateZ";
            this.textRotateZ.ValidColor = System.Drawing.Color.White;
            this.textRotateZ.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateZPlus
            // 
            resources.ApplyResources(this.buttRotateZPlus, "buttRotateZPlus");
            this.buttRotateZPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateZPlus.Checked = false;
            this.buttRotateZPlus.CheckImage = null;
            this.buttRotateZPlus.Gapx = 5;
            this.buttRotateZPlus.Gapy = 5;
            this.buttRotateZPlus.GLBackgroundImage = null;
            this.buttRotateZPlus.GLImage = null;
            this.buttRotateZPlus.GLVisible = false;
            this.buttRotateZPlus.GuiAnchor = null;
            this.buttRotateZPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateZPlus.Name = "buttRotateZPlus";
            this.buttRotateZPlus.StyleName = null;
            this.buttRotateZPlus.Tag = "";
            this.buttRotateZPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZPlus.Click += new System.EventHandler(this.buttRotateZPlus_Click);
            this.buttRotateZPlus.DoubleClick += new System.EventHandler(this.buttRotateZPlus_Click);
            // 
            // ctlRotate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ctlRotate";
            this.Resize += new System.EventHandler(this.ctlRotate_Resize);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private ctlImageButton buttRotateXMinus;
        private ctlImageButton buttRotateXPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private ctlImageButton buttRotateYMinus;
        private ctlImageButton buttRotateYPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label11;
        private ctlImageButton buttRotateZMinus;
        private ctlImageButton buttRotateZPlus;
        private ctlTextBox textRotateX;
        private ctlTextBox textRotateY;
        private ctlTextBox textRotateZ;
        private ctlTitle ctlTitle1;
    }
}
