$(document).ready(function () {
    $("#filtroEstado").attr("src","../resources/images/check.png");
    $("#filtroboolEstado").val("true");
    ListarSistemas();
    ListarTipoNodo();
    ListarNodos();

    //Popup
    ListarPopupSistemas();
    ListarPopupTipoNodo();
    $('#PopupNodo').on('shown.bs.modal', function () {
        $(document).off('focusin.modal');
    });

});

function ListarSistemas() {
    var params = JSON.stringify({
	"oe":{
		 "id" : 0,
		 "nombre" : "",
		 "descripcion" : "",
		 "key" : "",
		 "estado" : "true"
		}
	});
    $("#filtroSistema").kendoDropDownList({
        filter: "contains",
        dataTextField: "nombre",
        dataValueField: "id",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsConfiguracion.svc/ListarSistemasCombo",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        data: params,
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

function ListarTipoNodo() {
    $("#filtroTipo").kendoDropDownList({
        filter: "contains",
        dataTextField: "v02",
        dataValueField: "v01",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsConfiguracion.svc/ListarTipoNodo",
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

function ListarPopupTipoNodo() {
    $("#PopupNodoTipo").kendoDropDownList({
        filter: "contains",
        dataTextField: "v02",
        dataValueField: "v01",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsConfiguracion.svc/ListarTipoNodo",
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

function ListarPopupSistemas() {
    var params = JSON.stringify({
	"oe":{
		 "id" : 0,
		 "nombre" : "",
		 "descripcion" : "",
		 "key" : "",
		 "estado" : "true"
		}
	});
    $("#PopupNodoSistema").kendoDropDownList({
        filter: "contains",
        dataTextField: "nombre",
        dataValueField: "id",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsConfiguracion.svc/ListarSistemas",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        data: params,
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


function ListarPopupTipoNodo_filtering(e) {
    var filter = e.filter;
}


function ListarPopupSistemas_filtering(e) {
    var filter = e.filter;
}


function CambiarEstado()
{    
    if($("#PopupNodoboolEstado").val() == "true")
    {
        $("#PopupNodoEstado").attr("src","../resources/images/uncheck.png");
        $("#PopupNodoboolEstado").val("false");
    }
    else
    {
        $("#PopupNodoEstado").attr("src","../resources/images/check.png");
        $("#PopupNodoboolEstado").val("true");
    }
}

function CambiarFiltroEstado()
{    
    if($("#filtroboolEstado").val() == "true")
    {
        $("#filtroEstado").attr("src","../resources/images/uncheck.png");
        $("#filtroboolEstado").val("false");
    }
    else
    {
        $("#filtroEstado").attr("src","../resources/images/check.png");
        $("#filtroboolEstado").val("true");
    }
}

function EditarNodo(id)
{
    var params = JSON.stringify({
	"oe":{
		 "id" : id,
		 "nombre" : "",
		 "descripcion" : "",
		 "key" : "",
		 "estado" : false
		}
	});

    $.ajax({
        type: "POST",
        url: wsnode + "wsConfiguracion.svc/ListarNodos",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: false,
        processData: false,
        cache: false,
        success: function (response) {            
            $("#PopupNodoHeader").html("<i class=\"fa fa-pencil\">&nbsp;</i> Editar Nodo");    
            $("#PopupNodoId").val(response.Rows[0].id);
            $("#PopupNodoNombre").val(response.Rows[0].nombre);
            $("#PopupNodoDescripcion").val(response.Rows[0].descripcion);
            $("#PopupNodoValor").val(response.Rows[0].valor);
            $("#PopupNodoEstado").attr("src",response.Rows[0].icono_estado);
            $("#PopupNodoboolEstado").val(response.Rows[0].estado);

            var dropdownRecursoModal;
            dropdownRecursoModal = $("#PopupNodoTipo").data("kendoDropDownList");
            dropdownRecursoModal.bind("filtering", ListarPopupTipoNodo_filtering);
            dropdownRecursoModal.value(response.Rows[0].tipo);

            dropdownRecursoModal = $("#PopupNodoSistema").data("kendoDropDownList");
            dropdownRecursoModal.bind("filtering", ListarPopupSistemas_filtering);
            dropdownRecursoModal.value(response.Rows[0].idsistema);
            dropdownRecursoModal.enable(false); 

            $("#PopupNodo").modal("show");  
        },
        error: function (response) {
        }
    });
}

function GuardarNodo()
{
    var params = JSON.stringify({
	"oe":{
		 "id" : $("#PopupNodoId").val(),
         "idsistema" : $("#PopupNodoSistema").val(),
		 "nombre" : $("#PopupNodoNombre").val(),
		 "descripcion" : $("#PopupNodoDescripcion").val(),
         "tipo" : $("#PopupNodoTipo").val(),
		 "valor" : $("#PopupNodoValor").val(),
		 "estado" : $("#PopupNodoboolEstado").val()
		}
	});
    //console.log(params);    
    var method = $("#PopupNodoId").val()=="0" ? "InsertarNodo" : "EditarNodo";
    $.ajax({
        type: "POST",
        url: wsnode + "wsConfiguracion.svc/" + method,
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
            $("#PopupNodo").modal("hide");  
            ListarNodos();
        },
        error: function (transaction) {
        }
    });
}

function RegistrarNodo()
{
    if($("#filtroSistema").val()==0)
    {
        showError("Ud. debe seleccionar un sistema para registrar un Nodo");
        var dropdownlist = $("#filtroSistema").data("kendoDropDownList");
        dropdownlist.open();
        dropdownlist.focus();
        //$("#filtroSistema").focus();
        return;
    }
    var dropdownRecursoModal = $("#PopupNodoSistema").data("kendoDropDownList");
    dropdownRecursoModal.bind("filtering", ListarPopupSistemas_filtering);
    dropdownRecursoModal.value($("#filtroSistema").val());
    $("#PopupNodoHeader").html("<i class=\"fa fa-plus\">&nbsp;</i> Registrar Nodo");    
    $("#PopupNodoId").val("0");
    $("#PopupNodoNombre").val("");
    $("#PopupNodoDescripcion").val("");
    $("#PopupNodoValor").val("");
    $("#PopupNodoEstado").attr("src","../resources/images/uncheck.png");
    $("#PopupNodoboolEstado").val("false");
    dropdownRecursoModal.enable(false); 
    $("#PopupNodo").modal("show");      
}

function ListarNodos() {
    var params = JSON.stringify({
	"oe":{
		 "id" : 0,
         "idsistema" :  $("#filtroSistema").val(),
		 "nombre" : $("#filtroNombre").val(),
		 "tipo" : $("#filtroTipo").val(),
		 "estado" : $("#filtroboolEstado").val()
		}
	});
	
    $("#gridpadre").kendoGrid({
        dataSource: {
        type: "json",
        transport: {
            read: function (options) {
                $.ajax({
                    type: "POST",
                    url: wsnode + "wsConfiguracion.svc/ListarNodos",
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
                    }
                });
            },
            pageSize: 20
        }
    }
        ,
        height: 340,    
        groupable: false,
        sortable: true,
        selectable: true,
        resizable: true,
        pageable: {
            refresh: true,
            pageSizes: true,
            buttonCount: 5
        },
        columns: [
        {
            field: "id",
            title: "Código",
            hidden: true
        },
        {
            template:
            "<div class=\"home-buttom\" onclick=\"EditarNodo('#: id #'); return false;\">"+
                "<center><i class=\"fa fa-pencil\">&nbsp;</i></center>"+
            "</div>",
            field: "icono_estado",
            title: " ",
            width: 70
        }, 
        {
            field: "nombre",
            title: "Nombre",
            width: 180
        }, {
            field: "descripcion",
            title: "Descripcion",
            width: 300
        },
        {
            field: "tipo_descripcion",
            title: "Tipo",
            width: 100
        }, 
        {
            template: "<center><input type=\"image\" src=\"#: icono_estado #\" style=\"width:17px\" /></center>",
            field: "icono_estado",
            title: "Activo",
            width: 70
        }
		]
    });
    var grid = $('#gridpadre').data('kendoGrid');
    grid.dataSource.pageSize(10);
    grid.dataSource.page(1); 
    grid.dataSource.read();
}