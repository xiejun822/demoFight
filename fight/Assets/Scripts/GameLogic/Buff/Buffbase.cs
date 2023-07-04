using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BuffBase
{
    private double _bufftime = 0;
    private int _buffCount = 0;
    public double Bufftime { get => _bufftime; set => _bufftime = value; }
    public int BuffCount { get => _buffCount; set => _buffCount = value; }

    
    public virtual void EnterBuff() { }
    public virtual void ExitBuff() { }
    
}


