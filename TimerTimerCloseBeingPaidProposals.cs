using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerCloseBeingPaidProposals : ITimerExecutor {
        public const string TimerName = "TimerCloseBeingPaidProposals";
        public static readonly Guid TimerKey = Guid.Parse("400a6bcd-d4cc-44ce-83a5-44daa159e4b7");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerCancelPartiallyPaidProposals";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerCloseBeingPaidProposals (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerCancelPartiallyPaidProposals(requestContext,cancellationToken);
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
/// Action: WakeTimerCloseBeingPaidProposals
/// </summary>

public static async Task WakeTimerCloseBeingPaidProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerCloseBeingPaidProposals.TimerKey, cancellationToken);
return;
}

}

}
