using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRejectRecord
public class JSONRC_57219406c4228befe08a7a4e1abe2c17 : AbstractRESTStructure<RC_57219406c4228befe08a7a4e1abe2c17> {
[JsonProperty("FolioReject")]
[JsonPropertyName("FolioReject")]
public ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure AttrFolioReject;

public JSONRC_57219406c4228befe08a7a4e1abe2c17() { }

public JSONRC_57219406c4228befe08a7a4e1abe2c17 (RC_57219406c4228befe08a7a4e1abe2c17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioReject = ConvertToRestWithoutDefaults(s.ssSTFolioReject, new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure(), ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure.FromStructure, config);
  } else {
AttrFolioReject = ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure.FromStructure(s.ssSTFolioReject, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17, RC_57219406c4228befe08a7a4e1abe2c17> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17 s) => ToStructure(s, config);
}
public static RC_57219406c4228befe08a7a4e1abe2c17 ToStructure(ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17 obj, IBehaviorsConfiguration config) { 
  RC_57219406c4228befe08a7a4e1abe2c17 s = new RC_57219406c4228befe08a7a4e1abe2c17();
  if(obj != null) {
  s.ssSTFolioReject = ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure.ToStructure(obj.AttrFolioReject, config);
  }
  return s;
}

public static Func<RC_57219406c4228befe08a7a4e1abe2c17, ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_57219406c4228befe08a7a4e1abe2c17 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17 FromStructure(RC_57219406c4228befe08a7a4e1abe2c17 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_57219406c4228befe08a7a4e1abe2c17(s, config);
}

}


