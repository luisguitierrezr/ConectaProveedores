using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel).Namespace);

    public long inParami_ApplicantId;
public long inParami_FolioId;
public bool inParami_MandatoryError;
public long varLcl_ApprovalProcessId;
public bool varLcl_IsMandatoryError;
public ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model varLcGetApprovalProcesses;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel(long inParami_ApplicantId, long inParami_FolioId, bool inParami_MandatoryError, long varLcl_ApprovalProcessId, bool varLcl_IsMandatoryError, ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model varLcGetApprovalProcesses, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ApplicantId", "i_FolioId", "i_MandatoryError", "l_ApprovalProcessId", "l_IsMandatoryError", "GetApprovalProcesses", "ClientVars"}, new string[] {"inParami_ApplicantId", "inParami_FolioId", "inParami_MandatoryError", "varLcl_ApprovalProcessId", "varLcl_IsMandatoryError", "varLcGetApprovalProcesses", "clientVariables"});
this.inParami_ApplicantId = inParami_ApplicantId;
this.inParami_FolioId = inParami_FolioId;
this.inParami_MandatoryError = inParami_MandatoryError;
this.varLcl_ApprovalProcessId = varLcl_ApprovalProcessId;
this.varLcl_IsMandatoryError = varLcl_IsMandatoryError;
this.varLcGetApprovalProcesses = varLcGetApprovalProcesses;
this.clientVariables = clientVariables;
}



    

    public class lcvGetApprovalProcesses : VarsBag {
public RL_89fdc2de9b4f3c518b096795c532253b queryResGetApplicantById_outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
public long queryResGetApplicantById_outParamCount = 0L;

public RL_ecd1c5152b10fa2a937ada7598ead4ad queryResGetFolioById_outParamList = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
public long queryResGetFolioById_outParamCount = 0L;

public RL_5c614a706e3e33b4caf55ba997e805be queryResGetApprovalProcessesAgg_outParamList = new RL_5c614a706e3e33b4caf55ba997e805be();
public long queryResGetApprovalProcessesAgg_outParamCount = 0L;

public RL_5c614a706e3e33b4caf55ba997e805be queryResGetApprovalProcessesAgg2_outParamList = new RL_5c614a706e3e33b4caf55ba997e805be();
public long queryResGetApprovalProcessesAgg2_outParamCount = 0L;

public lcvGetApprovalProcesses() {
}
}
public class lcoGetApprovalProcesses : VarsBag {
public RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessesList = new RL_ce09c545b541edeabab89435c34c64f0();

public lcoGetApprovalProcesses() {
}
}
/// <summary>
/// Action <code>GetApprovalProcesses</code> that represents the Service Studio action
///  <code>GetApprovalProcesses</code> <p> Description: </p>
/// </summary>
public async Task<RL_ce09c545b541edeabab89435c34c64f0> DataActionGetApprovalProcesses(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessesList = default;
lcoGetApprovalProcesses result = new lcoGetApprovalProcesses();
lcvGetApprovalProcesses localVars = new lcvGetApprovalProcesses();
ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetApprovalProcesses", "c7b3576b-8e05-4629-9f32-915f4feb8459"))
using (activitySource.CreateScreenDataActionActivity("Wb_FlowOptions", "GetApprovalProcesses")){
if(((inParami_ApplicantId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetApplicantById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicantById_maxRecords = 1;
if (datasetGetApplicantById_maxRecords < 1) datasetGetApplicantById_maxRecords = 1;
int datasetGetApplicantById_startIndex = 0;(localVars.queryResGetApplicantById_outParamList,localVars.queryResGetApplicantById_outParamCount) = await FuncDataActionGetApprovalProcesses.datasetGetApplicantById(requestContext,datasetGetApplicantById_maxRecords,datasetGetApplicantById_startIndex,IterationMultiplicity.Never,inParami_ApplicantId,cancellationToken);

// Query datasetGetApprovalProcessesAgg2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessesAgg2_maxRecords = 99999;
if (datasetGetApprovalProcessesAgg2_maxRecords < 1) datasetGetApprovalProcessesAgg2_maxRecords = 1;
int datasetGetApprovalProcessesAgg2_startIndex = 0;(localVars.queryResGetApprovalProcessesAgg2_outParamList,localVars.queryResGetApprovalProcessesAgg2_outParamCount) = await FuncDataActionGetApprovalProcesses.datasetGetApprovalProcessesAgg2(requestContext,datasetGetApprovalProcessesAgg2_maxRecords,datasetGetApprovalProcessesAgg2_startIndex,IterationMultiplicity.Single,localVars.queryResGetApplicantById_outParamList.CurrentRec.ssENApplicant.ssApprovalProcessTypeId,cancellationToken);

// ApprovalProcessesList = GetApprovalProcessesAgg2.List
result.outParamApprovalProcessesList=(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovalProcessesAgg2_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_8cfc2af1075444d3070aa6269dcfdf32 source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken));
} else {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetApprovalProcesses.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// Query datasetGetApprovalProcessesAgg
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessesAgg_maxRecords = 99999;
if (datasetGetApprovalProcessesAgg_maxRecords < 1) datasetGetApprovalProcessesAgg_maxRecords = 1;
int datasetGetApprovalProcessesAgg_startIndex = 0;(localVars.queryResGetApprovalProcessesAgg_outParamList,localVars.queryResGetApprovalProcessesAgg_outParamCount) = await FuncDataActionGetApprovalProcesses.datasetGetApprovalProcessesAgg(requestContext,datasetGetApprovalProcessesAgg_maxRecords,datasetGetApprovalProcessesAgg_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssApprovalProcessId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssRegionId,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetMR09RegionId(requestContext,cancellationToken)),cancellationToken);

// ApprovalProcessesList = GetApprovalProcessesAgg.List
result.outParamApprovalProcessesList=(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovalProcessesAgg_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_8cfc2af1075444d3070aa6269dcfdf32 source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamApprovalProcessesList = result.outParamApprovalProcessesList;
} // inner-finally
RETURN_STATEMENT:
return outParamApprovalProcessesList;
}


    public static class FuncDataActionGetApprovalProcesses {

// Query Function "GetApplicantById" c1uPMGzeQE2YnmWCvBcQMg of Action "GetApprovalProcesses"
public static async Task<(RL_89fdc2de9b4f3c518b096795c532253b,long)> datasetGetApplicantById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApplicantById", "308f5b73-de6c-4d40-989e-6582bc171032");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApplicantById", "308f5b73-de6c-4d40-989e-6582bc171032", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.gS7YZIxAak6opB_t6DFmhw/DataActions.a1ezxwWOKUafMpFfT+uEWQ/NodesNotShownInESpaceTree.c1uPMGzeQE2YnmWCvBcQMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enapplicant4\".\"approvalprocesstypeid\" o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {Applicant} \"enapplicant4\"");
whereBuilder.Append(" WHERE ");
if (qpapId != 0) {
whereBuilder.Append("((\"enapplicant4\".\"id\" = @qpapId) AND (\"enapplicant4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapplicant4\".\"id\" IS NULL)");
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
RL_89fdc2de9b4f3c518b096795c532253b outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApplicantById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApplicantById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_f7c91773292f225022263e13d34e21c5> datasetGetFolioByIdReadDbAsync(RC_f7c91773292f225022263e13d34e21c5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" laqVQOuPJ0a62wokA3_WMg of Action "GetApprovalProcesses"
public static async Task<(RL_ecd1c5152b10fa2a937ada7598ead4ad,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetFolioById", "4095aa95-8feb-4627-badb-0a24037fd632");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetFolioById", "4095aa95-8feb-4627-badb-0a24037fd632", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.gS7YZIxAak6opB_t6DFmhw/DataActions.a1ezxwWOKUafMpFfT+uEWQ/NodesNotShownInESpaceTree.laqVQOuPJ0a62wokA3_WMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enfolioapproval54\".\"approvalprocessid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, \"enordermain138\".\"regionid\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Folio} \"enfolio97\" Left JOIN {FolioApproval} \"enfolioapproval54\" ON (\"enfolio97\".\"id\" = \"enfolioapproval54\".\"folioid\"))  Left JOIN {OrderMain} \"enordermain138\" ON (\"enfolio97\".\"orderid\" = \"enordermain138\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio97\".\"id\" = @qpfoFolio_Id) AND (\"enfolio97\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio97\".\"id\" IS NULL)");
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
RL_ecd1c5152b10fa2a937ada7598ead4ad outParamList = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecd1c5152b10fa2a937ada7598ead4ad _tmp = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecd1c5152b10fa2a937ada7598ead4ad)_tmp;
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

private static async Task<RC_8cfc2af1075444d3070aa6269dcfdf32> datasetGetApprovalProcessesAggReadDbAsync(RC_8cfc2af1075444d3070aa6269dcfdf32 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessesAgg" oq6VWRy0UUiOqFfEjtNM_Q of Action "GetApprovalProcesses"
public static async Task<(RL_5c614a706e3e33b4caf55ba997e805be,long)> datasetGetApprovalProcessesAgg(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploApprovalProcess_Id,long qpreApprovalProcess_RegionId,long qpreApprovalProcess_RegionId1,long qpreApprovalProcess_RegionId2,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg", "5995aea2-b41c-4851-8ea8-57c48ed34cfd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg", "5995aea2-b41c-4851-8ea8-57c48ed34cfd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.gS7YZIxAak6opB_t6DFmhw/DataActions.a1ezxwWOKUafMpFfT+uEWQ/NodesNotShownInESpaceTree.oq6VWRy0UUiOqFfEjtNM_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess52\".\"id\" o0, \"enapprovalprocess52\".\"processtypeid\" o1, \"enapprovalprocess52\".\"specialworkflowid\" o2, \"enapprovalprocess52\".\"approvalprocesstypeid\" o3, \"enapprovalprocess52\".\"regionid\" o4, \"enapprovalprocess52\".\"accountingregionid\" o5, \"enapprovalprocess52\".\"group\" o6, \"enapprovalprocess52\".\"code\" o7, \"enapprovalprocess52\".\"version\" o8, \"enapprovalprocess52\".\"description\" o9, \"enapprovalprocess52\".\"isactive\" o10, \"enapprovalprocess52\".\"isspecial\" o11, \"enapprovalprocess52\".\"isdonation\" o12, \"enapprovalprocess52\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess52\".\"createdby\" o14, \"enapprovalprocess52\".\"createdon\" o15, \"enapprovalprocess52\".\"updatedby\" o16, \"enapprovalprocess52\".\"updatedon\" o17, \"enapprovalprocess52\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess52\" Left JOIN {ProcessType} \"enprocesstype15\" ON (\"enapprovalprocess52\".\"processtypeid\" = \"enprocesstype15\".\"id\"))  Left JOIN {ApprovalProcessType} \"enapprovalprocesstype3\" ON (\"enapprovalprocess52\".\"approvalprocesstypeid\" = \"enapprovalprocesstype3\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enprocesstype15\".\"code\" collate \"default\") like caseaccent_normalize('FolioSAE' collate \"default\")) AND (\"enapprovalprocess52\".\"isactive\" = 1) AND (\"enapprovalprocess52\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enapprovalprocess52\".\"id\" <> (@qploApprovalProcess_Id)) AND ((CASE WHEN (@qpreApprovalProcess_RegionId = @qpreApprovalProcess_RegionId1) THEN (CASE WHEN (");
sqlCmd.CreateParameterWithoutReplacements("@qploApprovalProcess_Id", DbType.Int64, qploApprovalProcess_Id);
sqlCmd.CreateParameterWithoutReplacements("@qpreApprovalProcess_RegionId", DbType.Int64, qpreApprovalProcess_RegionId);
sqlCmd.CreateParameterWithoutReplacements("@qpreApprovalProcess_RegionId1", DbType.Int64, qpreApprovalProcess_RegionId1);
if (qpreApprovalProcess_RegionId1 != 0) {
whereBuilder.Append("((\"enapprovalprocess52\".\"regionid\" = @qpreApprovalProcess_RegionId1) AND (\"enapprovalprocess52\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreApprovalProcess_RegionId1", DbType.Int64, qpreApprovalProcess_RegionId1);
} else {
whereBuilder.Append("(\"enapprovalprocess52\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreApprovalProcess_RegionId2 != 0) {
whereBuilder.Append("((\"enapprovalprocess52\".\"regionid\" = @qpreApprovalProcess_RegionId2) AND (\"enapprovalprocess52\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreApprovalProcess_RegionId2", DbType.Int64, qpreApprovalProcess_RegionId2);
} else {
whereBuilder.Append("(\"enapprovalprocess52\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpreApprovalProcess_RegionId != 0) {
whereBuilder.Append("((\"enapprovalprocess52\".\"regionid\" = @qpreApprovalProcess_RegionId) AND (\"enapprovalprocess52\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreApprovalProcess_RegionId", DbType.Int64, qpreApprovalProcess_RegionId);
} else {
whereBuilder.Append("(\"enapprovalprocess52\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocess52\".\"code\" ASC , \"enapprovalprocess52\".\"version\" ASC ");
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
RL_5c614a706e3e33b4caf55ba997e805be outParamList = new RL_5c614a706e3e33b4caf55ba997e805be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessesAggReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c614a706e3e33b4caf55ba997e805be _tmp = new RL_5c614a706e3e33b4caf55ba997e805be();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessesAggReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c614a706e3e33b4caf55ba997e805be)_tmp;
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

private static async Task<RC_8cfc2af1075444d3070aa6269dcfdf32> datasetGetApprovalProcessesAgg2ReadDbAsync(RC_8cfc2af1075444d3070aa6269dcfdf32 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessesAgg2" vTydh44f+EOvwRHwJbfhng of Action "GetApprovalProcesses"
public static async Task<(RL_5c614a706e3e33b4caf55ba997e805be,long)> datasetGetApprovalProcessesAgg2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpapApprovalProcessTypeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg2", "879d3cbd-1f8e-43f8-afc1-11f025b7e19e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg2", "879d3cbd-1f8e-43f8-afc1-11f025b7e19e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.gS7YZIxAak6opB_t6DFmhw/DataActions.a1ezxwWOKUafMpFfT+uEWQ/NodesNotShownInESpaceTree.vTydh44f+EOvwRHwJbfhng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess53\".\"id\" o0, \"enapprovalprocess53\".\"processtypeid\" o1, \"enapprovalprocess53\".\"specialworkflowid\" o2, \"enapprovalprocess53\".\"approvalprocesstypeid\" o3, \"enapprovalprocess53\".\"regionid\" o4, \"enapprovalprocess53\".\"accountingregionid\" o5, \"enapprovalprocess53\".\"group\" o6, \"enapprovalprocess53\".\"code\" o7, \"enapprovalprocess53\".\"version\" o8, \"enapprovalprocess53\".\"description\" o9, \"enapprovalprocess53\".\"isactive\" o10, \"enapprovalprocess53\".\"isspecial\" o11, \"enapprovalprocess53\".\"isdonation\" o12, \"enapprovalprocess53\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess53\".\"createdby\" o14, \"enapprovalprocess53\".\"createdon\" o15, \"enapprovalprocess53\".\"updatedby\" o16, \"enapprovalprocess53\".\"updatedon\" o17, \"enapprovalprocess53\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess53\" Left JOIN {ProcessType} \"enprocesstype16\" ON (\"enapprovalprocess53\".\"processtypeid\" = \"enprocesstype16\".\"id\"))  Left JOIN {ApprovalProcessType} \"enapprovalprocesstype4\" ON (\"enapprovalprocess53\".\"approvalprocesstypeid\" = \"enapprovalprocesstype4\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enprocesstype16\".\"code\" collate \"default\") like caseaccent_normalize('FolioSAE' collate \"default\")) AND (\"enapprovalprocess53\".\"isactive\" = 1) AND ((CASE WHEN ");
if (qpapApprovalProcessTypeId != 0) {
whereBuilder.Append("((");
whereBuilder.Append(1
);
whereBuilder.Append(" = @qpapApprovalProcessTypeId) AND (");
whereBuilder.Append(1
);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessTypeId", DbType.Int32, qpapApprovalProcessTypeId);
} else {
whereBuilder.Append("(");
whereBuilder.Append(1
);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" THEN (CASE WHEN ((\"enapprovalprocess53\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") OR (\"enapprovalprocess53\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")) THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enapprovalprocess53\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1) AND (1 = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesstype4\".\"order\" ASC , \"enapprovalprocess53\".\"code\" ASC , \"enapprovalprocess53\".\"version\" ASC ");
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
RL_5c614a706e3e33b4caf55ba997e805be outParamList = new RL_5c614a706e3e33b4caf55ba997e805be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessesAgg2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c614a706e3e33b4caf55ba997e805be _tmp = new RL_5c614a706e3e33b4caf55ba997e805be();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessesAgg2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FlowOptions.GetApprovalProcesses.GetApprovalProcessesAgg2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c614a706e3e33b4caf55ba997e805be)_tmp;
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
