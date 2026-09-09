using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSuppliers;
[JsonProperty("GetSupplierById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce> ScreenDataSetGetSupplierById;
[JsonProperty("i_IsDisable")]
public bool? inParami_IsDisable;
[JsonProperty("i_SupplierId")]
public long? inParami_SupplierId;
[JsonProperty("i_RequisitionDetailRegionId")]
public long? inParami_RequisitionDetailRegionId;
[JsonProperty("i_IsValid")]
public bool? inParami_IsValid;
[JsonProperty("i_IsMandatory")]
public bool? inParami_IsMandatory;
[JsonProperty("i_IsFilter")]
public bool? inParami_IsFilter;
[JsonProperty("l_SupplierSearchText")]
public string varLcl_SupplierSearchText;
[JsonProperty("l_SupplierMaxRecord")]
public int? varLcl_SupplierMaxRecord;
[JsonProperty("l_IsValid")]
public bool? varLcl_IsValid;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel ToModel() {bool inParami_IsDisable = variables.inParami_IsDisable == null ? false : variables.inParami_IsDisable.Value;
long inParami_SupplierId = variables.inParami_SupplierId == null ? 0L : variables.inParami_SupplierId.Value;
long inParami_RequisitionDetailRegionId = variables.inParami_RequisitionDetailRegionId == null ? 0L : variables.inParami_RequisitionDetailRegionId.Value;
bool inParami_IsValid = variables.inParami_IsValid == null ? false : variables.inParami_IsValid.Value;
bool inParami_IsMandatory = variables.inParami_IsMandatory == null ? false : variables.inParami_IsMandatory.Value;
bool inParami_IsFilter = variables.inParami_IsFilter == null ? false : variables.inParami_IsFilter.Value;
string varLcl_SupplierSearchText = variables.varLcl_SupplierSearchText == null ? "" : variables.varLcl_SupplierSearchText;
int varLcl_SupplierMaxRecord = variables.varLcl_SupplierMaxRecord == null ? 20 : variables.varLcl_SupplierMaxRecord.Value;
bool varLcl_IsValid = variables.varLcl_IsValid == null ? true : variables.varLcl_IsValid.Value;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> _ScreenDataSetGetSupplierById = (variables.ScreenDataSetGetSupplierById != null) ? variables.ScreenDataSetGetSupplierById.FromJS((array) => {
return RL_d5c1b2482ff109e80580d8b5fb920193.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.ToStructure);
}
) : null;
ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel screenModel = new ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel(inParami_IsDisable, inParami_SupplierId, inParami_RequisitionDetailRegionId, inParami_IsValid, inParami_IsMandatory, inParami_IsFilter, varLcl_SupplierSearchText, varLcl_SupplierMaxRecord, varLcl_IsValid, _ScreenDataSetGetSuppliers, _ScreenDataSetGetSupplierById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
