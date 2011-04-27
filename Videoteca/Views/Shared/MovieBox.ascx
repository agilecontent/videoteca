<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Videoteca.Models.Movie>" %>
<div class="movie_box">
    <img src="/content/images/movies/<%= Model.Id %>.jpg" alt="<%= Model.Title %>" />
    <span class="title">
        <%= Html.RouteLink(Model.Title, "edit_movie_path", new { Model.Id })  %>
    </span>
    <span class="genre">
        <%= Html.RouteLink(Model.Genre.Title, "genre_path", new { Model.Genre.Id })%>
    </span>
    <span class="year"><%= Model.Year %></span>
    <div class="rating">
        <% using(Html.BeginRouteForm("rate_movie_path", new { Model.Id })) { %>
            <label for="rating">Nota</label>
            <%= Html.DropDownListFor(m => m.Rating, new SelectList(Enumerable.Range(1, 5).Reverse())) %>
            <input type="submit" value="alterar"/>
        <% } %>
    </div>
</div>