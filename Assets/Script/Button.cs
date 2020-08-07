using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Vector3 AxisZ = new Vector3(0, 0, 1);
    public void TiltPointerIn()
    {
        transform.Rotate(AxisZ, 8.0f);
    }
    public void TiltPointerOut()
    {
        transform.Rotate(AxisZ, -8.0f);
    }
}
