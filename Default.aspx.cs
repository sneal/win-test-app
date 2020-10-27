using System;
using System.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Stop Caching in IE
        Response.Cache.SetCacheability(HttpCacheability.NoCache);

        // Stop Caching in Firefox
        Response.Cache.SetNoStore();
    }
}
