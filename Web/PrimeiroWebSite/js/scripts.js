$(document).ready(
    function () {
        atualizaData();
    }
);
/*Criamos nossa primeira fun��o*/
function atualizaData() {
    /*adicionamos a fun��o dentro da nossa context do setInterval*/
    setInterval(function () { $('span[name="data_atual"]').text(Date());}, 100);
}