using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shiftHue : MonoBehaviour {
	//float H=0f;
	public Slider mainSlider;
	float H,S,V = 0f;

		
	// Update is called once per frame
	void Update () {
	Color.HSVToRGB(mainSlider.value, S,V);
		
	}
	//public void adjustHue (float newHue){
	//	mainSlider.value=newHue;
	//}
}

