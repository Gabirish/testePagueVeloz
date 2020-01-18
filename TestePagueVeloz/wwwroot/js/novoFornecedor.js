$(document).ready(function () {
    iniciar();
});

function iniciar() {
    var options = {
        onKeyPress: function (cpf, ev, el, op) {
            var masks = ['000.000.000-000', '00.000.000/0000-00'];
            $('.cpfOuCnpj').mask((cpf.length > 14) ? masks[1] : masks[0], op);
        }
    }

    $('.cpfOuCnpj').length > 11 ? $('.cpfOuCnpj').mask('00.000.000/0000-00', options) : $('.cpfOuCnpj').mask('000.000.000-00#', options);

    $('.cpfOuCnpj').on("blur", function () {
        if ($(this).val().length == 14) {
            $(".campoPessoaFisica").show();
        } else if ($(this).val().length == 18) {
            $(".campoPessoaFisica").hide();
        } else if (($(this).val().length > 0)) {
            alert("CPF ou CNPJ invalido");
            $(this).val("");
        }
    })


    $('#telefone').mask('(00) 00000-0000')

    $('#empresaDropDown').on("change", function () {
        $('#empresaIdTextArea').val($('#empresaDropDown').val());
    })

    if ($('.cpfOuCnpj').val().length == 14) {
        $(".campoPessoaFisica").show();
    }
}
