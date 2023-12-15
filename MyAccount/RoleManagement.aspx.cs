using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical5
{
    public partial class RoleManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                lstRoles.DataSource = Roles.GetAllRoles();
                lstRoles.DataBind();

                lstUsers.DataSource = Membership.GetAllUsers();
                lstUsers.DataBind();

                ddlRole.DataSource = Roles.GetAllRoles();
                ddlRole.DataBind();
            }

        }

        protected void btnInsertRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRole.Text.Trim();

            try 
            {
                if (Roles.RoleExists(roleName))
                {
                    //Display Error here
                }
                else {
                    Roles.CreateRole(roleName);
                    lstRoles.DataSource = Roles.GetAllRoles();
                    lstRoles.DataBind();
                    ddlRole.DataSource = Roles.GetAllRoles();
                    ddlRole.DataBind();
                }
                //Display Error here
            }catch(Exception ex)
            {
                //Display Error here
                Response.Write(ex.ToString());
            }
        }

        protected void btnAssignRole_Click(object sender, EventArgs e)
        {
            try
            {
                Roles.AddUserToRole(
                    lstUsers.SelectedItem.Text,
                    lstRoles.SelectedItem.Text);
                lstUserRole.DataSource =
                    Roles.GetRolesForUser(lstUsers.SelectedItem.Text);
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            Roles.AddUserToRole(lstUsers.SelectedItem.Text,
            lstRoles.SelectedItem.Text);

           //TO Be continued
        }

        protected void btnGetRoleUsers_Click(object sender, EventArgs e)
        {
            lstUserRole.DataSource =
                Roles.GetRolesForUser(ddlRole.SelectedValue);
            lstUserRole.DataBind(); 
        }
    }
}