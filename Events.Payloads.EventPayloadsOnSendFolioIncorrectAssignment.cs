using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnSendFolioIncorrectAssignmentPayload : IJsonOnSerializing {
[JsonPropertyName("2360953a-fe30-493a-afdc-99f13194132a")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_FolioId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParami_FolioId{get; set;} = default;
[JsonPropertyName("6518f337-8e36-4df3-804c-eac01089cf26")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_RejectMotive")]
[System.Text.Json.Serialization.JsonRequired()]
public string inParami_RejectMotive{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
EventUtils.ValidateEventTextInputsLength("OnSendFolioIncorrectAssignment","ConectaProveedores",("i_RejectMotive",inParami_RejectMotive?.Length ?? 0));}

}


}