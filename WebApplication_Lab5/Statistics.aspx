
<%
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
%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="WebApplication_Lab5.Statistics" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistic Calculator</title>
    <%-- Used the bootstrap provided by the Currency Calculator example --%>

    <%-- Use Bootstrap to style the page --%>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    
    <%-- Jquery required by Bootstrap  --%>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    
    <%-- Bootstrap's Javascript library --%>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container" style="background-color:aqua">
        <br />
        <h1>Statistic Calculator</h1>
        <br />
        <p>Enter three numbers and click Submit button to find out the statistics</p>
        <br />
        <form id="form1" runat="server">
            <div class="row form-group">
                <div class="col-md-4 align-content-center font-weight-bold">First Number:</div> <div class="col-md-2"><asp:TextBox runat="server" ID="txtFirstNumber" CssClass="form-control" OnTextChanged="txtFirstNumber_TextChanged"></asp:TextBox></div>
            </div>
            <div class="row form-group">
                <div class="col-md-4 align-content-center font-weight-bold">Second Number:</div> <div class="col-md-2"><asp:TextBox runat="server" ID="txtSecondNumber" CssClass="form-control"></asp:TextBox></div>
            </div>
            <div class="row form-group">
                <div class="col-md-4 align-content-center font-weight-bold">Third Number:</div> <div class="col-md-2"><asp:TextBox runat="server" ID="txtThirdNumber" CssClass="form-control"></asp:TextBox></div>
            </div>
            <div class="row form-group">
                <div class="col-md-3"><asp:Button runat="server" Text="Submit" CssClass="form-control btn btn-primary"/></div>
            </div>
            <div class="row form-group">
                <div class="col-md-5"><asp:Label runat="server" ID="lblErrorMsg" CssClass="alert-danger" Visible="false"/></div>
            </div>
            <br />
        </form>
        <h2>Statistics of the numbers you entered</h2>
        <br />
        <div class="row form-group">
            <div class="col-md-4 align-content-center font-weight-bold" style="padding-top:5px"> 
                    Maximum: <asp:Label runat="server" ID="lblToMaximum"></asp:Label>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-4 align-content-center font-weight-bold" style="padding-top:5px"> 
                    Minimum: <asp:Label runat="server" ID="lblToMinimum"></asp:Label>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-4 align-content-center font-weight-bold" style="padding-top:5px"> 
                    Average: <asp:Label runat="server" ID="lblToAverage"></asp:Label>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-4 align-content-center font-weight-bold" style="padding-top:5px"> 
                    Total: <asp:Label runat="server" ID="lblToTotal"></asp:Label>
        </div>
        </div>
        <br />
    </div>
    
</body>
</html>
