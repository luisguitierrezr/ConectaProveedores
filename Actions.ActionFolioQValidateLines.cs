namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioQValidateLines : VarsBag {
public RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 resListFilterXML_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public bool resRegex_SearchPDF_outParamFound = false;
public string resRegex_SearchPDF_outParamPatternResult = "";
public int resRegex_SearchPDF_outParamFirstIndex = 0;

public RL_ea38cd17f0e5d232db6162f29d44a023 queryResGetFolioItemsByOrderMainItemId_outParamList = new RL_ea38cd17f0e5d232db6162f29d44a023();
public long queryResGetFolioItemsByOrderMainItemId_outParamCount = 0L;

public RL_cbc3788d09399db0fa3c1bb25405f30f resListFilter_outParamFilteredList = new RL_cbc3788d09399db0fa3c1bb25405f30f();

public RL_cbc3788d09399db0fa3c1bb25405f30f queryResGetOrderMainItemsByPosition_outParamList = new RL_cbc3788d09399db0fa3c1bb25405f30f();
public long queryResGetOrderMainItemsByPosition_outParamCount = 0L;

public bool resRegex_SearchXML_outParamFound = false;
public string resRegex_SearchXML_outParamPatternResult = "";
public int resRegex_SearchXML_outParamFirstIndex = 0;

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilterFile_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public bool resRegex_Search_outParamFound = false;
public string resRegex_Search_outParamPatternResult = "";
public int resRegex_Search_outParamFirstIndex = 0;

public bool resRegex_SearchDate_outParamFound = false;
public string resRegex_SearchDate_outParamPatternResult = "";
public int resRegex_SearchDate_outParamFirstIndex = 0;

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilterPDF_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public RL_bab3397f952f07af0f0aa229e6f2b36e queryResGetOrdersItems_outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
public long queryResGetOrdersItems_outParamCount = 0L;

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUsers_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUsers_outParamCount = 0L;

public lcvFolioQValidateLines(RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList) {
this.inParamFolioQList = inParamFolioQList;
this.inParamFilesList = inParamFilesList;
}
}
public class lcoFolioQValidateLines : VarsBag {
public RL_f4ab0a048438c19ab1537693fa69f7c4 outParamFolioQListFinal = new RL_f4ab0a048438c19ab1537693fa69f7c4();

public lcoFolioQValidateLines() {
}
}
/// <summary>
/// Action <code>FolioQValidateLines</code> that represents the Service Studio action
///  <code>FolioQValidateLines</code> <p> Description: </p>
/// </summary>
public static async Task<RL_f4ab0a048438c19ab1537693fa69f7c4> ActionFolioQValidateLines(IRequestContext requestContext,RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,CancellationToken cancellationToken) {
RL_f4ab0a048438c19ab1537693fa69f7c4 outParamFolioQListFinal = default;
lcoFolioQValidateLines result = new lcoFolioQValidateLines();
lcvFolioQValidateLines localVars = new lcvFolioQValidateLines(inParamFolioQList, inParamFilesList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioQValidateLines", "aee44f7a-95b2-488d-adb5-f4906888bd09"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioQValidateLines", "aee44f7a-95b2-488d-adb5-f4906888bd09", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach FolioQList
localVars.inParamFolioQList.StartIteration();
try {while (!((localVars.inParamFolioQList.Eof))) {
// Query datasetGetOrderMainItemsByPosition
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByPosition_maxRecords = 1;
if (datasetGetOrderMainItemsByPosition_maxRecords < 1) datasetGetOrderMainItemsByPosition_maxRecords = 1;
int datasetGetOrderMainItemsByPosition_startIndex = 0;(localVars.queryResGetOrderMainItemsByPosition_outParamList,localVars.queryResGetOrderMainItemsByPosition_outParamCount) = await FuncActionFolioQValidateLines.datasetGetOrderMainItemsByPosition(requestContext,datasetGetOrderMainItemsByPosition_maxRecords,datasetGetOrderMainItemsByPosition_startIndex,IterationMultiplicity.Single,localVars.inParamFolioQList.CurrentRec.ssOrderNumber,localVars.inParamFolioQList.CurrentRec.ssPosition,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

// Query datasetGetFolioItemsByOrderMainItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByOrderMainItemId_maxRecords = 1;
if (datasetGetFolioItemsByOrderMainItemId_maxRecords < 1) datasetGetFolioItemsByOrderMainItemId_maxRecords = 1;
int datasetGetFolioItemsByOrderMainItemId_startIndex = 0;(localVars.queryResGetFolioItemsByOrderMainItemId_outParamList,localVars.queryResGetFolioItemsByOrderMainItemId_outParamCount) = await FuncActionFolioQValidateLines.datasetGetFolioItemsByOrderMainItemId(requestContext,datasetGetFolioItemsByOrderMainItemId_maxRecords,datasetGetFolioItemsByOrderMainItemId_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssId,cancellationToken);

// Empty?
if(((localVars.queryResGetOrderMainItemsByPosition_outParamList.Empty||localVars.queryResGetFolioItemsByOrderMainItemId_outParamList.Empty))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = "Number" + " " + FolioQList.Current.Number + " " + "is not available"
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((AppUtils.GetStringResource("qF1oExNSnUO4I1i9IX2C8Q#Value.-1950496919.1", "Number")+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("qF1oExNSnUO4I1i9IX2C8Q#Value.-981328570.1", "is not available"));
} else {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_cbc3788d09399db0fa3c1bb25405f30f)await  localVars.queryResGetOrderMainItemsByPosition_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssAssigmnentCode)!="Q"), cancellationToken)));

// Empty?
if((localVars.resListFilter_outParamFilteredList.Empty)) {
if(((!localVars.queryResGetOrderMainItemsByPosition_outParamList.Empty))) {
if(((localVars.inParamFolioQList.CurrentRec.ssInvoiceQuantity>localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + "Number" + " " + FolioQList.Current.Number + " " + "have more quantity then the available one"
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+AppUtils.GetStringResource("jwtHeFE3s0yuIiupdbGDVQ#Value.-1950496919.1", "Number"))+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("jwtHeFE3s0yuIiupdbGDVQ#Value.69968383.1", "have more quantity then the available one"));
}

// Query QueryGetOrdersItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems_maxRecords = 999999999;
if (QueryGetOrdersItems_maxRecords < 1) QueryGetOrdersItems_maxRecords = 1;
int QueryGetOrdersItems_startIndex = 0;(localVars.queryResGetOrdersItems_outParamList,localVars.queryResGetOrdersItems_outParamCount) = await FuncActionFolioQValidateLines.QueryGetOrdersItems(requestContext,QueryGetOrdersItems_maxRecords,QueryGetOrdersItems_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,cancellationToken);

if(((localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantityAvailable>=localVars.inParamFolioQList.CurrentRec.ssInvoiceQuantity))) {
// SetData
// FolioQList.Current.MaterialCode = GetOrderMainItemsByPosition.List.Current.OrderMainItem.MaterialCode
localVars.inParamFolioQList.CurrentRec.ssMaterialCode = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssMaterialCode;

// FolioQList.Current.MaterialDescription = GetOrderMainItemsByPosition.List.Current.OrderMainItem.MaterialDescription
localVars.inParamFolioQList.CurrentRec.ssMaterialDescription = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssMaterialDescription;

// FolioQList.Current.AssigmentCode = GetOrderMainItemsByPosition.List.Current.OrderMainItem.AssigmnentCode
localVars.inParamFolioQList.CurrentRec.ssAssigmentCode = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssAssigmnentCode;

// FolioQList.Current.UnitPrice = GetOrderMainItemsByPosition.List.Current.OrderMainItem.UnitPrice
localVars.inParamFolioQList.CurrentRec.ssUnitPrice = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice;

// FolioQList.Current.WaitingQuantity = GetOrdersItems.List.Current.FolioItem.QuantityAvailable - FolioQList.Current.InvoiceQuantity
localVars.inParamFolioQList.CurrentRec.ssWaitingQuantity = (localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantityAvailable-localVars.inParamFolioQList.CurrentRec.ssInvoiceQuantity);

// FolioQList.Current.Currency = GetOrderMainItemsByPosition.List.Current.Currency.Code
localVars.inParamFolioQList.CurrentRec.ssCurrency = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENCurrency.ssCode;

// FolioQList.Current.DeliveredQuantity = GetOrdersItems.List.Current.FolioItem.QuantityDelivered
localVars.inParamFolioQList.CurrentRec.ssDeliveredQuantity = (((int)localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantityDelivered));

// FolioQList.Current.AmountDelivered = GetOrdersItems.List.Current.FolioItem.ImportDelivered
localVars.inParamFolioQList.CurrentRec.ssAmountDelivered = localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssImportDelivered;

// FolioQList.Current.OrderMainItem = GetOrderMainItemsByPosition.List.Current.OrderMainItem.Id
localVars.inParamFolioQList.CurrentRec.ssOrderMainItem = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssId;

// FolioQList.Current.Quantity = GetOrderMainItemsByPosition.List.Current.OrderMainItem.Quantity
localVars.inParamFolioQList.CurrentRec.ssQuantity = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity;

// FolioQList.Current.BaseQuantity = GetOrderMainItemsByPosition.List.Current.OrderMainItem.BaseQuantity
localVars.inParamFolioQList.CurrentRec.ssBaseQuantity = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity;

// FolioQList.Current.VATRate = GetOrderMainItemsByPosition.List.Current.OrderMainItem.VATRate
localVars.inParamFolioQList.CurrentRec.ssVATRate = localVars.queryResGetOrderMainItemsByPosition_outParamList.CurrentRec.ssENOrderMainItem.ssVATRate;
if(((localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantityDelivered>=localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantity))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + "Number" + " " + FolioQList.Current.Number + " " + "is full delivered already"
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+AppUtils.GetStringResource("aErJo9K9GUa9+TlrWcdw4g#Value.-1950496919.1", "Number"))+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("aErJo9K9GUa9+TlrWcdw4g#Value.-2098899679.1", "is full delivered already"));
}

// ALIGN
// ALIGN
} else {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + "Number" + " " + FolioQList.Current.Number + " " + "have more quantity then the available one: " + " " + GetOrdersItems.List.Current.FolioItem.QuantityAvailable + ">" + FolioQList.Current.InvoiceQuantity
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+AppUtils.GetStringResource("PuQSy7pAM0S15K5KwsCb0A#Value.-1950496919.1", "Number"))+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("PuQSy7pAM0S15K5KwsCb0A#Value.-1479858843.1", "have more quantity then the available one: "))+" ")+BuiltInFunction.DecimalToText(localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTFolioItem.ssQuantityAvailable))+">")+BuiltInFunction.DecimalToText(localVars.inParamFolioQList.CurrentRec.ssInvoiceQuantity));
}

