# Royal Run

Royal Run is a 3D endless runner developed in Unity using C#.

The project was created as part of my Unity and C# learning journey, with a focus on practicing programming concepts, procedural generation, gameplay systems and Unity's physics tools through a small and manageable game.

## Project Status

**Completed**

Royal Run is now complete as a learning project.

There are many features that could still be added or expanded in the future, but the goal of this project was to practice programming concepts and explore new Unity systems rather than build a large production game.

I may return to the project in the future to expand it with new mechanics and features.

## Current Features

- Player movement using Unity's Input System and `Rigidbody.MovePosition()`.
- Movement limits using `Mathf.Clamp()`.
- Continuously moving level chunks.
- Automatic removal and replacement of old chunks.
- Multiple randomly selected level chunk Prefabs.
- Checkpoint chunks spawned at configurable intervals.
- Lane-based obstacle and pickup generation.
- Continuous obstacle spawning using Coroutines.
- Random obstacle rotations.
- Falling rock obstacles.
- Physics Materials for different physical interactions.
- Apple and coin pickup types.
- Random coin groups with configurable spacing.
- Score system with a TextMeshPro UI scoreboard.
- Configurable score values for coin pickups.
- Dependency injection for passing the `ScoreManager` to spawned objects.
- Player hit animations triggered by collisions.
- Collision cooldown to prevent repeated hit animations.
- Automatic cleanup of fallen obstacles.
- Timed game session with a game over state.
- Slow-motion game over sequence.
- Automatic level reload after game over.
- Background music and gameplay audio.

## Concepts Learned

### Player Movement

- Read two-dimensional input using `Vector2`.
- Converted input into a `Vector3` movement direction.
- Used `FixedUpdate()` and `Time.fixedDeltaTime` for physics-based movement.
- Limited the player's movement area using `Mathf.Clamp()`.

### Level Generation

- Created reusable level chunks with Prefabs.
- Used a `List<GameObject>` to keep track of active chunks.
- Used loops to spawn and iterate through chunks.
- Calculated new spawn positions based on previous chunks.
- Destroyed chunks after they passed the camera and spawned replacements.
- Used an array of chunk Prefabs to create level variation.
- Randomly selected which chunk should spawn.
- Separated chunk selection from chunk spawning using dedicated methods.

### Checkpoint System

- Created a dedicated checkpoint chunk Prefab.
- Tracked the total number of spawned chunks.
- Used the modulus operator (`%`) to identify checkpoint intervals.
- Used logical conditions with `&&` to handle the initial zero value.
- Added a configurable checkpoint interval instead of hardcoding the value.
- Refactored checkpoint selection into `ChooseChunkToSpawn()`.

### Dependency Injection

- Passed dependencies to objects instead of having each object search for them.
- Injected the `ScoreManager` from the `LevelGenerator` into each `Chunk`.
- Passed the same `ScoreManager` reference from a `Chunk` to spawned coins.
- Used initialization methods to provide dependencies after objects were instantiated.
- Reduced the need for scene-wide object searches such as `FindAnyObjectByType()`.

### Coroutines & Loops

- Created Coroutines using `IEnumerator`.
- Used `WaitForSeconds` to execute actions over time.
- Used `while` loops for continuous behavior.
- Used `for` loops when working with a defined number of iterations.
- Used Coroutines to control delayed gameplay actions such as level reloading.

### Obstacle Spawning

- Instantiated obstacle Prefabs during gameplay.
- Controlled spawn intervals through serialized variables.
- Used random rotations for spawned obstacles.
- Used available lane lists to control where objects could spawn.
- Prevented gameplay objects from occupying conflicting lanes.
- Added falling rock obstacles as an additional gameplay hazard.

### Pickup System

- Created a reusable base class for pickups.
- Created different pickup types using inheritance.
- Spawned pickups using available lane positions.
- Generated random groups of coins in a single lane.
- Used configurable spacing to control coin placement.

### Score System

- Created a dedicated `ScoreManager` class.
- Stored and increased the player's score.
- Passed score values from coin pickups to the score manager.
- Converted numeric score values into strings for UI display.
- Updated a TextMeshPro UI element during gameplay.
- Separated score logic from individual pickup behavior.

### Player Collision

- Triggered animations when the player collides with obstacles.
- Used Animator triggers to control hit animations.
- Added a cooldown to prevent repeated collision animations.
- Used `Invoke()` to control the cooldown timing.

### Physics & Time

- Learned how Unity physics uses a fixed timestep.
- Explored how `Time.timeScale` affects gameplay and physics simulation.
- Learned why very low time scales can make Rigidbody movement appear jittery.
- Learned how `Time.fixedDeltaTime` relates to physics updates.
- Used slow motion as part of the game over sequence.

### Game Flow

- Created a timed game session.
- Implemented a game over state.
- Disabled player control after game over.
- Displayed game over UI feedback.
- Used a Coroutine to delay the restart.
- Reloaded the current scene using `SceneManager`.
- Restored `Time.timeScale` before restarting the game.

### Physics Materials

- Learned how friction and bounciness affect Collider interactions.
- Used Physics Materials to change physical behavior without writing custom physics logic.

### Object Cleanup

- Used trigger colliders to detect objects that fall outside the playable area.
- Destroyed fallen objects to prevent unnecessary objects from remaining in the scene.

## Scripts

### Managers

- `GameManager.cs` — manages game state, timer, game over and level restarting.
- `ScoreManager.cs` — stores the score and updates the scoreboard UI.

### Player

- `PlayerController.cs` — handles player input and movement.
- `PlayerCollisionHandler.cs` — handles collision feedback and hit animation cooldown.
- `CameraController.cs` — manages camera behavior.

### Procedural Generation

- `LevelGenerator.cs` — manages chunk generation, movement, replacement and checkpoint selection.
- `Chunk.cs` — manages lane-based spawning inside individual level chunks.
- `Checkpoint.cs` — handles checkpoint behavior.
- `ObstacleSpawner.cs` — continuously spawns obstacles using a Coroutine.
- `ObstacleDestroy.cs` — removes objects that fall outside the playable area.
- `Rock.cs` — handles falling rock behavior.

### Pickups

- `Pickup.cs` — base class for collectible objects.
- `Apple.cs` — defines apple pickup behavior.
- `Coin.cs` — handles coin pickup behavior and score rewards.

## Technologies

- Unity 6
- C#
- Unity Input System
- Unity Physics
- TextMeshPro
- Git
- GitHub

## Learning Goal

Royal Run was created as a learning-focused project.

The goal was not to create a large or feature-complete game, but to use a smaller project to practice C# concepts, explore Unity systems and improve my understanding of gameplay programming.

The project has reached the point I wanted for this stage of my learning journey. I may return to Royal Run in the future and expand it with new mechanics, content and polish as my skills continue to grow.

---

This is my fourth completed Unity/C# project in my game development learning journey.