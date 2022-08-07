using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2_Lab6.Models;

namespace WebApplication2_Lab6
{
	public partial class RegisterCourse : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (this.IsPostBack == false)
			{
				foreach (Course cors in Helper.GetAvailableCourses())
				{
					chklst.Items.Add(new ListItem(cors.Title + " - " + cors.WeeklyHours + " hours/week", cors.Code));
				}
			}
		}

		protected void cmdOK_Click(object sender, System.EventArgs e)
		{
			bool noCourseSelected = true;

			int totalHours = 0;

			string nameInput = txtStudentName.Text;

			if (string.IsNullOrEmpty(nameInput) == true)
			{
				lblErrorMessage.Text = "You must enter a name!";
			}
			else if (rblStatus.SelectedValue != "0" && rblStatus.SelectedValue != "1" && rblStatus.SelectedValue != "2")
			{
				lblErrorMessage.Text = "You must select you status!";
			}
			else
			{
				foreach (ListItem lstItem in chklst.Items)
				{
					if (lstItem.Selected == true)
					{
						noCourseSelected = false;

						Course cors = Helper.GetCourseByCode(lstItem.Value);

						TableRow rowNew = new TableRow();
						tblCourses.Rows.Add(rowNew);

						TableCell cell = new TableCell();
						rowNew.Cells.Add(cell);
						cell.Text = cors.Code;

						cell = new TableCell();
						rowNew.Cells.Add(cell);
						cell.Text = cors.Title;

						cell = new TableCell();
						rowNew.Cells.Add(cell);
						cell.Text = cors.WeeklyHours.ToString();

						totalHours += cors.WeeklyHours;
					}
				}

				if (noCourseSelected)
				{
					TableRow rowNew = new TableRow();
					tblCourses.Rows.Add(rowNew);

					TableCell cell = new TableCell();
					rowNew.Cells.Add(cell);

					cell.ColumnSpan = 3;
					cell.Text = "No course selected!";
					cell.ForeColor = System.Drawing.Color.Red;
				}

				TableRow finalRow = new TableRow();
				tblCourses.Rows.Add(finalRow);

				TableCell finalCell1 = new TableCell();
				finalRow.Cells.Add(finalCell1);
				finalCell1.Text = "";

				TableCell finalCell2 = new TableCell();
				finalRow.Cells.Add(finalCell2);
				finalCell2.Text = "Total Hours";

				TableCell finalCell3 = new TableCell();
				finalRow.Cells.Add(finalCell3);
				finalCell3.Text = totalHours.ToString();

				bool checksCleared = true;

				if (rblStatus.SelectedValue == "0" && totalHours > 16)
				{
					lblErrorMessage.Text = "Your selection exceeds the maximum weekly hours: 16";

					checksCleared = false;
				}



				int numSelected = 0;

				foreach (ListItem listItem in chklst.Items)
				{
					if (listItem.Selected)
					{
						numSelected += 1;
					}
				}

				if (rblStatus.SelectedValue == "1" && numSelected > 3)
				{
					lblErrorMessage.Text = "Your selection exceeds the number of courses: 3";

					checksCleared = false;
				}



				if (rblStatus.SelectedValue == "2" && numSelected > 2)
				{
					lblErrorMessage.Text = "Your selection exceeds the number of courses: 2";

					checksCleared = false;
				}
				else if (rblStatus.SelectedValue == "2" && totalHours > 4)
				{
					lblErrorMessage.Text = "Your selection exceeds the maximum weekly hours: 4";

					checksCleared = false;
				}


				if (checksCleared)
				{
					lblErrorMessage.Text = "";

					txtStudentName.ReadOnly = true;
					rblStatus.Enabled = false;

					pnlResult.Visible = true;
					pnlSelection.Visible = false;
				}
				else
				{
					pnlResult.Visible = false;
					pnlSelection.Visible = true;
				}


			}







		}
	}
}