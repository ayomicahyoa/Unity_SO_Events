using Modules.KurkurSOEventsModule.Runtime.Base;
using Sirenix.OdinInspector;
using UnityEngine.Events;

namespace Modules.KurkurSOEventsModule.Runtime
{
    public class SOEventOneParamBase<param> : SOEventBase
    {
        private UnityEvent<param> _event = new UnityEvent<param>();

        public virtual void AddListener(UnityAction<param> action)
        {
            _event.AddListener(action);
        }

        public virtual void RemoveListener(UnityAction<param> action)
        {
            _event.RemoveListener(action);
        }

        public void RemoveAllListener()
        {
            _event.RemoveAllListeners();
        }

        [Button]
        public void Invoke(param value)
        {
            _event.Invoke(value);
        }
    }
}