using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : IRifle
{
    protected IRifle m_DecoratedRifle;

    //constructor
    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }
}

public class WithScope : RifleDecorator, IRifle
{
    private float m_ScopeAccuracy = 20.0f;

    //Constructor
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStabilizer : RifleDecorator, IRifle
{
    private float m_StabilizerAccuracy = 10.0f;

    public WithStabilizer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}

public class WithLasers : RifleDecorator, IRifle
{
    private float m_LaserAccuracy = 7.0f;

    public WithLasers(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_LaserAccuracy;
    }
}

public class WithBayonette : RifleDecorator, IRifle
{
    private float m_BayonetteAccuracy = 1.0f;

    public WithBayonette(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_BayonetteAccuracy;
    }
}