namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlScale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlScale));
            this.manipObject = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.textScaleAll = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttScaleAll = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textScaleX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttScaleX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textScaleY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttScaleY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textScaleZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttScaleZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttmm2inch = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttinch2mm = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.manipObject.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // manipObject
            // 
            resources.ApplyResources(this.manipObject, "manipObject");
            this.manipObject.BackColor = System.Drawing.Color.Navy;
            this.manipObject.Controls.Add(this.flowLayoutPanel4);
            this.manipObject.Controls.Add(this.flowLayoutPanel1);
            this.manipObject.Controls.Add(this.flowLayoutPanel3);
            this.manipObject.Controls.Add(this.flowLayoutPanel5);
            this.manipObject.Controls.Add(this.flowLayoutPanel2);
            this.manipObject.Name = "manipObject";
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel4.Controls.Add(this.label12);
            this.flowLayoutPanel4.Controls.Add(this.textScaleAll);
            this.flowLayoutPanel4.Controls.Add(this.buttScaleAll);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // textScaleAll
            // 
            resources.ApplyResources(this.textScaleAll, "textScaleAll");
            this.textScaleAll.BackColor = System.Drawing.Color.Navy;
            this.textScaleAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleAll.ErrorColor = System.Drawing.Color.Red;
            this.textScaleAll.FloatVal = 100F;
            this.textScaleAll.ForeColor = System.Drawing.Color.White;
            this.textScaleAll.IntVal = 100;
            this.textScaleAll.MaxFloat = 1000F;
            this.textScaleAll.MaxInt = 1000;
            this.textScaleAll.MinFloat = 1F;
            this.textScaleAll.MinInt = 1;
            this.textScaleAll.Name = "textScaleAll";
            this.textScaleAll.ValidColor = System.Drawing.Color.White;
            this.textScaleAll.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttScaleAll
            // 
            resources.ApplyResources(this.buttScaleAll, "buttScaleAll");
            this.buttScaleAll.BackColor = System.Drawing.Color.Navy;
            this.buttScaleAll.Checked = false;
            this.buttScaleAll.CheckImage = null;
            this.buttScaleAll.Gapx = 5;
            this.buttScaleAll.Gapy = 5;
            this.buttScaleAll.GLBackgroundImage = null;
            this.buttScaleAll.GLImage = null;
            this.buttScaleAll.GLVisible = false;
            this.buttScaleAll.GuiAnchor = null;
            this.buttScaleAll.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleAll.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.buttScaleAll.Name = "buttScaleAll";
            this.buttScaleAll.StyleName = null;
            this.buttScaleAll.Tag = "";
            this.buttScaleAll.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleAll.Click += new System.EventHandler(this.buttScaleAll_Click);
            this.buttScaleAll.DoubleClick += new System.EventHandler(this.buttScaleAll_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textScaleX);
            this.flowLayoutPanel1.Controls.Add(this.buttScaleX);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // textScaleX
            // 
            resources.ApplyResources(this.textScaleX, "textScaleX");
            this.textScaleX.BackColor = System.Drawing.Color.Navy;
            this.textScaleX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleX.ErrorColor = System.Drawing.Color.Red;
            this.textScaleX.FloatVal = 100F;
            this.textScaleX.ForeColor = System.Drawing.Color.White;
            this.textScaleX.IntVal = 100;
            this.textScaleX.MaxFloat = 1000F;
            this.textScaleX.MaxInt = 1000;
            this.textScaleX.MinFloat = 1F;
            this.textScaleX.MinInt = 1;
            this.textScaleX.Name = "textScaleX";
            this.textScaleX.ValidColor = System.Drawing.Color.White;
            this.textScaleX.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttScaleX
            // 
            resources.ApplyResources(this.buttScaleX, "buttScaleX");
            this.buttScaleX.BackColor = System.Drawing.Color.Navy;
            this.buttScaleX.Checked = false;
            this.buttScaleX.CheckImage = null;
            this.buttScaleX.Gapx = 5;
            this.buttScaleX.Gapy = 5;
            this.buttScaleX.GLBackgroundImage = null;
            this.buttScaleX.GLImage = null;
            this.buttScaleX.GLVisible = false;
            this.buttScaleX.GuiAnchor = null;
            this.buttScaleX.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleX.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.buttScaleX.Name = "buttScaleX";
            this.buttScaleX.StyleName = null;
            this.buttScaleX.Tag = "";
            this.buttScaleX.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleX.Click += new System.EventHandler(this.buttScaleX_Click);
            this.buttScaleX.DoubleClick += new System.EventHandler(this.buttScaleX_Click);
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.textScaleY);
            this.flowLayoutPanel3.Controls.Add(this.buttScaleY);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // textScaleY
            // 
            resources.ApplyResources(this.textScaleY, "textScaleY");
            this.textScaleY.BackColor = System.Drawing.Color.Navy;
            this.textScaleY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleY.ErrorColor = System.Drawing.Color.Red;
            this.textScaleY.FloatVal = 100F;
            this.textScaleY.ForeColor = System.Drawing.Color.White;
            this.textScaleY.IntVal = 100;
            this.textScaleY.MaxFloat = 1000F;
            this.textScaleY.MaxInt = 1000;
            this.textScaleY.MinFloat = 1F;
            this.textScaleY.MinInt = 1;
            this.textScaleY.Name = "textScaleY";
            this.textScaleY.ValidColor = System.Drawing.Color.White;
            this.textScaleY.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttScaleY
            // 
            resources.ApplyResources(this.buttScaleY, "buttScaleY");
            this.buttScaleY.BackColor = System.Drawing.Color.Navy;
            this.buttScaleY.Checked = false;
            this.buttScaleY.CheckImage = null;
            this.buttScaleY.Gapx = 5;
            this.buttScaleY.Gapy = 5;
            this.buttScaleY.GLBackgroundImage = null;
            this.buttScaleY.GLImage = null;
            this.buttScaleY.GLVisible = false;
            this.buttScaleY.GuiAnchor = null;
            this.buttScaleY.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleY.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.buttScaleY.Name = "buttScaleY";
            this.buttScaleY.StyleName = null;
            this.buttScaleY.Tag = "";
            this.buttScaleY.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleY.Click += new System.EventHandler(this.buttScaleY_Click);
            this.buttScaleY.DoubleClick += new System.EventHandler(this.buttScaleY_Click);
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.textScaleZ);
            this.flowLayoutPanel5.Controls.Add(this.buttScaleZ);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // textScaleZ
            // 
            resources.ApplyResources(this.textScaleZ, "textScaleZ");
            this.textScaleZ.BackColor = System.Drawing.Color.Navy;
            this.textScaleZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleZ.ErrorColor = System.Drawing.Color.Red;
            this.textScaleZ.FloatVal = 100F;
            this.textScaleZ.ForeColor = System.Drawing.Color.White;
            this.textScaleZ.IntVal = 100;
            this.textScaleZ.MaxFloat = 1000F;
            this.textScaleZ.MaxInt = 1000;
            this.textScaleZ.MinFloat = 1F;
            this.textScaleZ.MinInt = 1;
            this.textScaleZ.Name = "textScaleZ";
            this.textScaleZ.ValidColor = System.Drawing.Color.White;
            this.textScaleZ.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttScaleZ
            // 
            resources.ApplyResources(this.buttScaleZ, "buttScaleZ");
            this.buttScaleZ.BackColor = System.Drawing.Color.Navy;
            this.buttScaleZ.Checked = false;
            this.buttScaleZ.CheckImage = null;
            this.buttScaleZ.Gapx = 5;
            this.buttScaleZ.Gapy = 5;
            this.buttScaleZ.GLBackgroundImage = null;
            this.buttScaleZ.GLImage = null;
            this.buttScaleZ.GLVisible = false;
            this.buttScaleZ.GuiAnchor = null;
            this.buttScaleZ.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleZ.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.buttScaleZ.Name = "buttScaleZ";
            this.buttScaleZ.StyleName = null;
            this.buttScaleZ.Tag = "";
            this.buttScaleZ.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScaleZ.Click += new System.EventHandler(this.buttScaleZ_Click);
            this.buttScaleZ.DoubleClick += new System.EventHandler(this.buttScaleZ_Click);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Controls.Add(this.buttmm2inch);
            this.flowLayoutPanel2.Controls.Add(this.buttinch2mm);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // buttmm2inch
            // 
            resources.ApplyResources(this.buttmm2inch, "buttmm2inch");
            this.buttmm2inch.Checked = false;
            this.buttmm2inch.CheckImage = null;
            this.buttmm2inch.Gapx = 5;
            this.buttmm2inch.Gapy = 5;
            this.buttmm2inch.GLBackgroundImage = null;
            this.buttmm2inch.GLImage = null;
            this.buttmm2inch.GLVisible = false;
            this.buttmm2inch.GuiAnchor = null;
            this.buttmm2inch.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttmm2inch.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMmInch;
            this.buttmm2inch.Name = "buttmm2inch";
            this.buttmm2inch.StyleName = null;
            this.buttmm2inch.Tag = "";
            this.buttmm2inch.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttmm2inch.Click += new System.EventHandler(this.buttmm2inch_Click);
            // 
            // buttinch2mm
            // 
            resources.ApplyResources(this.buttinch2mm, "buttinch2mm");
            this.buttinch2mm.Checked = false;
            this.buttinch2mm.CheckImage = null;
            this.buttinch2mm.Gapx = 5;
            this.buttinch2mm.Gapy = 5;
            this.buttinch2mm.GLBackgroundImage = null;
            this.buttinch2mm.GLImage = null;
            this.buttinch2mm.GLVisible = false;
            this.buttinch2mm.GuiAnchor = null;
            this.buttinch2mm.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttinch2mm.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttInchMm;
            this.buttinch2mm.Name = "buttinch2mm";
            this.buttinch2mm.StyleName = null;
            this.buttinch2mm.Tag = "";
            this.buttinch2mm.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttinch2mm.Click += new System.EventHandler(this.buttinch2mm_Click);
            // 
            // ctlTitle1
            // 
            resources.ApplyResources(this.ctlTitle1, "ctlTitle1");
            this.ctlTitle1.BackColor = System.Drawing.Color.Navy;
            this.ctlTitle1.Checked = false;
            this.ctlTitle1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttStateTrig;
            this.ctlTitle1.Gapx = 0;
            this.ctlTitle1.Gapy = 0;
            this.ctlTitle1.GLBackgroundImage = null;
            this.ctlTitle1.GLVisible = false;
            this.ctlTitle1.GuiAnchor = null;
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttScale;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // ctlScale
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.manipObject);
            this.Controls.Add(this.ctlTitle1);
            this.Name = "ctlScale";
            this.Resize += new System.EventHandler(this.ctlScale_Resize);
            this.manipObject.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel manipObject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label12;
        private ctlTextBox textScaleAll;
        private ctlImageButton buttScaleAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private ctlImageButton buttScaleX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private ctlImageButton buttScaleY;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private ctlTextBox textScaleZ;
        private ctlImageButton buttScaleZ;
        private ctlTextBox textScaleX;
        private ctlTextBox textScaleY;
        private ctlTitle ctlTitle1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ctlImageButton buttmm2inch;
        private ctlImageButton buttinch2mm;

    }
}
