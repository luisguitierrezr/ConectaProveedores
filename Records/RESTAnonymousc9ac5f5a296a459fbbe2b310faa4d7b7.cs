using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRecord
public class RESTRC_bb81744faa58ae73e7cd8db74cb32155 : AbstractRESTStructure<RC_bb81744faa58ae73e7cd8db74cb32155> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public RESTRC_bb81744faa58ae73e7cd8db74cb32155() { }

public RESTRC_bb81744faa58ae73e7cd8db74cb32155 (RC_bb81744faa58ae73e7cd8db74cb32155 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static RC_bb81744faa58ae73e7cd8db74cb32155 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bb81744faa58ae73e7cd8db74cb32155 obj) { 
  RC_bb81744faa58ae73e7cd8db74cb32155 s = new RC_bb81744faa58ae73e7cd8db74cb32155();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  }
  return s;
}

public static Func<RC_bb81744faa58ae73e7cd8db74cb32155, ssConectaProveedores.RestRecords.RESTRC_bb81744faa58ae73e7cd8db74cb32155> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bb81744faa58ae73e7cd8db74cb32155 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bb81744faa58ae73e7cd8db74cb32155 FromStructure(RC_bb81744faa58ae73e7cd8db74cb32155 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bb81744faa58ae73e7cd8db74cb32155(s, config);
}

}


