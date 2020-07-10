using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asd : MonoBehaviour {
public Slider mySlider;
  public UnityEngine.UI.Slider slider ;
	
  
  public UnityEngine.UI.Image handle ;
 
  public void Start()
 
  {
  		
      mySlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
  }
 
  // Invoked when the value of the slider changes.
  public void ValueChangeCheck()
  {
      handle.color = Color.HSVToRGB(mySlider.value, 1, 1);
      }

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}

}
