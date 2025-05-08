using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EWT
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tsbEWT_Click(object sender, EventArgs e)
        {
            EWTForm frmEWT = new EWTForm();
            frmEWT.ShowDialog();

            frmEWT.Dispose();
            frmEWT = null;
        }


        private void EWTMasool_Click(object sender, EventArgs e)
        {
            EWTMasoolsForm frmEWTsMasools = new EWTMasoolsForm();
            frmEWTsMasools.ShowDialog();

            frmEWTsMasools.Dispose();
            frmEWTsMasools = null;
        }



        private void tsmEWTCheckMan_Click(object sender, EventArgs e)
        {
            EWTCheckmansForm frmEWTsCheckMans = new EWTCheckmansForm();
            frmEWTsCheckMans.ShowDialog();
            frmEWTsCheckMans.Dispose();
            frmEWTsCheckMans = null;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {




            //webControl1.WebView.Url = "http://intranet:81/Dashboard/Indexfactorymanagement.html";



            if (File.Exists(Utilities.Tools.UserInfo.PictureAddress))
            {
                userInfo1.ovalPictureBox.Image = Image.FromFile(Utilities.Tools.UserInfo.PictureAddress);  //new
            }
            else
            {
                userInfo1.ovalPictureBox.Image = Properties.Resources.NoPic;
            }


            userInfo1.lblName.Text = Utilities.Tools.UserInfo.FullName;


            tsslCurrentDate.Text = $"امروز: {Utilities.Tools.CurrentDate}";

            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.CheckMan:
                    explorerBar1.Groups[1].Items[0].Enabled = true;
                    explorerBar1.Groups[5].Items[0].Enabled = true;
                    break;

                case Enums.BusinessRoleEnum.Masool:

                    LoadDashBoard();

                    explorerBar1.Groups[1].Items[0].Enabled = true;
                    explorerBar1.Groups[5].Items[0].Enabled = true;
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    explorerBar1.Groups[1].Items[0].Enabled = true;
                    explorerBar1.Groups[5].Items[0].Enabled = true;
                    break;

                case Enums.BusinessRoleEnum.ViewUser:

                    LoadDashBoard();

                    foreach (Janus.Windows.ExplorerBar.ExplorerBarItem item in explorerBar1.Groups[5].Items)   //enabling all reports for viewuser aka Sarparast
                    {
                        item.Enabled = true;
                    }

                    break;

                case Enums.BusinessRoleEnum.Admin:

                    LoadDashBoard();


                    foreach (Janus.Windows.ExplorerBar.ExplorerBarItem item in explorerBar1.Groups[0].Items)
                    {
                        item.Enabled = true;
                    }
                    explorerBar1.Groups[1].Items[1].Enabled = true;
                    explorerBar1.Groups[1].Items[2].Enabled = true;
                    explorerBar1.Groups[5].Items[1].Enabled = true;   //gozareshha--> gozaresh e nr
                    explorerBar1.Groups[5].Items[2].Enabled = true;   //gozareshha--> gozaresh e nr tajmiyi
                    explorerBar1.Groups[5].Items[3].Enabled = true;   //gozareshha--> gozaresh e np
                    explorerBar1.Groups[5].Items[4].Enabled = true;   //gozareshha--> gozaresh e np tajmiyi
                    explorerBar1.Groups[5].Items[5].Enabled = true;   //gozareshha --> gozaresh e nqa
                    explorerBar1.Groups[5].Items[6].Enabled = true;   //gozareshha --> gozaresh e nqa tajmiyi
                    explorerBar1.Groups[5].Items[7].Enabled = true;   //gozareshha --> gozaresh e shakhes ha moavenat
                    explorerBar1.Groups[5].Items[8].Enabled = true;   //gozareshha --> rework vahed ha tajmiyi
                    explorerBar1.Groups[5].Items[9].Enabled = true;   //gozareshha --> rework ewt ha tajmiyi
                    explorerBar1.Groups[5].Items[10].Enabled = true;  //gozareshha --> gozaresh e nqc tajmiyi
                    break;

                case Enums.BusinessRoleEnum.Developer:
                    foreach (Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup in explorerBar1.Groups)
                    {
                        foreach (Janus.Windows.ExplorerBar.ExplorerBarItem item in explorerBarGroup.Items)
                        {
                            item.Enabled = true;
                        }
                    }
                    break;

                case Enums.BusinessRoleEnum.Boss:

                    LoadDashBoard();

                    explorerBar1.Groups[1].Items[1].Enabled = true;   //amaliat-->list e np jadid
                    explorerBar1.Groups[1].Items[2].Enabled = true;   //amaliat-> list e np baz
                    explorerBar1.Groups[5].Items[1].Enabled = true;   //gozareshha--> gozaresh e nr
                    explorerBar1.Groups[5].Items[2].Enabled = true;   //gozareshha--> gozaresh e nr tajmiyi
                    explorerBar1.Groups[5].Items[3].Enabled = true;   //gozareshha--> gozaresh e np
                    explorerBar1.Groups[5].Items[4].Enabled = true;   //gozareshha --> gozaresh e np tajmiyi
                    explorerBar1.Groups[5].Items[5].Enabled = true;   //gozareshha --> gozaresh e nqa
                    explorerBar1.Groups[5].Items[6].Enabled = true;   //gozareshha --> gozaresh e nqa tajmiyi
                    explorerBar1.Groups[5].Items[8].Enabled = true;   //gozareshha --> rework vahed ha tajmiyi
                    explorerBar1.Groups[5].Items[9].Enabled = true;   //gozareshha --> rework ewt ha tajmiyi
                    explorerBar1.Groups[5].Items[10].Enabled = true;  //gozareshha --> gozaresh e nqc tajmiyi

                    break;
                case Enums.BusinessRoleEnum.Manager:
                    LoadDashBoard();
                    foreach (Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup in explorerBar1.Groups)
                    {
                        if (explorerBarGroup.Index < 5)
                        {

                            foreach (Janus.Windows.ExplorerBar.ExplorerBarItem item in explorerBarGroup.Items)
                            {
                                item.Enabled = false;
                            }

                        }
                        else
                        {
                            foreach (Janus.Windows.ExplorerBar.ExplorerBarItem item in explorerBarGroup.Items)
                            {
                                item.Enabled = true;
                            }
                        }
                    }

                    break;


                default:
                    break;
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void tsmUserManagement_Click(object sender, EventArgs e)
        {
            UsersForm frmUsers = new UsersForm();
            frmUsers.ShowDialog();
            frmUsers.Dispose();
            frmUsers = null;
        }

        private void sabtERoozanehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EWTDailyInputForm ewtdailyinputform = new EWTDailyInputForm(Enums.FormDataModeEnum.Add);
            ewtdailyinputform.ShowDialog();

            ewtdailyinputform.Dispose();
            ewtdailyinputform = null;
        }

        private void dailyinputRepToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EWTDailyInputPickDateForm frmEWTDailyInputPickDates = new EWTDailyInputPickDateForm();
            frmEWTDailyInputPickDates.ShowDialog();
            frmEWTDailyInputPickDates.Dispose();
            frmEWTDailyInputPickDates = null;

        }

        public BaseForm MyForm { get; set; }

        private void explorerBar1_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            if (MyForm != null)
            {
                MyForm.Dispose();
                MyForm = null;
            }

            switch (e.Item.Key)
            {
                case "menuitemEWT":
                    MyForm = new EWTForm();
                    break;

                case "menuitemDeclareMembers":
                    MyForm = new EWTMemebersForm();
                    break;

                case "menuitemEWTAuditor":
                    MyForm = new EWTAuditorsForm();
                    break;

                case "menuitemEWTCheckMan":
                    MyForm = new EWTCheckmansForm();
                    break;

                case "menuitemFailManagement":
                    MyForm = new FailsForm();
                    break;

                case "menuitemUserManagement":
                    MyForm = new UsersForm();
                    break;

                case "menuitemAssignMembers":
                    MyForm = new EWTAssignMembersForm();
                    break;

                case "menuitemEWTDailyInput":
                    MyForm = new EWTDailyInputForm(Enums.FormDataModeEnum.Add);
                    break;

                case "menuItemEWTDailyInputShow":
                    MyForm = new EWTDailyInputPickDateForm();
                    break;

                case "menuitemChangePassword":
                    MyForm = new ChangePasswordForm();
                    break;

                case "menuitemExit":
                    System.Environment.Exit(0);
                    break;
                case "menuitemInstructions":
                    Process.Start(@"file://nas-a/EWT-Information/Instructions/");
                    break;
                case "menuitemForms":
                    Process.Start(@"file://nas-a/EWT-Information/Forms/");
                    break;
                case "menuitemAssessmentResult":
                    Process.Start(@"file://nas-a/EWT-Information/Assessment-Results/");
                    break;
                case "menuitemEducation":
                    Process.Start(@"file://nas-a/EWT-Information/Education/");
                    break;

                case "menuitemNewNP":
                    MyForm = new NewNPsForm(Enums.NPCategoriesEnum.New);
                    break;

                case "menuitemOpenNP":
                    MyForm = new NewNPsForm(Enums.NPCategoriesEnum.Open);
                    break;

                case "menuitemNPReport":
                    MyForm = new NPReportInputForm();
                    break;

                case "menuitemNRReport":
                    MyForm = new NRReportInputForm();
                    break;

                case "menuitemNQAReport":
                    MyForm = new NQAReportInputForm();
                    break;

                case "menuItemNPAggregateReport":
                    MyForm = new NPAggregateReportInputForm();
                    break;

                case "menuitemSumOfIndicatorsReport":
                    MyForm = new SumOfIndicatorsReportInputForm();
                    break;

                case "menuitemNQaAggregationReport":
                    MyForm = new NQaAggregateReportInputForm();
                    break;

                case "menuitemNrAggregationReport":
                    MyForm = new NrAggregateReportInputForm();
                    break;

                case "menuitemREWAggregationBossReport":
                    MyForm = new ReworkAggregateReportInputForm();
                    break;

                case "menuitemEWTReworkAggregateReport":
                    MyForm = new EWTReworkAggregateReportForm();
                    break;

                case "menuitemNQcAggregationReport":
                    MyForm = new NQcAggregateReportInputForm();
                    break;



            }

            if (MyForm != null)
            {
                MyForm.ShowDialog();
                MyForm.Dispose();
                MyForm = null;
            }


        }

        private void explorerBar1_GroupExpanding(object sender, Janus.Windows.ExplorerBar.GroupCancelEventArgs e)
        {
            foreach (Janus.Windows.ExplorerBar.ExplorerBarGroup groupItem in explorerBar1.Groups)
            {
                if (groupItem.Key.Equals(e.Group.Key, StringComparison.OrdinalIgnoreCase) == false)
                {
                    groupItem.Expanded = false;
                }
            }
        }

        private void LoadDashBoard()
        {
            Task taskA = new Task(() =>
            this.webBrowser1.Navigate("http://bi-srv/Reports/powerbi/Indexs/index%20factory%20management?rs:embed=true"));
            taskA.Start();
        }


    }
}
