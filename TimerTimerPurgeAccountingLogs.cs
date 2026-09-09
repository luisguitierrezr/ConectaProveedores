using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerPurgeAccountingLogs : ITimerExecutor {
        public const string TimerName = "TimerPurgeAccountingLogs";
        public static readonly Guid TimerKey = Guid.Parse("b953d068-6f7b-4d22-8a54-51c795f41068");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "AccountingLogs_Purge";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerPurgeAccountingLogs (IApplicationLogger applicationLogger) {
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
await Actions.ActionAccountingLogs_Purge(requestContext,cancellationToken);
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
/// Action: WakeTimerPurgeAccountingLogs
/// </summary>

public static async Task WakeTimerPurgeAccountingLogs(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerPurgeAccountingLogs.TimerKey, cancellationToken);
return;
}

}

}
