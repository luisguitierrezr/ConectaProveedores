using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("CountInvoiceLogs")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835> ScreenDataSetCountInvoiceLogs;
[JsonProperty("GetUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930> ScreenDataSetGetUsers;
[JsonProperty("GetInvoiceLogsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec> ScreenDataSetGetInvoiceLogsByInvoiceId;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_Refresh")]
public String inParami_Refresh;
[JsonProperty("l_DateTimeVar")]
public String varLcl_DateTimeVar;
[JsonProperty("l_UserName")]
public string varLcl_UserName;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
DateTime inParami_Refresh = variables.inParami_Refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_Refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcl_DateTimeVar = variables.varLcl_DateTimeVar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_DateTimeVar);
string varLcl_UserName = variables.varLcl_UserName == null ? "" : variables.varLcl_UserName;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 10 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> _ScreenDataSetCountInvoiceLogs = (variables.ScreenDataSetCountInvoiceLogs != null) ? variables.ScreenDataSetCountInvoiceLogs.FromJS((array) => {
return RL_11e68f59508e412eaf5b78801dd06b0e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835.ToStructure);
}
) : null;
AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> _ScreenDataSetGetUsers = (variables.ScreenDataSetGetUsers != null) ? variables.ScreenDataSetGetUsers.FromJS((array) => {
return RL_8e4276b7147c8295b1546570303ecba2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930.ToStructure);
}
) : null;
AggregateRecord<RL_8623462923ce4f5fca06be3fb804a6be> _ScreenDataSetGetInvoiceLogsByInvoiceId = (variables.ScreenDataSetGetInvoiceLogsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceLogsByInvoiceId.FromJS((array) => {
return RL_8623462923ce4f5fca06be3fb804a6be.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel(inParami_InvoiceId, inParami_Refresh, varLcl_DateTimeVar, varLcl_UserName, varLcMaxRecords, _ScreenDataSetCountInvoiceLogs, _ScreenDataSetGetUsers, _ScreenDataSetGetInvoiceLogsByInvoiceId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
