using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ConceptManualsAppConceptManualUserAreaRecord
public class RESTRC_bea8613d22251afcd4cf0079dd87bd03 : AbstractRESTStructure<RC_bea8613d22251afcd4cf0079dd87bd03> {
[JsonProperty("Concept")]
public ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord AttrConcept;

[JsonProperty("Manuals")]
public ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord AttrManuals;

[JsonProperty("AppConcept")]
public ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord AttrAppConcept;

[JsonProperty("ManualUserArea")]
public ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord AttrManualUserArea;

public RESTRC_bea8613d22251afcd4cf0079dd87bd03() { }

public RESTRC_bea8613d22251afcd4cf0079dd87bd03 (RC_bea8613d22251afcd4cf0079dd87bd03 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrConcept = ConvertToRestWithoutDefaults(s.ssENConcept, new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure, config);
AttrManuals = ConvertToRestWithoutDefaults(s.ssENManuals, new EN_f9557b941e05ea8155a182da4f23a896EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure, config);
AttrAppConcept = ConvertToRestWithoutDefaults(s.ssENAppConcept, new EN_01808938be8d2f648d79d661d64023eaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure, config);
AttrManualUserArea = ConvertToRestWithoutDefaults(s.ssENManualUserArea, new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure, config);
  } else {
AttrConcept = ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure(s.ssENConcept, config);
AttrManuals = ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure(s.ssENManuals, config);
AttrAppConcept = ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure(s.ssENAppConcept, config);
AttrManualUserArea = ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure(s.ssENManualUserArea, config);
  }
}

public static RC_bea8613d22251afcd4cf0079dd87bd03 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bea8613d22251afcd4cf0079dd87bd03 obj) { 
  RC_bea8613d22251afcd4cf0079dd87bd03 s = new RC_bea8613d22251afcd4cf0079dd87bd03();
  if(obj != null) {
  s.ssENConcept = ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.ToStructure(obj.AttrConcept);
  s.ssENManuals = ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.ToStructure(obj.AttrManuals);
  s.ssENAppConcept = ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.ToStructure(obj.AttrAppConcept);
  s.ssENManualUserArea = ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.ToStructure(obj.AttrManualUserArea);
  }
  return s;
}

public static Func<RC_bea8613d22251afcd4cf0079dd87bd03, ssConectaProveedores.RestRecords.RESTRC_bea8613d22251afcd4cf0079dd87bd03> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bea8613d22251afcd4cf0079dd87bd03 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bea8613d22251afcd4cf0079dd87bd03 FromStructure(RC_bea8613d22251afcd4cf0079dd87bd03 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bea8613d22251afcd4cf0079dd87bd03(s, config);
}

}


