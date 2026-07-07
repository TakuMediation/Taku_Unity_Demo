using UnityEditor;
using UnityEngine;

namespace AnyThink.Scripts.IntegrationManager.Editor
{
    public class AnyThinkMenuItems : MonoBehaviour
    {
        [MenuItem("AnyThink/SDK Manager %#t")]
        private static void IntegrationManager()
        {
            ATIntegrationManagerWindow.ShowManager();
        }

        [MenuItem("AnyThink/Documentation")]
        public static void Documentation()
        {
            Application.OpenURL("https://newdocs.toponad.com/docs/lgfbO4");
        }
    }
}
