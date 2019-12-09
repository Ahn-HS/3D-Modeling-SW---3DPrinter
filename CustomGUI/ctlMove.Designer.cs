namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMove));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttOnPlatform = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttCenter = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttArrange = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttXMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textMoveX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttXPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttYMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textMoveY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttYPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttZMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textMoveZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttZPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlToolTip1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlToolTip();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel2, resources.GetString("flowLayoutPanel2.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            this.ctlToolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.buttOnPlatform);
            this.flowLayoutPanel1.Controls.Add(this.buttCenter);
            this.flowLayoutPanel1.Controls.Add(this.buttArrange);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // buttOnPlatform
            // 
            resources.ApplyResources(this.buttOnPlatform, "buttOnPlatform");
            this.buttOnPlatform.BackColor = System.Drawing.Color.Navy;
            this.buttOnPlatform.Checked = false;
            this.buttOnPlatform.CheckImage = null;
            this.buttOnPlatform.Gapx = 5;
            this.buttOnPlatform.Gapy = 5;
            this.buttOnPlatform.GLBackgroundImage = null;
            this.buttOnPlatform.GLImage = null;
            this.buttOnPlatform.GLVisible = false;
            this.buttOnPlatform.GuiAnchor = null;
            this.buttOnPlatform.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttOnPlatform.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttOnPlatform;
            this.buttOnPlatform.Name = "buttOnPlatform";
            this.buttOnPlatform.StyleName = null;
            this.buttOnPlatform.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttOnPlatform, resources.GetString("buttOnPlatform.ToolTip"));
            this.buttOnPlatform.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttOnPlatform.Click += new System.EventHandler(this.buttOnPlatform_Click);
            // 
            // buttCenter
            // 
            resources.ApplyResources(this.buttCenter, "buttCenter");
            this.buttCenter.BackColor = System.Drawing.Color.Navy;
            this.buttCenter.Checked = false;
            this.buttCenter.CheckImage = null;
            this.buttCenter.Gapx = 5;
            this.buttCenter.Gapy = 5;
            this.buttCenter.GLBackgroundImage = null;
            this.buttCenter.GLImage = null;
            this.buttCenter.GLVisible = false;
            this.buttCenter.GuiAnchor = null;
            this.buttCenter.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttCenter.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttCenter;
            this.buttCenter.Name = "buttCenter";
            this.buttCenter.StyleName = null;
            this.buttCenter.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttCenter, resources.GetString("buttCenter.ToolTip"));
            this.buttCenter.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttCenter.Click += new System.EventHandler(this.buttCenter_Click);
            // 
            // buttArrange
            // 
            resources.ApplyResources(this.buttArrange, "buttArrange");
            this.buttArrange.BackColor = System.Drawing.Color.Navy;
            this.buttArrange.Checked = false;
            this.buttArrange.CheckImage = null;
            this.buttArrange.Gapx = 5;
            this.buttArrange.Gapy = 5;
            this.buttArrange.GLBackgroundImage = null;
            this.buttArrange.GLImage = null;
            this.buttArrange.GLVisible = false;
            this.buttArrange.GuiAnchor = null;
            this.buttArrange.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttArrange.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttArrange;
            this.buttArrange.Name = "buttArrange";
            this.buttArrange.StyleName = null;
            this.buttArrange.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttArrange, resources.GetString("buttArrange.ToolTip"));
            this.buttArrange.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttArrange.Click += new System.EventHandler(this.buttArrange_Click);
            // 
            // flowLayoutPanel7
            // 
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.buttXMinus);
            this.flowLayoutPanel7.Controls.Add(this.textMoveX);
            this.flowLayoutPanel7.Controls.Add(this.buttXPlus);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel7, resources.GetString("flowLayoutPanel7.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            this.ctlToolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // buttXMinus
            // 
            resources.ApplyResources(this.buttXMinus, "buttXMinus");
            this.buttXMinus.BackColor = System.Drawing.Color.Navy;
            this.buttXMinus.Checked = false;
            this.buttXMinus.CheckImage = null;
            this.buttXMinus.Gapx = 5;
            this.buttXMinus.Gapy = 5;
            this.buttXMinus.GLBackgroundImage = null;
            this.buttXMinus.GLImage = null;
            this.buttXMinus.GLVisible = false;
            this.buttXMinus.GuiAnchor = null;
            this.buttXMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttXMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttXMinus.Name = "buttXMinus";
            this.buttXMinus.StyleName = null;
            this.buttXMinus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttXMinus, resources.GetString("buttXMinus.ToolTip"));
            this.buttXMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttXMinus.Click += new System.EventHandler(this.buttXMinus_Click);
            this.buttXMinus.DoubleClick += new System.EventHandler(this.buttXMinus_Click);
            // 
            // textMoveX
            // 
            resources.ApplyResources(this.textMoveX, "textMoveX");
            this.textMoveX.BackColor = System.Drawing.Color.Navy;
            this.textMoveX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMoveX.ErrorColor = System.Drawing.Color.Red;
            this.textMoveX.FloatVal = 10F;
            this.textMoveX.ForeColor = System.Drawing.Color.White;
            this.textMoveX.IntVal = 1;
            this.textMoveX.MaxFloat = 500F;
            this.textMoveX.MaxInt = 1000;
            this.textMoveX.MinFloat = -500F;
            this.textMoveX.MinInt = 1;
            this.textMoveX.Name = "textMoveX";
            this.ctlToolTip1.SetToolTip(this.textMoveX, resources.GetString("textMoveX.ToolTip"));
            this.textMoveX.ValidColor = System.Drawing.Color.White;
            this.textMoveX.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttXPlus
            // 
            resources.ApplyResources(this.buttXPlus, "buttXPlus");
            this.buttXPlus.BackColor = System.Drawing.Color.Navy;
            this.buttXPlus.Checked = false;
            this.buttXPlus.CheckImage = null;
            this.buttXPlus.Gapx = 5;
            this.buttXPlus.Gapy = 5;
            this.buttXPlus.GLBackgroundImage = null;
            this.buttXPlus.GLImage = null;
            this.buttXPlus.GLVisible = false;
            this.buttXPlus.GuiAnchor = null;
            this.buttXPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttXPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttXPlus.Name = "buttXPlus";
            this.buttXPlus.StyleName = null;
            this.buttXPlus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttXPlus, resources.GetString("buttXPlus.ToolTip"));
            this.buttXPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttXPlus.Click += new System.EventHandler(this.buttXPlus_Click);
            this.buttXPlus.DoubleClick += new System.EventHandler(this.buttXPlus_Click);
            // 
            // flowLayoutPanel8
            // 
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel8.Controls.Add(this.label10);
            this.flowLayoutPanel8.Controls.Add(this.buttYMinus);
            this.flowLayoutPanel8.Controls.Add(this.textMoveY);
            this.flowLayoutPanel8.Controls.Add(this.buttYPlus);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel8, resources.GetString("flowLayoutPanel8.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            this.ctlToolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // buttYMinus
            // 
            resources.ApplyResources(this.buttYMinus, "buttYMinus");
            this.buttYMinus.BackColor = System.Drawing.Color.Navy;
            this.buttYMinus.Checked = false;
            this.buttYMinus.CheckImage = null;
            this.buttYMinus.Gapx = 5;
            this.buttYMinus.Gapy = 5;
            this.buttYMinus.GLBackgroundImage = null;
            this.buttYMinus.GLImage = null;
            this.buttYMinus.GLVisible = false;
            this.buttYMinus.GuiAnchor = null;
            this.buttYMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttYMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttYMinus.Name = "buttYMinus";
            this.buttYMinus.StyleName = null;
            this.buttYMinus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttYMinus, resources.GetString("buttYMinus.ToolTip"));
            this.buttYMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttYMinus.Click += new System.EventHandler(this.buttYMinus_Click);
            this.buttYMinus.DoubleClick += new System.EventHandler(this.buttYMinus_Click);
            // 
            // textMoveY
            // 
            resources.ApplyResources(this.textMoveY, "textMoveY");
            this.textMoveY.BackColor = System.Drawing.Color.Navy;
            this.textMoveY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMoveY.ErrorColor = System.Drawing.Color.Red;
            this.textMoveY.FloatVal = 10F;
            this.textMoveY.ForeColor = System.Drawing.Color.White;
            this.textMoveY.IntVal = 1;
            this.textMoveY.MaxFloat = 500F;
            this.textMoveY.MaxInt = 1000;
            this.textMoveY.MinFloat = -500F;
            this.textMoveY.MinInt = 1;
            this.textMoveY.Name = "textMoveY";
            this.ctlToolTip1.SetToolTip(this.textMoveY, resources.GetString("textMoveY.ToolTip"));
            this.textMoveY.ValidColor = System.Drawing.Color.White;
            this.textMoveY.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttYPlus
            // 
            resources.ApplyResources(this.buttYPlus, "buttYPlus");
            this.buttYPlus.BackColor = System.Drawing.Color.Navy;
            this.buttYPlus.Checked = false;
            this.buttYPlus.CheckImage = null;
            this.buttYPlus.Gapx = 5;
            this.buttYPlus.Gapy = 5;
            this.buttYPlus.GLBackgroundImage = null;
            this.buttYPlus.GLImage = null;
            this.buttYPlus.GLVisible = false;
            this.buttYPlus.GuiAnchor = null;
            this.buttYPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttYPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttYPlus.Name = "buttYPlus";
            this.buttYPlus.StyleName = null;
            this.buttYPlus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttYPlus, resources.GetString("buttYPlus.ToolTip"));
            this.buttYPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttYPlus.Click += new System.EventHandler(this.buttYPlus_Click);
            this.buttYPlus.DoubleClick += new System.EventHandler(this.buttYPlus_Click);
            // 
            // flowLayoutPanel10
            // 
            resources.ApplyResources(this.flowLayoutPanel10, "flowLayoutPanel10");
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel10.Controls.Add(this.label11);
            this.flowLayoutPanel10.Controls.Add(this.buttZMinus);
            this.flowLayoutPanel10.Controls.Add(this.textMoveZ);
            this.flowLayoutPanel10.Controls.Add(this.buttZPlus);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel10, resources.GetString("flowLayoutPanel10.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            this.ctlToolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // buttZMinus
            // 
            resources.ApplyResources(this.buttZMinus, "buttZMinus");
            this.buttZMinus.BackColor = System.Drawing.Color.Navy;
            this.buttZMinus.Checked = false;
            this.buttZMinus.CheckImage = null;
            this.buttZMinus.Gapx = 5;
            this.buttZMinus.Gapy = 5;
            this.buttZMinus.GLBackgroundImage = null;
            this.buttZMinus.GLImage = null;
            this.buttZMinus.GLVisible = false;
            this.buttZMinus.GuiAnchor = null;
            this.buttZMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttZMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttZMinus.Name = "buttZMinus";
            this.buttZMinus.StyleName = null;
            this.buttZMinus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttZMinus, resources.GetString("buttZMinus.ToolTip"));
            this.buttZMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttZMinus.Click += new System.EventHandler(this.buttZMinus_Click);
            this.buttZMinus.DoubleClick += new System.EventHandler(this.buttZMinus_Click);
            // 
            // textMoveZ
            // 
            resources.ApplyResources(this.textMoveZ, "textMoveZ");
            this.textMoveZ.BackColor = System.Drawing.Color.Navy;
            this.textMoveZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMoveZ.ErrorColor = System.Drawing.Color.Red;
            this.textMoveZ.FloatVal = 10F;
            this.textMoveZ.ForeColor = System.Drawing.Color.White;
            this.textMoveZ.IntVal = 1;
            this.textMoveZ.MaxFloat = 500F;
            this.textMoveZ.MaxInt = 1000;
            this.textMoveZ.MinFloat = -500F;
            this.textMoveZ.MinInt = 1;
            this.textMoveZ.Name = "textMoveZ";
            this.ctlToolTip1.SetToolTip(this.textMoveZ, resources.GetString("textMoveZ.ToolTip"));
            this.textMoveZ.ValidColor = System.Drawing.Color.White;
            this.textMoveZ.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttZPlus
            // 
            resources.ApplyResources(this.buttZPlus, "buttZPlus");
            this.buttZPlus.BackColor = System.Drawing.Color.Navy;
            this.buttZPlus.Checked = false;
            this.buttZPlus.CheckImage = null;
            this.buttZPlus.Gapx = 5;
            this.buttZPlus.Gapy = 5;
            this.buttZPlus.GLBackgroundImage = null;
            this.buttZPlus.GLImage = null;
            this.buttZPlus.GLVisible = false;
            this.buttZPlus.GuiAnchor = null;
            this.buttZPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttZPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttZPlus.Name = "buttZPlus";
            this.buttZPlus.StyleName = null;
            this.buttZPlus.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttZPlus, resources.GetString("buttZPlus.ToolTip"));
            this.buttZPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttZPlus.Click += new System.EventHandler(this.buttZPlus_Click);
            this.buttZPlus.DoubleClick += new System.EventHandler(this.buttZPlus_Click);
            // 
            // ctlToolTip1
            // 
            this.ctlToolTip1.AutoPopDelay = 5000;
            this.ctlToolTip1.BackColor = System.Drawing.Color.Turquoise;
            this.ctlToolTip1.ForeColor = System.Drawing.Color.Navy;
            this.ctlToolTip1.InitialDelay = 1500;
            this.ctlToolTip1.ReshowDelay = 100;
            // 
            // ctlMove
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ctlMove";
            this.ctlToolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private ctlImageButton buttXMinus;
        private ctlTextBox textMoveX;
        private ctlImageButton buttXPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private ctlImageButton buttYMinus;
        private ctlImageButton buttYPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label11;
        private ctlImageButton buttZMinus;
        private ctlImageButton buttZPlus;
        private ctlImageButton buttOnPlatform;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctlImageButton buttCenter;
        private ctlTextBox textMoveY;
        private ctlTextBox textMoveZ;
        private ctlToolTip ctlToolTip1;
        private ctlImageButton buttArrange;
    }
}
