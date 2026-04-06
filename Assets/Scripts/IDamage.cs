using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    
    int health { get; set; }

    void TakeDamage();

}
