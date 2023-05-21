using Modules.KurkurSOEventsModule.Runtime;
using UnityEngine;

public class SampleEventReceiver : MonoBehaviour
{
    [SerializeField]
    private SOEventFloat _sampleFloatEvent;

    [SerializeField]
    private SOEventString _sampleStringEvent;

    private void Awake()
    {
        _sampleFloatEvent.AddListener(ListenFloat);
        _sampleStringEvent.AddListener(ListenString);
    }

    private void OnDestroy()
    {
        _sampleFloatEvent.RemoveAllListener();
        _sampleStringEvent.RemoveAllListener();
    }

    private void ListenFloat(float value)
    {
        Debug.LogFormat($"Float Value Listened : {value}");
    }

    private void ListenString(string value)
    {
        Debug.LogFormat($"String Value Listened : {value}");
    }
}
