using UnityEngine;

namespace UnityPlugins {
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T> {
        private static T instance = null;

        public static T Instance {
            get {
                EnsureSingleton();
                return instance;
            }
        }

        public static T FastInstance => instance;

        private static void EnsureSingleton() {
            if (instance == null) {
                instance = FindObjectOfType<T>();

                if (instance == null) {
                    GameObject newGameObject = new GameObject {
                        name = $"{typeof(T)} singleton"
                    };

                    instance = newGameObject.AddComponent<T>();
                }
            }

            DontDestroyOnLoad(instance);
            return;
        }
        
        protected virtual void Awake() {
            EnsureSingleton();
            return;
        }

        protected virtual void OnDestroy() => instance = null;
    }
}