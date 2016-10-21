using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;
using DevExpress.XtraTreeList.Nodes;
using System.Runtime.InteropServices;


namespace MapSpotCheckProgram
{
     [ComVisible(true)]
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            initPage();
        }
        HtmlDocument htmlDoc;
        void initPage() {
            string path = MyRoutineTool.GetPathByParentDeep(System.IO.Directory.GetCurrentDirectory(), 2);
            path += @"\WebPageForMap\MapPage.htm";
            this.webBrowser1.ScriptErrorsSuppressed = false;
            this.webBrowser1.Navigate(path);
            htmlDoc = this.webBrowser1.Document;

            this.webBrowser1.ObjectForScripting = this;
        }
    }
}