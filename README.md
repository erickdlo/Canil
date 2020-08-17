# Canil 
## 1-Premissas assumidas:
Assume-se a premissa que serão somente três petshops cadastrados, não havendo gerenciamento de inclusão ou remoção, onde o valor de cada um deles relacionados com o dia da semana estará imputado no sistema.

## 2-Decisões de projeto:
Foi escolhido a linguagem C# com a estrutura de Destino .Net Core 2.1 para este projeto. Na camada de Controle foi utilizado o método Http Get para recuperar dados do sistema.

## 3-Instruções para executar o sistema:
Para executar a API deve-se passar a rota /canil/melhor-petshop? passando os parâmetros data (Data que deseja levar os caes para o banho),caesP (Numero de caes Pequenos) e caesG (Numero de caes Grandes), por exemplo. https://localhost:44313/canil/melhor-petshop?data=16/08/2020&caesP=3&caesG=3
