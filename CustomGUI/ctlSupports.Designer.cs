namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlSupports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlSupports));
            this.progressTitle = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlProgress();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttAddSupToBase = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttAddSupToFace2 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttAutoSupport = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttGenBase = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttRemoveType1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttRemoveType2 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttRemoveSupports = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.panelSuppotShape = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numBtip = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numCtip = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numOtip = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numItip = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.label1 = new System.Windows.Forms.Label();
            this.numFB1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numFB = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numFT = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numHB = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numHT = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.pictureSupport = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDownPolys = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.numDownAngle = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAutoDownFill = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.numGap = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.cmbSupType = new System.Windows.Forms.ComboBox();
            this.chkOnlyDownward = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.numY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAutoSup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdRemoveSupports = new System.Windows.Forms.Button();
            this.lbSupports = new System.Windows.Forms.ListView();
            this.Supports = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.ctlToolTip1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlToolTip();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelSuppotShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressTitle
            // 
            resources.ApplyResources(this.progressTitle, "progressTitle");
            this.progressTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.progressTitle.BarColor = System.Drawing.Color.RoyalBlue;
            this.progressTitle.BorderThickness = 2;
            this.progressTitle.ForeColor = System.Drawing.Color.White;
            this.progressTitle.Maximum = 100;
            this.progressTitle.Minimum = 0;
            this.progressTitle.Name = "progressTitle";
            this.ctlToolTip1.SetToolTip(this.progressTitle, resources.GetString("progressTitle.ToolTip"));
            this.progressTitle.Value = 0;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.buttAddSupToBase);
            this.flowLayoutPanel1.Controls.Add(this.buttAddSupToFace2);
            this.flowLayoutPanel1.Controls.Add(this.buttAutoSupport);
            this.flowLayoutPanel1.Controls.Add(this.buttGenBase);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // buttAddSupToBase
            // 
            resources.ApplyResources(this.buttAddSupToBase, "buttAddSupToBase");
            this.buttAddSupToBase.BackColor = System.Drawing.Color.Navy;
            this.buttAddSupToBase.Checked = false;
            this.buttAddSupToBase.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttAddSupToBase.Gapx = 5;
            this.buttAddSupToBase.Gapy = 5;
            this.buttAddSupToBase.GLBackgroundImage = null;
            this.buttAddSupToBase.GLImage = null;
            this.buttAddSupToBase.GLVisible = false;
            this.buttAddSupToBase.GuiAnchor = null;
            this.buttAddSupToBase.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupToBase.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAddSupport;
            this.buttAddSupToBase.Name = "buttAddSupToBase";
            this.buttAddSupToBase.StyleName = null;
            this.buttAddSupToBase.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttAddSupToBase, resources.GetString("buttAddSupToBase.ToolTip"));
            this.buttAddSupToBase.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupToBase.Click += new System.EventHandler(this.buttAddSupToBase_Click);
            // 
            // buttAddSupToFace2
            // 
            resources.ApplyResources(this.buttAddSupToFace2, "buttAddSupToFace2");
            this.buttAddSupToFace2.BackColor = System.Drawing.Color.Navy;
            this.buttAddSupToFace2.Checked = false;
            this.buttAddSupToFace2.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttAddSupToFace2.Gapx = 5;
            this.buttAddSupToFace2.Gapy = 5;
            this.buttAddSupToFace2.GLBackgroundImage = null;
            this.buttAddSupToFace2.GLImage = null;
            this.buttAddSupToFace2.GLVisible = false;
            this.buttAddSupToFace2.GuiAnchor = null;
            this.buttAddSupToFace2.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupToFace2.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAddSupportFace2;
            this.buttAddSupToFace2.Name = "buttAddSupToFace2";
            this.buttAddSupToFace2.StyleName = null;
            this.buttAddSupToFace2.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttAddSupToFace2, resources.GetString("buttAddSupToFace2.ToolTip"));
            this.buttAddSupToFace2.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupToFace2.Click += new System.EventHandler(this.buttAddSupToFace_Click);
            // 
            // buttAutoSupport
            // 
            resources.ApplyResources(this.buttAutoSupport, "buttAutoSupport");
            this.buttAutoSupport.BackColor = System.Drawing.Color.Navy;
            this.buttAutoSupport.Checked = false;
            this.buttAutoSupport.CheckImage = null;
            this.buttAutoSupport.Gapx = 5;
            this.buttAutoSupport.Gapy = 5;
            this.buttAutoSupport.GLBackgroundImage = null;
            this.buttAutoSupport.GLImage = null;
            this.buttAutoSupport.GLVisible = false;
            this.buttAutoSupport.GuiAnchor = null;
            this.buttAutoSupport.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAutoSupport.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAutoSupport;
            this.buttAutoSupport.Name = "buttAutoSupport";
            this.buttAutoSupport.StyleName = null;
            this.buttAutoSupport.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttAutoSupport, resources.GetString("buttAutoSupport.ToolTip"));
            this.buttAutoSupport.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAutoSupport.Click += new System.EventHandler(this.buttAutoSupport_Click);
            // 
            // buttGenBase
            // 
            resources.ApplyResources(this.buttGenBase, "buttGenBase");
            this.buttGenBase.BackColor = System.Drawing.Color.Navy;
            this.buttGenBase.Checked = false;
            this.buttGenBase.CheckImage = null;
            this.buttGenBase.Gapx = 5;
            this.buttGenBase.Gapy = 5;
            this.buttGenBase.GLBackgroundImage = null;
            this.buttGenBase.GLImage = null;
            this.buttGenBase.GLVisible = false;
            this.buttGenBase.GuiAnchor = null;
            this.buttGenBase.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttGenBase.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttSupBase;
            this.buttGenBase.Name = "buttGenBase";
            this.buttGenBase.StyleName = null;
            this.buttGenBase.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttGenBase, resources.GetString("buttGenBase.ToolTip"));
            this.buttGenBase.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttGenBase.Click += new System.EventHandler(this.buttGenBase_Click);
            // 
            // buttRemoveType1
            // 
            resources.ApplyResources(this.buttRemoveType1, "buttRemoveType1");
            this.buttRemoveType1.BackColor = System.Drawing.Color.Navy;
            this.buttRemoveType1.Checked = false;
            this.buttRemoveType1.CheckImage = null;
            this.buttRemoveType1.Gapx = 5;
            this.buttRemoveType1.Gapy = 5;
            this.buttRemoveType1.GLBackgroundImage = null;
            this.buttRemoveType1.GLImage = null;
            this.buttRemoveType1.GLVisible = false;
            this.buttRemoveType1.GuiAnchor = null;
            this.buttRemoveType1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveType1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRemoveType1;
            this.buttRemoveType1.Name = "buttRemoveType1";
            this.buttRemoveType1.StyleName = null;
            this.buttRemoveType1.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttRemoveType1, resources.GetString("buttRemoveType1.ToolTip"));
            this.buttRemoveType1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveType1.Click += new System.EventHandler(this.buttRemoveType1_Click);
            // 
            // buttRemoveType2
            // 
            resources.ApplyResources(this.buttRemoveType2, "buttRemoveType2");
            this.buttRemoveType2.BackColor = System.Drawing.Color.Navy;
            this.buttRemoveType2.Checked = false;
            this.buttRemoveType2.CheckImage = null;
            this.buttRemoveType2.Gapx = 5;
            this.buttRemoveType2.Gapy = 5;
            this.buttRemoveType2.GLBackgroundImage = null;
            this.buttRemoveType2.GLImage = null;
            this.buttRemoveType2.GLVisible = false;
            this.buttRemoveType2.GuiAnchor = null;
            this.buttRemoveType2.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveType2.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRemoveType2;
            this.buttRemoveType2.Name = "buttRemoveType2";
            this.buttRemoveType2.StyleName = null;
            this.buttRemoveType2.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttRemoveType2, resources.GetString("buttRemoveType2.ToolTip"));
            this.buttRemoveType2.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveType2.Click += new System.EventHandler(this.buttRemoveType2_Click);
            // 
            // buttRemoveSupports
            // 
            resources.ApplyResources(this.buttRemoveSupports, "buttRemoveSupports");
            this.buttRemoveSupports.BackColor = System.Drawing.Color.Navy;
            this.buttRemoveSupports.Checked = false;
            this.buttRemoveSupports.CheckImage = null;
            this.buttRemoveSupports.Gapx = 5;
            this.buttRemoveSupports.Gapy = 5;
            this.buttRemoveSupports.GLBackgroundImage = null;
            this.buttRemoveSupports.GLImage = null;
            this.buttRemoveSupports.GLVisible = false;
            this.buttRemoveSupports.GuiAnchor = null;
            this.buttRemoveSupports.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveSupports.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRemoveSupports;
            this.buttRemoveSupports.Name = "buttRemoveSupports";
            this.buttRemoveSupports.StyleName = null;
            this.buttRemoveSupports.Tag = "";
            this.ctlToolTip1.SetToolTip(this.buttRemoveSupports, resources.GetString("buttRemoveSupports.ToolTip"));
            this.buttRemoveSupports.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRemoveSupports.Click += new System.EventHandler(this.cmdRemoveSupports_Click);
            // 
            // panelSuppotShape
            // 
            resources.ApplyResources(this.panelSuppotShape, "panelSuppotShape");
            this.panelSuppotShape.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuppotShape.Controls.Add(this.label15);
            this.panelSuppotShape.Controls.Add(this.label14);
            this.panelSuppotShape.Controls.Add(this.label13);
            this.panelSuppotShape.Controls.Add(this.label12);
            this.panelSuppotShape.Controls.Add(this.numBtip);
            this.panelSuppotShape.Controls.Add(this.numCtip);
            this.panelSuppotShape.Controls.Add(this.numOtip);
            this.panelSuppotShape.Controls.Add(this.numItip);
            this.panelSuppotShape.Controls.Add(this.label1);
            this.panelSuppotShape.Controls.Add(this.numFB1);
            this.panelSuppotShape.Controls.Add(this.numFB);
            this.panelSuppotShape.Controls.Add(this.numFT);
            this.panelSuppotShape.Controls.Add(this.numHB);
            this.panelSuppotShape.Controls.Add(this.numHT);
            this.panelSuppotShape.Controls.Add(this.pictureSupport);
            this.panelSuppotShape.Controls.Add(this.label11);
            this.panelSuppotShape.Controls.Add(this.label10);
            this.panelSuppotShape.Controls.Add(this.label8);
            this.panelSuppotShape.Controls.Add(this.label5);
            this.panelSuppotShape.Controls.Add(this.pictureBox1);
            this.panelSuppotShape.ForeColor = System.Drawing.Color.White;
            this.panelSuppotShape.Name = "panelSuppotShape";
            this.ctlToolTip1.SetToolTip(this.panelSuppotShape, resources.GetString("panelSuppotShape.ToolTip"));
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Name = "label15";
            this.ctlToolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Name = "label14";
            this.ctlToolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Name = "label13";
            this.ctlToolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            this.ctlToolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // numBtip
            // 
            resources.ApplyResources(this.numBtip, "numBtip");
            this.numBtip.BackColor = System.Drawing.Color.RoyalBlue;
            this.numBtip.ButtonsColor = System.Drawing.Color.Navy;
            this.numBtip.Checked = false;
            this.numBtip.ErrorColor = System.Drawing.Color.Red;
            this.numBtip.FloatVal = 1F;
            this.numBtip.Gapx = 5;
            this.numBtip.Gapy = 5;
            this.numBtip.GLBackgroundImage = null;
            this.numBtip.GLVisible = false;
            this.numBtip.GuiAnchor = null;
            this.numBtip.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numBtip.Increment = 0.1F;
            this.numBtip.IntVal = 1;
            this.numBtip.IsFloat = true;
            this.numBtip.MaxFloat = 20F;
            this.numBtip.MaxInt = 1000;
            this.numBtip.MinFloat = 0.1F;
            this.numBtip.MinInt = 1;
            this.numBtip.Name = "numBtip";
            this.numBtip.StyleName = null;
            this.numBtip.Tag = "";
            this.numBtip.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numBtip, resources.GetString("numBtip.ToolTip"));
            this.numBtip.ValidColor = System.Drawing.Color.White;
            this.numBtip.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numBtip.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numCtip
            // 
            resources.ApplyResources(this.numCtip, "numCtip");
            this.numCtip.BackColor = System.Drawing.Color.RoyalBlue;
            this.numCtip.ButtonsColor = System.Drawing.Color.Navy;
            this.numCtip.Checked = false;
            this.numCtip.ErrorColor = System.Drawing.Color.Red;
            this.numCtip.FloatVal = 1F;
            this.numCtip.Gapx = 5;
            this.numCtip.Gapy = 5;
            this.numCtip.GLBackgroundImage = null;
            this.numCtip.GLVisible = false;
            this.numCtip.GuiAnchor = null;
            this.numCtip.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numCtip.Increment = 0.1F;
            this.numCtip.IntVal = 1;
            this.numCtip.IsFloat = true;
            this.numCtip.MaxFloat = 20F;
            this.numCtip.MaxInt = 1000;
            this.numCtip.MinFloat = 0.1F;
            this.numCtip.MinInt = 1;
            this.numCtip.Name = "numCtip";
            this.numCtip.StyleName = null;
            this.numCtip.Tag = "";
            this.numCtip.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numCtip, resources.GetString("numCtip.ToolTip"));
            this.numCtip.ValidColor = System.Drawing.Color.White;
            this.numCtip.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numCtip.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numOtip
            // 
            resources.ApplyResources(this.numOtip, "numOtip");
            this.numOtip.BackColor = System.Drawing.Color.RoyalBlue;
            this.numOtip.ButtonsColor = System.Drawing.Color.Navy;
            this.numOtip.Checked = false;
            this.numOtip.ErrorColor = System.Drawing.Color.Red;
            this.numOtip.FloatVal = 1F;
            this.numOtip.Gapx = 5;
            this.numOtip.Gapy = 5;
            this.numOtip.GLBackgroundImage = null;
            this.numOtip.GLVisible = false;
            this.numOtip.GuiAnchor = null;
            this.numOtip.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numOtip.Increment = 0.1F;
            this.numOtip.IntVal = 1;
            this.numOtip.IsFloat = true;
            this.numOtip.MaxFloat = 20F;
            this.numOtip.MaxInt = 1000;
            this.numOtip.MinFloat = 0.1F;
            this.numOtip.MinInt = 1;
            this.numOtip.Name = "numOtip";
            this.numOtip.StyleName = null;
            this.numOtip.Tag = "";
            this.numOtip.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numOtip, resources.GetString("numOtip.ToolTip"));
            this.numOtip.ValidColor = System.Drawing.Color.White;
            this.numOtip.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numOtip.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numItip
            // 
            resources.ApplyResources(this.numItip, "numItip");
            this.numItip.BackColor = System.Drawing.Color.RoyalBlue;
            this.numItip.ButtonsColor = System.Drawing.Color.Navy;
            this.numItip.Checked = false;
            this.numItip.ErrorColor = System.Drawing.Color.Red;
            this.numItip.FloatVal = 1F;
            this.numItip.Gapx = 5;
            this.numItip.Gapy = 5;
            this.numItip.GLBackgroundImage = null;
            this.numItip.GLVisible = false;
            this.numItip.GuiAnchor = null;
            this.numItip.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numItip.Increment = 0.1F;
            this.numItip.IntVal = 1;
            this.numItip.IsFloat = true;
            this.numItip.MaxFloat = 20F;
            this.numItip.MaxInt = 1000;
            this.numItip.MinFloat = 0.1F;
            this.numItip.MinInt = 1;
            this.numItip.Name = "numItip";
            this.numItip.StyleName = null;
            this.numItip.Tag = "";
            this.numItip.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numItip, resources.GetString("numItip.ToolTip"));
            this.numItip.ValidColor = System.Drawing.Color.White;
            this.numItip.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numItip.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.ctlToolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // numFB1
            // 
            resources.ApplyResources(this.numFB1, "numFB1");
            this.numFB1.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFB1.ButtonsColor = System.Drawing.Color.Navy;
            this.numFB1.Checked = false;
            this.numFB1.ErrorColor = System.Drawing.Color.Red;
            this.numFB1.FloatVal = 1F;
            this.numFB1.Gapx = 5;
            this.numFB1.Gapy = 5;
            this.numFB1.GLBackgroundImage = null;
            this.numFB1.GLVisible = false;
            this.numFB1.GuiAnchor = null;
            this.numFB1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFB1.Increment = 0.1F;
            this.numFB1.IntVal = 1;
            this.numFB1.IsFloat = true;
            this.numFB1.MaxFloat = 20F;
            this.numFB1.MaxInt = 1000;
            this.numFB1.MinFloat = 0.1F;
            this.numFB1.MinInt = 1;
            this.numFB1.Name = "numFB1";
            this.numFB1.StyleName = null;
            this.numFB1.Tag = "";
            this.numFB1.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFB1, resources.GetString("numFB1.ToolTip"));
            this.numFB1.ValidColor = System.Drawing.Color.White;
            this.numFB1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFB1.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            this.numFB1.Enter += new System.EventHandler(this.numFB1_Enter);
            // 
            // numFB
            // 
            resources.ApplyResources(this.numFB, "numFB");
            this.numFB.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFB.ButtonsColor = System.Drawing.Color.Navy;
            this.numFB.Checked = false;
            this.numFB.ErrorColor = System.Drawing.Color.Red;
            this.numFB.FloatVal = 1F;
            this.numFB.Gapx = 5;
            this.numFB.Gapy = 5;
            this.numFB.GLBackgroundImage = null;
            this.numFB.GLVisible = false;
            this.numFB.GuiAnchor = null;
            this.numFB.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFB.Increment = 0.1F;
            this.numFB.IntVal = 1;
            this.numFB.IsFloat = true;
            this.numFB.MaxFloat = 20F;
            this.numFB.MaxInt = 1000;
            this.numFB.MinFloat = 0.1F;
            this.numFB.MinInt = 1;
            this.numFB.Name = "numFB";
            this.numFB.StyleName = null;
            this.numFB.Tag = "";
            this.numFB.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFB, resources.GetString("numFB.ToolTip"));
            this.numFB.ValidColor = System.Drawing.Color.White;
            this.numFB.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFB.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            this.numFB.Enter += new System.EventHandler(this.numFB_Enter);
            // 
            // numFT
            // 
            resources.ApplyResources(this.numFT, "numFT");
            this.numFT.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFT.ButtonsColor = System.Drawing.Color.Navy;
            this.numFT.Checked = false;
            this.numFT.ErrorColor = System.Drawing.Color.Red;
            this.numFT.FloatVal = 1F;
            this.numFT.Gapx = 5;
            this.numFT.Gapy = 5;
            this.numFT.GLBackgroundImage = null;
            this.numFT.GLVisible = false;
            this.numFT.GuiAnchor = null;
            this.numFT.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFT.Increment = 0.1F;
            this.numFT.IntVal = 1;
            this.numFT.IsFloat = true;
            this.numFT.MaxFloat = 20F;
            this.numFT.MaxInt = 1000;
            this.numFT.MinFloat = 0.1F;
            this.numFT.MinInt = 1;
            this.numFT.Name = "numFT";
            this.numFT.StyleName = null;
            this.numFT.Tag = "";
            this.numFT.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFT, resources.GetString("numFT.ToolTip"));
            this.numFT.ValidColor = System.Drawing.Color.White;
            this.numFT.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numFT.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numHB
            // 
            resources.ApplyResources(this.numHB, "numHB");
            this.numHB.BackColor = System.Drawing.Color.RoyalBlue;
            this.numHB.ButtonsColor = System.Drawing.Color.Navy;
            this.numHB.Checked = false;
            this.numHB.ErrorColor = System.Drawing.Color.Red;
            this.numHB.FloatVal = 1F;
            this.numHB.Gapx = 5;
            this.numHB.Gapy = 5;
            this.numHB.GLBackgroundImage = null;
            this.numHB.GLVisible = false;
            this.numHB.GuiAnchor = null;
            this.numHB.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numHB.Increment = 0.1F;
            this.numHB.IntVal = 1;
            this.numHB.IsFloat = true;
            this.numHB.MaxFloat = 20F;
            this.numHB.MaxInt = 1000;
            this.numHB.MinFloat = 0.1F;
            this.numHB.MinInt = 1;
            this.numHB.Name = "numHB";
            this.numHB.StyleName = null;
            this.numHB.Tag = "";
            this.numHB.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numHB, resources.GetString("numHB.ToolTip"));
            this.numHB.ValidColor = System.Drawing.Color.White;
            this.numHB.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numHB.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numHT
            // 
            resources.ApplyResources(this.numHT, "numHT");
            this.numHT.BackColor = System.Drawing.Color.RoyalBlue;
            this.numHT.ButtonsColor = System.Drawing.Color.Navy;
            this.numHT.Checked = false;
            this.numHT.ErrorColor = System.Drawing.Color.Red;
            this.numHT.FloatVal = 1F;
            this.numHT.Gapx = 5;
            this.numHT.Gapy = 5;
            this.numHT.GLBackgroundImage = null;
            this.numHT.GLVisible = false;
            this.numHT.GuiAnchor = null;
            this.numHT.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numHT.Increment = 0.1F;
            this.numHT.IntVal = 1;
            this.numHT.IsFloat = true;
            this.numHT.MaxFloat = 20F;
            this.numHT.MaxInt = 1000;
            this.numHT.MinFloat = 0.1F;
            this.numHT.MinInt = 1;
            this.numHT.Name = "numHT";
            this.numHT.StyleName = null;
            this.numHT.Tag = "";
            this.numHT.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numHT, resources.GetString("numHT.ToolTip"));
            this.numHT.ValidColor = System.Drawing.Color.White;
            this.numHT.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numHT.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // pictureSupport
            // 
            resources.ApplyResources(this.pictureSupport, "pictureSupport");
            this.pictureSupport.Name = "pictureSupport";
            this.pictureSupport.TabStop = false;
            this.ctlToolTip1.SetToolTip(this.pictureSupport, resources.GetString("pictureSupport.ToolTip"));
            this.pictureSupport.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureSupport_Paint);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Name = "label11";
            this.ctlToolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            this.ctlToolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            this.ctlToolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            this.ctlToolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::UV_DLP_3D_Printer.Properties.Resources.text3768;
            this.pictureBox1.InitialImage = global::UV_DLP_3D_Printer.Properties.Resources.text3768;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.ctlToolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.chkDownPolys);
            this.panel1.Controls.Add(this.numDownAngle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            this.ctlToolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // chkDownPolys
            // 
            resources.ApplyResources(this.chkDownPolys, "chkDownPolys");
            this.chkDownPolys.BackColor = System.Drawing.Color.Navy;
            this.chkDownPolys.Checked = false;
            this.chkDownPolys.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.chkDownPolys.Gapx = 5;
            this.chkDownPolys.Gapy = 5;
            this.chkDownPolys.GLBackgroundImage = null;
            this.chkDownPolys.GLImage = null;
            this.chkDownPolys.GLVisible = false;
            this.chkDownPolys.GuiAnchor = null;
            this.chkDownPolys.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.chkDownPolys.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttViewDown;
            this.chkDownPolys.Name = "chkDownPolys";
            this.chkDownPolys.StyleName = null;
            this.chkDownPolys.Tag = "";
            this.ctlToolTip1.SetToolTip(this.chkDownPolys, resources.GetString("chkDownPolys.ToolTip"));
            this.chkDownPolys.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.chkDownPolys.Click += new System.EventHandler(this.chkDownPolys_Click);
            // 
            // numDownAngle
            // 
            resources.ApplyResources(this.numDownAngle, "numDownAngle");
            this.numDownAngle.BackColor = System.Drawing.Color.RoyalBlue;
            this.numDownAngle.ButtonsColor = System.Drawing.Color.Navy;
            this.numDownAngle.Checked = false;
            this.numDownAngle.ErrorColor = System.Drawing.Color.Red;
            this.numDownAngle.FloatVal = 17F;
            this.numDownAngle.Gapx = 5;
            this.numDownAngle.Gapy = 5;
            this.numDownAngle.GLBackgroundImage = null;
            this.numDownAngle.GLVisible = false;
            this.numDownAngle.GuiAnchor = null;
            this.numDownAngle.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numDownAngle.Increment = 1F;
            this.numDownAngle.IntVal = 1;
            this.numDownAngle.IsFloat = true;
            this.numDownAngle.MaxFloat = 90F;
            this.numDownAngle.MaxInt = 90;
            this.numDownAngle.MinFloat = 0F;
            this.numDownAngle.MinInt = 0;
            this.numDownAngle.Name = "numDownAngle";
            this.numDownAngle.StyleName = null;
            this.numDownAngle.Tag = "";
            this.numDownAngle.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numDownAngle, resources.GetString("numDownAngle.ToolTip"));
            this.numDownAngle.ValidColor = System.Drawing.Color.White;
            this.numDownAngle.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numDownAngle.ValueChanged += new System.EventHandler(this.numDownAngle_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.ctlToolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.ctlToolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.chkAutoDownFill);
            this.panel2.Controls.Add(this.numGap);
            this.panel2.Controls.Add(this.cmbSupType);
            this.panel2.Controls.Add(this.chkOnlyDownward);
            this.panel2.Controls.Add(this.numY);
            this.panel2.Controls.Add(this.numX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelAutoSup);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Name = "panel2";
            this.ctlToolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // chkAutoDownFill
            // 
            resources.ApplyResources(this.chkAutoDownFill, "chkAutoDownFill");
            this.chkAutoDownFill.BackColor = System.Drawing.Color.Navy;
            this.chkAutoDownFill.Checked = false;
            this.chkAutoDownFill.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.chkAutoDownFill.Gapx = 5;
            this.chkAutoDownFill.Gapy = 5;
            this.chkAutoDownFill.GLBackgroundImage = null;
            this.chkAutoDownFill.GLImage = null;
            this.chkAutoDownFill.GLVisible = false;
            this.chkAutoDownFill.GuiAnchor = null;
            this.chkAutoDownFill.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.chkAutoDownFill.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttDownFill;
            this.chkAutoDownFill.Name = "chkAutoDownFill";
            this.chkAutoDownFill.StyleName = null;
            this.chkAutoDownFill.Tag = "";
            this.ctlToolTip1.SetToolTip(this.chkAutoDownFill, resources.GetString("chkAutoDownFill.ToolTip"));
            this.chkAutoDownFill.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // numGap
            // 
            resources.ApplyResources(this.numGap, "numGap");
            this.numGap.BackColor = System.Drawing.Color.RoyalBlue;
            this.numGap.ButtonsColor = System.Drawing.Color.Navy;
            this.numGap.Checked = false;
            this.numGap.ErrorColor = System.Drawing.Color.Red;
            this.numGap.FloatVal = 1F;
            this.numGap.Gapx = 5;
            this.numGap.Gapy = 5;
            this.numGap.GLBackgroundImage = null;
            this.numGap.GLVisible = false;
            this.numGap.GuiAnchor = null;
            this.numGap.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numGap.Increment = 0.1F;
            this.numGap.IntVal = 1;
            this.numGap.IsFloat = true;
            this.numGap.MaxFloat = 20F;
            this.numGap.MaxInt = 1000;
            this.numGap.MinFloat = -20F;
            this.numGap.MinInt = 1;
            this.numGap.Name = "numGap";
            this.numGap.StyleName = null;
            this.numGap.Tag = "";
            this.numGap.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numGap, resources.GetString("numGap.ToolTip"));
            this.numGap.ValidColor = System.Drawing.Color.White;
            this.numGap.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // cmbSupType
            // 
            resources.ApplyResources(this.cmbSupType, "cmbSupType");
            this.cmbSupType.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbSupType.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbSupType.FormattingEnabled = true;
            this.cmbSupType.Items.AddRange(new object[] {
            resources.GetString("cmbSupType.Items"),
            resources.GetString("cmbSupType.Items1"),
            resources.GetString("cmbSupType.Items2")});
            this.cmbSupType.Name = "cmbSupType";
            this.ctlToolTip1.SetToolTip(this.cmbSupType, resources.GetString("cmbSupType.ToolTip"));
            this.cmbSupType.SelectedIndexChanged += new System.EventHandler(this.cmbSupType_SelectedIndexChanged);
            // 
            // chkOnlyDownward
            // 
            resources.ApplyResources(this.chkOnlyDownward, "chkOnlyDownward");
            this.chkOnlyDownward.BackColor = System.Drawing.Color.Navy;
            this.chkOnlyDownward.Checked = false;
            this.chkOnlyDownward.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.chkOnlyDownward.Gapx = 5;
            this.chkOnlyDownward.Gapy = 5;
            this.chkOnlyDownward.GLBackgroundImage = null;
            this.chkOnlyDownward.GLImage = null;
            this.chkOnlyDownward.GLVisible = false;
            this.chkOnlyDownward.GuiAnchor = null;
            this.chkOnlyDownward.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.chkOnlyDownward.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAutoDown;
            this.chkOnlyDownward.Name = "chkOnlyDownward";
            this.chkOnlyDownward.StyleName = null;
            this.chkOnlyDownward.Tag = "";
            this.ctlToolTip1.SetToolTip(this.chkOnlyDownward, resources.GetString("chkOnlyDownward.ToolTip"));
            this.chkOnlyDownward.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.chkOnlyDownward.Click += new System.EventHandler(this.chkOnlyDownward_Click);
            // 
            // numY
            // 
            resources.ApplyResources(this.numY, "numY");
            this.numY.BackColor = System.Drawing.Color.RoyalBlue;
            this.numY.ButtonsColor = System.Drawing.Color.Navy;
            this.numY.Checked = false;
            this.numY.ErrorColor = System.Drawing.Color.Red;
            this.numY.FloatVal = 1F;
            this.numY.Gapx = 5;
            this.numY.Gapy = 5;
            this.numY.GLBackgroundImage = null;
            this.numY.GLVisible = false;
            this.numY.GuiAnchor = null;
            this.numY.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numY.Increment = 0.1F;
            this.numY.IntVal = 1;
            this.numY.IsFloat = true;
            this.numY.MaxFloat = 20F;
            this.numY.MaxInt = 1000;
            this.numY.MinFloat = -20F;
            this.numY.MinInt = 1;
            this.numY.Name = "numY";
            this.numY.StyleName = null;
            this.numY.Tag = "";
            this.numY.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numY, resources.GetString("numY.ToolTip"));
            this.numY.ValidColor = System.Drawing.Color.White;
            this.numY.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // numX
            // 
            resources.ApplyResources(this.numX, "numX");
            this.numX.BackColor = System.Drawing.Color.RoyalBlue;
            this.numX.ButtonsColor = System.Drawing.Color.Navy;
            this.numX.Checked = false;
            this.numX.ErrorColor = System.Drawing.Color.Red;
            this.numX.FloatVal = 1F;
            this.numX.Gapx = 5;
            this.numX.Gapy = 5;
            this.numX.GLBackgroundImage = null;
            this.numX.GLVisible = false;
            this.numX.GuiAnchor = null;
            this.numX.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.numX.Increment = 0.1F;
            this.numX.IntVal = 1;
            this.numX.IsFloat = true;
            this.numX.MaxFloat = 20F;
            this.numX.MaxInt = 1000;
            this.numX.MinFloat = -20F;
            this.numX.MinInt = 1;
            this.numX.Name = "numX";
            this.numX.StyleName = null;
            this.numX.Tag = "";
            this.numX.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numX, resources.GetString("numX.ToolTip"));
            this.numX.ValidColor = System.Drawing.Color.White;
            this.numX.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            this.ctlToolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.ctlToolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // labelAutoSup
            // 
            resources.ApplyResources(this.labelAutoSup, "labelAutoSup");
            this.labelAutoSup.ForeColor = System.Drawing.Color.White;
            this.labelAutoSup.Name = "labelAutoSup";
            this.ctlToolTip1.SetToolTip(this.labelAutoSup, resources.GetString("labelAutoSup.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.ctlToolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.cmdRemoveSupports);
            this.panel3.Controls.Add(this.lbSupports);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Name = "panel3";
            this.ctlToolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // cmdRemoveSupports
            // 
            resources.ApplyResources(this.cmdRemoveSupports, "cmdRemoveSupports");
            this.cmdRemoveSupports.Name = "cmdRemoveSupports";
            this.ctlToolTip1.SetToolTip(this.cmdRemoveSupports, resources.GetString("cmdRemoveSupports.ToolTip"));
            this.cmdRemoveSupports.UseVisualStyleBackColor = true;
            this.cmdRemoveSupports.Click += new System.EventHandler(this.cmdRemoveSupports_Click);
            // 
            // lbSupports
            // 
            resources.ApplyResources(this.lbSupports, "lbSupports");
            this.lbSupports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Supports});
            this.lbSupports.FullRowSelect = true;
            this.lbSupports.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lbSupports.HideSelection = false;
            this.lbSupports.MultiSelect = false;
            this.lbSupports.Name = "lbSupports";
            this.ctlToolTip1.SetToolTip(this.lbSupports, resources.GetString("lbSupports.ToolTip"));
            this.lbSupports.UseCompatibleStateImageBehavior = false;
            this.lbSupports.View = System.Windows.Forms.View.Details;
            this.lbSupports.SelectedIndexChanged += new System.EventHandler(this.lbSupports_SelectedIndexChanged);
            // 
            // Supports
            // 
            resources.ApplyResources(this.Supports, "Supports");
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            this.ctlToolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // ctlToolTip1
            // 
            this.ctlToolTip1.AutoPopDelay = 5000;
            this.ctlToolTip1.BackColor = System.Drawing.Color.Turquoise;
            this.ctlToolTip1.ForeColor = System.Drawing.Color.Navy;
            this.ctlToolTip1.InitialDelay = 1500;
            this.ctlToolTip1.ReshowDelay = 100;
            // 
            // ctlTitle1
            // 
            resources.ApplyResources(this.ctlTitle1, "ctlTitle1");
            this.ctlTitle1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlTitle1.Checked = false;

            // by esyeon 2016-02-19
            //this.ctlTitle1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttStateTrig;
            // by esyeon 

            this.ctlTitle1.Gapx = 0;
            this.ctlTitle1.Gapy = 0;
            this.ctlTitle1.GLBackgroundImage = null;
            this.ctlTitle1.GLVisible = false;
            this.ctlTitle1.GuiAnchor = null;
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttSupport;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlToolTip1.SetToolTip(this.ctlTitle1, resources.GetString("ctlTitle1.ToolTip"));
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Controls.Add(this.buttRemoveType1);
            this.flowLayoutPanel2.Controls.Add(this.buttRemoveType2);
            this.flowLayoutPanel2.Controls.Add(this.buttRemoveSupports);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.ctlToolTip1.SetToolTip(this.flowLayoutPanel2, resources.GetString("flowLayoutPanel2.ToolTip"));
            // 
            // ctlSupports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.ctlTitle1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.progressTitle);
            this.Controls.Add(this.panelSuppotShape);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ctlSupports";
            this.Tag = "";
            this.ctlToolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelSuppotShape.ResumeLayout(false);
            this.panelSuppotShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctlImageButton buttAutoSupport;
        private ctlProgress progressTitle;
        private ctlToolTip ctlToolTip1;
        private System.Windows.Forms.Panel panelSuppotShape;
        private ctlNumber numHT;
        private System.Windows.Forms.PictureBox pictureSupport;
        private ctlNumber numFB;
        private ctlNumber numFT;
        private ctlNumber numHB;
        private ctlNumber numFB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ctlNumber numDownAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private ctlImageButton chkDownPolys;
        private ctlNumber numY;
        private ctlNumber numX;
        private ctlImageButton chkOnlyDownward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAutoSup;
        private System.Windows.Forms.ComboBox cmbSupType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lbSupports;
        private System.Windows.Forms.ColumnHeader Supports;
        private System.Windows.Forms.Button cmdRemoveSupports;
        private ctlTitle ctlTitle1;
        private ctlImageButton buttGenBase;
        private ctlNumber numGap;
        private ctlImageButton buttAddSupToBase;
        private ctlImageButton buttAddSupToFace2;
        private ctlImageButton chkAutoDownFill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private ctlNumber numBtip;
        private ctlNumber numCtip;
        private ctlNumber numOtip;
        private ctlNumber numItip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private ctlImageButton buttRemoveSupports;
        private ctlImageButton buttRemoveType1;
        private ctlImageButton buttRemoveType2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
