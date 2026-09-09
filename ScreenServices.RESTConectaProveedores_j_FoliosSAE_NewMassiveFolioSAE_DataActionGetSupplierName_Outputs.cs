using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("SupplierName")]
public string outParamSupplierName;


    public static RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamSupplierName) {RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs();
result.outParamSupplierName = outParamSupplierName;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model ToModel(RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs variables) {ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model result = new ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model();
result.outParamSupplierName = variables == null || variables.outParamSupplierName == null ? "" : variables.outParamSupplierName;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs();
result.outParamSupplierName = screenModel.outParamSupplierName;
return result;
}

}
