using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing.Utilities;

using UnityEngine.UI;
public class chroma : MonoBehaviour {
	public PostProcessingController myEffects;
    public Camera UICam;
    public Slider mainSlider;
 
    void Start () {
        UICam = GameObject.Find ("UICamera").GetComponent<Camera> ();
        myEffects = UICam.GetComponent<PostProcessingController> ();
    }
 
    void Update () {
        //myEffects.chromaticAberration.intensity = chromaticAberrationCurve.Evaluate (chromaticAberrationCurveTime);
		myEffects.colorGrading.basic.hueShift=mainSlider.value;
     }
     public void changeVal (float newVal)
	{
		mainSlider.value=newVal;
	}

}
