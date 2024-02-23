using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTask.BasketballProject
{
    public class MuteButtonVisual : MonoBehaviour
    {
        [SerializeField] private Texture2D _iconMute;
        [SerializeField] private Texture2D _iconUnmute;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _text;

        public void ChangeButtonVisual(bool muted)
        {
            if (muted)
            {
                _text.text = "Unmute";
                _image.sprite = Sprite.Create(_iconUnmute, new Rect(0, 0, _iconUnmute.width, _iconUnmute.height), new Vector2(0.5f, 1f));
            } else
            {
                _text.text = "Mute";
                _image.sprite = Sprite.Create(_iconMute, new Rect(0, 0, _iconMute.width, _iconMute.height), new Vector2(0.5f, 1f));
            }
        }
    }
}

