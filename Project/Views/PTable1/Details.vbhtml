@ModelType Project.Table1
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Table1</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.P_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.P_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Table.C_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Table.C_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.P_Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
