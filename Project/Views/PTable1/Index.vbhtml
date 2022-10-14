@ModelType IEnumerable(Of Project.Table1)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.P_Id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.P_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.C_Id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Table.C_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.P_Id)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.P_Name)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.C_Id)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Table.C_Name)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.P_Id}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.P_Id}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.P_Id})
    </td>
</tr>
Next

</table>
