$(document).ready(function () {
    $("#filtroEstado").attr("src","../resources/images/check.png");
    $("#filtroboolEstado").val("true");
    ListarSistemas();
});

function CambiarEstado()
{    
    if($("#PopupSistemaboolEstado").val() == "true")
    {
        $("#PopupSistemaEstado").attr("src","../resources/images/uncheck.png");
        $("#PopupSistemaboolEstado").val("false");
    }
    else
    {
        $("#PopupSistemaEstado").attr("src","../resources/images/check.png");
        $("#PopupSistemaboolEstado").val("true");
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

function EditarSistema(id)
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
        url: wsnode + "wsConfiguracion.svc/ListarSistemas",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: params,
        async: false,
        processData: false,
        cache: false,
        success: function (response) {            
            $("#PopupSistemaHeader").html("<i class=\"fa fa-pencil\">&nbsp;</i> Editar Sistema");    
            $("#PopupSistemaId").val(response.Rows[0].id);
            $("#PopupSistemaNombre").val(response.Rows[0].nombre);
            $("#PopupSistemaDescripcion").val(response.Rows[0].descripcion);
            $("#PopupSistemaKey").val(response.Rows[0].key);
            $("#PopupSistemaPassword").val(response.Rows[0].password);
            $("#PopupSistemaEncriptado").val(response.Rows[0].password_concatenado);                        
            $("#PopupSistemaEstado").attr("src",response.Rows[0].icono_estado);
            $("#PopupSistemaboolEstado").val(response.Rows[0].estado);
            $("#PopupSistemaEncriptado").prop("disabled", false);  
            $("#PopupSistema").modal("show");  
        },
        error: function (response) {
        }
    });
}

function GuardarSistema()
{
    var params = JSON.stringify({
	"oe":{
		 "id" : $("#PopupSistemaId").val(),
		 "nombre" : $("#PopupSistemaNombre").val(),
		 "descripcion" : $("#PopupSistemaDescripcion").val(),
		 "key" : $("#PopupSistemaKey").val(),
		 "estado" : $("#PopupSistemaboolEstado").val(),
         "password": $("#PopupSistemaPassword").val()
		}
	});
    //console.log(params);    
    var method = $("#PopupSistemaId").val()=="0" ? "InsertarSistema" : "EditarSistema";
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
            $("#PopupSistema").modal("hide");  
            ListarSistemas();
        },
        error: function (transaction) {
        }
    });
}

function RegistrarSistema()
{
    $("#PopupSistemaHeader").html("<i class=\"fa fa-plus\">&nbsp;</i> Registrar Sistema");    
    $("#PopupSistemaId").val("0");
    $("#PopupSistemaNombre").val("");
    $("#PopupSistemaDescripcion").val("");
    $("#PopupSistemaKey").val("");
    $("#PopupSistemaPassword").val("");
    $("#PopupSistemaEncriptado").val("");   
    $("#PopupSistemaEstado").attr("src","../resources/images/uncheck.png");
    $("#PopupSistemaboolEstado").val("false");
    $("#PopupSistemaEncriptado").prop("disabled", true);  
    $("#PopupSistema").modal("show");     
    

}

function ListarSistemas() {
    var params = JSON.stringify({
	"oe":{
		 "id" : 0,
		 "nombre" : $("#filtroNombre").val(),
		 "descripcion" : $("#filtroDescripcion").val(),
		 "key" : "",
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
            "<div class=\"home-buttom\" onclick=\"EditarSistema('#: id #'); return false;\">"+
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
            field: "key",
            title: "Key",
            width: 120
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