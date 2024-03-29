using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    public virtual void OnValueChanged(int value, int maxValue)
    {
        Slider.value = (float)value / maxValue;
    }

    public float GetSliderValue()
    {
        return Slider.value;
    }
}
