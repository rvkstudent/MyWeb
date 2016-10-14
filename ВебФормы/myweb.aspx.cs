using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ВебФормы
{
    public partial class Моя_форма : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
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

                           /* // Delete the file if it exists.
                            if (File.Exists(path))
                            {
                           
                                File.Delete(path);
                            }*/

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
                        Response.Redirect("Sumary.aspx");
                    }
                    else
                    {
                        Response.Redirect("sorryyoucantcome.html");
                    }
                }
            }
        }
    }
}