/*Ao carregar nosso site por completo executa o conteúdo do $(document)*/
$(document).ready(
    function () {
        $('button[name="btn"]').click(function () {
            /*obtemos o valor digitado eo usuario*/
            var nomeusuario = $('input[name="nomeusuario"]').val();
           
            $('span[name="usuariotext"]').text(nomeusuario);
        });
    }
);
