using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickupPrefab; // Assign the PickupItem prefab in the Inspector
    public float spawnInterval = 5.0f; // Time interval between spawns

    void Start()
    {
        InvokeRepeating("SpawnPickup", spawnInterval, spawnInterval);
    }

    void SpawnPickup()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10.0f, 10.0f), 10.0f, 0);
        Instantiate(pickupPrefab, spawnPosition, Quaternion.identity);
    }
}
