using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReport
public class JSONST_f54c1d1bac41c2667837ac97bb484830Structure : AbstractRESTStructure<ST_f54c1d1bac41c2667837ac97bb484830Structure> {
[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public string AttrSupplier;

[JsonProperty("Project")]
[JsonPropertyName("Project")]
public string AttrProject;

[JsonProperty("ReservePeriod")]
[JsonPropertyName("ReservePeriod")]
public string AttrReservePeriod;

[JsonProperty("InvoiceNumber")]
[JsonPropertyName("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public string AttrFrequency;

[JsonProperty("RequisitionNumber")]
[JsonPropertyName("RequisitionNumber")]
public string AttrRequisitionNumber;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("DeliveryDate")]
[JsonPropertyName("DeliveryDate")]
public string AttrDeliveryDate;

[JsonProperty("ValidationReportItems")]
[JsonPropertyName("ValidationReportItems")]
public ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure[] AttrValidationReportItems;

[JsonProperty("BusinessCat")]
[JsonPropertyName("BusinessCat")]
public string AttrBusinessCat;

[JsonProperty("BusinessSubcat")]
[JsonPropertyName("BusinessSubcat")]
public string AttrBusinessSubcat;

[JsonProperty("Characteristics")]
[JsonPropertyName("Characteristics")]
public string AttrCharacteristics;

[JsonProperty("Deliveries")]
[JsonPropertyName("Deliveries")]
public string AttrDeliveries;

[JsonProperty("Attachments")]
[JsonPropertyName("Attachments")]
public string AttrAttachments;

[JsonProperty("ValidationReportAuthorizations")]
[JsonPropertyName("ValidationReportAuthorizations")]
public ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure[] AttrValidationReportAuthorizations;

[JsonProperty("FolioCreationDate")]
[JsonPropertyName("FolioCreationDate")]
public String AttrFolioCreationDate;

[JsonProperty("Society")]
[JsonPropertyName("Society")]
public string AttrSociety;

[JsonProperty("PEPElement")]
[JsonPropertyName("PEPElement")]
public string AttrPEPElement;

[JsonProperty("DeliverySite")]
[JsonPropertyName("DeliverySite")]
public string AttrDeliverySite;

[JsonProperty("EntryNumber")]
[JsonPropertyName("EntryNumber")]
public string AttrEntryNumber;

[JsonProperty("EntryDate")]
[JsonPropertyName("EntryDate")]
public String AttrEntryDate;

public JSONST_f54c1d1bac41c2667837ac97bb484830Structure() { }

public JSONST_f54c1d1bac41c2667837ac97bb484830Structure (ST_f54c1d1bac41c2667837ac97bb484830Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplier = ConvertToRestWithoutDefaults(s.ssSupplier, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrReservePeriod = ConvertToRestWithoutDefaults(s.ssReservePeriod, "");
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, "");
AttrRequisitionNumber = ConvertToRestWithoutDefaults(s.ssRequisitionNumber, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrDeliveryDate = ConvertToRestWithoutDefaults(s.ssDeliveryDate, "");
AttrValidationReportItems = s.ssValidationReportItems.Length == 0 ? null : s.ssValidationReportItems.ToArray<ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(config));
AttrBusinessCat = ConvertToRestWithoutDefaults(s.ssBusinessCat, "");
AttrBusinessSubcat = ConvertToRestWithoutDefaults(s.ssBusinessSubcat, "");
AttrCharacteristics = ConvertToRestWithoutDefaults(s.ssCharacteristics, "");
AttrDeliveries = ConvertToRestWithoutDefaults(s.ssDeliveries, "");
AttrAttachments = ConvertToRestWithoutDefaults(s.ssAttachments, "");
AttrValidationReportAuthorizations = s.ssValidationReportAuthorizations.Length == 0 ? null : s.ssValidationReportAuthorizations.ToArray<ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure>(ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructureDelegate(config));
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
AttrValidationReportItems = s.ssValidationReportItems.ToArray<ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(config));
AttrBusinessCat = s.ssBusinessCat;
AttrBusinessSubcat = s.ssBusinessSubcat;
AttrCharacteristics = s.ssCharacteristics;
AttrDeliveries = s.ssDeliveries;
AttrAttachments = s.ssAttachments;
AttrValidationReportAuthorizations = s.ssValidationReportAuthorizations.ToArray<ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure>(ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructureDelegate(config));
AttrFolioCreationDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFolioCreationDate);
AttrSociety = s.ssSociety;
AttrPEPElement = s.ssPEPElement;
AttrDeliverySite = s.ssDeliverySite;
AttrEntryNumber = s.ssEntryNumber;
AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssEntryDate, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure, ST_f54c1d1bac41c2667837ac97bb484830Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure s) => ToStructure(s, config);
}
public static ST_f54c1d1bac41c2667837ac97bb484830Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure obj, IBehaviorsConfiguration config) { 
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
  s.ssValidationReportItems = RL_f0441ae281d3bacc0d1d0acaed8c2549.ToList(obj.AttrValidationReportItems, ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.ToStructureDelegate(config));
  s.ssBusinessCat = obj.AttrBusinessCat == null ? "" : obj.AttrBusinessCat;
  s.ssBusinessSubcat = obj.AttrBusinessSubcat == null ? "" : obj.AttrBusinessSubcat;
  s.ssCharacteristics = obj.AttrCharacteristics == null ? "" : obj.AttrCharacteristics;
  s.ssDeliveries = obj.AttrDeliveries == null ? "" : obj.AttrDeliveries;
  s.ssAttachments = obj.AttrAttachments == null ? "" : obj.AttrAttachments;
  s.ssValidationReportAuthorizations = RL_2d1a9f1ebd1dae77afe7dba56f4eb06c.ToList(obj.AttrValidationReportAuthorizations, ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.ToStructureDelegate(config));
  s.ssFolioCreationDate = obj.AttrFolioCreationDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFolioCreationDate);
  s.ssSociety = obj.AttrSociety == null ? "" : obj.AttrSociety;
  s.ssPEPElement = obj.AttrPEPElement == null ? "" : obj.AttrPEPElement;
  s.ssDeliverySite = obj.AttrDeliverySite == null ? "" : obj.AttrDeliverySite;
  s.ssEntryNumber = obj.AttrEntryNumber == null ? "" : obj.AttrEntryNumber;
  s.ssEntryDate = obj.AttrEntryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrEntryDate, config.DateTimeFormat);
  }
  return s;
}

public static Func<ST_f54c1d1bac41c2667837ac97bb484830Structure, ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f54c1d1bac41c2667837ac97bb484830Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure FromStructure(ST_f54c1d1bac41c2667837ac97bb484830Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure(s, config);
}

}