// ALIGN
} else {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = "Number" + " " + FolioQList.Current.Number + " " + "without inputation code Q."
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((AppUtils.GetStringResource("1P6knvRTGk6qdMVUwHmt6A#Value.-1950496919.1", "Number")+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("1P6knvRTGk6qdMVUwHmt6A#Value.1327125939.1", "without inputation code Q."));
}

// ALIGN
} else {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = "Number" + " " + FolioQList.Current.Number + " " + "is not available"
localVars.inParamFolioQList.CurrentRec.ssMessage = ((((AppUtils.GetStringResource("A52D0gZNfEGvz6Nz5vWQEw#Value.-1950496919.1", "Number")+" ")+Convert.ToString(localVars.inParamFolioQList.CurrentRec.ssNumber))+" ")+AppUtils.GetStringResource("A52D0gZNfEGvz6Nz5vWQEw#Value.-981328570.1", "is not available"));
}

// ALIGN
}

// ALIGN
// ALIGN
localVars.inParamFolioQList.Advance();
}

} finally {
localVars.inParamFolioQList.EndIteration();
}

// Foreach FolioQList
localVars.inParamFolioQList.StartIteration();
try {while (!((localVars.inParamFolioQList.Eof))) {
// Regex_SearchDate
(localVars.resRegex_SearchDate_outParamFound,localVars.resRegex_SearchDate_outParamPatternResult,localVars.resRegex_SearchDate_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamFolioQList.CurrentRec.ssDeliveryDate,"^(0[1-9]|[12][0-9]|3[01])\\/(0[1-9]|1[0-2])\\/\\d{4}$",true,false,false,cancellationToken);

if((!(localVars.resRegex_SearchDate_outParamFound))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Invalid date format, Should be DD/MM/AAAA"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("iQ2P6EkEQU6muaE4t7_PCg#Value.847285380.1", "Invalid date format, Should be DD/MM/AAAA"));
}

// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 1;
if (datasetGetUsers_maxRecords < 1) datasetGetUsers_maxRecords = 1;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncActionFolioQValidateLines.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Never,localVars.inParamFolioQList.CurrentRec.ssUserEmail,cancellationToken);

if((localVars.queryResGetUsers_outParamList.Empty)) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Email: " + " " + FolioQList.Current.UserEmail + " " + "doesn't not exists in the system."
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("+aUeT1RygEmWhUievtB0TA#Value.26637218.1", "Email: "))+" ")+localVars.inParamFolioQList.CurrentRec.ssUserEmail)+" ")+AppUtils.GetStringResource("+aUeT1RygEmWhUievtB0TA#Value.408829390.1", "doesn't not exists in the system."));
}

