using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // เป้าหมายที่กล้องจะติดตาม (ลูกกอล์ฟ)
    public Vector3 offset = new Vector3(0f, 5f, -10f); // ระยะห่างจากลูกกอล์ฟ

    void Update()
    {
        if (target != null)
        {
            // อัพเดตตำแหน่งกล้องให้ไปที่ตำแหน่งของลูกกอล์ฟ
            transform.position = target.position + offset;
        }
    }
}
