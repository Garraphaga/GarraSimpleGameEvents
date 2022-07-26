using UnityEngine;

namespace Garra.SSGE.Tests
{
    public class RedCube : MonoBehaviour
    {
        [SerializeField] ObjectGameEvent _objectGameEventHandler;
        void Start()
        {
            _objectGameEventHandler?.AddEventListener(OnGameEventListened);
        }

        private void OnGameEventListened(Object gameObject)
        {
            Debug.Log(this.name + " reaction to event " + _objectGameEventHandler.name + " whit argument " + gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
