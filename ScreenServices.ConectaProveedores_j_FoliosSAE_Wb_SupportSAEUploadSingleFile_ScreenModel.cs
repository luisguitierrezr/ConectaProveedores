using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel).Namespace);

    public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File;
public bool varLcAreFilesUploaded;
public ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty;
public AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> ScreenDataSetGetSupplierUsersByUserId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel(RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File, bool varLcAreFilesUploaded, ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty, AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> ScreenDataSetGetSupplierUsersByUserId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FilesList", "l_File", "AreFilesUploaded", "l_FileEmpty", "GetSupplierUsersByUserId", "ClientVars"}, new string[] {"varLcFilesList", "varLcl_File", "varLcAreFilesUploaded", "varLcl_FileEmpty", "ScreenDataSetGetSupplierUsersByUserId", "clientVariables"});
this.varLcFilesList = varLcFilesList;
this.varLcl_File = varLcl_File;
this.varLcAreFilesUploaded = varLcAreFilesUploaded;
this.varLcl_FileEmpty = varLcl_FileEmpty;
this.ScreenDataSetGetSupplierUsersByUserId = ScreenDataSetGetSupplierUsersByUserId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_187912d0df64c67be181be3d4f7af5f3> datasetGetSupplierUsersByUserIdReadDbAsync(RC_187912d0df64c67be181be3d4f7af5f3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierUsersByUserId" Jl10Uv0sVkOIl1454TRWVA of Action "Wb_SupportSAEUploadSingleFile"
public static async Task<(RL_5a0829a2b3c6573471cd9bfcbf323787,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusSupplierUser_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SupportSAEUploadSingleFile.GetSupplierUsersByUserId", "52745d26-2cfd-4356-8897-5e39e1345654");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SupportSAEUploadSingleFile","j_FoliosSAE.Wb_SupportSAEUploadSingleFile.GetSupplierUsersByUserId");
// Query Iterations: Never
// Refresh Query j6IzROtCyUmzsH0UcQv+mw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.hlDmL+qxDE2ZxsW8NnRXog/ScreenDataSets.Jl10Uv0sVkOIl1454TRWVA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM ({SupplierUser} \"ensupplieruser25\" Left JOIN {Supplier} \"ensupplier133\" ON (\"ensupplieruser25\".\"supplierid\" = \"ensupplier133\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusSupplierUser_UserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser25\".\"userid\" = @qpusSupplierUser_UserId) AND (\"ensupplieruser25\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
} else {
whereBuilder.Append("(\"ensupplieruser25\".\"userid\" IS NULL)");
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
RL_5a0829a2b3c6573471cd9bfcbf323787 outParamList = new RL_5a0829a2b3c6573471cd9bfcbf323787();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierUsersByUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SupportSAEUploadSingleFile.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a0829a2b3c6573471cd9bfcbf323787 _tmp = new RL_5a0829a2b3c6573471cd9bfcbf323787();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierUsersByUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SupportSAEUploadSingleFile.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a0829a2b3c6573471cd9bfcbf323787)_tmp;
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
