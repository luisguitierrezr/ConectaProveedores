using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel).Namespace);

    public string varLcFileName;
public DateTime varLcDateStart;
public DateTime varLcDateEnd;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public long varLcStorageId;
public bool varLcIsSelectOne;
public DateTime varLcForceRefresh;
public string varLcClickedCollum;
public ConectaProveedores_g_Reports_wb_documentExtrationFiles_DataActionGetAllFiles_Model varLcGetAllFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel() {
}



    public ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel(string varLcFileName, DateTime varLcDateStart, DateTime varLcDateEnd, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, long varLcStorageId, bool varLcIsSelectOne, DateTime varLcForceRefresh, string varLcClickedCollum, ConectaProveedores_g_Reports_wb_documentExtrationFiles_DataActionGetAllFiles_Model varLcGetAllFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FileName", "DateStart", "DateEnd", "TableSort", "StartIndex", "MaxRecords", "StorageId", "IsSelectOne", "ForceRefresh", "ClickedCollum", "GetAllFiles", "ClientVars"}, new string[] {"varLcFileName", "varLcDateStart", "varLcDateEnd", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcStorageId", "varLcIsSelectOne", "varLcForceRefresh", "varLcClickedCollum", "varLcGetAllFiles", "clientVariables"});
this.varLcFileName = varLcFileName;
this.varLcDateStart = varLcDateStart;
this.varLcDateEnd = varLcDateEnd;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcStorageId = varLcStorageId;
this.varLcIsSelectOne = varLcIsSelectOne;
this.varLcForceRefresh = varLcForceRefresh;
this.varLcClickedCollum = varLcClickedCollum;
this.varLcGetAllFiles = varLcGetAllFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetAllFiles : VarsBag {
public RL_26f7eba5ac045368b1e866dc619ecc4d queryResGetInvoiceFiles_outParamList = new RL_26f7eba5ac045368b1e866dc619ecc4d();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public RL_cffe9dc584f94114622f35f97e0bde6b queryResGetRequisitionFiles_outParamList = new RL_cffe9dc584f94114622f35f97e0bde6b();
public long queryResGetRequisitionFiles_outParamCount = 0L;

public RL_2ee5e32f7cbdd7ae81465087ec05e535 queryResGetOrderFiles_outParamList = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
public long queryResGetOrderFiles_outParamCount = 0L;

public RL_e98bb88ed92fb603b0cfe20670483f89 queryResGetFoliosFiles_outParamList = new RL_e98bb88ed92fb603b0cfe20670483f89();
public long queryResGetFoliosFiles_outParamCount = 0L;

public lcvGetAllFiles() {
}
}
public class lcoGetAllFiles : VarsBag {
public RL_845dd74219b9b2e8e635abcbf851e5ff outParamDocumentExtrationFiles = new RL_845dd74219b9b2e8e635abcbf851e5ff();

public lcoGetAllFiles() {
}
}
/// <summary>
/// Action <code>GetAllFiles</code> that represents the Service Studio action <code>GetAllFiles</code>
///  <p> Description: </p>
/// </summary>
public async Task<RL_845dd74219b9b2e8e635abcbf851e5ff> DataActionGetAllFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_845dd74219b9b2e8e635abcbf851e5ff outParamDocumentExtrationFiles = default;
lcoGetAllFiles result = new lcoGetAllFiles();
lcvGetAllFiles localVars = new lcvGetAllFiles();
ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetAllFiles", "a222b4f7-a755-4434-8594-9ba9fd1d72a9"))
using (activitySource.CreateScreenDataActionActivity("wb_documentExtrationFiles", "GetAllFiles")){
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = varLcMaxRecords;
if (datasetGetInvoiceFiles_maxRecords < 1) datasetGetInvoiceFiles_maxRecords = 1;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncDataActionGetAllFiles.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),varLcTableSort,cancellationToken);

