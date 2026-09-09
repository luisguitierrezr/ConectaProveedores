namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainItemCreateOrUpdate : VarsBag {
public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource;
public long resCreateOrUpdateOrderMainItem_outParamId = 0L;

public string resJSONSerialize1_outParamJSON = "";
public lcvOrderMainItemCreateOrUpdate(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderMainItemCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public bool outParamHasSuccess = false;

public string outParamErrorMessage = "";

public lcoOrderMainItemCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderMainItemCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderMainItemCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<(long,bool,string)> ActionOrderMainItemCreateOrUpdate(IRequestContext requestContext,EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
bool outParamHasSuccess = default;
string outParamErrorMessage = default;
lcoOrderMainItemCreateOrUpdate result = new lcoOrderMainItemCreateOrUpdate();
lcvOrderMainItemCreateOrUpdate localVars = new lcvOrderMainItemCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainItemCreateOrUpdate", "63f443d2-f726-49f4-a10d-4f92317b43c0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainItemCreateOrUpdate", "63f443d2-f726-49f4-a10d-4f92317b43c0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeOrderMainItemCreateOrUpdateJSONSerialize1
FuncActionOrderMainItemCreateOrUpdate.JsonSerializeOrderMainItemCreateOrUpdateJSONSerialize1(localVars.inParamSource, out localVars.resJSONSerialize1_outParamJSON);
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrderMainItemCreateOrUpdate » Source: "+localVars.resJSONSerialize1_outParamJSON),"OrderMainItemCreateOrUpdate",cancellationToken);

// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// CreateOrUpdateOrderMainItem
localVars.resCreateOrUpdateOrderMainItem_outParamId = await ExtendedActions.CreateOrUpdateOrderMainItem(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_c4cc207f9017de4e013fabcf1e8ebeaf)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderMainItem.Id
result.outParamId=localVars.resCreateOrUpdateOrderMainItem_outParamId;

// HasSuccess = True
result.outParamHasSuccess=true;
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;

// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = AllExceptions.ExceptionMessage
result.outParamErrorMessage=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamId = result.outParamId;
outParamHasSuccess = result.outParamHasSuccess;
outParamErrorMessage = result.outParamErrorMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamId,outParamHasSuccess,outParamErrorMessage);
}

public static class FuncActionOrderMainItemCreateOrUpdate {



/// <summary>
/// JSONSerialize: JsonSerializeOrderMainItemCreateOrUpdateJSONSerialize1 (KzcjQf0F_LU6AxWTy2f_jGw)  of
///  Action "OrderMainItemCreateOrUpdate"
/// </summary>
public static void JsonSerializeOrderMainItemCreateOrUpdateJSONSerialize1 (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
