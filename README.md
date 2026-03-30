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
   1. Menu Sytem
      - Start Game
      - View Game Info
      - Exit Application

   2. Snake Movement
     - Controlled using arrow keys
     - Snake grows when food is collected

   3. Multiple Food Types
     - Normal food (+1 score)
     - Bonus food (+3 score)

   4. Obstacle System (Challenge)
     - Obstacles increase with each level
     - Collision with obstacle results in game over

  5. Score Management
    - Tracks current score and high score

  6. Level System (Level 1,2,3)
    - Level 1 : Slow speed, fewer obstacles (Target : 5)
    - Level 2 : Medium speed, more obstacles (Target : 10)
    - Level 3 : Fast spped, highest difficulty (Target : 15)

  7. Increasing Difficulty
    - Snake speed increases each level

  8. Game Boundary (Black Border)
    - Clearly visible game area
    - Collision with border results in game over

  9. Game Over & Win Condition
    - Game ends if snake hits wall, obstacles or itself

e) OOP Concepts Used
   1. Encapsulation 
      - Private fields with public properties in classes
   2. Inheritance
      - Item (base class) - NormalFood, BonusFood
   3. Polymorphism
      - Different behaviour using overriden methods like GetPoints()
   4. Abstraction
      - Abstarct class Item
      - Interface ICollectable
  5. Collections
     - Lists used for snake body, obstacles and levels
  6. Exception Handling
     - Try-catch used to handle runtime errors during hame execution
  7. Separation of Concerns
     - GameController handles game logic
    - GameForm handles UI
    - LevelManager handles level progression
    - ScoreManager handles scoring

f) How to run the program
   1. Open the solution in Visual Studio Community
   2. Build the project
   3. Run using Start Debugging (F5)

g) Project Structure
   1. Program.cs
      - Entry point of the application -> initializes and runs the game
   2. GameController.cs
      - Controls overall game logic, flow and interactions between components
   3. GameBoard.cs
      - Represents the game area/grid where the snake, food and obstacles exists
   4. GameForm.Designer.cs
      - Auto-generated UI layout code for the game form
   5. GameForm.cs
      - Main game window -> handles UI and player interactions
   6. GameForm.resx
      - Resource file for storing UI assests (strings, images, etc) for the game form
   7. MainMenu.cs
      - Implements the main menu logic and navigation
   8. MainMenu.Designer.cs
      - Auto-generated UI layout code for the main menu
   9. MainMenu.resx
       - Resource file for main menu assets.
   10. Resources.Designer.cs
       - Auto-generated code for accessing resources (images, strings)
   11. Resources.resx
       - Resource file for storing localized strings and images for menus
   12. Snake.cs
       - Defines the snake's behaviour, movement and growth
   13. Player.cs
       - Represents the player entity, including score and state
   14. Position.cs
       - Utility class for handling coordinates/posiitons on the game board
   15. Item.cs
       - Base class for items that can be collected (e.g food)
   16. ICollectable.cs
       - Interface for items that can be collected (e.g food)
   17. NormalFood.cs
       - Represents standard food items that increase the snake's length
   18. BonusFood.cs
       - Represents special food items with bonus effects
   19. Obstacle.cs
       - Represents obstacles that block the snake's path
   20. Level.cs
       - Defines properties and settings for single game level
   21. LevelManager.cs
       - Manages multiple levels, progression and difficulty scaling
   22. ScoreManager.cs
       - Handles score tracking, updating and display
   23. README.md
       - Documentation for the project, setup instructions and usege notes
   24. Snake Game.csproj
       - Project file containing build configuration and references
   25. Snake Game.csproj.user
       - User-specific project settings
   26. Snake Game.slnx
       - Solution file for opening project in Visual Studio
   27. Gemini_Generated_Image_fy3hxyfy3hxyfy3h.png
       - AI-generated image used in the main menu.
   28. Gemini_Generated_Image_vr6yyovr6yyovr6y.png
       - Another AI-generated image for menu or background.
   29. f632a812eb1afc3.png
       - Custom image asset (likely for UI or menu).
   30. snake1.jpg
       - Snake-themed image for main menu or gameplay.
   31. snake2.jpg
       - Alternate snake-themed image for main menu or UI.
