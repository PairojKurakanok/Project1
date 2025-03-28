using UnityEngine;
using UnityEngine.SceneManagement;
public class HoleTrigger : MonoBehaviour
{
    // ฟังก์ชันนี้จะถูกเรียกเมื่อ GolfBall ตกลงไปในหลุม
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GolfBall")) // ตรวจสอบว่าเป็น GolfBall หรือไม่
        {
            Debug.Log("Golf Ball fell into the hole! Changing to next scene...");
            
            // เปลี่ยนซีนไปยังซีนถัดไป
            // สามารถเปลี่ยนเป็นชื่อของซีนถัดไปที่ต้องการ
            SceneManager.LoadScene("Scene3"); // เปลี่ยนชื่อเป็นชื่อซีนถัดไป
        }
    }
}
