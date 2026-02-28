using UnityEngine;
using UnityEngine.SceneManagement; // BẮT BUỘC: Gọi thư viện này ra thì mới chuyển cảnh được

public class MainMenu : MonoBehaviour
{
    // Hàm này sẽ được kích hoạt khi người chơi click vào nút Play
    public void OnPlayButtonClicked()
    {
        // Yêu cầu Unity tải Scene có tên là "Battle"
        SceneManager.LoadScene("Battle");
    }
}