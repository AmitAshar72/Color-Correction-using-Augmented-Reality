/*using UnityEngine;
 using System.Collections;
using System.Collections.Generic;
 using UnityEngine.UI;
 public static UnityEngine.Camera; // Required when Using UI elements.
 
 public class hueS : MonoBehaviour
 {
     public Slider mainSlider;
     public Light directionalLight;
     public Camera arCam;
     float H, S, V;
 
 public void Start()
     {
     	sh
         Color.RGBToHSV(arCam.color, out H, out S, out V);
         //Adds a listener to the main slider and invokes a method when the value changes.
         mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
     }
 
     // Invoked when the value of the slider changes.
     public void ValueChangeCheck()
     {
         arCam.color= Color.HSVToRGB(mainSlider.value,S,V);
         Debug.Log(mainSlider.value);
     }
 }*/