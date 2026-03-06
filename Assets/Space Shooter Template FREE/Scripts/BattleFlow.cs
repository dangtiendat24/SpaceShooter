using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;// Biến chứa bảng giao diện Game Over
    public PlayerHealth playerHealth; // Biến chứa máu của người chơi
    public GameObject bgMusic;        // Biến chứa nhạc nền đang phát

    private void Start()
    {
        // Khi mới vào game, đảm bảo bảng Game Over bị ẩn đi
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);

        // Cực kỳ quan trọng: Lắng nghe sự kiện chết! 
        // Khi onDead phát ra, hệ thống sẽ tự động chạy hàm OnGameOver bên dưới
        playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        // Kiểm tra điều kiện chiến thắng: Nếu không còn quái vật nào sống thì thắng
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            onGameWin();
        }
    }

    public void onGameWin()
    {
        // Khi thắng: Bật bảng Game Win lên
        gameWinUI.SetActive(true);
        // Tắt nhạc nền đi cho thêm phần hoành tráng
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false); // Ẩn nhân vật người chơi đi cho đẹp :D
    }

    private void OnGameOver()
    {
        // Khi chết: Bật bảng Game Over lên
        gameOverUI.SetActive(true);
        // Tắt nhạc nền đi cho thêm phần bi tráng
        bgMusic.SetActive(false);
    }

    public void ReturnToMenu() => SceneManager.LoadScene("MainMenu");
}