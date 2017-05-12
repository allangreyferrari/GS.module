$(document).ready(function () {
    getPaisDestino();
});

function getPaisDestino() {
    $("#pais_destino").kendoDropDownList({
        filter: "contains",
        dataTextField: "Nombre",
        dataValueField: "Codigo",
        width: '350px',
        value: "",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "Helpdesk.svc/GetPais",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: false,
                        processData: false,
                        cache: false,
                        success: function (response) {
                            options.success(response.rows);
                            if (response.messageType != "OK")
                                showError(response.message);
                        },
                        error: function (response) {
                            showError(response);
                        }

                    });
                }
            }
        }
    });
}