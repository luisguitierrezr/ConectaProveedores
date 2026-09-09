using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnSendEmailSupplierFolioInvoiceRejectedPayload : IJsonOnSerializing {
[JsonPropertyName("2c6a9d1c-a06e-4e42-b98d-2b52065c720f")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_FolioId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParami_FolioId{get; set;} = default;
[JsonPropertyName("497aca9b-e247-4fc9-a2d6-3107744bb3a3")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_RejectMotive1")]
[System.Text.Json.Serialization.JsonRequired()]
public string inParami_RejectMotive1{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
EventUtils.ValidateEventTextInputsLength("OnSendEmailSupplierFolioInvoiceRejected","ConectaProveedores",("i_RejectMotive1",inParami_RejectMotive1?.Length ?? 0));}

}


}