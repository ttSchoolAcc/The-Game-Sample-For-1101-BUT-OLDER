using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    PlayerMovement playerMovement;

    void Awake()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            playerMovement.numOfJumps = 1;
        }
    }
}
