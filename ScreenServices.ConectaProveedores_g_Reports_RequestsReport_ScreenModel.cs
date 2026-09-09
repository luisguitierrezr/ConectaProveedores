using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_RequestsReport_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_RequestsReport_ScreenModel).Namespace);

    public bool varLcLoading;
public int varLcStartIndex;
public string varLcTableSort;
public bool varLcIsToEmpty;
public string varLcColumnJSONVar;
public bool varLcReInvokeToggler;
public int varLcCountAfterFetch;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> ScreenDataSetGetApplicants;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public ConectaProveedores_g_Reports_RequestsReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model varLcGetOrderRequests;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_RequestsReport_ScreenModel() {
}



    public ConectaProveedores_g_Reports_RequestsReport_ScreenModel(bool varLcLoading, int varLcStartIndex, string varLcTableSort, bool varLcIsToEmpty, string varLcColumnJSONVar, bool varLcReInvokeToggler, int varLcCountAfterFetch, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> ScreenDataSetGetApplicants, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, ConectaProveedores_g_Reports_RequestsReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model varLcGetOrderRequests, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"Loading", "StartIndex", "TableSort", "IsToEmpty", "ColumnJSONVar", "ReInvokeToggler", "CountAfterFetch", "GetRegions", "GetApplicants", "GetCompanies", "GetUserApplicationRoles", "GetOrderRequests", "ClientVars"}, new string[] {"varLcLoading", "varLcStartIndex", "varLcTableSort", "varLcIsToEmpty", "varLcColumnJSONVar", "varLcReInvokeToggler", "varLcCountAfterFetch", "ScreenDataSetGetRegions", "ScreenDataSetGetApplicants", "ScreenDataSetGetCompanies", "varLcGetUserApplicationRoles", "varLcGetOrderRequests", "clientVariables"});
this.varLcLoading = varLcLoading;
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.varLcIsToEmpty = varLcIsToEmpty;
this.varLcColumnJSONVar = varLcColumnJSONVar;
this.varLcReInvokeToggler = varLcReInvokeToggler;
this.varLcCountAfterFetch = varLcCountAfterFetch;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetApplicants = ScreenDataSetGetApplicants;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.varLcGetOrderRequests = varLcGetOrderRequests;
this.clientVariables = clientVariables;
}



    
// Query Function "GetRegions" dqLaatlR10Sxwil3bkU1qg of Action "RequestsReport"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.RequestsReport.GetRegions", "6adaa276-51d9-44d7-b1c2-29776e4535aa");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequestsReport","g_Reports.RequestsReport.GetRegions");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.cUA+JskPOUaOvIgLg3E7NA/ScreenDataSets.dqLaatlR10Sxwil3bkU1qg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion94\".\"id\" o0, NULL o1, \"enregion94\".\"name\" o2, NULL o3, \"enregion94\".\"centrortp\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion94\"");
whereBuilder.Append(" WHERE (\"enregion94\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion94\".\"code\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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

// Query Function "GetApplicants" 3k_Eo6Llwk2CA7d5GsXNNw of Action "RequestsReport"
public static async Task<(RL_89fdc2de9b4f3c518b096795c532253b,long)> datasetGetApplicants(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.RequestsReport.GetApplicants", "a3c44fde-e5a2-4dc2-8203-b7791ac5cd37");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequestsReport","g_Reports.RequestsReport.GetApplicants");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.cUA+JskPOUaOvIgLg3E7NA/ScreenDataSets.3k_Eo6Llwk2CA7d5GsXNNw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicant1\".\"applicant\" o1, \"enapplicant1\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {Applicant} \"enapplicant1\"");
orderByBuilder.Append(" ORDER BY \"enapplicant1\".\"applicant\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetApplicants.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetApplicants.List", cancellationToken: cancellationToken);
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