// ListAppendAllInvoicesFiles
await ExtendedActions.ListAppendAll(requestContext,result.outParamDocumentExtrationFiles,(await RL_845dd74219b9b2e8e635abcbf851e5ff.ConvertAsync(localVars.queryResGetInvoiceFiles_outParamList, new RL_845dd74219b9b2e8e635abcbf851e5ff(), async (RC_6a167614a0071e1e1c2b280f79f64190 source, ST_27be19a2068bdbf4844f837df703a71bStructure target, CancellationToken cancellationToken) => {
target.ssFileName = source.ssENInvoiceFile.ssFilename;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedOn = BuiltInFunction.DateTimeToDate(source.ssENInvoiceFile.ssCreatedOn);
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetRequisitionFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFiles_maxRecords = 0;
int datasetGetRequisitionFiles_startIndex = 0;(localVars.queryResGetRequisitionFiles_outParamList,localVars.queryResGetRequisitionFiles_outParamCount) = await FuncDataActionGetAllFiles.datasetGetRequisitionFiles(requestContext,datasetGetRequisitionFiles_maxRecords,datasetGetRequisitionFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),varLcTableSort,cancellationToken);

// ListAppendAllRequisitionsFiles
await ExtendedActions.ListAppendAll(requestContext,result.outParamDocumentExtrationFiles,(await RL_845dd74219b9b2e8e635abcbf851e5ff.ConvertAsync(localVars.queryResGetRequisitionFiles_outParamList, new RL_845dd74219b9b2e8e635abcbf851e5ff(), async (RC_578a67dbd64153ec3fae13b76f75f54a source, ST_27be19a2068bdbf4844f837df703a71bStructure target, CancellationToken cancellationToken) => {
target.ssFileName = source.ssENRequisitionFile2.ssFilename;
target.ssStorageId = source.ssENRequisitionFile2.ssStorageId;
target.ssCreatedOn = BuiltInFunction.DateTimeToDate(source.ssENRequisitionFile2.ssCreatedOn);
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetFoliosFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosFiles_maxRecords = 0;
int datasetGetFoliosFiles_startIndex = 0;(localVars.queryResGetFoliosFiles_outParamList,localVars.queryResGetFoliosFiles_outParamCount) = await FuncDataActionGetAllFiles.datasetGetFoliosFiles(requestContext,datasetGetFoliosFiles_maxRecords,datasetGetFoliosFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),varLcTableSort,cancellationToken);

// ListAppendAllFolioFiles
await ExtendedActions.ListAppendAll(requestContext,result.outParamDocumentExtrationFiles,(await RL_845dd74219b9b2e8e635abcbf851e5ff.ConvertAsync(localVars.queryResGetFoliosFiles_outParamList, new RL_845dd74219b9b2e8e635abcbf851e5ff(), async (RC_c6c14818b27b1ae2048888ac314317c1 source, ST_27be19a2068bdbf4844f837df703a71bStructure target, CancellationToken cancellationToken) => {
target.ssFileName = source.ssENFolioFiles.ssFilename;
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
target.ssCreatedOn = BuiltInFunction.DateTimeToDate(source.ssENFolioFiles.ssCreatedOn);
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetOrderFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderFiles_maxRecords = 0;
int datasetGetOrderFiles_startIndex = 0;(localVars.queryResGetOrderFiles_outParamList,localVars.queryResGetOrderFiles_outParamCount) = await FuncDataActionGetAllFiles.datasetGetOrderFiles(requestContext,datasetGetOrderFiles_maxRecords,datasetGetOrderFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),varLcTableSort,cancellationToken);

// ListAppendAllOrderFiles
await ExtendedActions.ListAppendAll(requestContext,result.outParamDocumentExtrationFiles,(await RL_845dd74219b9b2e8e635abcbf851e5ff.ConvertAsync(localVars.queryResGetOrderFiles_outParamList, new RL_845dd74219b9b2e8e635abcbf851e5ff(), async (RC_2cd5474bded5833e5b006a17fe1ba636 source, ST_27be19a2068bdbf4844f837df703a71bStructure target, CancellationToken cancellationToken) => {
target.ssFileName = source.ssENOrderFile.ssFilename;
target.ssStorageId = source.ssENOrderFile.ssStorageId;
target.ssCreatedOn = BuiltInFunction.DateTimeToDate(source.ssENOrderFile.ssCreatedOn);
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

if(((varLcClickedCollum==""))) {
// DefaultSortCreatedOnDESC
await ExtendedActions.ListSort(requestContext,result.outParamDocumentExtrationFiles,async (p, cancellationToken) => p.ssCreatedOn,false,cancellationToken);

} else {
if(((varLcClickedCollum=="FileName"))) {
// ListSort2
await ExtendedActions.ListSort(requestContext,result.outParamDocumentExtrationFiles,async (p, cancellationToken) => p.ssFileName,true,cancellationToken);

}

if(((varLcClickedCollum=="CreatedOn"))) {
// ListSort
await ExtendedActions.ListSort(requestContext,result.outParamDocumentExtrationFiles,async (p, cancellationToken) => p.ssCreatedOn,true,cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamDocumentExtrationFiles = result.outParamDocumentExtrationFiles;
} // inner-finally
RETURN_STATEMENT:
return outParamDocumentExtrationFiles;
}


    public static class FuncDataActionGetAllFiles {

private static async Task<RC_6a167614a0071e1e1c2b280f79f64190> datasetGetInvoiceFilesReadDbAsync(RC_6a167614a0071e1e1c2b280f79f64190 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplier_2.Read( r, ref index);
rec.ssENSupplier_3.Read( r, ref index);
rec.ssRegionId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFolioInvoiceFileRequisitionOrderMainStorageSupplierSupplier_2Supplier_3RegionIdRecord.RegionId", 0L);
return rec;
}
// Query Function "GetInvoiceFiles" amIhCfglU0OsSs+9GPC1tQ of Action "GetAllFiles"
public static async Task<(RL_26f7eba5ac045368b1e866dc619ecc4d,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,long qpreRegionId,long qpreRegionId1,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetInvoiceFiles", "0921626a-25f8-4353-ac4a-cfbd18f0b5b5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetInvoiceFiles", "0921626a-25f8-4353-ac4a-cfbd18f0b5b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.2Z9RRJ3G7E6y45ebuePllw/DataActions.97QiolWnNESFlJup_R1yqQ/NodesNotShownInESpaceTree.amIhCfglU0OsSs+9GPC1tQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"eninvoicefile39\".\"filename\" o46, NULL o47, NULL o48, \"eninvoicefile39\".\"storageid\" o49, NULL o50, \"eninvoicefile39\".\"createdon\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, \"enstorage16\".\"size\" o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, NULL o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, NULL o233, NULL o234, NULL o235, NULL o236, NULL o237, NULL o238, NULL o239, NULL o240, NULL o241, NULL o242, (CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) \"regionid\"");
fromBuilder.Append(" FROM ((((((({InvoiceFile} \"eninvoicefile39\" Inner JOIN {Invoice} \"eninvoice109\" ON (\"eninvoicefile39\".\"invoiceid\" = \"eninvoice109\".\"id\"))  Left JOIN {Folio} \"enfolio68\" ON (\"eninvoice109\".\"folioid\" = \"enfolio68\".\"id\"))  Left JOIN ({OrderMain} \"enordermain83\" Inner JOIN {Supplier} \"ensupplier_2\" ON (\"enordermain83\".\"supplierid\" = \"ensupplier_2\".\"id\"))  ON (\"enfolio68\".\"orderid\" = \"enordermain83\".\"id\"))  Left JOIN {Requisition} \"enrequisition88\" ON (\"eninvoice109\".\"requisitionid\" = \"enrequisition88\".\"id\"))  Left JOIN {Supplier} \"ensupplier72\" ON (\"enfolio68\".\"supplierid\" = \"ensupplier72\".\"id\"))  Left JOIN {Supplier} \"ensupplier_3\" ON (\"enrequisition88\".\"supplierid\" = \"ensupplier_3\".\"id\"))  Inner JOIN {Storage} \"enstorage16\" ON (\"eninvoicefile39\".\"storageid\" = \"enstorage16\".\"id\")) ");
whereBuilder.Append(" WHERE (((((@qpreRegionId = @qpreRegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
if (qpreRegionId != 0) {
whereBuilder.Append("(((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) = @qpreRegionId1) AND ((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreRegionId1 != 0) {
whereBuilder.Append("(((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) = @qpreRegionId) AND ((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
} else {
whereBuilder.Append("((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) IS NULL)");
}
whereBuilder.Append(") OR ((CASE WHEN (\"ensupplier72\".\"id\" IS NOT NULL) THEN \"ensupplier72\".\"regionid\" ELSE (CASE WHEN (\"ensupplier_2\".\"id\" IS NOT NULL) THEN \"ensupplier_2\".\"regionid\" ELSE cast((CASE WHEN (\"ensupplier_3\".\"id\" IS NOT NULL) THEN \"ensupplier_3\".\"regionid\" ELSE cast((0) as bigint) END) as bigint) END) END) IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1)) AND (\"eninvoicefile39\".\"filename\" <> '')");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Folio", "InvoiceFile", "Storage", "Invoice", "Supplier_3", "Supplier_2", "Requisition", "OrderMain", "Supplier" }, new string[] { "ENFolio68", "ENInvoiceFile39", "ENStorage16", "ENInvoice109", "ENSupplier_3", "ENSupplier_2", "ENRequisition88", "ENOrderMain83", "ENSupplier72" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioEntity.AttributesToDatabaseNamesMap(), ENInvoiceFileEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_26f7eba5ac045368b1e866dc619ecc4d outParamList = new RL_26f7eba5ac045368b1e866dc619ecc4d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, false, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_26f7eba5ac045368b1e866dc619ecc4d _tmp = new RL_26f7eba5ac045368b1e866dc619ecc4d();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_26f7eba5ac045368b1e866dc619ecc4d)_tmp;
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

private static async Task<RC_578a67dbd64153ec3fae13b76f75f54a> datasetGetRequisitionFilesReadDbAsync(RC_578a67dbd64153ec3fae13b76f75f54a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionFiles" CVP9LInti0Kikx6S6aKFXA of Action "GetAllFiles"
public static async Task<(RL_cffe9dc584f94114622f35f97e0bde6b,long)> datasetGetRequisitionFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetRequisitionFiles", "2cfd5309-ed89-428b-a293-1e92e9a2855c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetRequisitionFiles", "2cfd5309-ed89-428b-a293-1e92e9a2855c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.2Z9RRJ3G7E6y45ebuePllw/DataActions.97QiolWnNESFlJup_R1yqQ/NodesNotShownInESpaceTree.CVP9LInti0Kikx6S6aKFXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionfile210\".\"filename\" o68, NULL o69, NULL o70, NULL o71, NULL o72, \"enrequisitionfile210\".\"createdon\" o73, \"enrequisitionfile210\".\"storageid\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, \"enstorage17\".\"size\" o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122");
fromBuilder.Append(" FROM (((({RequisitionFile2} \"enrequisitionfile210\" Inner JOIN {RequisitionContractFile} \"enrequisitioncontractfile13\" ON (\"enrequisitionfile210\".\"id\" = \"enrequisitioncontractfile13\".\"requisitionfileid\"))  Inner JOIN {Requisition} \"enrequisition89\" ON (\"enrequisitioncontractfile13\".\"requisitionid\" = \"enrequisition89\".\"id\"))  Left JOIN {Supplier} \"ensupplier73\" ON (\"enrequisition89\".\"supplierid\" = \"ensupplier73\".\"id\"))  Inner JOIN {Storage} \"enstorage17\" ON (\"enrequisitionfile210\".\"storageid\" = \"enstorage17\".\"id\")) ");
whereBuilder.Append(" WHERE (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier73\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier73\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier73\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier73\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier73\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier73\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier73\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1)) AND (\"enrequisitionfile210\".\"filename\" <> '')");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Supplier", "RequisitionFile2", "Requisition", "RequisitionContractFile", "Storage" }, new string[] { "ENSupplier73", "ENRequisitionFile210", "ENRequisition89", "ENRequisitionContractFile13", "ENStorage17" }, new System.Collections.Generic.Dictionary<string, string>[] { ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRequisitionFile2Entity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENRequisitionContractFileEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_cffe9dc584f94114622f35f97e0bde6b outParamList = new RL_cffe9dc584f94114622f35f97e0bde6b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetRequisitionFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cffe9dc584f94114622f35f97e0bde6b _tmp = new RL_cffe9dc584f94114622f35f97e0bde6b();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetRequisitionFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cffe9dc584f94114622f35f97e0bde6b)_tmp;
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

private static async Task<RC_2cd5474bded5833e5b006a17fe1ba636> datasetGetOrderFilesReadDbAsync(RC_2cd5474bded5833e5b006a17fe1ba636 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFiles" _kYqolz8ZEWsR0hWw54AhA of Action "GetAllFiles"
public static async Task<(RL_2ee5e32f7cbdd7ae81465087ec05e535,long)> datasetGetOrderFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetOrderFiles", "a22a46fe-fc5c-4564-ac47-4856c39e0084");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetOrderFiles", "a22a46fe-fc5c-4564-ac47-4856c39e0084", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.2Z9RRJ3G7E6y45ebuePllw/DataActions.97QiolWnNESFlJup_R1yqQ/NodesNotShownInESpaceTree._kYqolz8ZEWsR0hWw54AhA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enorderfile4\".\"filename\" o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enorderfile4\".\"createdon\" o20, \"enorderfile4\".\"storageid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, \"enstorage18\".\"size\" o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM (((({OrderFile} \"enorderfile4\" Inner JOIN {OrderContractFile} \"enordercontractfile4\" ON (\"enorderfile4\".\"id\" = \"enordercontractfile4\".\"orderfileid\"))  Inner JOIN {OrderMain} \"enordermain84\" ON (\"enordercontractfile4\".\"orderid\" = \"enordermain84\".\"id\"))  Inner JOIN {Supplier} \"ensupplier74\" ON (\"enordermain84\".\"supplierid\" = \"ensupplier74\".\"id\"))  Inner JOIN {Storage} \"enstorage18\" ON (\"enorderfile4\".\"storageid\" = \"enstorage18\".\"id\")) ");
whereBuilder.Append(" WHERE (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier74\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier74\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier74\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier74\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier74\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier74\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier74\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1)) AND (\"enorderfile4\".\"filename\" <> '')");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "OrderContractFile", "OrderFile", "OrderMain", "Supplier", "Storage" }, new string[] { "ENOrderContractFile4", "ENOrderFile4", "ENOrderMain84", "ENSupplier74", "ENStorage18" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderContractFileEntity.AttributesToDatabaseNamesMap(), ENOrderFileEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_2ee5e32f7cbdd7ae81465087ec05e535 outParamList = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetOrderFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2ee5e32f7cbdd7ae81465087ec05e535 _tmp = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetOrderFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2ee5e32f7cbdd7ae81465087ec05e535)_tmp;
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

private static async Task<RC_c6c14818b27b1ae2048888ac314317c1> datasetGetFoliosFilesReadDbAsync(RC_c6c14818b27b1ae2048888ac314317c1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFoliosFiles" klG3pQsP8kyexV4+32bWPw of Action "GetAllFiles"
public static async Task<(RL_e98bb88ed92fb603b0cfe20670483f89,long)> datasetGetFoliosFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetFoliosFiles", "a5b75192-0f0b-4cf2-9ec5-5e3edf66d63f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.wb_documentExtrationFiles.GetAllFiles.GetFoliosFiles", "a5b75192-0f0b-4cf2-9ec5-5e3edf66d63f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.2Z9RRJ3G7E6y45ebuePllw/DataActions.97QiolWnNESFlJup_R1yqQ/NodesNotShownInESpaceTree.klG3pQsP8kyexV4+32bWPw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfoliofiles5\".\"filename\" o21, NULL o22, NULL o23, \"enfoliofiles5\".\"storageid\" o24, NULL o25, \"enfoliofiles5\".\"createdon\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enstorage19\".\"size\" o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75");
fromBuilder.Append(" FROM ((({FolioFiles} \"enfoliofiles5\" Left JOIN {Folio} \"enfolio69\" ON (\"enfoliofiles5\".\"folioid\" = \"enfolio69\".\"id\"))  Left JOIN {Supplier} \"ensupplier75\" ON (\"enfolio69\".\"supplierid\" = \"ensupplier75\".\"id\"))  Inner JOIN {Storage} \"enstorage19\" ON (\"enfoliofiles5\".\"storageid\" = \"enstorage19\".\"id\")) ");
whereBuilder.Append(" WHERE (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier75\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier75\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier75\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier75\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier75\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier75\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier75\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1)) AND (\"enfoliofiles5\".\"filename\" <> '')");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Supplier", "Storage", "FolioFiles", "Folio" }, new string[] { "ENSupplier75", "ENStorage19", "ENFolioFiles5", "ENFolio69" }, new System.Collections.Generic.Dictionary<string, string>[] { ENSupplierEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap(), ENFolioFilesEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_e98bb88ed92fb603b0cfe20670483f89 outParamList = new RL_e98bb88ed92fb603b0cfe20670483f89();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, false, true, false, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetFoliosFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e98bb88ed92fb603b0cfe20670483f89 _tmp = new RL_e98bb88ed92fb603b0cfe20670483f89();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationFiles.GetAllFiles.GetFoliosFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e98bb88ed92fb603b0cfe20670483f89)_tmp;
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
