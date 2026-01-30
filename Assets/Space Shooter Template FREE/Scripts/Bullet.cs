using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;

    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.y += flySpeed * Time.deltaTime;

        transform.position = newPosition;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);

                Destroy(gameObject);
            }
        }
    }
}