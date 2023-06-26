using UnityEngine;

namespace UbioWeldingLtd
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    internal class Startup : MonoBehaviour
    {
        private void Start()
        {
            Log.log("Version {0}", Version.Text);

            try
            {
                KSPe.Util.Installation.Check<Startup>();
            }
            catch (KSPe.Util.InstallmentException e)
            {
                Log.ex(this, e);
                KSPe.Common.Dialogs.ShowStopperAlertBox.Show(e);
            }
        }
    }
}
