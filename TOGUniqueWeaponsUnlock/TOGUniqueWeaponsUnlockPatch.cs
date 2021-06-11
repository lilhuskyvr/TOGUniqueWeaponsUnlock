using TOGModFramework;
using UnityEngine;

namespace TOGUniqueWeaponsUnlock
{
    public class TOGUniqueWeaponsUnlockPatch : MonoBehaviour
    {
        public void Inject()
        {
            EventManager.OnPlayerLoaded += EventManagerOnOnPlayerLoaded;
        }

        private void EventManagerOnOnPlayerLoaded()
        {
            for (int i = 0; i < ConfigManager.local.spw.Length; i++)
            {
                ConfigManager.local.spw[i] = 1;
            }
        }
    }
}