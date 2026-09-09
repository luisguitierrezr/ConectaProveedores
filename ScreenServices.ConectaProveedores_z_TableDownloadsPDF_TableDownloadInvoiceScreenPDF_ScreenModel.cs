using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel).Namespace);

    public string inParamStringListIds;
public string inParamStringListLevelIds;
public RLTextList varLcInvoiceIdsList;
public RLTextList varLcInvoiceLevelIdsList;
public ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model varLcGetInvoices;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel() {
}



    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel(string inParamStringListIds, string inParamStringListLevelIds, RLTextList varLcInvoiceIdsList, RLTextList varLcInvoiceLevelIdsList, ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model varLcGetInvoices, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StringListIds", "StringListLevelIds", "InvoiceIdsList", "InvoiceLevelIdsList", "GetInvoices", "ClientVars"}, new string[] {"inParamStringListIds", "inParamStringListLevelIds", "varLcInvoiceIdsList", "varLcInvoiceLevelIdsList", "varLcGetInvoices", "clientVariables"});
this.inParamStringListIds = inParamStringListIds;
this.inParamStringListLevelIds = inParamStringListLevelIds;
this.varLcInvoiceIdsList = varLcInvoiceIdsList;
this.varLcInvoiceLevelIdsList = varLcInvoiceLevelIdsList;
this.varLcGetInvoices = varLcGetInvoices;
this.clientVariables = clientVariables;
}



    

    public class lcvGetInvoices : VarsBag {
public RL_d801fe1ea71112ff0b6aae5532582323 queryResGetInvoicesStructure_outParamList = new RL_d801fe1ea71112ff0b6aae5532582323();
public long queryResGetInvoicesStructure_outParamCount = 0L;

public lcvGetInvoices() {
}
}
public class lcoGetInvoices : VarsBag {
public RL_77750b395266828bf78fae563dd1fc3f outParamList = new RL_77750b395266828bf78fae563dd1fc3f();

public lcoGetInvoices() {
}
}
/// <summary>
/// Action <code>GetInvoices</code> that represents the Service Studio action <code>GetInvoices</code>
///  <p> Description: </p>
/// </summary>
public async Task<RL_77750b395266828bf78fae563dd1fc3f> DataActionGetInvoices(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_77750b395266828bf78fae563dd1fc3f outParamList = default;
lcoGetInvoices result = new lcoGetInvoices();
lcvGetInvoices localVars = new lcvGetInvoices();
ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoices", "8bb026ea-0747-4daa-be30-c3c620b10f9b"))
using (activitySource.CreateScreenDataActionActivity("TableDownloadInvoiceScreenPDF", "GetInvoices")){
// Foreach InvoiceIdsList
varLcInvoiceIdsList.StartIteration();
try {while (!((varLcInvoiceIdsList.Eof))) {
// Query datasetGetInvoicesStructure
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesStructure_maxRecords = 0;
int datasetGetInvoicesStructure_startIndex = 0;(localVars.queryResGetInvoicesStructure_outParamList,localVars.queryResGetInvoicesStructure_outParamCount) = await FuncDataActionGetInvoices.datasetGetInvoicesStructure(requestContext,datasetGetInvoicesStructure_maxRecords,datasetGetInvoicesStructure_startIndex,IterationMultiplicity.Never,varLcInvoiceIdsList.CurrentRec.ssValue,varLcInvoiceLevelIdsList[varLcInvoiceIdsList.CurrentRowNumber].ssValue,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamList,(await RecordUtils.ConvertAsync(localVars.queryResGetInvoicesStructure_outParamList.CurrentRec, new ST_3c6142d371d14231f5ddee7b64c28681Structure(), async (RC_a5a625e8d3ab33c9963e296857124373 source, ST_3c6142d371d14231f5ddee7b64c28681Structure target, CancellationToken cancellationToken) => {
target.ssInvoiceId = source.ssENInvoice.ssId;
target.ssInvoiceApprovalLevelId = source.ssENInvoiceApprovalLevel.ssId;
target.ssInvoiceName = source.ssENInvoice.ssName;
target.ssInvoiceStatus = source.ssENInvoiceStatus.ssLabelES;
target.ssRequisitionName = source.ssENRequisition.ssName;
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssSupplierNumber = source.ssENSupplier.ssNumber;
target.ssTotalAmount = BuiltInFunction.FormatCurrency (source.ssENInvoice.ssTotalAmount, "", 2, ".", ",");
target.ssUploadDate = BuiltInFunction.FormatDateTime (source.ssENInvoice.ssCreatedOn, "dd/MM/yyyy");
target.ssAssignedTo = source.ssENUser.ssName;
target.ssAction = source.ssENApprovalStatus.ssLabelES;
return target;
}, cancellationToken)),cancellationToken);

varLcInvoiceIdsList.Advance();
}

} finally {
varLcInvoiceIdsList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetInvoices {

private static async Task<RC_a5a625e8d3ab33c9963e296857124373> datasetGetInvoicesStructureReadDbAsync(RC_a5a625e8d3ab33c9963e296857124373 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesStructure" 6+YYBCzQBE+lcf7SttvzdQ of Action "GetInvoices"
public static async Task<(RL_d801fe1ea71112ff0b6aae5532582323,long)> datasetGetInvoicesStructure(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteInvoice_Id,string qpteInvoiceApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.GetInvoices.GetInvoicesStructure", "0418e6eb-d02c-4f04-a571-fed2b6dbf375");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.GetInvoices.GetInvoicesStructure", "0418e6eb-d02c-4f04-a571-fed2b6dbf375", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.NLyH7ZO9+kGcoI6wAHzRFw/DataActions.6iawi0cHqk2+MMPGILEPmw/NodesNotShownInESpaceTree.6+YYBCzQBE+lcf7SttvzdQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus23\".\"labeles\" o9, \"eninvoice136\".\"id\" o10, \"eninvoice136\".\"name\" o11, NULL o12, NULL o13, NULL o14, NULL o15, trim_scale(\"eninvoice136\".\"totalamount\"::numeric) o16, NULL o17, NULL o18, NULL o19, NULL o20, \"eninvoice136\".\"createdon\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"eninvoiceapprovallevel41\".\"id\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, \"eninvoicestatus17\".\"labeles\" o75, NULL o76, \"enrequisition118\".\"name\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"ensupplier116\".\"name\" o136, \"ensupplier116\".\"number\" o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, \"enuser193\".\"name\" o163, NULL o164, NULL o165, NULL o166");
fromBuilder.Append(" FROM ((((((({Invoice} \"eninvoice136\" Left JOIN {InvoiceApproval} \"eninvoiceapproval43\" ON (\"eninvoice136\".\"id\" = \"eninvoiceapproval43\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel41\" ON ((\"eninvoiceapprovallevel41\".\"invoiceapprovalid\" = \"eninvoiceapproval43\".\"id\") AND (\"eninvoiceapprovallevel41\".\"id\" = cast(((coalesce(cast(nullif(@qpteInvoiceApprovalLevel_Id,'') as integer), 0))) as bigint))))  Left JOIN {InvoiceStatus} \"eninvoicestatus17\" ON (\"eninvoice136\".\"invoicestatusid\" = \"eninvoicestatus17\".\"id\"))  Inner JOIN {Requisition} \"enrequisition118\" ON (\"eninvoice136\".\"requisitionid\" = \"enrequisition118\".\"id\"))  Left JOIN {Supplier} \"ensupplier116\" ON (\"enrequisition118\".\"supplierid\" = \"ensupplier116\".\"id\"))  Left JOIN {User} \"enuser193\" ON (\"eninvoiceapprovallevel41\".\"assignedto\" = \"enuser193\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus23\" ON (\"eninvoiceapprovallevel41\".\"approvalstatusid\" = \"enapprovalstatus23\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice136\".\"id\" = cast(((coalesce(cast(nullif(@qpteInvoice_Id,'') as integer), 0))) as bigint))");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceApprovalLevel_Id", DbType.String, qpteInvoiceApprovalLevel_Id);
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_Id", DbType.String, qpteInvoice_Id);
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
RL_d801fe1ea71112ff0b6aae5532582323 outParamList = new RL_d801fe1ea71112ff0b6aae5532582323();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesStructureReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.GetInvoices.GetInvoicesStructure.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d801fe1ea71112ff0b6aae5532582323 _tmp = new RL_d801fe1ea71112ff0b6aae5532582323();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesStructureReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.GetInvoices.GetInvoicesStructure.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d801fe1ea71112ff0b6aae5532582323)_tmp;
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
