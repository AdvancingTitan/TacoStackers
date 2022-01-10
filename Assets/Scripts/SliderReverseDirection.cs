using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderDir : MonoBehaviour
{
    public Slider mainSlider;

    public void Start()
    {
        //Changes the direction of the slider.
        if (mainSlider.direction == Slider.Direction.BottomToTop)
        {
            mainSlider.direction = Slider.Direction.TopToBottom;
        }
    }
}