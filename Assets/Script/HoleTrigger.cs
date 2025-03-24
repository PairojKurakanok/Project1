using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    public GameObject golfBall;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == golfBall)
        {
            Debug.Log("Ball in the hole!");
            // เพิ่มฟังก์ชันต่าง ๆ ที่ต้องการ เช่น แสดงข้อความหรือย้ายลูกกอล์ฟกลับไปที่จุดเริ่มต้น
        }
    }
}
