using UnityEngine;

// Thay vì : MonoBehaviour, ta đổi thành : Health
public class PlayerHealth : Health
{
    // Từ khóa 'override' nghĩa là: "Con muốn sửa lại cách chết của Cha"
    protected override void Die()
    {
        // base.Die() => Gọi lại lệnh Destroy(gameObject) của Cha
        base.Die();

        Debug.Log("Player died - Game Over!"); // In thông báo
    }
}