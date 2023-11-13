using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HairColorChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Button hairColorChangeButton;

       public List<Color> colorList = new List<Color>
    {
        new Color(52f / 255f, 31f / 255f, 10f / 255f),     
        new Color(138f / 255f, 96f / 255f, 48f / 255f),     
        new Color(164f / 255f, 122f / 255f, 63f / 255f),   
        new Color(167f / 255f, 98f / 255f, 255f / 255f),    
        new Color(255f / 255f, 254f / 255f, 208f / 255f),   
        new Color(128f / 255f, 79f / 255f, 27f / 255f),     
        new Color(96f / 255f, 46f / 255f, 13f / 255f),      
        new Color(227f / 255f, 152f / 255f, 80f / 255f), 
        new Color(108f / 255f, 126f / 255f, 255f / 255f),  
        new Color(158f / 255f, 131f / 255f, 105f / 255f), 
        new Color(113f / 255f, 73f / 255f, 44f / 255f),     
        new Color(82f / 255f, 60f / 255f, 40f / 255f),      
        new Color(254f / 255f, 255f / 255f, 141f / 255f),   
        new Color(55f / 255f, 37f / 255f, 27f / 255f),      
        new Color(255f / 255f, 244f / 255f, 189f / 255f),   
        new Color(169f / 255f, 33f / 255f, 17f / 255f),   
        new Color(255f / 255f, 255f / 255f, 255f / 255f), 
        new Color(195f / 255f, 195f / 255f, 195f / 255f) 
    };

    
    private int currentColorIndex = 0;

    private void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();

       
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the GameObject.");
        }

       
        hairColorChangeButton.onClick.AddListener(HairChangeColor);
    }

    
    private void HairChangeColor()
    {

        spriteRenderer.color = colorList[currentColorIndex];

       
        currentColorIndex = (currentColorIndex + 1) % colorList.Count;
    }
}
