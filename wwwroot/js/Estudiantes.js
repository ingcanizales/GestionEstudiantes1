$.ajaxSetup({
    data: {
        __RequestVerificationToken: document.getElementsByName(
            "__RequestVerificationToken"
        )[0].value
    }
});



//Guarda y valida mi formulario
async function Salvar() {
    var form = $("#FormEstudiante").dxForm("instance");
    var valido = form.validate().isValid;

    if (valido) {
        alert("Formulario valido");
        var data = form.option("formData");
        EnviarServidor(data);

    }

}

async function EnviarServidor(dataformulario) {
    try {
        var respuesta = await $.ajax({
            method: "POST",
            url: "/Estudiantes?handler=CrearEstudiante",
            data: dataformulario
        });

        alert("Estudiante Agregado")
    }

    catch (error) {
        alert("Algo Salio Mal")
    }

}