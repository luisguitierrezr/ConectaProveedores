using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("IsFinish")]
public bool? outParamIsFinish;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, bool outParamIsFinish) {RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_Output to the result.outParamo_Output
result.outParamo_Output = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamo_Output.AttrIsSuccess = (bool?) outParamo_Output.ssIsSuccess;
result.outParamo_Output.AttrMessage = outParamo_Output.ssMessage;
// Write optimized result.outParamo_Output.AttrLines
result.outParamo_Output.AttrLines = (int?) 0;
result.outParamIsFinish = (bool?) outParamIsFinish;
return result;
}


    

    
}
