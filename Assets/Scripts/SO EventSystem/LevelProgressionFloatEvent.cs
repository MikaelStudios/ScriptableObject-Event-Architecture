using UnityEngine;
using UnityEngine.Events;

public class LevelProgressionFloatEvent : MonoBehaviour
{
    public float multiplier = 10;

    public UnityEvent<float> InvokeEvent = new UnityEvent<float>();

    public void Invoke(float f)
    {
        InvokeEvent.Invoke(((f * multiplier)));

    }
}
