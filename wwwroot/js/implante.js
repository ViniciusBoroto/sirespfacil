let contImplantes = 0;

function adicionarImplante() {
    const dispositivo = document.getElementById("dispositivo").value;
    const tempoDeUso = document.getElementById("tempoDeUso").value;
    const material = document.getElementById("material").value;
    const localizacao = document.getElementById("localizacao").value;

    if (!dispositivo || !tempoDeUso || !material || !localizacao) {
        alert("Preencha todos os campos!");
        return;
    }

    const lista = document.getElementById("listaImplantes");
    const inputsHidden = document.getElementById("inputsHidden");

    const div = document.createElement("div");
    div.classList.add("border", "p-3", "mb-3");
    div.innerHTML = `
        <strong>Dispositivo:</strong> ${dispositivo} <br/>
        <strong>Tempo de Uso:</strong> ${tempoDeUso} <br/>
        <strong>Material:</strong> ${material} <br/>
        <strong>Localização:</strong> ${localizacao}
    `;
    lista.appendChild(div);

    inputsHidden.innerHTML += `
        <input type="hidden" name="ImplantesMetalicos[${contImplantes}].Dispositivo" value="${dispositivo}" />
        <input type="hidden" name="ImplantesMetalicos[${contImplantes}].TempoDeUso" value="${tempoDeUso}" />
        <input type="hidden" name="ImplantesMetalicos[${contImplantes}].Material" value="${material}" />
        <input type="hidden" name="ImplantesMetalicos[${contImplantes}].Localizacao" value="${localizacao}" />
    `;

    contImplantes++;

    document.getElementById("dispositivo").value = "";
    document.getElementById("tempoDeUso").value = "";
    document.getElementById("material").value = "";
    document.getElementById("localizacao").value = "";

    const modal = bootstrap.Modal.getInstance(document.getElementById("modalImplante"));
    modal.hide();
}