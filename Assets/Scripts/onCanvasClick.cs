using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class onCanvasClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    [SerializeField]
    private Material skybox;
    //private Image image;
    private CanvasManager canvasManager;

    private void Start()
    {
        canvasManager = FindObjectOfType<CanvasManager>(); 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverExit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    void OnHoverEnter()
    {
        //bigger Scale
    }

    void OnHoverExit()
    {
        //scale back to original
    }

    void OnClick()
    {
        canvasManager.OnPanelClick(name);
        RenderSettings.skybox = skybox;

    }

}
