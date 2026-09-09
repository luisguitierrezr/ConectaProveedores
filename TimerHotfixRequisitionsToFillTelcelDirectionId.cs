using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerHotfixRequisitionsToFillTelcelDirectionId : ITimerExecutor {
        public const string TimerName = "HotfixRequisitionsToFillTelcelDirectionId";
        public static readonly Guid TimerKey = Guid.Parse("6b89ec35-1fe7-4a00-9b98-cf08c59b0d7b");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "HotfixRequisitionsToFillTelcelDirectionId";

        private readonly IApplicationLogger applicationLogger;

        public TimerHotfixRequisitionsToFillTelcelDirectionId (IApplicationLogger applicationLogger) {
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
await Actions.ActionHotfixRequisitionsToFillTelcelDirectionId(requestContext,cancellationToken);
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
/// Action: WakeHotfixRequisitionsToFillTelcelDirectionId
/// </summary>

public static async Task WakeHotfixRequisitionsToFillTelcelDirectionId(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerHotfixRequisitionsToFillTelcelDirectionId.TimerKey, cancellationToken);
return;
}

}

}
