using UnityEngine;

// Lưu ý: Đổi MonoBehaviour thành Health để kế thừa toàn bộ tính năng máu và nổ tung đã làm ở bài trước
public class EnemyHealth : Health
{
    // Biến static dùng chung cho toàn bộ kẻ địch. Dùng để đếm tổng số quái vật đang sống.
    public static int LivingEnemyCount;

    // Hàm này chạy ngay khi kẻ địch vừa xuất hiện
    private void Awake() => LivingEnemyCount++;

    // Ghi đè lại hàm chết
    protected override void Die()
    {
        // Khi con quái này chết, trừ tổng số lượng đi 1
        LivingEnemyCount--;

        // Vẫn gọi lại hàm Die() của class Health gốc để nó chạy hiệu ứng nổ và xóa object
        base.Die();
    }
}