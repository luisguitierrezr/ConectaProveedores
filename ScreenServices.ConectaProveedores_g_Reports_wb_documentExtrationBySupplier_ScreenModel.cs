using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel).Namespace);

    public long varLcSupplierId;
public string varLcKeyword;
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


    public ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel() {
}



    public ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel(long varLcSupplierId, string varLcKeyword, DateTime varLcDateStart, DateTime varLcDateEnd, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, long varLcStorageId, bool varLcIsSelectOne, DateTime varLcForceRefresh, AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073> ScreenDataSetGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"SupplierId", "Keyword", "DateStart", "DateEnd", "TableSort", "StartIndex", "MaxRecords", "StorageId", "IsSelectOne", "ForceRefresh", "GetInvoiceFiles", "ClientVars"}, new string[] {"varLcSupplierId", "varLcKeyword", "varLcDateStart", "varLcDateEnd", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcStorageId", "varLcIsSelectOne", "varLcForceRefresh", "ScreenDataSetGetInvoiceFiles", "clientVariables"});
this.varLcSupplierId = varLcSupplierId;
this.varLcKeyword = varLcKeyword;
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
// Query Function "GetInvoiceFiles" lteGfHmqUki_ZVa+lhOIkA of Action "wb_documentExtrationBySupplier"
public static async Task<(RL_9cdf1789e965682ff9f78e76a5697073,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,int qpinOffsetUtc,DateTime qpdaDateEnd,DateTime qpdaDateStart,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,string qpteKeyword,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,long qpsuSupplier_Id,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles", "7c86d796-aa79-4852-bf65-56be96138890");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_documentExtrationBySupplier","g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles");
// Query Iterations: Multiple
// Refresh Query eQSEW5N1U0WmT3_HxFm53w Iterations: Multiple
// Refresh Query PIjPxIqwQU6MYR4dWS59KA Iterations: Multiple
// Refresh Query bzOuyCFl10eT2lcOcVOmEQ Iterations: Multiple
// Refresh Query OaNY62eTu0Wa3ZLkvHClZg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.DrhD79G8UUmDZC7zDukKCg/ScreenDataSets.lteGfHmqUki_ZVa+lhOIkA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice114\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice114\".\"totalamount\"::numeric) o6, \"eninvoice114\".\"currency\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting26\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"eninvoiceextended27\".\"uuid\" o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, \"eninvoicefile43\".\"storageid\" o69, NULL o70, \"eninvoicefile43\".\"createdon\" o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition93\".\"name\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, \"enstorage23\".\"id\" o143, NULL o144, NULL o145, NULL o146, \"enstorage23\".\"filename\" o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, \"enstorage23\".\"size\" o161, NULL o162, NULL o163, NULL o164, \"ensupplier80\".\"name\" o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, 0 \"select\"");
fromBuilder.Append(" FROM ((((((({InvoiceFile} \"eninvoicefile43\" Inner JOIN {Invoice} \"eninvoice114\" ON (\"eninvoicefile43\".\"invoiceid\" = \"eninvoice114\".\"id\"))  Inner JOIN {Requisition} \"enrequisition93\" ON (\"eninvoice114\".\"requisitionid\" = \"enrequisition93\".\"id\"))  Inner JOIN {Supplier} \"ensupplier80\" ON (\"enrequisition93\".\"supplierid\" = \"ensupplier80\".\"id\"))  Inner JOIN {Storage} \"enstorage23\" ON (\"eninvoicefile43\".\"storageid\" = \"enstorage23\".\"id\"))  Inner JOIN {Region} \"enregion106\" ON (\"ensupplier80\".\"regionid\" = \"enregion106\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended27\" ON (\"eninvoice114\".\"id\" = \"eninvoiceextended27\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting26\" ON (\"eninvoice114\".\"id\" = \"eninvoiceaccounting26\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ((");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier80\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier80\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier80\".\"id\" IS NULL)");
}
whereBuilder.Append(" OR ((caseaccent_normalize(\"ensupplier80\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")) AND (@qpteKeyword <> ''))) OR ((caseaccent_normalize(\"ensupplier80\".\"number\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")) AND (@qpteKeyword <> ''))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
if (qpdaDateStart != BuiltInFunction.NullDate()) {
whereBuilder.Append("(((\"eninvoicefile43\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) >= @qpdaNewDateTime) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime1);
}
if (qpdaDateEnd != BuiltInFunction.NullDate()) {
whereBuilder.Append("(((\"eninvoicefile43\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) <= @qpdaNewDateTime1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime);
}
whereBuilder.Append("(((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier80\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier80\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier80\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier80\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier80\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier80\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier80\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "InvoiceFile", "InvoiceExtended", "Invoice", "Storage", "Region", "Supplier", "InvoiceAccounting", "Requisition" }, new string[] { "ENInvoiceFile43", "ENInvoiceExtended27", "ENInvoice114", "ENStorage23", "ENRegion106", "ENSupplier80", "ENInvoiceAccounting26", "ENRequisition93" }, new System.Collections.Generic.Dictionary<string, string>[] { ENInvoiceFileEntity.AttributesToDatabaseNamesMap(), ENInvoiceExtendedEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoicefile43\".\"createdon\" DESC ");
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
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9cdf1789e965682ff9f78e76a5697073)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.wb_documentExtrationBySupplier.GetInvoiceFiles.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
