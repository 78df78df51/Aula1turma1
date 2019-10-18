/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuUsuario = { nome: "Felipe", Idade: 19, raca: "bbvvv" };


$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomeusuario"]').val(MeuUsuario.nome);


        $('input[name="bntsalvar"]').click(function () {
            MeuUsuario.raca = $('input[raca="Raça"]').val();
            MeuUsuario.Idade = $('input[Idade="Idade"]').val();
            MeuUsuario.nome = $('input[name="nome"]').val();
        });
        $('input[name="bntmostrar"]').click(function () {
            alert(MeuUsuario.nome + " " + MeuUsuario.raca + MeuUsuario.Idade);
          
        });


    }
);
  
$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});