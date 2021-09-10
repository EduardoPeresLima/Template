using System.Collections;
using UnityEngine;

namespace Splashes
{
    public abstract class Splash : ScriptableObject
    {
        public float TimeLife { get; protected set; }
        public abstract IEnumerator PlaySplash(GameObject obj);
    }
}