using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalProcessTypeRecord
public class RESTRC_c72f9a44b3b624f179aa49efc0650682 : AbstractRESTStructure<RC_c72f9a44b3b624f179aa49efc0650682> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("ApprovalProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public RESTRC_c72f9a44b3b624f179aa49efc0650682() { }

public RESTRC_c72f9a44b3b624f179aa49efc0650682 (RC_c72f9a44b3b624f179aa49efc0650682 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static RC_c72f9a44b3b624f179aa49efc0650682 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c72f9a44b3b624f179aa49efc0650682 obj) { 
  RC_c72f9a44b3b624f179aa49efc0650682 s = new RC_c72f9a44b3b624f179aa49efc0650682();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType);
  }
  return s;
}

public static Func<RC_c72f9a44b3b624f179aa49efc0650682, ssConectaProveedores.RestRecords.RESTRC_c72f9a44b3b624f179aa49efc0650682> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c72f9a44b3b624f179aa49efc0650682 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c72f9a44b3b624f179aa49efc0650682 FromStructure(RC_c72f9a44b3b624f179aa49efc0650682 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c72f9a44b3b624f179aa49efc0650682(s, config);
}

}


