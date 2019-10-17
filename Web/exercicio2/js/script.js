/*Ao carregar nosso site por completo executa o conteúdo do $(document)*/
$(document).ready(
    function () {
        $('input[name="btnconverter"]').click(function () {

            var valordolar = 4.16;
            var valoreal = $('input[name="valoreal"]').val()
                .replace(".", "")
                .replace(",", ".");

            var convercao = (valoreal / valordolar)
                .toFixed(2)
                .toString()
                .replace(/(\d)(\d{2})$/,"$1,$2");

            $('input[name="valordolar"]').val(convercao);
        });
        $('input[name="valoreal"]').mask("000.000,00");
    }
);