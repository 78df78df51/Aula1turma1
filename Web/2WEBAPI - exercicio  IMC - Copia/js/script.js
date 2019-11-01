$(document).ready(function () {
    //$('input[name="altura"]').mask('0.00');
    $('input[name="btnCalcular"]').click(function () {
        var nomeUsuario = $('input[name="nome"]').val();
        var peso = $('input[name="peso"]').val();
        var altura = $('input[name="altura"]').val();

        $.get("http://localhost:53404/api/default?nomeUsuario=" + nomeUsuario + "&peso=" + peso + "&altura=" + altura,
            function (data) {
                alert(data);
            });
    });
});

