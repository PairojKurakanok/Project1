using UnityEngine;

public class GolfBallController : MonoBehaviour
{
    public float hitForce = 10f; // ความแรงในการยิง
    private Rigidbody rb;
    private bool isHit = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // คลิกเมาส์เพื่อยิง
        {
            isHit = true;
        }

        if (isHit)
        {
            // ยิงลูกกอล์ฟ
            Vector3 hitDirection = (Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane)) - transform.position).normalized;
            rb.AddForce(hitDirection * hitForce, ForceMode.Impulse);
            isHit = false;
        }
    }
}
