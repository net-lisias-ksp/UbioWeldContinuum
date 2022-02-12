using UnityEngine;
using KSP.UI.Screens;

using KSPe.Annotations;
using Toolbar = KSPe.UI.Toolbar;
using Asset = KSPe.IO.Asset<UbioWeldingLtd.ToolbarController>;
using System.Collections.Generic;

namespace UbioWeldingLtd
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	public class ToolbarController:MonoBehaviour
	{
		private static ToolbarController instance;
		internal static ToolbarController Instance => instance;
		private Toolbar.Toolbar controller => Toolbar.Controller.Instance.Get<ToolbarController>();

		[UsedImplicitly]
		private void Awake()
		{
			instance = this;
			DontDestroyOnLoad(this);
		}

		[UsedImplicitly]
		private void Start()
		{
			Toolbar.Controller.Instance.Register<ToolbarController>(Version.FriendlyName);
		}

		// State controller for the toobar button
		private class WindowState:KSPe.UI.Toolbar.State.Status<bool> { protected WindowState(bool v):base(v) { }  public static implicit operator WindowState(bool v) => new WindowState(v);   public static implicit operator bool(WindowState s) => s.v; }
		private Toolbar.State.Control windowState;
		private Toolbar.Button button = null;

		private bool state = false;
		internal bool IsRegistered { get; private set; }
		internal event Callback OnTrue = delegate { };
		internal event Callback OnFalse = delegate { };
		internal event Callback OnAlternateClick = delegate { };
		internal const string ICON_DIR = "Textures";
		private static UnityEngine.Texture2D launcher = null;
		private static UnityEngine.Texture2D toolbar = null;

		internal void Register()
		{
			launcher			= launcher			?? (launcher = Asset.Texture2D.LoadFromFile(ICON_DIR, "ToolbarLargeIcon"));
			toolbar				= toolbar			?? (toolbar = Asset.Texture2D.LoadFromFile(ICON_DIR, "ToolbarSmallIcon"));
			this.button = Toolbar.Button.Create(this
					, ApplicationLauncher.AppScenes.VAB | ApplicationLauncher.AppScenes.SPH
					, launcher
					, toolbar
					, Version.FriendlyName
				);

			windowState = this.button.State.Controller.Create<WindowState>(
				new Dictionary<Toolbar.State.Status, Toolbar.State.Data> {
							{ (WindowState)false, Toolbar.State.Data.Create(launcher, toolbar) }
							,{ (WindowState)true, Toolbar.State.Data.Create(launcher, toolbar) }
				}
			);

			this.button.Mouse.Add(Toolbar.Button.MouseEvents.Kind.Left, this.Button_OnLeftClick);
			this.button.Mouse.Add(Toolbar.Button.MouseEvents.Kind.Right, this.Button_OnRightClick);
			this.controller.Add(this.button);
			this.controller.ButtonsActive(true, true);
			this.IsRegistered = true;
		}

		internal void Unregister()
		{
			this.OnTrue.Clear();
			this.OnFalse.Clear();
			this.OnAlternateClick.Clear();
			this.controller.Destroy();
			this.button = null;
			this.IsRegistered = false;
		}

		internal void Button_OnLeftClick()
		{
			Log.dbg("Left Click!!!");
			this.state = !this.state;

			if (state) this.OnTrue();
			else this.OnFalse();
		}

		internal void Button_OnRightClick()
		{
			Log.dbg("Right Click!!!");
			this.OnAlternateClick();
		}
	}
}
