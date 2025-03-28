using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;  // กำหนดลูกกอล์ฟให้กล้องติดตาม
    public Vector3 offset = new Vector3(0, 5, -10); // ปรับตำแหน่งของกล้อง
    public float smoothSpeed = 5f; // ความเร็วของการติดตาม

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target); // ให้กล้องหันไปหาลูกกอล์ฟ
    }
}
