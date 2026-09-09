namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersDistribution_Assignment : VarsBag {
public long inParamOrderDistributionConfigId;
public long inParamOrderMainId;
public bool inParamSendEmails;
public bool inParamUpdateOrder;
/// <summary>
/// Variable <code>LevelNumber</code> that represents the Service Studio Integer
///  <code>LevelNumber</code> <p>Description: </p>
/// </summary>
public int varLcLevelNumber = 1;

public RL_44cb753cf22fd0b01aa78a5ab2f30079 queryResGetRequestDistributionConfigById_outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
public long queryResGetRequestDistributionConfigById_outParamCount = 0L;

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainById_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainById_outParamCount = 0L;

public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderApprovalCreate resOrderApprovalCreate =  new Actions.lcoOrderApprovalCreate();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public RL_0688c4264713247af7bc090251768cdb queryResCorrectRegionDivision_outParamList = new RL_0688c4264713247af7bc090251768cdb();
public long queryResCorrectRegionDivision_outParamCount = 0L;

public lcvOrdersDistribution_Assignment(long inParamOrderDistributionConfigId, long inParamOrderMainId, bool inParamSendEmails, bool inParamUpdateOrder) {
this.inParamOrderDistributionConfigId = inParamOrderDistributionConfigId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamSendEmails = inParamSendEmails;
this.inParamUpdateOrder = inParamUpdateOrder;
}
}
public class lcoOrdersDistribution_Assignment : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public long outParamPositionFirstContactId = 0L;

public lcoOrdersDistribution_Assignment() {
}
}
/// <summary>
/// Action <code>OrdersDistribution_Assignment</code> that represents the Service Studio action
///  <code>OrdersDistribution_Assignment</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_9f3831cec6ebd34416b59b8df7a27893Structure,long)> ActionOrdersDistribution_Assignment(IRequestContext requestContext,long inParamOrderDistributionConfigId,long inParamOrderMainId,bool inParamSendEmails,bool inParamUpdateOrder,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
long outParamPositionFirstContactId = default;
lcoOrdersDistribution_Assignment result = new lcoOrdersDistribution_Assignment();
lcvOrdersDistribution_Assignment localVars = new lcvOrdersDistribution_Assignment(inParamOrderDistributionConfigId, inParamOrderMainId, inParamSendEmails, inParamUpdateOrder);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersDistribution_Assignment", "7fc6d530-f324-4efd-bed6-89a6d2f09630"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersDistribution_Assignment", "7fc6d530-f324-4efd-bed6-89a6d2f09630", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),"OrdersDistribution_Assignment: Start","OrdersDistribution_Assignment",cancellationToken);

// Query datasetGetRequestDistributionConfigById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequestDistributionConfigById_maxRecords = 1;
if (datasetGetRequestDistributionConfigById_maxRecords < 1) datasetGetRequestDistributionConfigById_maxRecords = 1;
int datasetGetRequestDistributionConfigById_startIndex = 0;(localVars.queryResGetRequestDistributionConfigById_outParamList,localVars.queryResGetRequestDistributionConfigById_outParamCount) = await FuncActionOrdersDistribution_Assignment.datasetGetRequestDistributionConfigById(requestContext,datasetGetRequestDistributionConfigById_maxRecords,datasetGetRequestDistributionConfigById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderDistributionConfigId,cancellationToken);

