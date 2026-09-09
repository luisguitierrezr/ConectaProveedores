using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel).Namespace);

    public RL_09457db01df0de3852b9312cdd42fb2a inParaml_InvoiceApprovalLevelList;
public bool varLcl_IsBusy;
public string varLcl_UserSelected;
public AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> ScreenDataSetGetEligebleUsers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel() {
}



    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel(RL_09457db01df0de3852b9312cdd42fb2a inParaml_InvoiceApprovalLevelList, bool varLcl_IsBusy, string varLcl_UserSelected, AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> ScreenDataSetGetEligebleUsers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_InvoiceApprovalLevelList", "l_IsBusy", "l_UserSelected", "GetEligebleUsers", "ClientVars"}, new string[] {"inParaml_InvoiceApprovalLevelList", "varLcl_IsBusy", "varLcl_UserSelected", "ScreenDataSetGetEligebleUsers", "clientVariables"});
this.inParaml_InvoiceApprovalLevelList = inParaml_InvoiceApprovalLevelList;
this.varLcl_IsBusy = varLcl_IsBusy;
this.varLcl_UserSelected = varLcl_UserSelected;
this.ScreenDataSetGetEligebleUsers = ScreenDataSetGetEligebleUsers;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetEligebleUsersReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetEligebleUsers" fe7OxjbaJE2yXli35+bxQg of Action "Wb_PopupInvoiceAssignAnalista"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetEligebleUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpreUser_Extended_Internal_RegionId,long qpteUser_Extended_Internal_TelcelDirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceAssignAnalista.GetEligebleUsers", "c6ceee7d-da36-4d24-b25e-58b7e7e6f142");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceAssignAnalista","d_InvoicePopups.Wb_PopupInvoiceAssignAnalista.GetEligebleUsers");
// Query Iterations: Multiple
// Refresh Query 4LXi3KaWdUWJT4QxsoBVmg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.zfqvXceZ70e0OIuDuv3dNA/ScreenDataSets.fe7OxjbaJE2yXli35+bxQg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enuser150\".\"id\" o6, \"enuser150\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal90\" Inner JOIN {User} \"enuser150\" ON (\"enuser_extended_internal90\".\"id\" = \"enuser150\".\"id\"))  Left JOIN {EntraRole} \"enentrarole45\" ON (\"enuser_extended_internal90\".\"entraroleid\" = \"enentrarole45\".\"id\"))  Left JOIN {UserExtension} \"enuserextension68\" ON (\"enuser150\".\"id\" = \"enuserextension68\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal90\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal90\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal90\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpteUser_Extended_Internal_TelcelDirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal90\".\"telceldirectionid\" = @qpteUser_Extended_Internal_TelcelDirectionId) AND (\"enuser_extended_internal90\".\"telceldirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDirectionId", DbType.Int64, qpteUser_Extended_Internal_TelcelDirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal90\".\"telceldirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal90\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal90\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal90\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole45\".\"isareacxp\" = 1) AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension68\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_f518d708e7bb15a03a65b75b9f603096 outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEligebleUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceAssignAnalista.GetEligebleUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f518d708e7bb15a03a65b75b9f603096 _tmp = new RL_f518d708e7bb15a03a65b75b9f603096();
_tmp.AlternateReadDbMethodAsync = datasetGetEligebleUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceAssignAnalista.GetEligebleUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f518d708e7bb15a03a65b75b9f603096)_tmp;
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
