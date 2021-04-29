# Desafio Shopping

## 💻 Sobre o projeto

Desafio Shopping é um software que tem o objetivo de processar informações de entrada de uma loja como estoque, desconto e ordem de compra e ao final do dia
gerar um arquivo com esse resumo.

Projeto desenvolvido durante **Processo seletivo Fade/Samsung**.

---

## ⚙️ Arquitetura de Software

### Abreviações

  MVC – Padrão de arquitetura de software onde M significa modelo sendo responsável pela parte de regras de negócio, V a visualização 
  responsável pela parte de interfaces e C a parte de controle dos dados. 

### Restrições da Arquitetura 

Existem algumas restrições de requisito e de sistema principais que têm uma relação significativa com a arquitetura, sendo elas: 

 1. Utilização do paradigma Orientado a Objetos para o desenvolvimento
 2. Boas práticas de codificação (princípios SOLID, DRY, clean code, etc)
 3. Estrutura MVC
 4. Linguagem de programação C#
 5. Framework Net (4.6.1) 
 6. Padrões de projeto
 7. Estrutura de dados e algoritmos de busca / desempenho

### Visão da Implementação

A aplicação irá rodar localmente na máquina o tamanho que a mesma poderá chegar e suportado tranquilamente 
quem qualquer computador hoje comercializado.O sistema será implementado utilizando conceitos de Programação Orientada a
Objetos através do framework .NET estrutura MVC E linguagem de Programação C#.

### Qualidade
O padrão de arquitetura adotado no projeto tem como finalidade garantir uma melhor
organização do código-fonte, uma manutenção de código tranquila.

---

## ⚙️ Funcionalidades

- [x] Leitura de arquivos "Lista de Produtos, Lista de Descontos, Lista Ordem Compra"
- [X] Geração de Fatura
- [x] Exportação da fatura para um arquivo .txt

---

## 🛠 Modelo dos arquivos 

Todos os arquivos precisam ser no formato de .txt

>	Produtos

```bash
# O layout do arquivo será sempre o mesmo conforme as descrições
#
# 1 -> Numero de Produtos
# Leite -> Nome do Produto
# 2 
# Farinha

```

>	Descontos

```bash
# O layout do arquivo será sempre o mesmo conforme as descrições
#
# 2 -> Numero de Descontos
# Leite -> Nome do Produto
# 2 -> Quantidade Itens Pedido
# 1-> Quantidade Itens Pagar
# 1 
# Biscoito 
# 2 
# 1

```

>	Ordem de Compra

```bash
# O Numero de items e descrição do produto vai ser repetido N vezes
#
# 2 -> Numero de Pedidos
# 1 -> ID do Pedido 
# 2 -> Número de items no pedido
# Leite-> Nome do produto 
# 2
# 3
# Farinha de trigo
# Leite
# Farinha de trigo

```

---
## 🚀 Como executar o projeto

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com). Além disto é bom ter um editor para trabalhar com o código como [Vs_Studio](https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Professional&rel=16)

#### 🎲 Rodando o sistema
##
##
##### Clone este repositório
$ git clone https://caiqueneves@bitbucket.org/caiqueneves/desafio-042021-caiqueneves.git

##### Abrindo o projeto

  1. Abrir o repositório do projeto "../desafio-042021-caiqueneves/Desafio.CaiqueNeves"
  2. Clique no arquivo Desafio.CaiqueNeves.sln - aguardar o projeto abrir no visual studio

##### Executando o projeto

Você tera duas opções para executar o projeto :

  1. Clicando no botão "start" na parte superior da IDE 
  2. Clicando na aba "Solution Explorer" depois clica no projeto e botão direito. Após isso escolher a opção DEBUG

Caso deseje executar o sistema depois e o visual studio estive fechado basta acessar o endereço "..\desafio-042021-caiqueneves\Desafio.CaiqueNeves\bin\Debug" 
e clica no executável "Desafio.CaiqueNeves.exe".

##### Usando o sistema

O sistema tem um menu de opções onde vc podera escolher entre as opções:

   1. Informar os endereços dos arquivos
   2. Gerar a fatura
   3. Exportar a fatura para um arquivo

Para informar a opção basta informar o número que estive no inicio da opção : EX => 2. para gerar a fatura 

Quando escolher a opção "1- Informar ... arquivos", será necessário informar os endereços dos arquivos respeitando a ordem solicitada.

EX => Informe o endereço do arquivo da lista de produtos: "..\desafio-042021-caiqueneves\documentos\listaProdutos.txt"

Quando escolher a opção "3. Exportar a fatura ...", será necessário informar onde deseja que o sistema salve o arquivo "invoices.txt". 
##### Obs : Nessa opção é para informar o endereço sem o nome do arquivo.

---

## 🛠 Tecnologias

Linguagem de programação C# e Framework .Net

---

## 🚀  Autor

Caíque Neves

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE.MT).

Feito com ❤️ por Caíque Neves 👋🏽 

---

##  Versões do README

[Português 🇧🇷](./README.md)  