
$(document).ready(function () {
    $("#RealTxt").mask('#.##0,00', { reverse: true });
});


$('input[type="button"]').click(function () {
    
    var real = $('input[name="real"]').val();
    
    var resultado = (real * 4.18);
    $('input[name="dolar"]').val(resultado);


})