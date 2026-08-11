using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float animationCooldown = 1f;

    const string hitString = "Hit";

    float cooldownTimer = 0f;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
    }    

    private void OnCollisionEnter(Collision other)
    {
        if (cooldownTimer <= animationCooldown) return;

            animator.SetTrigger(hitString);
            cooldownTimer = 0f;
    }


}
