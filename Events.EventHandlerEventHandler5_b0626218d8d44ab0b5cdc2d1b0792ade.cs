using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("79e14446-5ffa-490c-bb2c-b0c9b5300bd6", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler5_b0626218d8d44ab0b5cdc2d1b0792ade : AbstractEventSubscriber<EventPayloads.GlobalEventOnSendEmailSupplierFolioInvoiceRejectedPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler5_b0626218d8d44ab0b5cdc2d1b0792ade(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnSendEmailSupplierFolioInvoiceRejected", "79e14446-5ffa-490c-bb2c-b0c9b5300bd6", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnSendEmailSupplierFolioInvoiceRejectedPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParami_FolioId = @event.inParami_FolioId.Value;
var inParami_RejectMotive1 = @event.inParami_RejectMotive1;
await Actions.ActionSendEmailSupplier_FolioInvoiceRejected(requestContext,inParami_FolioId,inParami_RejectMotive1,cancellationToken);


}

}
