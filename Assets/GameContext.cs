﻿using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

public class GameContext : MVCSContext
{
    public GameContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
    {
        
    }    
}
