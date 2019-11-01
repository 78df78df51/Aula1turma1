$(document).ready(
    function () {

        $('input[name="cep"]').mask("00000-000");

        $('input[name="bntmostrar"]').click(
            function () {

                if ($('input[name="cep"]').val() == "") {
                    alert("Digita alguma coisa ai doidao");
                }
                else {

                    $.get("https://viacep.com.br/ws/" + $('input[name="cep"]').val() + "/json/", function (data, status) {
                        console.log(data);
                        if (data.erro == true)
                            alert("CEP inválido");
                        else {
                            $('input[name="cep"]').val(data.cep);
                            $('input[name="logradouro"]').val(data.logradouro);
                            $('input[name="localidade"]').val(data.localidade);
                            $('input[name="bairro"]').val(data.bairro);
                            $('input[name="uf"]').val(data.uf);
                            $('input[name="ibge"]').val(data.ibge);
                        }
                    })
                }

            });
			
    });


$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntmostrar"]').click();
    }
});

