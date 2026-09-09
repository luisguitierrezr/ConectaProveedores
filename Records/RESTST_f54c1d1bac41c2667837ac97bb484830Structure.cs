using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReport
public class RESTST_f54c1d1bac41c2667837ac97bb484830Structure : AbstractRESTStructure<ST_f54c1d1bac41c2667837ac97bb484830Structure> {
[JsonProperty("Supplier")]
public string AttrSupplier;

[JsonProperty("Project")]
public string AttrProject;

[JsonProperty("ReservePeriod")]
public string AttrReservePeriod;

[JsonProperty("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("Frequency")]
public string AttrFrequency;

[JsonProperty("RequisitionNumber")]
public string AttrRequisitionNumber;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("DeliveryDate")]
public string AttrDeliveryDate;

[JsonProperty("ValidationReportItems")]
public RestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> AttrValidationReportItems;

[JsonProperty("BusinessCat")]
public string AttrBusinessCat;

[JsonProperty("BusinessSubcat")]
public string AttrBusinessSubcat;

[JsonProperty("Characteristics")]
public string AttrCharacteristics;

[JsonProperty("Deliveries")]
public string AttrDeliveries;

[JsonProperty("Attachments")]
public string AttrAttachments;

[JsonProperty("ValidationReportAuthorizations")]
public RestList<ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure> AttrValidationReportAuthorizations;

[JsonProperty("FolioCreationDate")]
public String AttrFolioCreationDate;

[JsonProperty("Society")]
public string AttrSociety;

[JsonProperty("PEPElement")]
public string AttrPEPElement;

[JsonProperty("DeliverySite")]
public string AttrDeliverySite;

[JsonProperty("EntryNumber")]
public string AttrEntryNumber;

[JsonProperty("EntryDate")]
public String AttrEntryDate;

public RESTST_f54c1d1bac41c2667837ac97bb484830Structure() { }

public RESTST_f54c1d1bac41c2667837ac97bb484830Structure (ST_f54c1d1bac41c2667837ac97bb484830Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplier = ConvertToRestWithoutDefaults(s.ssSupplier, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrReservePeriod = ConvertToRestWithoutDefaults(s.ssReservePeriod, "");
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, "");
AttrRequisitionNumber = ConvertToRestWithoutDefaults(s.ssRequisitionNumber, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrDeliveryDate = ConvertToRestWithoutDefaults(s.ssDeliveryDate, "");
AttrValidationReportItems = s.ssValidationReportItems.Length == 0 ? null : s.ssValidationReportItems.ToRestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(config));
AttrBusinessCat = ConvertToRestWithoutDefaults(s.ssBusinessCat, "");
AttrBusinessSubcat = ConvertToRestWithoutDefaults(s.ssBusinessSubcat, "");
AttrCharacteristics = ConvertToRestWithoutDefaults(s.ssCharacteristics, "");
AttrDeliveries = ConvertToRestWithoutDefaults(s.ssDeliveries, "");
AttrAttachments = ConvertToRestWithoutDefaults(s.ssAttachments, "");
AttrValidationReportAuthorizations = s.ssValidationReportAuthorizations.Length == 0 ? null : s.ssValidationReportAuthorizations.ToRestList<ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure>(ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructureDelegate(config));
AttrFolioCreationDate = ConvertDateToRestWithoutDefaults(s.ssFolioCreationDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrSociety = ConvertToRestWithoutDefaults(s.ssSociety, "");
AttrPEPElement = ConvertToRestWithoutDefaults(s.ssPEPElement, "");
AttrDeliverySite = ConvertToRestWithoutDefaults(s.ssDeliverySite, "");
AttrEntryNumber = ConvertToRestWithoutDefaults(s.ssEntryNumber, "");
AttrEntryDate = ConvertDateTimeToRestWithoutDefaults(s.ssEntryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrSupplier = s.ssSupplier;
AttrProject = s.ssProject;
AttrReservePeriod = s.ssReservePeriod;
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrFrequency = s.ssFrequency;
AttrRequisitionNumber = s.ssRequisitionNumber;
AttrOrderNumber = s.ssOrderNumber;
AttrDeliveryDate = s.ssDeliveryDate;
AttrValidationReportItems = s.ssValidationReportItems.ToRestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(config));
AttrBusinessCat = s.ssBusinessCat;
AttrBusinessSubcat = s.ssBusinessSubcat;
AttrCharacteristics = s.ssCharacteristics;
AttrDeliveries = s.ssDeliveries;
AttrAttachments = s.ssAttachments;
AttrValidationReportAuthorizations = s.ssValidationReportAuthorizations.ToRestList<ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure>(ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructureDelegate(config));
AttrFolioCreationDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFolioCreationDate);
AttrSociety = s.ssSociety;
AttrPEPElement = s.ssPEPElement;
AttrDeliverySite = s.ssDeliverySite;
AttrEntryNumber = s.ssEntryNumber;
AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssEntryDate, config.DateTimeFormat);
  }
}

public static ST_f54c1d1bac41c2667837ac97bb484830Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure obj) { 
  ST_f54c1d1bac41c2667837ac97bb484830Structure s = new ST_f54c1d1bac41c2667837ac97bb484830Structure();
  if(obj != null) {
  s.ssSupplier = obj.AttrSupplier == null ? "" : obj.AttrSupplier;
  s.ssProject = obj.AttrProject == null ? "" : obj.AttrProject;
  s.ssReservePeriod = obj.AttrReservePeriod == null ? "" : obj.AttrReservePeriod;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssFrequency = obj.AttrFrequency == null ? "" : obj.AttrFrequency;
  s.ssRequisitionNumber = obj.AttrRequisitionNumber == null ? "" : obj.AttrRequisitionNumber;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? "" : obj.AttrDeliveryDate;
  s.ssValidationReportItems = RL_f0441ae281d3bacc0d1d0acaed8c2549.FromRestList(obj.AttrValidationReportItems, ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.ToStructure);
  s.ssBusinessCat = obj.AttrBusinessCat == null ? "" : obj.AttrBusinessCat;
  s.ssBusinessSubcat = obj.AttrBusinessSubcat == null ? "" : obj.AttrBusinessSubcat;
  s.ssCharacteristics = obj.AttrCharacteristics == null ? "" : obj.AttrCharacteristics;
  s.ssDeliveries = obj.AttrDeliveries == null ? "" : obj.AttrDeliveries;
  s.ssAttachments = obj.AttrAttachments == null ? "" : obj.AttrAttachments;
  s.ssValidationReportAuthorizations = RL_2d1a9f1ebd1dae77afe7dba56f4eb06c.FromRestList(obj.AttrValidationReportAuthorizations, ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.ToStructure);
  s.ssFolioCreationDate = obj.AttrFolioCreationDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFolioCreationDate);
  s.ssSociety = obj.AttrSociety == null ? "" : obj.AttrSociety;
  s.ssPEPElement = obj.AttrPEPElement == null ? "" : obj.AttrPEPElement;
  s.ssDeliverySite = obj.AttrDeliverySite == null ? "" : obj.AttrDeliverySite;
  s.ssEntryNumber = obj.AttrEntryNumber == null ? "" : obj.AttrEntryNumber;
  s.ssEntryDate = obj.AttrEntryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrEntryDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<ST_f54c1d1bac41c2667837ac97bb484830Structure, ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f54c1d1bac41c2667837ac97bb484830Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure FromStructure(ST_f54c1d1bac41c2667837ac97bb484830Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure(s, config);
}

}


