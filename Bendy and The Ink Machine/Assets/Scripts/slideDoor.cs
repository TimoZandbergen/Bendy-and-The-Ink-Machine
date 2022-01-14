using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideDoor : MonoBehaviour
{
    public AnimationCurve openSpeedCurve = new AnimationCurve(new Keyframe[] { new Keyframe(0, 1, 0, 0), new Keyframe(0.8f, 1, 0, 0), new Keyframe(1, 0, 0, 0) }); 
    public float doorOpenAngle = 90.0f; 

    bool open = false;
    bool enter = false;
}
