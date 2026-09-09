namespace ssConectaProveedores;

public partial class Actions {
public class lcvHotfixRequisitionsToFillTelcelDirectionId : VarsBag {
public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternals_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternals_outParamCount = 0L;

public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitions_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitions_outParamCount = 0L;

public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserByIdOrEmail_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserByIdOrEmail_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();

public long resServiceTelcelDirectionCreate_outParamId = 0L;

public RL_9895159eebcdcdaed80fbd832f52d838 queryResGetTelcelDirectionsByName_outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
public long queryResGetTelcelDirectionsByName_outParamCount = 0L;

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public lcvHotfixRequisitionsToFillTelcelDirectionId() {
}
}
/// <summary>
/// Action <code>HotfixRequisitionsToFillTelcelDirectionId</code> that represents the Service Studio
///  action <code>HotfixRequisitionsToFillTelcelDirectionId</code> <p> Description: </p>
/// </summary>
public static async Task ActionHotfixRequisitionsToFillTelcelDirectionId(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvHotfixRequisitionsToFillTelcelDirectionId localVars = new lcvHotfixRequisitionsToFillTelcelDirectionId();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HotfixRequisitionsToFillTelcelDirectionId", "0ac28a41-e168-4cbe-8300-3097bb434513"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HotfixRequisitionsToFillTelcelDirectionId", "0ac28a41-e168-4cbe-8300-3097bb434513", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitions_maxRecords = 0;
int datasetGetRequisitions_startIndex = 0;(localVars.queryResGetRequisitions_outParamList,localVars.queryResGetRequisitions_outParamCount) = await FuncActionHotfixRequisitionsToFillTelcelDirectionId.datasetGetRequisitions(requestContext,datasetGetRequisitions_maxRecords,datasetGetRequisitions_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetRequisitions.List
localVars.queryResGetRequisitions_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitions_outParamList.Eof))) {
if(((localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssApplicantId!=BuiltInFunction.NullTextIdentifier ()))) {
// Query datasetGetUserExtendedInternals
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternals_maxRecords = 1;
if (datasetGetUserExtendedInternals_maxRecords < 1) datasetGetUserExtendedInternals_maxRecords = 1;
int datasetGetUserExtendedInternals_startIndex = 0;(localVars.queryResGetUserExtendedInternals_outParamList,localVars.queryResGetUserExtendedInternals_outParamCount) = await FuncActionHotfixRequisitionsToFillTelcelDirectionId.datasetGetUserExtendedInternals(requestContext,datasetGetUserExtendedInternals_maxRecords,datasetGetUserExtendedInternals_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

if(((localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser_Extended_Internal.ssTelcelDirectionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// GetUserByIdOrEmail
(localVars.resGetUserByIdOrEmail_outParamResult,localVars.resGetUserByIdOrEmail_outParamResponse) = await Actions.ActionGetUserByIdOrEmail(requestContext,(((localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// IsSuccess?
if((localVars.resGetUserByIdOrEmail_outParamResult.ssIsSuccess)) {
// Query datasetGetTelcelDirectionsByName
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTelcelDirectionsByName_maxRecords = 1;
if (datasetGetTelcelDirectionsByName_maxRecords < 1) datasetGetTelcelDirectionsByName_maxRecords = 1;
int datasetGetTelcelDirectionsByName_startIndex = 0;(localVars.queryResGetTelcelDirectionsByName_outParamList,localVars.queryResGetTelcelDirectionsByName_outParamCount) = await FuncActionHotfixRequisitionsToFillTelcelDirectionId.datasetGetTelcelDirectionsByName(requestContext,datasetGetTelcelDirectionsByName_maxRecords,datasetGetTelcelDirectionsByName_startIndex,IterationMultiplicity.Never,localVars.resGetUserByIdOrEmail_outParamResponse.ssextension_914754251c5a475cadb45125f912505d_telceld,cancellationToken);

// Not found?
if((localVars.queryResGetTelcelDirectionsByName_outParamList.Empty)) {
// ServiceTelcelDirectionCreate
localVars.resServiceTelcelDirectionCreate_outParamId = await ServiceAPIs.ServiceAPIServiceTelcelDirectionCreate(requestContext,new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssName = localVars.resGetUserByIdOrEmail_outParamResponse.ssextension_914754251c5a475cadb45125f912505d_telceld, ssIsActive = true, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssUpdatedOn = BuiltInFunction.CurrDateTime (), ssUpdatedBy = BuiltInFunction.NullTextIdentifier () },cancellationToken);

// GetRequisitions.List.Current.Requisition.TelcelDirectionId = ServiceTelcelDirectionCreate.Id
localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssTelcelDirectionId = localVars.resServiceTelcelDirectionCreate_outParamId;
} else {
// GetRequisitions.List.Current.Requisition.TelcelDirectionId = GetTelcelDirectionsByName.List.Current.TelcelDirection.Id
localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssTelcelDirectionId = localVars.queryResGetTelcelDirectionsByName_outParamList.CurrentRec.ssENTelcelDirection.ssId;
}

} else {
localVars.queryResGetRequisitions_outParamList.Advance();
continue;
}

} else {
// GetRequisitions.List.Current.Requisition.TelcelDirectionId = GetUserExtendedInternals.List.Current.User_Extended_Internal.TelcelDirectionId
localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssTelcelDirectionId = localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser_Extended_Internal.ssTelcelDirectionId;
}

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition,cancellationToken);

}

localVars.queryResGetRequisitions_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitions_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionHotfixRequisitionsToFillTelcelDirectionId {

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserExtendedInternalsReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternals" ly_CEe+8rEKR9_wanQq4xQ of Action "HotfixRequisitionsToFillTelcelDirectionId"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixRequisitionsToFillTelcelDirectionId.GetUserExtendedInternals", "11c22f97-bcef-42ac-91f7-fc1a9d0ab8c5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixRequisitionsToFillTelcelDirectionId.GetUserExtendedInternals", "11c22f97-bcef-42ac-91f7-fc1a9d0ab8c5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.QYrCCmjhvkyDADCXu0NFEw/NodesNotShownInESpaceTree.ly_CEe+8rEKR9_wanQq4xQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser10\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enuser_extended_internal5\".\"telceldirectionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enuserextension5\".\"correspondentexternalemail\" o26, NULL o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal5\" Inner JOIN {User} \"enuser10\" ON (\"enuser_extended_internal5\".\"id\" = \"enuser10\".\"id\"))  Left JOIN {UserExtension} \"enuserextension5\" ON (\"enuser10\".\"id\" = \"enuserextension5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser10\".\"id\" = @qpusUser_Id) AND (\"enuser10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser10\".\"id\" IS NULL)");
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
RL_bc2063fe1d05aa544017f329fb1e030b outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixRequisitionsToFillTelcelDirectionId.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixRequisitionsToFillTelcelDirectionId.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bc2063fe1d05aa544017f329fb1e030b)_tmp;
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

// Query Function "GetRequisitions" fuEHL2p20kaNgj0AFpINMQ of Action "HotfixRequisitionsToFillTelcelDirectionId"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixRequisitionsToFillTelcelDirectionId.GetRequisitions", "2f07e17e-766a-46d2-8d82-3d0016920d31");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixRequisitionsToFillTelcelDirectionId.GetRequisitions", "2f07e17e-766a-46d2-8d82-3d0016920d31", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.QYrCCmjhvkyDADCXu0NFEw/NodesNotShownInESpaceTree.fuEHL2p20kaNgj0AFpINMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition5\".\"id\" o0, \"enrequisition5\".\"name\" o1, \"enrequisition5\".\"counter\" o2, \"enrequisition5\".\"requisitionstatusid\" o3, \"enrequisition5\".\"supplierid\" o4, \"enrequisition5\".\"regionid\" o5, \"enrequisition5\".\"accountingregionid\" o6, \"enrequisition5\".\"applicantid\" o7, \"enrequisition5\".\"maxdatefinishcapture\" o8, \"enrequisition5\".\"projectassetserviceid\" o9, \"enrequisition5\".\"projectassetservice\" o10, \"enrequisition5\".\"projectdescription\" o11, \"enrequisition5\".\"frequencyid\" o12, \"enrequisition5\".\"issustainability\" o13, \"enrequisition5\".\"sustainabilityid\" o14, \"enrequisition5\".\"businessvaluecategoryid\" o15, \"enrequisition5\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition5\".\"totalamount\"::numeric) o17, \"enrequisition5\".\"currencyid\" o18, \"enrequisition5\".\"distributionid\" o19, \"enrequisition5\".\"costcenterid\" o20, \"enrequisition5\".\"hascontract\" o21, \"enrequisition5\".\"iscontractpending\" o22, \"enrequisition5\".\"hasdeposit\" o23, \"enrequisition5\".\"hasinsurance\" o24, \"enrequisition5\".\"hasadvancepayment\" o25, \"enrequisition5\".\"accountingservicetypeid_depr\" o26, \"enrequisition5\".\"servicedescription_deprec\" o27, \"enrequisition5\".\"invoiceusageid_deprec\" o28, \"enrequisition5\".\"serviceformatid\" o29, \"enrequisition5\".\"companyid\" o30, trim_scale(\"enrequisition5\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition5\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition5\".\"paymentmethodid\" o33, \"enrequisition5\".\"paymenttermsid\" o34, \"enrequisition5\".\"isautomaticaccounting\" o35, \"enrequisition5\".\"createdby\" o36, \"enrequisition5\".\"createdon\" o37, \"enrequisition5\".\"updatedon\" o38, \"enrequisition5\".\"updatedby\" o39, \"enrequisition5\".\"createdbyapplicationrole\" o40, \"enrequisition5\".\"dateofcommitment\" o41, \"enrequisition5\".\"hascontractfileuploaded\" o42, \"enrequisition5\".\"hasupdateddateofcommitment\" o43, \"enrequisition5\".\"submittedon\" o44, \"enrequisition5\".\"isdonation\" o45, \"enrequisition5\".\"advwithoutinvoice\" o46, \"enrequisition5\".\"wasadvwithoutinvoice\" o47, \"enrequisition5\".\"isadvanced\" o48, \"enrequisition5\".\"documenttypeid\" o49, \"enrequisition5\".\"iscreatedbyanassistente\" o50, \"enrequisition5\".\"telceldirectionid\" o51, \"enrequisition5\".\"hasmultiupload\" o52, \"enrequisition5\".\"accountingdate\" o53, \"enrequisition5\".\"paymentoptionsid\" o54, \"enrequisition5\".\"paymentwaysid\" o55, \"enrequisition5\".\"buydocnumber\" o56, \"enrequisition5\".\"buydocposition\" o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition5\"");
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixRequisitionsToFillTelcelDirectionId.GetRequisitions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixRequisitionsToFillTelcelDirectionId.GetRequisitions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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

// Query Function "GetTelcelDirectionsByName" L4GTZKnjP06eHt75srxDIg of Action "HotfixRequisitionsToFillTelcelDirectionId"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetTelcelDirectionsByName(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixRequisitionsToFillTelcelDirectionId.GetTelcelDirectionsByName", "6493812f-e3a9-4e3f-9e1e-def9b2bc4322");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixRequisitionsToFillTelcelDirectionId.GetTelcelDirectionsByName", "6493812f-e3a9-4e3f-9e1e-def9b2bc4322", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.QYrCCmjhvkyDADCXu0NFEw/NodesNotShownInESpaceTree.L4GTZKnjP06eHt75srxDIg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entelceldirection\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection\"");
whereBuilder.Append(" WHERE (\"entelceldirection\".\"name\" = @qpteName)");
orderByBuilder.Append(" ORDER BY \"entelceldirection\".\"name\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteName", DbType.String, qpteName);
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixRequisitionsToFillTelcelDirectionId.GetTelcelDirectionsByName.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixRequisitionsToFillTelcelDirectionId.GetTelcelDirectionsByName.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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



}


}
