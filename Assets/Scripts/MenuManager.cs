using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private SceneAsset levelsMenuScene;
    [SerializeField] private SceneAsset configurationsScene;
    [SerializeField] private SceneAsset creditsScene;

    public void LoadLevelsMenu() => LoadScene(levelsMenuScene.name);
    public void LoadConfigurations() => LoadScene(configurationsScene.name);
    public void LoadCredits() => LoadScene(creditsScene.name);
    private static void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
