using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioRecord
public class RESTRC_d62ad7391a87381616a77aeae304e183 : AbstractRESTStructure<RC_d62ad7391a87381616a77aeae304e183> {
[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

public RESTRC_d62ad7391a87381616a77aeae304e183() { }

public RESTRC_d62ad7391a87381616a77aeae304e183 (RC_d62ad7391a87381616a77aeae304e183 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
  }
}

public static RC_d62ad7391a87381616a77aeae304e183 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d62ad7391a87381616a77aeae304e183 obj) { 
  RC_d62ad7391a87381616a77aeae304e183 s = new RC_d62ad7391a87381616a77aeae304e183();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  }
  return s;
}

public static Func<RC_d62ad7391a87381616a77aeae304e183, ssConectaProveedores.RestRecords.RESTRC_d62ad7391a87381616a77aeae304e183> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d62ad7391a87381616a77aeae304e183 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d62ad7391a87381616a77aeae304e183 FromStructure(RC_d62ad7391a87381616a77aeae304e183 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d62ad7391a87381616a77aeae304e183(s, config);
}

}


