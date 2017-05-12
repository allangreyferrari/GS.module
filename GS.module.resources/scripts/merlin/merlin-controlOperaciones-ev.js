$(document).ready(function () {
    $("#filtrofinicio").mask("99/99/9999", { placeholder: 'DD/MM/YYYY' });
    $("#filtroffinal").mask("99/99/9999", { placeholder: 'DD/MM/YYYY' });
    ListarEmpresas();
    ObtieneRangoBusquedaAprobacion();
    ListarEstado1erAprob();
    ListarEstado2daAprob();

    var dropdownRecursoModal;
    dropdownRecursoModal = $("#filtro1erAprob").data("kendoDropDownList");
    dropdownRecursoModal.bind("filtering", ListarEstado1erAprob_filtering);
    dropdownRecursoModal.value("1");

    dropdownRecursoModal = $("#filtro2daAprob").data("kendoDropDownList");
    dropdownRecursoModal.bind("filtering", ListarEstado2daAprob_filtering);
    dropdownRecursoModal.value("0");

    ListarOperaciones();

});


function ListarEstado1erAprob_filtering(e) {
    var filter = e.filter;
}

function ListarEstado2daAprob_filtering(e) {
    var filter = e.filter;
}

function ListarEmpresas() {
    $("#filtroEmpresa").kendoDropDownList({
        filter: "contains",
        dataTextField: "v02",
        dataValueField: "v01",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsMaster.svc/ListarEmpresas",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: false,
                        processData: false,
                        cache: false,
                        success: function (response) {
                            options.success(response.Rows);
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

function ObtieneRangoBusquedaAprobacion() {
    $.ajax({
        type: "GET",
        url: wsnode + "wsMaster.svc/ObtieneRangoBusquedaAprobacion",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            $("#filtrofinicio").val(response[0]);
            $("#filtroffinal").val(response[1]);
        },
        error: function (response) {
            showError(response);
        }

    });
}

function ListarEstado1erAprob() {
    $("#filtro1erAprob").kendoDropDownList({
        filter: "contains",
        dataTextField: "v02",
        dataValueField: "v01",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsMaster.svc/ListarEstados",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: false,
                        processData: false,
                        cache: false,
                        success: function (response) {
                            options.success(response.Rows);
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

function ListarEstado2daAprob() {
    $("#filtro2daAprob").kendoDropDownList({
        filter: "contains",
        dataTextField: "v02",
        dataValueField: "v01",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsMaster.svc/ListarEstados",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: false,
                        processData: false,
                        cache: false,
                        success: function (response) {
                            options.success(response.Rows);
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



function ListarOperaciones() {
    var params = JSON.stringify({ 
    "bd": $("#filtroEmpresa").val(), 
	"orden": $("#filtroOp").val(), 
	"fechaini": $("#filtrofinicio").val(), 
	"fechafin": $("#filtroffinal").val(),
	"check1" : $("#filtro1erAprob").val(), 
	"check2" : $("#filtro2daAprob").val() 
    });
	
    $("#gridpadre").kendoGrid({
        dataSource: {
        type: "json",
        transport: {
            read: function (options) {
                $.ajax({
                    type: "POST",
                    url: wsnode + "wsMaster.svc/ListarOperacionesTesoreriaEV",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: params,
                    async: false,
                    processData: false,
                    cache: false,
                    success: function (response) {
                        options.success(response.Rows);
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });
            },
            pageSize: 20
        }
    },

        rowTemplate:
            "<tr>" +
            "<td>" +
            "<div class='container-fluid font-gs' style='overflow-y: scroll;'>" +
            "<div class='row-fluid'>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>OP: </b>#: v01 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>AGENDA: </b>#: v02 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>MONTO: </b>#: v05 # (#: v04 #)</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>1° APROBACION: </b>#: v07 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>FECHA: </b>#: v08 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none' style=\"#: v10 #;border-radius:4px;max-width: 286px;\">" +
            "<center><b> #: v09 # </b></center>" +
            "</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-8 pad-none'><b>CONCEPTO: </b>#:v03 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'>" +
            "<div class=\"home-buttom\" style='max-width: 286px;#: v15 #' onclick=\"AprobarOperacionId('#: v11 #','#: v12 #');return false;\">" +
            "    <center><i class=\"fa fa-check\">&nbsp;</i> Aprobar</center>" +
            "</div>" +
            "</div>" +
            "</div>" +
            "</div>" +
            "</td>" +
            "</tr>",
        altRowTemplate:
            "<tr>" +
            "<td>" +
            "<div class='container-fluid font-gs' style='overflow-y: scroll;'>" +
            "<div class='row-fluid'>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>OP: </b>#: v01 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>AGENDA: </b>#: v02 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>MONTO: </b>#: v05 # (#: v04 #)</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>1° APROBACION: </b>#: v07 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'><b>FECHA: </b>#: v08 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none' style=\"#: v10 #;border-radius:4px;max-width: 286px;\">" +
            "<center><b> #: v09 # </b></center>" +
            "</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-8 pad-none'><b>CONCEPTO: </b>#:v03 #</div>" +
            "<div class='col-xs-12 col-sm-6 col-md-4 pad-none'>" +
            "<div class=\"home-buttom\" style='max-width: 286px;#: v15 #' onclick=\"AprobarOperacionId('#: v11 #','#: v12 #');return false;\">" +
            "    <center><i class=\"fa fa-check\" >&nbsp;</i> Aprobar</center>" +
            "</div>"+
            "</div>" +
            "</div>" +
            "</div>" +
            "</td>" +
            "</tr>",
        height: 400,    
        groupable: false,
        sortable: true,
        selectable: true,
        resizable: true,
        pageable: {
            refresh: true,
            pageSizes: true,
            buttonCount: 5
        },
        columns:  [ 
            { 
                field: "v06", 
                title: "Area",
                hidden: true 
            }
        ]
    });
    var grid = $('#gridpadre').data('kendoGrid');
    grid.dataSource.pageSize(10);
    grid.dataSource.page(1); 
    grid.dataSource.group({
        field: "v06", title: "Area",
    });
    grid.dataSource.read();
}

function AprobarOperacionId(Op, Db)
{
    $('#confirmaraprobarModal').modal("show");
    var params = JSON.stringify({ 
    "bd": Db, 
	"orden": Op, 
	"fechaini": "", 
	"fechafin": "",
	"check1" : -1, 
	"check2" : -1
    });
    $.ajax({
        type: "POST",
        url: wsnode + "wsMaster.svc/ListarOperacionesTesoreriaEV",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: false,
        processData: false,
        cache: false,
        success: function (data) {
            if(data.Rows.length>0)
            {
                $('#inPopupOp').html(data.Rows[0].v01);
                $('#inPopupArea').val(data.Rows[0].v06);
                $('#inPopupMonto').val(data.Rows[0].v05+ " ("+data.Rows[0].v04+")");
                $('#inPopupConcepto').val(data.Rows[0].v03);
                $('#inPopupOp').val(data.Rows[0].v13);
                $('#inPopupBd').val(data.Rows[0].v12);
            }
            else
                showWarning("No se pudo recuperar la Op");
        },
        error: function (response) {
            showSuccess(response)
        }
    });
}

function ConfirmarOperacionId()
{
    /*showSuccess($('#inPopupBd').val() + " - " + $('#inPopupOp').val());*/
    var params = JSON.stringify({ 
	"Op": $('#inPopupOp').val(), 
	"Bd": $('#inPopupBd').val(),
    "Clave": $('#inPopupKey').val()
    });
    $.ajax({
        type: "POST",
        url: wsnode + "wsMaster.svc/AprobarOperacionesTesoreria",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: false,
        processData: false,
        cache: false,
        success: function (data) {
            $('#jquerypages').append(data);    
        },
        error: function (response) {
            showError("Ocurrio el siguiente error:" + response)
        }
    });
}