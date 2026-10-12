using System;
using System.Linq;

namespace WebApplication1
{
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataClasses1DataContext db = new DataClasses1DataContext("Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpDB");
                var result = from emp in db.Employees
                             select emp;
                GridView1.DataSource = result;
                GridView1.DataBind();
            }
        }
    }
}
