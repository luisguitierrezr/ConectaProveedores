using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord
public class RESTRC_9f414d82ade67cb4131fecd8fda64580 : AbstractRESTStructure<RC_9f414d82ade67cb4131fecd8fda64580> {
[JsonProperty("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

public RESTRC_9f414d82ade67cb4131fecd8fda64580() { }

public RESTRC_9f414d82ade67cb4131fecd8fda64580 (RC_9f414d82ade67cb4131fecd8fda64580 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrIsAccounting = ConvertToRestWithoutDefaults(s.ssIsAccounting, false);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceName = s.ssInvoiceName;
AttrIsAccounting = (bool?) s.ssIsAccounting;
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static RC_9f414d82ade67cb4131fecd8fda64580 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580 obj) { 
  RC_9f414d82ade67cb4131fecd8fda64580 s = new RC_9f414d82ade67cb4131fecd8fda64580();
  if(obj != null) {
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssIsAccounting = obj.AttrIsAccounting == null ? false : obj.AttrIsAccounting.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_9f414d82ade67cb4131fecd8fda64580, ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9f414d82ade67cb4131fecd8fda64580 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580 FromStructure(RC_9f414d82ade67cb4131fecd8fda64580 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580(s, config);
}

}


