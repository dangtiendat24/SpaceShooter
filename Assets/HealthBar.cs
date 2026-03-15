using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask; // Kéo vật thể Mask vào đây
    public Health health;      // Kéo vật thể Player (chứa script Health) vào đây

    private float originalWidth; // Lưu lại chiều rộng ban đầu của thanh máu

    void Start()
    {
        // 1. Lưu lại chiều rộng đầy đủ ban đầu (khi máu 100%)
        originalWidth = mask.sizeDelta.x;

        // 2. Cập nhật hiển thị lần đầu
        UpdateHealthValue();

        // 3. Đăng ký lắng nghe: Mỗi khi máu thay đổi, hãy tự động chạy hàm UpdateHealthValue
        health.onHealthChanged += UpdateHealthValue;
    }

    private void UpdateHealthValue()
    {
        // Tính toán tỷ lệ: Máu hiện tại / Máu tối đa
        float scale = (float)health.healthPoint / health.defaultHealthPoint;

        // Cập nhật lại chiều rộng của Mask dựa trên tỷ lệ vừa tính
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}