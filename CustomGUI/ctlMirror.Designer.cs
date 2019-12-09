﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlMirror
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMirror));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.lblX);
            this.flowLayoutPanel1.Controls.Add(this.lblY);
            this.flowLayoutPanel1.Controls.Add(this.lblZ);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // lblX
            // 
            resources.ApplyResources(this.lblX, "lblX");
            this.lblX.BackColor = System.Drawing.Color.Navy;
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Name = "lblX";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblY
            // 
            resources.ApplyResources(this.lblY, "lblY");
            this.lblY.BackColor = System.Drawing.Color.Navy;
            this.lblY.ForeColor = System.Drawing.Color.White;
            this.lblY.Name = "lblY";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // lblZ
            // 
            resources.ApplyResources(this.lblZ, "lblZ");
            this.lblZ.BackColor = System.Drawing.Color.Navy;
            this.lblZ.ForeColor = System.Drawing.Color.White;
            this.lblZ.Name = "lblZ";
            this.lblZ.Click += new System.EventHandler(this.lblZ_Click);
            // 
            // ctlTitle1
            // 
            resources.ApplyResources(this.ctlTitle1, "ctlTitle1");
            this.ctlTitle1.BackColor = System.Drawing.Color.DarkBlue;
            this.ctlTitle1.Checked = false;
            this.ctlTitle1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttStateTrig;
            this.ctlTitle1.Gapx = 0;
            this.ctlTitle1.Gapy = 0;
            this.ctlTitle1.GLBackgroundImage = null;
            this.ctlTitle1.GLVisible = false;
            this.ctlTitle1.GuiAnchor = null;
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMirror;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // ctlMirror
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ctlTitle1);
            this.Name = "ctlMirror";
            this.Resize += new System.EventHandler(this.ctlMirror_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlTitle ctlTitle1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
    }
}
