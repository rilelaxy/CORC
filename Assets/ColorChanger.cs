using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Button colorChangeButton;
    public List<Color> colorList = new List<Color>
    {
        new Color(59f / 255f, 34f / 255f, 25f / 255f),    
        new Color(67f / 255f, 43f / 255f, 21f / 255f),     
        new Color(141f / 255f, 85f / 255f, 36f / 255f),   
        new Color(198f / 255f, 134f / 255f, 66f / 255f),  
        new Color(224f / 255f, 172f / 255f, 105f / 255f),  
        new Color(212f / 255f, 170f / 255f, 120f / 255f),
        new Color(241f / 255f, 194f / 255f, 125f / 255f),
        new Color(255f / 255f, 208f / 255f, 143f / 255f),  
        new Color(255f / 255f, 219f / 255f, 172f / 255f),  
        new Color(255f / 255f, 233f / 255f, 203f / 255f) 
    };

    private int currentColorIndex = 0;

    private void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the GameObject.");
        }

        colorChangeButton.onClick.AddListener(ChangeColor);
    }

    private void ChangeColor()
    {
        spriteRenderer.color = colorList[currentColorIndex];

        currentColorIndex = (currentColorIndex + 1) % colorList.Count;
    }
}