// Sitio Check
if(((BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssPlaceId)==""))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Id Sitio cannot be empty"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("RekXwnSnAUqYHcIHAI+rNQ#Value.-2074566964.1", "Id Sitio cannot be empty"));
}

// SitioName Check
if(((BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssPlaceName)==""))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Sitio Name cannot be empty"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("NjnIhS6YXk2WyFEKRSUYfQ#Value.1469239924.1", "Sitio Name cannot be empty"));
}

// PEP Check
if(((BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssPEP)==""))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "PEP cannot be empty"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("ukjJ1RxVwk6avqW3re9ycA#Value.1875623048.1", "PEP cannot be empty"));
}

// ALIGN
// ListFilterPDF
localVars.resListFilterPDF_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToLower (BuiltInFunction.Trim (p.ssName))==BuiltInFunction.ToLower (BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenamePdf))), cancellationToken)));

// ListFilterXML
localVars.resListFilterXML_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToLower (BuiltInFunction.Trim (p.ssName))==BuiltInFunction.ToLower (BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenameXml))), cancellationToken)));

// Empty?
if((localVars.resListFilterPDF_outParamFilteredList.Empty)) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "File with filename:" + " " + FolioQList.Current.FolioQFilesList.Current.Filename + " " + "was not uploaded"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("oodQsZQxJk6tFQHG3z6wPg#Value.617740093.1", "File with filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename)+" ")+AppUtils.GetStringResource("oodQsZQxJk6tFQHG3z6wPg#Value.-1568663324.1", "was not uploaded"));
}

