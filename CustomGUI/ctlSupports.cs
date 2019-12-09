using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UV_DLP_3D_Printer.Configs;
using Engine3D;

namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    public partial class ctlSupports : ctlUserPanel
    {
        private bool m_settingData;
        private bool m_changingData;
        private bool m_numFBSelected;

        public ctlSupports()
        {
            InitializeComponent();
            UVDLPApp.Instance().m_supportgenerator.SupportEvent += new SupportGeneratorEvent(SupEvent);
            UVDLPApp.Instance().AppEvent += new AppEventDelegate(AppEvent);
            SetData();
            m_changingData = false;
            m_numFBSelected = true;
            numDownAngle.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.downangle;
            numDownAngle.IntVal = Convert.ToInt32(UVDLPApp.Instance().m_supportconfig.downangle);
            ListSupports();
        }
        private void AppEvent(eAppEvent ev,string message)
        {
            switch (ev) 
            {
                case eAppEvent.eModelRemoved:
                    ListSupports();
                    break;
                case eAppEvent.eModelAdded:
                    ListSupports();
                    break;
                case eAppEvent.eObjectSelected:
                    Object3d sel = UVDLPApp.Instance().SelectedObject;
                    if (sel != null) 
                    {
                        //highlist the selected
                        HighLightSelected(sel);
                    }
                    break;
            }
        }

        private void HighLightSelected(Object3d sel) 
        {
            int idx = 0;
            foreach (ListViewItem lvi in lbSupports.Items) 
            {
                Object3d obj = (Object3d)lvi.Tag;
                if (obj == sel) 
                {
                    //lbSupports.sel
                    lbSupports.Items[idx].Selected = true;
                    break;
                }
                idx++;
            }
        }

        private void SetData()
        {
            m_settingData = true;
            try
            {
                numFB.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.fbrad;
                numFT.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.ftrad;
                numHB.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.hbrad;
                numHT.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.htrad;
                numFB1.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.htrad; // (float)UVDLPApp.Instance().m_supportconfig.fbrad2;
                numY.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.yspace;
                numX.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.xspace;
                numGap.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.mingap;
                chkOnlyDownward.Checked = UVDLPApp.Instance().m_supportconfig.m_downonly;
                chkAutoDownFill.Checked = UVDLPApp.Instance().m_supportconfig.m_downfill;
                chkDownPolys.Checked = UVDLPApp.Instance().m_supportconfig.m_downpoly;
                numDownAngle.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.downangle;
                numDownAngle.IntVal = Convert.ToInt32(UVDLPApp.Instance().m_supportconfig.downangle);
                buttAddSupToBase.Checked = UVDLPApp.Instance().m_supportconfig.m_addsupbase;
                //buttAddSupToFace.Checked = UVDLPApp.Instance().m_supportconfig.m_addsupface;
                numItip.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.itip;
                numOtip.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.otip;
                numCtip.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.ctip;
                numBtip.FloatVal = (float)UVDLPApp.Instance().m_supportconfig.btip;
                switch (UVDLPApp.Instance().m_supportconfig.eSupType)
                {
                    case SupportConfig.eAUTOSUPPORTTYPE.eBON:
                        cmbSupType.SelectedIndex = 0;
                        break;
                    case SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE:
                        cmbSupType.SelectedIndex = 1;
                        break;
                    case SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE2:
                        cmbSupType.SelectedIndex = 2;
                        break;
                }
                UpdateForSupportType();
            }
            catch (Exception ex)
            {
                DebugLogger.Instance().LogError(ex.Message);
            }
            m_settingData = false;
        }
        private bool GetData()
        {
            try
            {
                UVDLPApp.Instance().m_supportconfig.fbrad = (double)numFB.FloatVal;
                UVDLPApp.Instance().m_supportconfig.ftrad = (double)numFT.FloatVal;
                UVDLPApp.Instance().m_supportconfig.hbrad = (double)numHB.FloatVal;
                UVDLPApp.Instance().m_supportconfig.htrad = (double)numHT.FloatVal;
                UVDLPApp.Instance().m_supportconfig.fbrad2 = UVDLPApp.Instance().m_supportconfig.htrad; // (double)numFB1.FloatVal;
                UVDLPApp.Instance().m_supportconfig.yspace = (double)numY.FloatVal;
                UVDLPApp.Instance().m_supportconfig.xspace = (double)numX.FloatVal;
                UVDLPApp.Instance().m_supportconfig.mingap = (double)numGap.FloatVal;
                UVDLPApp.Instance().m_supportconfig.m_downonly = chkOnlyDownward.Checked;
                UVDLPApp.Instance().m_supportconfig.m_downfill = chkAutoDownFill.Checked;
                UVDLPApp.Instance().m_supportconfig.m_downpoly = chkDownPolys.Checked;
                UVDLPApp.Instance().m_supportconfig.downangle = (double)numDownAngle.FloatVal;
                UVDLPApp.Instance().m_supportconfig.m_addsupbase = buttAddSupToBase.Checked;
                //UVDLPApp.Instance().m_supportconfig.m_addsupface = buttAddSupToFace.Checked;
                UVDLPApp.Instance().m_supportconfig.itip = (double)numItip.FloatVal;
                UVDLPApp.Instance().m_supportconfig.otip = (double)numOtip.FloatVal;
                UVDLPApp.Instance().m_supportconfig.ctip = (double)numCtip.FloatVal;
                UVDLPApp.Instance().m_supportconfig.btip = (double)numBtip.FloatVal;
                pictureSupport.Invalidate();
                switch (cmbSupType.SelectedIndex) 
                {
                    case 0:
                        UVDLPApp.Instance().m_supportconfig.eSupType = SupportConfig.eAUTOSUPPORTTYPE.eBON;
                        break;
                    case 1:
                        UVDLPApp.Instance().m_supportconfig.eSupType = SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE;
                        break;
                    case 2:
                        UVDLPApp.Instance().m_supportconfig.eSupType = SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE2;
                        break;
                }
                UVDLPApp.Instance().SaveSupportConfig(UVDLPApp.Instance().m_appconfig.SupportConfigName);
                return true;
            }
            catch (Exception ex)
            {
                if (!m_changingData)
                    DebugLogger.Instance().LogError(ex.Message);
                return false;
            }
        }
        
        public void SupEvent(SupportEvent ev, string message, Object obj)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { SupEvent(ev, message, obj); }));
            }
            else
            {
                try
                {
                    switch (ev)
                    {
                        case SupportEvent.eCompleted:
                            //close this dialog
                            progressTitle.Value = 0;
                            progressTitle.Text = "Supports";
                            //DialogResult = System.Windows.Forms.DialogResult.OK;
                            //Close();
                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                            ListSupports();
                            break;
                        case SupportEvent.eCancel:
                            break;
                        case SupportEvent.eProgress:
                            // P
                            
                            string[] toks = message.Split('/');
                            int cs = int.Parse(toks[0]);
                            int ts = int.Parse(toks[1]);
                            if (cs == 0) // set up the prog bar on the first step
                            {
                                progressTitle.Maximum = ts;
                                progressTitle.Text = "Generating...";
                            }
                            else
                            {
                                progressTitle.Value = cs;
                            }
                            break;
                        case SupportEvent.eStarted:
                            
                            break;
                        case SupportEvent.eSupportGenerated:
                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                            ListSupports();
                            
                            break;
                    }
                }
                catch (Exception ex)
                {
                    DebugLogger.Instance().LogError(ex.Message);
                }
            }
        }

        private void buttAddSupport_Click(object sender, EventArgs e)
        {
            Object3d obj = UVDLPApp.Instance().SelectedObject;
            if (obj == null)
                return;

            if (obj.tag != Object3d.OBJ_NORMAL)
            {
                MessageBox.Show("Please select some 3D model object first!");
                return;
            }

            //UVDLPApp.Instance().AddSupport();

            UVDLPApp.Instance().SaveSupportConfig(UVDLPApp.Instance().m_appconfig.SupportConfigName);
        }

        private void buttGenBase_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-02-25
            // by esyeon 2016-02-19
            Object3d obj = UVDLPApp.Instance().SelectedObject;
            if (obj == null)
                return;

            if (obj.tag != Object3d.OBJ_NORMAL)
            {
                MessageBox.Show("Please select some 3D model object first!");
                return;
            }

            // by esyeon 2016-03-03
            /*
            //by sypark 2016-03-02
            int nCount = obj.m_supports.Count();
            int i;
            for (i = nCount - 1; i >= 0; i--)
            {
                if (obj.m_supports.ElementAt(i).m_name.Contains("Base") == true)
                    return;

            }
            if (nCount == 0 || i == -1)
                UVDLPApp.Instance().AddSupportBase();*/
            // by esyeon 2016-03-09
            if (obj.m_supports.Count == 0 || obj.m_supports[0].Name.Contains("_Base") == false)
            // by esyeon 
                UVDLPApp.Instance().AddSupportBase();            
            //by sypark           
            // by esyeon 
            
        }
        
        private void buttAutoSupport_Click(object sender, EventArgs e)
        {
            //by sypark 2016-03-10
            buttAddSupToBase.Checked = false;
            //by sypark 

            Object3d obj = UVDLPApp.Instance().SelectedObject;
            if (obj == null)
            {
                MessageBox.Show("Selected Object is not exist.");
                return;
            }

            if (obj.tag != Object3d.OBJ_NORMAL)
            {
                MessageBox.Show("Please select some 3D model object first!");
                return;
            }
            //bysypark 20160204
            // by esyeon 2016-02-17
            // by esyeon 2016-02-19
            if (chkDownPolys.Checked == false)
            {
                MessageBox.Show("Please Check the PolysButton");
                return;
            }
            
            if (obj.m_bAutoSpport == true)
            {
                MessageBox.Show("The effect of the applied Auto Support is already exist.");
                return;
            }
            GetData();

            //by sypark 2016-02-25
            UVDLPApp.Instance().m_undoer.RemoveList();
            //UVDLPApp.Instance().RemoveAllSupports();
            UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelRemoved, "remove_all_supports");
            UVDLPApp.Instance().m_undoer.UpdateButtons();
            //by sypark 

            // by esyeon 2016-02-25
            obj.m_bAutoSpport = true;
            // by esyeon

            //UVDLPApp.Instance().m_mainform.ctl3DView1.pictureBox1.Show();
            UVDLPApp.Instance().m_supportconfig = UVDLPApp.Instance().m_supportconfig; // should copy really
            UVDLPApp.Instance().StartAddSupports(); // start the support generation
            UVDLPApp.Instance().SaveSupportConfig(UVDLPApp.Instance().m_appconfig.SupportConfigName);
            //
            // by esyeon 

        }
        /*
        private void buttSetup_Click(object sender, EventArgs e)
        {
            if (buttSetup.Checked)
            {
                Width = widthopen;
                Location = new Point(Location.X, Location.Y - (heightopen - Height));
                Height = heightopen;
            }
            else
            {
                Width = 170;
                Location = new Point(Location.X, Location.Y + (Height - 96));
                Height = 96;
            }
        }
        */
        private void chkDownPolys_Click(object sender, EventArgs e)
        {
            UVDLPApp.Instance().m_supportconfig.m_downpoly = chkDownPolys.Checked;
            if (UVDLPApp.Instance().SelectedObject == null) return;
            // tell the 3d engine to only show polygons from objects that are facing downward at the specified angle
            if (chkDownPolys.Checked == true)
            {
                UVDLPApp.Instance().m_supportconfig.downangle = (double)numDownAngle.FloatVal;
                // I think this should affect all objects in the scene
                // and it should be more of a global setting 
                UVDLPApp.Instance().SelectedObject.MarkPolysDown(UVDLPApp.Instance().m_supportconfig.downangle);
            }
            else
            {
                // restore the object
                UVDLPApp.Instance().SelectedObject.ClearPolyTags();
            }
            UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eReDraw, "redraw");
        }
        private PointF[] GetLinePoints(float[] coords)
        {
            int npts = coords.Length / 2;
            PointF[] pts = new PointF[npts];
            for (int i = 0; i < npts; i++)
            {
                pts[i] = new PointF(coords[i * 2], coords[i * 2 + 1]);
            }
            return pts;
        }

        private void DrawGuide(PaintEventArgs e, float x, float y, float edge, Control c)
        {
            float yend = c.Location.Y + c.Height / 2 - pictureSupport.Location.Y;
            float xend = pictureSupport.Width - edge;
            if (x > xend)
                return;
            Pen pen = new Pen(Color.Black, 1);
            PointF[] pts = GetLinePoints(new float[] { x, y, xend, y, xend, yend, pictureSupport.Width, yend });
            e.Graphics.DrawLines(pen, pts);
            // by esyeo 2016-01-29
            pen.Dispose();
            // by esyeon 

        }

        private void pictureSupport_Paint(object sender, PaintEventArgs e)
        {
            float fullHeight = pictureSupport.Height;
            float yfb = 0.95f * fullHeight;
            float yft = 0.75f * fullHeight;
            float yhb = 0.25f * fullHeight;
            float yht = 0.05f * fullHeight;

            float halfPixPermm = (float)pictureSupport.Width / 10.0f;
            float xc = (float)pictureSupport.Width * 0.4f;

            float xfb = (float)(halfPixPermm * UVDLPApp.Instance().m_supportconfig.fbrad);
            float xfb2 = (float)(halfPixPermm * UVDLPApp.Instance().m_supportconfig.fbrad2);
            float xft = (float)(halfPixPermm * UVDLPApp.Instance().m_supportconfig.ftrad);
            float xhb = (float)(halfPixPermm * UVDLPApp.Instance().m_supportconfig.hbrad);
            float xht = (float)(halfPixPermm * UVDLPApp.Instance().m_supportconfig.htrad);

            SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Pink);

            PointF[] supportHead = GetLinePoints(new float[] {
                xc - xht, yht, xc + xht, yht, xc + xhb, yhb, xc - xhb, yhb});
            PointF[] supportBody = GetLinePoints(new float[] {
                xc - xhb, yhb, xc + xhb, yhb, xc + xft, yft, xc - xft, yft});
            PointF[] supportFoot = GetLinePoints(new float[] {
                xc - xft, yft, xc + xft, yft, xc + xfb, yfb, xc - xfb, yfb});
            PointF[] supportFoot2 = GetLinePoints(new float[] {
                xc - xft, yft, xc + xft, yft, xc + xfb2, yfb, xc - xfb2, yfb});

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen blackPen = new Pen(Color.Black, 2);
            e.Graphics.FillPolygon(greenBrush, supportHead);
            e.Graphics.FillPolygon(yellowBrush, supportBody);
            if (m_numFBSelected)
                e.Graphics.FillPolygon(redBrush, supportFoot);
            else
                e.Graphics.FillPolygon(redBrush, supportFoot2);
            e.Graphics.DrawPolygon(blackPen, supportHead);
            e.Graphics.DrawPolygon(blackPen, supportBody);
            if (m_numFBSelected)
                e.Graphics.DrawPolygon(blackPen, supportFoot);
            else
                e.Graphics.DrawPolygon(blackPen, supportFoot2);
            // by esyeo 2016-01-29
            blackPen.Dispose();
            // by esyeon 


            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            DrawGuide(e, xc + xht + 3, yht, 4, numHT);
            DrawGuide(e, xc + xhb + 3, yhb, 8, numHB);
            DrawGuide(e, xc + xft + 3, yft, 8, numFT);
            if (m_numFBSelected)
                DrawGuide(e, xc + xfb + 3, yfb, 4, numFB);
            else
                DrawGuide(e, xc + xfb2 + 3, yfb, 4, numFB1);
        }
 
        private void num_ValueChanged(object sender, EventArgs e)
        {
            if (m_settingData)
                return;
            m_changingData = true;
            GetData();
            m_changingData = false;
            pictureSupport.Invalidate();
        }

        private void numFB_Enter(object sender, EventArgs e)
        {
            m_numFBSelected = true;
            pictureSupport.Invalidate();
        }

        private void numFB1_Enter(object sender, EventArgs e)
        {
            m_numFBSelected = false;
            pictureSupport.Invalidate();
        }

        private void numDownAngle_ValueChanged(object sender, EventArgs e)
        {
            if (UVDLPApp.Instance().SelectedObject == null)
                return;
            
            if (chkDownPolys.Checked == true)
            {
                UVDLPApp.Instance().m_supportconfig.downangle = (double)numDownAngle.FloatVal;
                UVDLPApp.Instance().SelectedObject.MarkPolysDown(UVDLPApp.Instance().m_supportconfig.downangle);
                UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eReDraw, "");
            }
        }
        private void UpdateForSupportType() 
        {
            switch (UVDLPApp.Instance().m_supportconfig.eSupType)
            {
                case SupportConfig.eAUTOSUPPORTTYPE.eBON:
                    chkOnlyDownward.Visible = true;
                    chkAutoDownFill.Visible = true;
                    //labelAutoSup.Visible = true;
                    labelAutoSup.Text = "Automatic Support";
                    label6.Visible = true;
                    label7.Visible = true;
                    numX.Visible = true;
                    numGap.Visible = false;
                    numY.Visible = true;
                    
                    break;
                case SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE:
                case SupportConfig.eAUTOSUPPORTTYPE.eADAPTIVE2:
                    chkOnlyDownward.Visible = false;
                    chkAutoDownFill.Visible = false;
                    //labelAutoSup.Visible = false;
                    labelAutoSup.Text = "Minimum Gap (mm)";
                    label6.Visible = false;
                    label7.Visible = false;
                    numX.Visible = false;
                    numGap.Visible = true;
                    numY.Visible = false;

                    break;
            }        
        }
        private void cmbSupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
            UpdateForSupportType();
        }
        public void ListSupports() 
        {
            if (UVDLPApp.Instance().m_supportgenerator.Generating)
                return; // avoid cross-thread using of support list
            lbSupports.Items.Clear();
            foreach (Object3d obj in UVDLPApp.Instance().Engine3D.m_objects) 
            {
                if ((obj.tag == Object3d.OBJ_SUPPORT) || (obj.tag == Object3d.OBJ_SUPPORT_BASE)) 
                {
                    ListViewItem lvi = new ListViewItem(obj.Name);
                    lvi.Tag = obj;
                    lbSupports.Items.Add(lvi);
                }
            }
            
        }
        public override void ApplyStyle(GuiControlStyle ct)
        {
            base.ApplyStyle(ct);
            if (ct.ForeColor.IsValid())
            {
                ctlTitle1.ForeColor = ct.ForeColor;
                label1.ForeColor = ct.ForeColor;
                label2.ForeColor = ct.ForeColor;
                label3.ForeColor = ct.ForeColor;
                label4.ForeColor = ct.ForeColor;
                labelAutoSup.ForeColor = ct.ForeColor;
                label6.ForeColor = ct.ForeColor;
                label7.ForeColor = ct.ForeColor;
                label9.ForeColor = ct.ForeColor;
                cmbSupType.ForeColor = ct.ForeColor;
                lbSupports.ForeColor = ct.ForeColor;
                cmdRemoveSupports.ForeColor = ct.ForeColor;
                //cmdArrangeSupports.ForeColor = ct.ForeColor;
                progressTitle.ForeColor = ct.ForeColor;
            }
            if (ct.BackColor.IsValid())
            {
                ctlTitle1.BackColor = ct.BackColor;
                BackColor = ct.BackColor;
                cmbSupType.BackColor = ct.BackColor;
                //flowLayoutPanel2.BackColor = ct.BackColor;
                progressTitle.BackColor = ct.BackColor;
            }
            if (ct.FrameColor.IsValid())
            {
                
                flowLayoutPanel1.BackColor = ct.FrameColor;
                flowLayoutPanel2.BackColor = ct.FrameColor;
                panel1.BackColor = ct.FrameColor;
                panel2.BackColor = ct.FrameColor;
                panelSuppotShape.BackColor = ct.FrameColor;
                panel3.BackColor = ct.FrameColor;
                lbSupports.BackColor = ct.FrameColor;
                cmdRemoveSupports.BackColor = ct.BackColor;
                //cmdArrangeSupports.BackColor = ct.BackColor;
                //flowLayoutPanel2.BackColor = ct.FrameColor;
            }

        }

        private void buttManualEdit_Click(object sender, EventArgs e)
        {
            // the manual edit of support button is clicked
        }

        private void lbSupports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected item
            try
            {
                ListView.SelectedListViewItemCollection slvi =  lbSupports.SelectedItems;
                if (slvi.Count > 0) 
                {
                    ListViewItem lvi = slvi[0];
                    Object3d obj = (Object3d)lvi.Tag;
                    UVDLPApp.Instance().SelectedObject = obj;
                }
                //Object3d obj = (Object3d)lbSupports.SelectedItems[0].Tag;
                //UVDLPApp.Instance().SelectedObject = obj;
            }
            catch (Exception ex) 
            {
                DebugLogger.Instance().LogError(ex);
            }
        }

        private void cmdRemoveSupports_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-02-25
            /*
            // by esyeon 2016-02-19
            if (UVDLPApp.Instance().m_engine3d.m_objects.Count == 0)
                return;
            // by esyeon 
             */
            if (UVDLPApp.Instance().SelectedObject == null)
                return;
            // by esyeon 

            UVDLPApp.Instance().SelectedObject.m_bAutoSpport = false;          


            //by sypark 2016-03-03
            UVDLPApp.Instance().m_undoer.RemoveList();
            UVDLPApp.Instance().RemoveAllSupports();
            UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eUpdateSelectedObject, "remove_all_supports");
            UVDLPApp.Instance().m_undoer.CheckList();
            UVDLPApp.Instance().m_undoer.UpdateButtons();
            //by sypark 
        }

        private void ctlTitle1_Click(object sender, EventArgs e)
        {
            if (ctlTitle1.Checked)
            {
                // by esyeon 2016-02-19
                //this.Height = 678 + 5;
                this.Height = 574;

                //this.Width = (int)((double)(258) * (double)1920 / dbWidth) - 50;
                //this.Width = 300;
                this.Width = UVDLPApp.Instance().m_mainform.ctl3DView1.Location.X;
                // by esyeon 
            }
            else
            {
                this.Height = ctlTitle1.Height + 5;
            }
        }

        private void buttAddSupExclusive(object sender)
        {
            if (sender == buttAddSupToBase)
            {
                if (buttAddSupToBase.Checked)
                {
                    //buttAddSupToFace.Checked = false;
                    buttAddSupToFace2.Checked = false;
                }
            }
            //if (sender == buttAddSupToFace)
            //{
            //    if (buttAddSupToFace.Checked)
            //    {
            //        buttAddSupToBase.Checked = false;
            //        buttAddSupToFace2.Checked = false;
            //    }
            //}
            if (sender == buttAddSupToFace2)
            {
                if (buttAddSupToFace2.Checked)
                {
                    buttAddSupToBase.Checked = false;
                    //buttAddSupToFace.Checked = false;
                }
            }
        }
        private void buttAddSupToBase_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-03-02            
            UVDLPApp.Instance().m_supportconfig.m_addsupbase = buttAddSupToBase.Checked;

            if (buttAddSupToBase.Checked == true)
                //UVDLPApp.Instance().m_supportconfig.m_addsupface = buttAddSupToFace.Checked;
                UVDLPApp.Instance().m_supportconfig.m_addsupface2 = buttAddSupToFace2.Checked = false;
            
            
            Object3d obj = UVDLPApp.Instance().SelectedObject;
            if (obj == null)
                return;

            if (obj.tag != Object3d.OBJ_NORMAL)
            {
                if (obj.m_parent != null)
                    UVDLPApp.Instance().SelectedObject = obj.m_parent;
                else
                {
                    UVDLPApp.Instance().m_supportconfig.m_addsupbase = buttAddSupToBase.Checked = false;
                    MessageBox.Show("Please select some 3D model object first!");
                    return;
                }
            }
            
            
            
            buttAddSupExclusive(sender);

            
          
        }
        private void buttAddSupToFace_Click(object sender, EventArgs e)
        {
            UVDLPApp.Instance().m_supportconfig.m_addsupface2 = buttAddSupToFace2.Checked;

            if (buttAddSupToFace2.Checked == true)
                //UVDLPApp.Instance().m_supportconfig.m_addsupface = buttAddSupToFace.Checked;
                UVDLPApp.Instance().m_supportconfig.m_addsupbase = buttAddSupToBase.Checked = false;
 
           
            Object3d obj = UVDLPApp.Instance().SelectedObject;
            if (obj == null)
                return;

            if (obj.tag != Object3d.OBJ_NORMAL)
            {
                if (obj.m_parent != null)
                    UVDLPApp.Instance().SelectedObject = obj.m_parent;
                else
                {
                    UVDLPApp.Instance().m_supportconfig.m_addsupface2 = buttAddSupToFace2.Checked = false;
                    MessageBox.Show("Please select some 3D model object first!");
                    return;
                }
            }

            // by esyeon 2016-03-02            

            
            buttAddSupExclusive(sender);


           
    }

        private void cmdArrangeSupports_Click(object sender, EventArgs e)
        {
            /*
            foreach(ListViewItem lvi in lbSupports.Items)
            {
                Support supp = (Support)lvi.Tag;
                if (supp is FillSupport)
                    continue;
                Point3d tip = supp.CalcTipCentroid();
                UV_DLP_3D_Printer.UVDLPApp.Instance().m_mainform.ctl3DView1.MoveSupportTowardEye(supp,  tip);
            }
            UV_DLP_3D_Printer.UVDLPApp.Instance().m_mainform.ctl3DView1.UpdateView();
            */

            foreach (ListViewItem lvi in lbSupports.Items)
            {
                Support supp = (Support)lvi.Tag;
                UVDLPApp.Instance().AddToSelectionList(supp);
            }
            UVDLPApp.Instance().m_engine3d.UpdateLists();
        }

        private void chkOnlyDownward_Click(object sender, EventArgs e)
        {
            if (chkOnlyDownward.Checked)
            {
                chkAutoDownFill.Enabled = true;
            }
            else
            {
                chkAutoDownFill.Enabled = false;
                chkAutoDownFill.Checked = false;
            }
        }

        private void buttRemoveType1_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-02-25
            // by esyeon 2016-02-19
            Object3d sobj = UVDLPApp.Instance().SelectedObject;
            if (sobj == null || sobj.m_supports.Count() == 0)
                return;
            
            if (sobj.tag != Object3d.OBJ_NORMAL)
            {
                MessageBox.Show("Please select some 3D model object first!");
                return;
            }

            // by esyeon 

            UVDLPApp.Instance().RemoveType1Supports(sobj.m_supports);
            // by esyeon 2016-02-25
            //UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelRemoved, "remove_all_supports");
            // by esyeon 

            //by sypark 2016-02-29
            /*
            int supportcnt = 0;
            foreach (Object3d obj in sobj.m_supports)
            {
                if(obj.Visible == true)
                {
                    supportcnt++;
                }
            }

            if (supportcnt == 0)*/
            if (sobj.m_supports.Count() == 0)
                sobj.m_bAutoSpport = false;
            //by sypark
        }

        private void buttRemoveType2_Click(object sender, EventArgs e)
        {
            // by esyeon 2016-02-25
            // by esyeon 2016-02-23
            Object3d sobj = UVDLPApp.Instance().SelectedObject;
            if (sobj == null || sobj.m_supports.Count() == 0)
                return;
            
            if (sobj.tag != Object3d.OBJ_NORMAL)
            {
                MessageBox.Show("Please select some 3D model object first!");
                return;
            }

            // by esyeon 

            UVDLPApp.Instance().RemoveType2Supports(sobj.m_supports);
            // by esyeon 2016-02-25
            //UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eModelRemoved, "remove_all_supports");
            // by esyeon 

            //by sypark 2016-02-29
            /*
            int supportcnt = 0;
            foreach (Object3d obj in sobj.m_supports)
            {
                if (obj.Visible == true)
                {
                    supportcnt++;
                }
            }

            if (supportcnt == 0)*/

            if (sobj.m_supports.Count() == 0)
                sobj.m_bAutoSpport = false;
            //by sypark
        }
    }
}
