
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public Vector3 rotationAmount;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((rotationAmount * Time.deltaTime));
    }
}
