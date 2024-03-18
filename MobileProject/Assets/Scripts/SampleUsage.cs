using DefaultNamespace;
using UnityEngine;

public class SampleUsage : MonoBehaviour
{
    void Start()
    {
        FakeSensor sensor = FakeSensor.Instance;
        Vector3Data data = FakeSensor.Instance.FakeStuff;
        Debug.Log(FakeSensor.Instance.SampleRate);
        FakeSensor.Instance.SampleRate = 16;
        
        FakeSensor.OtherCoolStuff();
        FakeSensor.Instance.DoCoolStuff();
    }
}