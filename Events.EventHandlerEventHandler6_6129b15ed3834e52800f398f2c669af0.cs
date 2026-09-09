using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("3f191604-7966-4c34-90f8-8efef3186d49", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler6_6129b15ed3834e52800f398f2c669af0 : AbstractEventSubscriber<EventPayloads.GlobalEventOnDeleteCacheStorageFromConceptPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler6_6129b15ed3834e52800f398f2c669af0(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnDeleteCacheStorageFromConcept", "3f191604-7966-4c34-90f8-8efef3186d49", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnDeleteCacheStorageFromConceptPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParami_RequisitionId = @event.inParami_RequisitionId.Value;
var inParami_InvoiceId = @event.inParami_InvoiceId.Value;
var inParami_OrderId = @event.inParami_OrderId.Value;
var inParami_FolioId = @event.inParami_FolioId.Value;
var inParami_OrderRequestFileId = @event.inParami_OrderRequestFileId.Value;
await Actions.ActionEventDeleteCacheStorageFromConcept(requestContext,inParami_RequisitionId,inParami_InvoiceId,inParami_OrderId,inParami_FolioId,inParami_OrderRequestFileId,cancellationToken);


}

}
