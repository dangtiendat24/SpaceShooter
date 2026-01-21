using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    // Hàm được gọi đầu tiên khi Script được nạp (ngay cả khi chưa enable)
    void Awake()
    {
        Debug.Log("1. Awake called");
    }

    // Hàm được gọi mỗi khi Object được bật (Active)
    void OnEnable()
    {
        Debug.Log("2. OnEnable called");
    }

    // Hàm được gọi trước frame đầu tiên (chỉ chạy 1 lần khi bắt đầu)
    void Start()
    {
        Debug.Log("3. Start called");
    }

    // Hàm update vật lý (chạy cố định khoảng 0.02s/lần)
    void FixedUpdate()
    {
        // Mình chỉ log 1 lần để tránh spam console
        if (Time.time < 0.1f) Debug.Log("4. FixedUpdate called");
    }

    // Hàm update logic (chạy mỗi frame)
    void Update()
    {
        // Chỉ log khi nhấn phím Space để đỡ rối
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("5. Update called (Press Space)");
        }
    }

    // Hàm chạy sau khi tất cả các Update đã chạy xong (thường dùng cho Camera)
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("6. LateUpdate called");
        }
    }

    // Hàm được gọi khi Object bị tắt (Disable)
    void OnDisable()
    {
        Debug.Log("7. OnDisable called");
    }

    // Hàm được gọi khi Object bị hủy hoàn toàn (Destroy) hoặc tắt game
    void OnDestroy()
    {
        Debug.Log("8. OnDestroy called");
    }
}