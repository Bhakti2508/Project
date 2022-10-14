@ModelType Project.Table1
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