// Empty?
if((localVars.resListFilterXML_outParamFilteredList.Empty)) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "File with filename:" + " " + FolioQList.Current.FolioQFilesList.Current.Filename + " " + "was not uploaded"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("zkaI88ooW0W3CdgLZLJmxQ#Value.617740093.1", "File with filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename)+" ")+AppUtils.GetStringResource("zkaI88ooW0W3CdgLZLJmxQ#Value.-1568663324.1", "was not uploaded"));
}

// FolioQList.Current.IsValidInvoiceFilenamePdf = ListFilterPDF.FilteredList.Length = 1
localVars.inParamFolioQList.CurrentRec.ssIsValidInvoiceFilenamePdf = (localVars.resListFilterPDF_outParamFilteredList.Length==1);

// FolioQList.Current.IsValidInvoiceFilenameXml = ListFilterXML.FilteredList.Length = 1
localVars.inParamFolioQList.CurrentRec.ssIsValidInvoiceFilenameXml = (localVars.resListFilterXML_outParamFilteredList.Length==1);
// Regex_SearchPDF
(localVars.resRegex_SearchPDF_outParamFound,localVars.resRegex_SearchPDF_outParamPatternResult,localVars.resRegex_SearchPDF_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenamePdf,"^.+\\.[^.]+$",true,false,false,cancellationToken);

// Regex_SearchXML
(localVars.resRegex_SearchXML_outParamFound,localVars.resRegex_SearchXML_outParamPatternResult,localVars.resRegex_SearchXML_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenameXml,"^.+\\.[^.]+$",true,false,false,cancellationToken);

