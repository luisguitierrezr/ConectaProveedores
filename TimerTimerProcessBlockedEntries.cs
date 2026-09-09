using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerProcessBlockedEntries : ITimerExecutor {
        public const string TimerName = "TimerProcessBlockedEntries";
        public static readonly Guid TimerKey = Guid.Parse("55b5a328-2c1f-41df-949c-4e09687ec6a1");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "Entry_CallBlocked";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerProcessBlockedEntries (IApplicationLogger applicationLogger) {
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
await Actions.ActionEntry_CallBlocked(requestContext,cancellationToken);
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
/// Action: WakeTimerProcessBlockedEntries
/// </summary>

public static async Task WakeTimerProcessBlockedEntries(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerProcessBlockedEntries.TimerKey, cancellationToken);
return;
}

}

}
