using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject welcomePanel;

    [SerializeField]
    private Button okButton;

    void Awake()
    {
        okButton.onClick.AddListener(Dismiss);
    }

    private void Dismiss() => welcomePanel.SetActive(false);

}
