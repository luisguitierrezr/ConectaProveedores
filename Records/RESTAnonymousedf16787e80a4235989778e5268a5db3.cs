using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedCartaPorteRecord
public class RESTRC_79b8311427bcbe4ce4ecbe042bf03773 : AbstractRESTStructure<RC_79b8311427bcbe4ce4ecbe042bf03773> {
[JsonProperty("InvoiceExtendedCartaPorte")]
public ssConectaProveedores.RestRecords.RESTEN_9bd576a05df3846c52ce88a606aff414EntityRecord AttrInvoiceExtendedCartaPorte;

public RESTRC_79b8311427bcbe4ce4ecbe042bf03773() { }

public RESTRC_79b8311427bcbe4ce4ecbe042bf03773 (RC_79b8311427bcbe4ce4ecbe042bf03773 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedCartaPorte = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedCartaPorte, new EN_9bd576a05df3846c52ce88a606aff414EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.RESTEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure(s.ssENInvoiceExtendedCartaPorte, config);
  }
}

public static RC_79b8311427bcbe4ce4ecbe042bf03773 ToStructure(ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773 obj) { 
  RC_79b8311427bcbe4ce4ecbe042bf03773 s = new RC_79b8311427bcbe4ce4ecbe042bf03773();
  if(obj != null) {
  s.ssENInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.RESTEN_9bd576a05df3846c52ce88a606aff414EntityRecord.ToStructure(obj.AttrInvoiceExtendedCartaPorte);
  }
  return s;
}

public static Func<RC_79b8311427bcbe4ce4ecbe042bf03773, ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_79b8311427bcbe4ce4ecbe042bf03773 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773 FromStructure(RC_79b8311427bcbe4ce4ecbe042bf03773 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773(s, config);
}

}


