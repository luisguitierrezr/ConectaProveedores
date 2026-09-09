using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRequisitionById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972> ScreenDataSetGetRequisitionById;
[JsonProperty("GetSupplierById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSupplierById;
[JsonProperty("SupplierId")]
public long? inParamSupplierId;
[JsonProperty("IsEnabled")]
public bool? inParamIsEnabled;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel ToModel() {long inParamSupplierId = variables.inParamSupplierId == null ? 0L : variables.inParamSupplierId.Value;
bool inParamIsEnabled = variables.inParamIsEnabled == null ? false : variables.inParamIsEnabled.Value;
long inParamRequisitionId = variables.inParamRequisitionId == null ? 0L : variables.inParamRequisitionId.Value;
AggregateRecord<RL_b9a4d89a3154e989f9ae297e352963c3> _ScreenDataSetGetRequisitionById = (variables.ScreenDataSetGetRequisitionById != null) ? variables.ScreenDataSetGetRequisitionById.FromJS((array) => {
return RL_b9a4d89a3154e989f9ae297e352963c3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972.ToStructure);
}
) : null;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSupplierById = (variables.ScreenDataSetGetSupplierById != null) ? variables.ScreenDataSetGetSupplierById.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel(inParamSupplierId, inParamIsEnabled, inParamRequisitionId, _ScreenDataSetGetRequisitionById, _ScreenDataSetGetSupplierById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
