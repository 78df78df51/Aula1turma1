using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a padronização dos modos de operação convencionais
 O empenho em analisar a constante divulgação das informações acarreta um processo de reformulação e modernização dos relacionamentos
verticais entre as hierarquiasNo entanto, não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento
dos níveis de motivação departamental A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas
apresenta tendências no sentido de aprovar a manutenção do sistema de participação geral.Do mesmo modo, o novo modelo estrutural
aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações
A prática cotidiana prova que o desenvolvimento contínuo de distintas formas de atuação assume importantes posições no estabelecimento
das direções preferenciais no sentido do progresso.Neste sentido, o início da atividade geral de formação de atitudes pode nos levar
a considerar a reestruturação do sistema de formação de quadros que corresponde às necessidades As experiências acumuladas demonstram
que a revolução dos costumes obstaculiza a apreciação da importância do orçamento setorial
Todas estas questões devidamente ponderadas levantam dúvidas sobre se o aumento do diálogo entre os diferentes setores produtivos nos
obriga à análise dos índices pretendidos Assim mesmo o acompanhamento das preferências de consumo oferece uma interessante oportunidade
para verificação do impacto na agilidade decisória Nunca é demais lembrar o peso e o significado destes problemas uma vez que o
desafiador cenário globalizado facilita a criação das formas de ação";

            var countFind = 0;

            Console.WriteLine("Encontre a palavra");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length -2); i++)
            {
                var palavraComparar = nome[i].ToString() +
                                      nome[i + 1].ToString() +
                                      nome[i + 2].ToString();

                if (palavra == palavraComparar)
                    countFind++;
             }

            Console.WriteLine($"Quantidade total de '{palavra}' {countFind}");
            Console.ReadKey();
        }
    }
 }
