using Game.Commands;
using UnityEngine;

namespace Game
{
    public class Instruction : MonoBehaviour
    {
        [SerializeField] private ICommand _commands;
    }
}