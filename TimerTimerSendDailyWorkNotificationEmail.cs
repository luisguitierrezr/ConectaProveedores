using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerSendDailyWorkNotificationEmail : ITimerExecutor {
        public const string TimerName = "TimerSendDailyWorkNotificationEmail";
        public static readonly Guid TimerKey = Guid.Parse("384e5b04-edad-4328-85ef-57cadaab04ca");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "SendDailyNotificationsEmail";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerSendDailyWorkNotificationEmail (IApplicationLogger applicationLogger) {
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
await Actions.ActionSendDailyNotificationsEmail(requestContext,cancellationToken);
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
/// Action: WakeTimerSendDailyWorkNotificationEmail
/// </summary>

public static async Task WakeTimerSendDailyWorkNotificationEmail(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerSendDailyWorkNotificationEmail.TimerKey, cancellationToken);
return;
}

}

}
