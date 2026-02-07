using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Biến để chứa máu của chính mình (để tự sát)
    public EnemyHealth health;

    // Sát thương gây ra cho người chơi
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Kiểm tra xem vật va chạm có phải là Player không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        // 2. Nếu đúng là Player
        if (playerHealth != null)
        {
            // Trừ máu người chơi
            playerHealth.TakeDamage(damage);

            // Tự sát (Trừ 1000 máu để đảm bảo chết ngay lập tức)
            health.TakeDamage(1000);
        }
    }
}