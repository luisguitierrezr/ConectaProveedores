using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamo_Output
result.outParamo_Output = ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(new ST_046fb53ebbe142526d95e87ef1ae9711Structure(), conf);
return result;
}


    

    
}
