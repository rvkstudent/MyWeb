using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web.ModelBinding;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace ВебФормы
{
    public partial class Моя_форма : System.Web.UI.Page
    {

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           
        }
        private void LinkBtn_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {

                case "SiZ6":

                    Label1.Text = TextBox1.Text;
                    break;


            }
        }
        public void GreetingBtn_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("myweb.aspx");
            
        }

       
        protected void Page_Load(object sender, EventArgs e)
        {


            System.Data.SqlClient.SqlConnection sqlConnection1 =
                           new System.Data.SqlClient.SqlConnection(@"Data Source=ROMANNB-ПК;Initial Catalog=C:\CANDLEBASE\DATABASE1.MDF;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd1 = new System.Data.SqlClient.SqlCommand();

            cmd1.CommandType = System.Data.CommandType.Text;

            cmd1.Connection = sqlConnection1;

            cmd1.CommandText = "SELECT * FROM portfolio_funds ;";

            sqlConnection1.Open();

            System.Data.SqlClient.SqlDataReader reader2 = cmd1.ExecuteReader();
            
            reader2.Close();

            reader2 = cmd1.ExecuteReader();

            TableHeaderCell header = new TableHeaderCell();

            header.RowSpan = 1;
            header.ColumnSpan = 3;
            
            header.Text = "Показатели счета";
            header.Font.Bold = true;
            header.HorizontalAlign = HorizontalAlign.Center;
            header.VerticalAlign = VerticalAlign.Middle;

            // Add the header to a new row.
            TableRow headerRow = new TableRow();
            headerRow.Cells.Add(header);

            // Add the header row to the table.
            Table1.Rows.AddAt(0, headerRow);

          
            Table1.BorderWidth = 1;
            Table1.CellPadding = 5;

            if (reader2.HasRows)
            {
               
                while (reader2.Read())
                {

                    TableRow r = new TableRow();
                    
                        for (int i = 0; i <= 7; i++)
                        {
                        TableCell c = new TableCell();
                        if (reader2.GetDataTypeName(i) == "nvarchar" || reader2.GetDataTypeName(i) == "nchar")
                           c.Text = reader2.GetString(i);
                        else
                            c.Text = reader2.GetDouble(i).ToString();

                        r.HorizontalAlign = HorizontalAlign.Center;
                        r.BorderWidth = 1;

                        c.HorizontalAlign = HorizontalAlign.Center;
                        c.BorderWidth = 1;

                       

                        r.Cells.Add(c);

                        }
                        Table1.Rows.Add(r);
                      
                }

            }
            


            cmd1.CommandText = "SELECT * FROM dbo.[Current] where Ticker = 'SiZ6' or  Ticker = 'SNGSP' or  Ticker = 'BRX6' ;";

            reader2.Close();

            System.Data.SqlClient.SqlDataReader reader = cmd1.ExecuteReader();

            header = new TableHeaderCell();

            header.RowSpan = 1;
            header.ColumnSpan = 4;

            header.Text = "Текущие цены";
            header.Font.Bold = true;
            header.HorizontalAlign = HorizontalAlign.Center;
            header.VerticalAlign = VerticalAlign.Middle;

            // Add the header to a new row.
            headerRow = new TableRow();
            headerRow.Cells.Add(header);

            // Add the header row to the table.
            Table2.Rows.AddAt(0, headerRow);


            Table2.BorderWidth = 1;
            Table2.CellPadding = 5;

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    TableRow r = new TableRow();

                    for (int i = 0; i <= 3; i++)
                    {
                        TableCell c = new TableCell();
                        if (reader.GetDataTypeName(i) == "nvarchar" || reader.GetDataTypeName(i) == "nchar")
                            c.Text = reader.GetString(i);
                        else
                            c.Text = reader.GetDouble(i).ToString();

                        r.HorizontalAlign = HorizontalAlign.Center;
                        r.BorderWidth = 1;

                        c.HorizontalAlign = HorizontalAlign.Center;
                        c.BorderWidth = 1;



                        r.Cells.Add(c);


                    }

                    TableCell b = new TableCell();
                    // Создать новый объект кнопки. 

                 LinkButton LinkBtn = new LinkButton();
                    LinkBtn.CommandArgument = reader.GetString(0);
                    LinkBtn.CommandName = reader.GetString(0);
                    LinkBtn.Command += new CommandEventHandler(LinkBtn_Command);
                    LinkBtn.Text = "Удалить";
                    //Page.Form.Controls.Add(LinkBtn);
                   // b.Text = reader.GetString(0);
                    b.Controls.Add(LinkBtn);
                    ///r.Cells.Add(b);
                    r.Cells.Add(b);


                    Table2.Rows.Add(r);

                }

            }

            reader.Close();
            sqlConnection1.Close();

           
                        

            Button1.Click += new EventHandler(this.GreetingBtn_Click);

            /* if (IsPostBack)
             {
                 GuestResponse rsvp = new GuestResponse();

                 if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                 {
                     ResponseRepository.GetRepository().AddResponse(rsvp);



                     if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value)
                     {

                   string path = @"d:\\MyTest.txt";

                         try
                         {


                             // Create the file.
                             using (FileStream fs = File.Create(path))
                             {
                                 Byte[] info = new UTF8Encoding(true).GetBytes(rsvp.Name.ToString());
                                 // Add some information to the file.

                                 fs.Write(info, 0, info.Length);
                             }


                         }

                         catch (Exception ex)
                         {
                             ;
                         }
                         Response.Redirect("myweb.aspx");
                     }
                     else
                     {
                         Response.Redirect("myweb.aspx");
                     }
                 }
             }*/
        }
    }
}