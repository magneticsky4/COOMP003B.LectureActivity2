@{
    ViewData["Title"]="Hobbies";
    Layout = "~/View/Shared/_Layout.cshtml";
}

<h2>@ViewData["Title"]</h2>
<ul>
    <li>Gaming</li>
    <li>music</li>
    <li>Coding Projects</li>
 </ul>
await Html.PartialAsync("_Sidebare")