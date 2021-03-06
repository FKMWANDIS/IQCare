using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.IO; 
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Interface.Security;
using Application.Presentation;
using Application.Common;
using Interface.Administration;

public partial class frmDBBackupSetting : BasePage
{
    private void Init_Page()
    {
        if (Session["AppLocation"] == null || Session.Count == 0 || Session["AppUserID"].ToString() == "")
        {
            IQCareMsgBox.Show("SessionExpired", this);
            Response.Redirect("~/frmlogin.aspx", true);
        }
        IQCareUtils theUtil = new IQCareUtils();
        DataTable theDT = theUtil.CreateTimeTable(15);
        DataRow theDR = theDT.NewRow();
        theDR[0] = "0";
        theDR[1] = "Select";
        theDT.Rows.InsertAt(theDR, 0);
        ddBackupTime.DataSource = theDT;
        ddBackupTime.DataTextField = "Time";
        ddBackupTime.DataValueField = "Id";
        ddBackupTime.DataBind();
        ddBackupDrive.SelectedValue = "Select";

        IFacilitySetup BackupManger = (IFacilitySetup)ObjectFactory.CreateInstance("BusinessProcess.Administration.BFacility, BusinessProcess.Administration");
        theDT = BackupManger.GetBackupSetup();
        if (theDT.Rows[0].IsNull("BackupTime") != true)
            ddBackupTime.SelectedValue = ((DateTime)theDT.Rows[0]["BackupTime"]).TimeOfDay.ToString();

        ddBackupDrive.SelectedValue = theDT.Rows[0]["BackupDrive"].ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AppLocation"] == null || Session.Count == 0 || Session["AppUserID"].ToString() == "")
        {
            IQCareMsgBox.Show("SessionExpired", this);
            Response.Redirect("~/frmlogin.aspx", true);
        }
        if (Page.IsPostBack != true)
        {
            Init_Page();
        }
    }
    protected void cmdSave_Click(object sender, EventArgs e)
    {
        try
        {
            IQCareUtils theUtils = new IQCareUtils();
            string theTime;
            if (ddBackupTime.SelectedValue != "0")
                theTime = ddBackupTime.SelectedItem.ToString();
            else
                theTime = "0";

            IFacilitySetup BackupManger = (IFacilitySetup)ObjectFactory.CreateInstance("BusinessProcess.Administration.BFacility, BusinessProcess.Administration");
            int noRows = BackupManger.SaveBackupSetup(ddBackupDrive.SelectedItem.ToString(), theTime);
            BackupManger = null;
            IQCareMsgBox.Show("BackupSetupSave", this);
        }
        catch (Exception err)
        {
            MsgBuilder theBuilder = new MsgBuilder();
            theBuilder.DataElements["MessageText"] = err.Message.ToString();
            IQCareMsgBox.Show("#C1", theBuilder, this);
        }
    }

    
}
