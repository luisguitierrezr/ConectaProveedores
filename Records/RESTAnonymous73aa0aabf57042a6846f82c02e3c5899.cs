using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCommentRecord
public class RESTRC_08daffa670c72e7502779e59a7b292d3 : AbstractRESTStructure<RC_08daffa670c72e7502779e59a7b292d3> {
[JsonProperty("RequisitionComment")]
public ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord AttrRequisitionComment;

public RESTRC_08daffa670c72e7502779e59a7b292d3() { }

public RESTRC_08daffa670c72e7502779e59a7b292d3 (RC_08daffa670c72e7502779e59a7b292d3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionComment = ConvertToRestWithoutDefaults(s.ssENRequisitionComment, new EN_cbeb601b681344342c8de0161d058f87EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure, config);
  } else {
AttrRequisitionComment = ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure(s.ssENRequisitionComment, config);
  }
}

public static RC_08daffa670c72e7502779e59a7b292d3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_08daffa670c72e7502779e59a7b292d3 obj) { 
  RC_08daffa670c72e7502779e59a7b292d3 s = new RC_08daffa670c72e7502779e59a7b292d3();
  if(obj != null) {
  s.ssENRequisitionComment = ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord.ToStructure(obj.AttrRequisitionComment);
  }
  return s;
}

public static Func<RC_08daffa670c72e7502779e59a7b292d3, ssConectaProveedores.RestRecords.RESTRC_08daffa670c72e7502779e59a7b292d3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_08daffa670c72e7502779e59a7b292d3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_08daffa670c72e7502779e59a7b292d3 FromStructure(RC_08daffa670c72e7502779e59a7b292d3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_08daffa670c72e7502779e59a7b292d3(s, config);
}

}


