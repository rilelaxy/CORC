using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
    public GameObject customizationObject;
    public Sprite[] options;
    public Button changeButton;

    private int currentIndex = 0;

    private void Start()
    {
        currentIndex = PlayerPrefs.GetInt("CustomizationIndex", 0);

        changeButton.onClick.AddListener(ChangeCustomization);
        UpdateCustomizationSprite();
    }

    private void ChangeCustomization()
    {
        currentIndex = (currentIndex + 1) % options.Length;
        UpdateCustomizationSprite();

        PlayerPrefs.SetInt("CustomizationIndex", currentIndex);
        PlayerPrefs.Save();
    }

    public void ApplyCustomization(int customizationIndex)
    {
        currentIndex = customizationIndex;
        UpdateCustomizationSprite();
    }

    private void UpdateCustomizationSprite()
    {
        if (currentIndex >= 0 && currentIndex < options.Length)
        {
            customizationObject.GetComponent<SpriteRenderer>().sprite = options[currentIndex];
        }
    }
}
