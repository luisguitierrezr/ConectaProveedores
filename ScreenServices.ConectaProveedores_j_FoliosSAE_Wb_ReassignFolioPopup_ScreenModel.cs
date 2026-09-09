using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel).Namespace);

    public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public bool varLcl_IsExecuting;
public string varLcl_AssignUserId;
public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model varLcGetUsersList;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel(long inParami_FolioId, long inParami_FolioApprovalLevelId, bool varLcl_IsExecuting, string varLcl_AssignUserId, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model varLcGetUsersList, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_FolioApprovalLevelId", "l_IsExecuting", "l_AssignUserId", "GetUsersList", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_FolioApprovalLevelId", "varLcl_IsExecuting", "varLcl_AssignUserId", "varLcGetUsersList", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.varLcl_IsExecuting = varLcl_IsExecuting;
this.varLcl_AssignUserId = varLcl_AssignUserId;
this.varLcGetUsersList = varLcGetUsersList;
this.clientVariables = clientVariables;
}



    

    public class lcvGetUsersList : VarsBag {
public RL_4c313dd08c2e051e0c0310a6d05109b0 queryResGetUserById_outParamList = new RL_4c313dd08c2e051e0c0310a6d05109b0();
public long queryResGetUserById_outParamCount = 0L;

public RL_d93cbaf98e8c7bf91c01ba8ed183bc42 queryResGetFolioById_outParamList = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
public long queryResGetFolioById_outParamCount = 0L;

public lcvGetUsersList() {
}
}
public class lcoGetUsersList : VarsBag {
public RL_4c313dd08c2e051e0c0310a6d05109b0 outParamo_UsersList = new RL_4c313dd08c2e051e0c0310a6d05109b0();

public lcoGetUsersList() {
}
}
/// <summary>
/// Action <code>GetUsersList</code> that represents the Service Studio action
///  <code>GetUsersList</code> <p> Description: Query to fetch Users List.</p>
/// </summary>
public async Task<RL_4c313dd08c2e051e0c0310a6d05109b0> DataActionGetUsersList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4c313dd08c2e051e0c0310a6d05109b0 outParamo_UsersList = default;
lcoGetUsersList result = new lcoGetUsersList();
lcvGetUsersList localVars = new lcvGetUsersList();
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUsersList", "3752ad47-b59b-439b-b65e-2ea9177a9006"))
using (activitySource.CreateScreenDataActionActivity("Wb_ReassignFolioPopup", "GetUsersList")){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetUsersList.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 0;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncDataActionGetUsersList.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssTelcelDirectionId,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamo_UsersList,cancellationToken);

// Set List
// o_UsersList = GetUserById.List
result.outParamo_UsersList=localVars.queryResGetUserById_outParamList;
} //close CreateActionActivity using block
} // try

finally {
outParamo_UsersList = result.outParamo_UsersList;
} // inner-finally
RETURN_STATEMENT:
return outParamo_UsersList;
}


    public static class FuncDataActionGetUsersList {

private static async Task<RC_a32d2d6effb998fa5a8e4b01f03a15ca> datasetGetUserByIdReadDbAsync(RC_a32d2d6effb998fa5a8e4b01f03a15ca rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" te4CaeFp9Em83CxwklN0Tw of Action "GetUsersList"
public static async Task<(RL_4c313dd08c2e051e0c0310a6d05109b0,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteUser_Extended_Internal_TelcelDirectionId,long qpenUser_Extended_Internal_EntraRoleId,string qpusUser_Id,long qpreUser_Extended_Internal_RegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetUserById", "6902eeb5-69e1-49f4-bcdc-2c709253744f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetUserById", "6902eeb5-69e1-49f4-bcdc-2c709253744f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.dsqFv+neEkOAzNlTVA4NAg/DataActions.R61SN5u1m0O2Xi6pF3qQBg/NodesNotShownInESpaceTree.te4CaeFp9Em83CxwklN0Tw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole91\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enregion203\".\"code\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enuser249\".\"id\" o19, \"enuser249\".\"name\" o20, \"enuser249\".\"email\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enuser_extended_internal146\".\"telceldireccion\" o43");
fromBuilder.Append(" FROM ((({User} \"enuser249\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal146\" ON (\"enuser249\".\"id\" = \"enuser_extended_internal146\".\"id\"))  Left JOIN {Region} \"enregion203\" ON (\"enuser_extended_internal146\".\"regionid\" = \"enregion203\".\"id\"))  Left JOIN {EntraRole} \"enentrarole91\" ON (\"enuser_extended_internal146\".\"entraroleid\" = \"enentrarole91\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal146\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal146\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal146\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal146\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal146\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal146\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser249\".\"id\" <> @qpusUser_Id) OR (\"enuser249\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser249\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND ");
if (qpteUser_Extended_Internal_TelcelDirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal146\".\"telceldirectionid\" = @qpteUser_Extended_Internal_TelcelDirectionId) AND (\"enuser_extended_internal146\".\"telceldirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDirectionId", DbType.Int64, qpteUser_Extended_Internal_TelcelDirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal146\".\"telceldirectionid\" IS NULL)");
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
RL_4c313dd08c2e051e0c0310a6d05109b0 outParamList = new RL_4c313dd08c2e051e0c0310a6d05109b0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4c313dd08c2e051e0c0310a6d05109b0 _tmp = new RL_4c313dd08c2e051e0c0310a6d05109b0();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4c313dd08c2e051e0c0310a6d05109b0)_tmp;
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

private static async Task<RC_d80dcf5f9effb79b8ba59dd1971d484d> datasetGetFolioByIdReadDbAsync(RC_d80dcf5f9effb79b8ba59dd1971d484d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" rfd45b+Lb0GmY65dP5a0ug of Action "GetUsersList"
public static async Task<(RL_d93cbaf98e8c7bf91c01ba8ed183bc42,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetFolioById", "e578f7ad-8bbf-416f-a663-ae5d3f96b4ba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetFolioById", "e578f7ad-8bbf-416f-a663-ae5d3f96b4ba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.dsqFv+neEkOAzNlTVA4NAg/DataActions.R61SN5u1m0O2Xi6pF3qQBg/NodesNotShownInESpaceTree.rfd45b+Lb0GmY65dP5a0ug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enordermain157\".\"telceldirectionid\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48");
fromBuilder.Append(" FROM ({Folio} \"enfolio117\" Left JOIN {OrderMain} \"enordermain157\" ON (\"enfolio117\".\"orderid\" = \"enordermain157\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio117\".\"id\" = @qpfoFolio_Id) AND (\"enfolio117\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio117\".\"id\" IS NULL)");
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
RL_d93cbaf98e8c7bf91c01ba8ed183bc42 outParamList = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d93cbaf98e8c7bf91c01ba8ed183bc42 _tmp = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolioPopup.GetUsersList.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d93cbaf98e8c7bf91c01ba8ed183bc42)_tmp;
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
