using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerExpireDataCaptureRequisitions : ITimerExecutor {
        public const string TimerName = "TimerExpireDataCaptureRequisitions";
        public static readonly Guid TimerKey = Guid.Parse("123989b9-ca47-46bc-9c9c-40ebe9af69ea");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerExpireDataCaptureRequisitions";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerExpireDataCaptureRequisitions (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerExpireDataCaptureRequisitions(requestContext,cancellationToken);
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
/// Action: WakeTimerExpireDataCaptureRequisitions
/// </summary>

public static async Task WakeTimerExpireDataCaptureRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerExpireDataCaptureRequisitions.TimerKey, cancellationToken);
return;
}

}

}
