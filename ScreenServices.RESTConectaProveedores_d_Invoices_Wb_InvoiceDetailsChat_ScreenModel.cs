using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceCommentsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac> ScreenDataSetGetInvoiceCommentsByInvoiceId;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("l_MaxRecords")]
public int? varLcl_MaxRecords;
[JsonProperty("NewMsg")]
public string varLcNewMsg;
[JsonProperty("IsOpenMenu")]
public bool? varLcIsOpenMenu;
[JsonProperty("IsPublic")]
public bool? varLcIsPublic;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
int varLcl_MaxRecords = variables.varLcl_MaxRecords == null ? 10 : variables.varLcl_MaxRecords.Value;
string varLcNewMsg = variables.varLcNewMsg == null ? "" : variables.varLcNewMsg;
bool varLcIsOpenMenu = variables.varLcIsOpenMenu == null ? false : variables.varLcIsOpenMenu.Value;
bool varLcIsPublic = variables.varLcIsPublic == null ? false : variables.varLcIsPublic.Value;
AggregateRecord<RL_2b8298c99eec97081abcd9d7211953b5> _ScreenDataSetGetInvoiceCommentsByInvoiceId = (variables.ScreenDataSetGetInvoiceCommentsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceCommentsByInvoiceId.FromJS((array) => {
return RL_2b8298c99eec97081abcd9d7211953b5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel(inParami_InvoiceId, varLcl_MaxRecords, varLcNewMsg, varLcIsOpenMenu, varLcIsPublic, _ScreenDataSetGetInvoiceCommentsByInvoiceId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
