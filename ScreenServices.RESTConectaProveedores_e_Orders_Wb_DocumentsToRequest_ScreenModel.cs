using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierUsersBySupplierId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def> ScreenDataSetGetSupplierUsersBySupplierId;
[JsonProperty("i_SupplierId")]
public long? inParami_SupplierId;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_CanEditUserArea")]
public bool? inParami_CanEditUserArea;
[JsonProperty("i_HasError")]
public bool? inParami_HasError;
[JsonProperty("i_HasntRequestDocuments")]
public bool? inParami_HasntRequestDocuments;
[JsonProperty("l_HasError")]
public bool? varLcl_HasError;
[JsonProperty("l_IsValidList")]
public bool? varLcl_IsValidList;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("GetOrderRequestFiles")]
public RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_DataActionGetOrderRequestFiles_Outputs varLcGetOrderRequestFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel ToModel() {long inParami_SupplierId = variables.inParami_SupplierId == null ? 0L : variables.inParami_SupplierId.Value;
long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
bool inParami_CanEditUserArea = variables.inParami_CanEditUserArea == null ? false : variables.inParami_CanEditUserArea.Value;
bool inParami_HasError = variables.inParami_HasError == null ? false : variables.inParami_HasError.Value;
bool inParami_HasntRequestDocuments = variables.inParami_HasntRequestDocuments == null ? false : variables.inParami_HasntRequestDocuments.Value;
bool varLcl_HasError = variables.varLcl_HasError == null ? false : variables.varLcl_HasError.Value;
bool varLcl_IsValidList = variables.varLcl_IsValidList == null ? false : variables.varLcl_IsValidList.Value;
bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
AggregateRecord<RL_84bdfe424d1eb0223fc2b8cfa9bb96be> _ScreenDataSetGetSupplierUsersBySupplierId = (variables.ScreenDataSetGetSupplierUsersBySupplierId != null) ? variables.ScreenDataSetGetSupplierUsersBySupplierId.FromJS((array) => {
return RL_84bdfe424d1eb0223fc2b8cfa9bb96be.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_33e6e9ec201f65e0eb7bd5d251178def.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_DocumentsToRequest_DataActionGetOrderRequestFiles_Model _varLcGetOrderRequestFiles = (variables.varLcGetOrderRequestFiles != null) ? RESTConectaProveedores_e_Orders_Wb_DocumentsToRequest_DataActionGetOrderRequestFiles_Outputs.ToModel(variables.varLcGetOrderRequestFiles) : null;
ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel(inParami_SupplierId, inParami_OrderId, inParami_CanEditUserArea, inParami_HasError, inParami_HasntRequestDocuments, varLcl_HasError, varLcl_IsValidList, varLcl_IsBusy, _ScreenDataSetGetSupplierUsersBySupplierId, _varLcGetOrderRequestFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
