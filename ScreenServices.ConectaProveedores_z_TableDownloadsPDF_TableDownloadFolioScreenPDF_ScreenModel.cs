using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel).Namespace);

    public string inParamStringListIds;
public RLTextList varLcFolioIdsList;
public ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model varLcGetFolios;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel() {
}



    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel(string inParamStringListIds, RLTextList varLcFolioIdsList, ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model varLcGetFolios, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StringListIds", "FolioIdsList", "GetFolios", "ClientVars"}, new string[] {"inParamStringListIds", "varLcFolioIdsList", "varLcGetFolios", "clientVariables"});
this.inParamStringListIds = inParamStringListIds;
this.varLcFolioIdsList = varLcFolioIdsList;
this.varLcGetFolios = varLcGetFolios;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFolios : VarsBag {
public RL_30161a112f14892cdc0ac26addbb3f2a queryResGetFoliosSAE_outParamList = new RL_30161a112f14892cdc0ac26addbb3f2a();
public long queryResGetFoliosSAE_outParamCount = 0L;

public lcvGetFolios() {
}
}
public class lcoGetFolios : VarsBag {
public RL_9046748205310553b4766e7b1bf0c997 outParamList = new RL_9046748205310553b4766e7b1bf0c997();

public lcoGetFolios() {
}
}
/// <summary>
/// Action <code>GetFolios</code> that represents the Service Studio action <code>GetFolios</code> <p>
///  Description: </p>
/// </summary>
public async Task<RL_9046748205310553b4766e7b1bf0c997> DataActionGetFolios(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_9046748205310553b4766e7b1bf0c997 outParamList = default;
lcoGetFolios result = new lcoGetFolios();
lcvGetFolios localVars = new lcvGetFolios();
ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolios", "b30dfe43-487f-42e6-b2d6-86d92dfa5d4e"))
using (activitySource.CreateScreenDataActionActivity("TableDownloadFolioScreenPDF", "GetFolios")){
// Foreach FolioIdsList
varLcFolioIdsList.StartIteration();
try {while (!((varLcFolioIdsList.Eof))) {
// Query datasetGetFoliosSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosSAE_maxRecords = 999999999;
if (datasetGetFoliosSAE_maxRecords < 1) datasetGetFoliosSAE_maxRecords = 1;
int datasetGetFoliosSAE_startIndex = 0;(localVars.queryResGetFoliosSAE_outParamList,localVars.queryResGetFoliosSAE_outParamCount) = await FuncDataActionGetFolios.datasetGetFoliosSAE(requestContext,datasetGetFoliosSAE_maxRecords,datasetGetFoliosSAE_startIndex,IterationMultiplicity.Never,varLcFolioIdsList.CurrentRec.ssValue,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamList,(await RecordUtils.ConvertAsync(localVars.queryResGetFoliosSAE_outParamList.CurrentRec, new ST_3dc7a528e6a1e146b195db5c3edb006aStructure(), async (RC_b392345d734f6e0fb1fef27015c3b935 source, ST_3dc7a528e6a1e146b195db5c3edb006aStructure target, CancellationToken cancellationToken) => {
target.ssFolioId = source.ssENFolio.ssId;
target.ssFolioNumber = source.ssENFolio.ssFolioNumber;
target.ssOrderNumber = source.ssENOrderMain.ssOrderNumber;
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssSupplierNumber = source.ssENSupplier.ssNumber;
target.ssRegion = source.ssENRegion.ssCode;
target.ssTotalAmount = BuiltInFunction.FormatCurrency (source.ssENFolio.ssTotalAmount, "", 2, ".", ",");
target.ssCurrency = source.ssENFolio.ssCurrencyId;
target.ssUploadDate = BuiltInFunction.FormatDateTime (source.ssENFolio.ssCreatedOn, "dd/MM/yyyy");
target.ssStatus = source.ssENFolioStatus.ssLabelES;
return target;
}, cancellationToken)),cancellationToken);

varLcFolioIdsList.Advance();
}

} finally {
varLcFolioIdsList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetFolios {

private static async Task<RC_b392345d734f6e0fb1fef27015c3b935> datasetGetFoliosSAEReadDbAsync(RC_b392345d734f6e0fb1fef27015c3b935 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFoliosSAE" EeRXrBFTeEitDC34S9cJMg of Action "GetFolios"
public static async Task<(RL_30161a112f14892cdc0ac26addbb3f2a,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadFolioScreenPDF.GetFolios.GetFoliosSAE", "ac57e411-5311-4878-ad0c-2df84bd70932");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadFolioScreenPDF.GetFolios.GetFoliosSAE", "ac57e411-5311-4878-ad0c-2df84bd70932", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.qBBd5uplSky29QGwJb9ENg/DataActions.Q_4Ns39I5kKy1obZLfpdTg/NodesNotShownInESpaceTree.EeRXrBFTeEitDC34S9cJMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enfolio71\".\"id\" o17, NULL o18, \"enfolio71\".\"folionumber\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enfolio71\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, \"enfolio71\".\"currencyid\" o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enfolio71\".\"createdon\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, \"enfoliostatus8\".\"labeles\" o72, NULL o73, \"enordermain110\".\"ordernumber\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enregion152\".\"code\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, \"ensupplier115\".\"name\" o117, \"ensupplier115\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio71\" Left JOIN {FolioApproval} \"enfolioapproval38\" ON (\"enfolio71\".\"id\" = \"enfolioapproval38\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel34\" ON (\"enfolioapproval38\".\"id\" = \"enfolioapprovallevel34\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain110\" ON (\"enfolio71\".\"orderid\" = \"enordermain110\".\"id\"))  Left JOIN {Region} \"enregion152\" ON (\"enordermain110\".\"regionid\" = \"enregion152\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole74\" ON (\"enfolioapprovallevel34\".\"applicationroleid\" = \"enapplicationrole74\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus8\" ON (\"enfolio71\".\"foliostatusid\" = \"enfoliostatus8\".\"id\"))  Left JOIN {Supplier} \"ensupplier115\" ON (\"enfolio71\".\"supplierid\" = \"ensupplier115\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus22\" ON (\"enfolioapprovallevel34\".\"approvalstatusid\" = \"enapprovalstatus22\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enfolio71\".\"id\" = cast(((coalesce(cast(nullif(@qpteFolio_Id,'') as integer), 0))) as bigint))");
orderByBuilder.Append(" ORDER BY \"enfolio71\".\"id\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolio_Id", DbType.String, qpteFolio_Id);
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
RL_30161a112f14892cdc0ac26addbb3f2a outParamList = new RL_30161a112f14892cdc0ac26addbb3f2a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, false, true, true, false, true, true, true, true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadFolioScreenPDF.GetFolios.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_30161a112f14892cdc0ac26addbb3f2a _tmp = new RL_30161a112f14892cdc0ac26addbb3f2a();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadFolioScreenPDF.GetFolios.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_30161a112f14892cdc0ac26addbb3f2a)_tmp;
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
