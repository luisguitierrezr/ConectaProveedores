namespace ssConectaProveedores;

public partial class Actions {
public class lcvSubstituteFolioFiles_v2_Construction : VarsBag {
public long inParamFolioId;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public RL_897c95bca5499c293930e47bf793d0d9 queryResGetFolioFilesByFolioId_outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public long resCreateFolioFiles_outParamId = 0L;

public RLAIItemRecordList queryResSetAllOldfiles_outParamList = new RLAIItemRecordList();
public long queryResSetAllOldfiles_outParamCount = 0L;

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilter3_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public long resServiceStorageCreate3_outParamId = 0L;

public RL_8d8af94fcd9af501b3964ae58f9c81aa queryResGetFolioById_outParamList = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
public long queryResGetFolioById_outParamCount = 0L;

public lcvSubstituteFolioFiles_v2_Construction(long inParamFolioId, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra) {
this.inParamFolioId = inParamFolioId;
this.inParamFilesListExtra = inParamFilesListExtra;
}
}
/// <summary>
/// Action <code>SubstituteFolioFiles_v2_Construction</code> that represents the Service Studio action
///  <code>SubstituteFolioFiles_v2_Construction</code> <p> Description: </p>
/// </summary>
public static async Task ActionSubstituteFolioFiles_v2_Construction(IRequestContext requestContext,long inParamFolioId,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,CancellationToken cancellationToken) {
lcvSubstituteFolioFiles_v2_Construction localVars = new lcvSubstituteFolioFiles_v2_Construction(inParamFolioId, inParamFilesListExtra);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SubstituteFolioFiles_v2_Construction", "695f70ca-3cfd-4f36-9321-45542865fc34"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SubstituteFolioFiles_v2_Construction", "695f70ca-3cfd-4f36-9321-45542865fc34", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSubstituteFolioFiles_v2_Construction.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 0;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncActionSubstituteFolioFiles_v2_Construction.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParamFolioId,cancellationToken);

// Query QuerySetAllOldfiles
cancellationToken.ThrowIfCancellationRequested();
int QuerySetAllOldfiles_maxRecords = 0;
int QuerySetAllOldfiles_startIndex = 0;(localVars.queryResSetAllOldfiles_outParamList,localVars.queryResSetAllOldfiles_outParamCount) = await FuncActionSubstituteFolioFiles_v2_Construction.QuerySetAllOldfiles(requestContext,QuerySetAllOldfiles_maxRecords,QuerySetAllOldfiles_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// Foreach GetFolioFilesByFolioId.List
localVars.queryResGetFolioFilesByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioFilesByFolioId_outParamList.Eof))) {
// ListFilter3
localVars.resListFilter3_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesListExtra.FilterAsync(async (p, cancellationToken) => (p.ssStorageId==localVars.queryResGetFolioFilesByFolioId_outParamList.CurrentRec.ssENFolioFiles.ssStorageId), cancellationToken)));

// new
if((localVars.resListFilter3_outParamFilteredList.Empty)) {
// ServiceStorageDelete3
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetFolioFilesByFolioId_outParamList.CurrentRec.ssENFolioFiles.ssStorageId,cancellationToken);

// DeleteFolioFiles
await ExtendedActions.DeleteFolioFiles(requestContext,localVars.queryResGetFolioFilesByFolioId_outParamList.CurrentRec.ssENFolioFiles.ssId,cancellationToken);

}

localVars.queryResGetFolioFilesByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioFilesByFolioId_outParamList.EndIteration();
}

// Foreach FilesListExtra
localVars.inParamFilesListExtra.StartIteration();
try {while (!((localVars.inParamFilesListExtra.Eof))) {
// new and exists
if((((localVars.inParamFilesListExtra.CurrentRec.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&!(BinaryContentUtils.AreBothBinariesNull(localVars.inParamFilesListExtra.CurrentRec.ssBinaryData, BuiltInFunction.NullBinary ()))))) {
// ServiceStorageCreate3
localVars.resServiceStorageCreate3_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, ssInternalConceptId = 1, ssFile = localVars.inParamFilesListExtra.CurrentRec.ssBinaryData, ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssVendor = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther]))))))), ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))), ssIstoSendToExternal = true },false,cancellationToken);

// CreateFolioFiles
localVars.resCreateFolioFiles_outParamId = await ExtendedActions.CreateFolioFiles(requestContext,new RC_28fdb7a8aef891dc921c5fe34393a569(){ ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(){ ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssFolioId = localVars.inParamFolioId, ssIsExtra = true, ssStorageId = localVars.resServiceStorageCreate3_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsNewFile = true } },cancellationToken);

}

