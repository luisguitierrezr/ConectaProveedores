using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetData")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4c9ca09958a3ee4cb990399bb84ebebd> ScreenDataSetGetData;
[JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3> ScreenDataSetGetSuppliers;
[JsonProperty("GetFolioStatus")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ScreenDataSetGetFolioStatus;
[JsonProperty("i_StartIndex")]
public int? varLci_StartIndex;
[JsonProperty("i_TableSort")]
public string varLci_TableSort;
[JsonProperty("i_ReInvokeToggler")]
public bool? varLci_ReInvokeToggler;
[JsonProperty("i_ColumnsListInJSON")]
public string varLci_ColumnsListInJSON;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel ToModel() {int varLci_StartIndex = variables.varLci_StartIndex == null ? 0 : variables.varLci_StartIndex.Value;
string varLci_TableSort = variables.varLci_TableSort == null ? "" : variables.varLci_TableSort;
bool varLci_ReInvokeToggler = variables.varLci_ReInvokeToggler == null ? false : variables.varLci_ReInvokeToggler.Value;
string varLci_ColumnsListInJSON = variables.varLci_ColumnsListInJSON == null ? "" : variables.varLci_ColumnsListInJSON;
AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> _ScreenDataSetGetData = (variables.ScreenDataSetGetData != null) ? variables.ScreenDataSetGetData.FromJS((array) => {
return RL_dee12d8d138188f23c97a0b0c9fde91b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4c9ca09958a3ee4cb990399bb84ebebd.ToStructure);
}
) : null;
AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_53ee8acf49c9618a86f040a6ab1ebb06.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3.ToStructure);
}
) : null;
AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> _ScreenDataSetGetFolioStatus = (variables.ScreenDataSetGetFolioStatus != null) ? variables.ScreenDataSetGetFolioStatus.FromJS((array) => {
return RL_ba9fc810801f4aabee0bc4ef3685a9dd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2.ToStructure);
}
) : null;
ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel screenModel = new ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel(varLci_StartIndex, varLci_TableSort, varLci_ReInvokeToggler, varLci_ColumnsListInJSON, _ScreenDataSetGetData, _ScreenDataSetGetSuppliers, _ScreenDataSetGetFolioStatus, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
