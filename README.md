# Verificador de Número Primo (NumeroPrimo)

Aplicação desktop em **C# com Windows Forms** que recebe um número inteiro, verifica se ele é primo contando seus divisores e exibe o resultado em uma segunda janela (`Resultado`).

## Funcionalidades

- Valida a entrada do usuário com `int.TryParse`, evitando erros ao digitar letras ou deixar o campo vazio.
- Calcula a quantidade de divisores de `1` até o número informado.
- Identifica se o número possui exatamente 2 divisores (1 e ele mesmo) para determinar se é primo.
- Exibe a mensagem de resultado em um formulário separado (`Resultado`) por meio do método `Exibir(string texto)`.
- Mostra um `MessageBox` de aviso caso o valor inserido não seja um número inteiro válido.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Interface / Framework:** Windows Forms (`.NET`)
- **IDE:** Visual Studio

## Estrutura Principal

- `Form1.cs`: Captura o valor de `txtNumero`, executa a validação, calcula os divisores no clique de `btnCalcular` e abre a tela de resultado.
- `Resultado.cs`: Formulário secundário responsável por receber a mensagem e exibi-la em `lblResultado`.

## Como Executar

1. Clone ou baixe o repositório para a sua máquina.
2. Abra o arquivo da solução (`.sln`) no **Visual Studio**.
3. Certifique-se de que os controles `txtNumero`, `btnCalcular` e `lblResultado` estão devidamente configurados nos respectivos designers (`Form1` e `Resultado`).
4. Pressione **F5** ou clique em **Iniciar** para compilar e executar.

## Próximos Passos / Melhorias

- Revisar a regra de números decimais ("quebrados"), já que números primos são definidos no conjunto dos inteiros e `int.TryParse` aceita apenas inteiros.
- Tratar casos especiais como números negativos, `0` e `1` de forma explícita na documentação ou lógica.
- Otimizar o laço de verificação de divisores para números maiores conforme o projeto evolui.
