var MeuNomeDeVariavel;

$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                $.get("https://viacep.com.br/ws/89065050/json/", function (data, status) {
                    $('input[name="bairro"]').val(data.bairro);
                })
            });
});