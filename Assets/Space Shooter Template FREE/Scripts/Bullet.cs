using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1; // --- MỚI: Chỉ số sát thương của đạn ---

    void Update()
    {
        // Code bay giữ nguyên
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Kiểm tra xem vật va chạm có thành phần Máu (EnemyHealth) không?
        var enemy = collision.GetComponent<EnemyHealth>();

        // 2. Nếu có (là kẻ thù), thì gọi hàm trừ máu
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        // 3. Hủy viên đạn (đâm vào là mất)
        Destroy(gameObject);
    }
}