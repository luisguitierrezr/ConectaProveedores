namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioMassCreate : VarsBag {
public RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public long inParamOrderAccConceptID;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>OrderDistinctList</code> that represents the Service Studio TextList
///  <code>OrderDistinctList</code> <p>Description: </p>
/// </summary>
public BasicTypeList<string> varLcOrderDistinctList = new BasicTypeList<string>();

/// <summary>
/// Variable <code>l_FilesList</code> that represents the Service Studio FolioFilesStructList
///  <code>l_FilesList</code> <p>Description: </p>
/// </summary>
public RL_1501ee54ff868a67eff67465502ee3d9 varLcl_FilesList = new RL_1501ee54ff868a67eff67465502ee3d9();

/// <summary>
/// Variable <code>l_FilesListExtra</code> that represents the Service Studio FolioFilesStructList
///  <code>l_FilesListExtra</code> <p>Description: </p>
/// </summary>
public RL_1501ee54ff868a67eff67465502ee3d9 varLcl_FilesListExtra = new RL_1501ee54ff868a67eff67465502ee3d9();

public RL_1501ee54ff868a67eff67465502ee3d9 resListFilter_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public Actions.lcoFolioCreate resFolioCreate =  new Actions.lcoFolioCreate();
public RC_c4cc207f9017de4e013fabcf1e8ebeaf resGetOrderMainItem_outParamRecord = new RC_c4cc207f9017de4e013fabcf1e8ebeaf();

public BasicTypeList<string> resListDistinct_outParamDistinctList = new BasicTypeList<string>();

public RL_f4ab0a048438c19ab1537693fa69f7c4 resListFilterOrder_outParamFilteredList = new RL_f4ab0a048438c19ab1537693fa69f7c4();

public lcvFolioMassCreate(RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, long inParamOrderAccConceptID, int inParamOffsetUtc) {
this.inParamFolioQList = inParamFolioQList;
this.inParamFilesList = inParamFilesList;
this.inParamOrderAccConceptID = inParamOrderAccConceptID;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoFolioMassCreate : VarsBag {
public string outParamErrorMsg = "";

public lcoFolioMassCreate() {
}
}
/// <summary>
/// Action <code>FolioMassCreate</code> that represents the Service Studio action
///  <code>FolioMassCreate</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionFolioMassCreate(IRequestContext requestContext,RL_f4ab0a048438c19ab1537693fa69f7c4 inParamFolioQList,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,long inParamOrderAccConceptID,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoFolioMassCreate result = new lcoFolioMassCreate();
lcvFolioMassCreate localVars = new lcvFolioMassCreate(inParamFolioQList, inParamFilesList, inParamOrderAccConceptID, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioMassCreate", "5d000fd4-bb11-4301-82d2-6d30937240e7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioMassCreate", "5d000fd4-bb11-4301-82d2-6d30937240e7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcOrderDistinctList,(await BasicTypeList<string>.ConvertAsync(localVars.inParamFolioQList, new BasicTypeList<string>(), async (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure source, string target, CancellationToken cancellationToken) => {
target = source.ssOrderNumber;
return target;
}, cancellationToken)),cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((BasicTypeList<string>) localVars.varLcOrderDistinctList.Distinct()));

// Foreach ListDistinct.DistinctList
localVars.resListDistinct_outParamDistinctList.StartIteration();
try {while (!((localVars.resListDistinct_outParamDistinctList.Eof))) {
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_FilesList,cancellationToken);

// ListClear2
await ExtendedActions.ListClear(requestContext,localVars.varLcl_FilesListExtra,cancellationToken);

// ListFilterOrder
localVars.resListFilterOrder_outParamFilteredList = (((RL_f4ab0a048438c19ab1537693fa69f7c4)await  localVars.inParamFolioQList.FilterAsync(async (p, cancellationToken) => (p.ssOrderNumber==localVars.resListDistinct_outParamDistinctList.CurrentRec), cancellationToken)));

// GetOrderMainItem
localVars.resGetOrderMainItem_outParamRecord = await ExtendedActions.GetOrderMainItem(requestContext,localVars.resListFilterOrder_outParamFilteredList.CurrentRec.ssOrderMainItem,cancellationToken);

// Foreach FilesList
localVars.inParamFilesList.StartIteration();
try {while (!((localVars.inParamFilesList.Eof))) {
if(((BuiltInFunction.ToUpper (localVars.inParamFilesList.CurrentRec.ssName)==BuiltInFunction.ToUpper (localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenamePdf)))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FilesList,localVars.inParamFilesList.CurrentRec,cancellationToken);

}

if(((BuiltInFunction.ToUpper (localVars.inParamFilesList.CurrentRec.ssName)==BuiltInFunction.ToUpper (localVars.inParamFolioQList.CurrentRec.ssInvoiceFilenameXml)))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FilesList,localVars.inParamFilesList.CurrentRec,cancellationToken);

}

localVars.inParamFilesList.Advance();
}

} finally {
localVars.inParamFilesList.EndIteration();
}

// Foreach FolioQList.Current.FolioQFilesList
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.StartIteration();
try {while (!((localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (p.ssName==localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.CurrentRec.ssFilename), cancellationToken)));

if(((localVars.resListFilterOrder_outParamFilteredList.Length==1))) {
// ListAppend3
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FilesListExtra,localVars.resListFilter_outParamFilteredList.CurrentRec,cancellationToken);

}

localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.Advance();
}

} finally {
localVars.inParamFolioQList.CurrentRec.ssFolioQFilesList.EndIteration();
}