// Query Function "GetCompanies" Y5F95hXaYUaJantlhOLFcA of Action "RequestsReport"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.RequestsReport.GetCompanies", "e67d9163-da15-4661-896a-7b6584e2c570");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequestsReport","g_Reports.RequestsReport.GetCompanies");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.cUA+JskPOUaOvIgLg3E7NA/ScreenDataSets.Y5F95hXaYUaJantlhOLFcA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany27\".\"id\" o0, \"encompany27\".\"externalid\" o1, \"encompany27\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany27\"");
orderByBuilder.Append(" ORDER BY \"encompany27\".\"externalid\" ASC ");
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetCompanies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetCompanies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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


    public class lcvGetUserApplicationRoles : VarsBag {
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersByUserId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersByUserId_outParamCount = 0L;

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public long outParamUserRegion = 0L;

public long outParamSupplierId = 0L;

public bool outParamIsAllRegions = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(long,long,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamUserRegion = default;
long outParamSupplierId = default;
bool outParamIsAllRegions = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_g_Reports_RequestsReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "b65662c8-77f7-4b6f-af09-3cd5cdaaf556"))
using (activitySource.CreateScreenDataActionActivity("RequestsReport", "GetUserApplicationRoles")){
// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// Query datasetGetSupplierUsersByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUsersByUserId_maxRecords = 1;
if (datasetGetSupplierUsersByUserId_maxRecords < 1) datasetGetSupplierUsersByUserId_maxRecords = 1;
int datasetGetSupplierUsersByUserId_startIndex = 0;(localVars.queryResGetSupplierUsersByUserId_outParamList,localVars.queryResGetSupplierUsersByUserId_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetSupplierUsersByUserId(requestContext,datasetGetSupplierUsersByUserId_maxRecords,datasetGetSupplierUsersByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetRegionCorp
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCorp_maxRecords = 1;
if (datasetGetRegionCorp_maxRecords < 1) datasetGetRegionCorp_maxRecords = 1;
int datasetGetRegionCorp_startIndex = 0;(localVars.queryResGetRegionCorp_outParamList,localVars.queryResGetRegionCorp_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRegionCorp(requestContext,datasetGetRegionCorp_maxRecords,datasetGetRegionCorp_startIndex,IterationMultiplicity.Never,cancellationToken);

// UserRegion = GetUserRegionId.o_RegionId
result.outParamUserRegion=localVars.resGetUserRegionId.outParamo_RegionId;

// SupplierId = GetSupplierUsersByUserId.List.Current.SupplierUser.SupplierId
result.outParamSupplierId=localVars.queryResGetSupplierUsersByUserId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId;

// IsAllRegions = GetUserRegionId.o_RegionId = NullIdentifier or GetUserRegionId.o_RegionId = GetRegionCorp.List.Current.Region.Id
result.outParamIsAllRegions=((localVars.resGetUserRegionId.outParamo_RegionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(localVars.resGetUserRegionId.outParamo_RegionId==localVars.queryResGetRegionCorp_outParamList.CurrentRec.ssENRegion.ssId));
} //close CreateActionActivity using block
} // try

finally {
outParamUserRegion = result.outParamUserRegion;
outParamSupplierId = result.outParamSupplierId;
outParamIsAllRegions = result.outParamIsAllRegions;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRegion,outParamSupplierId,outParamIsAllRegions);
}
public class lcvGetOrderRequests : VarsBag {
public RL_f5a2fdd028de7dc3b32fee45ae563140 queryResGetOrderRequest_outParamList = new RL_f5a2fdd028de7dc3b32fee45ae563140();
public long queryResGetOrderRequest_outParamCount = 0L;

public Actions.lcoCheckUserSession resCheckUserSession =  new Actions.lcoCheckUserSession();
public RL_516b8a2b0fa040ead03115e8bb85ea9b queryResGetOrderCount_outParamList = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
public long queryResGetOrderCount_outParamCount = 0L;

public lcvGetOrderRequests() {
}
}
public class lcoGetOrderRequests : VarsBag {
public RL_f5a2fdd028de7dc3b32fee45ae563140 outParamList2 = new RL_f5a2fdd028de7dc3b32fee45ae563140();

public int outParamCount = 0;

public lcoGetOrderRequests() {
}
}
/// <summary>
/// Action <code>GetOrderRequests</code> that represents the Service Studio action
///  <code>GetOrderRequests</code> <p> Description: </p>
/// </summary>
public async Task<(RL_f5a2fdd028de7dc3b32fee45ae563140,int)> DataActionGetOrderRequests(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_f5a2fdd028de7dc3b32fee45ae563140 outParamList2 = default;
int outParamCount = default;
lcoGetOrderRequests result = new lcoGetOrderRequests();
lcvGetOrderRequests localVars = new lcvGetOrderRequests();
ConectaProveedores_g_Reports_RequestsReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderRequests", "dd6e1584-a7f4-421f-aa5c-31827aadcb4a"))
using (activitySource.CreateScreenDataActionActivity("RequestsReport", "GetOrderRequests")){
// CheckUserSession
localVars.resCheckUserSession.outParamIsValidSession = await Actions.ActionCheckUserSession(requestContext,cancellationToken);

// Query QueryGetOrderRequest
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrderRequest_maxRecords = 0;
int QueryGetOrderRequest_startIndex = 0;(localVars.queryResGetOrderRequest_outParamList,localVars.queryResGetOrderRequest_outParamCount) = await FuncDataActionGetOrderRequests.QueryGetOrderRequest(requestContext,QueryGetOrderRequest_maxRecords,QueryGetOrderRequest_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.NullTextIdentifier (),model.clientVariables.ssReport63_StartDate,model.clientVariables.ssReport63_EndDate,model.clientVariables.ssReport63_OrderNumber,varLcGetUserApplicationRoles.outParamUserRegion,varLcGetUserApplicationRoles.outParamIsAllRegions,model.clientVariables.ssReport63_SociedadId,model.clientVariables.ssReport63_SupplierId,model.clientVariables.ssReport63_Applicant,varLcIsToEmpty,model.clientVariables.ssReport63_RegionId,varLcGetUserApplicationRoles.outParamSupplierId,model.clientVariables.ssMaxRecords,varLcStartIndex,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,(model.clientVariables.ssOffsetUtc*(-1)),cancellationToken);

// Query QueryGetOrderCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrderCount_maxRecords = 0;
int QueryGetOrderCount_startIndex = 0;(localVars.queryResGetOrderCount_outParamList,localVars.queryResGetOrderCount_outParamCount) = await FuncDataActionGetOrderRequests.QueryGetOrderCount(requestContext,QueryGetOrderCount_maxRecords,QueryGetOrderCount_startIndex,IterationMultiplicity.Never,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.NullTextIdentifier (),model.clientVariables.ssReport63_StartDate,model.clientVariables.ssReport63_EndDate,model.clientVariables.ssReport63_OrderNumber,varLcGetUserApplicationRoles.outParamUserRegion,varLcGetUserApplicationRoles.outParamIsAllRegions,model.clientVariables.ssReport63_SociedadId,model.clientVariables.ssReport63_SupplierId,model.clientVariables.ssReport63_Applicant,varLcIsToEmpty,model.clientVariables.ssReport63_RegionId,varLcGetUserApplicationRoles.outParamSupplierId,(model.clientVariables.ssOffsetUtc*(-1)),cancellationToken);

// List2 = GetOrderRequest.List
result.outParamList2=localVars.queryResGetOrderRequest_outParamList;

// Count = GetOrderCount.List.Current.Total.Value
result.outParamCount=(((int)localVars.queryResGetOrderCount_outParamList.CurrentRec.ssSTTotal.ssValue));
} //close CreateActionActivity using block
} // try

finally {
outParamList2 = result.outParamList2;
outParamCount = result.outParamCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamList2,outParamCount);
}


    public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetSupplierUsersByUserId" P_PbEWJYbk+VxuRt+UAnjg of Action "GetUserApplicationRoles"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.RequestsReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "11dbf33f-5862-4f6e-95c6-e46df940278e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.RequestsReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "11dbf33f-5862-4f6e-95c6-e46df940278e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.cUA+JskPOUaOvIgLg3E7NA/DataActions.yGJWtvd3b0uvCTzVzar1Vg/NodesNotShownInESpaceTree.P_PbEWJYbk+VxuRt+UAnjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"ensupplieruser16\".\"supplierid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser16\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser16\".\"userid\" = @qpusUserId) AND (\"ensupplieruser16\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser16\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser16\".\"name\" ASC ");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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

