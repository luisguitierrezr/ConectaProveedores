namespace ssConectaProveedores;

public partial class Actions {
public class lcvSubstitutoFolioFiles_v2_Extra : VarsBag {
public long inParamFolioId;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public long inParamInvoiceId;
public long resCreateInvoiceFile2_outParamId = 0L;

public RL_8d8af94fcd9af501b3964ae58f9c81aa queryResGetFolioById_outParamList = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
public long queryResGetFolioById_outParamCount = 0L;

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilter2_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public long resServiceStorageCreate2_outParamId = 0L;

public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoiceFilesExtra_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoiceFilesExtra_outParamCount = 0L;

public lcvSubstitutoFolioFiles_v2_Extra(long inParamFolioId, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra, long inParamInvoiceId) {
this.inParamFolioId = inParamFolioId;
this.inParamFilesListExtra = inParamFilesListExtra;
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>SubstitutoFolioFiles_v2_Extra</code> that represents the Service Studio action
///  <code>SubstitutoFolioFiles_v2_Extra</code> <p> Description: </p>
/// </summary>
public static async Task ActionSubstitutoFolioFiles_v2_Extra(IRequestContext requestContext,long inParamFolioId,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvSubstitutoFolioFiles_v2_Extra localVars = new lcvSubstitutoFolioFiles_v2_Extra(inParamFolioId, inParamFilesListExtra, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SubstitutoFolioFiles_v2_Extra", "7fd03432-4014-4f68-9b93-780e0ee97967"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SubstitutoFolioFiles_v2_Extra", "7fd03432-4014-4f68-9b93-780e0ee97967", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSubstitutoFolioFiles_v2_Extra.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// Query datasetGetInvoiceFilesExtra
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesExtra_maxRecords = 0;
int datasetGetInvoiceFilesExtra_startIndex = 0;(localVars.queryResGetInvoiceFilesExtra_outParamList,localVars.queryResGetInvoiceFilesExtra_outParamCount) = await FuncActionSubstitutoFolioFiles_v2_Extra.datasetGetInvoiceFilesExtra(requestContext,datasetGetInvoiceFilesExtra_maxRecords,datasetGetInvoiceFilesExtra_startIndex,IterationMultiplicity.Single,localVars.inParamFolioId,cancellationToken);

// Foreach GetInvoiceFilesExtra.List
localVars.queryResGetInvoiceFilesExtra_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesExtra_outParamList.Eof))) {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesListExtra.FilterAsync(async (p, cancellationToken) => (p.ssStorageId==localVars.queryResGetInvoiceFilesExtra_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId), cancellationToken)));

// new
if((localVars.resListFilter2_outParamFilteredList.Empty)) {
// ServiceStorageDelete2
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFilesExtra_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// DeleteInvoiceFile2
await ExtendedActions.DeleteInvoiceFile(requestContext,localVars.queryResGetInvoiceFilesExtra_outParamList.CurrentRec.ssENInvoiceFile.ssId,cancellationToken);

}

localVars.queryResGetInvoiceFilesExtra_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesExtra_outParamList.EndIteration();
}

// Foreach FilesListExtra
localVars.inParamFilesListExtra.StartIteration();
try {while (!((localVars.inParamFilesListExtra.Eof))) {
// new and exists
if((((localVars.inParamFilesListExtra.CurrentRec.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&!(BinaryContentUtils.AreBothBinariesNull(localVars.inParamFilesListExtra.CurrentRec.ssBinaryData, BuiltInFunction.NullBinary ()))))) {
// ServiceStorageCreate2
localVars.resServiceStorageCreate2_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, ssInternalConceptId = 1, ssFile = localVars.inParamFilesListExtra.CurrentRec.ssBinaryData, ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssVendor = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther]))))))), ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))), ssIstoSendToExternal = true },false,cancellationToken);

// CreateInvoiceFile2
localVars.resCreateInvoiceFile2_outParamId = await ExtendedActions.CreateInvoiceFile(requestContext,new RC_18990af86f7169e92b712b468e13b947(){ ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssInvoiceId = localVars.inParamInvoiceId, ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssIsExtra = true, ssIsReport = false, ssStorageId = localVars.resServiceStorageCreate2_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

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

public static class FuncActionSubstitutoFolioFiles_v2_Extra {

private static async Task<RC_d1d085a826d7afd1d542eed60c39554c> datasetGetFolioByIdReadDbAsync(RC_d1d085a826d7afd1d542eed60c39554c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" phEgJ75ATUOWDpRxZ5w97Q of Action "SubstitutoFolioFiles_v2_Extra"
public static async Task<(RL_8d8af94fcd9af501b3964ae58f9c81aa,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SubstitutoFolioFiles_v2_Extra.GetFolioById", "272011a6-40be-434d-960e-9471679c3ded");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SubstitutoFolioFiles_v2_Extra.GetFolioById", "272011a6-40be-434d-960e-9471679c3ded", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.MjTQfxRAaE+bk3gODul5Zw/NodesNotShownInESpaceTree.phEgJ75ATUOWDpRxZ5w97Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio27\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"ensupplier22\".\"number\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ({Folio} \"enfolio27\" Left JOIN {Supplier} \"ensupplier22\" ON (\"enfolio27\".\"supplierid\" = \"ensupplier22\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio27\".\"id\" = @qpfoFolio_Id) AND (\"enfolio27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio27\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstitutoFolioFiles_v2_Extra.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstitutoFolioFiles_v2_Extra.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesExtraReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesExtra" NgtV0dSwEE+kdO_sI899HA of Action "SubstitutoFolioFiles_v2_Extra"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFilesExtra(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SubstitutoFolioFiles_v2_Extra.GetInvoiceFilesExtra", "d1550b36-b0d4-4f10-a474-efec23cf7d1c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SubstitutoFolioFiles_v2_Extra.GetInvoiceFilesExtra", "d1550b36-b0d4-4f10-a474-efec23cf7d1c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.MjTQfxRAaE+bk3gODul5Zw/NodesNotShownInESpaceTree.NgtV0dSwEE+kdO_sI899HA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoicefile10\".\"id\" o24, NULL o25, NULL o26, NULL o27, NULL o28, \"eninvoicefile10\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice33\" Inner JOIN {InvoiceFile} \"eninvoicefile10\" ON (\"eninvoice33\".\"id\" = \"eninvoicefile10\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice33\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice33\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice33\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile10\".\"isextra\" = 1)");
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesExtraReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstitutoFolioFiles_v2_Extra.GetInvoiceFilesExtra.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesExtraReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstitutoFolioFiles_v2_Extra.GetInvoiceFilesExtra.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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
