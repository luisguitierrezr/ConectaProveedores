namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioQMassUpload : VarsBag {
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
/// <summary>
/// Variable <code>FolioQFilesAux</code> that represents the Service Studio FolioQFilesList
///  <code>FolioQFilesAux</code> <p>Description: </p>
/// </summary>
public RL_d6af4e3a9c01393365c1248e2444fa63 varLcFolioQFilesAux = new RL_d6af4e3a9c01393365c1248e2444fa63();

public RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 resExcelToRecordList_outParamOut = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 resListFilterAttachments_outParamFilteredList = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();

public RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 resListDuplicate_outParamDuplicatedList = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();

public bool resListAny_outParamResult = false;

public Actions.lcoFolioQValidateLines resFolioQValidateLines =  new Actions.lcoFolioQValidateLines();
public ST_cbb2055cf19f871ed882642269bd43ceStructure resCall_ZMXMIMMF_VISUALIZAR_SAL_ANT_outParamResponse = new ST_cbb2055cf19f871ed882642269bd43ceStructure();

public RL_f4ab0a048438c19ab1537693fa69f7c4 resCountErrors_outParamFilteredList = new RL_f4ab0a048438c19ab1537693fa69f7c4();

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMains_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMains_outParamCount = 0L;

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilterExcel_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public lcvFolioQMassUpload(RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList) {
this.inParamFilesList = inParamFilesList;
}
}
public class lcoFolioQMassUpload : VarsBag {
public RL_f4ab0a048438c19ab1537693fa69f7c4 outParamFolioQList = new RL_f4ab0a048438c19ab1537693fa69f7c4();

public int outParamNumberOfRecords = 0;

public int outParamNumberOfErros = 0;

public long outParamOrderNumber = 0L;

public string outParamErrorMsg = "";

public lcoFolioQMassUpload() {
}
}
/// <summary>
/// Action <code>FolioQMassUpload</code> that represents the Service Studio action
///  <code>FolioQMassUpload</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_f4ab0a048438c19ab1537693fa69f7c4,int,int,long,string)> ActionFolioQMassUpload(IRequestContext requestContext,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,CancellationToken cancellationToken) {
RL_f4ab0a048438c19ab1537693fa69f7c4 outParamFolioQList = default;
int outParamNumberOfRecords = default;
int outParamNumberOfErros = default;
long outParamOrderNumber = default;
string outParamErrorMsg = default;
lcoFolioQMassUpload result = new lcoFolioQMassUpload();
lcvFolioQMassUpload localVars = new lcvFolioQMassUpload(inParamFilesList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioQMassUpload", "4a3abb9c-b012-4c99-8ff2-ea86db3f42ec"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioQMassUpload", "4a3abb9c-b012-4c99-8ff2-ea86db3f42ec", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListFilterExcel
localVars.resListFilterExcel_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssName), ".xlsx", 0, false, false)!=(-1)), cancellationToken)));

