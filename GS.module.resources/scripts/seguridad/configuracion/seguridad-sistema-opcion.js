$(document).ready(function () {
    $("#filtroEstado").attr("src","../../../moduleresources/images/check.png");
    $("#filtroboolEstado").val("true");

    CrearCombo($("#PopupOpcionNivel"), "v02", "v01", "contains", '100%',
        JSON.stringify({ "key": "ZsH4bynJgWs=", "parametros": [1], "cryp": [] }), null);

    CrearCombo($("#PopupOpcionFormaMostrar"), "v02", "v01", "contains", '100%',
        JSON.stringify({ "key": "ZsH4bynJgWs=", "parametros": [2], "cryp": [] }), null);

    var OnSelectTipoImagen = function onSelect(e) {
        if (e.item) {
            var dataItem = this.dataItem(e.item);
            $("#PopupOpcionContentImagen").empty();
            EvaluarContenedorImagen(dataItem.v01);
        }
        else {
            showError("No se obtuvo los datos de la selección");
        }
    }

    CrearCombo($("#PopupOpcionTipoImagen"), "v02", "v01", "contains", '100%',
        JSON.stringify({ "key": "ZsH4bynJgWs=", "parametros": [3], "cryp": [] }), OnSelectTipoImagen);

    $("#PopupOpcionImagen").kendoUpload();
    $("#PopupOpcionIndice").mask('999');

    $('#PopupOpcion').on('shown.bs.modal', function () {
        $(document).off('focusin.modal');
    });

    ListarOpciones(argument);
});


function EvaluarContenedorImagen(data)
{
    $("#PopupOpcionContentImagen").empty();
    switch (data) {
        case "1":
            $("#PopupOpcionContentImagen").append(
                "<span class=\"input-group-addon\" style=\"width:120px\">Imagen</span><input type=\"text\" id=\"PopupOpcionImagen\" class=\"form-control\" />"
            )
            break;
        case "2":
            $("#PopupOpcionContentImagen").append(
                "<span class=\"input-group-addon\" style=\"width:120px\">Imagen 2</span><input type=\"text\" id=\"PopupOpcionImagen\" class=\"form-control\" />"
            )
            break;
        case "3":
            $("#PopupOpcionContentImagen").append(
                "<span class=\"input-group-addon\" style=\"width:120px\">Imagen 3</span><input type=\"text\" id=\"PopupOpcionImagen\" class=\"form-control\" />"
            )
            break;
        default:
            $("#PopupOpcionContentImagen").append(
                "<span class=\"input-group-addon\" style=\"width:120px\">Imagen 4</span><input type=\"text\" id=\"PopupOpcionImagen\" class=\"form-control\" />"
            )
            showError("Esta opción no tiene especificación");
    }
}

function CambiarEstado()
{    
    if($("#PopupSistemaboolEstado").val() == "true")
    {
        $("#PopupSistemaEstado").attr("src", "../../../moduleresources/images/uncheck.png");
        $("#PopupSistemaboolEstado").val("false");
    }
    else
    {
        $("#PopupSistemaEstado").attr("src", "../../../moduleresources/images/check.png");
        $("#PopupSistemaboolEstado").val("true");
    }
}

function CambiarFiltroEstado()
{    
    if($("#filtroboolEstado").val() == "true")
    {
        $("#filtroEstado").attr("src", "../../../moduleresources/images/uncheck.png");
        $("#filtroboolEstado").val("false");
    }
    else
    {
        $("#filtroEstado").attr("src", "../../../moduleresources/images/check.png");
        $("#filtroboolEstado").val("true");
    }
}

function EditarOpcion(id)
{
    var params = JSON.stringify({
        "key": "PIV8o1/cmq0=",
        "parametros":
            [
                id,
                "",
                "",
                0,
                localStorage.getItem('session')
            ],
        "cryp": []
    });

    $.ajax({
        type: "POST",
        url: wsnode + "wsCommon.svc/ListarBasicTen",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: true,
        processData: true,
        cache: false,
        success: function (response) {
            if (response.Transaction.Type == 1)
                showError(response.Transaction.Message);
            if (response.NroRows = 0)
                showError("Ocurrio un error al interntar recuperar el registro");
       
            $("#PopupOpcionHeader").html("<i class=\"fa fa-pencil\">&nbsp;</i> Editar Opción");
            $("#PopupOpcionId").val(response.Rows[0].v01);
            $("#PopupOpcionNombre").val(response.Rows[0].v02);
            $("#PopupOpcionDescripcion").val(response.Rows[0].v03);
            $("#PopupOpcionKey").val(response.Rows[0].v05);
            $("#PopupOpcionPoolName").val(response.Rows[0].v07);
            $("#PopupOpcionFileconfig").val(response.Rows[0].v08);
            $("#PopupOpcionEstado").attr("src", response.Rows[0].v09);
            $("#PopupOpcionboolEstado").val(response.Rows[0].v06);
            $("#Password").prop("disabled", true);
            $("#").modal("show");
        },
        error: function (response) {
        }
    });
}

