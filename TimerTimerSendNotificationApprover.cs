using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerSendNotificationApprover : ITimerExecutor {
        public const string TimerName = "TimerSendNotificationApprover";
        public static readonly Guid TimerKey = Guid.Parse("8c94b468-48ef-4d8f-b5b5-03cb57e498e8");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerSendNotificationApprover";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerSendNotificationApprover (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerSendNotificationApprover(requestContext,cancellationToken);
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
/// Action: WakeTimerSendNotificationApprover
/// </summary>

public static async Task WakeTimerSendNotificationApprover(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerSendNotificationApprover.TimerKey, cancellationToken);
return;
}

}

}
