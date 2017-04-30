<%@ Application Language="C#" %>
<script RunAt="server">
    void Session_Start(object sender, EventArgs e){
        Session["price"] = 0.00;
        Session["order"] = "";
    }
</script>