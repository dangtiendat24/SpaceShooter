using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;

    // --- MỚI: Khai báo biến máu ---
    public int defaultHealthPoint; // Máu gốc (Cài đặt trong Inspector)
    private int healthPoint;       // Máu hiện tại (Tính toán trong game)

    // Khi bắt đầu game, nạp đầy máu
    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    // --- MỚI: Hàm nhận sát thương (thay cho việc chết ngay) ---
    public void TakeDamage(int damage)
    {
        // Nếu đã chết rồi thì thôi không trừ nữa
        if (healthPoint <= 0) return;

        // Trừ máu
        healthPoint -= damage;

        // Kiểm tra: Nếu hết máu thì mới gọi hàm Die
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    // Hàm Die giữ nguyên như cũ
    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}