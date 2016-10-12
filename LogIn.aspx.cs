using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;

namespace ResTesting
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static StudDetails[] GetStudList()
        {
             DataTable dtTest = new DataTable();
                DataRow dr;

                #region Add student

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student1";
                dr["Division"] = "A";
                dtTest.Rows.Add(dr);

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student2";
                dr["Division"] = "A";
                dtTest.Rows.Add(dr);

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student3";
                dr["Division"] = "A";
                dtTest.Rows.Add(dr);

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student4";
                dr["Division"] = "B";
                dtTest.Rows.Add(dr);

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student5";
                dr["Division"] = "B";
                dtTest.Rows.Add(dr);

                dr = dtTest.NewRow();
                dr["Id"] = 1;
                dr["Name"] = "Student6";
                dr["Division"] = "C";
                dtTest.Rows.Add(dr);

                #endregion

                List<StudDetails> details = new List<StudDetails>();

                foreach (DataRow drow in dtTest.Rows)
                {
                    StudDetails student = new StudDetails();
                    student.Id =   dr["Id"].ToString();
                    student.StudentName = dr["Name"].ToString();
                    student.Division = dr["Division"].ToString();
                }
                return details.ToArray();
        }
    }

    public class StudDetails
{
public string Id { get; set; }
public string StudentName { get; set; }
public string Division { get; set; }
}
}