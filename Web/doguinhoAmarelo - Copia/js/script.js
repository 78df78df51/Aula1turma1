/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MyBikeMyBike = {marca:"Kaloi", valor:899, peso: "10 kg" };


$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomeusuario"]').val(MyBikeMyBike.marca);
        
        debugger
        $('input[name="bntsalvar"]').click(function () {
            MyBikeMyBike.marca = $('input[name="marca"]').val();
            MyBikeMyBike.valor = $('input[name="valor"]').val();
            MyBikeMyBike.peso = $('input[name="peso"]').val();
        });
        $('input[name="bntmostrar"]').click(function () {
            alert(MyBikeMyBike.marca + " " + MyBikeMyBike.valor + " " + MyBikeMyBike.peso);
          
        });


    }
);
  
$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});