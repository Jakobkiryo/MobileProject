using UnityEngine.InputSystem;
using UnityEngine;

public class GravitySynchronizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(Accelerometer.current);
        
        Debug.Log("Default sampling");
        
        Accelerometer.current.samplingFrequency = 30;
    }

    // Update is called once per frame
    void Update()
    {
        var gravity = Accelerometer.current.acceleration.value;
        
        gravity.z *= -1;
        gravity *= 9.81f;
        Physics.gravity = gravity;
    }
}
