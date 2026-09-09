using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalRecord
public class RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 : AbstractRESTStructure<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> {
[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

public RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50() { }

public RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
  }
}

public static RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 obj) { 
  RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s = new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  }
  return s;
}

public static Func<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50, ssConectaProveedores.RestRecords.RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50 FromStructure(RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8f1c2b4902cba2d0c0cbb5fb1e978b50(s, config);
}

}


