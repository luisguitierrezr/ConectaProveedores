using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel).Namespace);

    public long inParami_ManualId;
public AggregateRecord<RL_d2939f0caa78f2bcae0d5522f32cf37b> ScreenDataSetGetManualById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel() {
}



    public ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel(long inParami_ManualId, AggregateRecord<RL_d2939f0caa78f2bcae0d5522f32cf37b> ScreenDataSetGetManualById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ManualId", "GetManualById", "ClientVars"}, new string[] {"inParami_ManualId", "ScreenDataSetGetManualById", "clientVariables"});
this.inParami_ManualId = inParami_ManualId;
this.ScreenDataSetGetManualById = ScreenDataSetGetManualById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_367437e31e499bf19d13607cb372e4f5> datasetGetManualByIdReadDbAsync(RC_367437e31e499bf19d13607cb372e4f5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENManualFile.Read( r, ref index);
rec.ssENManuals.Read( r, ref index);
return rec;
}
// Query Function "GetManualById" hRsI13mL2Um8as78Vi764w of Action "ManualDetailView"
public static async Task<(RL_d2939f0caa78f2bcae0d5522f32cf37b,long)> datasetGetManualById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpmaManuals_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("m_Manuals.ManualDetailView.GetManualById", "d7081b85-8b79-49d9-bc6a-cefc562efae3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ManualDetailView","m_Manuals.ManualDetailView.GetManualById");
// Query Iterations: Never
// Refresh Query yOR5TMonzUqoXQjqcq5Edg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.89mnu6g_g02tRDJNYbRrPw/NodesShownInESpaceTree.D_x3uLYWAU+lOl+oiBKWeQ/ScreenDataSets.hRsI13mL2Um8as78Vi764w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enmanualfile1\".\"file\" o2, \"enmanualfile1\".\"videolink\" o3, NULL o4, \"enmanuals2\".\"title\" o5, NULL o6, NULL o7, \"enmanuals2\".\"shortdescription\" o8, \"enmanuals2\".\"description\" o9, NULL o10, NULL o11, \"enmanuals2\".\"isvideo\" o12, NULL o13, NULL o14, NULL o15");
fromBuilder.Append(" FROM ({Manuals} \"enmanuals2\" Left JOIN {ManualFile} \"enmanualfile1\" ON (\"enmanuals2\".\"id\" = \"enmanualfile1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpmaManuals_Id != 0) {
whereBuilder.Append("((\"enmanuals2\".\"id\" = @qpmaManuals_Id) AND (\"enmanuals2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaManuals_Id", DbType.Int64, qpmaManuals_Id);
} else {
whereBuilder.Append("(\"enmanuals2\".\"id\" IS NULL)");
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
RL_d2939f0caa78f2bcae0d5522f32cf37b outParamList = new RL_d2939f0caa78f2bcae0d5522f32cf37b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetManualByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, false, false, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query m_Manuals.ManualDetailView.GetManualById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d2939f0caa78f2bcae0d5522f32cf37b _tmp = new RL_d2939f0caa78f2bcae0d5522f32cf37b();
_tmp.AlternateReadDbMethodAsync = datasetGetManualByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query m_Manuals.ManualDetailView.GetManualById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d2939f0caa78f2bcae0d5522f32cf37b)_tmp;
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
