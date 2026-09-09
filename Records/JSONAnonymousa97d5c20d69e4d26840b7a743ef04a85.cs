using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalRecord
public class JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 : AbstractRESTStructure<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

public JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50() { }

public JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50, RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s) => ToStructure(s, config);
}
public static RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 obj, IBehaviorsConfiguration config) { 
  RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s = new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  }
  return s;
}

public static Func<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50, ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 FromStructure(RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8f1c2b4902cba2d0c0cbb5fb1e978b50(s, config);
}

}


