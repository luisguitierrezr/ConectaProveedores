using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ConceptManualsAppConceptManualUserAreaRecord
public class JSONRC_bea8613d22251afcd4cf0079dd87bd03 : AbstractRESTStructure<RC_bea8613d22251afcd4cf0079dd87bd03> {
[JsonProperty("Concept")]
[JsonPropertyName("Concept")]
public ssConectaProveedores.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord AttrConcept;

[JsonProperty("Manuals")]
[JsonPropertyName("Manuals")]
public ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord AttrManuals;

[JsonProperty("AppConcept")]
[JsonPropertyName("AppConcept")]
public ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord AttrAppConcept;

[JsonProperty("ManualUserArea")]
[JsonPropertyName("ManualUserArea")]
public ssConectaProveedores.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord AttrManualUserArea;

public JSONRC_bea8613d22251afcd4cf0079dd87bd03() { }

public JSONRC_bea8613d22251afcd4cf0079dd87bd03 (RC_bea8613d22251afcd4cf0079dd87bd03 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrConcept = ConvertToRestWithoutDefaults(s.ssENConcept, new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure, config);
AttrManuals = ConvertToRestWithoutDefaults(s.ssENManuals, new EN_f9557b941e05ea8155a182da4f23a896EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure, config);
AttrAppConcept = ConvertToRestWithoutDefaults(s.ssENAppConcept, new EN_01808938be8d2f648d79d661d64023eaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure, config);
AttrManualUserArea = ConvertToRestWithoutDefaults(s.ssENManualUserArea, new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure, config);
  } else {
AttrConcept = ssConectaProveedores.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure(s.ssENConcept, config);
AttrManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure(s.ssENManuals, config);
AttrAppConcept = ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure(s.ssENAppConcept, config);
AttrManualUserArea = ssConectaProveedores.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure(s.ssENManualUserArea, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03, RC_bea8613d22251afcd4cf0079dd87bd03> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03 s) => ToStructure(s, config);
}
public static RC_bea8613d22251afcd4cf0079dd87bd03 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03 obj, IBehaviorsConfiguration config) { 
  RC_bea8613d22251afcd4cf0079dd87bd03 s = new RC_bea8613d22251afcd4cf0079dd87bd03();
  if(obj != null) {
  s.ssENConcept = ssConectaProveedores.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.ToStructure(obj.AttrConcept, config);
  s.ssENManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.ToStructure(obj.AttrManuals, config);
  s.ssENAppConcept = ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.ToStructure(obj.AttrAppConcept, config);
  s.ssENManualUserArea = ssConectaProveedores.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.ToStructure(obj.AttrManualUserArea, config);
  }
  return s;
}

public static Func<RC_bea8613d22251afcd4cf0079dd87bd03, ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bea8613d22251afcd4cf0079dd87bd03 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03 FromStructure(RC_bea8613d22251afcd4cf0079dd87bd03 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bea8613d22251afcd4cf0079dd87bd03(s, config);
}

}


