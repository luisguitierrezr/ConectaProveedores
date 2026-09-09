using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("87d51710-2b55-47b8-bf1b-f39d8d936a60", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler3_c9c5d14b7a4c4eac871c90b0dfd87b18 : AbstractEventSubscriber<EventPayloads.GlobalEventOnGenerateInvoiceReportPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler3_c9c5d14b7a4c4eac871c90b0dfd87b18(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnGenerateInvoiceReport", "87d51710-2b55-47b8-bf1b-f39d8d936a60", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnGenerateInvoiceReportPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParamInvoiceId = @event.inParamInvoiceId.Value;
var inParamInvoiceName = @event.inParamInvoiceName;
await Actions.ActionGenerateInvoiceReport(requestContext,inParamInvoiceId,inParamInvoiceName,cancellationToken);


}

}
