using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("I_ACREEDOR")]
public string inParamI_ACREEDOR;
[JsonProperty("I_ANTICIPOS_HIGH")]
public string inParamI_ANTICIPOS_HIGH;
[JsonProperty("I_ANTICIPOS_LOW")]
public string inParamI_ANTICIPOS_LOW;
[JsonProperty("I_F_PARTABIE")]
public string inParamI_F_PARTABIE;
[JsonProperty("I_PCOMP_HIGH")]
public string inParamI_PCOMP_HIGH;
[JsonProperty("I_PCOMP_LOW")]
public string inParamI_PCOMP_LOW;
[JsonProperty("I_REGION")]
public string inParamI_REGION;
[JsonProperty("I_SOCIEDAD")]
public long? inParamI_SOCIEDAD;


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Model ToModel() {ConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Model result = new ConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Model();
result.inParamI_ACREEDOR = inParamI_ACREEDOR == null ? "" : inParamI_ACREEDOR;
result.inParamI_ANTICIPOS_HIGH = inParamI_ANTICIPOS_HIGH == null ? "" : inParamI_ANTICIPOS_HIGH;
result.inParamI_ANTICIPOS_LOW = inParamI_ANTICIPOS_LOW == null ? "" : inParamI_ANTICIPOS_LOW;
result.inParamI_F_PARTABIE = inParamI_F_PARTABIE == null ? "" : inParamI_F_PARTABIE;
result.inParamI_PCOMP_HIGH = inParamI_PCOMP_HIGH == null ? "" : inParamI_PCOMP_HIGH;
result.inParamI_PCOMP_LOW = inParamI_PCOMP_LOW == null ? "" : inParamI_PCOMP_LOW;
result.inParamI_REGION = inParamI_REGION == null ? "" : inParamI_REGION;
result.inParamI_SOCIEDAD = inParamI_SOCIEDAD == null ? 0L : inParamI_SOCIEDAD.Value;
return result;
}

}
