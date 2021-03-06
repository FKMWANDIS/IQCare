using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Interface.Administration;
using Application.Presentation;
using Application.Common;
public partial class Admin_LabTestlist : LogPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AppLocation"] == null || Session.Count == 0 || Session["AppUserID"].ToString() == "")
        {
            IQCareMsgBox.Show("SessionExpired", this);
            Response.Redirect("~/frmlogin.aspx",true);
        }
        ILabMst LabManager;
        try
        {
            if (!IsPostBack)
            {
                //(Master.FindControl("lblRoot") as Label).Text = " � Customize Lists";
                //(Master.FindControl("lblMark") as Label).Visible = false;
                //(Master.FindControl("lblheader") as Label).Text = "Laboratory";  
                //(Master.FindControl("levelOneNavigationUserControl1").FindControl("lblRoot") as Label).Text = "Customize Lists >> ";
                //(Master.FindControl("levelOneNavigationUserControl1").FindControl("lblheader") as Label).Text = "Laboratory";
                LabManager = (ILabMst)ObjectFactory.CreateInstance("BusinessProcess.Administration.BLabMst, BusinessProcess.Administration");
                DataSet theDS = LabManager.GetLabs();
                this.grdLab.DataSource = theDS.Tables[0];
                this.grdLab.DataBind();
                ViewState["gridSortDirection"] = "Desc";
                ViewState["FID"] = Request.QueryString["Fid"].ToString();
                if (ViewState["grdDataSource"] == null)
                    ViewState["grdDataSource"] = theDS.Tables[0];
                ViewState["SortDirection"] = "Desc";
                BindGrid();
            }
        }
        catch (Exception err)
        {
            MsgBuilder theBuilder = new MsgBuilder();
            theBuilder.DataElements["MessageText"] = err.Message.ToString();
            IQCareMsgBox.Show("#C1", theBuilder, this);
            return;
        }
        finally
        {
            LabManager = null;
        }       

    }
    protected void grdLab_RowDataBound(object sender, GridViewRowEventArgs e)

    {
        //So that when the user clicks on the row - the corresponding row is edited
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.cursor='pointer';this.style.BackColor='#666699';");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='';");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grdLab, "Select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Add new Lab test
        
        //url = "frmAdmin_LaboratoryTestMaster.aspx?name=Add";
        string theUrl = string.Format("{0}?Name={1}&Fid={2}", "frmAdmin_LaboratoryTestMaster.aspx","Add", ViewState["FID"].ToString());
        Response.Redirect(theUrl);
    }
  
    protected void grdLab_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        //Edit the selected row
        int thePage = grdLab.PageIndex;
        int thePageSize = grdLab.PageSize;


        GridViewRow theRow = grdLab.Rows[e.NewSelectedIndex];
        int theIndex = thePageSize * thePage + theRow.RowIndex;

        int LabId = Convert.ToInt32(theRow.Cells[0].Text.ToString());
        string theUrl = string.Format("{0}LabId={1}&Fid={2}", "frmAdmin_LaboratoryTestMaster.aspx?name=" + "Edit" + "&", LabId, ViewState["FID"].ToString());
        Response.Redirect(theUrl);

    }
  

    #region User functions
    private void BindGrid()
    {

        //Bind the fields of the gridview
        BoundField theCol0 = new BoundField();
        theCol0.HeaderText = "Lab Test ID";
        theCol0.DataField = "LabTestID";
        theCol0.ItemStyle.CssClass = "textstyle";
        theCol0.ReadOnly = true;

        BoundField theCol1 = new BoundField();
        theCol1.HeaderText = "Priority";
        theCol1.DataField = "Sequence";
        theCol1.ItemStyle.CssClass = "textstyle";
        theCol1.SortExpression = "Sequence";
        theCol1.ItemStyle.Font.Underline = true;
        theCol1.ReadOnly = true;


        BoundField theCol2 = new BoundField();
        theCol2.HeaderText = "Lab Type";
        theCol2.ItemStyle.CssClass = "textstyle";
        theCol2.DataField = "LabTypeName";
        theCol2.SortExpression = "LabTypeName";
        theCol2.ReadOnly = true;

        BoundField theCol3 = new BoundField();
        theCol3.HeaderText = "Department";
        theCol3.ItemStyle.CssClass = "textstyle";
        theCol3.DataField = "LabDepartmentName";
        theCol3.SortExpression = "LabDepartmentName";
        theCol3.ReadOnly = true;

        BoundField theCol4 = new BoundField();
        theCol4.HeaderText = "Test Name";
        theCol4.ItemStyle.CssClass = "textstyle";
        theCol4.DataField = "LabName";
        theCol4.SortExpression = "LabName";
        theCol4.ReadOnly = true;

        BoundField theCol5 = new BoundField();
        theCol5.HeaderText = "Status";
        theCol5.DataField = "Status";
        theCol5.ItemStyle.CssClass = "textstyle";
        theCol5.SortExpression = "Status";
        theCol5.ReadOnly = true;


        ButtonField theBtn = new ButtonField();
        theBtn.ButtonType = ButtonType.Link;
        theBtn.CommandName = "Select";
        theBtn.HeaderStyle.CssClass = "textstylehidden";
        theBtn.ItemStyle.CssClass = "textstylehidden";

        grdLab.Columns.Add(theCol0);
        grdLab.Columns.Add(theCol1);
        /////grdLab.Columns.Add(theCol2);   ----- Sanjay 13 Sept 2006
        grdLab.Columns.Add(theCol3);
        grdLab.Columns.Add(theCol4);
        grdLab.Columns.Add(theCol5);


        grdLab.Columns.Add(theBtn);

        grdLab.DataBind();
        grdLab.Columns[0].Visible = false;

    }
    #endregion
    protected void grdLab_Sorting(object sender, GridViewSortEventArgs e)
    {
        //sorting
        IQCareUtils clsUtil = new IQCareUtils();
        DataView theDV;
        if (ViewState["SortDirection"].ToString() == "Asc")
        {
            theDV = clsUtil.GridSort((DataTable)ViewState["grdDataSource"], e.SortExpression, ViewState["SortDirection"].ToString());
            ViewState["SortDirection"] = "Desc";
        }
        else
        {
            theDV = clsUtil.GridSort((DataTable)ViewState["grdDataSource"], e.SortExpression, ViewState["SortDirection"].ToString());
            ViewState["SortDirection"] = "Asc";
        }
        grdLab.Columns.Clear();
        grdLab.DataSource = theDV;
        BindGrid();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAdmin_PMTCT_CustomItems.aspx");
    }
}
