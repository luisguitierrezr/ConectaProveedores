using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceItemsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f5e2444cde8ccebe1d8b8fbec7a36039> ScreenDataSetGetInvoiceItemsByInvoiceId;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
AggregateRecord<RL_e14179ee8651dc8cb6e49b70d6c98c9d> _ScreenDataSetGetInvoiceItemsByInvoiceId = (variables.ScreenDataSetGetInvoiceItemsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceItemsByInvoiceId.FromJS((array) => {
return RL_e14179ee8651dc8cb6e49b70d6c98c9d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f5e2444cde8ccebe1d8b8fbec7a36039.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel(inParami_InvoiceId, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_Loading, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, _ScreenDataSetGetInvoiceItemsByInvoiceId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
