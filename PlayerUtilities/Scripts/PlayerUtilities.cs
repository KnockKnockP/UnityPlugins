using UnityEngine;

namespace UnityPlugins {
    public struct PlayerUtilities {
        public static Vector2 MouseToWorld(Vector2 mousePosition, Camera camera) {
            return camera.ScreenToWorldPoint(mousePosition);
        }
    }
}