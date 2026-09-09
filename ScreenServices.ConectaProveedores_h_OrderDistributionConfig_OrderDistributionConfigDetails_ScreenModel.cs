using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel).Namespace);

    public long inParamConfigId;
public bool varLcShowPopup;
public string varLcOriginalJSON;
public DateTime varLcl_RefeshSideBar;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_44cb753cf22fd0b01aa78a5ab2f30079> ScreenDataSetGetOrderDistributionConfigById;
public AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> ScreenDataSetGetTelcelDirections;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel() {
}



    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel(long inParamConfigId, bool varLcShowPopup, string varLcOriginalJSON, DateTime varLcl_RefeshSideBar, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_44cb753cf22fd0b01aa78a5ab2f30079> ScreenDataSetGetOrderDistributionConfigById, AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> ScreenDataSetGetTelcelDirections, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ConfigId", "ShowPopup", "OriginalJSON", "l_RefeshSideBar", "GetRegions", "GetOrderDistributionConfigById", "GetTelcelDirections", "ClientVars"}, new string[] {"inParamConfigId", "varLcShowPopup", "varLcOriginalJSON", "varLcl_RefeshSideBar", "ScreenDataSetGetRegions", "ScreenDataSetGetOrderDistributionConfigById", "ScreenDataSetGetTelcelDirections", "clientVariables"});
this.inParamConfigId = inParamConfigId;
this.varLcShowPopup = varLcShowPopup;
this.varLcOriginalJSON = varLcOriginalJSON;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetOrderDistributionConfigById = ScreenDataSetGetOrderDistributionConfigById;
this.ScreenDataSetGetTelcelDirections = ScreenDataSetGetTelcelDirections;
this.clientVariables = clientVariables;
}



    
// Query Function "GetRegions" ZTQtISvA9E+Tmhaw7ZpLvQ of Action "OrderDistributionConfigDetails"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.OrderDistributionConfigDetails.GetRegions", "212d3465-c02b-4ff4-939a-16b0ed9a4bbd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDistributionConfigDetails","h_OrderDistributionConfig.OrderDistributionConfigDetails.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.L2vQZodjIkuWwLt97skalg/ScreenDataSets.ZTQtISvA9E+Tmhaw7ZpLvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion137\".\"id\" o0, NULL o1, NULL o2, \"enregion137\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion137\"");
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
opt[0] = new BitArray(new bool[] {false, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetRegions.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderDistributionConfigById" US+vd0dUZEqbgaeI64n9Vg of Action "OrderDistributionConfigDetails"
public static async Task<(RL_44cb753cf22fd0b01aa78a5ab2f30079,long)> datasetGetOrderDistributionConfigById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.OrderDistributionConfigDetails.GetOrderDistributionConfigById", "77af2f51-5447-4a64-9b81-a788eb89fd56");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDistributionConfigDetails","h_OrderDistributionConfig.OrderDistributionConfigDetails.GetOrderDistributionConfigById");
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.L2vQZodjIkuWwLt97skalg/ScreenDataSets.US+vd0dUZEqbgaeI64n9Vg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderdistributionconfig6\".\"id\" o0, \"enorderdistributionconfig6\".\"regionid\" o1, \"enorderdistributionconfig6\".\"applicant\" o2, \"enorderdistributionconfig6\".\"applicantdescription\" o3, \"enorderdistributionconfig6\".\"directionid\" o4, \"enorderdistributionconfig6\".\"firstcontact_entraroleid\" o5, \"enorderdistributionconfig6\".\"secondcontact_entraroleid\" o6, \"enorderdistributionconfig6\".\"firstapprover_entraroleid\" o7, \"enorderdistributionconfig6\".\"secondapprover_entraroleid\" o8, \"enorderdistributionconfig6\".\"createdby\" o9, \"enorderdistributionconfig6\".\"createdon\" o10, \"enorderdistributionconfig6\".\"updatedby\" o11, \"enorderdistributionconfig6\".\"updatedon\" o12");
fromBuilder.Append(" FROM {OrderDistributionConfig} \"enorderdistributionconfig6\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderdistributionconfig6\".\"id\" = @qporId) AND (\"enorderdistributionconfig6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderdistributionconfig6\".\"id\" IS NULL)");
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
RL_44cb753cf22fd0b01aa78a5ab2f30079 outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetOrderDistributionConfigById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_44cb753cf22fd0b01aa78a5ab2f30079 _tmp = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetOrderDistributionConfigById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_44cb753cf22fd0b01aa78a5ab2f30079)_tmp;
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

// Query Function "GetTelcelDirections" DZ5ljT6+w0qfWWTiuCoegQ of Action "OrderDistributionConfigDetails"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetTelcelDirections(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.OrderDistributionConfigDetails.GetTelcelDirections", "8d659e0d-be3e-4ac3-9f59-64e2b82a1e81");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDistributionConfigDetails","h_OrderDistributionConfig.OrderDistributionConfigDetails.GetTelcelDirections");
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.L2vQZodjIkuWwLt97skalg/ScreenDataSets.DZ5ljT6+w0qfWWTiuCoegQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entelceldirection14\".\"id\" o0, \"entelceldirection14\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection14\"");
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetTelcelDirections.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.OrderDistributionConfigDetails.GetTelcelDirections.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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
