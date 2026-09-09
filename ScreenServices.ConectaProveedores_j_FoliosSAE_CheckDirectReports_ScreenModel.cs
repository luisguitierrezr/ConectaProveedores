using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel).Namespace);

    public string varLcl_ColumnJSONVar;
public bool varLcl_ReInvokeToggler;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model varLcGetFolios;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel(string varLcl_ColumnJSONVar, bool varLcl_ReInvokeToggler, string varLcl_TableSort, int varLcl_StartIndex, ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model varLcGetFolios, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ColumnJSONVar", "l_ReInvokeToggler", "l_TableSort", "l_StartIndex", "GetFolios", "ClientVars"}, new string[] {"varLcl_ColumnJSONVar", "varLcl_ReInvokeToggler", "varLcl_TableSort", "varLcl_StartIndex", "varLcGetFolios", "clientVariables"});
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcGetFolios = varLcGetFolios;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFolios : VarsBag {
public RL_d6c492838bba25b2d8eac44d00689146 resListDistinct_outParamDistinctList = new RL_d6c492838bba25b2d8eac44d00689146();

public RL_752c66ffcb633a1081093541635464e7 queryResGetUserDirectReport_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserDirectReport_outParamCount = 0L;

public ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure resGetDirectReportsList_outParamUsers = new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetDirectReportsList_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserById_outParamCount = 0L;

public RL_d6c492838bba25b2d8eac44d00689146 queryResGetFolioById_outParamList = new RL_d6c492838bba25b2d8eac44d00689146();
public long queryResGetFolioById_outParamCount = 0L;

public lcvGetFolios() {
}
}
public class lcoGetFolios : VarsBag {
public RL_d6c492838bba25b2d8eac44d00689146 outParamList = new RL_d6c492838bba25b2d8eac44d00689146();

public lcoGetFolios() {
}
}
/// <summary>
/// Action <code>GetFolios</code> that represents the Service Studio action <code>GetFolios</code> <p>
///  Description: </p>
/// </summary>
public async Task<RL_d6c492838bba25b2d8eac44d00689146> DataActionGetFolios(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_d6c492838bba25b2d8eac44d00689146 outParamList = default;
lcoGetFolios result = new lcoGetFolios();
lcvGetFolios localVars = new lcvGetFolios();
ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolios", "4e2b868a-5237-40a6-8ec4-f964c4eba37c"))
using (activitySource.CreateScreenDataActionActivity("CheckDirectReports", "GetFolios")){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncDataActionGetFolios.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// GetDirectReportsList
(localVars.resGetDirectReportsList_outParamUsers,localVars.resGetDirectReportsList_outParamResult) = await Actions.ActionGetDirectReportsList(requestContext,(((localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamList,cancellationToken);

// Foreach GetDirectReportsList.Users.Value
localVars.resGetDirectReportsList_outParamUsers.ssValue.StartIteration();
try {while (!((localVars.resGetDirectReportsList_outParamUsers.ssValue.Eof))) {
// Query datasetGetUserDirectReport
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserDirectReport_maxRecords = 1;
if (datasetGetUserDirectReport_maxRecords < 1) datasetGetUserDirectReport_maxRecords = 1;
int datasetGetUserDirectReport_startIndex = 0;(localVars.queryResGetUserDirectReport_outParamList,localVars.queryResGetUserDirectReport_outParamCount) = await FuncDataActionGetFolios.datasetGetUserDirectReport(requestContext,datasetGetUserDirectReport_maxRecords,datasetGetUserDirectReport_startIndex,IterationMultiplicity.Never,localVars.resGetDirectReportsList_outParamUsers.ssValue.CurrentRec.ssId,cancellationToken);

// Empty?
if((!(localVars.queryResGetUserDirectReport_outParamList.Empty))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetFolios.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Single,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),localVars.queryResGetUserDirectReport_outParamList.CurrentRec.ssENUser_Extended_Internal.ssRegionId,localVars.queryResGetUserDirectReport_outParamList.CurrentRec.ssENUser.ssId,(await Functions.ActionGetUserEntraRoleId(requestContext,localVars.queryResGetUserDirectReport_outParamList.CurrentRec.ssENUser.ssId,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,localVars.queryResGetUserDirectReport_outParamList.CurrentRec.ssENUser.ssId,2,true,false,cancellationToken)),cancellationToken);

// Empty?
if((!(localVars.queryResGetFolioById_outParamList.Empty))) {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamList,localVars.queryResGetFolioById_outParamList,cancellationToken);

}

}

localVars.resGetDirectReportsList_outParamUsers.ssValue.Advance();
}

} finally {
localVars.resGetDirectReportsList_outParamUsers.ssValue.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_d6c492838bba25b2d8eac44d00689146) result.outParamList.Distinct()));

// List = ListDistinct.DistinctList
result.outParamList=localVars.resListDistinct_outParamDistinctList;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetFolios {

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserDirectReportReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserDirectReport" w8czDmhHB0eGnIU3ts+8Sg of Action "GetFolios"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserDirectReport(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteUser_Extended_Internal_EntraId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.CheckDirectReports.GetFolios.GetUserDirectReport", "0e33c7c3-4768-4707-869c-8537b6cfbc4a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.CheckDirectReports.GetFolios.GetUserDirectReport", "0e33c7c3-4768-4707-869c-8537b6cfbc4a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.t8p5D4LINE2v7WdwRylvEg/DataActions.ioYrTjdSpkCOxPlkxOujfA/NodesNotShownInESpaceTree.w8czDmhHB0eGnIU3ts+8Sg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser226\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser_extended_internal134\".\"regionid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User} \"enuser226\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal134\" ON (\"enuser226\".\"id\" = \"enuser_extended_internal134\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal134\".\"entraid\" = @qpteUser_Extended_Internal_EntraId)");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_EntraId", DbType.String, qpteUser_Extended_Internal_EntraId);
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserDirectReportReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetUserDirectReport.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserDirectReportReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetUserDirectReport.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" c5KXOaInB0OqDGmAN++ahQ of Action "GetFolios"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.CheckDirectReports.GetFolios.GetUserById", "39979273-27a2-4307-aa0c-698037ef9a85");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.CheckDirectReports.GetFolios.GetUserById", "39979273-27a2-4307-aa0c-698037ef9a85", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.t8p5D4LINE2v7WdwRylvEg/DataActions.ioYrTjdSpkCOxPlkxOujfA/NodesNotShownInESpaceTree.c5KXOaInB0OqDGmAN++ahQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser227\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension82\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser227\" Left JOIN {UserExtension} \"enuserextension82\" ON (\"enuser227\".\"id\" = \"enuserextension82\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser227\".\"id\" = @qpusUser_Id) AND (\"enuser227\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser227\".\"id\" IS NULL)");
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
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
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

