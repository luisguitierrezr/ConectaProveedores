using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel).Namespace);

    public long inParami_StorageId;
public long inParami_FileSize;
public bool inParami_IsTagStyle;
public string inParami_TagText;
public string inParami_ExtendedClass;
public bool varLcl_PopupToggler;
public ST_a158c76eb93396680623c04244f48b6cStructure varLcFileStruct;
public string varLcXML_Text;
public AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ScreenDataSetGetStorageById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel() {
}



    public ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel(long inParami_StorageId, long inParami_FileSize, bool inParami_IsTagStyle, string inParami_TagText, string inParami_ExtendedClass, bool varLcl_PopupToggler, ST_a158c76eb93396680623c04244f48b6cStructure varLcFileStruct, string varLcXML_Text, AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ScreenDataSetGetStorageById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_StorageId", "i_FileSize", "i_IsTagStyle", "i_TagText", "i_ExtendedClass", "l_PopupToggler", "FileStruct", "XML_Text", "GetStorageById", "ClientVars"}, new string[] {"inParami_StorageId", "inParami_FileSize", "inParami_IsTagStyle", "inParami_TagText", "inParami_ExtendedClass", "varLcl_PopupToggler", "varLcFileStruct", "varLcXML_Text", "ScreenDataSetGetStorageById", "clientVariables"});
this.inParami_StorageId = inParami_StorageId;
this.inParami_FileSize = inParami_FileSize;
this.inParami_IsTagStyle = inParami_IsTagStyle;
this.inParami_TagText = inParami_TagText;
this.inParami_ExtendedClass = inParami_ExtendedClass;
this.varLcl_PopupToggler = varLcl_PopupToggler;
this.varLcFileStruct = varLcFileStruct;
this.varLcXML_Text = varLcXML_Text;
this.ScreenDataSetGetStorageById = ScreenDataSetGetStorageById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetStorageById" Fp16TiS1yUOYpgxV3lxtxQ of Action "wb_PreviewFile"
public static async Task<(RL_d3db3806acf82f8f2cc8b7a1ac07805b,long)> datasetGetStorageById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpstId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("s_Storage.wb_PreviewFile.GetStorageById", "4e7a9d16-b524-43c9-98a6-0c55de5c6dc5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_PreviewFile","s_Storage.wb_PreviewFile.GetStorageById");
// Query Iterations: Never
// Refresh Query yntXD6MyxkWINHR1T_rj5A Iterations: Never
// Refresh Query CNd+YSI4fUiGzXF2TTyQcw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.2U30RcCSoUG+QhQMrCUZgA/NodesShownInESpaceTree.oDfF5HPU0Eix9NC4eCWPig/ScreenDataSets.Fp16TiS1yUOYpgxV3lxtxQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"enstorage30\".\"filename\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Storage} \"enstorage30\"");
whereBuilder.Append(" WHERE ");
if (qpstId != 0) {
whereBuilder.Append("((\"enstorage30\".\"id\" = @qpstId) AND (\"enstorage30\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpstId", DbType.Int64, qpstId);
} else {
whereBuilder.Append("(\"enstorage30\".\"id\" IS NULL)");
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
RL_d3db3806acf82f8f2cc8b7a1ac07805b outParamList = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query s_Storage.wb_PreviewFile.GetStorageById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3db3806acf82f8f2cc8b7a1ac07805b _tmp = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query s_Storage.wb_PreviewFile.GetStorageById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3db3806acf82f8f2cc8b7a1ac07805b)_tmp;
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
