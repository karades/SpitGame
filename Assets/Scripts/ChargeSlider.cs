using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeSlider : MonoBehaviour
{
    public PlayerMovement charger;
    public Slider chargeSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chargeSlider.value = charger.chargeShot;
        chargeSlider.maxValue = 600.0f;
    }
}
