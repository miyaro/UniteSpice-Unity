using UnityEngine;

public class BoardController : MonoBehaviour
{
    private const float boardMoveLimit = 12.5f;
    [SerializeField] private float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * speed;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.forward * speed;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }

    private void LateUpdate()
    {
        if (transform.position.x > boardMoveLimit)
        {
            transform.position = new Vector3(boardMoveLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -boardMoveLimit)
        {
            transform.position = new Vector3(-boardMoveLimit, transform.position.y, transform.position.z);
        }
    }
}
