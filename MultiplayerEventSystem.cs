using UnityEngine.EventSystems;
using UnityEngine;

public class MultiplayerEventSystem : EventSystem
{

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    protected override void Update()
    {
        EventSystem originalCurrent = null;
        current = this;
        base.Update();
        current = originalCurrent;
    }
}
