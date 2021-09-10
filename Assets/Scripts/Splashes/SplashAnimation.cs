using System.Collections;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Splashes
{
    [CreateAssetMenu(fileName = "SplashAnimation", menuName = "Splash/Splash Animation")]
    public class SplashAnimation : Splash
    {
        public AnimatorController animatorController;
        
        public override IEnumerator PlaySplash(GameObject obj)
        {
            obj.GetComponent<Image>().CrossFadeAlpha(1,0,false);
            TimeLife = animatorController.animationClips[0].length + .5f;
            Animator animator = obj.GetComponent<Animator>();
            animator.runtimeAnimatorController = animatorController;
            animator.enabled = true;
            animator.Play(0);
            yield return new WaitForSeconds(TimeLife);
            animator.enabled = false;
        }
    }
}