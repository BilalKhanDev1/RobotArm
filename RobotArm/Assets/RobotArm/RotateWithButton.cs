using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithButton : MonoBehaviour
{
    // Set joints and pose, you can set them in the inspector on the robotarm
    [SerializeField] private List<Transform> joints;
    [SerializeField] private List<float> poseValues;

    public void SetPose()
    {
        for (int i = 0; i < joints.Count; i++)
        {
            joints[i].localRotation = Quaternion.Euler(0, 0, poseValues[i]); 
        }
    }
}
