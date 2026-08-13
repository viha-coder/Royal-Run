using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Animator animator;

    [Header("Cooldown Settings")]
    [SerializeField] float animationCooldown = 1f;

    [Header("Speed Adjustment Settings")]
    [SerializeField] float adjustChangeMoveSpeedAmount = -2f;

    const string hitString = "Hit";

    float cooldownTimer = 0f;

    LevelGenerator levelGenerator;

    private void Start()
    {
        levelGenerator = FindAnyObjectByType<LevelGenerator>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
    }    

    private void OnCollisionEnter(Collision other)
    {
        if (cooldownTimer <= animationCooldown) return;

            levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
            animator.SetTrigger(hitString);
            cooldownTimer = 0f;
    }


}
