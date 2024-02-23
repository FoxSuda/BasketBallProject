using UnityEngine;

namespace UnityTask.BasketballProject
{
    [CreateAssetMenu(menuName = "Game/Configs/Shop configuration", fileName = "Shop configuration")]
    public class SkinConfiguration : ScriptableObject
    {
        [SerializeField] private int skinPrice = 200;
        [SerializeField] private Material skinMaterial;
        [SerializeField] private Texture2D skinImage;
        [SerializeField] private bool skinBought = false;

        public int SkinPrice { get => skinPrice; set => skinPrice = value; }
        public Material SkinMaterial { get => skinMaterial; set => skinMaterial = value; }
        public Texture2D SkinImage { get => skinImage; set => skinImage = value; }
        public bool SkinBought { get => skinBought; set => skinBought = value; }
    }
}

