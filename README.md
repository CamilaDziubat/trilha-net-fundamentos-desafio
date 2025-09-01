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

## ✅ Resolução do Desafio

Este projeto foi desenvolvido como parte do desafio da Trilha de Fundamentos .NET da DIO, com o objetivo de aplicar na prática conceitos fundamentais de C# e .NET, como estrutura de classes, manipulação de listas, entrada e saída de dados no console e lógica de negócio.

## 🚗 Sistema de Estacionamento - .NET 6

Trata-se de uma aplicação de console que simula o funcionamento básico de um sistema de estacionamento rotativo, com funcionalidades para registrar, remover e listar veículos, além de calcular o valor a ser pago pelo tempo de permanência.

## 🧩 O que foi resolvido e implementado

Durante o desenvolvimento, foram implementadas as seguintes funcionalidades:

## 🔧 Funcionalidades Implementadas

## 1.Cadastrar Veículo

O usuário informa a placa do veículo.

O sistema adiciona o veículo à lista de veículos estacionados.

## 2.Remover Veículo

O usuário informa a placa e o tempo de permanência em horas.

O sistema calcula o valor total a ser pago com base no preço inicial e no preço por hora.

O veículo é removido da lista.

## 3.Listar Veículos

Exibe todas as placas dos veículos atualmente estacionados.

## 4.Encerrar Programa

Finaliza a execução do sistema.

## 💡 Regras de Negócio Atendidas

O sistema utiliza preço fixo inicial e valor por hora, definidos pelo usuário no início do programa.

O valor total é calculado com a fórmula:

Valor Total = Preço Inicial + (Preço por Hora × Quantidade de Horas)


O sistema impede que veículos não cadastrados sejam removidos, exibindo uma mensagem apropriada.

As placas são armazenadas e comparadas sem diferenciação entre maiúsculas e minúsculas.
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

```bash
dotnet run
````

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 📷 Exemplo de Uso
<img width="555" height="336" alt="image" src="https://github.com/user-attachments/assets/033fe126-d01c-42e4-a17d-454d397b5189" />





