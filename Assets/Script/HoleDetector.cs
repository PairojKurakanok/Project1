using UnityEngine;

public class HoleDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Golf"))
        {
            Debug.Log("Hole In One!");
            // ทำคะแนน หรือโหลดด่านใหม่
        }
    }
}
