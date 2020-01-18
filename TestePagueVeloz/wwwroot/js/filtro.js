function Filtrar(elemento, campo) {
    $(elemento).keyup(function () {
        let value = $(this).val()
        if (value.replace(/ /g, "").length > 0) {
            $("tbody tr").each(function () {
                if (!($(this).find(campo).text().includes(value))) {
                    $(this).hide();
                } else {
                    $(this).show();
                }
            });
        } else {
            $("tr").show();
        }
    })
}
