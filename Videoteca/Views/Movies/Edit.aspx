<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Layout.Master" Inherits="System.Web.Mvc.ViewPage<Videoteca.Models.Movie>" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<% var genres = this.ViewData["genres"] as IEnumerable<Genre>; %>

<div id="movie-form">
    <% using(Html.BeginRouteForm("update_movie_path")) {  %>
        <dl>
            <dt><%= Html.LabelFor(m => m.Title) %></dt>
            <dd><%= Html.TextBoxFor(m => m.Title) %></dd>

            <dt><%= Html.LabelFor(m => m.Year) %></dt>
            <dd><%= Html.TextBoxFor(m => m.Year) %></dd>
            
            <dt><%= Html.Label("genre_id", "Genre") %></dt>
            <dd>
                <%= Html.DropDownList("genre_id", new SelectList(genres, "id", "title", Model.Genre.Id)) %>
            </dd>

            <dt><%= Html.LabelFor(m => m.Rating) %></dt>
            <dd><%= Html.DropDownListFor(m => m.Rating, new SelectList(Enumerable.Range(1, 5).Reverse()), new { id = "rating"})%></dd>
        </dl>
        <div>
            <input type=submit value="salvar" />
        </div>
    <% } %>
</div>

</asp:Content>
