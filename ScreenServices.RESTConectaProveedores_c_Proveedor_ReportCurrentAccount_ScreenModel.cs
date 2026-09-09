using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierUserByUserId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSupplierUserByUserId;
[JsonProperty("GetPaymentTerms")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> ScreenDataSetGetPaymentTerms;
[JsonProperty("I_ACREEDOR")]
public string inParamI_ACREEDOR;
[JsonProperty("I_ANTICIPOS_HIGH")]
public String inParamI_ANTICIPOS_HIGH;
[JsonProperty("I_ANTICIPOS_LOW")]
public String inParamI_ANTICIPOS_LOW;
[JsonProperty("I_F_PARTABIE")]
public String inParamI_F_PARTABIE;
[JsonProperty("I_PCOMP_HIGH")]
public String inParamI_PCOMP_HIGH;
[JsonProperty("I_PCOMP_LOW")]
public String inParamI_PCOMP_LOW;
[JsonProperty("I_REGION")]
public string inParamI_REGION;
[JsonProperty("I_SOCIEDAD")]
public string inParamI_SOCIEDAD;
[JsonProperty("SupplierId")]
public long? inParamSupplierId;
[JsonProperty("GetSapData")]
public RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Outputs varLcGetSapData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel ToModel() {string inParamI_ACREEDOR = variables.inParamI_ACREEDOR == null ? "" : variables.inParamI_ACREEDOR;
DateTime inParamI_ANTICIPOS_HIGH = variables.inParamI_ANTICIPOS_HIGH == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.inParamI_ANTICIPOS_HIGH);
DateTime inParamI_ANTICIPOS_LOW = variables.inParamI_ANTICIPOS_LOW == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.inParamI_ANTICIPOS_LOW);
DateTime inParamI_F_PARTABIE = variables.inParamI_F_PARTABIE == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.inParamI_F_PARTABIE);
DateTime inParamI_PCOMP_HIGH = variables.inParamI_PCOMP_HIGH == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.inParamI_PCOMP_HIGH);
DateTime inParamI_PCOMP_LOW = variables.inParamI_PCOMP_LOW == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.inParamI_PCOMP_LOW);
string inParamI_REGION = variables.inParamI_REGION == null ? "" : variables.inParamI_REGION;
string inParamI_SOCIEDAD = variables.inParamI_SOCIEDAD == null ? "" : variables.inParamI_SOCIEDAD;
long inParamSupplierId = variables.inParamSupplierId == null ? 0L : variables.inParamSupplierId.Value;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSupplierUserByUserId = (variables.ScreenDataSetGetSupplierUserByUserId != null) ? variables.ScreenDataSetGetSupplierUserByUserId.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> _ScreenDataSetGetPaymentTerms = (variables.ScreenDataSetGetPaymentTerms != null) ? variables.ScreenDataSetGetPaymentTerms.FromJS((array) => {
return RL_375b9dd8c8b0d6d7bccf4d550f48644d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.ToStructure);
}
) : null;
ConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Model _varLcGetSapData = (variables.varLcGetSapData != null) ? RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Outputs.ToModel(variables.varLcGetSapData) : null;
ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel screenModel = new ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel(inParamI_ACREEDOR, inParamI_ANTICIPOS_HIGH, inParamI_ANTICIPOS_LOW, inParamI_F_PARTABIE, inParamI_PCOMP_HIGH, inParamI_PCOMP_LOW, inParamI_REGION, inParamI_SOCIEDAD, inParamSupplierId, _ScreenDataSetGetSupplierUserByUserId, _ScreenDataSetGetPaymentTerms, _varLcGetSapData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
