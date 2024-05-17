# Floppy Burd

Welcome to the GitHub repository for **Floppy Burd**, a creative and addictive version of the classic game **Flappy Bird**. Passionately developed in **Unity** and meticulously programmed in **C#**, this game promises to provide hours of fun and challenges.

## About the Game

**Floppy Burd** is an arcade game where players test their agility and patience. Control a cute bird and navigate it through the obstacles that appear along the way, in a colorful and lively world.

## Game mechanics

The game's basic mechanics are simple but addictive: players tap the screen or use a key to make the birdie "flutter" and soar through the air, avoiding obstacles to get the highest score.

### Code

The project includes several C# scripts that together create a fluid and responsive gaming experience:

- `burd_script.cs`: This script controls the bird's movements, giving it the ability to `fly`, reach obstacles and soar through the air.
- `pipe_spawner.cs`: Responsible for dynamically generating obstacles, this script maintains the randomization of the obstacle position.
- `pipe_script.cs`: Provides speed for moving obstacles and clearing them if they go out of play .
- `Middle_Score_script.cs`: This script manages the scoring system, recording each obstacle passed and displaying the score on the screen.
- `logic_manager.cs`: The heart of the game logic, this script manages the start and end states of the game, as well as the game over screen.

## Assets

- Graphical assets have been selected and integrated to create a vibrant and immersive world.
- The game's main logo was originally created in **Adobe Illustrator**, then converted to **PNG** format to match the game's aesthetic.

## Score and Game Over System

The game uses a simple scoring system based on the number of obstacles avoided. Upon colliding with an obstacle or falling bird, the game ends, displaying the game over screen and giving the player the option to try again to improve their score.

**Floppy Burd** is an open community project and we look forward to seeing how it evolves with your help and creativity!
