using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game.Commands
{
    [Serializable]
    public abstract class BaseCommand : MonoBehaviour, ICommand
    {
        [SerializeField, Min(0.0f)] protected float _duration;

        public abstract UniTask ExecuteAsync();
    }
}