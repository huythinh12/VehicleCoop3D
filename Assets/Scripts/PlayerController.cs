using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float turnSpeed; // tốc độ bẻ lái
    public TMP_Text titleNotiWin;
    private float speed = 10;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.name == "Vehicle P2")
        {
                ControlCarPRight();
        }
        else
        {
            ControlCarPLeft();
        }

    }
    private void ControlCarPLeft()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle on horizontal 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
    private void ControlCarPRight()
    {
            horizontalInput = Input.GetAxis("Horizontal1");
        forwardInput = Input.GetAxis("Vertical1");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle on horizontal 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finish"))
        {
            titleNotiWin.gameObject.SetActive(true);
            if (transform.CompareTag("P1"))
            {
                titleNotiWin.text = "Player1 Win";
            }
            else if(transform.CompareTag("P2"))
            {
                titleNotiWin.text = "Player2 Win";
            }
            else
            {
                titleNotiWin.text = "Draw";
            }
        }
    }
}
