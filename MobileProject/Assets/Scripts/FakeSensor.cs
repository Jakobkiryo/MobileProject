public struct Vector3Data
{
    public float X, Y, Z;
}
    
public class FakeSensor : System.Object
{
    public static FakeSensor Instance { get; }
        
    public Vector3Data FakeStuff { get; }
        
    public int SampleRate { get; set; }

    public void DoCoolStuff()
    {
            
    }

    public static void OtherCoolStuff()
    {
            
    }
}