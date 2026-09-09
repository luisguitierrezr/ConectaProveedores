using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel).Namespace);

    public long inParami_FolioId;
public int varLcl_ActiveTab;
public bool varLcl_IsExecuting;
public string varLcl_Motive;
public bool varLcl_IsValidSearchUserDropdown;
public string varLcl_SelectedUser;
public bool varLcl_IsValidSearchApprovalProcessDropdown;
public long varLcl_SelectedApprovalProcess;
public int varLcl_ApprovalProcessTypeSelected;
public AggregateRecord<RL_aa462092dd42df329d9d5474c2d56c53> ScreenDataSetGetApprovalProcessTypes;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel(long inParami_FolioId, int varLcl_ActiveTab, bool varLcl_IsExecuting, string varLcl_Motive, bool varLcl_IsValidSearchUserDropdown, string varLcl_SelectedUser, bool varLcl_IsValidSearchApprovalProcessDropdown, long varLcl_SelectedApprovalProcess, int varLcl_ApprovalProcessTypeSelected, AggregateRecord<RL_aa462092dd42df329d9d5474c2d56c53> ScreenDataSetGetApprovalProcessTypes, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "l_ActiveTab", "l_IsExecuting", "l_Motive", "l_IsValidSearchUserDropdown", "l_SelectedUser", "l_IsValidSearchApprovalProcessDropdown", "l_SelectedApprovalProcess", "l_ApprovalProcessTypeSelected", "GetApprovalProcessTypes", "ClientVars"}, new string[] {"inParami_FolioId", "varLcl_ActiveTab", "varLcl_IsExecuting", "varLcl_Motive", "varLcl_IsValidSearchUserDropdown", "varLcl_SelectedUser", "varLcl_IsValidSearchApprovalProcessDropdown", "varLcl_SelectedApprovalProcess", "varLcl_ApprovalProcessTypeSelected", "ScreenDataSetGetApprovalProcessTypes", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.varLcl_ActiveTab = varLcl_ActiveTab;
this.varLcl_IsExecuting = varLcl_IsExecuting;
this.varLcl_Motive = varLcl_Motive;
this.varLcl_IsValidSearchUserDropdown = varLcl_IsValidSearchUserDropdown;
this.varLcl_SelectedUser = varLcl_SelectedUser;
this.varLcl_IsValidSearchApprovalProcessDropdown = varLcl_IsValidSearchApprovalProcessDropdown;
this.varLcl_SelectedApprovalProcess = varLcl_SelectedApprovalProcess;
this.varLcl_ApprovalProcessTypeSelected = varLcl_ApprovalProcessTypeSelected;
this.ScreenDataSetGetApprovalProcessTypes = ScreenDataSetGetApprovalProcessTypes;
this.clientVariables = clientVariables;
}



    
// Query Function "GetApprovalProcessTypes" JQXyQc5dfUa43FUXpaVaiw of Action "Wb_ReassignFolioFromRejectPopup"
public static async Task<(RL_aa462092dd42df329d9d5474c2d56c53,long)> datasetGetApprovalProcessTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.GetApprovalProcessTypes", "41f20525-5dce-467d-b8dc-5517a5a55a8b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ReassignFolioFromRejectPopup","j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.GetApprovalProcessTypes");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.S5MC63e2HUy+ncCqkMVO4w/ScreenDataSets.JQXyQc5dfUa43FUXpaVaiw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocesstype7\".\"id\" o0, NULL o1, \"enapprovalprocesstype7\".\"label_es\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ApprovalProcessType} \"enapprovalprocesstype7\"");
whereBuilder.Append(" WHERE (\"enapprovalprocesstype7\".\"is_active\" = 1) AND (\"enapprovalprocesstype7\".\"id\" <> ");
whereBuilder.Append(4
);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesstype7\".\"label_es\" ASC ");
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
RL_aa462092dd42df329d9d5474c2d56c53 outParamList = new RL_aa462092dd42df329d9d5474c2d56c53();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.GetApprovalProcessTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_aa462092dd42df329d9d5474c2d56c53 _tmp = new RL_aa462092dd42df329d9d5474c2d56c53();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.GetApprovalProcessTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_aa462092dd42df329d9d5474c2d56c53)_tmp;
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
