using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerCreatePolizaDocumentRelation : ITimerExecutor {
        public const string TimerName = "TimerCreatePolizaDocumentRelation";
        public static readonly Guid TimerKey = Guid.Parse("9101b317-4716-4e6d-8386-5cb66a61255e");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "Timer_InvoiceDocRelationSendNew";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerCreatePolizaDocumentRelation (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimer_InvoiceDocRelationSendNew(requestContext,cancellationToken);
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
/// Action: WakeTimerCreatePolizaDocumentRelation
/// </summary>

public static async Task WakeTimerCreatePolizaDocumentRelation(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerCreatePolizaDocumentRelation.TimerKey, cancellationToken);
return;
}

}

}
