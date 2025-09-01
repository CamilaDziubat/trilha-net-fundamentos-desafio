# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## # 🚗 Sistema de Estacionamento em .NET 6

Este é um projeto de console desenvolvido em C# com .NET 6 que simula um **sistema de estacionamento**. Ele permite:

- Cadastrar veículos que estão sendo estacionados.
- Remover veículos e calcular o valor a ser pago.
- Listar todos os veículos atualmente estacionados.

O projeto foi desenvolvido como parte de um desafio de fundamentos em .NET da Trilha DIO.

---

## 🛠️ Tecnologias Utilizadas

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- C#
- Console App

---

## 📁 Estrutura do Projeto

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
```bash
trilha-net-fundamentos-desafio/
│
├── DesafioFundamentos.csproj         ← Arquivo do projeto (.NET 6)
├── Program.cs                        ← Ponto de entrada (Main)
└── Models/
    └── Estacionamento.cs             ← Lógica principal do estacionamento
````

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---

## ▶️ Como Executar o Projeto

1. Certifique-se de ter o **.NET 6 SDK instalado**.  
   Verifique com o comando:

   ```bash
   dotnet --version
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Clone ou baixe este repositório.

No terminal, navegue até a pasta onde está o arquivo .csproj:

cd trilha-net-fundamentos-desafio


Execute o projeto com:

dotnet run

## 📌 Funcionalidades
## 1. Cadastrar Veículo

O usuário informa a placa do veículo.

O veículo é adicionado à lista de veículos estacionados.

## 2. Remover Veículo

O usuário informa a placa e a quantidade de horas que o veículo ficou estacionado.

O sistema calcula o valor total com base nos preços informados no início do programa.

O veículo é removido da lista.

## 3. Listar Veículos

Exibe todos os veículos atualmente estacionados no sistema.

## 4. Encerrar

Finaliza a execução do programa.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 📷 Exemplo de Uso
<img width="555" height="336" alt="image" src="https://github.com/user-attachments/assets/033fe126-d01c-42e4-a17d-454d397b5189" />





