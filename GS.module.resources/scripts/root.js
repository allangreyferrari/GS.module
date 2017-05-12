$(document).ready(function () {
    $.ajax({
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        url: wsnode + "wsSecurity.svc/UserValidate",
        dataType: "json",
        data: JSON.stringify({ "alias": "mtuestaa", "clave": "54321" }),
        async: false,
        processData: false,
        cache: false,
        success: function (response) {
            $("#hreflogo").append('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
            $.ajax({
                type: "GET",
                contentType: 'application/json; charset=utf-8',
                url: wsnode + "wsSecurity.svc/GetOptions",
                data: null,
                cache: false,
                success: function (data) {
                    $("#ul-options").append(data);
                }
            });

            $.ajax({
                type: "GET",
                contentType: 'application/json; charset=utf-8',
                url: wsnode + "wsSecurity.svc/GetSectionName",
                data: null,
                cache: false,
                success: function (data) {
                    $("#sectionname").append(data);
                }
            });

        },
        error: function (response) {
            showError(response);
            return false;
        }
    });
    OpenPage();
    return false;
    
});

function OpenPage() {
    var page = getUrlParameter('page');
    //showError(page);
    $("#pages").load("Content/Tesoreria/controlOperaciones"+page+".html");
}

function ClosedSession() {
    $.ajax({
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        url: wsnode + "wsSecurity.svc/ClosedSession",
        async: false,
        processData: false,
        cache: false,
        success: function (response) {
            if (response == true) {
                $(location).attr('href', 'login.html');
            }
            else {
                $("#outMessage").removeClass("hide");
                $("#outMessage").html(response);
            }
        },
        error: function (response) {
        }
    })
}

var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = decodeURIComponent(window.location.search.substring(1)),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};
