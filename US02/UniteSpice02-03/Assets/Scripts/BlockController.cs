﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public void DestroyBlock()
    {
        Destroy(gameObject);
    }
}
