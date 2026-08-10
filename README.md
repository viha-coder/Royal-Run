# Royal Run

Royal Run is a 3D endless runner developed in Unity using C#.

The project is being developed as part of my Unity and C# learning journey, with a focus on practicing programming concepts and exploring Unity systems through a small and manageable game.

## Project Status

**In Development**

New mechanics and systems will be added as I progress through the course.

## Current Features

- Player movement using Unity's Input System and `Rigidbody.MovePosition()`.
- Movement limits using `Mathf.Clamp()`.
- Continuously moving level chunks.
- Automatic removal and replacement of old chunks.
- Continuous obstacle spawning using Coroutines.
- Random obstacle rotations.
- Physics Materials for different physical interactions.

## Concepts Learned

### Player Movement
- Read two-dimensional input using `Vector2`.
- Converted input into a `Vector3` movement direction.
- Used `FixedUpdate()` and `Time.fixedDeltaTime` for physics-based movement.
- Limited the player's movement area using `Mathf.Clamp()`.

### Level Generation
- Created reusable level chunks with Prefabs.
- Used a `List<GameObject>` to keep track of active chunks.
- Used `for` loops to spawn and iterate through chunks.
- Calculated new spawn positions based on the previous chunk.
- Destroyed chunks after they passed the camera and spawned replacements.

### Coroutines & Loops
- Created Coroutines using `IEnumerator`.
- Used `WaitForSeconds` to execute actions over time.
- Used `while (true)` for continuous obstacle spawning.
- Practiced the difference between `for` loops for a defined number of repetitions and `while` loops for continuous behavior.

### Obstacle Spawning
- Instantiated obstacle Prefabs during gameplay.
- Controlled the spawn interval through a serialized variable.
- Used `Random.rotation` to give spawned obstacles random orientations.

### Physics Materials
- Learned how friction and bounciness affect Collider interactions.
- Used Physics Materials to change physical behavior without writing custom physics logic.

## Scripts

- `PlayerController.cs` — handles player input and movement.
- `LevelGenerator.cs` — manages moving, removing, and replacing level chunks.
- `ObstacleSpawner.cs` — continuously spawns obstacles using a Coroutine.

## Technologies

- Unity 6
- C#
- Unity Input System
- Unity Physics
- Git
- GitHub

## Learning Goal

Royal Run is a learning-focused project.

The goal is not to create a large game, but to use a smaller project to practice C# concepts, explore Unity systems, and improve my understanding of gameplay programming.

---

This is my fourth Unity/C# project in my game development learning journey.