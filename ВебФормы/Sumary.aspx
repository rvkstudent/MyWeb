<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumary.aspx.cs" Inherits="ВебФормы.Sumary" %>
<%@ Import Namespace="ВебФормы" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <h2>Приглашения</h2>
     <form id="rsvpform2" runat="server">
      <asp:Button id="Button1" Text="Click here for greeting..." OnClick="GreetingBtn_Click" runat="server"/> 
      </form>
      <br />
     
    <h3>Люди которые были приглашены: </h3>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Email</th>
            </tr>
        </thead>
        <tbody>
            <% var yesData = ResponseRepository.GetRepository().GetAllResponses()
                    .Where(r => r.WillAttend.Value);
                foreach (var rsvp in yesData) {
                    string htmlString = String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td>",
                        rsvp.Name, rsvp.Email, rsvp.Phone);
                    Response.Write(htmlString);
                } %>
        </tbody>
    </table>
</body>
</html>
