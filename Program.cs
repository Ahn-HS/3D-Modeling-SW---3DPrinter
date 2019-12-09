

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using UV_DLP_3D_Printer.GUI;
//using SoftwareLocker;
using UV_DLP_3D_Printer.Plugin;

namespace UV_DLP_3D_Printer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException +=
                new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            SetDefaultCulture(System.Globalization.CultureInfo.InvariantCulture); 
            Application.SetCompatibleTextRenderingDefault(false);
            //init the app object


            if (UVDLPApp.Instance().DoAppStartup() == false) // start the app and load the plug-ins
            {
                Application.Exit();   // by esyeon 20160127
                return;
            }
            
            
            

            // by esyeon 20151230


            try
            {
#if !DEBUG  // no splash screen under debug release
                frmSplash splash = new frmSplash(); // should pull from a licensed plug-in if need-be
                splash.Show();
#endif
                Application.Run(new frmMain2());
            }
            catch (Exception ex)
            {
                DebugLogger.Instance().LogError(ex);
            }
            
        }
        static bool CheckTrial(PluginEntry pe) 
        {
            /*
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMCR";
            if (!Directory.Exists(strPath))
            {
                Utility.CreateDirectory(strPath);
            }

             strPath += "\\CRTMSet.dbg";
            
            
            TrialMaker t = new TrialMaker("CT5", Application.StartupPath + "\\RegFile.reg",
                //Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\TMSetp.dbf",
                strPath,
                "",
                30, 1000, "887");
            //Environment.SpecialFolder.ApplicationData
            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63,
            4, 54, 87, 56, 123, 10, 3, 62,
            7, 9, 20, 36, 37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;

            TrialMaker.RunTypes RT = t.ShowDialog();
            //bool is_trial;
            
            if (RT != TrialMaker.RunTypes.Expired)
            {
            
                return true;
                //Application.Run(new Form1(is_trial));
            }
            */
            return false;
            
            
        }

        /*Set up a methoid to use reflection to set the culture information*/
        static void SetDefaultCulture(CultureInfo culture)
        {
            Type type = typeof(CultureInfo);

            try
            {
                type.InvokeMember("s_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("s_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }

            try
            {
                type.InvokeMember("m_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("m_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }
        }

        static void CurrentDomain_UnhandledException
          (object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                MessageBox.Show("Whoops! Please contact the developers with the following"
                      + " information:\n\n" + ex.Message + ex.StackTrace,
                      "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }

        public static void Application_ThreadException
          (object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Abort;
            try
            {
                result = MessageBox.Show("Whoops! Please contact the developers with the"
                  + " following information:\n\n" + e.Exception.Message + e.Exception.StackTrace,
                  "Application Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            finally
            {
                if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }
    }
}


