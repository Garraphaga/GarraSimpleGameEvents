using UnityEngine;
using UnityEngine.UI;

namespace Garra.SSGE.Tests
{
    public class BlueCube : MonoBehaviour
    {
        [SerializeField] ObjectGameEvent _objectGameEvent;
        [SerializeField] Button button;

        private void OnEnable()
        {
            button.onClick.AddListener(DoRaise);
        }

        private void DoRaise()
        {
            _objectGameEvent.Raise(this);
        }
    }
}