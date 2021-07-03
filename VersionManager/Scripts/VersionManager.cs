using UnityEngine;
using UnityEngine.Serialization;

namespace UnityPlugins {
    public class VersionManager : MonoBehaviour {
        [FormerlySerializedAs("MainBuildDisableObjects"), SerializeField]
        private GameObject[] mainBuildDisableObjects = null;

        public void Awake() => DisableObjects();

        public void DisableObjects() {
            foreach (GameObject _gameObject in mainBuildDisableObjects) {
                _gameObject.SetActive(Debug.isDebugBuild);
            }
            return;
        }
    }
}