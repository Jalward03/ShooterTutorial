using UnityEngine;

namespace ThirdPersonShooter.UI
{
	public abstract class MenuBase : MonoBehaviour
	{
		public bool IsDefault => isDefault;
		public bool isVisile => gameObject.activeSelf;
		
		public abstract string ID { get; }
		[SerializeField] private bool isDefault;

		public void SetVisible(bool _visisble) => gameObject.SetActive(_visisble);

		public virtual void OnOpenMenu(UIManager _manager) { }
		public virtual void OnCloseMenu(UIManager _manager) { }
	}
}