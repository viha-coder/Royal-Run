using UnityEngine;

public class Apple : Pickup
{
    [Header("Speed Boost Settings")]
    [SerializeField] float adjustChangeMoveSpeedAmount = 3f;

    LevelGenerator levelGenerator;

    private void Start()
    {
        levelGenerator = FindAnyObjectByType<LevelGenerator>();
    }

    protected override void OnPickup()
    {
        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
    }
}
