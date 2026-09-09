namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveAndValidateOrderDistributionConfig : VarsBag {
public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource;
public string inParamJustification;
public string inParamOriginalJSON;
/// <summary>
/// Variable <code>ChangeJSON</code> that represents the Service Studio Text <code>ChangeJSON</code>
///  <p>Description: </p>
/// </summary>
public string varLcChangeJSON = "";

/// <summary>
/// Variable <code>UserName</code> that represents the Service Studio Text <code>UserName</code>
///  <p>Description: </p>
/// </summary>
public string varLcUserName = "";

/// <summary>
/// Variable <code>JobTitle</code> that represents the Service Studio Text <code>JobTitle</code>
///  <p>Description: </p>
/// </summary>
public string varLcJobTitle = "";

public Actions.lcoCreateOrUpdateOrderDistribution resCreateOrUpdateOrderDistribution =  new Actions.lcoCreateOrUpdateOrderDistribution();
public Actions.lcoGetUserById resGetUserById =  new Actions.lcoGetUserById();
public RL_44cb753cf22fd0b01aa78a5ab2f30079 queryResGetRequestDistributionConfigsByGroup_outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
public long queryResGetRequestDistributionConfigsByGroup_outParamCount = 0L;

public RL_89fdc2de9b4f3c518b096795c532253b queryResGetApplicantsByApplicant_outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
public long queryResGetApplicantsByApplicant_outParamCount = 0L;

public long resServiceApplicantCreateOrUpdate_outParamId = 0L;

public string resJSONSerialize1_outParamJSON = "";
public lcvSaveAndValidateOrderDistributionConfig(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource, string inParamJustification, string inParamOriginalJSON) {
this.inParamSource = inParamSource;
this.inParamJustification = inParamJustification;
this.inParamOriginalJSON = inParamOriginalJSON;
}
}
public class lcoSaveAndValidateOrderDistributionConfig : VarsBag {
public long outParamId = 0L;

public bool outParamHasSuccess = false;

public string outParamErrorMessage = "";

public lcoSaveAndValidateOrderDistributionConfig() {
}
}
/// <summary>
/// Action <code>SaveAndValidateOrderDistributionConfig</code> that represents the Service Studio
///  action <code>SaveAndValidateOrderDistributionConfig</code> <p> Description: </p>
/// </summary>
public static async Task<(long,bool,string)> ActionSaveAndValidateOrderDistributionConfig(IRequestContext requestContext,EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource,string inParamJustification,string inParamOriginalJSON,CancellationToken cancellationToken) {
long outParamId = default;
bool outParamHasSuccess = default;
string outParamErrorMessage = default;
lcoSaveAndValidateOrderDistributionConfig result = new lcoSaveAndValidateOrderDistributionConfig();
lcvSaveAndValidateOrderDistributionConfig localVars = new lcvSaveAndValidateOrderDistributionConfig(inParamSource, inParamJustification, inParamOriginalJSON);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveAndValidateOrderDistributionConfig", "9a37d238-4362-448d-8cd0-dbb40768b0dc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveAndValidateOrderDistributionConfig", "9a37d238-4362-448d-8cd0-dbb40768b0dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetUserById
localVars.resGetUserById.outParamResult = await Actions.ActionGetUserById(requestContext,BuiltInFunction.GetUserId (),cancellationToken);

// JSON Serialize JsonSerializeSaveAndValidateOrderDistributionConfigJSONSerialize1
FuncActionSaveAndValidateOrderDistributionConfig.JsonSerializeSaveAndValidateOrderDistributionConfigJSONSerialize1(localVars.inParamSource, out localVars.resJSONSerialize1_outParamJSON);
// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;

// ChangeJSON = JSONSerialize1.JSON
localVars.varLcChangeJSON=localVars.resJSONSerialize1_outParamJSON;

// UserName = GetUserById.Result.User.Name
localVars.varLcUserName=localVars.resGetUserById.outParamResult.ssENUser.ssName;

// JobTitle = GetUserById.Result.User_Extended_Internal.JobTitle
localVars.varLcJobTitle=localVars.resGetUserById.outParamResult.ssENUser_Extended_Internal.ssJobTitle;
// Mandatory attributes validation
if((((((((localVars.inParamSource.ssRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.inParamSource.ssApplicant!=""))&&(localVars.inParamSource.ssDirectionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssFirstContact_EntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssSecondContact_EntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssFirstApprover_EntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetRequestDistributionConfigsByGroup
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequestDistributionConfigsByGroup_maxRecords = 0;
int datasetGetRequestDistributionConfigsByGroup_startIndex = 0;(localVars.queryResGetRequestDistributionConfigsByGroup_outParamList,localVars.queryResGetRequestDistributionConfigsByGroup_outParamCount) = await FuncActionSaveAndValidateOrderDistributionConfig.datasetGetRequestDistributionConfigsByGroup(requestContext,datasetGetRequestDistributionConfigsByGroup_maxRecords,datasetGetRequestDistributionConfigsByGroup_startIndex,IterationMultiplicity.Never,localVars.inParamSource.ssApplicant,localVars.inParamSource.ssApplicantDescription,localVars.inParamSource.ssDirectionId,localVars.inParamSource.ssId,localVars.inParamSource.ssRegionId,cancellationToken);

// Exists
if(((!localVars.queryResGetRequestDistributionConfigsByGroup_outParamList.Empty))) {
// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = "Already exists an equal distribution"
result.outParamErrorMessage=AppUtils.GetStringResource("V8MfkmqrJU2Bj8dpOIWAVQ#Value.1802409191.1", "Already exists an equal distribution");
// AuditCreateWrapper
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 1, ssIdentifier = result.outParamId, ssMessage = (((((((("An error ocurred when"+" ")+localVars.varLcUserName)+" (")+localVars.varLcJobTitle)+") ")+"tried to change a distribution. Error")+": ")+result.outParamErrorMessage), ssOriginalJSON = localVars.inParamOriginalJSON, ssChangeJSON = localVars.resJSONSerialize1_outParamJSON },cancellationToken);

} else {
// Query datasetGetApplicantsByApplicant
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicantsByApplicant_maxRecords = 1;
if (datasetGetApplicantsByApplicant_maxRecords < 1) datasetGetApplicantsByApplicant_maxRecords = 1;
int datasetGetApplicantsByApplicant_startIndex = 0;(localVars.queryResGetApplicantsByApplicant_outParamList,localVars.queryResGetApplicantsByApplicant_outParamCount) = await FuncActionSaveAndValidateOrderDistributionConfig.datasetGetApplicantsByApplicant(requestContext,datasetGetApplicantsByApplicant_maxRecords,datasetGetApplicantsByApplicant_startIndex,IterationMultiplicity.Never,localVars.inParamSource.ssApplicant,cancellationToken);

// empty?
if((localVars.queryResGetApplicantsByApplicant_outParamList.Empty)) {
// ServiceApplicantCreateOrUpdate
localVars.resServiceApplicantCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceApplicantCreateOrUpdate(requestContext,new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssApplicant = localVars.inParamSource.ssApplicant, ssDescription = localVars.inParamSource.ssApplicantDescription },cancellationToken);

}

// CreateOrUpdateOrderDistribution
localVars.resCreateOrUpdateOrderDistribution.outParamId = await Actions.ActionCreateOrUpdateOrderDistribution(requestContext,localVars.inParamSource,cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderDistribution.Id
result.outParamId=localVars.resCreateOrUpdateOrderDistribution.outParamId;

// HasSuccess = True
result.outParamHasSuccess=true;
// AuditCreateWrapper4
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 1, ssIdentifier = result.outParamId, ssMessage = (((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((("A distribution was created by "+localVars.varLcUserName)+" (")+localVars.varLcJobTitle)+")")) : (((((("A distribution was changed by "+localVars.varLcUserName)+" (")+localVars.varLcJobTitle)+") because ")+localVars.inParamJustification))), ssOriginalJSON = localVars.inParamOriginalJSON, ssChangeJSON = localVars.resJSONSerialize1_outParamJSON },cancellationToken);

}

} else {
// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = "Mandatory fields are required"
result.outParamErrorMessage=AppUtils.GetStringResource("oRAE95v310eqWuLsuTsvGg#Value.1103836427.1", "Mandatory fields are required");
// AuditCreateWrapper2
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 1, ssIdentifier = result.outParamId, ssMessage = (((((((("An error ocurred when"+" ")+localVars.varLcUserName)+" (")+localVars.varLcJobTitle)+") ")+"tried to change a distribution. Error")+": ")+result.outParamErrorMessage), ssOriginalJSON = localVars.inParamOriginalJSON, ssChangeJSON = localVars.resJSONSerialize1_outParamJSON },cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = AllExceptions.ExceptionMessage
result.outParamErrorMessage=ex.Message;
// AuditCreateWrapper3
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 1, ssIdentifier = result.outParamId, ssMessage = (((((((("An error ocurred when"+" ")+localVars.varLcUserName)+" (")+localVars.varLcJobTitle)+") ")+"tried to change a distribution. Error")+": ")+result.outParamErrorMessage), ssOriginalJSON = localVars.inParamOriginalJSON, ssChangeJSON = localVars.varLcChangeJSON },cancellationToken);

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

public static class FuncActionSaveAndValidateOrderDistributionConfig {

// Query Function "GetRequestDistributionConfigsByGroup" 6yxrcVbB8kGgyWVXqBrzJg of Action "SaveAndValidateOrderDistributionConfig"
public static async Task<(RL_44cb753cf22fd0b01aa78a5ab2f30079,long)> datasetGetRequestDistributionConfigsByGroup(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteApplicant,string qpteApplicantDescription,long qpteDirectionId,long qporId,long qpreRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveAndValidateOrderDistributionConfig.GetRequestDistributionConfigsByGroup", "716b2ceb-c156-41f2-a0c9-6557a81af326");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveAndValidateOrderDistributionConfig.GetRequestDistributionConfigsByGroup", "716b2ceb-c156-41f2-a0c9-6557a81af326", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.ONI3mmJDjUSM0Nu0B2iw3A/NodesNotShownInESpaceTree.6yxrcVbB8kGgyWVXqBrzJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {OrderDistributionConfig} \"enorderdistributionconfig4\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enorderdistributionconfig4\".\"regionid\" = @qpreRegionId) AND (\"enorderdistributionconfig4\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enorderdistributionconfig4\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderdistributionconfig4\".\"applicant\" = @qpteApplicant) AND (\"enorderdistributionconfig4\".\"applicantdescription\" = @qpteApplicantDescription) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteApplicant", DbType.String, qpteApplicant);
sqlCmd.CreateParameterWithoutReplacements("@qpteApplicantDescription", DbType.String, qpteApplicantDescription);
if (qpteDirectionId != 0) {
whereBuilder.Append("((\"enorderdistributionconfig4\".\"directionid\" = @qpteDirectionId) AND (\"enorderdistributionconfig4\".\"directionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteDirectionId", DbType.Int64, qpteDirectionId);
} else {
whereBuilder.Append("(\"enorderdistributionconfig4\".\"directionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderdistributionconfig4\".\"id\" <> @qporId) OR (\"enorderdistributionconfig4\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderdistributionconfig4\".\"id\" IS NOT NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_44cb753cf22fd0b01aa78a5ab2f30079 outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveAndValidateOrderDistributionConfig.GetRequestDistributionConfigsByGroup.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_44cb753cf22fd0b01aa78a5ab2f30079 _tmp = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveAndValidateOrderDistributionConfig.GetRequestDistributionConfigsByGroup.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_44cb753cf22fd0b01aa78a5ab2f30079)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetApplicantsByApplicant" yVtHr4gF60uEKx0Jl+QvEg of Action "SaveAndValidateOrderDistributionConfig"
public static async Task<(RL_89fdc2de9b4f3c518b096795c532253b,long)> datasetGetApplicantsByApplicant(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteApplicant,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveAndValidateOrderDistributionConfig.GetApplicantsByApplicant", "af475bc9-0588-4beb-842b-1d0997e42f12");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveAndValidateOrderDistributionConfig.GetApplicantsByApplicant", "af475bc9-0588-4beb-842b-1d0997e42f12", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.ONI3mmJDjUSM0Nu0B2iw3A/NodesNotShownInESpaceTree.yVtHr4gF60uEKx0Jl+QvEg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {Applicant} \"enapplicant\"");
whereBuilder.Append(" WHERE ((Upper((trim(\"enapplicant\".\"applicant\")))) = (Upper((trim(@qpteApplicant)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteApplicant", DbType.String, qpteApplicant);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_89fdc2de9b4f3c518b096795c532253b outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveAndValidateOrderDistributionConfig.GetApplicantsByApplicant.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_89fdc2de9b4f3c518b096795c532253b _tmp = new RL_89fdc2de9b4f3c518b096795c532253b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveAndValidateOrderDistributionConfig.GetApplicantsByApplicant.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_89fdc2de9b4f3c518b096795c532253b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



/// <summary>
/// JSONSerialize: JsonSerializeSaveAndValidateOrderDistributionConfigJSONSerialize1
///  (KdmQn7mF130qiAc6NxnYwDQ)  of Action "SaveAndValidateOrderDistributionConfig"
/// </summary>
public static void JsonSerializeSaveAndValidateOrderDistributionConfigJSONSerialize1 (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
