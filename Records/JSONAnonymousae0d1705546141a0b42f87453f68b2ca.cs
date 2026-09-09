using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelRecord
public class JSONRC_a542803a75b19356be8279fb269e55fb : AbstractRESTStructure<RC_a542803a75b19356be8279fb269e55fb> {
[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_a542803a75b19356be8279fb269e55fb() { }

public JSONRC_a542803a75b19356be8279fb269e55fb (RC_a542803a75b19356be8279fb269e55fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb, RC_a542803a75b19356be8279fb269e55fb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb s) => ToStructure(s, config);
}
public static RC_a542803a75b19356be8279fb269e55fb ToStructure(ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb obj, IBehaviorsConfiguration config) { 
  RC_a542803a75b19356be8279fb269e55fb s = new RC_a542803a75b19356be8279fb269e55fb();
  if(obj != null) {
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_a542803a75b19356be8279fb269e55fb, ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a542803a75b19356be8279fb269e55fb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb FromStructure(RC_a542803a75b19356be8279fb269e55fb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a542803a75b19356be8279fb269e55fb(s, config);
}

}


