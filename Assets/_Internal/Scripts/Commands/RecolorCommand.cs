using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Game.Commands
{
    public class RecolorCommand : BaseCommand
    {
        [SerializeField] private Renderer _target;
        [SerializeField] private Color _toValue;
        
        public override async UniTask ExecuteAsync(CancellationToken token)
        {
            // Not best way of change color for material, because it creates new unshared material everytime
            // But I'm not sure about purpose of doing it, so let's leave as it is
            await _target.material.DOColor(_toValue, _duration).ToUniTask(cancellationToken: token);
        }
    }
}