using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;

    // --- Khai báo biến máu ---
    public int defaultHealthPoint; // Máu gốc (Cài đặt trong Inspector)

    // Đã chuyển thành public để script UI lát nữa có thể đọc được số máu này
    public int healthPoint;        // Máu hiện tại (Tính toán trong game)

    // --- Khai báo các sự kiện (Loa thông báo) ---
    public System.Action onDead;
    public System.Action onHealthChanged; // MỚI: Sự kiện báo khi máu bị thay đổi

    // Khi bắt đầu game, nạp đầy máu
    private void Start()
    {
        healthPoint = defaultHealthPoint;

        // Phát tín hiệu ngay khi vào game để thanh UI hiển thị đầy 100%
        onHealthChanged?.Invoke();
    }

    // Hàm nhận sát thương 
    public void TakeDamage(int damage)
    {
        // Nếu đã chết rồi thì thôi không trừ nữa
        if (healthPoint <= 0) return;

        // Trừ máu
        healthPoint -= damage;

        // Phát tín hiệu để thanh UI biết mà co ngắn lại
        onHealthChanged?.Invoke();

        // Kiểm tra: Nếu hết máu thì mới gọi hàm Die
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    // Hàm Die 
    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        // Phát sự kiện chết trước khi xóa vật thể
        onDead?.Invoke();

        Destroy(gameObject);
    }
}