localVars.inParamFilesListExtra.Advance();
}

} finally {
localVars.inParamFilesListExtra.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSubstituteFolioFiles_v2_Construction {

// Query Function "GetFolioFilesByFolioId" VYXvFEdywEuiCuQnnOztgQ of Action "SubstituteFolioFiles_v2_Construction"
public static async Task<(RL_897c95bca5499c293930e47bf793d0d9,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SubstituteFolioFiles_v2_Construction.GetFolioFilesByFolioId", "14ef8555-7247-4bc0-a20a-e4279ceced81");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SubstituteFolioFiles_v2_Construction.GetFolioFilesByFolioId", "14ef8555-7247-4bc0-a20a-e4279ceced81", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.ynBfaf08Nk+TIUVUKGX8NA/NodesNotShownInESpaceTree.VYXvFEdywEuiCuQnnOztgQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliofiles2\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"enfoliofiles2\".\"storageid\" o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {FolioFiles} \"enfoliofiles2\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliofiles2\".\"folioid\" = @qpfoFolioId) AND (\"enfoliofiles2\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliofiles2\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliofiles2\".\"filename\" ASC ");
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
RL_897c95bca5499c293930e47bf793d0d9 outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstituteFolioFiles_v2_Construction.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_897c95bca5499c293930e47bf793d0d9 _tmp = new RL_897c95bca5499c293930e47bf793d0d9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstituteFolioFiles_v2_Construction.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_897c95bca5499c293930e47bf793d0d9)_tmp;
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

// Query Function "SetAllOldfiles" qRe8y2XlnE+CXdHsAOD59w of Action "SubstituteFolioFiles_v2_Construction"
public static async Task<(RLAIItemRecordList,long)> QuerySetAllOldfiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioID,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("SubstituteFolioFiles_v2_Construction.SetAllOldfiles", "cbbc17a9-e565-4f9c-825d-d1ec00e0f9f7");
using var queryActivity = activitySource.CreateSqlQueryActivity("SubstituteFolioFiles_v2_Construction.SetAllOldfiles", "cbbc17a9-e565-4f9c-825d-d1ec00e0f9f7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolioFiles = AppUtils.Instance.RuntimeEntityReplace("FolioFiles");
sqlCmd.CreateParameter("@qpfoFolioID", DbType.Int64, qpfoFolioID);
string sql = "";
string advSql = "UPDATE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioFiles,"") + " \nSET \"isnewfile\" = 0 \nWHERE \"folioid\" = @qpfoFolioID";
string[] entitiesToCheck = new[] {"FolioFiles"};
AppUtils.Instance.RuntimeCheckReadOnlyEntity(entitiesToCheck);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLAIItemRecordList outParamList = new RLAIItemRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstituteFolioFiles_v2_Construction.SetAllOldfiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLAIItemRecordList _tmp = new RLAIItemRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstituteFolioFiles_v2_Construction.SetAllOldfiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLAIItemRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("SetAllOldfiles in SubstituteFolioFiles_v2_Construction in ConectaProveedores (UPDATE {FolioFiles}  SET [IsNewFile] = 0  WHERE [FolioId] = @FolioID): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SetAllOldfiles in SubstituteFolioFiles_v2_Construction in ConectaProveedores (UPDATE {FolioFiles}  SET [IsNewFile] = 0  WHERE [FolioId] = @FolioID): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SetAllOldfiles in SubstituteFolioFiles_v2_Construction in ConectaProveedores (UPDATE {FolioFiles}  SET [IsNewFile] = 0  WHERE [FolioId] = @FolioID): " + aqExcep.Message));
}
}
}

private static async Task<RC_d1d085a826d7afd1d542eed60c39554c> datasetGetFolioByIdReadDbAsync(RC_d1d085a826d7afd1d542eed60c39554c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" v+nc2ZQaVUeai+TqVwduyw of Action "SubstituteFolioFiles_v2_Construction"
public static async Task<(RL_8d8af94fcd9af501b3964ae58f9c81aa,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SubstituteFolioFiles_v2_Construction.GetFolioById", "d9dce9bf-1a94-4755-9a8b-e4ea57076ecb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SubstituteFolioFiles_v2_Construction.GetFolioById", "d9dce9bf-1a94-4755-9a8b-e4ea57076ecb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ynBfaf08Nk+TIUVUKGX8NA/NodesNotShownInESpaceTree.v+nc2ZQaVUeai+TqVwduyw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio19\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"ensupplier18\".\"number\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ({Folio} \"enfolio19\" Left JOIN {Supplier} \"ensupplier18\" ON (\"enfolio19\".\"supplierid\" = \"ensupplier18\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio19\".\"id\" = @qpfoFolio_Id) AND (\"enfolio19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio19\".\"id\" IS NULL)");
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
RL_8d8af94fcd9af501b3964ae58f9c81aa outParamList = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstituteFolioFiles_v2_Construction.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8d8af94fcd9af501b3964ae58f9c81aa _tmp = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstituteFolioFiles_v2_Construction.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8d8af94fcd9af501b3964ae58f9c81aa)_tmp;
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
