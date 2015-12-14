﻿<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
    <header>
        <div class="content-wrapper">
            <div class="float-left">
                <p class="site-title">
                    <a href="~/">ASP.NET Web API</a></p>
            </div>
            <div class="float-right">
                <nav>
                    <ul id="menu">
                        <li>@Html.ActionLink("Inicio", "Index", "Home", New with { .area = "" }, Nothing)</li>
                        <li>@Html.ActionLink("API", "Index", "Help", New with { .area = "" }, Nothing)</li>
                    </ul>
                </nav>
            </div>
        </div>
    </header>
    @RenderBody()

    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
</body>
</html>