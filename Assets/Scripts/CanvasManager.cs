using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    [SerializeField]
    private GameObject backButton;

    [SerializeField]
    private GameObject panels;

    private List<GameObject> panelsList = new();

    private Dictionary<GameObject, GameObject> subPanels = new();

    private GameObject activePanel;



    private void Awake()
    {
        
        foreach (Transform child in panels.transform)
        {
            panelsList.Add(child.gameObject);
        }
        
        foreach (var panel in panelsList)
        {
            string name = panel.name + "SubPanels";
            GameObject subPanel = GameObject.Find(name);         
            if (subPanel == null)
            {
                return;
            }
            subPanels[panel] = subPanel;
            subPanel.SetActive(false);
        }

    }
    public void OnPanelClick(string activePanelName)
    {
        panels.SetActive(false);
        backButton.SetActive(true);
        searchActivePanel(activePanelName);
        subPanels[activePanel].SetActive(true);
    }
    public void OnBackClick()
    {
        panels.SetActive(true);
        backButton.SetActive(false);
        subPanels[activePanel].SetActive(false);
    }
    private void searchActivePanel(string activePanelName)
    {
        foreach (GameObject i in subPanels.Keys)
        {
            if (i.name == activePanelName)
            {
                activePanel = i;
            }
        }
    }
}
