# Protótipo de Arquitetura por Features

Este projeto apresenta um exemplo de montagem de um protótipo seguindo a arquitetura proposta durante as aulas da área de programação, no ano 2026, no projeto DevU da Faculade Federal de Itajubá (UNIFEI).

O projeto também está pré-configurado para atender a diversos cenários comuns no ambiente da DevU, podendo ser reutilizado como um template inicial para novos projetos.

## Estrutura do Projeto

A organização do projeto foi baseada em **features**. Cada funcionalidade (como Player, Coin, Score, etc.) possui sua própria estrutura interna, permitindo maior modularidade e independência.

Além disso, foi utilizada a estratégia de **centralização de dados com Scriptable Objects**, visando facilitar o trabalho dos game designers da equipe.

## Organização Interna

Para servir como exemplo, cada feature foi organizada de uma forma diferente, podendo variar no nível de complexidade e modularização. 

Features mais complexas, como o Player, apresentam uma estrutura mais robusta, enquanto features mais simples são menos organizadas internamente. O foco do modelo não é uma organização interna padronizada.

## Comunicação entre Features

A comunicação entre diferentes seções do projeto pode ser feita de duas formas:

### 1. Scripts de Cola (Recomendado)

São scripts responsáveis por conectar duas features sem que elas dependam diretamente uma da outra.

Exemplo:
- `CoinScoreGlue.cs`: conecta as features de **Coin** e **Score**

Nesse script existe uma referência direta ao sistema de pontuação, o que é inevitável. A comunicação com as moedas, porém, é feita via **eventos em C#**, reduzindo o acoplamento.  

### 2. Referência Direta (Não recomendado)

Uma feature acessa diretamente a outra. Pode ser utilizada mas não é recomendado, pois quebra a independência das features, aumenta o acoplamento e dificulta manutenção e reutilização.

## Namespaces

Um recurso bastante utilizado no exemplo e que não foi explicado em aula. Namespaces são utilizados para organizar e agrupar classes relacionadas dentro do projeto, evitando conflitos de nomes e melhorando a legibilidade do código. 

Eles funcionam como uma forma de separar logicamente as diferentes partes do sistema, sendo especialmente úteis em projetos organizados por features.