if(((((localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssFirstContact_EntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssSecondContact_EntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))||(localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Output Variables
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.Identifier = OrderMainId
result.outParamResult.ssIdentifier = localVars.inParamOrderMainId;

// Result.ErrorMessage = "Impossible to distribute. Configuration found but it is incomplete."
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("6UK9fhlAu0KLIu33POM4qA#Value.665593627.1", "Impossible to distribute. Configuration found but it is incomplete.");
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersDistribution_Assignment: "+result.outParamResult.ssErrorMessage),"OrdersDistribution_Assignment",cancellationToken);

} else {
// OrdersDistribution_DeleteOld
await Actions.ActionOrdersDistribution_DeleteOld(requestContext,localVars.inParamOrderMainId,cancellationToken);

// OrderApprovalCreate
localVars.resOrderApprovalCreate.outParamId = await Actions.ActionOrderApprovalCreate(requestContext,new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParamOrderMainId, ssCurrentLevel = 1, ssMaxLevel = (((localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (3) : (4)), ssStartedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

if((localVars.inParamUpdateOrder)) {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 1;
if (datasetGetOrderMainById_maxRecords < 1) datasetGetOrderMainById_maxRecords = 1;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionOrdersDistribution_Assignment.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// Query QueryCorrectRegionDivision
cancellationToken.ThrowIfCancellationRequested();
int QueryCorrectRegionDivision_maxRecords = 1;
if (QueryCorrectRegionDivision_maxRecords < 1) QueryCorrectRegionDivision_maxRecords = 1;
int QueryCorrectRegionDivision_startIndex = 0;(localVars.queryResCorrectRegionDivision_outParamList,localVars.queryResCorrectRegionDivision_outParamCount) = await FuncActionOrdersDistribution_Assignment.QueryCorrectRegionDivision(requestContext,QueryCorrectRegionDivision_maxRecords,QueryCorrectRegionDivision_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssRegionId,localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssRegionId,BuiltInFunction.LongIntegerToText(localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssDirectionId),cancellationToken);

// GetOrderMainById.List.Current.OrderMain.RegionId = LongIntegerToIdentifier
localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssRegionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResCorrectRegionDivision_outParamList.CurrentRec.ssSTNewRegionId.ssValue);

// GetOrderMainById.List.Current.OrderMain.DivisionId = LongIntegerToIdentifier
localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssDivisionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResCorrectRegionDivision_outParamList.CurrentRec.ssSTNewDivisionId.ssValue);

// GetOrderMainById.List.Current.OrderMain.OrderStatusId = ToComplement
localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId;
// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

}

while (((localVars.varLcLevelNumber<=(((localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (3) : (4))))) {
// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderApprovalId = localVars.resOrderApprovalCreate.outParamId, ssLevelNumber = localVars.varLcLevelNumber, ssEntraRoleId = (((localVars.varLcLevelNumber==1)) ? (localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssFirstContact_EntraRoleId) : ((((localVars.varLcLevelNumber==2)) ? (localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssSecondContact_EntraRoleId) : ((((localVars.varLcLevelNumber==3)) ? (localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId) : (localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId)))))), ssApprovalStatusId = (((localVars.varLcLevelNumber==1)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bxcfUQnAU0CWvUsA+ZfAjw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)) },cancellationToken);

if((((localVars.varLcLevelNumber==1)&&localVars.inParamSendEmails))) {
// OrdersDistribution_SendEmails
await Actions.ActionOrdersDistribution_SendEmails(requestContext,localVars.inParamOrderMainId,cancellationToken);

}

// LevelNumber = LevelNumber + 1
localVars.varLcLevelNumber=(localVars.varLcLevelNumber+1);
}

// Output Variables
// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.Identifier = OrderMainId
result.outParamResult.ssIdentifier = localVars.inParamOrderMainId;

// PositionFirstContactId = GetRequestDistributionConfigById.List.Current.OrderDistributionConfig.FirstContact_EntraRoleId
result.outParamPositionFirstContactId=localVars.queryResGetRequestDistributionConfigById_outParamList.CurrentRec.ssENOrderDistributionConfig.ssFirstContact_EntraRoleId;
// ControledLogMessage3
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),"OrdersDistribution_Assignment: End","OrdersDistribution_Assignment",cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Output Variables
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.Identifier = OrderMainId
result.outParamResult.ssIdentifier = localVars.inParamOrderMainId;

// Result.ErrorMessage = AllExceptions.ExceptionMessage
result.outParamResult.ssErrorMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResult = result.outParamResult;
outParamPositionFirstContactId = result.outParamPositionFirstContactId;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamResult,outParamPositionFirstContactId);
}

public static class FuncActionOrdersDistribution_Assignment {

// Query Function "GetRequestDistributionConfigById" hzDGY4Kk20KyJWSspgoxrA of Action "OrdersDistribution_Assignment"
public static async Task<(RL_44cb753cf22fd0b01aa78a5ab2f30079,long)> datasetGetRequestDistributionConfigById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_Assignment.GetRequestDistributionConfigById", "63c63087-a482-42db-b225-64aca60a31ac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_Assignment.GetRequestDistributionConfigById", "63c63087-a482-42db-b225-64aca60a31ac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.MNXGfyTz_U6+1omm0vCWMA/NodesNotShownInESpaceTree.hzDGY4Kk20KyJWSspgoxrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enorderdistributionconfig3\".\"regionid\" o1, NULL o2, NULL o3, \"enorderdistributionconfig3\".\"directionid\" o4, \"enorderdistributionconfig3\".\"firstcontact_entraroleid\" o5, \"enorderdistributionconfig3\".\"secondcontact_entraroleid\" o6, \"enorderdistributionconfig3\".\"firstapprover_entraroleid\" o7, \"enorderdistributionconfig3\".\"secondapprover_entraroleid\" o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {OrderDistributionConfig} \"enorderdistributionconfig3\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderdistributionconfig3\".\"id\" = @qporId) AND (\"enorderdistributionconfig3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderdistributionconfig3\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, false, false, false, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_Assignment.GetRequestDistributionConfigById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_Assignment.GetRequestDistributionConfigById.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderMainById" Is9zgL79lEuQ+x_p+eY5zQ of Action "OrdersDistribution_Assignment"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_Assignment.GetOrderMainById", "8073cf22-fdbe-4b94-90fb-1fe9f9e639cd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_Assignment.GetOrderMainById", "8073cf22-fdbe-4b94-90fb-1fe9f9e639cd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.MNXGfyTz_U6+1omm0vCWMA/NodesNotShownInESpaceTree.Is9zgL79lEuQ+x_p+eY5zQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain39\".\"id\" o0, \"enordermain39\".\"ordernumber\" o1, \"enordermain39\".\"orderdate\" o2, \"enordermain39\".\"orderstatusid\" o3, \"enordermain39\".\"previousorderstatusid\" o4, \"enordermain39\".\"assignmentcode\" o5, \"enordermain39\".\"supplierid\" o6, \"enordermain39\".\"companyid\" o7, \"enordermain39\".\"documenttypeid\" o8, \"enordermain39\".\"currencyid\" o9, \"enordermain39\".\"telceldirectionid\" o10, \"enordermain39\".\"procurementgroup\" o11, \"enordermain39\".\"creatorsapnumber\" o12, \"enordermain39\".\"creatorsapname\" o13, \"enordermain39\".\"country\" o14, \"enordermain39\".\"isdeleted\" o15, \"enordermain39\".\"isreleased\" o16, trim_scale(\"enordermain39\".\"exchangerate\"::numeric) o17, \"enordermain39\".\"sustainabilitycategory\" o18, \"enordermain39\".\"sustainabilitysubcategory\" o19, trim_scale(\"enordermain39\".\"totalamount\"::numeric) o20, \"enordermain39\".\"fromcosmoz\" o21, \"enordermain39\".\"regionid\" o22, \"enordermain39\".\"divisionid\" o23, \"enordermain39\".\"applicant\" o24, \"enordermain39\".\"createdby\" o25, \"enordermain39\".\"createdon\" o26, \"enordermain39\".\"updatedby\" o27, \"enordermain39\".\"updatedon\" o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain39\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain39\".\"id\" = @qporId) AND (\"enordermain39\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain39\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_Assignment.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_Assignment.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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

private static async Task<RC_957af43c68dca2b8260b54a010c3971e> QueryCorrectRegionDivisionReadDbAsync(RC_957af43c68dca2b8260b54a010c3971e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSTNewRegionId.Read(r, ref index);
rec.ssSTNewDivisionId.Read(r, ref index);
rec.ssSTNewDirectionId.Read(r, ref index);
return rec;
}
// Query Function "CorrectRegionDivision" EgxR9x3T60isuRvfiXj66A of Action "OrdersDistribution_Assignment"
public static async Task<(RL_0688c4264713247af7bc090251768cdb,long)> QueryCorrectRegionDivision(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploDivisionId,long qploRegionId,string qpteDirection,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("OrdersDistribution_Assignment.CorrectRegionDivision", "f7510c12-d31d-48eb-acb9-1bdf8978fae8");
using var queryActivity = activitySource.CreateSqlQueryActivity("OrdersDistribution_Assignment.CorrectRegionDivision", "f7510c12-d31d-48eb-acb9-1bdf8978fae8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
sqlCmd.CreateParameter("@qploRegionId", DbType.Int64, qploRegionId);
sqlCmd.CreateParameter("@qploDivisionId", DbType.Int64, qploDivisionId);
sqlCmd.CreateParameter("@qpteDirection", DbType.String, qpteDirection);
string sql = "";
string advSql = "SELECT  \n    @qploRegionId \"newregionid\", \n    ( \n    CASE WHEN  \n        (SELECT SUBSTRING( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", 3, 2) FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " = @qploRegionId ) = '00'  \n    THEN \n        @qploDivisionId \n    ELSE \n        @qploRegionId \n    END \n    ) \"newdivisionid\", \n    (SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"name\"") + " = @qpteDirection) \"newdirectionid\"";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0688c4264713247af7bc090251768cdb outParamList = new RL_0688c4264713247af7bc090251768cdb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryCorrectRegionDivisionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false});
opt[1] = new BitArray(new bool[] {false});
opt[2] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_Assignment.CorrectRegionDivision.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0688c4264713247af7bc090251768cdb _tmp = new RL_0688c4264713247af7bc090251768cdb();
_tmp.AlternateReadDbMethodAsync = QueryCorrectRegionDivisionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_Assignment.CorrectRegionDivision.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0688c4264713247af7bc090251768cdb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("CorrectRegionDivision in OrdersDistribution_Assignment in ConectaProveedores (SELECT       @RegionId [NewRegionId],      (      CASE WHEN           (SELECT SUBSTRING({Region}.[CentroRTP], 3, 2) FROM {Region} WHERE {Region}.[Id] = @RegionId ) = '00'       THEN          @DivisionId      ELSE          @RegionId      END      ) [NewDivisionId],      (SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direction) [NewDirectionId]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("CorrectRegionDivision in OrdersDistribution_Assignment in ConectaProveedores (SELECT       @RegionId [NewRegionId],      (      CASE WHEN           (SELECT SUBSTRING({Region}.[CentroRTP], 3, 2) FROM {Region} WHERE {Region}.[Id] = @RegionId ) = '00'       THEN          @DivisionId      ELSE          @RegionId      END      ) [NewDivisionId],      (SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direction) [NewDirectionId]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("CorrectRegionDivision in OrdersDistribution_Assignment in ConectaProveedores (SELECT       @RegionId [NewRegionId],      (      CASE WHEN           (SELECT SUBSTRING({Region}.[CentroRTP], 3, 2) FROM {Region} WHERE {Region}.[Id] = @RegionId ) = '00'       THEN          @DivisionId      ELSE          @RegionId      END      ) [NewDivisionId],      (SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direction) [NewDirectionId]): " + aqExcep.Message));
}
}
}



}


}
