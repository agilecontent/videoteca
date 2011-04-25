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
                <form action="/" method="post">
                    <label for="rating">Nota</label>
                    <select name="rating">
                        <option value="5">5</option>
                        <option value="4">4</option>
                        <option value="3">3</option>
                        <option value="2">2</option>
                        <option value="1">1</option>
                    </select>
                    <input type="submit" value="alterar"/>
                </form>
            </div>
        </li>
        <% } %>
    </ul>
</div>
</asp:Content>