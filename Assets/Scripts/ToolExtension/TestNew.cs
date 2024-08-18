using System;
using System.Collections;
using ToolExtension.ObserverPattern;
using UnityEngine;

namespace ToolExtension
{
    public class TestNew : MonoBehaviour
    {

        private IEnumerator InitPool()
        {
            var count = 0;
            while (count++ < 10)
            {
                for (int i = 0; i < 100; i++)
                {
                
                }

                yield return null;
            }
            
        }
    }
}