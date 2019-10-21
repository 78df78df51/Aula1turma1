/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MyBike = { nome: "Felipe", Idade: 19,cor:"amarelo", raca: "bbvvv" };


$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomeusuario"]').val(MyBike.nome);
        

        $('input[name="bntsalvar"]').click(function () {
            MyBike.raca = $('input[name="raca"]').val();
            MyBike.Idade = $('input[name="Idade"]').val();
            MyBike.Cor = $('input[name="cor"]').val();
            MyBike.nome = $('input[name="nome"]').val();
        });
        $('input[name="bntmostrar"]').click(function () {
            alert(MyBike.nome + " " + MyBike.raca + " " + MyBike.Idade + " " + MyBike.cor);
          
        });


    }
);
  
$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});