function GuardarOpcion()
{
    var params = JSON.stringify({
        "key": $("#PopupOpcionId").val() == "0" ? "KpJCdc9cdSs=" : "KpJCdc9cdSs=",
        "parametros":
            [
                0,
                $("#filtroNombre").val(),
                $("#filtroDescripcion").val(),
                0, //$("#filtroboolEstado").val() == "" ? 0 : parseInt($("#filtroboolEstado").val()),
                localStorage.getItem('session')
            ],
        "cryp": []
    });
    $.ajax({
        type: "POST",
        url: wsnode + "wsCommon.svc/ListarBasicTen",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: false,
        processData: false,
        cache: false,
        success: function (transaction) { 
            if(transaction.type==0)
                showSuccess(transaction.message);
            else
                showError(transaction.message);
            $("#PopupSistema").modal("hide");  
            ListarSistemas();
        },
        error: function (transaction) {
        }
    });
}

function RegistrarOpcion() {
    $("#PopupOpcionHeader").html(
        "<i class=\"fa fa-plus\">&nbsp;</i> Registrar Opción del Sistema" +
        "<i class=\"fa fa-check pull-right\" style=\"cursor:pointer;margin-right:25px\" onclick=\"GuardarOpcion(); return false;\" title=\"Grabar Opción del Sistema\">&nbsp;</i>"
        );
    $("#PopupOpcionId").val("0");
    $("#PopupOpcionNombre").val("");
    $("#PopupOpcionDescripcion").val("");
    $("#PopupOpcionRuta").val("");
    $("#PopupOpcionPadre").val("");
    $("#PopupOpcionNivel").val("");
    $("#PopupOpcionFormaMostrar").val("");
    //$("#PopupOpcionTipoImagen").val("");
    EvaluarContenedorImagen($("#PopupOpcionTipoImagen").val());
    $("#PopupOpcionImagen").val("");
    $("#PopupOpcionIndice").val("");    
    $("#PopupOpcionEstado").attr("src", "../../../moduleresources/images/uncheck.png");
    $("#PopupOpcionboolEstado").val("false");
    $("#PopupOpcion").modal("show");
}

function RegresarSistemas()
{
    $("#pages").load('configuracion/viewSistema.html');
}

function ListarOpciones(id) {
    
    var params = JSON.stringify({
        "key": "PIV8o1/cmq0=",
        "parametros":
            [
                0,
                $("#filtroNombre").val(),
                $("#filtroDescripcion").val(),
                0, //$("#filtroboolEstado").val() == "" ? 0 : parseInt($("#filtroboolEstado").val()),
                localStorage.getItem('session')
            ],
        "cryp": []
    });
    var dsgridpadre = new kendo.data.TreeListDataSource({
        transport: {
            read: function (options) {
                $.ajax({
                    type: "POST",
                    url: wsnode + "wsCommon.svc/ListarBasicTen",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: params,
                    async: true,
                    processData: true,
                    cache: false,
                    success: function (response) {
                        if (response.Transaction.Type == 1)
                            showError(response.Transaction.Message);
                        if (response.NroRows > 0)
                            dsgridpadre.pageSize(20);
                        options.success(response.Rows);
                    },
                    error: function (err) { }
                });
            }
        }
    });

    $("#gridpadre").kendoTreeList({
        dataSource: dsgridpadre,
        reorderable: true,
        resizable: true,
        groupable: false,
        sortable: false,
        selectable: true,
        resizable: true,
        height: '100%',
        /*
        pageable: {
            refresh: true,
            pageSizes: [10, 20, 'All'],
            buttonCount: 5
        },*/
        columns: [
        {
            template:
                "<div title='Editar Sistema' style='cursor:pointer'><center><i class=\"fa fa-pencil\" onclick=\"EditarSistema('#: v01 #'); return false;\">&nbsp;</i></center></div>",
            title: " ",
            width: 50
        },
        {
            field: "v01",
            title: "Código",
            expandable: true,
            width: 60
        },
        {
            field: "v02",
            title: "Nombre",
            width: 180
        },
        {
            field: "v03",
            title: "Descripcion",
            width: 300
        },
        {
            field: "v05",
            title: "Key",
            width: 120
        },
        {
            template: "<center><input type=\"image\" src=\"#: v09 #\" style=\"width:17px\" /></center>",
            field: "v09",
            title: "Activo",
            width: 70
        }
        ]
    });

}