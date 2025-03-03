using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject onCollectEffect; // Set collectible's on collect effect.
    [SerializeField] private float rotationSpeed = 0.5f; // Set collectible's rotation speed.

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0); // Rotate collectible around the Y-axis.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if player has collided with collectible.
        {
            Instantiate(onCollectEffect, transform.position, Quaternion.identity); // Create on collect effect.
            Destroy(gameObject); // Destroy collectible.
        }
    }
}
