var rootInit = "http://localhost";
function apeendElement(type, url) {
    switch (type) {
        case "css":
            document.write('<link href=\"' + rootInit + url + '\" rel="stylesheet" type="text/css" />');
            break;
        case "ico":
            document.write('<link href=\"' + rootInit + url + '\" rel="icon" />');
            break;
        case "script":
            document.write('<script src=\"' + rootInit + url + '\" type="text/javascript"><\/script>');
            break;
        default:
            return;
    }
}
