<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="WebApplication2_Lab6.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Registration</title>
    <link rel="stylesheet" href="App_Themes/SiteStyles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Algonquin College Course Registration</h1>
        <table>
            <tr>
                <th>
                    Student Name:
                </th>
                <th>
                    <asp:TextBox runat="server" ID="txtStudentName" class="input"></asp:TextBox>
                </th>
                <th>
                    <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Full Time" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Part Time" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Co-Op" Value="2"></asp:ListItem>
                    </asp:RadioButtonList>             
                </th>
            </tr>
        </table>
        <p><asp:Label runat="server" ID="lblErrorMessage" CssClass="emphsis"></asp:Label></p>
        <asp:Panel runat="server" ID="pnlSelection">
            <p>Following courses are currently available for registration</p>
            <asp:CheckBoxList ID="chklst" runat="server" />
            <br /><br />
            <asp:Button ID="cmdOK" Text="Submit" runat="server" OnClick="cmdOK_Click" CssClass="button"/>
            <br /><br />
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlResult" Visible="false" >
        <p>Has enrolled in the following courses:</p>
        <asp:Table ID="tblCourses" runat="server" CssClass="table"> 
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Course Code</asp:TableHeaderCell>
                <asp:TableHeaderCell>Course Title</asp:TableHeaderCell>
                <asp:TableHeaderCell>Weekly Hours</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <a href="RegisterCourse.aspx" >Back to Selection</a>
    </asp:Panel>
        <div>
        </div>
    </form>
</body>
</html>
