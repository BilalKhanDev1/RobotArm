using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWIthSlider : MonoBehaviour
{
    // Set object to rotate (joint) in the inspector
    [SerializeField] private GameObject objectToRotate;

    private float previousValue = 0;
    private Slider slider; 

    // Runs on start from object
    private void Start()
    {
        //Get the slider
        this.slider = this.GetComponent<Slider>();

        // Set value to 0 on start
        this.previousValue = 0;

        //Add listener to slider
        this.slider.onValueChanged.AddListener(this.OnSliderChanged);

        //Set value to slider value
        this.previousValue = this.slider.value;
    }

    void OnSliderChanged(float value)
    {
        // Caculate the difference between value and previous value
        float delta = value - this.previousValue;

        // Rotate the object
        this.objectToRotate.transform.Rotate(Vector3.back * delta * 360);

        // Set previous value with current value
        this.previousValue = value;
    }
}
