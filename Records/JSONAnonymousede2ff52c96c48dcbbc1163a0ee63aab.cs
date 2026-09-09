using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioRecord
public class JSONRC_d62ad7391a87381616a77aeae304e183 : AbstractRESTStructure<RC_d62ad7391a87381616a77aeae304e183> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

public JSONRC_d62ad7391a87381616a77aeae304e183() { }

public JSONRC_d62ad7391a87381616a77aeae304e183 (RC_d62ad7391a87381616a77aeae304e183 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183, RC_d62ad7391a87381616a77aeae304e183> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183 s) => ToStructure(s, config);
}
public static RC_d62ad7391a87381616a77aeae304e183 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183 obj, IBehaviorsConfiguration config) { 
  RC_d62ad7391a87381616a77aeae304e183 s = new RC_d62ad7391a87381616a77aeae304e183();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  }
  return s;
}

public static Func<RC_d62ad7391a87381616a77aeae304e183, ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d62ad7391a87381616a77aeae304e183 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183 FromStructure(RC_d62ad7391a87381616a77aeae304e183 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d62ad7391a87381616a77aeae304e183(s, config);
}

}


