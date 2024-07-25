using UnityEngine;

public class BoundaryDestroyer : MonoBehaviour
{
    public float topBoundary = 10f;
    public float bottomBoundary = -10f;

    void Update()
    {
        if (transform.position.y > topBoundary || transform.position.y < bottomBoundary)
        {
            Destroy(gameObject);
        }
    }
}
