@ModelType IEnumerable(Of TesteOracle.Medico)
@Code
ViewData("Title") = "Medicos"
End Code

<h2>Medicos</h2>

<p>
    @Html.ActionLink("Novo", "InserirMedico", New With {.htmlAttributes = New With {.class = "btn btn-primary"}})
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Especialidade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CRM)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Especialidade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CRM)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
