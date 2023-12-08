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
                lstRoles.DataSource = RoleServiceManager.GetAllRoles();
                lstRoles.DataBind();

                lstUsers.DataSource = Membership.GetAllUsers();
                lstUsers.DataBind();

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
                    lstRoles.DataSource = RoleServiceManager.GetAllRoles();
                    lstRoles.DataBind();
                }
                //Display Error here
            }catch(Exception ex)
            {
                //Display Error here
            }
        }

        protected void btnAssignRoleToUser_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(lstUsers.SelectedItem.Text,
            lstRoles.SelectedItem.Text);

           //TO Be continued
        }
    }
}