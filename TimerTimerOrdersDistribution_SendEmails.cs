using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerOrdersDistribution_SendEmails : ITimerExecutor {
        public const string TimerName = "TimerOrdersDistribution_SendEmails";
        public static readonly Guid TimerKey = Guid.Parse("b535a064-9310-46bd-945d-671fd8bd6abc");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "OrdersDistribution_SendEmails";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerOrdersDistribution_SendEmails (IApplicationLogger applicationLogger) {
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
await Actions.ActionOrdersDistribution_SendEmails(requestContext,0L,cancellationToken);
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
/// Action: WakeTimerOrdersDistribution_SendEmails
/// </summary>

public static async Task WakeTimerOrdersDistribution_SendEmails(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerOrdersDistribution_SendEmails.TimerKey, cancellationToken);
return;
}

}

}
