using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Splashes
{
    [CreateAssetMenu(fileName = "SplashImage", menuName = "Splash/Splash Image")]
    public class SplashImage : Splash
    {
        [SerializeField] private Sprite splashImage;
        public float TimeFadeIn = 1.5f;
        public float TimeFadeOut = 2.5f;

        public override IEnumerator PlaySplash(GameObject obj)
        {
            TimeLife = TimeFadeIn + TimeFadeOut;
            Image objImage = obj.GetComponent<Image>();
            objImage.sprite = splashImage;
            objImage.canvasRenderer.SetAlpha(0.0f);
            objImage.CrossFadeAlpha(1.0f, TimeFadeIn, false);
            yield return new WaitForSeconds(TimeFadeIn);
            
            objImage.CrossFadeAlpha(0.0f, TimeFadeOut, false);
            yield return new WaitForSeconds(TimeFadeOut);
        }
    }
}