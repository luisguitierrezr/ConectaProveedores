using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRejectRecord
public class RESTRC_57219406c4228befe08a7a4e1abe2c17 : AbstractRESTStructure<RC_57219406c4228befe08a7a4e1abe2c17> {
[JsonProperty("FolioReject")]
public ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure AttrFolioReject;

public RESTRC_57219406c4228befe08a7a4e1abe2c17() { }

public RESTRC_57219406c4228befe08a7a4e1abe2c17 (RC_57219406c4228befe08a7a4e1abe2c17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioReject = ConvertToRestWithoutDefaults(s.ssSTFolioReject, new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure(), ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.FromStructure, config);
  } else {
AttrFolioReject = ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.FromStructure(s.ssSTFolioReject, config);
  }
}

public static RC_57219406c4228befe08a7a4e1abe2c17 ToStructure(ssConectaProveedores.RestRecords.RESTRC_57219406c4228befe08a7a4e1abe2c17 obj) { 
  RC_57219406c4228befe08a7a4e1abe2c17 s = new RC_57219406c4228befe08a7a4e1abe2c17();
  if(obj != null) {
  s.ssSTFolioReject = ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.ToStructure(obj.AttrFolioReject);
  }
  return s;
}

public static Func<RC_57219406c4228befe08a7a4e1abe2c17, ssConectaProveedores.RestRecords.RESTRC_57219406c4228befe08a7a4e1abe2c17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_57219406c4228befe08a7a4e1abe2c17 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_57219406c4228befe08a7a4e1abe2c17 FromStructure(RC_57219406c4228befe08a7a4e1abe2c17 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_57219406c4228befe08a7a4e1abe2c17(s, config);
}

}


