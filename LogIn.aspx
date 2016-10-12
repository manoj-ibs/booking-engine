<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="ResTesting.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #wrap
        {
            width: 750px;
            margin: 0 auto;
            background: #99c;
        }
        #header {
background:#ddd;
}
#nav {
background:#c99;
}
#main {
background:#9c9;
}
#sidebar {
background:#c9c;
}
#footer {
background:#cc9;
}

#main {
float:right;
width:600px;
background:#9c9;
}

#sidebar {
float:left;
width:150px;
background:#c9c;
}

#footer {
clear:both;
background:#cc9;
}
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="wrap">
            <div id="header"></div>
            <div id="nav">
                <ul>
                    <li><a href="#">Option 1</a></li>
                    <li><a href="#">Option 2</a></li>
                </ul>
            </div>
            <div id="sidebar">
                <h2>Column 1</h2>
                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit...</p>
                <ul>
                    <li><a href="#">Link 1</a></li>
                    <li><a href="#">Link 2</a></li>
                </ul>
            </div>
            <div id="main">
                <h2>Column 2</h2>
                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit...</p>
            </div>
            
            <div id="footer"></div>
        </div>

    </form>
</body>
</html>
