using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel).Namespace);

    public bool varLcl_IsBusy;
public string varLcl_UserSelected;
public AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ScreenDataSetGetUserById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel(bool varLcl_IsBusy, string varLcl_UserSelected, AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ScreenDataSetGetUserById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_IsBusy", "l_UserSelected", "GetUserById", "ClientVars"}, new string[] {"varLcl_IsBusy", "varLcl_UserSelected", "ScreenDataSetGetUserById", "clientVariables"});
this.varLcl_IsBusy = varLcl_IsBusy;
this.varLcl_UserSelected = varLcl_UserSelected;
this.ScreenDataSetGetUserById = ScreenDataSetGetUserById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserByIdReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" 4UY+2xey7k+FqXlUbsy5hQ of Action "Wb_AssignFirstApproverPopup"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,long qpreUser_Extended_Internal_RegionId,long qpteUser_Extended_Internal_TelcelDirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_AssignFirstApproverPopup.GetUserById", "db3e46e1-b217-4fee-85a9-79546eccb985");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_AssignFirstApproverPopup","c_Requisitions.Wb_AssignFirstApproverPopup.GetUserById");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.VgWxXeHnV0K34_R3mwPiDg/ScreenDataSets.4UY+2xey7k+FqXlUbsy5hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser181\".\"id\" o0, \"enuser181\".\"name\" o1, \"enuser181\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM (({User} \"enuser181\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal109\" ON (\"enuser181\".\"id\" = \"enuser_extended_internal109\".\"id\"))  Left JOIN {UserExtension} \"enuserextension73\" ON (\"enuser181\".\"id\" = \"enuserextension73\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal109\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal109\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal109\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpteUser_Extended_Internal_TelcelDirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal109\".\"telceldirectionid\" = @qpteUser_Extended_Internal_TelcelDirectionId) AND (\"enuser_extended_internal109\".\"telceldirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDirectionId", DbType.Int64, qpteUser_Extended_Internal_TelcelDirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal109\".\"telceldirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser181\".\"id\" <> @qpusUser_Id) OR (\"enuser181\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser181\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension73\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
orderByBuilder.Append(" ORDER BY \"enuser181\".\"name\" ASC ");
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
RL_bc2063fe1d05aa544017f329fb1e030b outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_AssignFirstApproverPopup.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_AssignFirstApproverPopup.GetUserById.List", cancellationToken: cancellationToken);
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


    

    

}
