let exameIndex = 0;

function adicionarExame() {
    const tipo = document.getElementById("tipoExame").value;
    const arquivos = document.getElementById("arquivosExame");

    const lista = document.getElementById("exames-lista");

    // bloco visual para mostrar o exame adicionado
    const div = document.createElement("div");
    div.classList.add("border", "p-2", "mb-2");
    div.innerHTML = `<strong>${tipo}</strong> - ${arquivos.files.length} arquivo(s)`;

    // input hidden para o tipo
    const tipoInput = document.createElement("input");
    tipoInput.type = "hidden";
    tipoInput.name = `Exames[${exameIndex}].Tipo`;
    tipoInput.value = tipo;
    div.appendChild(tipoInput);

    // clona o input de arquivos do modal e troca o "name"
    const fileInputClone = arquivos.cloneNode(true);
    fileInputClone.name = `Exames[${exameIndex}].Arquivos`;
    div.appendChild(fileInputClone);

    lista.appendChild(div);

    exameIndex++;
    arquivos.value = ""; // limpa seleção
    bootstrap.Modal.getInstance(document.getElementById('modalExame')).hide();
}