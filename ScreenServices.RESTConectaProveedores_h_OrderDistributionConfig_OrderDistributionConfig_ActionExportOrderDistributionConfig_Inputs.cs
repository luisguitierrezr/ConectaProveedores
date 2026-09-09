using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_TabNumber")]
public int? inParami_TabNumber;
[JsonProperty("i_TableSort")]
public string inParami_TableSort;
[JsonProperty("i_OrderDistributionConfig_Applicant")]
public string inParami_OrderDistributionConfig_Applicant;
[JsonProperty("i_OrderDistributionConfig_ApplicantDescription")]
public string inParami_OrderDistributionConfig_ApplicantDescription;
[JsonProperty("i_OrderDistributionConfig_Direction")]
public string inParami_OrderDistributionConfig_Direction;
[JsonProperty("i_OrderDistributionConfig_Division")]
public string inParami_OrderDistributionConfig_Division;
[JsonProperty("i_OrderDistributionConfig_Role")]
public string inParami_OrderDistributionConfig_Role;


    public static RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Inputs result = inputParameters.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Inputs>(settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Model ToModel() {ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Model result = new ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Model();
result.inParami_OrderId = inParami_OrderId == null ? 0L : inParami_OrderId.Value;
result.inParami_TabNumber = inParami_TabNumber == null ? 0 : inParami_TabNumber.Value;
result.inParami_TableSort = inParami_TableSort == null ? "" : inParami_TableSort;
result.inParami_OrderDistributionConfig_Applicant = inParami_OrderDistributionConfig_Applicant == null ? "" : inParami_OrderDistributionConfig_Applicant;
result.inParami_OrderDistributionConfig_ApplicantDescription = inParami_OrderDistributionConfig_ApplicantDescription == null ? "" : inParami_OrderDistributionConfig_ApplicantDescription;
result.inParami_OrderDistributionConfig_Direction = inParami_OrderDistributionConfig_Direction == null ? "" : inParami_OrderDistributionConfig_Direction;
result.inParami_OrderDistributionConfig_Division = inParami_OrderDistributionConfig_Division == null ? "" : inParami_OrderDistributionConfig_Division;
result.inParami_OrderDistributionConfig_Role = inParami_OrderDistributionConfig_Role == null ? "" : inParami_OrderDistributionConfig_Role;
return result;
}

}