if((!(localVars.resRegex_SearchPDF_outParamFound))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Filename:" + " " + FolioQList.Current.InvoiceFilenamePdf + " " + "doen't have extension"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("znNfI1pLmkeCUJHRMnchSg#Value.700976883.1", "Filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenamePdf)+" ")+AppUtils.GetStringResource("znNfI1pLmkeCUJHRMnchSg#Value.-2118019354.1", "doen't have extension"));
}

if((!(localVars.resRegex_SearchXML_outParamFound))) {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Filename:" + " " + FolioQList.Current.InvoiceFilenameXml + " " + "doen't have extension"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("fOgPHqhfTkmmIyVz0cXbIw#Value.700976883.1", "Filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenameXml)+" ")+AppUtils.GetStringResource("fOgPHqhfTkmmIyVz0cXbIw#Value.-2118019354.1", "doen't have extension"));
}

// FolioQList.Current.IsValidInvoiceFilenamePdf = ListFilterPDF.FilteredList.Length = 1
localVars.inParamFolioQList.CurrentRec.ssIsValidInvoiceFilenamePdf = (localVars.resListFilterPDF_outParamFilteredList.Length==1);

// FolioQList.Current.IsValidInvoiceFilenameXml = ListFilterXML.FilteredList.Length = 1
localVars.inParamFolioQList.CurrentRec.ssIsValidInvoiceFilenameXml = (localVars.resListFilterXML_outParamFilteredList.Length==1);
// Foreach FolioQList.Current.FolioQFilesList
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.StartIteration();
try {while (!((localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.Eof))) {
// Regex_Search
(localVars.resRegex_Search_outParamFound,localVars.resRegex_Search_outParamPatternResult,localVars.resRegex_Search_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename,"^.+\\.[^.]+$",true,false,false,cancellationToken);

if((localVars.resRegex_Search_outParamFound)) {
// ListFilterFile
localVars.resListFilterFile_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToLower (BuiltInFunction.Trim (p.ssName))==BuiltInFunction.ToLower (BuiltInFunction.Trim (localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename))), cancellationToken)));

// Exists?
if(((localVars.resListFilterFile_outParamFilteredList.Length==1))) {
// SetfileName
// FolioQList.Current.FolioQFilesList.Current.BinaryFilename = ListFilterFile.FilteredList.Current.Name
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssBinaryFilename = localVars.resListFilterFile_outParamFilteredList.CurrentRec.ssName;

// FolioQList.Current.FolioQFilesList.Current.FileExists = True
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFileExists = true;

// FolioQList.Current.FolioQFilesList.Current.IsExtra = True
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssIsExtra = true;
// ALIGN
} else {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "File with filename:" + " " + FolioQList.Current.FolioQFilesList.Current.Filename + " " + "was not uploaded"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("ryxosyCiKkKvUcaSIgIdFQ#Value.617740093.1", "File with filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename)+" ")+AppUtils.GetStringResource("ryxosyCiKkKvUcaSIgIdFQ#Value.-1568663324.1", "was not uploaded"));
}

// ALIGN
} else {
// ERROR
// FolioQList.Current.WithError = True
localVars.inParamFolioQList.CurrentRec.ssWithError = true;

// FolioQList.Current.Message = If + " " + "Filename:" + " " + FolioQList.Current.FolioQFilesList.Current.Filename + " " + "doen't have extension"
localVars.inParamFolioQList.CurrentRec.ssMessage = (((((((((localVars.inParamFolioQList.CurrentRec.ssMessage=="")) ? (localVars.inParamFolioQList.CurrentRec.ssMessage) : ((localVars.inParamFolioQList.CurrentRec.ssMessage+"\r\n")))+" ")+AppUtils.GetStringResource("pxFAXIyRP0iA4IcbQwDTzg#Value.700976883.1", "Filename:"))+" ")+localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename)+" ")+AppUtils.GetStringResource("pxFAXIyRP0iA4IcbQwDTzg#Value.-2118019354.1", "doen't have extension"));
}

// ALIGN
// ALIGN
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.Advance();
}

} finally {
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.EndIteration();
}

localVars.inParamFolioQList.Advance();
}

} finally {
localVars.inParamFolioQList.EndIteration();
}

// FolioQListFinal = FolioQList
result.outParamFolioQListFinal=localVars.inParamFolioQList;
} //close CreateActionActivity using block
} // try

