using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b> outParamList;
[JsonProperty("Count")]
public int? outParamCount;


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_ba76bc23b46b20e6625cad46f2aea8e4 outParamList, int outParamCount) {RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderStatus to the tmpoutParamListElement.AttrOrderStatus
tmpoutParamListElement.AttrOrderStatus = new ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord();
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrId
tmpoutParamListElement.AttrOrderStatus.AttrId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrLabel
tmpoutParamListElement.AttrOrderStatus.AttrLabel = "";
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrClass
tmpoutParamListElement.AttrOrderStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrOrder
tmpoutParamListElement.AttrOrderStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrIs_Active
tmpoutParamListElement.AttrOrderStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrLabelES
tmpoutParamListElement.AttrOrderStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderMain to the tmpoutParamListElement.AttrOrderMain
tmpoutParamListElement.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
tmpoutParamListElement.AttrOrderMain.AttrId = (long?) outParamList.CurrentRec.ssENOrderMain.ssId;
tmpoutParamListElement.AttrOrderMain.AttrOrderNumber = outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
tmpoutParamListElement.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENOrderMain.ssOrderDate);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode = outParamList.CurrentRec.ssENOrderMain.ssAssignmentCode;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSupplierId
tmpoutParamListElement.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCompanyId
tmpoutParamListElement.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId
tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCurrencyId
tmpoutParamListElement.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup
tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCountry
tmpoutParamListElement.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsDeleted
tmpoutParamListElement.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsReleased
tmpoutParamListElement.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrExchangeRate
tmpoutParamListElement.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory = "";
tmpoutParamListElement.AttrOrderMain.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENOrderMain.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz
tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrRegionId
tmpoutParamListElement.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDivisionId
tmpoutParamListElement.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrApplicant
tmpoutParamListElement.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedBy
tmpoutParamListElement.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedOn
tmpoutParamListElement.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy
tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn
tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssSTQuantidadeEntregada to the tmpoutParamListElement.AttrQuantidadeEntregada
tmpoutParamListElement.AttrQuantidadeEntregada = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamListElement.AttrQuantidadeEntregada.AttrValue = (decimal?) outParamList.CurrentRec.ssSTQuantidadeEntregada.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTQuantidadeTotal to the tmpoutParamListElement.AttrQuantidadeTotal
tmpoutParamListElement.AttrQuantidadeTotal = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamListElement.AttrQuantidadeTotal.AttrValue = (decimal?) outParamList.CurrentRec.ssSTQuantidadeTotal.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
tmpoutParamListElement.AttrCompany.AttrDescription = outParamList.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b>(new ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderStatus to the tmpoutParamListElement.AttrOrderStatus
tmpoutParamListElement.AttrOrderStatus = new ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord();
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrId
tmpoutParamListElement.AttrOrderStatus.AttrId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrLabel
tmpoutParamListElement.AttrOrderStatus.AttrLabel = "";
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrClass
tmpoutParamListElement.AttrOrderStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrOrder
tmpoutParamListElement.AttrOrderStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrIs_Active
tmpoutParamListElement.AttrOrderStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderStatus.AttrLabelES
tmpoutParamListElement.AttrOrderStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderMain to the tmpoutParamListElement.AttrOrderMain
tmpoutParamListElement.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
tmpoutParamListElement.AttrOrderMain.AttrId = (long?) outParamList.CurrentRec.ssENOrderMain.ssId;
tmpoutParamListElement.AttrOrderMain.AttrOrderNumber = outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
tmpoutParamListElement.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENOrderMain.ssOrderDate);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode = outParamList.CurrentRec.ssENOrderMain.ssAssignmentCode;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSupplierId
tmpoutParamListElement.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCompanyId
tmpoutParamListElement.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId
tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCurrencyId
tmpoutParamListElement.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup
tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCountry
tmpoutParamListElement.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsDeleted
tmpoutParamListElement.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsReleased
tmpoutParamListElement.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrExchangeRate
tmpoutParamListElement.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory = "";
tmpoutParamListElement.AttrOrderMain.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENOrderMain.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz
tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrRegionId
tmpoutParamListElement.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDivisionId
tmpoutParamListElement.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrApplicant
tmpoutParamListElement.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedBy
tmpoutParamListElement.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedOn
tmpoutParamListElement.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy
tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn
tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssSTQuantidadeEntregada to the tmpoutParamListElement.AttrQuantidadeEntregada
tmpoutParamListElement.AttrQuantidadeEntregada = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamListElement.AttrQuantidadeEntregada.AttrValue = (decimal?) outParamList.CurrentRec.ssSTQuantidadeEntregada.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTQuantidadeTotal to the tmpoutParamListElement.AttrQuantidadeTotal
tmpoutParamListElement.AttrQuantidadeTotal = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamListElement.AttrQuantidadeTotal.AttrValue = (decimal?) outParamList.CurrentRec.ssSTQuantidadeTotal.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
tmpoutParamListElement.AttrCompany.AttrDescription = outParamList.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b));
}

result.outParamCount = (int?) outParamCount;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model ToModel(RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs variables) {ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model result = new ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model();
result.outParamList = variables == null ? new RL_ba76bc23b46b20e6625cad46f2aea8e4() : RL_ba76bc23b46b20e6625cad46f2aea8e4.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0 : variables.outParamCount.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b>(ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b.FromStructureDelegate(conf));
result.outParamCount = (int?) screenModel.outParamCount;
return result;
}

}
