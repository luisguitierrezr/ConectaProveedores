using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderAccountingsByOrderId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae> ScreenDataSetGetOrderAccountingsByOrderId;
[JsonProperty("GetOrderFileById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032> ScreenDataSetGetOrderFileById;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("l_ShowPopupFinancial")]
public bool? varLcl_ShowPopupFinancial;
[JsonProperty("l_OrderAccConceptsId")]
public long? varLcl_OrderAccConceptsId;
[JsonProperty("l_AccountingDataTypeId")]
public int? varLcl_AccountingDataTypeId;
[JsonProperty("l_ShowContractPopup")]
public bool? varLcl_ShowContractPopup;
[JsonProperty("l_OrderContractFile")]
public long? varLcl_OrderContractFile;
[JsonProperty("l_OrderRequestFileIdSelected")]
public long? varLcl_OrderRequestFileIdSelected;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
bool varLcl_ShowPopupFinancial = variables.varLcl_ShowPopupFinancial == null ? false : variables.varLcl_ShowPopupFinancial.Value;
long varLcl_OrderAccConceptsId = variables.varLcl_OrderAccConceptsId == null ? 0L : variables.varLcl_OrderAccConceptsId.Value;
int varLcl_AccountingDataTypeId = variables.varLcl_AccountingDataTypeId == null ? 0 : variables.varLcl_AccountingDataTypeId.Value;
bool varLcl_ShowContractPopup = variables.varLcl_ShowContractPopup == null ? false : variables.varLcl_ShowContractPopup.Value;
long varLcl_OrderContractFile = variables.varLcl_OrderContractFile == null ? 0L : variables.varLcl_OrderContractFile.Value;
long varLcl_OrderRequestFileIdSelected = variables.varLcl_OrderRequestFileIdSelected == null ? 0L : variables.varLcl_OrderRequestFileIdSelected.Value;
AggregateRecord<RL_e127e807f43523243e5e4b1203065583> _ScreenDataSetGetOrderAccountingsByOrderId = (variables.ScreenDataSetGetOrderAccountingsByOrderId != null) ? variables.ScreenDataSetGetOrderAccountingsByOrderId.FromJS((array) => {
return RL_e127e807f43523243e5e4b1203065583.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae.ToStructure);
}
) : null;
AggregateRecord<RL_924196580a3b015839b6fad505120f41> _ScreenDataSetGetOrderFileById = (variables.ScreenDataSetGetOrderFileById != null) ? variables.ScreenDataSetGetOrderFileById.FromJS((array) => {
return RL_924196580a3b015839b6fad505120f41.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel screenModel = new ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel(inParami_OrderId, varLcl_ShowPopupFinancial, varLcl_OrderAccConceptsId, varLcl_AccountingDataTypeId, varLcl_ShowContractPopup, varLcl_OrderContractFile, varLcl_OrderRequestFileIdSelected, _ScreenDataSetGetOrderAccountingsByOrderId, _ScreenDataSetGetOrderFileById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
