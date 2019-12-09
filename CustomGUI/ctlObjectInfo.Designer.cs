namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlObjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlObjectInfo));
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.tName = new System.Windows.Forms.Label();
            this.tVolume = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tCost = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tPoints = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tPolys = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tMin = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tMax = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tSize = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            resources.ApplyResources(this.layoutPanel, "layoutPanel");
            this.layoutPanel.BackColor = System.Drawing.Color.Navy;
            this.layoutPanel.Controls.Add(this.ctlTitle1);
            this.layoutPanel.Controls.Add(this.tName);
            this.layoutPanel.Controls.Add(this.tVolume);
            this.layoutPanel.Controls.Add(this.tCost);
            this.layoutPanel.Controls.Add(this.tPoints);
            this.layoutPanel.Controls.Add(this.tPolys);
            this.layoutPanel.Controls.Add(this.tMin);
            this.layoutPanel.Controls.Add(this.tMax);
            this.layoutPanel.Controls.Add(this.tSize);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Resize += new System.EventHandler(this.layoutPanel_Resize);
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
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttOinfo;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // tName
            // 
            resources.ApplyResources(this.tName, "tName");
            this.tName.BackColor = System.Drawing.Color.RoyalBlue;
            this.tName.ForeColor = System.Drawing.Color.White;
            this.tName.Name = "tName";
            // 
            // tVolume
            // 
            resources.ApplyResources(this.tVolume, "tVolume");
            this.tVolume.BackColor = System.Drawing.Color.Navy;
            this.tVolume.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tVolume.DataColor = System.Drawing.Color.White;
            this.tVolume.DataText = "";
            this.tVolume.Gapx = 0;
            this.tVolume.Gapy = 0;
            this.tVolume.GLBackgroundImage = null;
            this.tVolume.GLVisible = false;
            this.tVolume.GuiAnchor = null;
            this.tVolume.Name = "tVolume";
            this.tVolume.StyleName = null;
            this.tVolume.TitleBackColor = System.Drawing.Color.Navy;
            this.tVolume.TitleColor = System.Drawing.Color.White;
            this.tVolume.TitleText = "Volume:";
            this.tVolume.TitleWidth = 35;
            // 
            // tCost
            // 
            resources.ApplyResources(this.tCost, "tCost");
            this.tCost.BackColor = System.Drawing.Color.Navy;
            this.tCost.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tCost.DataColor = System.Drawing.Color.White;
            this.tCost.DataText = "";
            this.tCost.Gapx = 0;
            this.tCost.Gapy = 0;
            this.tCost.GLBackgroundImage = null;
            this.tCost.GLVisible = false;
            this.tCost.GuiAnchor = null;
            this.tCost.Name = "tCost";
            this.tCost.StyleName = null;
            this.tCost.TitleBackColor = System.Drawing.Color.Navy;
            this.tCost.TitleColor = System.Drawing.Color.White;
            this.tCost.TitleText = "Cost:";
            this.tCost.TitleWidth = 35;
            // 
            // tPoints
            // 
            resources.ApplyResources(this.tPoints, "tPoints");
            this.tPoints.BackColor = System.Drawing.Color.Navy;
            this.tPoints.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tPoints.DataColor = System.Drawing.Color.White;
            this.tPoints.DataText = "";
            this.tPoints.Gapx = 0;
            this.tPoints.Gapy = 0;
            this.tPoints.GLBackgroundImage = null;
            this.tPoints.GLVisible = false;
            this.tPoints.GuiAnchor = null;
            this.tPoints.Name = "tPoints";
            this.tPoints.StyleName = null;
            this.tPoints.TitleBackColor = System.Drawing.Color.Navy;
            this.tPoints.TitleColor = System.Drawing.Color.White;
            this.tPoints.TitleText = "# Points:";
            this.tPoints.TitleWidth = 35;
            // 
            // tPolys
            // 
            resources.ApplyResources(this.tPolys, "tPolys");
            this.tPolys.BackColor = System.Drawing.Color.Navy;
            this.tPolys.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tPolys.DataColor = System.Drawing.Color.White;
            this.tPolys.DataText = "";
            this.tPolys.Gapx = 0;
            this.tPolys.Gapy = 0;
            this.tPolys.GLBackgroundImage = null;
            this.tPolys.GLVisible = false;
            this.tPolys.GuiAnchor = null;
            this.tPolys.Name = "tPolys";
            this.tPolys.StyleName = null;
            this.tPolys.TitleBackColor = System.Drawing.Color.Navy;
            this.tPolys.TitleColor = System.Drawing.Color.White;
            this.tPolys.TitleText = "# Polys:";
            this.tPolys.TitleWidth = 35;
            // 
            // tMin
            // 
            resources.ApplyResources(this.tMin, "tMin");
            this.tMin.BackColor = System.Drawing.Color.Navy;
            this.tMin.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tMin.DataColor = System.Drawing.Color.White;
            this.tMin.DataText = "";
            this.tMin.Gapx = 0;
            this.tMin.Gapy = 0;
            this.tMin.GLBackgroundImage = null;
            this.tMin.GLVisible = false;
            this.tMin.GuiAnchor = null;
            this.tMin.Name = "tMin";
            this.tMin.StyleName = null;
            this.tMin.TitleBackColor = System.Drawing.Color.Navy;
            this.tMin.TitleColor = System.Drawing.Color.White;
            this.tMin.TitleText = "Min:";
            this.tMin.TitleWidth = 20;
            // 
            // tMax
            // 
            resources.ApplyResources(this.tMax, "tMax");
            this.tMax.BackColor = System.Drawing.Color.Navy;
            this.tMax.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tMax.DataColor = System.Drawing.Color.White;
            this.tMax.DataText = "";
            this.tMax.Gapx = 0;
            this.tMax.Gapy = 0;
            this.tMax.GLBackgroundImage = null;
            this.tMax.GLVisible = false;
            this.tMax.GuiAnchor = null;
            this.tMax.Name = "tMax";
            this.tMax.StyleName = null;
            this.tMax.TitleBackColor = System.Drawing.Color.Navy;
            this.tMax.TitleColor = System.Drawing.Color.White;
            this.tMax.TitleText = "Max:";
            this.tMax.TitleWidth = 20;
            // 
            // tSize
            // 
            resources.ApplyResources(this.tSize, "tSize");
            this.tSize.BackColor = System.Drawing.Color.Navy;
            this.tSize.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.tSize.DataColor = System.Drawing.Color.White;
            this.tSize.DataText = "";
            this.tSize.Gapx = 0;
            this.tSize.Gapy = 0;
            this.tSize.GLBackgroundImage = null;
            this.tSize.GLVisible = false;
            this.tSize.GuiAnchor = null;
            this.tSize.Name = "tSize";
            this.tSize.StyleName = null;
            this.tSize.TitleBackColor = System.Drawing.Color.Navy;
            this.tSize.TitleColor = System.Drawing.Color.White;
            this.tSize.TitleText = "Size:";
            this.tSize.TitleWidth = 21;
            // 
            // ctlObjectInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.layoutPanel);
            this.Name = "ctlObjectInfo";
            this.Resize += new System.EventHandler(this.ctlObjectInfo_Resize);
            this.layoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Label tName;
        private ctlInfoItem tVolume;
        private ctlInfoItem tCost;
        private ctlInfoItem tPoints;
        private ctlInfoItem tPolys;
        private ctlInfoItem tMin;
        private ctlInfoItem tMax;
        private ctlInfoItem tSize;
        private ctlTitle ctlTitle1;
    }
}
