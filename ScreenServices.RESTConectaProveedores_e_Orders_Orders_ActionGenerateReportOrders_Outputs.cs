using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("File")]
public byte[] outParamFile;
[JsonProperty("Filename")]
public string outParamFilename;


    public static RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamFile, string outParamFilename) {RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Outputs result = new RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Outputs();
conf.IncludeBinariesURL = false;
result.outParamFile = outParamFile;
result.outParamFilename = outParamFilename;
return result;
}


    

    
}
