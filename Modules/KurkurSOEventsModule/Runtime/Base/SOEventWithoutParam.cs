using Modules.KurkurSOEventsModule.Runtime.Base;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Modules.KurkurSOEventsModule.Runtime
{
    [CreateAssetMenu(menuName = "Kurkur/SO Events/Without Param")]
    public class SOEventWithoutParam : SOEventBase
    {
        private UnityEvent _event = new UnityEvent();

        public void AddListener(UnityAction action)
        {
            _event.AddListener(action);
        }

        public void RemoveListener(UnityAction action)
        {
            _event.RemoveListener(action);
        }

        public void RemoveAllListener()
        {
            _event.RemoveAllListeners();
        }

        [Button]
        public void Invoke()
        {
            _event.Invoke();
        }
    }
}