using UnityEngine;
    using UnityEngine.PostProcessing;
    using UnityEngine.UI;

    public class hueFromSlider : MonoBehaviour 
    {
        public PostProcessingProfile profile; // A reference to the profile
        ColorGradingModel model; // The color grading model
        ColorGradingModel.Settings settings; // The color grading model settings.

        public Slider slider; // A reference to the slider so that on start it goes back to were it was.

        private void Start()
        {
            model = profile.colorGrading; // Set the model
            settings = model.settings; // Set the settings
            if (slider != null) // Set the slider back to what it was only if it has been referenced.
                slider.value = settings.basic.hueShift;
        }

        public void ChangeHue(float hue)
        {
            settings.basic.hueShift = hue; // Set the hue in the settings
            model.settings = settings; // Set the settings of the model
            profile.colorGrading = model; // set the profile model to the model
        }
    }