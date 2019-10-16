$(document).ready(
    function () {
        atualizaData();
    }
);
/*Criamos nossa primeira função*/
function atualizaData() {
    /*adicionamos a função dentro da nossa context do setInterval*/
    setInterval(function () { $('span[name="data_atual"]').text(Date());}, 100);
}