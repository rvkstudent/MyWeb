<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myweb.aspx.cs" Inherits="ВебФормы.Моя_форма" %>
<%@ Import Namespace="ВебФормы" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
    <link href="~/Content/bootstrap-theme.css" rel="stylesheet" />
    <style>
        .btn a {
            color: white;
            text-decoration: none;
        }

        body {
            background-color: #F1F1F1;
        }
         </style>
</head>
<body>
      <div class="panel-body">
   <form id="rsvpform" runat="server">
        <div class="form-group">
            <h1>Показатели из QUIK</h1>
        
           
        </div>
     
        <div class="text-center">
            <button type="submit">Обновить</button>
             <asp:Button id="Button1" Text="Обновить" class="btn btn-success" OnClick="GreetingBtn_Click" runat="server"/> 
        </div>
       <div class="form-group">

           <asp:Table ID="Table2" runat="server">

                <asp:TableHeaderRow id="TableHeaderRow1" 
            BackColor="LightBlue"
            runat="server">
                  <asp:TableHeaderCell 
                Scope="Column" 
                Text="Тикер" />
            <asp:TableHeaderCell  
                Scope="Column" 
                Text="Изм." />
            <asp:TableHeaderCell 
                Scope="Column" 
                Text="Цена посл" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Объем" />
                      <asp:TableHeaderCell 
                Scope="Column" 
                Text="Действие" />
               
        </asp:TableHeaderRow>   
               
                    </asp:Table>
         
         </div>
       <div>
        <asp:Table ID="Table1" runat="server">

            <asp:TableHeaderRow id="Table1HeaderRow" 
            BackColor="LightBlue"
            runat="server">
            <asp:TableHeaderCell 
                Scope="Column" 
                Text="Код" />
            <asp:TableHeaderCell  
                Scope="Column" 
                Text="Изм." />
            <asp:TableHeaderCell 
                Scope="Column" 
                Text="Период" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Вход.средства" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Исход.средства" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Профит" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Мин.маржа" />
                 <asp:TableHeaderCell 
                Scope="Column" 
                Text="Нач.маржа" />
        </asp:TableHeaderRow>          

        </asp:Table>
           </div>

         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    </form>
           
      </div>
      <p>
          &nbsp;</p>
           
      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    
           
</body>
</html>
