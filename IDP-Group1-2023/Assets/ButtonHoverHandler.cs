using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image buttonImage;
    public float hoverAlpha = 0.8f;
    private Color originalColor;

    private void Start()
    {
        // Store the original color of the button image
        originalColor = buttonImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Reduce the transparency (alpha) of the button image
        Color hoverColor = originalColor;
        hoverColor.a = hoverAlpha;
        buttonImage.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Restore the original transparency (alpha) of the button image
        buttonImage.color = originalColor;
    }
}
