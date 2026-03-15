using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // Hàm này giúp vẽ các ký hiệu hỗ trợ trong màn hình Scene (không hiện trong Game)
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green; // Đặt màu xanh lá
        Gizmos.DrawSphere(transform.position, 0.1f); // Vẽ hình cầu nhỏ tại vị trí của điểm mốc
    }
}