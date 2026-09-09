using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel).Namespace);

    public long inParamSupplierId;
public bool inParamIsEnabled;
public long inParamRequisitionId;
public AggregateRecord<RL_b9a4d89a3154e989f9ae297e352963c3> ScreenDataSetGetRequisitionById;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_SearchSupplier_ScreenModel(long inParamSupplierId, bool inParamIsEnabled, long inParamRequisitionId, AggregateRecord<RL_b9a4d89a3154e989f9ae297e352963c3> ScreenDataSetGetRequisitionById, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"SupplierId", "IsEnabled", "RequisitionId", "GetRequisitionById", "GetSupplierById", "ClientVars"}, new string[] {"inParamSupplierId", "inParamIsEnabled", "inParamRequisitionId", "ScreenDataSetGetRequisitionById", "ScreenDataSetGetSupplierById", "clientVariables"});
this.inParamSupplierId = inParamSupplierId;
this.inParamIsEnabled = inParamIsEnabled;
this.inParamRequisitionId = inParamRequisitionId;
this.ScreenDataSetGetRequisitionById = ScreenDataSetGetRequisitionById;
this.ScreenDataSetGetSupplierById = ScreenDataSetGetSupplierById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_4b3e229d9fe6ec886da8c5cf0d4be972> datasetGetRequisitionByIdReadDbAsync(RC_4b3e229d9fe6ec886da8c5cf0d4be972 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" K0tiRUbFeU+i+muze6nGtg of Action "Wb_SearchSupplier"
public static async Task<(RL_b9a4d89a3154e989f9ae297e352963c3,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_SearchSupplier.GetRequisitionById", "45624b2b-c546-4f79-a2fa-6bb37ba9c6b6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplier","c_Requisitions.Wb_SearchSupplier.GetRequisitionById");
// Query Iterations: Multiple
// Refresh Query X8ZcDnfX+ke9xRlhrqvX8w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.PA3KdSRAz0OvtXFBcQGxqg/ScreenDataSets.K0tiRUbFeU+i+muze6nGtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enregion139\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enrequisition109\".\"regionid\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70");
fromBuilder.Append(" FROM ({Region} \"enregion139\" Left JOIN {Requisition} \"enrequisition109\" ON (\"enregion139\".\"id\" = \"enrequisition109\".\"regionid\")) ");
whereBuilder.Append(" WHERE (");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition109\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition109\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition109\".\"id\" IS NULL)");
}
whereBuilder.Append(" OR (\"enrequisition109\".\"id\" IS NULL))");
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
RL_b9a4d89a3154e989f9ae297e352963c3 outParamList = new RL_b9a4d89a3154e989f9ae297e352963c3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_SearchSupplier.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9a4d89a3154e989f9ae297e352963c3 _tmp = new RL_b9a4d89a3154e989f9ae297e352963c3();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_SearchSupplier.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9a4d89a3154e989f9ae297e352963c3)_tmp;
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

private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSupplierByIdReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierById" UCdm+EHRXUuMfCrn1H9o+w of Action "Wb_SearchSupplier"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_SearchSupplier.GetSupplierById", "f8662750-d141-4b5d-8c7c-2ae7d47f68fb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplier","c_Requisitions.Wb_SearchSupplier.GetSupplierById");
// Query Iterations: Never
// Refresh Query 9bIS+Q6GfUSBmybt3+mJ5Q Iterations: Never
// Refresh Query kesBbaeAQU6FGU2Fd4wGwg Iterations: Never
// Refresh Query 7wXPhAaUK0ebyxRnrXnYKA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.PA3KdSRAz0OvtXFBcQGxqg/ScreenDataSets.UCdm+EHRXUuMfCrn1H9o+w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"ensupplier110\".\"tratamiento\" o14, \"ensupplier110\".\"name\" o15, \"ensupplier110\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, \"ensupplier110\".\"pais\" o21, \"ensupplier110\".\"region_\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"ensupplier110\".\"n_ident_fis_1\" o30, NULL o31, \"ensupplier110\".\"ramo\" o32, \"ensupplier110\".\"grupodeporte\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier110\" Left JOIN {Region} \"enregion140\" ON (\"ensupplier110\".\"regionid\" = \"enregion140\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier110\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier110\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier110\".\"id\" IS NULL)");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, false, false, true, true, true, true, false, false, true, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_SearchSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_SearchSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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
