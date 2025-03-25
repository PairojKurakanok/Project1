using UnityEngine;

public class GolfBallController : MonoBehaviour
{
    public Rigidbody rb;
    public float hitForce = 10f; // แรงตีลูกกอล์ฟ
    private Vector3 hitDirection;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hitDirection = CalculateHitDirection();
        }

        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(hitDirection * hitForce, ForceMode.Impulse);
        }
    }

    Vector3 CalculateHitDirection()
    {
        // คำนวณทิศทางที่ผู้เล่นเลือก
        return (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
    }
}
