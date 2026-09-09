using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_CurrencyCode")]
public string inParami_CurrencyCode;
[JsonProperty("i_TotalAmount")]
public decimal? inParami_TotalAmount;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("TableSort")]
public string varLcTableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
string inParami_CurrencyCode = variables.inParami_CurrencyCode == null ? "" : variables.inParami_CurrencyCode;
decimal inParami_TotalAmount = variables.inParami_TotalAmount == null ? 0.0M : variables.inParami_TotalAmount.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel(inParami_FolioId, inParami_CurrencyCode, inParami_TotalAmount, varLcStartIndex, varLcMaxRecords, varLcTableSort, _ScreenDataSetGetFolioItemsByFolioId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
