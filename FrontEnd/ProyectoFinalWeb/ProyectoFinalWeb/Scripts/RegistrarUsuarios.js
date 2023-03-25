function BuscarCorreo() {

    $("#btnRegistrar").prop("disabled", true);
    let correoValidar = $("#CorreoElectronico").val();

    $.ajax({
        type: "POST",
        url: "/Home/BuscarCorreo",
        dataType: "json",
        data: {
            "correoValidar": correoValidar
        },
        success: function (res) {

            if (res != "ERROR")
            { 
                if (res == "") {
                    $("#btnRegistrar").prop("disabled", false);
                }
                else
                {
                    alert(res);
                }
            }

        }
    });

}

function ValidarConfirmacionContrasenna() {

    let contrasenna = $("#Contrasenna").val();
    let confirmarContrasenna = $("#ConfirmarContrasenna").val();

    if (contrasenna.trim() != "" && confirmarContrasenna.trim()) {
        if (contrasenna.trim() != confirmarContrasenna.trim()) {
            alert("Las contraseñas no coinciden");
            $("#ConfirmarContrasenna").val("");
        }
    }
}

