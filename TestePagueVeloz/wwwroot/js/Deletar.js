
function deletar(href) {
    $("#dialog-confirm").dialog({
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        buttons: {
            "Delete all items": function () {
                window.location.href = href
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    })
}