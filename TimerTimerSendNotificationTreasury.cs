using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerSendNotificationTreasury : ITimerExecutor {
        public const string TimerName = "TimerSendNotificationTreasury";
        public static readonly Guid TimerKey = Guid.Parse("9e11d749-7552-4163-a7ba-2fe6c5008099");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerSendNotificationTreasury";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerSendNotificationTreasury (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerSendNotificationTreasury(requestContext,cancellationToken);
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
/// Action: WakeTimerSendNotificationTreasury
/// </summary>

public static async Task WakeTimerSendNotificationTreasury(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerSendNotificationTreasury.TimerKey, cancellationToken);
return;
}

}

}
