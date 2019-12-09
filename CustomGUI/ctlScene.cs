using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Engine3D;

namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    public partial class ctlScene : ctlAnchorable
    {
        bool ignorerefresh;
        public ctlScene()
        {
            InitializeComponent();
            UVDLPApp.Instance().AppEvent += new AppEventDelegate(AppEventDel);
            UpdateSceneTree();
            ignorerefresh = false;
        }
        private void AppEventDel(eAppEvent ev, String Message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { AppEventDel(ev, Message); }));
            }
            else
            {

                switch (ev)
                {
                    case eAppEvent.eObjectSelected:
                        Object3d sel = UVDLPApp.Instance().SelectedObject;
                        if (sel != null)
                        {
                            //highlist the selected
                            HighLightSelected(sel);
                        }
                        break;
                    case eAppEvent.eModelRemoved:
                    case eAppEvent.eModelAdded:
                        if (ignorerefresh) return;
                        UpdateSceneTree();

                        break;

                    // bye esyeon 2016-02-17
                    case eAppEvent.eModelSupportCompleted:
                        UpdateSceneTree(2);

                        break;
                    // by esyeon 
                }
                Refresh();
            }

        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                if (!isChecked)
                    node.BackColor = treeScene.BackColor;
            }
        }

        private void HighLightSelected(Object3d sel)
        {
            TreeNode sceneNode = treeScene.Nodes[0];
            CheckChildren(sceneNode, false);

            if ((sel.tag == Object3d.OBJ_NORMAL) || (sel.tag == Object3d.OBJ_SUPPORT_BASE))
            {
                foreach (TreeNode tni in sceneNode.Nodes)
                {
                    Object3d obj = (Object3d)tni.Tag;
                    if (obj == sel)
                    {
                        treeScene.SelectedNode = tni;
                        tni.BackColor = Color.White; // now set the selected color
                        treeScene.Update();
                        return;
                    }
                }

            }
            else
            {
                foreach (TreeNode tno in sceneNode.Nodes)
                {
                    Object3d obj = (Object3d)tno.Tag;
                    if (obj != sel.m_parent)
                        continue;
                    if (tno.Nodes.Count > 0)
                    {
                        foreach (TreeNode tni in tno.Nodes[0].Nodes)
                        {
                            Object3d supp = (Object3d)tni.Tag;
                            if (supp == sel)
                            {
                                treeScene.SelectedNode = tni;
                                tni.BackColor = Color.White; // now set the selected color
                                treeScene.Update();
                                return;
                            }
                        }
                    }
                }
            }
        }

        public override void ApplyStyle(GuiControlStyle ct)
        {
            base.ApplyStyle(ct);
            if (ct.ForeColor.IsValid())
            {
                ctlTitle1.ForeColor = ct.ForeColor;
                treeScene.ForeColor = ct.ForeColor;
                treeScene.LineColor = ct.ForeColor;
                cmdCopy.ForeColor = ct.ForeColor;
                cmdDelete.ForeColor = ct.ForeColor;
            }
            if (ct.BackColor.IsValid())
            {
                BackColor = ct.BackColor;
                manipObject.BackColor = ct.BackColor;
                cmdCopy.BackColor = ct.BackColor;
                cmdDelete.BackColor = ct.BackColor;

            }
            if (ct.FrameColor.IsValid())
            {
                treeScene.BackColor = ct.FrameColor;
                flowLayoutPanel1.BackColor = ct.FrameColor;
            }

        }

        #region Scene tree

        public void UpdateSceneTree(int nType = 0)
        {
            if (nType == 1)
                SetupSceneTree_AllDel();
            else if (nType == 2)
                SetupSceneTree_All();
            else
                //by esyeon 2016-02-19
                SetupSceneTree_All();
                //by esyeon
        }

        private TreeNode FindObjectNode(TreeNodeCollection nodes, Object3d sel)
        {
            TreeNode found = null;
            foreach (TreeNode node in nodes)
            {
                if (node.Tag == sel) { return node; }
                found = FindObjectNode(node.Nodes, sel);
                if (found != null) { break; }
            }
            return found;
        }

        // by esyeon 2016-02-17
        private void SetupSceneTree_AllDel()
        {
            treeScene.BeginUpdate();
            try
            {

                treeScene.Nodes.Clear();

                TreeNode scenenode = new TreeNode("Scene");
                treeScene.Nodes.Add(scenenode);
                UVDLPApp.Instance().SelectedObject = null;
            }
            finally
            {
                treeScene.EndUpdate();
            }
        }


        private void SetupSceneTree(int nType = 0)
        {
            treeScene.BeginUpdate();
            try
            {
                // by esyeon 2016-02-17
                //treeScene.Nodes.Clear();//clear the old


                TreeNode scenenode = null;
                if (treeScene.Nodes.Count == 0)
                {
                    scenenode = new TreeNode("Scene");
                    treeScene.Nodes.Add(scenenode);
                }
                else
                    scenenode = treeScene.Nodes[0];






                // by esyeon

                TreeNode selNode = null;

                Object3d obj = UVDLPApp.Instance().SelectedObject;

                if (obj != null && obj.tag == Object3d.OBJ_NORMAL)
                {
                    TreeNode objnode = new TreeNode(obj.Name);
                    // by esyeon 2016-02-17
                    objnode.Name = obj.Name;
                    // by esyeon 
                    objnode.Tag = obj;
                    if (nType == 0)
                    {
                        scenenode.Nodes.Add(objnode);
                    }
                    selNode = objnode;

                    if (obj.m_supports.Count() > 0) //if object has supports, create a node for them
                    {
                        TreeNode supnode = new TreeNode("Supports");
                        objnode.Nodes.Add(supnode);
                        supnode.Collapse();
                        foreach (Object3d sup in obj.m_supports)
                        {
                            if (sup.Visible == true)    // by esyeon 2016-02-23
                            { 
                                TreeNode tn = new TreeNode(sup.Name);
                                tn.Tag = sup;
                                supnode.Nodes.Add(tn);
                            }                           // by esyeon
                        }
                        supnode.ExpandAll();
                    }

                    objnode.ExpandAll();

                    if (selNode != null)
                        selNode.BackColor = Color.White;
                    scenenode.Expand();

                    treeScene.SelectedNode = objnode;

                }
                /*
                foreach (Object3d obj in UVDLPApp.Instance().Engine3D.m_objects)
                {
                
                    if(obj.tag == Object3d.OBJ_NORMAL)
                    {
                        TreeNode objnode = new TreeNode(obj.Name);
                        
                        // by esyeon 2016-02-17
                        objnode.Name = obj.Name;
                        // by esyeon 

                        objnode.Tag = obj;
                        scenenode.Nodes.Add(objnode);
                        if (obj == UVDLPApp.Instance().SelectedObject)  // expand this node
                        {
                            //objnode.BackColor = Color.LightBlue;
                            //treeScene.SelectedNode = objnode;
                            selNode = objnode;
                        }
                        if (obj.m_supports.Count() > 0) //if object has supports, create a node for them
                        {
                            TreeNode supnode = new TreeNode("Supports");
                            objnode.Nodes.Add(supnode);
                            supnode.Collapse();
                            foreach (Object3d sup in obj.m_supports) 
                            {
                                TreeNode tn = new TreeNode(sup.Name);
                                tn.Tag = sup;
                                supnode.Nodes.Add(tn);
                            }
                        }
                        objnode.ExpandAll();
                    }
                }
                 

                if (selNode != null)
                    selNode.BackColor = Color.White;
                scenenode.Expand();
                if (selNode != null)
                {
                    TreeNode[] nodes = treeScene.Nodes.Find(selNode.Name, true);
                    if ((nodes != null) && (nodes.Count() > 0))
                        treeScene.SelectedNode = nodes[0];
                    else
                        treeScene.SelectedNode = null;
                    selNode = treeScene.SelectedNode;
                }
                */
            }
            finally
            {
                treeScene.EndUpdate();
            }
        }

        private void SetupSceneTree_All()
        {
            treeScene.BeginUpdate();
            try
            {
                // by esyeon 2016-02-17
                treeScene.Nodes.Clear();//clear the old


                TreeNode scenenode = new TreeNode("Scene");
                treeScene.Nodes.Add(scenenode);


                // by esyeon

                TreeNode selNode = null;

                foreach (Object3d obj in UVDLPApp.Instance().Engine3D.m_objects)
                {

                    if (obj.tag == Object3d.OBJ_NORMAL)
                    {
                        TreeNode objnode = new TreeNode(obj.Name);

                        // by esyeon 2016-02-17
                        objnode.Name = obj.Name;
                        // by esyeon 

                        objnode.Tag = obj;
                        scenenode.Nodes.Add(objnode);
                        if (obj == UVDLPApp.Instance().SelectedObject)  // expand this node
                        {
                            //objnode.BackColor = Color.LightBlue;
                            //treeScene.SelectedNode = objnode;
                            selNode = objnode;
                        }

                        // by esyeon 2016-02-23
                        if (obj.m_supports != null) //if object has supports, create a node for them
                        //if (obj.m_supports.Count() > 0) //if object has supports, create a node for them
                        // by esyeon 
                        {
                            TreeNode supnode = null;        // by esyeon 2016-02-23
                            foreach (Object3d sup in obj.m_supports)
                            {
                                if (sup.Visible == true)        // by esyeon 2016-02-23
                                {
                                    if (supnode == null)
                                    {
                                        supnode = new TreeNode("Supports");
                                        objnode.Nodes.Add(supnode);
                                        supnode.Collapse();
                                    }

                                    TreeNode tn = new TreeNode(sup.Name);
                                    tn.Tag = sup;
                                    supnode.Nodes.Add(tn);
                                }                           // by esyeon
                                
                            }
                        }
                        objnode.ExpandAll();
                    }
                }


                if (selNode != null)
                    selNode.BackColor = Color.White;
                scenenode.Expand();
                if (selNode != null)
                {
                    TreeNode[] nodes = treeScene.Nodes.Find(selNode.Name, true);
                    if ((nodes != null) && (nodes.Count() > 0))
                        treeScene.SelectedNode = nodes[0];
                    else
                        treeScene.SelectedNode = null;
                    selNode = treeScene.SelectedNode;
                }

            }
            finally
            {
                treeScene.EndUpdate();
            }
        }



        private void cmdRemoveObject_Click(object sender, EventArgs e)
        {
            // delete the current selected object
            if (UVDLPApp.Instance().SelectedObject != null)
            {
                //if this is a support, remove it from the parent as to not create an orphan
                if (UVDLPApp.Instance().SelectedObject.tag == Object3d.OBJ_SUPPORT || UVDLPApp.Instance().SelectedObject.tag == Object3d.OBJ_SUPPORT_BASE)
                {
                    UVDLPApp.Instance().RemoveSupport(UVDLPApp.Instance().SelectedObject, true);
                }
                else
                    UVDLPApp.Instance().RemoveCurrentModel();

                UVDLPApp.Instance().SelectedObject = null;

                // by esyeon 2016-02-17
                SetupSceneTree_All();
                // by esyeon 
            }
        }

        private void cmdRemoveAllSupports_Click(object sender, EventArgs e)
        {
            // remove all supports
            //iterate through objects, remove all supports
            UVDLPApp.Instance().RemoveAllSupports();
            SetupSceneTree();
        }

        /*
          This function does 2 things,
          * when a node is click that is an object node, it sets
          * the App current object to be the clicked object
          * when an obj in the tree view is right clicked, it shows the context menu
          */
        private void treeScene_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (e.Node.Tag != null)            
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Node.Tag != null)
            {
                ignorerefresh = true;
                TreeNode tn = FindObjectNode(treeScene.Nodes, UVDLPApp.Instance().SelectedObject); // find the node that's currently selected
                if (tn != null) //set it back to the original color
                    tn.BackColor = treeScene.BackColor;

                UVDLPApp.Instance().SelectedObject = (Object3d)e.Node.Tag;
                e.Node.BackColor = Color.White; // now set the selected color

                // SetupSceneTree();                
                UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eUpdateSelectedObject, "updateobject");
                ignorerefresh = false;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)  // we right clicked a menu item, check and see if it has a tag
            {

                if (e.Node.Tag != null)
                {
                    contextMenuObject.Show(treeScene, e.Node.Bounds.Left, e.Node.Bounds.Top);
                }

            }
        }
        #endregion Scene tree

        private void ctlTitle1_Click(object sender, EventArgs e)
        {
            if (ctlTitle1.Checked)
            {
                this.Height = manipObject.Height;
            }
            else
            {
                this.Height = ctlTitle1.Height + 5;
            }
        }

        private void ctlScene_Resize(object sender, EventArgs e)
        {
            manipObject.Width = manipObject.Parent.Width - 6;
            ctlTitle1.Width = ctlTitle1.Parent.Width - 6;
            flowLayoutPanel1.Width = flowLayoutPanel1.Parent.Width - 6;
            treeScene.Width = treeScene.Parent.Width - 6;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            cmdRemoveObject_Click(null, null);
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            //by sypark 2016-03-10
            if (UVDLPApp.Instance().SelectedObject is Support)
                return;
            //by sypark

            //copy the object
            Object3d objCurr = UVDLPApp.Instance().SelectedObject;
            if (objCurr != null)
            {                
                try
                {
                    if (objCurr.tag != Object3d.OBJ_NORMAL)
                    {
                        Object3d objSup = fnCopySupport((Object3d)objCurr, objCurr.m_parent);

                        if (objSup != null)
                            UVDLPApp.Instance().SelectedObject = objSup;

                        UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelAdded, "Model Created");
                        return;
                    }

                    Object3d objCopy = UVDLPApp.Instance().SelectedObject.Copy();
                    UVDLPApp.Instance().m_engine3d.AddObject(objCopy);
                    List<Object3d> lstsupports = objCopy.m_supports;
                    UVDLPApp.Instance().m_undoer.SaveAddition(objCopy);

                    int nCount = objCurr.m_supports.Count;
                    for (int i = 0; i < nCount; i++)                        
                    {                        
                        fnCopySupport((Object3d) objCurr.m_supports[i], objCopy);                        
                    }

                    UVDLPApp.Instance().SelectedObject = objCopy;

                    // by esyeon 2016-02-17
                    //UVDLPApp.Instance().SelectedObject = obj;
                    // by esyeon 

                    UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelAdded, "Model Created");

                    // by esyeon 2016-02-17
                    //SetupSceneTree();
                    // by esyeon
                }
                catch (Exception ex)
                {
                    DebugLogger.Instance().LogError(ex);
                }
            }
        }

        public Object3d fnCopySupport(Object3d objSup, Object3d objCopy)
        {
                        if (objSup.Name.Contains("T1") == true)
                        {
                            Type1Support supCurr = (Type1Support) objSup;
                            Type1Support supCopy = supCurr.MakeCopy1();                            
                            UVDLPApp.Instance().m_engine3d.AddObject(supCopy);
                            UVDLPApp.Instance().m_undoer.SaveAddition(supCopy);
                            objCopy.AddSupport(supCopy);
                            return (Object3d) supCopy;
                        }
                        else if (objSup.Name.Contains("T2") == true)
                        {
                            Type2Support supCurr = (Type2Support)objSup;
                            Type2Support supCopy = supCurr.MakeCopy2();                            
                            UVDLPApp.Instance().m_engine3d.AddObject(supCopy);
                            UVDLPApp.Instance().m_undoer.SaveAddition(supCopy);
                            objCopy.AddSupport(supCopy);
                            return (Object3d)supCopy;
                        }
                        else if (objSup.Name.Contains("_Base") == true)
                        {
                            SupportBase supCurr = (SupportBase)objSup;
                            SupportBase supCopy = supCurr.MakeCopyBase();
                            supCopy.m_parent = objCopy;// by esyeon 2016-03-09
                            UVDLPApp.Instance().m_engine3d.AddObject(supCopy);
                            UVDLPApp.Instance().m_undoer.SaveAddition(supCopy);
                            objCopy.m_supports.Insert(0, supCopy); // by esyeon 2016-03-09
                            return (Object3d)supCopy;
                        }
                        return null;
        }

        private void cmdNewScene_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-02-16
            //UVDLPApp.Instance().RemoveCurrentModel();
            // by esyeon 

            // by esyeon 2016-02-17
            if (UVDLPApp.Instance().m_engine3d.m_objects.Count == 0)
                return;
            // by esyeon 

            UVDLPApp.Instance().Engine3D.RemoveAllObjects();

            SetupSceneTree_AllDel();
            //refresh the 3d view

            UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelRemoved, "");
        }

    }
}
