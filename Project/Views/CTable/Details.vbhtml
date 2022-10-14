@ModelType Project.Table
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Table</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.C_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.C_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.C_Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
