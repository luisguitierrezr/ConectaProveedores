using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCommentRecord
public class JSONRC_08daffa670c72e7502779e59a7b292d3 : AbstractRESTStructure<RC_08daffa670c72e7502779e59a7b292d3> {
[JsonProperty("RequisitionComment")]
[JsonPropertyName("RequisitionComment")]
public ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord AttrRequisitionComment;

public JSONRC_08daffa670c72e7502779e59a7b292d3() { }

public JSONRC_08daffa670c72e7502779e59a7b292d3 (RC_08daffa670c72e7502779e59a7b292d3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionComment = ConvertToRestWithoutDefaults(s.ssENRequisitionComment, new EN_cbeb601b681344342c8de0161d058f87EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure, config);
  } else {
AttrRequisitionComment = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure(s.ssENRequisitionComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3, RC_08daffa670c72e7502779e59a7b292d3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3 s) => ToStructure(s, config);
}
public static RC_08daffa670c72e7502779e59a7b292d3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3 obj, IBehaviorsConfiguration config) { 
  RC_08daffa670c72e7502779e59a7b292d3 s = new RC_08daffa670c72e7502779e59a7b292d3();
  if(obj != null) {
  s.ssENRequisitionComment = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.ToStructure(obj.AttrRequisitionComment, config);
  }
  return s;
}

public static Func<RC_08daffa670c72e7502779e59a7b292d3, ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_08daffa670c72e7502779e59a7b292d3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3 FromStructure(RC_08daffa670c72e7502779e59a7b292d3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_08daffa670c72e7502779e59a7b292d3(s, config);
}

}


