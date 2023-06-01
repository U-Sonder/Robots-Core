using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Game.Commands
{
    public class RotateCommand : BaseCommand
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _toValue;
        
        public override async UniTask ExecuteAsync()
        {
            await _target.DORotate(_toValue, _duration).ToUniTask();
        }
    }
}