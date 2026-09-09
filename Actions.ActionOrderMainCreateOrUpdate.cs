namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainCreateOrUpdate : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public string resJSONSerialize1_outParamJSON = "";
public long resCreateOrUpdateOrderMain_outParamId = 0L;

public lcvOrderMainCreateOrUpdate(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderMainCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public bool outParamHasSuccess = true;

public string outParamErrorMessage = "";

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord outParamSource_Out = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();

public lcoOrderMainCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderMainCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderMainCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<(long,bool,string,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)> ActionOrderMainCreateOrUpdate(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
bool outParamHasSuccess = default;
string outParamErrorMessage = default;
EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord outParamSource_Out = default;
lcoOrderMainCreateOrUpdate result = new lcoOrderMainCreateOrUpdate();
lcvOrderMainCreateOrUpdate localVars = new lcvOrderMainCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainCreateOrUpdate", "0efcd6c2-6e35-4cc9-9c7d-698bae017f91"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainCreateOrUpdate", "0efcd6c2-6e35-4cc9-9c7d-698bae017f91", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeOrderMainCreateOrUpdateJSONSerialize1
FuncActionOrderMainCreateOrUpdate.JsonSerializeOrderMainCreateOrUpdateJSONSerialize1(localVars.inParamSource, out localVars.resJSONSerialize1_outParamJSON);
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrderMainCreateOrUpdate » Source: "+localVars.resJSONSerialize1_outParamJSON),"OrderMainCreateOrUpdate",cancellationToken);

// Is new record?
if((((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(localVars.inParamSource.ssCreatedBy==BuiltInFunction.NullTextIdentifier ())))) {
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
// CreateOrUpdateOrderMain
localVars.resCreateOrUpdateOrderMain_outParamId = await ExtendedActions.CreateOrUpdateOrderMain(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_1583d548420c231ffb93458312800446)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderMain.Id
result.outParamId=localVars.resCreateOrUpdateOrderMain_outParamId;

// HasSuccess = True
result.outParamHasSuccess=true;

// Source_Out = Source
result.outParamSource_Out=localVars.inParamSource;

// Source_Out.Id = CreateOrUpdateOrderMain.Id
result.outParamSource_Out.ssId = localVars.resCreateOrUpdateOrderMain_outParamId;
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
outParamSource_Out = result.outParamSource_Out;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamId,outParamHasSuccess,outParamErrorMessage,outParamSource_Out);
}

public static class FuncActionOrderMainCreateOrUpdate {



/// <summary>
/// JSONSerialize: JsonSerializeOrderMainCreateOrUpdateJSONSerialize1 (KIMOLPlihGUWWNP6RLfirTw)  of
///  Action "OrderMainCreateOrUpdate"
/// </summary>
public static void JsonSerializeOrderMainCreateOrUpdateJSONSerialize1 (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
