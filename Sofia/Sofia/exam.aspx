<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam.aspx.cs" Inherits="Sofia.exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <center><h1>Security+ 20 Question Practice Exam</h1></center>
            <hr />

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td><%#Eval("Qid") %> : <%#Eval("Question") %> </td>
                        </tr>
                        <tr>
                            <td>
                                <ul>

                                    <li>
                                        <asp:RadioButton ID="RadOption1" runat="server" Text='<%#Eval("option1") %>' GroupName="Sec" /></li>
                                    <li>
                                        <asp:RadioButton ID="RadOption2" runat="server" Text='<%#Eval("option2") %>' GroupName="Sec" /></li>
                                    <li>
                                        <asp:RadioButton ID="RadOption3" runat="server" Text='<%#Eval("option3") %>' GroupName="Sec" /></li>
                                    <li>
                                        <asp:RadioButton ID="RadOption4" runat="server" Text='<%#Eval("option4") %>' GroupName="Sec" /></li>

                                </ul>

                                

                                <b><asp:Label ID="LabCorrectAns" runat="server" Text='<%#Eval("Correctans") %>' Visible="false"></asp:Label></b>
                                <hr />

                                <tr>

                                    <td>
                                        <asp:Label ID="LabUserSelectedOption" runat="server" Text=""></asp:Label>

                                    </td>
                                </tr>

                            </td>

                        </tr>

                    </table>


                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="ButSubmit" runat="server" Text="Submit" OnClick="ButSubmit_Click" />
            

        </div>
    </form>
</body>
</html>
