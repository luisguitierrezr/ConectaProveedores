namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML09_UUID : VarsBag {
public long inParamInvoiceId;
public object inParamXMLDocument;
/// <summary>
/// Variable <code>XMLNode</code> that represents the Service Studio Object <code>XMLNode</code>
///  <p>Description: </p>
/// </summary>
public object varLcXMLNode = null;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate13 =  new Actions.lcoLogsAccountingCreate();
public string resGetUUID_outParamAttributeValue = "";

public RL_1f9a243d40703326d9bf7c63586316cd queryResGetInvoiceExtendedsByUUID_outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
public long queryResGetInvoiceExtendedsByUUID_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public object resSelectSingleNode_Complemento_outParamXMLNode = null;

public object resSelectSingleNode_TimbreFiscalDigital_outParamXMLNode = null;

public lcvXML09_UUID(long inParamInvoiceId, object inParamXMLDocument) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamXMLDocument = inParamXMLDocument;
}
}
public class lcoXML09_UUID : VarsBag {
public string outParamUUID = "";

public string outParamErrorMsg = "";

public lcoXML09_UUID() {
}
}
/// <summary>
/// Action <code>XML09_UUID</code> that represents the Service Studio action <code>XML09_UUID</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(string,string)> ActionXML09_UUID(IRequestContext requestContext,long inParamInvoiceId,object inParamXMLDocument,CancellationToken cancellationToken) {
string outParamUUID = default;
string outParamErrorMsg = default;
lcoXML09_UUID result = new lcoXML09_UUID();
lcvXML09_UUID localVars = new lcvXML09_UUID(inParamInvoiceId, inParamXMLDocument);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML09_UUID", "ed659f42-2509-4053-bd19-c69975d2d2f3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML09_UUID", "ed659f42-2509-4053-bd19-c69975d2d2f3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Complemento
localVars.resSelectSingleNode_Complemento_outParamXMLNode = await Actions.ActionXMLDocument_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Complemento']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Complemento_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_TimbreFiscalDigital
localVars.resSelectSingleNode_TimbreFiscalDigital_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Complemento_outParamXMLNode,"//*[local-name()='TimbreFiscalDigital']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_TimbreFiscalDigital_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// XMLNode = SelectSingleNode_TimbreFiscalDigital.XMLNode
localVars.varLcXMLNode=localVars.resSelectSingleNode_TimbreFiscalDigital_outParamXMLNode;
// GetUUID
localVars.resGetUUID_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"UUID",cancellationToken);

// UUID = GetUUID.AttributeValue
result.outParamUUID=localVars.resGetUUID_outParamAttributeValue;
// empty?
if(((localVars.resGetUUID_outParamAttributeValue==""))) {
// ErrorMsg = "Invalid UUID"
result.outParamErrorMsg=AppUtils.GetStringResource("4Pw2dpXS1kutSYLKvqft2w#Value.632414308.1", "Invalid UUID");
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Invalid UUID", ssDescription = (localVars.resGetUUID_outParamAttributeValue+" = vacio"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// skip validate uuid
if((!((!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_UUID]))))))) {
// Query datasetGetInvoiceExtendedsByUUID
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedsByUUID_maxRecords = 1;
if (datasetGetInvoiceExtendedsByUUID_maxRecords < 1) datasetGetInvoiceExtendedsByUUID_maxRecords = 1;
int datasetGetInvoiceExtendedsByUUID_startIndex = 0;(localVars.queryResGetInvoiceExtendedsByUUID_outParamList,localVars.queryResGetInvoiceExtendedsByUUID_outParamCount) = await FuncActionXML09_UUID.datasetGetInvoiceExtendedsByUUID(requestContext,datasetGetInvoiceExtendedsByUUID_maxRecords,datasetGetInvoiceExtendedsByUUID_startIndex,IterationMultiplicity.Never,localVars.resGetUUID_outParamAttributeValue,localVars.inParamInvoiceId,cancellationToken);

// not empty?
if(((!localVars.queryResGetInvoiceExtendedsByUUID_outParamList.Empty))) {
// ErrorMsg = "Duplicated UUID."
result.outParamErrorMsg=AppUtils.GetStringResource("lyn8sr8ZvkyUb9K4goD0EQ#Value.-927987252.1", "Duplicated UUID.");
// LogsXMLValidationCreate13
localVars.resLogsXMLValidationCreate13.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Invalid UUID", ssDescription = ((localVars.resGetUUID_outParamAttributeValue+" duplicado. Invoice ")+localVars.queryResGetInvoiceExtendedsByUUID_outParamList.CurrentRec.ssENInvoice.ssName), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamUUID = result.outParamUUID;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamUUID,outParamErrorMsg);
}

public static class FuncActionXML09_UUID {

private static async Task<RC_b6257dfb536e679f8b7be7b4b56f189b> datasetGetInvoiceExtendedsByUUIDReadDbAsync(RC_b6257dfb536e679f8b7be7b4b56f189b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceExtendedsByUUID" IAfYlBjVTkGMzieu4kqbSQ of Action "XML09_UUID"
public static async Task<(RL_1f9a243d40703326d9bf7c63586316cd,long)> datasetGetInvoiceExtendedsByUUID(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteInvoiceExtended_UUID,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("XML09_UUID.GetInvoiceExtendedsByUUID", "94d80720-d518-414e-8cce-27aee24a9b49");
using var queryActivity = activitySource.CreateAggregateQueryActivity("XML09_UUID.GetInvoiceExtendedsByUUID", "94d80720-d518-414e-8cce-27aee24a9b49", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Qp9l7QklU0C9GcaZddLS8w/NodesNotShownInESpaceTree.IAfYlBjVTkGMzieu4kqbSQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice72\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM ({InvoiceExtended} \"eninvoiceextended18\" Inner JOIN {Invoice} \"eninvoice72\" ON (\"eninvoiceextended18\".\"id\" = \"eninvoice72\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoiceextended18\".\"uuid\" = @qpteInvoiceExtended_UUID) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceExtended_UUID", DbType.String, qpteInvoiceExtended_UUID);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice72\".\"id\" <> @qpinInvoice_Id) OR (\"eninvoice72\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice72\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND (\"eninvoice72\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append(")");
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
RL_1f9a243d40703326d9bf7c63586316cd outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceExtendedsByUUIDReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query XML09_UUID.GetInvoiceExtendedsByUUID.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f9a243d40703326d9bf7c63586316cd _tmp = new RL_1f9a243d40703326d9bf7c63586316cd();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceExtendedsByUUIDReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query XML09_UUID.GetInvoiceExtendedsByUUID.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f9a243d40703326d9bf7c63586316cd)_tmp;
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
