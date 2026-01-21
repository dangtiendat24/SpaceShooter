using UnityEngine;

public class SimpleShooting : MonoBehaviour
{
    public GameObject bulletPrefab;     // Khuôn đạn
    public float shootingInterval = 0.2f; // Thời gian giãn cách giữa 2 viên đạn (giây)

    private float lastBulletTime;       // Biến lưu thời điểm bắn viên đạn gần nhất

    void Update()
    {
        // Thay vì GetKeyDown (nhấn 1 lần), ta dùng GetKey (giữ phím)
        // Bắn khi GIỮ Chuột trái (0) HOẶC GIỮ phím Space
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Kiểm tra xem đã đủ thời gian chờ chưa (Time.time là thời gian hiện tại của game)
        if (Time.time - lastBulletTime > shootingInterval)
        {
            // Tạo đạn
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Cập nhật lại thời điểm vừa bắn xong
            lastBulletTime = Time.time;
        }
    }
}