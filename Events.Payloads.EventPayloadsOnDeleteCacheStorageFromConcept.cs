using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnDeleteCacheStorageFromConceptPayload : IJsonOnSerializing {
[JsonPropertyName("51e42083-1883-4a06-933b-a6a0aaedfeb0")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_RequisitionId")]
public long? inParami_RequisitionId{get; set;} = 0L;
[JsonPropertyName("eb421d1e-b8f3-4fb7-bf28-9d4d9c36c184")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_InvoiceId")]
public long? inParami_InvoiceId{get; set;} = 0L;
[JsonPropertyName("77c6ab3d-41eb-425c-8624-98624dd66b75")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_OrderId")]
public long? inParami_OrderId{get; set;} = 0L;
[JsonPropertyName("52d55f2e-7f28-4150-aa07-ca342d9683d2")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_FolioId")]
public long? inParami_FolioId{get; set;} = 0L;
[JsonPropertyName("f943a004-026e-47dc-ab7d-5a61804578a0")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_OrderRequestFileId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParami_OrderRequestFileId{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
}

}


}