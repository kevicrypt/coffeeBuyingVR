using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class updatePrice : MonoBehaviour
{
    public Slider slider;
    public TMP_Text orderPriceText;
    public TMP_Text tipText;
    public TMP_Text totalPriceText;

    public float orderPrice = 3.0f;
    private float tipAmount = 0.0f;
    private float totalPrice = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        orderPriceText.text = "Your Order Price: " + orderPrice.ToString() + " €";
    }

    // Update is called once per frame
    void Update()
    {
        tipAmount = slider.value / 10;
        totalPrice = tipAmount + orderPrice;
        tipText.text = "Tip: " + tipAmount.ToString() + " €";
        totalPriceText.text = "Total Price: " + totalPrice.ToString() + " €";

    }
}
