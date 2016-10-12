<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="ResTesting.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
               <div id="dvMsg" runat="server"><asp:Label ID="lblErr" runat="server" CssClass="errMsg"></asp:Label></div>
                <div id="content" class="content_mod_2">
                    <h1>Training Feedback Form</h1>
                    <p><span>Thank you for taking the time to provide feedback regarding Backbone.js training that you have attended.</span></p>
                    <label>Name:</label><br />
                    <asp:TextBox ID="txtName" runat="server" Style="border: 1px inset #808080;"></asp:TextBox><br />
                    <label>1. This Training:</label>
                    <asp:RadioButtonList ID="rdbtnlstThisTraining" runat="server">
                        <asp:ListItem Value="Exceeded My Expectations">
                            Exceeded My Expectations
                        </asp:ListItem>
                        <asp:ListItem Value="Met My Expectations">
                            Met My Expectations
                        </asp:ListItem>
                        <asp:ListItem Value=" Did Not Meet My Expectations"> Did Not Meet My Expectations
                        </asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <label for="tff_apply">2. What you learn from this training?</label><br />
                    <asp:TextBox ID="txtWhatLearning" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <label for="tff_apply">3. How will you apply what you learned to your job?</label><br />
                    <asp:TextBox ID="txtApplylearned" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <label for="tff_apply">4. What was missing in this training?</label><br />
                    <asp:TextBox ID="txtMissing" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <label for="tff_apply">5. what would have been done better?</label><br />
                    <asp:TextBox ID="txtDoneBetter" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:Button CssClass="btn" runat="server" Text="Submit" ID="btnSubmit" OnClick="btnSubmit_Click" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
