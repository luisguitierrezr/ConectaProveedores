using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQImport
public class JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure : AbstractRESTStructure<ST_9d31438c744477d5e7fa3ba41ac26dffStructure> {
[JsonProperty("number")]
[JsonPropertyName("number")]
public string AttrNumber;

[JsonProperty("order")]
[JsonPropertyName("order")]
public string AttrOrder;

[JsonProperty("attachments")]
[JsonPropertyName("attachments")]
public string AttrAttachments;

[JsonProperty("positions")]
[JsonPropertyName("positions")]
public string AttrPositions;

[JsonProperty("delivery_date")]
[JsonPropertyName("delivery_date")]
public string AttrDelivery_date;

[JsonProperty("amount_to_invoice")]
[JsonPropertyName("amount_to_invoice")]
public string AttrInvoiceDelivery;

[JsonProperty("user")]
[JsonPropertyName("user")]
public string AttrUser;

[JsonProperty("invoice_pdf")]
[JsonPropertyName("invoice_pdf")]
public string AttrInvoice_pdf;

[JsonProperty("invoice_xml")]
[JsonPropertyName("invoice_xml")]
public string AttrInvoice_xml;

[JsonProperty("pep")]
[JsonPropertyName("pep")]
public string AttrPep;

[JsonProperty("site_id")]
[JsonPropertyName("site_id")]
public string AttrSite_id;

[JsonProperty("site_name")]
[JsonPropertyName("site_name")]
public string AttrSite_name;

public JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure() { }

public JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure (ST_9d31438c744477d5e7fa3ba41ac26dffStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNumber = ConvertToRestWithoutDefaults(s.ssNumber, "");
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, "");
AttrAttachments = ConvertToRestWithoutDefaults(s.ssAttachments, "");
AttrPositions = ConvertToRestWithoutDefaults(s.ssPositions, "");
AttrDelivery_date = ConvertToRestWithoutDefaults(s.ssDelivery_date, "");
AttrInvoiceDelivery = ConvertToRestWithoutDefaults(s.ssInvoiceDelivery, "");
AttrUser = ConvertToRestWithoutDefaults(s.ssUser, "");
AttrInvoice_pdf = ConvertToRestWithoutDefaults(s.ssInvoice_pdf, "");
AttrInvoice_xml = ConvertToRestWithoutDefaults(s.ssInvoice_xml, "");
AttrPep = ConvertToRestWithoutDefaults(s.ssPep, "");
AttrSite_id = ConvertToRestWithoutDefaults(s.ssSite_id, "");
AttrSite_name = ConvertToRestWithoutDefaults(s.ssSite_name, "");
  } else {
AttrNumber = s.ssNumber;
AttrOrder = s.ssOrder;
AttrAttachments = s.ssAttachments;
AttrPositions = s.ssPositions;
AttrDelivery_date = s.ssDelivery_date;
AttrInvoiceDelivery = s.ssInvoiceDelivery;
AttrUser = s.ssUser;
AttrInvoice_pdf = s.ssInvoice_pdf;
AttrInvoice_xml = s.ssInvoice_xml;
AttrPep = s.ssPep;
AttrSite_id = s.ssSite_id;
AttrSite_name = s.ssSite_name;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure, ST_9d31438c744477d5e7fa3ba41ac26dffStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure s) => ToStructure(s, config);
}
public static ST_9d31438c744477d5e7fa3ba41ac26dffStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure obj, IBehaviorsConfiguration config) { 
  ST_9d31438c744477d5e7fa3ba41ac26dffStructure s = new ST_9d31438c744477d5e7fa3ba41ac26dffStructure();
  if(obj != null) {
  s.ssNumber = obj.AttrNumber == null ? "" : obj.AttrNumber;
  s.ssOrder = obj.AttrOrder == null ? "" : obj.AttrOrder;
  s.ssAttachments = obj.AttrAttachments == null ? "" : obj.AttrAttachments;
  s.ssPositions = obj.AttrPositions == null ? "" : obj.AttrPositions;
  s.ssDelivery_date = obj.AttrDelivery_date == null ? "" : obj.AttrDelivery_date;
  s.ssInvoiceDelivery = obj.AttrInvoiceDelivery == null ? "" : obj.AttrInvoiceDelivery;
  s.ssUser = obj.AttrUser == null ? "" : obj.AttrUser;
  s.ssInvoice_pdf = obj.AttrInvoice_pdf == null ? "" : obj.AttrInvoice_pdf;
  s.ssInvoice_xml = obj.AttrInvoice_xml == null ? "" : obj.AttrInvoice_xml;
  s.ssPep = obj.AttrPep == null ? "" : obj.AttrPep;
  s.ssSite_id = obj.AttrSite_id == null ? "" : obj.AttrSite_id;
  s.ssSite_name = obj.AttrSite_name == null ? "" : obj.AttrSite_name;
  }
  return s;
}

public static Func<ST_9d31438c744477d5e7fa3ba41ac26dffStructure, ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9d31438c744477d5e7fa3ba41ac26dffStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure FromStructure(ST_9d31438c744477d5e7fa3ba41ac26dffStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure(s, config);
}

}


