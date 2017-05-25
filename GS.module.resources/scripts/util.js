function CrearCombo(InputControl, Text, Value, Filter, Width, Params, OnSelect)
{
    InputControl.kendoDropDownList({
        filter: Filter,
        dataTextField: Text,
        dataValueField: Value,
        width: Width,
        select: OnSelect,
        value: "",
        dataSource: {
            type: "json",
            transport: {
                read: function (options) {
                    $.ajax({
                        type: "POST",
                        url: wsnode + "wsCommon.svc/ListarBasicFive",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        data: Params,
                        async: true,
                        processData: true,
                        cache: false,
                        success: function (response) {
                            if (response.Transaction.Type == 1)
                                showError(response.Transaction.Message);
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
