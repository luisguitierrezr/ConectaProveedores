using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937> ScreenDataSetGetInvoiceApprovalLevels;
[JsonProperty("i_RegionId")]
public long? inParami_RegionId;
[JsonProperty("i_SupplierId")]
public long? inParami_SupplierId;
[JsonProperty("i_CurrentRowNumber")]
public int? inParami_CurrentRowNumber;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel ToModel() {long inParami_RegionId = variables.inParami_RegionId == null ? 0L : variables.inParami_RegionId.Value;
long inParami_SupplierId = variables.inParami_SupplierId == null ? 0L : variables.inParami_SupplierId.Value;
int inParami_CurrentRowNumber = variables.inParami_CurrentRowNumber == null ? 0 : variables.inParami_CurrentRowNumber.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_a0d7b43e9ac13e97d2ade731b2b4eb81> _ScreenDataSetGetInvoiceApprovalLevels = (variables.ScreenDataSetGetInvoiceApprovalLevels != null) ? variables.ScreenDataSetGetInvoiceApprovalLevels.FromJS((array) => {
return RL_a0d7b43e9ac13e97d2ade731b2b4eb81.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937.ToStructure);
}
) : null;
ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel screenModel = new ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel(inParami_RegionId, inParami_SupplierId, inParami_CurrentRowNumber, varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetGetInvoiceApprovalLevels, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
