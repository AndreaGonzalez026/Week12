using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public float speed = 2.0f; // Speed at which the pickup moves down the screen
    private PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        // Move the pickup item down the screen
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add the item to the player's inventory
            playerController.CollectPickup();
            // Destroy the pickup item
            Destroy(gameObject);
        }
    }
}
