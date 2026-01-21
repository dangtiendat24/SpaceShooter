using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f; // Tốc độ bay (Mặc định là 10)

    // Hàm Update chạy liên tục mỗi khung hình
    void Update()
    {
        // 1. Lấy vị trí hiện tại
        Vector3 newPosition = transform.position;

        // 2. Tăng vị trí Y lên (Bay lên trên)
        // Công thức: Vị trí mới = Vị trí cũ + (Tốc độ * Thời gian)
        newPosition.y += flySpeed * Time.deltaTime;

        // 3. Gán lại vị trí mới cho viên đạn
        transform.position = newPosition;
    }
}