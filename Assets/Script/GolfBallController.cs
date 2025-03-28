using UnityEngine;

public class GolfBallController : MonoBehaviour
{
    public float forceMultiplier = 5f;  // ปรับค่าความแรงของการยิง
    private Rigidbody rb;
    private Vector3 startDragPosition;  // ตำแหน่งเริ่มต้นเมื่อกดคลิก
    private Vector3 endDragPosition;    // ตำแหน่งสุดท้ายเมื่อปล่อยเมาส์
    private bool isDragging = false;    // เช็คว่ากำลังลากเมาส์อยู่หรือไม่

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // ดึง Rigidbody ของลูกกอล์ฟมาใช้งาน
    }

    void Update()
    {
        // เมื่อกดคลิกเมาส์ซ้าย
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // ตรวจสอบว่า Raycast โดนลูกกอล์ฟหรือไม่
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                startDragPosition = hit.point;  // บันทึกตำแหน่งที่เริ่มคลิก
                isDragging = true;             // เปิดการลากเมาส์
            }
        }

        // เมื่อปล่อยคลิกเมาส์ซ้าย
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                endDragPosition = hit.point; // บันทึกตำแหน่งที่ปล่อยเมาส์
            }
            else
            {
                endDragPosition = startDragPosition; // ถ้าปล่อยเมาส์นอกลูกกอล์ฟให้ใช้ค่าตำแหน่งเริ่มต้น
            }

            // คำนวณแรงยิงโดยให้ลูกกอล์ฟพุ่งไปทิศตรงข้าม
            Vector3 forceDirection = (startDragPosition - endDragPosition).normalized;
            float forceMagnitude = Vector3.Distance(startDragPosition, endDragPosition) * forceMultiplier;

            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);

            isDragging = false; // จบการลาก
        }
    }
}

