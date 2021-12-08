# Casino Game - Console Application
## About The Project
This is a casino game solution for a game of cards. The game makes use of a single deck of 52 cards and has four suits. The suits are Diamonds, Hearts, Spades and Clubs. 

This solution makes use of:  
* SOLID Principles
* OOP
* Clean Architecture

## Built With
The solution is a C# Console Application that uses .NET Core 5.0 

## Rules of The Game
The rules of the game are as follows: 
* The player is dealt cards until they choose to stop recieving new cards (hit or stand). 
* The players total is added each time they get a new card
* The player loses if their hand value goes over the count of 21. 
* If the player chooses to stand before 21, the dealer will have a turn of recieving cards. 
* The dealer loses if their hand value goes over the count of 21. 
* The highest hand wins 

## How To Play
1. Run the solution 
2. Enter your name 
3. Enter your bankroll 
4. Enter your bet amount 
5. Your first two cards are drawn and your hand value is displayed. The dealers cards are drawn and one of his cards are hidden. Enter 'Hit' or 'Stand'. 
6. You will win if your hand value is 21 and under or if the dealer loses. 
7. You will lose if your hand value is over 21 or if the dealers wins. 

## Future Features 
* Making the solution more generic for other games to be added. 
* Making more use of OOP 
* Creating a solution with a UI
