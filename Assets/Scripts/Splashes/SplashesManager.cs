using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Splashes
{
    public class SplashesManager : MonoBehaviour
    {
        [SerializeField] private List<Splash> splashes;
        [SerializeField] private GameObject splashObject;
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

        private static void GoToMenu() => SceneManager.LoadScene("MainMenu");
    }
}