// Query Function "GetRegionCorp" XNi30yvIL0CQH23AzNOEMg of Action "GetUserApplicationRoles"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.RequestsReport.GetUserApplicationRoles.GetRegionCorp", "d3b7d85c-c82b-402f-901f-6dc0ccd38432");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.RequestsReport.GetUserApplicationRoles.GetRegionCorp", "d3b7d85c-c82b-402f-901f-6dc0ccd38432", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.cUA+JskPOUaOvIgLg3E7NA/DataActions.yGJWtvd3b0uvCTzVzar1Vg/NodesNotShownInESpaceTree.XNi30yvIL0CQH23AzNOEMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion95\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion95\"");
whereBuilder.Append(" WHERE (\"enregion95\".\"isactive\" = 1) AND (\"enregion95\".\"centrortp\" = 'MX00')");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
public static class FuncDataActionGetOrderRequests {

private static async Task<RC_aae113dc341165a54f51793c1371eeba> QueryGetOrderRequestReadDbAsync(RC_aae113dc341165a54f51793c1371eeba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read(r, ref index);
rec.ssENOrderStatus.Read(r, ref index);
rec.ssENCompany.Read(r, ref index);
rec.ssENSupplier.Read(r, ref index);
rec.ssENOrderDetail.Read(r, ref index);
rec.ssENOrderMainItem.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENOrderMainItemStatus.Read(r, ref index);
rec.ssENOrderApprovalLevel.Read(r, ref index);
rec.ssENUser.Read(r, ref index);
rec.ssENUser_Extended_Internal.Read(r, ref index);
rec.ssSTDeliveryStatus.Read(r, ref index);
rec.ssSTTotal.Read(r, ref index);
rec.ssSTQtdDelivered.Read(r, ref index);
rec.ssSTQuantityAvailable.Read(r, ref index);
return rec;
}
// Query Function "GetOrderRequest" 6iPSJ4fZm0G41oGdOvbsbA of Action "GetOrderRequests"
public static async Task<(RL_f5a2fdd028de7dc3b32fee45ae563140,long)> QueryGetOrderRequest(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaNulldate,long qploNullIdentifier,string qpteNullTextIdentifier,DateTime qpdaReport63_StartDate,DateTime qpdaReport63_EndDate,string qpteReport63_OrderNumber,long qpreUserRegion,bool qpboIsAllRegions,long qpcoReport63_SociedadId,long qpsuReport63_SupplierId,string qpteReport63_Applicant,bool qpboIsToEmpty,long qpreReport63_RegionId,long qpsuSupplierId,int qpinMaxRecords,int qpinStartIndex,int qpfoFolioStatusIdCanceled,int qpfoFolioStatusIdCanceledByProvider,int qpinOffsetUtc,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("g_Reports.RequestsReport.GetOrderRequests.GetOrderRequest", "27d223ea-d987-419b-b8d6-819d3af6ec6c");
using var queryActivity = activitySource.CreateSqlQueryActivity("g_Reports.RequestsReport.GetOrderRequests.GetOrderRequest", "27d223ea-d987-419b-b8d6-819d3af6ec6c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderDetail = AppUtils.Instance.RuntimeEntityReplace("OrderDetail");
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
sqlCmd.CreateParameter("@qpfoFolioStatusIdCanceled", DbType.Int32, qpfoFolioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoFolioStatusIdCanceledByProvider", DbType.Int32, qpfoFolioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qpdaReport63_StartDate", DbType.DateTime, qpdaReport63_StartDate);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpdaReport63_EndDate", DbType.DateTime, qpdaReport63_EndDate);
sqlCmd.CreateParameter("@qpteReport63_OrderNumber", DbType.String, qpteReport63_OrderNumber);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpcoReport63_SociedadId", DbType.Int64, qpcoReport63_SociedadId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpsuReport63_SupplierId", DbType.Int64, qpsuReport63_SupplierId);
sqlCmd.CreateParameter("@qpteReport63_Applicant", DbType.String, qpteReport63_Applicant);
sqlCmd.CreateParameter("@qpteNullTextIdentifier", DbType.String, qpteNullTextIdentifier);
sqlCmd.CreateParameter("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCmd.CreateParameter("@qpreReport63_RegionId", DbType.Int64, qpreReport63_RegionId);
sqlCmd.CreateParameter("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinStartIndex", DbType.Int32, qpinStartIndex);
string sql = "";
string advSql = "SELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"previousorderstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"assignmentcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"documenttypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"procurementgroup\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"creatorsapnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"creatorsapname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"country\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isdeleted\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isreleased\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"exchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"sustainabilitycategory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"sustainabilitysubcategory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"totalamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"fromcosmoz\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"updatedon\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"labeles\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"rfc\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"postalcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"cyaimport\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"fspuse\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedby\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"tratamiento\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"conceptobusq_1_2\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"calle_numero\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"distrito\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"codigopostal_pobl_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"pais\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"region_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"idioma\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"telefono\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"extension\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"fax\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"cliente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"soc_glasociada\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"clavedegrupo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"n_ident_fis_1\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"personafisica\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"ramo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"grupodeporte\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"email\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"regionid\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"isapprovalfromuserarea\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectassetserviceid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectassetservice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectdescription\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"businessvaluecategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"businessvaluesubcategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"paymenttermsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"paymentmethodid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"negotiatedexchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"contractstatus\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"dateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"hasdeposit\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"hasinsurance\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"distributionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"hasadvancepayment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"retentionrate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"hasbasedate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"startbasedate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"endbasedate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"contractnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"isretentionapplied\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"frequency\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"period\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderretentiontypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"paymentoptionsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"paymentwaysid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderscontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"contractamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"contracttarif\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"contractsupplier\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"isdependentfromfolios\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"specialapprovalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"allcontactfilesvalidated\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"hasntrequestdocuments\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"documentclassid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unittype\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"glaccountid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"costcenterid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"fundscenter\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"fund\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"commitmentitem\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatindicator\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatprocedure\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"purchaserequisitionnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"purchaserequisitionitemnr\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"center\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"applicant\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"direction\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"contractnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"contractposition\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"contractstartdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"contractenddate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"contractplannedvalue\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"positiontype\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"serialnumberprofile\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"batchmanaged\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialtype\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"itemgroup\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderrequestcreatorsapnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"invoiceusageid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainitemstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"divisionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"updatedon\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"is_active\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"orderapprovalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"levelnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"entraroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"assignedto\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"assignedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"rejectedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"rejectedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"iscomplement\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"isreassigned\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"issubstitutefor\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"tomodifyby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"tomodifyon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"wascanceledby\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"email\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"photourl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"username\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"employeenumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"managedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"departmentid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"managementid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"subdirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"city\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"jobtitle\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"onpremisesdistinguishedname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"hasrolesassigned\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"lastsync\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"telceldireccion\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " = ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n            ), 0) + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,2))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            ), 0) \n        ) \n            THEN 'Entregada' \n        WHEN ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n            ), 0) + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            ), 0) \n        ) > 0 \n            THEN 'Entrega parcial' \n        ELSE 'Disponible' \n    END AS DeliveryStatus, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " * ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + " /  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ") as Total, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n    ), 0) + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        AND ( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n    OR ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 \n    ) \n) \n    ), 0) as QtdDelivered, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " - ( \n        COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled  \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n        ), 0)  +  COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n                OR ( \n                     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n                    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 \n                ) \n                ) \n        ), 0) \n    ) AS QuantityAvailable \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainitemstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " \n    ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"orderapprovalid\"") + "  \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"levelnumber\"") + ") \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"assignedto\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " \nWHERE  \n    ( \n        @qpdaReport63_StartDate = @qpdaNulldate  \n        OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) >= @qpdaReport63_StartDate \n    )        \n \n    AND ( \n        @qpdaReport63_EndDate = @qpdaNulldate  \n        OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) <= @qpdaReport63_EndDate \n    ) \n \n    AND ( \n        TRIM(@qpteReport63_OrderNumber) = ''  \n        OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " collate \"default\") ILIKE '%' || @qpteReport63_OrderNumber || '%' \n    ) \n \n    AND ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreUserRegion  \n        OR @qpboIsAllRegions = 1 \n    ) \n \n    AND ( \n        @qpcoReport63_SociedadId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " = @qpcoReport63_SociedadId \n    ) \n \n    AND ( \n        @qpsuReport63_SupplierId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuReport63_SupplierId \n    ) \n \n    AND ( \n        @qpteReport63_Applicant = @qpteNullTextIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + " = @qpteReport63_Applicant \n    ) \n \n    AND ( \n        @qpboIsToEmpty = 0 \n    ) \n \n    AND ( \n        @qpreReport63_RegionId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreReport63_RegionId \n    ) \n \n    AND ( \n        @qpsuSupplierId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuSupplierId \n    ) \n \nORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \nLIMIT @qpinMaxRecords::int \nOFFSET @qpinStartIndex::int;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_f5a2fdd028de7dc3b32fee45ae563140 outParamList = new RL_f5a2fdd028de7dc3b32fee45ae563140();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetOrderRequestReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[15];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false});
opt[9] = new BitArray(new bool[] {false});
opt[10] = new BitArray(new bool[] {false});
opt[11] = new BitArray(new bool[] {false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[13] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[14] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetOrderRequests.GetOrderRequest.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f5a2fdd028de7dc3b32fee45ae563140 _tmp = new RL_f5a2fdd028de7dc3b32fee45ae563140();
_tmp.AlternateReadDbMethodAsync = QueryGetOrderRequestReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetOrderRequests.GetOrderRequest.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f5a2fdd028de7dc3b32fee45ae563140)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrderRequest in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT       {OrderMain}.*,      {OrderStatus}.*,      {Company}.*,      {Supplier}.*,      {OrderDetail}.*,      {OrderMainItem}.*,      {Currency}.*,      {OrderMainItemStatus}.*,      {OrderApprovalLevel}.*,      {User}.*,      {User_Extended_Internal}.*,      CASE          WHEN {OrderMainItem}.[Quantity] = (              {OrderMainItem}.[QuantityDelivered] + COALESCE((                  SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))                  FROM {FolioItems}                  inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]                  WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]                  and ({Folio}.[FolioStatusId] <> @FolioStatusIdCanceled and {Folio}.[FolioStatusId] <> @FolioStatusIdCanceledByProvider)              ), 0) + COALESCE((                  SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))                  FROM {OrderItemEntries}                  WHERE {OrderItemEntries}.[OrderMainItemid] = {O ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderRequest in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT       {OrderMain}.*,      {OrderStatus}.*,      {Company}.*,      {Supplier}.*,      {OrderDetail}.*,      {OrderMainItem}.*,      {Currency}.*,      {OrderMainItemStatus}.*,      {OrderApprovalLevel}.*,      {User}.*,      {User_Extended_Internal}.*,      CASE          WHEN {OrderMainItem}.[Quantity] = (              {OrderMainItem}.[QuantityDelivered] + COALESCE((                  SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))                  FROM {FolioItems}                  inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]                  WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]                  and ({Folio}.[FolioStatusId] <> @FolioStatusIdCanceled and {Folio}.[FolioStatusId] <> @FolioStatusIdCanceledByProvider)              ), 0) + COALESCE((                  SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))                  FROM {OrderItemEntries}                  WHERE {OrderItemEntries}.[OrderMainItemid] = {O ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderRequest in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT       {OrderMain}.*,      {OrderStatus}.*,      {Company}.*,      {Supplier}.*,      {OrderDetail}.*,      {OrderMainItem}.*,      {Currency}.*,      {OrderMainItemStatus}.*,      {OrderApprovalLevel}.*,      {User}.*,      {User_Extended_Internal}.*,      CASE          WHEN {OrderMainItem}.[Quantity] = (              {OrderMainItem}.[QuantityDelivered] + COALESCE((                  SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))                  FROM {FolioItems}                  inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]                  WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]                  and ({Folio}.[FolioStatusId] <> @FolioStatusIdCanceled and {Folio}.[FolioStatusId] <> @FolioStatusIdCanceledByProvider)              ), 0) + COALESCE((                  SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))                  FROM {OrderItemEntries}                  WHERE {OrderItemEntries}.[OrderMainItemid] = {O ...): " + aqExcep.Message));
}
}
}

