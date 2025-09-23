let contExamesRealizados = 0;

function adicionarExameRealizado() {
    const tipo = document.getElementById("tipoExameRealizado").value;
    const data = document.getElementById("dataExameRealizado").value;
    const laudoInput = document.getElementById("laudoExameRealizado");
    const laudo = laudoInput.files.length > 0 ? laudoInput.files[0].name : "";

    if (!tipo || !data) {
        alert("Preencha Tipo e Data do exame!");
        return;
    }

    const lista = document.getElementById("listaExamesRealizados");
    const inputsHidden = document.getElementById("inputsHiddenExamesRealizados");

    // Pré-visualização
    const div = document.createElement("div");
    div.classList.add("border", "p-3", "mb-3");
    div.innerHTML = `
        <strong>Tipo:</strong> ${tipo} <br/>
        <strong>Data:</strong> ${data} <br/>
        <strong>Laudo:</strong> ${laudo || 'Não anexado'}
    `;
    lista.appendChild(div);

    // Inputs hidden para envio
    inputsHidden.innerHTML += `
        <input type="hidden" name="Exames[${contExamesRealizados}].Tipo" value="${tipo}" />
        <input type="hidden" name="Exames[${contExamesRealizados}].Data" value="${data}" />
        <input type="hidden" name="Exames[${contExamesRealizados}].Laudo" value="${laudo}" />
    `;

    contExamesRealizados++;

    // Limpar modal
    document.getElementById("tipoExameRealizado").value = "";
    document.getElementById("dataExameRealizado").value = "";
    laudoInput.value = "";

    const modal = bootstrap.Modal.getInstance(document.getElementById("modalExameRealizado"));
    modal.hide();
}
