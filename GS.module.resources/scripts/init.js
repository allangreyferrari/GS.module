//var wsnode = 'http://localhost:50795/contract/'
var wsnode = 'http://localhost/moduleservices/contract/';
var pgnode = '/';
var sysname = 'HelpDesk';

function appendScriptChild(url)
{
	$("#headerpages").empty()
	$("#headerpages").append('<script src=\"' + rootInit + url + '\" type="text/javascript"><\/script>');
}

function showSuccess(message) {
    setTimeout(function () {
        toastr.options = {
            closeButton: true,
            progressBar: true,
            showMethod: 'slideDown',
            positionClass: 'toast-top-center',
            timeOut: 4000
        };
        toastr.success(message, sysname);

    }, 300);
}

function showError(message) {
    setTimeout(function () {
        toastr.options = {
            closeButton: true,
            progressBar: true,
            showMethod: 'slideDown',
            positionClass: 'toast-top-center',
            timeOut: 4000
        };
        toastr.error(message, sysname);

    }, 300);
}

function showWarning(message) {
    setTimeout(function () {
        toastr.options = {
            closeButton: true,
            progressBar: true,
            showMethod: 'slideDown',
            positionClass: 'toast-top-center',
            timeOut: 4000
        };
        toastr.warning(message, sysname);

    }, 300);
}

function showSuccessRight(message) {
    setTimeout(function () {
        toastr.options = {
            closeButton: true,
            progressBar: true,
            showMethod: 'slideDown',
            positionClass: 'toast-top-right',
            timeOut: 4000
        };
        toastr.success(message, sysname);

    }, 300);
}