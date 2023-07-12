
# Screen Sound

Este é um programa em C# para registrar e avaliar bandas de música.



## Funcionalidades

    1. Registrar uma banda.
    2. Mostrar todas as bandas registradas.
    3. Avaliar uma banda.
    4. Exibir a média de uma banda.
    5. Sair do programa.

## Uso
Ao iniciar o programa, será exibido um menu com as opções disponíveis. Você pode escolher uma opção digitando o número correspondente e pressionando *Enter*.

    1. Registrar uma banda
    Essa opção permite registrar uma nova banda. Será solicitado que você digite o nome da banda que deseja registrar. Após digitar o nome da banda, ela será adicionada à lista de bandas registradas.

    2. Mostrar todas as bandas registradas
    Essa opção exibe a lista de todas as bandas registradas. Se não houver nenhuma banda registrada, será exibida uma mensagem informando que nenhuma banda foi registrada. Caso contrário, todas as bandas serão mostradas na tela.

    3. Avaliar uma banda
    Essa opção permite avaliar uma banda existente. Será solicitado que você digite o nome da banda que deseja avaliar. Se a banda estiver registrada, você poderá atribuir uma nota a ela. A nota será adicionada à lista de notas da banda.

    4. Exibir a média de uma banda
    Essa opção exibe a média das notas atribuídas a uma banda específica. Será solicitado que você digite o nome da banda que deseja verificar a média. Se a banda estiver registrada e tiver notas atribuídas, a média será calculada e exibida na tela.

    5. Sair do programa
    Essa opção encerra a execução do programa.

## Logo

Ao iniciar o programa, será exibido o logo do "Screen Sound", seguido de uma mensagem de boas-vindas.




```
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
```
Boas vindas ao Screen Sound


## Observações

* O programa utiliza um dicionário chamado `bandasRegistradas` para armazenar as bandas e suas respectivas notas. Cada banda é representada por uma chave (nome da banda) e possui uma lista de notas.

* O código contém comentários explicativos para facilitar a compreensão.
A função `ExibirLogo()` é responsável por exibir o logo e a mensagem de boas-vindas na tela.

* A função `ExibirOpcoesDoMenu()` exibe o menu principal e realiza o redirecionamento de acordo com a opção escolhida pelo usuário.

* A função `ExibirTituloDaOpcao(string titulo)` é utilizada para exibir um título com asteriscos acima e abaixo.

Obs: Alguns trechos do código estão comentados e podem ser habilitados se necessário, como no caso da função `MostrarBandasRegistradas()`.
