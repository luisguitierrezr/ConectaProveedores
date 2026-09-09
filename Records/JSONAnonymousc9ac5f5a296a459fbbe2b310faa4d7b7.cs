using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRecord
public class JSONRC_bb81744faa58ae73e7cd8db74cb32155 : AbstractRESTStructure<RC_bb81744faa58ae73e7cd8db74cb32155> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public JSONRC_bb81744faa58ae73e7cd8db74cb32155() { }

public JSONRC_bb81744faa58ae73e7cd8db74cb32155 (RC_bb81744faa58ae73e7cd8db74cb32155 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155, RC_bb81744faa58ae73e7cd8db74cb32155> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155 s) => ToStructure(s, config);
}
public static RC_bb81744faa58ae73e7cd8db74cb32155 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155 obj, IBehaviorsConfiguration config) { 
  RC_bb81744faa58ae73e7cd8db74cb32155 s = new RC_bb81744faa58ae73e7cd8db74cb32155();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  }
  return s;
}

public static Func<RC_bb81744faa58ae73e7cd8db74cb32155, ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bb81744faa58ae73e7cd8db74cb32155 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155 FromStructure(RC_bb81744faa58ae73e7cd8db74cb32155 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bb81744faa58ae73e7cd8db74cb32155(s, config);
}

}