// FolioCreate
(localVars.resFolioCreate.outParamo_FolioName,localVars.resFolioCreate.outParamErrorMsg) = await Actions.ActionFolioCreate(requestContext,(await RL_123aa03224ec08dab8cbe26021987012.ConvertAsync(localVars.resListFilterOrder_outParamFilteredList, new RL_123aa03224ec08dab8cbe26021987012(), async (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure source, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure target, CancellationToken cancellationToken) => {
target.ssOrderMainId = source.ssOrderMainItem;
target.ssPosition = Convert.ToString(source.ssPosition);
target.ssOrderNumber = source.ssOrderNumber;
target.ssArticleNumber = localVars.resGetOrderMainItem_outParamRecord.ssENOrderMainItem.ssMaterialCode;
target.ssDescription = localVars.resGetOrderMainItem_outParamRecord.ssENOrderMainItem.ssMaterialDescription;
target.ssInputationCode = localVars.resGetOrderMainItem_outParamRecord.ssENOrderMainItem.ssAssigmnentCode;
target.ssDeliveryDate = BuiltInFunction.NewDate (BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (source.ssDeliveryDate, 7, 4)), BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (source.ssDeliveryDate, 4, 2)), BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (source.ssDeliveryDate, 1, 2)));
target.ssInvoiceQtt = source.ssInvoiceQuantity;
target.ssRemainingQtt = (((decimal)0));
target.ssRemainingQttTotal = (((decimal)0));
target.ssUnitPrice = source.ssUnitPrice;
target.ssTotalPrice = (source.ssUnitPrice*source.ssInvoiceQuantity);
target.ssQuantity = localVars.resGetOrderMainItem_outParamRecord.ssENOrderMainItem.ssQuantity;
target.ssDeliveryQtt = Convert.ToString(source.ssDeliveredQuantity);
target.ssImportdelivery = localVars.resListFilterOrder_outParamFilteredList.CurrentRec.ssAmountDelivered;
target.ssIsInvoiceError = false;
target.ssIsDateError = false;
target.ssPEP = source.ssPEP;
target.ssPlaceId = source.ssPlaceId;
target.ssPlaceName = source.ssPlaceName;
target.ssBaseQuantity = source.ssBaseQuantity;
target.ssVatRate = source.ssVATRate;
return target;
}, cancellationToken)),localVars.resGetOrderMainItem_outParamRecord.ssENOrderMainItem.ssOrderMainId,BuiltInFunction.NullTextIdentifier (),"",new EN_f81a3d226103fd013068b8763798067aEntityRecord(),localVars.varLcl_FilesListExtra,localVars.varLcl_FilesList,0L,new ST_6f620840109ac6f721328b723ec0152cStructure(),3,new RC_1c2482ce6cd4b83ca44ec0510b231d44(),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),new RC_45d2d2c3c5fe5caa10fa5e20326622ac(),true,0,localVars.inParamOrderAccConceptID,new RL_1501ee54ff868a67eff67465502ee3d9(),(((decimal)0)),false,localVars.inParamOffsetUtc,cancellationToken);

if((!((localVars.resFolioCreate.outParamErrorMsg=="")))) {
// ErrorMsg = FolioCreate.ErrorMsg
result.outParamErrorMsg=localVars.resFolioCreate.outParamErrorMsg;
goto RETURN_STATEMENT;

}

localVars.resListDistinct_outParamDistinctList.Advance();
}

} finally {
localVars.resListDistinct_outParamDistinctList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionFolioMassCreate {



}


}
