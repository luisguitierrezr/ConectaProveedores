using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("HasSuccess")]
public bool? outParamHasSuccess;
[JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamHasSuccess, string outParamErrorMessage) {RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Outputs result = new RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Outputs();
conf.IncludeBinariesURL = false;
result.outParamHasSuccess = (bool?) outParamHasSuccess;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
