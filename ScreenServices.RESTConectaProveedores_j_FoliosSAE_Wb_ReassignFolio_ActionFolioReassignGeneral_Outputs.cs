using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_NotificationContent")]
public ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent;
[JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent, string outParamErrorMessage) {RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_NotificationContent to the result.outParamo_NotificationContent
result.outParamo_NotificationContent = new ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
result.outParamo_NotificationContent.AttrEmail = outParamo_NotificationContent.ssEmail;
result.outParamo_NotificationContent.AttrName = outParamo_NotificationContent.ssName;
result.outParamo_NotificationContent.AttrJobTitle = outParamo_NotificationContent.ssJobTitle;
result.outParamo_NotificationContent.AttrPhoneNumber = outParamo_NotificationContent.ssPhoneNumber;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