// Find the Excel xlsx file?
if(((localVars.resListFilterExcel_outParamFilteredList.Length!=1))) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException ((((localVars.resListFilterExcel_outParamFilteredList.Length==0)) ? (AppUtils.GetStringResource("gPNaZnM3GkijKy1rvs4IiQ#Message.1743478300.1", "It was not possible to find the xlsx file")) : (AppUtils.GetStringResource("gPNaZnM3GkijKy1rvs4IiQ#Message.-403265375.1", "It was not possible to find the xlsx file, upload only one"))));

} else {
// ExcelToRecordList ExcelToRLFolioQMassUploadExcelToRecordList
FuncActionFolioQMassUpload.ExcelToRLFolioQMassUploadExcelToRecordList(requestContext,localVars.resListFilterExcel_outParamFilteredList.CurrentRec.ssBinaryData,"",out localVars.resExcelToRecordList_outParamOut);
// ListDuplicate
localVars.resListDuplicate_outParamDuplicatedList = (((RL_15a59605b8f7d8d15b1b6b6cad6ee0c8) localVars.resExcelToRecordList_outParamOut.Duplicate()));

// Foreach ExcelToRecordList
localVars.resExcelToRecordList_outParamOut.StartIteration();
try {while (!((localVars.resExcelToRecordList_outParamOut.Eof))) {
// ListAny
localVars.resListAny_outParamResult = await ExtendedActions.ListAny(requestContext,result.outParamFolioQList,async (p, cancellationToken) => (Convert.ToString(p.ssNumber)==localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssNumber),cancellationToken);

if((!(localVars.resListAny_outParamResult))) {
// ListClearAUX
await ExtendedActions.ListClear(requestContext,localVars.varLcFolioQFilesAux,cancellationToken);

// ListFilterAttachments
localVars.resListFilterAttachments_outParamFilteredList = (((RL_15a59605b8f7d8d15b1b6b6cad6ee0c8)await  localVars.resListDuplicate_outParamDuplicatedList.FilterAsync(async (p, cancellationToken) => (p.ssSTFolioQImport.ssNumber==localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssNumber), cancellationToken)));

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcFolioQFilesAux,(await RL_d6af4e3a9c01393365c1248e2444fa63.ConvertAsync(localVars.resListFilterAttachments_outParamFilteredList, new RL_d6af4e3a9c01393365c1248e2444fa63(), async (RC_11133d573140bca413fb3e86df694e32 source, ST_b9bc0a93e29018653085b5de5dd1951eStructure target, CancellationToken cancellationToken) => {
target.ssFilename = source.ssSTFolioQImport.ssAttachments;
target.ssIsExtra = true;
return target;
}, cancellationToken)),cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamFolioQList,(await RecordUtils.ConvertAsync(localVars.resExcelToRecordList_outParamOut.CurrentRec, new ST_118fe20454dd0bf1f0e6d925e7d7544bStructure(), async (RC_11133d573140bca413fb3e86df694e32 source, ST_118fe20454dd0bf1f0e6d925e7d7544bStructure target, CancellationToken cancellationToken) => {
target.ssNumber = BuiltInFunction.TextToInteger (localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssNumber);
target.ssOrderNumber = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssOrder;
target.ssPosition = BuiltInFunction.TextToInteger (localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssPositions);
target.ssDeliveryDate = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssDelivery_date;
target.ssInvoiceQuantity = BuiltInFunction.TextToDecimal (localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssInvoiceDelivery);
target.ssUserEmail = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssUser;
target.ssInvoiceFilenamePdf = source.ssSTFolioQImport.ssInvoice_pdf;
target.ssInvoiceFilenameXml = source.ssSTFolioQImport.ssInvoice_xml;
target.ssPEP = source.ssSTFolioQImport.ssPep;
target.ssPlaceId = source.ssSTFolioQImport.ssSite_id;
target.ssPlaceName = source.ssSTFolioQImport.ssSite_name;
target.ssFolioQFilesList = localVars.varLcFolioQFilesAux;
target.ssWithError = false;
target.ssMessage = "";
return target;
}, cancellationToken)),cancellationToken);

}

// ALIGN
localVars.resExcelToRecordList_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList_outParamOut.EndIteration();
}

// Query datasetGetOrderMains
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMains_maxRecords = 0;
int datasetGetOrderMains_startIndex = 0;(localVars.queryResGetOrderMains_outParamList,localVars.queryResGetOrderMains_outParamCount) = await FuncActionFolioQMassUpload.datasetGetOrderMains(requestContext,datasetGetOrderMains_maxRecords,datasetGetOrderMains_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTFolioQImport.ssOrder,cancellationToken);

// Set Order
// OrderNumber = GetOrderMains.List.Current.OrderMain.Id
result.outParamOrderNumber=localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderMain.ssId;
// Call_ZMXMIMMF_VISUALIZAR_SAL_ANT
localVars.resCall_ZMXMIMMF_VISUALIZAR_SAL_ANT_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(requestContext,new ST_f68ab54e767928bb7cc21e9801e8642bStructure(){ ssPI_PEDIDO = localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber },cancellationToken);

// has credit
if(((localVars.resCall_ZMXMIMMF_VISUALIZAR_SAL_ANT_outParamResponse.ssPO_IMP_ANT>(((decimal)0))))) {
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "VISUALIZAR_SALDO_ANTICIPO", ssDescription = ((BuiltInFunction.DecimalToText(localVars.resCall_ZMXMIMMF_VISUALIZAR_SAL_ANT_outParamResponse.ssPO_IMP_ANT)+" > 0 para el pedido ")+localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = BuiltInFunction.NullIdentifier () },cancellationToken);

// ErrorMsg = "This order had anticipo credit that requires amortization. Please use single folio creation for this."
result.outParamErrorMsg=AppUtils.GetStringResource("Qv3rzERTNU+t6Etzp3_Awg#Value.1471261497.1", "This order had anticipo credit that requires amortization. Please use single folio creation for this.");
} else {
// FolioQValidateLines
localVars.resFolioQValidateLines.outParamFolioQListFinal = await Actions.ActionFolioQValidateLines(requestContext,result.outParamFolioQList,localVars.inParamFilesList,cancellationToken);

// CountErrors
localVars.resCountErrors_outParamFilteredList = (((RL_f4ab0a048438c19ab1537693fa69f7c4)await  localVars.resFolioQValidateLines.outParamFolioQListFinal.FilterAsync(async (p, cancellationToken) => p.ssWithError, cancellationToken)));

// FolioQList = FolioQValidateLines.FolioQListFinal
result.outParamFolioQList=localVars.resFolioQValidateLines.outParamFolioQListFinal;

// NumberOfRecords = ExcelToRecordList.Length
result.outParamNumberOfRecords=localVars.resExcelToRecordList_outParamOut.Length;

// NumberOfErros = CountErrors.FilteredList.Length
result.outParamNumberOfErros=localVars.resCountErrors_outParamFilteredList.Length;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamFolioQList = result.outParamFolioQList;
outParamNumberOfRecords = result.outParamNumberOfRecords;
outParamNumberOfErros = result.outParamNumberOfErros;
outParamOrderNumber = result.outParamOrderNumber;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamFolioQList,outParamNumberOfRecords,outParamNumberOfErros,outParamOrderNumber,outParamErrorMsg);
}

