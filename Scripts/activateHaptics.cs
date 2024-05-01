using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class activateHaptics : MonoBehaviour
{
    public XRDirectInteractor leftXrDirectInteractor;
    public XRDirectInteractor rightXrDirectInteractor;
    // Start is called before the first frame update
    void Start()
    {
        leftXrDirectInteractor.playHapticsOnHoverEntered = true;
        rightXrDirectInteractor.playHapticsOnHoverEntered = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