private static async Task<RC_9387247c408750aafc8750d323f6a93d> datasetGetFolioByIdReadDbAsync(RC_9387247c408750aafc8750d323f6a93d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser_CreatedBy.Read( r, ref index);
rec.ssENUser_UpdatedBy.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 8qAo4XAQN0+Tyb+UYfswcQ of Action "GetFolios"
public static async Task<(RL_d6c492838bba25b2d8eac44d00689146,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreGetMR00RegionId,long qpreRegionId,string qpusFolioApprovalLevel_AssignedTo,long qpenFolioApprovalLevel_EntraRoleId,long qpapFolioApprovalLevel_ApplicationRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.CheckDirectReports.GetFolios.GetFolioById", "e128a0f2-1070-4f37-93c9-bf9461fb3071");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.CheckDirectReports.GetFolios.GetFolioById", "e128a0f2-1070-4f37-93c9-bf9461fb3071", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.t8p5D4LINE2v7WdwRylvEg/DataActions.ioYrTjdSpkCOxPlkxOujfA/NodesNotShownInESpaceTree.8qAo4XAQN0+Tyb+UYfswcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany63\".\"id\" o0, \"encompany63\".\"externalid\" o1, \"encompany63\".\"description\" o2, \"encompany63\".\"rfc\" o3, \"encompany63\".\"postalcode\" o4, \"encompany63\".\"cyaimport\" o5, \"encompany63\".\"fspuse\" o6, \"encompany63\".\"createdon\" o7, \"encompany63\".\"createdby\" o8, \"encompany63\".\"updatedon\" o9, \"encompany63\".\"updatedby\" o10, \"encurrency42\".\"code\" o11, \"encurrency42\".\"name\" o12, \"encurrency42\".\"symbol\" o13, \"encurrency42\".\"minorunitdecimals\" o14, \"encurrency42\".\"isactive\" o15, \"enfolio80\".\"id\" o16, \"enfolio80\".\"isdraft\" o17, \"enfolio80\".\"folionumber\" o18, \"enfolio80\".\"canproveedorcancel\" o19, \"enfolio80\".\"orderid\" o20, \"enfolio80\".\"supplierid\" o21, \"enfolio80\".\"companyid\" o22, \"enfolio80\".\"foliostatusid\" o23, trim_scale(\"enfolio80\".\"totalamount\"::numeric) o24, trim_scale(\"enfolio80\".\"totaliva_amount\"::numeric) o25, trim_scale(\"enfolio80\".\"partialamount\"::numeric) o26, \"enfolio80\".\"currencyid\" o27, \"enfolio80\".\"firstapproveruserid\" o28, \"enfolio80\".\"approvalprocesstypeid\" o29, \"enfolio80\".\"sapentryerror\" o30, \"enfolio80\".\"createdby\" o31, \"enfolio80\".\"createdon\" o32, \"enfolio80\".\"updatedby\" o33, \"enfolio80\".\"updatedon\" o34, \"enfolio80\".\"minuteselected\" o35, \"enfolioapproval46\".\"id\" o36, \"enfolioapproval46\".\"folioid\" o37, \"enfolioapproval46\".\"approvalprocessid\" o38, \"enfolioapproval46\".\"processtypecode\" o39, \"enfolioapproval46\".\"approvalprocessversion\" o40, \"enfolioapproval46\".\"currentlevel\" o41, \"enfolioapproval46\".\"maxlevel\" o42, \"enfolioapproval46\".\"startedon\" o43, \"enfolioapproval46\".\"finishedon\" o44, \"enfolioapproval46\".\"regionid\" o45, \"enfolioapprovallevel42\".\"id\" o46, \"enfolioapprovallevel42\".\"folioapprovalid\" o47, \"enfolioapprovallevel42\".\"levelnumber\" o48, \"enfolioapprovallevel42\".\"applicationroleid\" o49, \"enfolioapprovallevel42\".\"entrajobtitle\" o50, \"enfolioapprovallevel42\".\"entraroleid\" o51, \"enfolioapprovallevel42\".\"departmentid\" o52, \"enfolioapprovallevel42\".\"assignedto\" o53, \"enfolioapprovallevel42\".\"approvalstatusid\" o54, \"enfolioapprovallevel42\".\"ismandatory\" o55, \"enfolioapprovallevel42\".\"isreassigned\" o56, \"enfolioapprovallevel42\".\"approvedby\" o57, \"enfolioapprovallevel42\".\"approvedon\" o58, \"enfolioapprovallevel42\".\"canceledby\" o59, \"enfolioapprovallevel42\".\"canceledon\" o60, \"enfolioapprovallevel42\".\"rejectedby\" o61, \"enfolioapprovallevel42\".\"rejectedon\" o62, \"enfolioapprovallevel42\".\"issubstitutefor\" o63, \"enfolioapprovallevel42\".\"rejectreason\" o64, \"enfolioapprovallevel42\".\"isinvoiceapproval\" o65, \"enfoliostatus10\".\"id\" o66, \"enfoliostatus10\".\"label\" o67, \"enfoliostatus10\".\"class\" o68, \"enfoliostatus10\".\"order\" o69, \"enfoliostatus10\".\"is_active\" o70, \"enfoliostatus10\".\"labeles\" o71, \"enordermain123\".\"id\" o72, \"enordermain123\".\"ordernumber\" o73, \"enordermain123\".\"orderdate\" o74, \"enordermain123\".\"orderstatusid\" o75, \"enordermain123\".\"previousorderstatusid\" o76, \"enordermain123\".\"assignmentcode\" o77, \"enordermain123\".\"supplierid\" o78, \"enordermain123\".\"companyid\" o79, \"enordermain123\".\"documenttypeid\" o80, \"enordermain123\".\"currencyid\" o81, \"enordermain123\".\"telceldirectionid\" o82, \"enordermain123\".\"procurementgroup\" o83, \"enordermain123\".\"creatorsapnumber\" o84, \"enordermain123\".\"creatorsapname\" o85, \"enordermain123\".\"country\" o86, \"enordermain123\".\"isdeleted\" o87, \"enordermain123\".\"isreleased\" o88, trim_scale(\"enordermain123\".\"exchangerate\"::numeric) o89, \"enordermain123\".\"sustainabilitycategory\" o90, \"enordermain123\".\"sustainabilitysubcategory\" o91, trim_scale(\"enordermain123\".\"totalamount\"::numeric) o92, \"enordermain123\".\"fromcosmoz\" o93, \"enordermain123\".\"regionid\" o94, \"enordermain123\".\"divisionid\" o95, \"enordermain123\".\"applicant\" o96, \"enordermain123\".\"createdby\" o97, \"enordermain123\".\"createdon\" o98, \"enordermain123\".\"updatedby\" o99, \"enordermain123\".\"updatedon\" o100, \"enregion176\".\"id\" o101, \"enregion176\".\"code\" o102, \"enregion176\".\"name\" o103, \"enregion176\".\"divisionfi\" o104, \"enregion176\".\"centrortp\" o105, \"enregion176\".\"commissionregion\" o106, \"enregion176\".\"isactive\" o107, \"enregion176\".\"createdon\" o108, \"enregion176\".\"createdby\" o109, \"enregion176\".\"updatedon\" o110, \"enregion176\".\"updatedby\" o111, \"enregion176\".\"isfsp\" o112, \"enregion176\".\"isfcp\" o113, \"ensupplier128\".\"id\" o114, \"ensupplier128\".\"tratamiento\" o115, \"ensupplier128\".\"name\" o116, \"ensupplier128\".\"number\" o117, \"ensupplier128\".\"conceptobusq_1_2\" o118, \"ensupplier128\".\"calle_numero\" o119, \"ensupplier128\".\"distrito\" o120, \"ensupplier128\".\"codigopostal_pobl_\" o121, \"ensupplier128\".\"pais\" o122, \"ensupplier128\".\"region_\" o123, \"ensupplier128\".\"idioma\" o124, \"ensupplier128\".\"telefono\" o125, \"ensupplier128\".\"extension\" o126, \"ensupplier128\".\"fax\" o127, \"ensupplier128\".\"cliente\" o128, \"ensupplier128\".\"soc_glasociada\" o129, \"ensupplier128\".\"clavedegrupo\" o130, \"ensupplier128\".\"n_ident_fis_1\" o131, \"ensupplier128\".\"personafisica\" o132, \"ensupplier128\".\"ramo\" o133, \"ensupplier128\".\"grupodeporte\" o134, \"ensupplier128\".\"email\" o135, \"ensupplier128\".\"isactive\" o136, \"ensupplier128\".\"createdon\" o137, \"ensupplier128\".\"createdby\" o138, \"ensupplier128\".\"updatedon\" o139, \"ensupplier128\".\"updatedby\" o140, \"ensupplier128\".\"regionid\" o141, \"enuser_createdby1\".\"id\" o142, \"enuser_createdby1\".\"name\" o143, \"enuser_createdby1\".\"email\" o144, \"enuser_createdby1\".\"photourl\" o145, \"enuser_createdby1\".\"username\" o146, \"enuser_updatedby1\".\"id\" o147, \"enuser_updatedby1\".\"name\" o148, \"enuser_updatedby1\".\"email\" o149, \"enuser_updatedby1\".\"photourl\" o150, \"enuser_updatedby1\".\"username\" o151");
fromBuilder.Append(" FROM (((((((((({Folio} \"enfolio80\" Left JOIN {FolioStatus} \"enfoliostatus10\" ON (\"enfolio80\".\"foliostatusid\" = \"enfoliostatus10\".\"id\"))  Left JOIN {FolioApproval} \"enfolioapproval46\" ON ((\"enfolio80\".\"id\" = \"enfolioapproval46\".\"folioid\") AND (\"enfolio80\".\"approvalprocesstypeid\" = ");
fromBuilder.Append(1
);
fromBuilder.Append(")))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel42\" ON (((\"enfolioapproval46\".\"id\" = \"enfolioapprovallevel42\".\"folioapprovalid\") AND ((CASE WHEN (\"enfolioapprovallevel42\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel42\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel42\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
fromBuilder.Append("(\"enfolioapprovallevel42\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (");
if (qpapFolioApprovalLevel_ApplicationRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel42\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId) AND (\"enfolioapprovallevel42\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel42\".\"applicationroleid\" IS NULL)");
}
fromBuilder.Append(" OR ");
if (qpenFolioApprovalLevel_EntraRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel42\".\"entraroleid\" = @qpenFolioApprovalLevel_EntraRoleId) AND (\"enfolioapprovallevel42\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenFolioApprovalLevel_EntraRoleId", DbType.Int64, qpenFolioApprovalLevel_EntraRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel42\".\"entraroleid\" IS NULL)");
}
fromBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)) AND (\"enfolioapprovallevel42\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser_updatedby1\" ON (\"enfolio80\".\"createdby\" = \"enuser_updatedby1\".\"id\"))  Left JOIN {User} \"enuser_createdby1\" ON (\"enfolio80\".\"updatedby\" = \"enuser_createdby1\".\"id\"))  Left JOIN {OrderMain} \"enordermain123\" ON (\"enfolio80\".\"orderid\" = \"enordermain123\".\"id\"))  Left JOIN {Company} \"encompany63\" ON (\"enfolio80\".\"companyid\" = \"encompany63\".\"id\"))  Left JOIN {Supplier} \"ensupplier128\" ON (\"enfolio80\".\"supplierid\" = \"ensupplier128\".\"id\"))  Left JOIN {Currency} \"encurrency42\" ON (\"enfolio80\".\"currencyid\" = \"encurrency42\".\"code\"))  Left JOIN {Region} \"enregion176\" ON (\"enordermain123\".\"regionid\" = \"enregion176\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (((");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enordermain123\".\"divisionid\" = @qpreRegionId) AND (\"enordermain123\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enordermain123\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval46\".\"regionid\" = @qpreRegionId) AND (\"enfolioapproval46\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval46\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpreRegionId = @qpreGetMR00RegionId)) AND (\"enfolioapprovallevel42\".\"levelnumber\" = 1))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
sqlCmd.CreateParameterWithoutReplacements("@qpreGetMR00RegionId", DbType.Int64, qpreGetMR00RegionId);
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
RL_d6c492838bba25b2d8eac44d00689146 outParamList = new RL_d6c492838bba25b2d8eac44d00689146();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[11];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[9] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d6c492838bba25b2d8eac44d00689146 _tmp = new RL_d6c492838bba25b2d8eac44d00689146();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.CheckDirectReports.GetFolios.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d6c492838bba25b2d8eac44d00689146)_tmp;
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
