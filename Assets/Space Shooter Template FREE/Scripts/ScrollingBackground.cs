using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bgRenderer; // Biến để chứa thành phần hiển thị hình ảnh
    public float speed;         // Biến chỉnh tốc độ cuộn

    // Update được gọi liên tục mỗi khung hình
    void Update() =>
        // Kéo lệch tọa độ Y của bức ảnh theo thời gian
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * speed);
}