using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_NotificationContent")]
public ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent;
[JsonProperty("o_Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Outputs result = new RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_NotificationContent to the result.outParamo_NotificationContent
result.outParamo_NotificationContent = new ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
result.outParamo_NotificationContent.AttrEmail = outParamo_NotificationContent.ssEmail;
result.outParamo_NotificationContent.AttrName = outParamo_NotificationContent.ssName;
result.outParamo_NotificationContent.AttrJobTitle = outParamo_NotificationContent.ssJobTitle;
result.outParamo_NotificationContent.AttrPhoneNumber = outParamo_NotificationContent.ssPhoneNumber;
// Write the needed fields of the record outParamo_Output to the result.outParamo_Output
result.outParamo_Output = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamo_Output.AttrIsSuccess = (bool?) outParamo_Output.ssIsSuccess;
result.outParamo_Output.AttrMessage = outParamo_Output.ssMessage;
// Write optimized result.outParamo_Output.AttrLines
result.outParamo_Output.AttrLines = (int?) 0;
return result;
}


    

    
}
