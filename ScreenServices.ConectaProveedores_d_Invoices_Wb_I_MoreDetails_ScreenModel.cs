using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel).Namespace);

    public long inParamInvoiceId;
public string varLcTableSort;
public AggregateRecord<RL_2e7f130f9df070446bc2a9ac7dcde539> ScreenDataSetLatestInvoiceComment;
public AggregateRecord<RL_555a5d0da2fe2f0e71754918f879d5c3> ScreenDataSetMoreDetails;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel(long inParamInvoiceId, string varLcTableSort, AggregateRecord<RL_2e7f130f9df070446bc2a9ac7dcde539> ScreenDataSetLatestInvoiceComment, AggregateRecord<RL_555a5d0da2fe2f0e71754918f879d5c3> ScreenDataSetMoreDetails, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "TableSort", "LatestInvoiceComment", "MoreDetails", "ClientVars"}, new string[] {"inParamInvoiceId", "varLcTableSort", "ScreenDataSetLatestInvoiceComment", "ScreenDataSetMoreDetails", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.varLcTableSort = varLcTableSort;
this.ScreenDataSetLatestInvoiceComment = ScreenDataSetLatestInvoiceComment;
this.ScreenDataSetMoreDetails = ScreenDataSetMoreDetails;
this.clientVariables = clientVariables;
}



    
// Query Function "LatestInvoiceComment" 1YfSPINd1EOd59Hwm+aPGA of Action "Wb_I_MoreDetails"
public static async Task<(RL_2e7f130f9df070446bc2a9ac7dcde539,long)> datasetLatestInvoiceComment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_I_MoreDetails.LatestInvoiceComment", "3cd287d5-5d83-43d4-9de7-d1f09be68f18");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_I_MoreDetails","d_Invoices.Wb_I_MoreDetails.LatestInvoiceComment");
// Query Iterations: Never
// Refresh Query P+Ha+TS+eUWEKORqXIPkOg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.4qSl8T8neEezsFS_5hFv+w/ScreenDataSets.1YfSPINd1EOd59Hwm+aPGA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"eninvoicecomment2\".\"message\" o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceComment} \"eninvoicecomment2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicecomment2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicecomment2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicecomment2\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicecomment2\".\"createdon\" DESC ");
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
RL_2e7f130f9df070446bc2a9ac7dcde539 outParamList = new RL_2e7f130f9df070446bc2a9ac7dcde539();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_I_MoreDetails.LatestInvoiceComment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2e7f130f9df070446bc2a9ac7dcde539 _tmp = new RL_2e7f130f9df070446bc2a9ac7dcde539();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_I_MoreDetails.LatestInvoiceComment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2e7f130f9df070446bc2a9ac7dcde539)_tmp;
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

