using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Splashes
{
    public class SplashesManager : MonoBehaviour
    {
        [SerializeField] private List<Splash> splashes;
        [SerializeField] private GameObject splashObject;
        [SerializeField] private SceneAsset mainMenuScene;
        private void Start() => StartCoroutine(PlayAllSplashes());

        private IEnumerator PlayAllSplashes()
        {
            foreach (Splash splash in splashes)
            {
                StartCoroutine(splash.PlaySplash(splashObject));
                print(splash.TimeLife);
                yield return new WaitForSeconds(splash.TimeLife);
            }
            GoToMenu();
        }

        private void GoToMenu() => SceneManager.LoadScene(mainMenuScene.name);
    }
}