finally {
outParamFolioQListFinal = result.outParamFolioQListFinal;
} // inner-finally
RETURN_STATEMENT:
return outParamFolioQListFinal;
}

public static class FuncActionFolioQValidateLines {

private static async Task<RC_d158748ead56eba288746615205b9a8e> datasetGetFolioItemsByOrderMainItemIdReadDbAsync(RC_d158748ead56eba288746615205b9a8e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssInvoiceQttSum = r.ReadDecimal(index++, "InvoiceQttSumTotalPriceSumRecord.InvoiceQttSum", 0.0M);
rec.ssTotalPriceSum = r.ReadCurrency(index++, "InvoiceQttSumTotalPriceSumRecord.TotalPriceSum", 0.0M);
return rec;
}
// Query Function "GetFolioItemsByOrderMainItemId" hcUWLVV_ZUC5RZJfu4s3CQ of Action "FolioQValidateLines"
public static async Task<(RL_ea38cd17f0e5d232db6162f29d44a023,long)> datasetGetFolioItemsByOrderMainItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporFolioItems_OrderMainItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioQValidateLines.GetFolioItemsByOrderMainItemId", "2d16c585-7f55-4065-b945-925fbb8b3709");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioQValidateLines.GetFolioItemsByOrderMainItemId", "2d16c585-7f55-4065-b945-925fbb8b3709", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ek_krrKVjUittfSQaIi9CQ/NodesNotShownInESpaceTree.hcUWLVV_ZUC5RZJfu4s3CQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems5\".\"invoiceqtt\") \"invoiceqttsum\", Sum(\"enfolioitems5\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({FolioItems} \"enfolioitems5\" Left JOIN {Folio} \"enfolio42\" ON (\"enfolioitems5\".\"folioid\" = \"enfolio42\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolioItems_OrderMainItemId != 0) {
whereBuilder.Append("((\"enfolioitems5\".\"ordermainitemid\" = @qporFolioItems_OrderMainItemId) AND (\"enfolioitems5\".\"ordermainitemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolioItems_OrderMainItemId", DbType.Int64, qporFolioItems_OrderMainItemId);
} else {
whereBuilder.Append("(\"enfolioitems5\".\"ordermainitemid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolio42\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
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
RL_ea38cd17f0e5d232db6162f29d44a023 outParamList = new RL_ea38cd17f0e5d232db6162f29d44a023();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainItemIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioQValidateLines.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ea38cd17f0e5d232db6162f29d44a023 _tmp = new RL_ea38cd17f0e5d232db6162f29d44a023();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainItemIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioQValidateLines.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ea38cd17f0e5d232db6162f29d44a023)_tmp;
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

private static async Task<RC_f8f8f0b7fba136e61b433a9935152136> datasetGetOrderMainItemsByPositionReadDbAsync(RC_f8f8f0b7fba136e61b433a9935152136 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByPosition" Yc2hVDiMb0mK9VKKvffmTg of Action "FolioQValidateLines"
public static async Task<(RL_cbc3788d09399db0fa3c1bb25405f30f,long)> datasetGetOrderMainItemsByPosition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderMain_OrderNumber,int qpinOrderMainItem_Position,long qpsuOrderMain_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioQValidateLines.GetOrderMainItemsByPosition", "54a1cd61-8c38-496f-8af5-528abdf7e64e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioQValidateLines.GetOrderMainItemsByPosition", "54a1cd61-8c38-496f-8af5-528abdf7e64e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ek_krrKVjUittfSQaIi9CQ/NodesNotShownInESpaceTree.Yc2hVDiMb0mK9VKKvffmTg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency3\".\"code\" o0, \"encurrency3\".\"name\" o1, \"encurrency3\".\"symbol\" o2, \"encurrency3\".\"minorunitdecimals\" o3, \"encurrency3\".\"isactive\" o4, \"enordermain45\".\"id\" o5, \"enordermain45\".\"ordernumber\" o6, \"enordermain45\".\"orderdate\" o7, \"enordermain45\".\"orderstatusid\" o8, \"enordermain45\".\"previousorderstatusid\" o9, \"enordermain45\".\"assignmentcode\" o10, \"enordermain45\".\"supplierid\" o11, \"enordermain45\".\"companyid\" o12, \"enordermain45\".\"documenttypeid\" o13, \"enordermain45\".\"currencyid\" o14, \"enordermain45\".\"telceldirectionid\" o15, \"enordermain45\".\"procurementgroup\" o16, \"enordermain45\".\"creatorsapnumber\" o17, \"enordermain45\".\"creatorsapname\" o18, \"enordermain45\".\"country\" o19, \"enordermain45\".\"isdeleted\" o20, \"enordermain45\".\"isreleased\" o21, trim_scale(\"enordermain45\".\"exchangerate\"::numeric) o22, \"enordermain45\".\"sustainabilitycategory\" o23, \"enordermain45\".\"sustainabilitysubcategory\" o24, trim_scale(\"enordermain45\".\"totalamount\"::numeric) o25, \"enordermain45\".\"fromcosmoz\" o26, \"enordermain45\".\"regionid\" o27, \"enordermain45\".\"divisionid\" o28, \"enordermain45\".\"applicant\" o29, \"enordermain45\".\"createdby\" o30, \"enordermain45\".\"createdon\" o31, \"enordermain45\".\"updatedby\" o32, \"enordermain45\".\"updatedon\" o33, \"enordermainitem7\".\"id\" o34, \"enordermainitem7\".\"ordermainid\" o35, \"enordermainitem7\".\"position\" o36, \"enordermainitem7\".\"materialcode\" o37, \"enordermainitem7\".\"materialdescription\" o38, \"enordermainitem7\".\"assigmnentcode\" o39, \"enordermainitem7\".\"documentclassid\" o40, \"enordermainitem7\".\"deliverydate\" o41, trim_scale(\"enordermainitem7\".\"quantity\"::numeric) o42, \"enordermainitem7\".\"unittype\" o43, trim_scale(\"enordermainitem7\".\"unitprice\"::numeric) o44, \"enordermainitem7\".\"basequantity\" o45, \"enordermainitem7\".\"isdeleted\" o46, \"enordermainitem7\".\"isblocked\" o47, \"enordermainitem7\".\"isfinaldelivery\" o48, \"enordermainitem7\".\"glaccountid\" o49, \"enordermainitem7\".\"costcenterid\" o50, \"enordermainitem7\".\"fundscenter\" o51, \"enordermainitem7\".\"fund\" o52, \"enordermainitem7\".\"commitmentitem\" o53, \"enordermainitem7\".\"vatindicator\" o54, \"enordermainitem7\".\"vatprocedure\" o55, trim_scale(\"enordermainitem7\".\"vatrate\"::numeric) o56, \"enordermainitem7\".\"purchaserequisitionnumber\" o57, \"enordermainitem7\".\"purchaserequisitionitemnr\" o58, \"enordermainitem7\".\"regionid\" o59, \"enordermainitem7\".\"center\" o60, \"enordermainitem7\".\"pepelement\" o61, trim_scale(\"enordermainitem7\".\"quantitydelivered\"::numeric) o62, \"enordermainitem7\".\"orderunitofmeasure\" o63, \"enordermainitem7\".\"applicant\" o64, \"enordermainitem7\".\"direction\" o65, \"enordermainitem7\".\"contractnumber\" o66, \"enordermainitem7\".\"contractposition\" o67, \"enordermainitem7\".\"contractstartdate\" o68, \"enordermainitem7\".\"contractenddate\" o69, trim_scale(\"enordermainitem7\".\"contractplannedvalue\"::numeric) o70, \"enordermainitem7\".\"positiontype\" o71, \"enordermainitem7\".\"serialnumberprofile\" o72, \"enordermainitem7\".\"batchmanaged\" o73, \"enordermainitem7\".\"materialtype\" o74, \"enordermainitem7\".\"itemgroup\" o75, \"enordermainitem7\".\"orderrequestcreatorsapnumber\" o76, \"enordermainitem7\".\"ismultipleimputation\" o77, \"enordermainitem7\".\"invoiceusageid\" o78, \"enordermainitem7\".\"ordermainitemstatusid\" o79, \"enordermainitem7\".\"divisionid\" o80, \"enordermainitem7\".\"createdby\" o81, \"enordermainitem7\".\"createdon\" o82, \"enordermainitem7\".\"updatedby\" o83, \"enordermainitem7\".\"updatedon\" o84");
fromBuilder.Append(" FROM (({OrderMainItem} \"enordermainitem7\" Left JOIN {OrderMain} \"enordermain45\" ON (\"enordermainitem7\".\"ordermainid\" = \"enordermain45\".\"id\"))  Left JOIN {Currency} \"encurrency3\" ON (\"enordermain45\".\"currencyid\" = \"encurrency3\".\"code\")) ");
whereBuilder.Append(" WHERE (\"enordermain45\".\"ordernumber\" = @qpteOrderMain_OrderNumber) AND (\"enordermainitem7\".\"position\" = @qpinOrderMainItem_Position) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_OrderNumber", DbType.String, qpteOrderMain_OrderNumber);
sqlCmd.CreateParameterWithoutReplacements("@qpinOrderMainItem_Position", DbType.Int32, qpinOrderMainItem_Position);
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain45\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain45\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain45\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enordermain45\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId);
whereBuilder.Append(") OR (\"enordermain45\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("+y0n+52Y0kWtv1lCSYVl5g"))).ssId);
whereBuilder.Append(")) OR (\"enordermain45\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append("))");
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
RL_cbc3788d09399db0fa3c1bb25405f30f outParamList = new RL_cbc3788d09399db0fa3c1bb25405f30f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByPositionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioQValidateLines.GetOrderMainItemsByPosition.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cbc3788d09399db0fa3c1bb25405f30f _tmp = new RL_cbc3788d09399db0fa3c1bb25405f30f();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByPositionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioQValidateLines.GetOrderMainItemsByPosition.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cbc3788d09399db0fa3c1bb25405f30f)_tmp;
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

