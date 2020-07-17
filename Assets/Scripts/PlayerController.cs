using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public string horizontalAxis;
    public string verticalAxis;
    
public float movementSpeed = 20;
    public float rotationSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Steer();

    }


    private void Move()
    {
        float verticalInput = Input.GetAxis(verticalAxis);

        this.transform.Translate(Vector3.forward * (verticalInput * (Time.deltaTime * movementSpeed)));
    }
/// <summary>
/// Steers the vehicle right and left.
/// </summary>
    private void Steer()
    {
        float horizontalInput = Input.GetAxis(horizontalAxis);
        this.transform.Rotate(Vector3.up * (horizontalInput* (Time.deltaTime * rotationSpeed)));
    }


}
