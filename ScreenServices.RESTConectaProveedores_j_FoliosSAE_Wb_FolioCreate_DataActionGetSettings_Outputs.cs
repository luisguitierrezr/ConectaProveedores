using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsActiveAmountValidation")]
public bool? outParamIsActiveAmountValidation;
[JsonProperty("IsForceForeigner")]
public bool? outParamIsForceForeigner;
[JsonProperty("o_ForeignCurrencyMargin")]
public decimal? outParamo_ForeignCurrencyMargin;
[JsonProperty("o_NationalCurrencyMargin")]
public decimal? outParamo_NationalCurrencyMargin;
[JsonProperty("o_IsActiveDEV_HU13008_Complement")]
public bool? outParamo_IsActiveDEV_HU13008_Complement;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsActiveAmountValidation, bool outParamIsForceForeigner, decimal outParamo_ForeignCurrencyMargin, decimal outParamo_NationalCurrencyMargin, bool outParamo_IsActiveDEV_HU13008_Complement) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs();
result.outParamIsActiveAmountValidation = (bool?) outParamIsActiveAmountValidation;
result.outParamIsForceForeigner = (bool?) outParamIsForceForeigner;
result.outParamo_ForeignCurrencyMargin = (decimal?) outParamo_ForeignCurrencyMargin;
result.outParamo_NationalCurrencyMargin = (decimal?) outParamo_NationalCurrencyMargin;
result.outParamo_IsActiveDEV_HU13008_Complement = (bool?) outParamo_IsActiveDEV_HU13008_Complement;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model();
result.outParamIsActiveAmountValidation = variables == null || variables.outParamIsActiveAmountValidation == null ? false : variables.outParamIsActiveAmountValidation.Value;
result.outParamIsForceForeigner = variables == null || variables.outParamIsForceForeigner == null ? false : variables.outParamIsForceForeigner.Value;
result.outParamo_ForeignCurrencyMargin = variables == null || variables.outParamo_ForeignCurrencyMargin == null ? (((decimal)10)) : variables.outParamo_ForeignCurrencyMargin.Value;
result.outParamo_NationalCurrencyMargin = variables == null || variables.outParamo_NationalCurrencyMargin == null ? (((decimal)10)) : variables.outParamo_NationalCurrencyMargin.Value;
result.outParamo_IsActiveDEV_HU13008_Complement = variables == null || variables.outParamo_IsActiveDEV_HU13008_Complement == null ? false : variables.outParamo_IsActiveDEV_HU13008_Complement.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs();
result.outParamIsActiveAmountValidation = (bool?) screenModel.outParamIsActiveAmountValidation;
result.outParamIsForceForeigner = (bool?) screenModel.outParamIsForceForeigner;
result.outParamo_ForeignCurrencyMargin = (decimal?) screenModel.outParamo_ForeignCurrencyMargin;
result.outParamo_NationalCurrencyMargin = (decimal?) screenModel.outParamo_NationalCurrencyMargin;
result.outParamo_IsActiveDEV_HU13008_Complement = (bool?) screenModel.outParamo_IsActiveDEV_HU13008_Complement;
return result;
}

}
