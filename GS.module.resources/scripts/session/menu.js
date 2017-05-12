$(document).ready(function () {
    //Showmodal(true);
    $("#hreflogo").append('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
    $.ajax({
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        url: wsnode + "wsSecurity.svc/GetOptions",
        data: null,
        cache: false,
        success: function (data) {
            $("#ul-options").append(data);
            //Showmodal(false);
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
    return false;
});

function OpenPage(namepage) {
    //Showmodal(true);
    $("#pages").load(namepage);
}

function ClosedSession() {
    //Showmodal(true);
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
            //Showmodal(false);
        },
        error: function (response) {
            /*
            $("#outMessage").removeClass("hide");
            $("#outMessage").html(response);
            */
            //Showmodal(false);

        }
    })
}
