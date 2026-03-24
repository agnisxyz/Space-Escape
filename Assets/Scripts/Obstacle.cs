using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSize = 0.5f;
    public float maxSize = 2f;
    public float maxSpeed = 150f;

    public float minSpeed = 50f;
    public Vector2 randomDirection = Random.insideUnitCircle;

    public Rigidbody2D rb;

    private void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        rb = GetComponent<Rigidbody2D>();
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        rb.AddForce(randomDirection * randomSpeed);
    }
}