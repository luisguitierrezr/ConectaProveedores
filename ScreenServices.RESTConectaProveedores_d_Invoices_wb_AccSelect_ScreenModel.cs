using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderAccountingsByOrderId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ab3c433102000c44a55e713fb2ce955d> ScreenDataSetGetOrderAccountingsByOrderId;
[JsonProperty("OrderMainID")]
public long? inParamOrderMainID;
[JsonProperty("IsFromFolio")]
public bool? inParamIsFromFolio;
[JsonProperty("IsEnable")]
public bool? inParamIsEnable;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel ToModel() {long inParamOrderMainID = variables.inParamOrderMainID == null ? 0L : variables.inParamOrderMainID.Value;
bool inParamIsFromFolio = variables.inParamIsFromFolio == null ? false : variables.inParamIsFromFolio.Value;
bool inParamIsEnable = variables.inParamIsEnable == null ? false : variables.inParamIsEnable.Value;
AggregateRecord<RL_c78a606a32d5fd9bcd75de1aae614727> _ScreenDataSetGetOrderAccountingsByOrderId = (variables.ScreenDataSetGetOrderAccountingsByOrderId != null) ? variables.ScreenDataSetGetOrderAccountingsByOrderId.FromJS((array) => {
return RL_c78a606a32d5fd9bcd75de1aae614727.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ab3c433102000c44a55e713fb2ce955d.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel screenModel = new ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel(inParamOrderMainID, inParamIsFromFolio, inParamIsEnable, _ScreenDataSetGetOrderAccountingsByOrderId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
