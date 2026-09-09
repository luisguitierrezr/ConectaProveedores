using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceRecord")]
public ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f outParamInvoiceRecord;
[JsonProperty("HasDifferentRegions")]
public bool? outParamHasDifferentRegions;
[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord outParamRegion;
[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord outParamSupplier;


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs FromOutputs(IBehaviorsConfiguration conf, RC_cad676a01e44d775889bfdee9f2eda1f outParamInvoiceRecord, bool outParamHasDifferentRegions, EN_31f501c551d210017fcb34b5237e3390EntityRecord outParamRegion, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord outParamSupplier) {RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs();
// Write the needed fields of the record outParamInvoiceRecord to the result.outParamInvoiceRecord
result.outParamInvoiceRecord = new ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f();
// Write the needed fields of the record outParamInvoiceRecord.ssENInvoice to the result.outParamInvoiceRecord.AttrInvoice
result.outParamInvoiceRecord.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
result.outParamInvoiceRecord.AttrInvoice.AttrId = (long?) outParamInvoiceRecord.ssENInvoice.ssId;
result.outParamInvoiceRecord.AttrInvoice.AttrName = outParamInvoiceRecord.ssENInvoice.ssName;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrRequisitionId
result.outParamInvoiceRecord.AttrInvoice.AttrRequisitionId = (long?) 0L;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrFolioId
result.outParamInvoiceRecord.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrOrderMainId
result.outParamInvoiceRecord.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrCFDITypeId
result.outParamInvoiceRecord.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrTotalAmount
result.outParamInvoiceRecord.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrCurrency
result.outParamInvoiceRecord.AttrInvoice.AttrCurrency = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrInvoiceStatusId
result.outParamInvoiceRecord.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrAccountingDateTime
result.outParamInvoiceRecord.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrPaymentDateTime
result.outParamInvoiceRecord.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrCreatedOn
result.outParamInvoiceRecord.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrCreatedBy
result.outParamInvoiceRecord.AttrInvoice.AttrCreatedBy = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrUpdatedOn
result.outParamInvoiceRecord.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrUpdatedBy
result.outParamInvoiceRecord.AttrInvoice.AttrUpdatedBy = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrSubmittedOn
result.outParamInvoiceRecord.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrIsNewVersion
result.outParamInvoiceRecord.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrID_POLIZA
result.outParamInvoiceRecord.AttrInvoice.AttrID_POLIZA = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrID_POLIZA_SAP
result.outParamInvoiceRecord.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrDoc51
result.outParamInvoiceRecord.AttrInvoice.AttrDoc51 = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrAccountingError
result.outParamInvoiceRecord.AttrInvoice.AttrAccountingError = "";
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrOrderAccConceptsID
result.outParamInvoiceRecord.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrAmortization
result.outParamInvoiceRecord.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized result.outParamInvoiceRecord.AttrInvoice.AttrCreditNoteInvoiceId
result.outParamInvoiceRecord.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceRecord.ssENInvoiceStatus to the result.outParamInvoiceRecord.AttrInvoiceStatus
result.outParamInvoiceRecord.AttrInvoiceStatus = new ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
// Write optimized result.outParamInvoiceRecord.AttrInvoiceStatus.AttrId
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrId = (int?) 0;
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrLabel = outParamInvoiceRecord.ssENInvoiceStatus.ssLabel;
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrClass = outParamInvoiceRecord.ssENInvoiceStatus.ssClass;
// Write optimized result.outParamInvoiceRecord.AttrInvoiceStatus.AttrOrder
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrOrder = (int?) 0;
// Write optimized result.outParamInvoiceRecord.AttrInvoiceStatus.AttrIs_Active
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrIs_Active = (bool?) false;
// Write optimized result.outParamInvoiceRecord.AttrInvoiceStatus.AttrIsInAccounting
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrIsInAccounting = (bool?) false;
// Write optimized result.outParamInvoiceRecord.AttrInvoiceStatus.AttrLabelES
result.outParamInvoiceRecord.AttrInvoiceStatus.AttrLabelES = "";
result.outParamHasDifferentRegions = (bool?) outParamHasDifferentRegions;
// Write the needed fields of the record outParamRegion to the result.outParamRegion
result.outParamRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized result.outParamRegion.AttrId
result.outParamRegion.AttrId = (long?) 0L;
result.outParamRegion.AttrCode = outParamRegion.ssCode;
// Write optimized result.outParamRegion.AttrName
result.outParamRegion.AttrName = "";
result.outParamRegion.AttrDivisionFI = outParamRegion.ssDivisionFI;
// Write optimized result.outParamRegion.AttrCentroRTP
result.outParamRegion.AttrCentroRTP = "";
// Write optimized result.outParamRegion.AttrCommissionRegion
result.outParamRegion.AttrCommissionRegion = "";
// Write optimized result.outParamRegion.AttrIsActive
result.outParamRegion.AttrIsActive = (bool?) false;
// Write optimized result.outParamRegion.AttrCreatedOn
result.outParamRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamRegion.AttrCreatedBy
result.outParamRegion.AttrCreatedBy = "";
// Write optimized result.outParamRegion.AttrUpdatedOn
result.outParamRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamRegion.AttrUpdatedBy
result.outParamRegion.AttrUpdatedBy = "";
// Write optimized result.outParamRegion.AttrIsFsP
result.outParamRegion.AttrIsFsP = (bool?) false;
// Write optimized result.outParamRegion.AttrIsFcP
result.outParamRegion.AttrIsFcP = (bool?) false;
// Write the needed fields of the record outParamSupplier to the result.outParamSupplier
result.outParamSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized result.outParamSupplier.AttrId
result.outParamSupplier.AttrId = (long?) 0L;
// Write optimized result.outParamSupplier.AttrTratamiento
result.outParamSupplier.AttrTratamiento = "";
result.outParamSupplier.AttrName = outParamSupplier.ssName;
result.outParamSupplier.AttrNumber = outParamSupplier.ssNumber;
// Write optimized result.outParamSupplier.AttrConceptobusq_1_2
result.outParamSupplier.AttrConceptobusq_1_2 = "";
// Write optimized result.outParamSupplier.AttrCalle_Numero
result.outParamSupplier.AttrCalle_Numero = "";
// Write optimized result.outParamSupplier.AttrDistrito
result.outParamSupplier.AttrDistrito = "";
// Write optimized result.outParamSupplier.AttrCodigopostal_Pobl_
result.outParamSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized result.outParamSupplier.AttrPais
result.outParamSupplier.AttrPais = "";
// Write optimized result.outParamSupplier.AttrRegion_
result.outParamSupplier.AttrRegion_ = "";
// Write optimized result.outParamSupplier.AttrIdioma
result.outParamSupplier.AttrIdioma = "";
// Write optimized result.outParamSupplier.AttrTelefono
result.outParamSupplier.AttrTelefono = "";
// Write optimized result.outParamSupplier.AttrExtension
result.outParamSupplier.AttrExtension = "";
// Write optimized result.outParamSupplier.AttrFax
result.outParamSupplier.AttrFax = "";
// Write optimized result.outParamSupplier.AttrCliente
result.outParamSupplier.AttrCliente = "";
// Write optimized result.outParamSupplier.AttrSoc_GLasociada
result.outParamSupplier.AttrSoc_GLasociada = "";
// Write optimized result.outParamSupplier.AttrClavedegrupo
result.outParamSupplier.AttrClavedegrupo = "";
result.outParamSupplier.AttrN_ident_fis_1 = outParamSupplier.ssN_ident_fis_1;
// Write optimized result.outParamSupplier.AttrPersonafisica
result.outParamSupplier.AttrPersonafisica = "";
// Write optimized result.outParamSupplier.AttrRamo
result.outParamSupplier.AttrRamo = "";
// Write optimized result.outParamSupplier.AttrGrupodeporte
result.outParamSupplier.AttrGrupodeporte = "";
// Write optimized result.outParamSupplier.AttrEmail
result.outParamSupplier.AttrEmail = "";
// Write optimized result.outParamSupplier.AttrIsActive
result.outParamSupplier.AttrIsActive = (bool?) false;
// Write optimized result.outParamSupplier.AttrCreatedOn
result.outParamSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamSupplier.AttrCreatedBy
result.outParamSupplier.AttrCreatedBy = "";
// Write optimized result.outParamSupplier.AttrUpdatedOn
result.outParamSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamSupplier.AttrUpdatedBy
result.outParamSupplier.AttrUpdatedBy = "";
// Write optimized result.outParamSupplier.AttrRegionId
result.outParamSupplier.AttrRegionId = (long?) 0L;
return result;
}


    public static ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model ToModel(RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs variables) {ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model result = new ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model();
result.outParamInvoiceRecord = variables == null ? new RC_cad676a01e44d775889bfdee9f2eda1f() : ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f.ToStructure(variables.outParamInvoiceRecord);
result.outParamHasDifferentRegions = variables == null || variables.outParamHasDifferentRegions == null ? false : variables.outParamHasDifferentRegions.Value;
result.outParamRegion = variables == null ? new EN_31f501c551d210017fcb34b5237e3390EntityRecord() : ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(variables.outParamRegion);
result.outParamSupplier = variables == null ? new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord() : ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(variables.outParamSupplier);
return result;
}


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs();
result.outParamInvoiceRecord = ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f.FromStructure(screenModel.outParamInvoiceRecord, conf);
result.outParamHasDifferentRegions = (bool?) screenModel.outParamHasDifferentRegions;
result.outParamRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(screenModel.outParamRegion, conf);
result.outParamSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(screenModel.outParamSupplier, conf);
return result;
}

}
