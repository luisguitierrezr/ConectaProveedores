using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_SetTableRecord_ServiceAPIServiceSetUserPreferences_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Return")]
public ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return;


    public static RESTConectaProveedores_y_Utils_Wb_SetTableRecord_ServiceAPIServiceSetUserPreferences_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return) {RESTConectaProveedores_y_Utils_Wb_SetTableRecord_ServiceAPIServiceSetUserPreferences_Outputs result = new RESTConectaProveedores_y_Utils_Wb_SetTableRecord_ServiceAPIServiceSetUserPreferences_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamo_Return
result.outParamo_Return = ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure.FromStructure(new ST_b1b6df219277397c7c2be747d587880aStructure(), conf);
return result;
}


    

    
}
