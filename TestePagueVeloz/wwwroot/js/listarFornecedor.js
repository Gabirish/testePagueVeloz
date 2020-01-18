$(document).ready(function () {
    iniciar();
});


function iniciar() {
    Filtrar("#filtroCpfCnpj", "#cpfOuCnpj");
    Filtrar("#filtroFornecedor", "#fornecedor");
    Filtrar("#filtroDataDeCadastro", "#dataDeCadastro");

    $("tbody").on("click", function (evt) {
        if ($(evt.target)[0].nodeName != "BUTTON") {
            var id = $(evt.target).closest("tr").find("#idFornecedor").text();
            BuscarFornecedor(id);
        }
    });

    function BuscarFornecedor(id) {
        $.ajax({
            url: `/BuscarFornecedor/${id}`,
            type: 'GET',
            success: function (fornececdor) {
                console.log(fornececdor);
                MostrarModal(fornececdor);
            }
        });
    }


    function MostrarModal(fornececdor) {
        var dataDeNascimento = "";
        try {
            dataDeNascimento = fornececdor.dataDeNascimento.split("T")[0].split("-");
        } catch
        {
            dataDeNascimento = null;
        }


        $("#nomeFornecedor").val(fornececdor.nome);
        $("#idCpfOuCnpj").val(fornececdor.cnpjOuCpf);
        if (dataDeNascimento) {
            $("#last-start-date").val(`${dataDeNascimento[0]}-${dataDeNascimento[1]}-${dataDeNascimento[2]}`);
        }

        if (fornececdor.empresaId) {
            $("#empresaDropDown").val(fornececdor.empresaId);
        }
        $("#rg").val(fornececdor.rg);
        $("#telefone").val(fornececdor.telefone);

        IniciarFiltros();

        $("#dialog-viewAndEdit").dialog({
            resizable: false,
            height: "auto",
            width: 800,
            modal: true,
            buttons: {
                "Salvar Alterações": function () {
                    Enviar(fornececdor.fornecedorId);
                },
                Voltar: function () {
                    $(this).dialog("close");
                }
            }
        })
    }

    function Enviar(fornecedorId) {
        var fornecedor =
        {
            FornecedorId: fornecedorId ,
            Nome :  $("#nomeFornecedor").val(),
            CnpjOuCpf : $("#idCpfOuCnpj").val(),
            Rg : $("#RG").val(),
            DataDeNascimento : $("#last-start-date").val(),
            Telefone: $("#telefone").val(),
            EmpresaId: $("#empresaDropDown").val()
        };
        console.log(fornecedor);

        $.ajax({
            type: "POST",
            url: "/AtualizarFornecedor",
            data: fornecedor,
            success: () => { window.location.reload(); },
            error: () => { alert("houve um erro na requisição ou dados estavam incorretos. Por favor, tente novamente mais tarde"); }
        });

    }

    function IniciarFiltros() {
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
        });

        $('#telefone').mask('(00) 00000-0000')

        if ($('.cpfOuCnpj').val().length == 14) {
            $(".campoPessoaFisica").show();
        }
    }
}

