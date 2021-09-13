using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEditor.SearchService;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    [SerializeField] private List<SceneAsset> levelsScenes;
    [SerializeField] private Transform content;
    [SerializeField] private GameObject prefabButton;
    void Start()
    {
        foreach (SceneAsset level in levelsScenes)
        {

            GameObject buttonInstance = Instantiate(prefabButton, content);
            TextMeshProUGUI buttonText = buttonInstance.GetComponentInChildren<TextMeshProUGUI>();
            Button button = buttonInstance.GetComponent<Button>();

            buttonInstance.name = level.name;
            buttonText.text = level.name;
            button.onClick.AddListener(delegate { LoadScene(level.name); });
        }
    }
    
    
    private static void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);

}
