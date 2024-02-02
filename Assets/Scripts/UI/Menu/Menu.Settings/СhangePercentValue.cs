using Doozy.Runtime.Reactor;
using Doozy.Runtime.UIManager.Components;
using UnityEngine;

public class ÑhangePercentValue : MonoBehaviour
{

    [SerializeField] Progressor percentValueText;
    [SerializeField] UISlider sliderValueText;

    private void Awake()
    {
        ChangeObjectValue();
    }

    public void ChangeObjectValue()
    {
        percentValueText.SetValueAt(sliderValueText.value);
    }
}
