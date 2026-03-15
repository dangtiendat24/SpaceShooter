using UnityEngine;

public class FlyPath : MonoBehaviour
{
    // Mảng chứa danh sách các điểm mốc
    public Waypoint[] waypoints;

    // Hàm Reset sẽ tự chạy khi bạn gắn script hoặc nhấn Reset trong Inspector
    private void Reset()
    {
        // Tự động tìm và đưa tất cả các script Waypoint của vật thể con vào mảng
        waypoints = GetComponentsInChildren<Waypoint>();
    }
}