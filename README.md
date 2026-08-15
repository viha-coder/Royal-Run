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
- Multiple randomly selected level chunk Prefabs.
- Checkpoint chunks spawned at configurable intervals.
- Continuous obstacle spawning using Coroutines.
- Random obstacle rotations.
- Physics Materials for different physical interactions.
- Lane-based obstacle and pickup spawning.
- Apple and coin pickup types.
- Random coin groups with configurable spacing.
- Score system with a TextMeshPro UI scoreboard.
- Configurable score values for coin pickups.
- Dependency injection for passing the `ScoreManager` to spawned objects.
- Player hit animation triggered by collisions.
- Collision cooldown to prevent repeated hit animations.
- Automatic cleanup of fallen obstacles.

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
- Used an array of chunk Prefabs to create level variation.
- Randomly selected which chunk should spawn.
- Created a separate method to decide which chunk Prefab should be instantiated.

### Checkpoint Chunks

- Created a dedicated checkpoint chunk Prefab.
- Tracked the total number of spawned chunks.
- Used the modulus operator (`%`) to identify checkpoint intervals.
- Used logical conditions with `&&` to avoid spawning a checkpoint at the initial count of zero.
- Added a configurable checkpoint interval instead of hardcoding the value.
- Refactored checkpoint selection into `ChooseChunkToSpawn()`.

### Dependency Injection

- Passed dependencies to objects instead of having each object search for them.
- Injected the `ScoreManager` from the `LevelGenerator` into each `Chunk`.
- Passed the same `ScoreManager` reference from a `Chunk` to spawned coins.
- Used initialization methods to provide dependencies after objects are instantiated.
- Reduced the need for scene-wide object searches such as `FindAnyObjectByType()`.

### Coroutines & Loops

- Created Coroutines using `IEnumerator`.
- Used `WaitForSeconds` to execute actions over time.
- Used `while (true)` for continuous obstacle spawning.
- Practiced the difference between `for` loops for a defined number of repetitions and `while` loops for continuous behavior.

### Obstacle Spawning

- Instantiated obstacle Prefabs during gameplay.
- Controlled the spawn interval through a serialized variable.
- Used `Random.rotation` to give spawned obstacles random orientations.
- Used available lane lists to control where objects can spawn.
- Prevented multiple gameplay objects from occupying the same lane.

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
- Used `Invoke()` to restore the player's ability to receive another hit.

### Physics & Time

- Learned how physics updates use a fixed timestep.
- Explored how `Time.timeScale` affects physics simulation.
- Learned why a very low time scale can make Rigidbody movement appear jittery.
- Learned how `Time.fixedDeltaTime` can be adjusted when working with slow motion.

### Physics Materials

- Learned how friction and bounciness affect Collider interactions.
- Used Physics Materials to change physical behavior without writing custom physics logic.

### Object Cleanup

- Used trigger colliders to detect objects that fall outside the playable area.
- Destroyed fallen objects to prevent unnecessary objects from remaining in the scene.

## Scripts

### Managers

- `GameManager.cs` — manages game-level behavior.
- `ScoreManager.cs` — stores the score and updates the scoreboard UI.

### Player

- `PlayerController.cs` — handles player input and movement.
- `PlayerCollisionHandler.cs` — handles player collision feedback and hit animation cooldown.
- `CameraController.cs` — manages camera behavior.

### Procedural Generation

- `LevelGenerator.cs` — manages chunk generation, movement, replacement and checkpoint selection.
- `Chunk.cs` — manages lane-based spawning inside individual level chunks.
- `ObstacleSpawner.cs` — continuously spawns obstacles using a Coroutine.
- `ObstacleDestroy.cs` — removes objects that fall outside the playable area.

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

Royal Run is a learning-focused project.

The goal is not to create a large game, but to use a smaller project to practice C# concepts, explore Unity systems, and improve my understanding of gameplay programming.

---

This is my fourth Unity/C# project in my game development learning journey.
