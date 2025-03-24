using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void StartGame()
    {
        // โหลดซีนเกม
        SceneManager.LoadScene("Scene2");
    }

    //public void OpenSettings()
   // {
        // โหลดซีนการตั้งค่าหรือเปิดหน้าต่างตั้งค่า
        //SceneManager.LoadScene("SettingsScene");
   // }
}
