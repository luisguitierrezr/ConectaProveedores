using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_ScreenModel).Namespace);

    public DateTime varLcDateStart;
public DateTime varLcDateEnd;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public long varLcStorageId;
public bool varLcIsSelectOne;
public DateTime varLcForceRefresh;
public AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073> ScreenDataSetGetInvoiceFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_ScreenModel() {
}



    public ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_ScreenModel(DateTime varLcDateStart, DateTime varLcDateEnd, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, long varLcStorageId, bool varLcIsSelectOne, DateTime varLcForceRefresh, AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073> ScreenDataSetGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"DateStart", "DateEnd", "TableSort", "StartIndex", "MaxRecords", "StorageId", "IsSelectOne", "ForceRefresh", "GetInvoiceFiles", "ClientVars"}, new string[] {"varLcDateStart", "varLcDateEnd", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcStorageId", "varLcIsSelectOne", "varLcForceRefresh", "ScreenDataSetGetInvoiceFiles", "clientVariables"});
this.varLcDateStart = varLcDateStart;
this.varLcDateEnd = varLcDateEnd;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcStorageId = varLcStorageId;
this.varLcIsSelectOne = varLcIsSelectOne;
this.varLcForceRefresh = varLcForceRefresh;
this.ScreenDataSetGetInvoiceFiles = ScreenDataSetGetInvoiceFiles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cfb4b5cbc9f75e782e7f32736dbeac24> datasetGetInvoiceFilesReadDbAsync(RC_cfb4b5cbc9f75e782e7f32736dbeac24 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssSelect = r.ReadBoolean(index++, "InvoiceInvoiceFileRequisitionInvoiceAccountingInvoiceExtendedSelectStorageSupplierRegionRecord.Select", false);
return rec;
}
// Query Function "GetInvoiceFiles" BPxR69JPQ0CuYNm0htzUAQ of Action "wb_documentExtrationByDatesRange"
public static async Task<(RL_9cdf1789e965682ff9f78e76a5697073,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,int qpinOffsetUtc,DateTime qpdaDateEnd,DateTime qpdaDateStart,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles", "eb51fc04-4fd2-4043-ae60-d9b486dcd401");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_documentExtrationByDatesRange","g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles");
// Query Iterations: Multiple
// Refresh Query +lxOcN+dqEGlD4wIsy292A Iterations: Multiple
// Refresh Query 9GPJkUuxO0WDY1smeX82DA Iterations: Multiple
// Refresh Query 8GvwitkDj0WMhUGdHTpH2g Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.RVOAVc1a6U6kNWfKqcRR5Q/ScreenDataSets.BPxR69JPQ0CuYNm0htzUAQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice110\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice110\".\"totalamount\"::numeric) o6, \"eninvoice110\".\"currency\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting23\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"eninvoiceextended24\".\"uuid\" o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, \"eninvoicefile40\".\"storageid\" o69, NULL o70, \"eninvoicefile40\".\"createdon\" o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition90\".\"name\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, \"enstorage20\".\"id\" o143, NULL o144, NULL o145, NULL o146, \"enstorage20\".\"filename\" o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, \"enstorage20\".\"size\" o161, NULL o162, NULL o163, NULL o164, \"ensupplier76\".\"name\" o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, 0 \"select\"");
fromBuilder.Append(" FROM ((((((({InvoiceFile} \"eninvoicefile40\" Inner JOIN {Invoice} \"eninvoice110\" ON (\"eninvoicefile40\".\"invoiceid\" = \"eninvoice110\".\"id\"))  Inner JOIN {Requisition} \"enrequisition90\" ON (\"eninvoice110\".\"requisitionid\" = \"enrequisition90\".\"id\"))  Inner JOIN {Supplier} \"ensupplier76\" ON (\"enrequisition90\".\"supplierid\" = \"ensupplier76\".\"id\"))  Inner JOIN {Storage} \"enstorage20\" ON (\"eninvoicefile40\".\"storageid\" = \"enstorage20\".\"id\"))  Inner JOIN {Region} \"enregion100\" ON (\"ensupplier76\".\"regionid\" = \"enregion100\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended24\" ON (\"eninvoice110\".\"id\" = \"eninvoiceextended24\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting23\" ON (\"eninvoice110\".\"id\" = \"eninvoiceaccounting23\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ((@qpdaDateStart <> (date '1900-01-01')) AND (((\"eninvoicefile40\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) >= @qpdaNewDateTime)) AND ((@qpdaDateEnd <> (date '1900-01-01')) AND (((\"eninvoicefile40\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) <= @qpdaNewDateTime1)) AND (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaDateStart", DbType.DateTime, qpdaDateStart);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaDateStart", DbType.DateTime, qpdaDateStart);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime1);
sqlCmd.CreateParameterWithoutReplacements("@qpdaDateEnd", DbType.DateTime, qpdaDateEnd);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaDateEnd", DbType.DateTime, qpdaDateEnd);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier76\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier76\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier76\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier76\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier76\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier76\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier76\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Supplier", "Invoice", "InvoiceExtended", "InvoiceAccounting", "InvoiceFile", "Storage", "Requisition", "Region" }, new string[] { "ENSupplier76", "ENInvoice110", "ENInvoiceExtended24", "ENInvoiceAccounting23", "ENInvoiceFile40", "ENStorage20", "ENRequisition90", "ENRegion100" }, new System.Collections.Generic.Dictionary<string, string>[] { ENSupplierEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceExtendedEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENInvoiceFileEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoicefile40\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_9cdf1789e965682ff9f78e76a5697073 outParamList = new RL_9cdf1789e965682ff9f78e76a5697073();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, false});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[5] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9cdf1789e965682ff9f78e76a5697073 _tmp = new RL_9cdf1789e965682ff9f78e76a5697073();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9cdf1789e965682ff9f78e76a5697073)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.wb_documentExtrationByDatesRange.GetInvoiceFiles.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
