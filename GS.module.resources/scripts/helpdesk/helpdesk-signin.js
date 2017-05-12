$(document).ready(function () {
	resizeHTML();
	if (navigator.userAgent.search("Firefox")>-1){
		$("#logo-gs").attr('src','https://intranet.gruposilvestre.com.pe/resources/images/logo-grupo-silvestre-b.png');
	}
	
	$("#btnEntry").click(function() {
		var Usuario = $("#inUser").val();
		var Contrasenna = $("#inContrasenna").val();
		var isValid = true;
		if (isValid) {
			$.ajax({
				type: "POST",
				contentType: 'application/json; charset=utf-8',
				url: wsnode + "wsSecurity.svc/UserValidate",
				dataType: "json",
				data: JSON.stringify({ "alias": Usuario, "clave": Contrasenna }),
				async: false,
				processData: false,
				cache: false,
				success: function (response) {
					$("#outMessage").append(response);
					
				},
				error: function (response) {
					showError(response);
					return false;
				}
			})
		}		
	});
});

$(window).resize(function() {
	resizeHTML();
});



function resizeHTML()
{
	if(parseInt($(window).innerWidth())<990)
	{
		$("#sig-pannel").hide();
		$("#sig-items").hide();
		$("#sig-footer").hide();
	}
	else
	{
		$("#sig-pannel").show();
		$("#sig-items").show();
		$("#sig-footer").show();
	}
}