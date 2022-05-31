using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 60f; // 회전속도


    private void Update()
    {
        transform.Rotate(0f, RotationSpeed*Time.deltaTime, 0f);    
    }
}