// Query Function "GetOrdersItems" 4S9o9Pau+0G_iZNqbdwz6w of Action "FolioQValidateLines"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderMainItemId,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("FolioQValidateLines.GetOrdersItems", "f4682fe1-aef6-41fb-bf89-936a6ddc33eb");
using var queryActivity = activitySource.CreateSqlQueryActivity("FolioQValidateLines.GetOrdersItems", "f4682fe1-aef6-41fb-bf89-936a6ddc33eb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qporl_OrderMainItemId", DbType.Int64, qporl_OrderMainItemId);
string sql = "";
string advSql = "SELECT  \n    0, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0) + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n    ), 0) as QtdDelivered, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " - ( \n        COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled  \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        ), 0)  +  COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n        ), 0) \n    ) AS QttAvailable, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + "* " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + " \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " = @qporl_OrderMainItemId \n    and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \n    and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0 \n    order by  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " asc";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bab3397f952f07af0f0aa229e6f2b36e outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioQValidateLines.GetOrdersItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bab3397f952f07af0f0aa229e6f2b36e _tmp = new RL_bab3397f952f07af0f0aa229e6f2b36e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioQValidateLines.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in FolioQValidateLines in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))          FROM {OrderItemEntries}          WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0) as QtdDelivered,        {OrderMa ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in FolioQValidateLines in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))          FROM {OrderItemEntries}          WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0) as QtdDelivered,        {OrderMa ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in FolioQValidateLines in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))          FROM {OrderItemEntries}          WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0) as QtdDelivered,        {OrderMa ...): " + aqExcep.Message));
}
}
}

// Query Function "GetUsers" WshN9mYkZ0GCciOiV4u2xw of Action "FolioQValidateLines"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpemEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioQValidateLines.GetUsers", "f64dc85a-2466-4167-8272-23a2578bb6c7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioQValidateLines.GetUsers", "f64dc85a-2466-4167-8272-23a2578bb6c7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ek_krrKVjUittfSQaIi9CQ/NodesNotShownInESpaceTree.WshN9mYkZ0GCciOiV4u2xw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser98\"");
whereBuilder.Append(" WHERE (\"enuser98\".\"email\" = (trim(@qpemEmail)))");
orderByBuilder.Append(" ORDER BY \"enuser98\".\"name\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpemEmail", DbType.String, qpemEmail);
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioQValidateLines.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioQValidateLines.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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
