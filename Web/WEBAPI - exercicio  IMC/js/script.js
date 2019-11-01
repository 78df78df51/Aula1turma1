$(document).ready(function () {
    $('input[name="bntCalcular"]').click(
        function () {
            $('input[name="nome"]').val();
            $('input[name="peso"]').val();
            $('input[name="altura"]').val();
            
            $.get("http://localhost:64447/api/Calcular?nomeUsuario=" + $('input[name="nome"]').val() + "&peso=" +
                $('input[name="peso"]').val() + "&altura=" + $('input[name="altura"]').val(), function (data) {
               
                alert(data);
            });
        });
});

