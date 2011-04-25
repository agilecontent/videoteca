<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Layout.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<asp:Content ID="title" ContentPlaceHolderID="TitleContent" runat="server">Index</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
<div id="movie-list">
    <ul>
        <% foreach (var movie in (this.ViewData["movies"] as IEnumerable<Movie>)) { %>
        <li>
            <img src="/content/images/movies/<%= movie.Id %>.jpg" alt="<%= movie.Title %>" />
            <span class="title">
                <%= Html.RouteLink(movie.Title, "movie_path", new { movie.Id })  %>
            </span>
            <span class="genre">
                <%= Html.RouteLink(movie.Genre.Title, "genre_movies_path", new { movie.Genre.Id })%>
            </span>
            <span class="year"><%= movie.Year %></span>
            <div class="rating">
                <% Html.BeginRouteForm("edit_movie_path", new { movie.Id }) { %>
                    <label for="rating">Nota</label>
                    <%= Html.DropDownList("rating", new SelectList(Enumerable.Range(1, 5).Reverse(), movie.Rating)) %>
                    <input type="submit" value="alterar"/>
                <% } %>
            </div>
        </li>
        <% } %>
    </ul>
</div>
</asp:Content>