function BuscarCorreo() {

    $("#btnCambiar").prop("disabled", true);
    let correoValidar = $("#CorreoElectronico").val();

    $.ajax({
        type: "POST",
        url: "/Home/BuscarCorreo",
        dataType: "json",
        data: {
            "correoValidar": correoValidar
        },
        success: function (res) {

            if (res != "ERROR") {
                if (res == "") {
                    $("#btnCambiar").prop("disabled", false);
                }
                else {
                    alert(res);
                }
            }

        }
    });

}

function validarContrasenna() {

    $("#btnCambiar").prop("disabled", true);
    let passValidar = $("#Contraseñatemporal").val();

    $.ajax({
        type: "POST",
        url: "/Home/BuscarContrasenna",
        dataType: "json",
        data: {
            "passValidar": passValidar
        },
        success: function (res) {

            if (res != "ERROR") {
                if (res == "") {
                    $("#btnCambiar").prop("disabled", false);
                }
                else {
                    alert(res);
                }
            }

        }
    });
}