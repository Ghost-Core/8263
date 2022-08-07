
/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Student Name                :  Amin Ahmadi                 **/
/**    EMail Address               :  ahma0160@algonquinlive.com  **/
/**    Student Number              :  040993411                   **/
/**    Course Number               :  CST 8253                    **/
/**    Lab Section Number          :  011                         **/
/**    Professor Name              :  Wei Gong                    **/
/**    Assignment Name/Number      :  Lab 5                       **/
/**    Optional Comments           :                              **/
/**                                                               **/
/**                                                               **/
/*******************************************************************/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Lab5
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;

            if (IsPostBack)
            {
                try
                {
                    int firstNumber = int.Parse(txtFirstNumber.Text);

                    int secondNumber = int.Parse(txtSecondNumber.Text);

                    int thirdNumber = int.Parse(txtThirdNumber.Text);

                    int maximum = 0;

                    int minimum = 0;

                    double average = 0.0;

                    int total = 0;

                    if (firstNumber > secondNumber && firstNumber > thirdNumber)
                    {
                        maximum = firstNumber;
                    }
                    else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                    {
                        maximum = secondNumber;
                    }
                    else
                    {
                        maximum = thirdNumber;
                    }

                    if (firstNumber < secondNumber && firstNumber < thirdNumber)
                    {
                        minimum = firstNumber;
                    }
                    else if (secondNumber < firstNumber && secondNumber < thirdNumber)
                    {
                        minimum = secondNumber;
                    }
                    else
                    {
                        minimum = thirdNumber;
                    }

                    average = (double) (firstNumber + secondNumber + thirdNumber) / 3;

                    total = firstNumber + secondNumber + thirdNumber;

                    lblToMaximum.Text = maximum.ToString();

                    lblToMinimum.Text = minimum.ToString();

                    lblToAverage.Text = average.ToString();

                    lblToTotal.Text = total.ToString();
                }
                catch (Exception exception)
                {
                    lblErrorMsg.Visible = true;
                    lblErrorMsg.Text = exception.Message;
                }
            }



        }

        protected void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}