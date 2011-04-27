<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Layout.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<asp:Content ID="title" ContentPlaceHolderID="TitleContent" runat="server">Index</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
<div id="movie-list">
    <ul>
        <% foreach (var movie in (this.ViewData["movies"] as IEnumerable<Movie>)) { %>
        <li>
            <% Html.RenderPartial("MovieBox", movie); %>
        </li>
        <% } %>
    </ul>
</div>
</asp:Content>