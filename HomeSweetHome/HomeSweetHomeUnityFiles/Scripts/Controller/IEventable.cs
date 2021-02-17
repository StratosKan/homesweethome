using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEventable
{
    void EventTime();
    IEnumerator TimeBeforEvent();
}