public static class FuncActionFolioQMassUpload {

// Query Function "GetOrderMains" EmdYxFTK10a3d59U+JZiJA of Action "FolioQMassUpload"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMains(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioQMassUpload.GetOrderMains", "c4586712-ca54-46d7-b777-9f54f8966224");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioQMassUpload.GetOrderMains", "c4586712-ca54-46d7-b777-9f54f8966224", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nLs6ShKwmUyP8uqG2z9C7A/NodesNotShownInESpaceTree.EmdYxFTK10a3d59U+JZiJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain21\".\"id\" o0, \"enordermain21\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain21\"");
whereBuilder.Append(" WHERE (\"enordermain21\".\"ordernumber\" = (trim(@qpteOrderNumber)))");
orderByBuilder.Append(" ORDER BY \"enordermain21\".\"ordernumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioQMassUpload.GetOrderMains.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioQMassUpload.GetOrderMains.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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


/// <summary>
/// Excel To RecordList: ExcelToRLFolioQMassUploadExcelToRecordList (KOwxrDZQ_0kC3L8GSz3ToeA) of Action
///  "FolioQMassUpload"
/// </summary>
public static void ExcelToRLFolioQMassUploadExcelToRecordList(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 outParamOut) {

if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
var service = ServiceLocator.GetService<ISpreadsheetService>();
var reader = service.GetReader(
    excelContent, 
    tableName, 
    new Type[] {
        typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string)
    },
    new string[] {
        "Number", 
"Order", 
"Attachments", 
"Positions", 
"Delivery_date", 
"InvoiceDelivery", 
"User", 
"Invoice_pdf", 
"Invoice_xml", 
"Pep", 
"Site_id", 
"Site_name"
    },
    new string[] {
        "Number", 
"Order", 
"Attachments", 
"Positions", 
"Delivery date", 
"Invoice Delivery", 
"User", 
"Invoice pdf", 
"Invoice xml", 
"Pep", 
"Site", 
"Site name"
    },
    new string[] {
        "Number", 
"Order", 
"Attachments", 
"Positions", 
"Delivery_date", 
"InvoiceDelivery", 
"User", 
"Invoice_pdf", 
"Invoice_xml", 
"Pep", 
"Site_id", 
"Site_name"
    },
    new string[] {
        "Number", 
"Order", 
"Attachments", 
"Positions", 
"Delivery date", 
"Invoice Delivery", 
"User", 
"Invoice pdf", 
"Invoice xml", 
"Pep", 
"Site", 
"Site name"
    });

RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 tmp = new();
tmp.Reader = reader;

outParamOut = (RL_15a59605b8f7d8d15b1b6b6cad6ee0c8)tmp.Duplicate();
}


}


}
