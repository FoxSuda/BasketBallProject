using Doozy.Runtime.UIManager.Components;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LanguageManager : MonoBehaviour
{
    [SerializeField] private UIButton englishButton;
    [SerializeField] private UIButton ukrainianButton;

    void Start()
    {
        englishButton.onClickEvent.AddListener(SetEnglish);
        ukrainianButton.onClickEvent.AddListener(SetUkrainian);
    }

    private void SetEnglish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("en");
    }

    private void SetUkrainian()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("uk");
    }

    private void OnDestroy()
    {
        englishButton.onClickEvent.RemoveListener(SetEnglish);
        ukrainianButton.onClickEvent.RemoveListener(SetUkrainian);
    }
}
