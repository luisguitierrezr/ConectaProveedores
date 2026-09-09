using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel).Namespace);

    public string varLcOldPassword;
public string varLcNewPassword;
public string varLcConfirmPassword;
public bool varLcIsPasswordVisible;
public bool varLcIsConfirmPasswordVisible;
public bool varLcIsButtonEnabled;
public bool varLcIsExecuting;
public bool varLcIsNewPasswordCompliant;
public AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserDetail;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel() {
}



    public ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel(string varLcOldPassword, string varLcNewPassword, string varLcConfirmPassword, bool varLcIsPasswordVisible, bool varLcIsConfirmPasswordVisible, bool varLcIsButtonEnabled, bool varLcIsExecuting, bool varLcIsNewPasswordCompliant, AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserDetail, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OldPassword", "NewPassword", "ConfirmPassword", "IsPasswordVisible", "IsConfirmPasswordVisible", "IsButtonEnabled", "IsExecuting", "IsNewPasswordCompliant", "GetUserDetail", "ClientVars"}, new string[] {"varLcOldPassword", "varLcNewPassword", "varLcConfirmPassword", "varLcIsPasswordVisible", "varLcIsConfirmPasswordVisible", "varLcIsButtonEnabled", "varLcIsExecuting", "varLcIsNewPasswordCompliant", "ScreenDataSetGetUserDetail", "clientVariables"});
this.varLcOldPassword = varLcOldPassword;
this.varLcNewPassword = varLcNewPassword;
this.varLcConfirmPassword = varLcConfirmPassword;
this.varLcIsPasswordVisible = varLcIsPasswordVisible;
this.varLcIsConfirmPasswordVisible = varLcIsConfirmPasswordVisible;
this.varLcIsButtonEnabled = varLcIsButtonEnabled;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsNewPasswordCompliant = varLcIsNewPasswordCompliant;
this.ScreenDataSetGetUserDetail = ScreenDataSetGetUserDetail;
this.clientVariables = clientVariables;
}



    
// Query Function "GetUserDetail" 1uflzfiVlEi5bBK53Texzg of Action "Wb_ChangePassword"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Wb_ChangePassword.GetUserDetail", "cde5e7d6-95f8-4894-b96c-12b9dd37b1ce");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ChangePassword","a_Common.Wb_ChangePassword.GetUserDetail");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.ddPgNlgEZ0WOLY2+t5Hi7w/ScreenDataSets.1uflzfiVlEi5bBK53Texzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser155\".\"email\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser155\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser155\".\"id\" = @qpusId) AND (\"enuser155\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser155\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Wb_ChangePassword.GetUserDetail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Wb_ChangePassword.GetUserDetail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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
