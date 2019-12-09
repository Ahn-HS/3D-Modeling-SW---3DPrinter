namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlScene
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlScene));
            this.contextMenuObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdRemoveObject = new System.Windows.Forms.ToolStripMenuItem();
            this.manipObject = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.treeScene = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdCopy = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.cmdDelete = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.cmdNewScene = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.contextMenuObject.SuspendLayout();
            this.manipObject.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuObject
            // 
            resources.ApplyResources(this.contextMenuObject, "contextMenuObject");
            this.contextMenuObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRemoveObject});
            this.contextMenuObject.Name = "contextMenuStrip1";
            // 
            // cmdRemoveObject
            // 
            resources.ApplyResources(this.cmdRemoveObject, "cmdRemoveObject");
            this.cmdRemoveObject.Name = "cmdRemoveObject";
            this.cmdRemoveObject.Click += new System.EventHandler(this.cmdRemoveObject_Click);
            // 
            // manipObject
            // 
            resources.ApplyResources(this.manipObject, "manipObject");
            this.manipObject.BackColor = System.Drawing.Color.Navy;
            this.manipObject.Controls.Add(this.ctlTitle1);
            this.manipObject.Controls.Add(this.treeScene);
            this.manipObject.Controls.Add(this.flowLayoutPanel1);
            this.manipObject.Name = "manipObject";
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
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttTreeview;
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // treeScene
            // 
            resources.ApplyResources(this.treeScene, "treeScene");
            this.treeScene.BackColor = System.Drawing.Color.RoyalBlue;
            this.treeScene.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeScene.ForeColor = System.Drawing.Color.White;
            this.treeScene.Name = "treeScene";
            this.treeScene.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeScene_NodeMouseClick);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.cmdCopy);
            this.flowLayoutPanel1.Controls.Add(this.cmdDelete);
            this.flowLayoutPanel1.Controls.Add(this.cmdNewScene);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // cmdCopy
            // 
            resources.ApplyResources(this.cmdCopy, "cmdCopy");
            this.cmdCopy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdCopy.Checked = false;
            this.cmdCopy.CheckImage = null;
            this.cmdCopy.Gapx = 5;
            this.cmdCopy.Gapy = 5;
            this.cmdCopy.GLBackgroundImage = null;
            this.cmdCopy.GLImage = null;
            this.cmdCopy.GLVisible = false;
            this.cmdCopy.GuiAnchor = null;
            this.cmdCopy.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdCopy.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.StyleName = null;
            this.cmdCopy.Tag = "";
            this.cmdCopy.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdDelete
            // 
            resources.ApplyResources(this.cmdDelete, "cmdDelete");
            this.cmdDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdDelete.Checked = false;
            this.cmdDelete.CheckImage = null;
            this.cmdDelete.Gapx = 5;
            this.cmdDelete.Gapy = 5;
            this.cmdDelete.GLBackgroundImage = null;
            this.cmdDelete.GLImage = null;
            this.cmdDelete.GLVisible = false;
            this.cmdDelete.GuiAnchor = null;
            this.cmdDelete.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelete.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.StyleName = null;
            this.cmdDelete.Tag = "";
            this.cmdDelete.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdNewScene
            // 
            resources.ApplyResources(this.cmdNewScene, "cmdNewScene");
            this.cmdNewScene.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdNewScene.Checked = false;
            this.cmdNewScene.CheckImage = null;
            this.cmdNewScene.Gapx = 5;
            this.cmdNewScene.Gapy = 5;
            this.cmdNewScene.GLBackgroundImage = null;
            this.cmdNewScene.GLImage = null;
            this.cmdNewScene.GLVisible = false;
            this.cmdNewScene.GuiAnchor = null;
            this.cmdNewScene.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdNewScene.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttX;
            this.cmdNewScene.Name = "cmdNewScene";
            this.cmdNewScene.StyleName = null;
            this.cmdNewScene.Tag = "";
            this.cmdNewScene.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdNewScene.Click += new System.EventHandler(this.cmdNewScene_Click);
            // 
            // ctlScene
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.manipObject);
            this.Name = "ctlScene";
            this.Resize += new System.EventHandler(this.ctlScene_Resize);
            this.contextMenuObject.ResumeLayout(false);
            this.manipObject.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel manipObject;
        private System.Windows.Forms.TreeView treeScene;
        private System.Windows.Forms.ContextMenuStrip contextMenuObject;
        private System.Windows.Forms.ToolStripMenuItem cmdRemoveObject;
        private ctlTitle ctlTitle1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctlImageButton cmdCopy;
        private ctlImageButton cmdDelete;
        private ctlImageButton cmdNewScene;

    }
}