private static async Task<RC_b64650646295f01a3e7c46ac44009d3c> datasetMoreDetailsReadDbAsync(RC_b64650646295f01a3e7c46ac44009d3c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBusinessValueCategory.Read( r, ref index);
rec.ssENBusinessValueSubcategory.Read( r, ref index);
rec.ssENDistribution.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceExtendedTax.Read( r, ref index);
rec.ssENInvoiceTaxType.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "MoreDetails" g7CZbqDR3UarZ5ppXK+T4Q of Action "Wb_I_MoreDetails"
public static async Task<(RL_555a5d0da2fe2f0e71754918f879d5c3,long)> datasetMoreDetails(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_I_MoreDetails.MoreDetails", "6e99b083-d1a0-46dd-ab67-9a695caf93e1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_I_MoreDetails","d_Invoices.Wb_I_MoreDetails.MoreDetails");
// Query Iterations: Never
// Refresh Query bvHGoFIfSka_YEmcdS09vw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.4qSl8T8neEezsFS_5hFv+w/ScreenDataSets.g7CZbqDR3UarZ5ppXK+T4Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbusinessvaluecategory1\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enbusinessvaluesubcategory1\".\"description\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"endistribution1\".\"label\" o14, NULL o15, NULL o16, NULL o17, \"enfrequency4\".\"label\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"eninvoice130\".\"paymentdatetime\" o31, \"eninvoice130\".\"createdon\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, \"eninvoiceextended34\".\"serie\" o48, \"eninvoiceextended34\".\"fechaemision\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"eninvoicetaxtype\".\"label\" o73, NULL o74, NULL o75, NULL o76, \"enproject_asset_service10\".\"description\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140");
fromBuilder.Append(" FROM ((((((((({Invoice} \"eninvoice130\" Left JOIN {InvoiceExtended} \"eninvoiceextended34\" ON (\"eninvoice130\".\"id\" = \"eninvoiceextended34\".\"id\"))  Inner JOIN {InvoiceExtendedTax} \"eninvoiceextendedtax12\" ON (\"eninvoice130\".\"id\" = \"eninvoiceextendedtax12\".\"invoiceid\"))  Inner JOIN {InvoiceTaxType} \"eninvoicetaxtype\" ON (\"eninvoiceextendedtax12\".\"invoicetaxtypeid\" = \"eninvoicetaxtype\".\"id\"))  Left JOIN {Requisition} \"enrequisition105\" ON (\"eninvoice130\".\"requisitionid\" = \"enrequisition105\".\"id\"))  Left JOIN {Frequency} \"enfrequency4\" ON (\"enrequisition105\".\"frequencyid\" = \"enfrequency4\".\"id\"))  Left JOIN {Distribution} \"endistribution1\" ON (\"enrequisition105\".\"distributionid\" = \"endistribution1\".\"id\"))  Left JOIN {BusinessValueCategory} \"enbusinessvaluecategory1\" ON (\"enrequisition105\".\"businessvaluecategoryid\" = \"enbusinessvaluecategory1\".\"id\"))  Left JOIN {BusinessValueSubcategory} \"enbusinessvaluesubcategory1\" ON (\"enrequisition105\".\"businessvaluesubcategoryid\" = \"enbusinessvaluesubcategory1\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service10\" ON (\"enrequisition105\".\"projectassetserviceid\" = \"enproject_asset_service10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice130\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice130\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice130\".\"id\" IS NULL)");
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Distribution", "Requisition", "InvoiceExtended", "Project_Asset_Service", "Invoice", "BusinessValueSubcategory", "BusinessValueCategory", "Frequency", "InvoiceTaxType", "InvoiceExtendedTax" }, new string[] { "ENDistribution1", "ENRequisition105", "ENInvoiceExtended34", "ENProject_Asset_Service10", "ENInvoice130", "ENBusinessValueSubcategory1", "ENBusinessValueCategory1", "ENFrequency4", "ENInvoiceTaxType", "ENInvoiceExtendedTax12" }, new System.Collections.Generic.Dictionary<string, string>[] { ENDistributionEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENInvoiceExtendedEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENBusinessValueSubcategoryEntity.AttributesToDatabaseNamesMap(), ENBusinessValueCategoryEntity.AttributesToDatabaseNamesMap(), ENFrequencyEntity.AttributesToDatabaseNamesMap(), ENInvoiceTaxTypeEntity.AttributesToDatabaseNamesMap(), ENInvoiceExtendedTaxEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_555a5d0da2fe2f0e71754918f879d5c3 outParamList = new RL_555a5d0da2fe2f0e71754918f879d5c3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetMoreDetailsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true});
opt[6] = new BitArray(new bool[] {true, false, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_I_MoreDetails.MoreDetails.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_555a5d0da2fe2f0e71754918f879d5c3 _tmp = new RL_555a5d0da2fe2f0e71754918f879d5c3();
_tmp.AlternateReadDbMethodAsync = datasetMoreDetailsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_I_MoreDetails.MoreDetails.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_555a5d0da2fe2f0e71754918f879d5c3)_tmp;
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
