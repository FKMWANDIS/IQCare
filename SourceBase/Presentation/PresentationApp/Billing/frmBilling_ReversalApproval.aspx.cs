﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Application.Presentation;
using Interface.SCM;
using Application.Common;

namespace IQCare.Web.Billing
{
    public partial class frmBilling_ReversalApproval : LogPage
    {
        bool isError = false;
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //(Master.FindControl("levelOneNavigationUserControl1").FindControl("lblRoot") as Label).Text = "Billing >> ";
                //(Master.FindControl("levelOneNavigationUserControl1").FindControl("lblheader") as Label).Text = "Bill Reversal Approval";
                Session["PatientId"] = 0;
                // this.PopulateReversalBills();
                this.ReverseTransaction.Rebind();
            }

        }
        /// <summary>
        /// Handles the Init event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Init(object sender, EventArgs e)
        {
            Master.PageScriptManager.AsyncPostBackError += new EventHandler<AsyncPostBackErrorEventArgs>(PageScriptManager_AsyncPostBackError);


        }
        /// <summary>
        /// Handles the AsyncPostBackError event of the PageScriptManager control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="AsyncPostBackErrorEventArgs"/> instance containing the event data.</param>
        void PageScriptManager_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            string message = e.Exception.Message;
            Master.PageScriptManager.AsyncPostBackErrorMessage = message;
        }
        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event to initialize the page.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.ReverseTransaction.IsApprovalMode = true;          
            this.ReverseTransaction.CanRefund = true;
            this.ReverseTransaction.PatientID = 0;
            this.ReverseTransaction.LocationID = Convert.ToInt32(Session["AppLocationId"]);
            this.ReverseTransaction.RowCommand += new CommandEventHandler(ReverseTransaction_RowCommand);
            this.ReverseTransaction.ErrorOccurred += new CommandEventHandler(ReverseTransaction_ErrorOccurred);

            this.ReverseTransaction.NotifyCommand += new CommandEventHandler(ReverseTransaction_NotifyCommand);

        }
        void SetStyle()
        {
            HtmlGenericControl facilityBanner = (Master.FindControl("facilityBanner") as HtmlGenericControl);
            if (facilityBanner != null) facilityBanner.Style.Add("display", "inline");

            HtmlGenericControl patientBanner = (Master.FindControl("patientBanner") as HtmlGenericControl);
            if (patientBanner != null) patientBanner.Style.Add("display", "none");
            HtmlGenericControl username1 = (Master.FindControl("username1") as HtmlGenericControl);
            if (username1 != null)
                username1.Attributes["class"] = "usernameLevel1"; //Style.Add("display", "inline");
            HtmlGenericControl currentdate1 = (Master.FindControl("currentdate1") as HtmlGenericControl);
            if (currentdate1 != null) currentdate1.Attributes["class"] = "currentdateLevel1"; //Style.Add("display", "inline");
            HtmlGenericControl facilityName = (Master.FindControl("facilityName") as HtmlGenericControl);
            if (facilityName != null) facilityName.Attributes["class"] = "facilityLevel1"; //Style.Add("display", "inline");
            //userNameLevel2.Style.Add("display", "none");
            //currentDateLevel2.Style.Add("display", "none");
            HtmlGenericControl imageFlipLevel2 = (Master.FindControl("imageFlipLevel2") as HtmlGenericControl);
            if (imageFlipLevel2 != null) imageFlipLevel2.Style.Add("display", "none");
            //facilityLevel2.Style.Add("display", "none");
            HtmlGenericControl level2Navigation = (Master.FindControl("level2Navigation") as HtmlGenericControl);
            if (level2Navigation != null) level2Navigation.Style.Add("display", "none");
        }
        /// <summary>
        /// Handles the PreRender event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            divError.Visible = this.isError;
        }
        /// <summary>
        /// Handles the RowCommand event of the ReverseTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CommandEventArgs"/> instance containing the event data.</param>
        void ReverseTransaction_RowCommand(object sender, CommandEventArgs e)
        {
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Handles the NotifyCommand event of the ReverseTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CommandEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        void ReverseTransaction_NotifyCommand(object sender, CommandEventArgs e)
        {
            //List<KeyValuePair<string, string>> param = e.CommandArgument as List<KeyValuePair<string, string>>;
            //string strMessage = param.Find(l => l.Key == "Message").Value;
            //string strTitle = param.Find(l => l.Key == "Message").Value;
            //bool errorFlag = param.Find(l => l.Key == "errorFlag").Value.Equals("true");
            //this.NotifyAction(strMessage, strTitle, errorFlag);
        }

        /// <summary>
        /// Handles the ErrorOccurred event of the ReverseTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CommandEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        void ReverseTransaction_ErrorOccurred(object sender, CommandEventArgs e)
        {
            // throw new NotImplementedException();
            Exception ex = e.CommandArgument as Exception;
            this.showErrorMessage(ref ex);
        }        
        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="ex">The ex.</param>
        void showErrorMessage(ref Exception ex)
        {
            this.isError = true;
            //if (this.Debug)
            //{
            //    lblError.Text = ex.Message + ex.StackTrace + ex.Source;
            //}
            //else
            //{
            //    lblError.Text = "An error has occured within IQCARE during processing. Please contact the support team";
            //    this.isError = this.divError.Visible = true;
            //    Exception lastError = ex;


            //    lastError.Data.Add("Domain", "Patient Consumeable Issueance Form");
            //    //Application.Logger.EventLogger logger = new Application.Logger.EventLogger();
            //    //logger.LogError(ex);


            //}
            CLogger.WriteLog(ELogLevel.ERROR, ex.ToString());
            if (Session["PatientId"] == null || Convert.ToInt32(Session["PatientId"]) != 0)
            {
                this.NotifyAction("Application has an issue, Please contact Administrator!", "Application Error", true, "window.location.href='../frmFindAddCustom.aspx?srvNm=" + Session["TechnicalAreaName"] + "&mod=0'");
                //Response.Write("<script>alert('Application has an issue, Please contact Administrator!') ; window.location.href='../frmFindAddCustom.aspx?srvNm=" + Session["TechnicalAreaName"] + "&mod=0'</script>");
            }
            else
            {
                if (Session["TechnicalAreaId"] != null || Convert.ToInt16(Session["TechnicalAreaId"]) != 0)
                {
                    this.NotifyAction("Application has an issue, Please contact Administrator!", "Application Error", true, "window.location.href='../frmFacilityHome.aspx';");
                    //Response.Write("<script>alert('Application has an issue, Please contact Administrator!') ; window.location.href='../frmFacilityHome.aspx'</script>");

                }
                else
                {

                    this.NotifyAction("Application has an issue, Please contact Administrator!", "Application Error", true, "window.location.href='../frmLogin.aspx';");
                    //Response.Write("<script>alert('Application has an issue, Please contact Administrator!') ; window.location.href='../frmLogin.aspx'</script>");
                }
            }
            ex = null;

        }
        /// <summary>
        /// Notifies the action.
        /// </summary>
        /// <param name="strMessage">The string message.</param>
        /// <param name="strTitle">The string title.</param>
        /// <param name="errorFlag">if set to <c>true</c> [error flag].</param>
        void NotifyAction(string strMessage, string strTitle, bool errorFlag, string onOkScript = "")
        {
            // ConfirmModalPopupExtender.Hide();
            // this.mpe1.Hide();
            lblNoticeInfo.Text = strMessage;
            lblNotice.Text = strTitle;
            lblNoticeInfo.ForeColor = (errorFlag) ? System.Drawing.Color.DarkRed : System.Drawing.Color.DarkGreen;
            lblNoticeInfo.Font.Bold = true;
            imgNotice.ImageUrl = (errorFlag) ? "~/Common/images/mb_hand.gif" : "~/Common/images/mb_information.gif";
            btnOkAction.OnClientClick = "";
            if (onOkScript != "" && errorFlag == true)
            {
                btnOkAction.OnClientClick = onOkScript;
            }
            this.notifyPopupExtender.Show();
        }
        // static IBilling _Ibilling;

        /// <summary>
        /// Gets the billing manager.
        /// </summary>
        /// <value>
        /// The billing manager.
        /// </value>
        IBilling BillingManager
        {
            get
            {

                return (IBilling)ObjectFactory.CreateInstance("BusinessProcess.SCM.BBilling, BusinessProcess.SCM");

            }
        }
        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        int UserID
        {
            get
            {
                return Convert.ToInt32(base.Session["AppUserId"]);
            }
        }
        /// <summary>
        /// Gets a value indicating whether this <see cref="frmBilling_ReverseBill"/> is debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        bool Debug
        {
            get
            {
                bool _debug = true;
                bool.TryParse(ConfigurationManager.AppSettings.Get("DEBUG").ToLower(), out _debug);
                return _debug;
            }
        }

        
    }
}
