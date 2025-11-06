let contExames = 0;

function adicionarExame() {
    const exame = document.getElementById("exame").value;
    const sedacao = document.getElementById("sedacao").checked;
    const classificacaoAsa = document.getElementById("classificacaoAsa").value;
    const lateralidade = document.getElementById("lateralidade").value;

    if (!exame) {
        alert("Preencha o campo Exame!");
        return;
    }

    const lista = document.getElementById("listaExames");
    const inputsHidden = document.getElementById("inputsHiddenExames");

    // Pré-visualização do exame
    const div = document.createElement("div");
    div.classList.add("border", "p-3", "mb-3");
    div.innerHTML = `
        <strong>Exame:</strong> ${exame} <br/>
        <strong>Sedação:</strong> ${sedacao ? 'Sim' : 'Não'} <br/>
        <strong>Classificação ASA:</strong> ${classificacaoAsa} <br/>
        <strong>Lateralidade:</strong> ${lateralidade}
    `;
    lista.appendChild(div);

    // Inputs hidden para envio
    inputsHidden.innerHTML += `
        <input type="hidden" name="ExamesSolicitados[${contExames}].Exame" value="${exame}" />
        <input type="hidden" name="ExamesSolicitados[${contExames}].Sedacao" value="${sedacao}" />
        <input type="hidden" name="ExamesSolicitados[${contExames}].ClassificacaoAsa" value="${classificacaoAsa}" />
        <input type="hidden" name="ExamesSolicitados[${contExames}].Lateralidade" value="${lateralidade}" />
    `;

    contExames++;

    // Limpar modal
    document.getElementById("exame").value = "";
    document.getElementById("sedacao").checked = false;
    document.getElementById("classificacaoAsa").value = "";
    document.getElementById("lateralidade").value = "";

    // Fechar modal
    const modal = bootstrap.Modal.getInstance(document.getElementById("modalExame"));
    modal.hide();
    setTimeout(() => {
        document.querySelectorAll('.modal-backdrop').forEach(b => b.remove());
        document.body.classList.remove('modal-open');
        document.body.style.overflow = '';      // libera scroll
        document.body.style.paddingRight = '';  // remove compensação
    }, 300);
}
