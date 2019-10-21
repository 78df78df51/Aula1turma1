

/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuUsuario = { nome: "Felipe", idade: 189, raca:"Caramelo", corolaracao:"amarelo" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomedog"]').val(MeuUsuario.nome);
        $('input[name="idadedog"]').val   (MeuUsuario.idade);
        $('input[name="raca"]').val      (MeuUsuario.raca);
        $('input[name="cor"]').val        (MeuUsuario.corolaracao);




        $('input[name="bntsalvar"]').click(function () {
            MeuUsuario.nome = $('input[name="nomedog"]').val();
            MeuUsuario.idade =  $('input[name="idadedog"]').val ();
            MeuUsuario.raca =      $('input[name="raca"]').val ();
            MeuUsuario.corolaracao = $('input[name="cor"]').val();
            LimparTela();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(MeuUsuario.nome + "\r\n" + MeuUsuario.idade + "\r\n" + MeuUsuario.raca + "\r\n" + MeuUsuario.corolaracao);
        });

    }
);
  
$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});

function LimparTela() {
    var meusInputs = $('input[type="text"]');

    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }
}