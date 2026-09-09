using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerLastApproverGerenteJefeOrdersFill : ITimerExecutor {
        public const string TimerName = "TimerLastApproverGerenteJefeOrdersFill";
        public static readonly Guid TimerKey = Guid.Parse("8b37f6e4-4ab3-498d-a824-171470257c16");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "LastApproverGerenteJefeOrdersFill";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerLastApproverGerenteJefeOrdersFill (IApplicationLogger applicationLogger) {
            this.applicationLogger = applicationLogger;
        }

        /// <summary>
        /// Executes a timer action
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        public async Task ExecuteAsync(
            IRequestContext requestContext,
            CancellationToken cancellationToken = default
        ) {


            
try {
await Actions.ActionLastApproverGerenteJefeOrdersFill(requestContext,cancellationToken);
}
finally {
}

        }

        // TODO: EvaluateFields is used by the debugger
        public static void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
            variable.Found = false;
        }
    }

    public partial class ExtendedActions {
/// <summary>
/// Action: WakeTimerLastApproverGerenteJefeOrdersFill
/// </summary>

public static async Task WakeTimerLastApproverGerenteJefeOrdersFill(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerLastApproverGerenteJefeOrdersFill.TimerKey, cancellationToken);
return;
}

}

}
