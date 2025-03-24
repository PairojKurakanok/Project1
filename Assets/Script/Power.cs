using UnityEngine;
using UnityEngine.UI;
public class Power : MonoBehaviour
{
    public Slider powerSlider;
    public float powerRate = 5f;

    private float currentPower = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) // เมื่อกดปุ่ม Space จะเพิ่มความแรง
        {
            currentPower += powerRate * Time.deltaTime;
            currentPower = Mathf.Clamp(currentPower, 0f, powerSlider.maxValue);
            powerSlider.value = currentPower;
        }
        else if (Input.GetKeyUp(KeyCode.Space)) // เมื่อปล่อย Space จะยิงลูกกอล์ฟ
        {
            ShootGolfBall();
            currentPower = 0f;
            powerSlider.value = currentPower;
        }
    }

    void ShootGolfBall()
    {
        // ยิงลูกกอล์ฟโดยใช้ค่าความแรง
        // เพิ่มฟังก์ชันการยิงลูกกอล์ฟที่นี่
    }
}
