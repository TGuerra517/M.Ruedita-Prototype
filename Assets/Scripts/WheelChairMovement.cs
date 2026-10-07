using UnityEngine;

public class WheelChairMovement : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float moveDistance = 0.5f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float scroll = Input.mouseScrollDelta.y;

        if (scroll > 0)
        {
            Move(1);
        }
        else if (scroll < 0)
        {
            Move(-1);
        }
    }

    void Move(int direction)
    {
        Vector3 movement = transform.forward * direction * moveDistance;

        rb.MovePosition(rb.position + movement);
    }
}
