using UnityEngine;

public class PlayerParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem movementParticles;
    [SerializeField] private float minVelocityForParticles = 0.2f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (movementParticles != null)
            movementParticles.Stop();
    }

    void Update()
    {
        Vector3 horizontalVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
        bool isMoving = horizontalVelocity.magnitude > minVelocityForParticles;

        if (isMoving && !movementParticles.isPlaying)
        {
            movementParticles.Play();
        }
        else if (!isMoving && movementParticles.isPlaying)
        {
            movementParticles.Stop();
        }
    }
}