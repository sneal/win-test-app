<%@ Application Language="C#" %>

<script runat="server"> 
    void Application_Error(object sender, EventArgs e) 
    {
        Exception lastError = Server.GetLastError();
        Console.WriteLine("Unhandled exception: " + lastError.Message + lastError.StackTrace);
    }
</script>