// Query Function "GetOrderCount" eXbp1bSY2EWKwYzBw7gBrw of Action "GetOrderRequests"
public static async Task<(RL_516b8a2b0fa040ead03115e8bb85ea9b,long)> QueryGetOrderCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaNulldate,long qploNullIdentifier,string qpteNullTextIdentifier,DateTime qpdaReport63_StartDate,DateTime qpdaReport63_EndDate,string qpteReport63_OrderNumber,long qpreUserRegion,bool qpboIsAllRegions,long qpcoReport63_SociedadId,long qpsuReport63_SupplierId,string qpteReport63_Applicant,bool qpboIsToEmpty,long qpreReport63_RegionId,long qpsuSupplierId,int qpinOffsetUtc,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("g_Reports.RequestsReport.GetOrderRequests.GetOrderCount", "d5e97679-98b4-45d8-8ac1-8cc1c3b801af");
using var queryActivity = activitySource.CreateSqlQueryActivity("g_Reports.RequestsReport.GetOrderRequests.GetOrderCount", "d5e97679-98b4-45d8-8ac1-8cc1c3b801af", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderDetail = AppUtils.Instance.RuntimeEntityReplace("OrderDetail");
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
sqlCmd.CreateParameter("@qpdaReport63_StartDate", DbType.DateTime, qpdaReport63_StartDate);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpdaReport63_EndDate", DbType.DateTime, qpdaReport63_EndDate);
sqlCmd.CreateParameter("@qpteReport63_OrderNumber", DbType.String, qpteReport63_OrderNumber);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpcoReport63_SociedadId", DbType.Int64, qpcoReport63_SociedadId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpsuReport63_SupplierId", DbType.Int64, qpsuReport63_SupplierId);
sqlCmd.CreateParameter("@qpteReport63_Applicant", DbType.String, qpteReport63_Applicant);
sqlCmd.CreateParameter("@qpteNullTextIdentifier", DbType.String, qpteNullTextIdentifier);
sqlCmd.CreateParameter("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCmd.CreateParameter("@qpreReport63_RegionId", DbType.Int64, qpreReport63_RegionId);
sqlCmd.CreateParameter("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
string sql = "";
string advSql = "SELECT count(1) \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainitemstatusid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr  \n    ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\"  \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\") \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr  \n    ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \n     \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr  \n    ON User_Curr.\"id\" = UserExt_Curr.\"id\" \n \nWHERE  \n    ( \n        @qpdaReport63_StartDate = @qpdaNulldate  \n        OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) >= @qpdaReport63_StartDate \n    ) \n \n    AND ( \n        @qpdaReport63_EndDate = @qpdaNulldate  \n        OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) <= @qpdaReport63_EndDate \n    ) \n \n    AND ( \n        TRIM(@qpteReport63_OrderNumber) = ''  \n        OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " collate \"default\") ILIKE '%' || @qpteReport63_OrderNumber || '%' \n    ) \n \n    AND ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreUserRegion  \n        OR @qpboIsAllRegions = 1 \n    ) \n \n    AND ( \n        @qpcoReport63_SociedadId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " = @qpcoReport63_SociedadId \n    ) \n \n    AND ( \n        @qpsuReport63_SupplierId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuReport63_SupplierId \n    ) \n \n    AND ( \n        @qpteReport63_Applicant = @qpteNullTextIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + " = @qpteReport63_Applicant \n    ) \n \n    AND ( \n        @qpboIsToEmpty = 0 \n    ) \n \n    AND ( \n        @qpreReport63_RegionId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreReport63_RegionId \n    ) \n \n    AND ( \n        @qpsuSupplierId = @qploNullIdentifier  \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuSupplierId \n    )";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_516b8a2b0fa040ead03115e8bb85ea9b outParamList = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.RequestsReport.GetOrderRequests.GetOrderCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_516b8a2b0fa040ead03115e8bb85ea9b _tmp = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.RequestsReport.GetOrderRequests.GetOrderCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_516b8a2b0fa040ead03115e8bb85ea9b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrderCount in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT count(1)  FROM {OrderMain}    LEFT JOIN {OrderStatus}       ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]    LEFT JOIN {Company}       ON {OrderMain}.[CompanyId] = {Company}.[Id]    LEFT JOIN {Supplier}       ON {OrderMain}.[SupplierId] = {Supplier}.[Id]    LEFT JOIN {OrderDetail}       ON {OrderDetail}.[OrderId] = {OrderMain}.[Id]    LEFT JOIN {OrderMainItem}       ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]    LEFT JOIN {Currency}       ON {OrderMain}.[CurrencyId] = {Currency}.[Code]    LEFT JOIN {OrderMainItemStatus}       ON {OrderMainItemStatus}.[Id] = {OrderMainItem}.[OrderMainItemStatusId]    LEFT JOIN {OrderApproval}      ON {OrderMain}.[Id] = {OrderApproval}.[OrderId]    LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr       ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId]       AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])    LEFT JOIN {User} User_Curr       ON OrderApprovalLevel_Curr.[AssignedTo] =  ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCount in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT count(1)  FROM {OrderMain}    LEFT JOIN {OrderStatus}       ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]    LEFT JOIN {Company}       ON {OrderMain}.[CompanyId] = {Company}.[Id]    LEFT JOIN {Supplier}       ON {OrderMain}.[SupplierId] = {Supplier}.[Id]    LEFT JOIN {OrderDetail}       ON {OrderDetail}.[OrderId] = {OrderMain}.[Id]    LEFT JOIN {OrderMainItem}       ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]    LEFT JOIN {Currency}       ON {OrderMain}.[CurrencyId] = {Currency}.[Code]    LEFT JOIN {OrderMainItemStatus}       ON {OrderMainItemStatus}.[Id] = {OrderMainItem}.[OrderMainItemStatusId]    LEFT JOIN {OrderApproval}      ON {OrderMain}.[Id] = {OrderApproval}.[OrderId]    LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr       ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId]       AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])    LEFT JOIN {User} User_Curr       ON OrderApprovalLevel_Curr.[AssignedTo] =  ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCount in GetOrderRequests in RequestsReport in g_Reports in ConectaProveedores (SELECT count(1)  FROM {OrderMain}    LEFT JOIN {OrderStatus}       ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]    LEFT JOIN {Company}       ON {OrderMain}.[CompanyId] = {Company}.[Id]    LEFT JOIN {Supplier}       ON {OrderMain}.[SupplierId] = {Supplier}.[Id]    LEFT JOIN {OrderDetail}       ON {OrderDetail}.[OrderId] = {OrderMain}.[Id]    LEFT JOIN {OrderMainItem}       ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]    LEFT JOIN {Currency}       ON {OrderMain}.[CurrencyId] = {Currency}.[Code]    LEFT JOIN {OrderMainItemStatus}       ON {OrderMainItemStatus}.[Id] = {OrderMainItem}.[OrderMainItemStatusId]    LEFT JOIN {OrderApproval}      ON {OrderMain}.[Id] = {OrderApproval}.[OrderId]    LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr       ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId]       AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])    LEFT JOIN {User} User_Curr       ON OrderApprovalLevel_Curr.[AssignedTo] =  ...): " + aqExcep.Message));
}
}
}
}


}
