a) Project Title
  - SnakeGame Assignment

b) Group Members
1. Sarah Amni Binti Manan- 25014216
2. ⁠Nur Aqilah Binti Roslan - 25014140
3. ⁠Puteri Alya Qistina Binti Mohamad Faizal -25014060
4. ⁠Adlina Binti Shahrizan Adzham - 25014209
5. ⁠Jasmin Damia Binti Norazmi - 25014130
6. ⁠Wan Nur Ainnadhirah binti Wan Mohd Azmi - 25014235
7. Nur Iman Farzana Binti Zamzeley - 25014260

c) Project Description
  - This project is a C# Windows Forms Snake Game developed using Object-Oriented Programming
  (OOP) concepts. The player controls a snake that moves inside a bordered area, collects food, and avoids obstacles and collisions.
  The game has three levels with increasing difficulty. As the player moves to higher levels, the snake become faster and more obstacles appear, making the game
  more challenging. The objective is to reach the target score for each level and complete all levels without hitting with the wall, obstacles, or the snake's own    body.This project demonstrate the use of OOP concepts such as encapsulation, inheritance, polymorphism,   and abstraction. It also provides a simple interactive
  and menu-driven interface for the user.

d) System Features
  - Menu Sytem
  - -> Start Game
  - -> View Game Info
  - -> Exit Application

  - Snake Movement
  - -> Controlled using arrow keys
  - -> Snake grows when food is collected

  - Multiple Food Types
  - -> Normal food (+1 score)
  - -> Bonus food (+3 score)

  - Obstacle System (Challenge)
  - -> Obstacles increase with each level
  - -> Collision with obstacle results in game over

  - Score Management
  - -> Tracks current score and high score

  - Level System (Level 1,2,3)
  - -> Level 1 : Slow speed, fewer obstacles (Target : 5)
  - -> Level 2 : Medium speed, more obstacles (Target : 10)
  - -> Level 3 : Fast spped, highest difficulty (Target : 15)

  - Increasing Difficulty
  - -> Snake speed increases each level

  - Game Boundary (Black Border)
  - -> Clearly visible game area
  - -> Collision with border results in game over

  - Game Over & Win Condition
  - -> Game ends if snake hits wall, obstacles or itself

e) OOP Concepts Used
  - Encapsulation
  - -> Private fields with public properties in classes

  - Inheritance
  - -> Item (base class) - NormalFood, BonusFood

  - Polymorphism
  - -> Different behaviour using overriden methods like GetPoints()

  - Abstraction
  - -> Abstarct class Item
  - -> Interface ICollectable

  - Collections
  - -> Lists used for snake body, obstacles and levels

  - Exception Handling
  - -> Try-catch used to handle runtime errors during hame execution

  - Separation of Concerns
  - -> GameController handles game logic
  - -> GameForm handles UI
  - -> LevelManager handles level progression
  - -> ScoreManager handles scoring

f) How to run the program
   1. Open the solution in Visual Studio Community
   2. Build the project
   3. Run using Start Debugging (F5)


