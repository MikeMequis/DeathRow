# DeathRow - A Windows Forms C# Game
DeathRow - Um jogo feito em Windows Forms C#

## Summary/Índice

1. [About/Sobre](#aboutsobre)
2. [Objective/Objetivo](#objectiveobjetivo)
3. [Final Minigame/Último Minigame](#final-minigameúltimo-minigame)
4. [Code Insights/Detalhes do Código](#code-insightsdetalhes-do-código)
   1. [First Part (Escape)/Primeira Parte](#first-part-escapeprimeira-parte)
   2. [Last Part (Duel)/Última Parte](#last-part-duelúltima-parte)
5. [Vídeo/Video](#vídeo--video)

## About/Sobre
Death Row is a text-based puzzle game where players control an inmate with a death penalty and needs to escape quickly. They can do this by navigating throughout the available locations in his map, interacting with different objects and points of interest and collecting different items to progress and keeping them in the player’s inventory. Our goal while making the game is to present a straightforward display so that it can be and accessible for many kinds of people, with easy-to-follow visual elements. It also features a ranking system at the end of the game to provide feedback about the player’s performance.

Death Row é um jogo de quebra-cabeça baseado em texto, onde os jogadores controlam um prisioneiro com pena de morte que precisa escapar rapidamente. Eles podem fazer isso navegando pelos locais disponíveis no mapa, interagindo com diferentes objetos e pontos de interesse, coletando itens diversos para progredir e mantendo-os no inventário do jogador. Nosso objetivo ao criar o jogo é apresentar uma exibição simples, para que seja acessível a diversos tipos de pessoas, com elementos visuais fáceis de seguir. O jogo também conta com um sistema de classificação ao final para fornecer feedback sobre o desempenho do jogador.


## Objective/Objetivo
The main goal of the game is to find and gather all pieces of the key from his cell across locations and points of interest. With this, players must look around and interact with a wide variety of points of interest. Not only they have to take notice of possible dangers lead by some actions that can be chosen but also with the limited amount of time left before the inmate’s execution.

O objetivo principal do jogo é encontrar e reunir todas as partes da chave da cela do prisioneiro, espalhadas pelos locais e pontos de interesse. Para isso, os jogadores devem explorar e interagir com uma ampla variedade de pontos de interesse. Eles não só precisam estar atentos aos perigos potenciais causados por algumas ações escolhidas, mas também ao tempo limitado antes da execução do prisioneiro.

## Final Minigame/Último Minigame
Once the main protagonist finds all pieces of the key and leaves his cell, he encounters a cop guarding the prison exit. In order to escape, he stands up for himself and fights the officer. The fight is represented by the form of the traditional game of Rock, Paper, and Scissors. After the cop’s defeat with 5 confirmed hits, the prisoner flees the prison, and the player wins the game.

Depois que o protagonista principal encontra todas as partes da chave e sai de sua cela, ele encontra um policial guardando a saída da prisão. Para escapar, ele enfrenta o policial em uma luta, que é representada pelo jogo tradicional de Pedra, Papel e Tesoura. Após derrotar o policial com 5 golpes confirmados, o prisioneiro foge da prisão, e o jogador vence o jogo.

## Code Insights/Detalhes do Código
### First Part (Escape)/Primeira Parte
The way how the game builds its elements and shows them on screen consists of three different classes: Point of Interest, Action, and Inventory/Items. Each place in the cell has its own set of objects and its possible actions. With this, each button activates a constructor, creates an object with a list of actions and calls its methods to show on screen and let players select the possible options. When a specific action is selected, it generates a specific item for the inventory.

A forma como o jogo constrói seus elementos e os exibe na tela consiste em três classes diferentes: Ponto de Interesse, Ação e Inventário/Itens. Cada local na cela possui seu próprio conjunto de objetos e suas possíveis ações. Com isso, cada botão ativa um construtor, cria um objeto com uma lista de ações e chama seus métodos para exibi-los na tela, permitindo que os jogadores selecionem as opções disponíveis. Quando uma ação específica é selecionada, ela gera um item específico para o inventário.

### Last Part (Duel)/Última Parte
In the minigame’s case, the game code makes use of variables, pictures and arrays, along with its methods. The opponent’s turns give to the player a randomized choice from the Random class from dot NET whenever he selects one of the options. Another method is called to determine who is the winner of the turn, depending on its circumstances, and increases his score, in this case, the confirmed hits.

No caso do minigame, o código do jogo faz uso de variáveis, imagens e arrays, junto com seus métodos. Os turnos do oponente oferecem ao jogador uma escolha aleatória da classe Random do .NET sempre que ele seleciona uma das opções. Outro método é chamado para determinar quem é o vencedor do turno, dependendo das circunstâncias, e aumenta sua pontuação, que, neste caso, são os golpes confirmados.

## Vídeo/Video
[![Watch the video](https://img.youtube.com/vi/dHgyyThsXUY/maxresdefault.jpg)](https://youtu.be/dHgyyThsXUY)
