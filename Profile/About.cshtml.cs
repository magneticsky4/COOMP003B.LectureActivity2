@{
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>@ViewData["Title"]<h2>
<p>this page introduces me to the world of ASP.NET Core.</p>
await Html.PartialAsync("_Sidebare")