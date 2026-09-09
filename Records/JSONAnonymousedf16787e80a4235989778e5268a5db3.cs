using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedCartaPorteRecord
public class JSONRC_79b8311427bcbe4ce4ecbe042bf03773 : AbstractRESTStructure<RC_79b8311427bcbe4ce4ecbe042bf03773> {
[JsonProperty("InvoiceExtendedCartaPorte")]
[JsonPropertyName("InvoiceExtendedCartaPorte")]
public ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord AttrInvoiceExtendedCartaPorte;

public JSONRC_79b8311427bcbe4ce4ecbe042bf03773() { }

public JSONRC_79b8311427bcbe4ce4ecbe042bf03773 (RC_79b8311427bcbe4ce4ecbe042bf03773 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedCartaPorte = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedCartaPorte, new EN_9bd576a05df3846c52ce88a606aff414EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure(s.ssENInvoiceExtendedCartaPorte, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773, RC_79b8311427bcbe4ce4ecbe042bf03773> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773 s) => ToStructure(s, config);
}
public static RC_79b8311427bcbe4ce4ecbe042bf03773 ToStructure(ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773 obj, IBehaviorsConfiguration config) { 
  RC_79b8311427bcbe4ce4ecbe042bf03773 s = new RC_79b8311427bcbe4ce4ecbe042bf03773();
  if(obj != null) {
  s.ssENInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.ToStructure(obj.AttrInvoiceExtendedCartaPorte, config);
  }
  return s;
}

public static Func<RC_79b8311427bcbe4ce4ecbe042bf03773, ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_79b8311427bcbe4ce4ecbe042bf03773 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773 FromStructure(RC_79b8311427bcbe4ce4ecbe042bf03773 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_79b8311427bcbe4ce4ecbe042bf03773(s, config);
}

}


