using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel).Namespace);

    public RL_9fb5c5e988576f6c521a9ef779213183 inParamList;
public string inParamOrderNumber;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public long inParami_FolioId;
public string varLcErrorMsg;
public RL_f4c5cb6ef02fae333513cbd4dafd500c varLcListAux;
public bool varLcl_ErrorMsgAlreadySent;
public ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_DataActionGetApprover_Model varLcGetApprover;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel(RL_9fb5c5e988576f6c521a9ef779213183 inParamList, string inParamOrderNumber, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, long inParami_FolioId, string varLcErrorMsg, RL_f4c5cb6ef02fae333513cbd4dafd500c varLcListAux, bool varLcl_ErrorMsgAlreadySent, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_DataActionGetApprover_Model varLcGetApprover, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"List", "OrderNumber", "FilesList", "i_FolioId", "ErrorMsg", "ListAux", "l_ErrorMsgAlreadySent", "GetApprover", "ClientVars"}, new string[] {"inParamList", "inParamOrderNumber", "inParamFilesList", "inParami_FolioId", "varLcErrorMsg", "varLcListAux", "varLcl_ErrorMsgAlreadySent", "varLcGetApprover", "clientVariables"});
this.inParamList = inParamList;
this.inParamOrderNumber = inParamOrderNumber;
this.inParamFilesList = inParamFilesList;
this.inParami_FolioId = inParami_FolioId;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcListAux = varLcListAux;
this.varLcl_ErrorMsgAlreadySent = varLcl_ErrorMsgAlreadySent;
this.varLcGetApprover = varLcGetApprover;
this.clientVariables = clientVariables;
}



    

    public class lcvGetApprover : VarsBag {
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalsByFolioId_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public lcvGetApprover() {
}
}
public class lcoGetApprover : VarsBag {
public bool outParamo_IsFirstApprover = false;

public lcoGetApprover() {
}
}
/// <summary>
/// Action <code>GetApprover</code> that represents the Service Studio action <code>GetApprover</code>
///  <p> Description: Query to fetch if EvidenceRequested was by first approver</p>
/// </summary>
public async Task<bool> DataActionGetApprover(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsFirstApprover = default;
lcoGetApprover result = new lcoGetApprover();
lcvGetApprover localVars = new lcvGetApprover();
ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetApprover", "8a065165-605a-4d4d-9610-870c3f46c0fc"))
using (activitySource.CreateScreenDataActionActivity("Wb_UploadDocumentsConstructionEdit", "GetApprover")){
// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 1;
if (datasetGetFolioApprovalsByFolioId_maxRecords < 1) datasetGetFolioApprovalsByFolioId_maxRecords = 1;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncDataActionGetApprover.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// o_IsFirstApprover = GetFolioApprovalsByFolioId.List.Current.FolioApprovalLevel.ApprovalStatusId = EvidenceRequested
result.outParamo_IsFirstApprover=(localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsFirstApprover = result.outParamo_IsFirstApprover;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsFirstApprover;
}


    public static class FuncDataActionGetApprover {

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalsByFolioIdReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalsByFolioId" KiI_AgyS3UOzoXVoLrQ5hQ of Action "GetApprover"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.GetApprover.GetFolioApprovalsByFolioId", "023f222a-920c-43dd-b3a1-75682eb43985");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.GetApprover.GetFolioApprovalsByFolioId", "023f222a-920c-43dd-b3a1-75682eb43985", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.SlNEBt0ux0GXNmQZYGM1FA/DataActions.ZVEGilpgTU2WEIcMP0bA_A/NodesNotShownInESpaceTree.KiI_AgyS3UOzoXVoLrQ5hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enfolioapprovallevel41\".\"approvalstatusid\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval45\" Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel41\" ON (\"enfolioapproval45\".\"id\" = \"enfolioapprovallevel41\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval45\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval45\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval45\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel41\".\"levelnumber\" ASC ");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.GetApprover.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.GetApprover.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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
