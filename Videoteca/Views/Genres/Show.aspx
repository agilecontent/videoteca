<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Layout.Master" Inherits="System.Web.Mvc.ViewPage<Genre>" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>// <%= Model.Title %></h2>
    <div id="movie-list">
    <ul>
        <% foreach (var movie in Model.Movies) { %>
        <li>
            <% Html.RenderPartial("MovieBox", movie); %>
        </li>
        <% } %>
    </ul>
</div>
</asp:Content>