using UnityEngine;

public class SimpleShooting : MonoBehaviour
{
    public GameObject bulletPrefab;     
    public float shootingInterval = 0.2f; 

    private float lastBulletTime;

    public Vector3 bulletOffset;

    void Update()
    {
        // Getkey: giữ phím
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            Vector3 spawnPosition = transform.position + bulletOffset;

            Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);

            lastBulletTime = Time.time;
        }
    }
}