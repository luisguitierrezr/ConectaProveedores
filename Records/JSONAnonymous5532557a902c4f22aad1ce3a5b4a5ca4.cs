using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioCommentRecord
public class JSONRC_bd4c69fd286a3fa1bae388a3d68ac007 : AbstractRESTStructure<RC_bd4c69fd286a3fa1bae388a3d68ac007> {
[JsonProperty("FolioComment")]
[JsonPropertyName("FolioComment")]
public ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord AttrFolioComment;

public JSONRC_bd4c69fd286a3fa1bae388a3d68ac007() { }

public JSONRC_bd4c69fd286a3fa1bae388a3d68ac007 (RC_bd4c69fd286a3fa1bae388a3d68ac007 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioComment = ConvertToRestWithoutDefaults(s.ssENFolioComment, new EN_a75639301080da49357fc03810b8d65fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure, config);
  } else {
AttrFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure(s.ssENFolioComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007, RC_bd4c69fd286a3fa1bae388a3d68ac007> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007 s) => ToStructure(s, config);
}
public static RC_bd4c69fd286a3fa1bae388a3d68ac007 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007 obj, IBehaviorsConfiguration config) { 
  RC_bd4c69fd286a3fa1bae388a3d68ac007 s = new RC_bd4c69fd286a3fa1bae388a3d68ac007();
  if(obj != null) {
  s.ssENFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.ToStructure(obj.AttrFolioComment, config);
  }
  return s;
}

public static Func<RC_bd4c69fd286a3fa1bae388a3d68ac007, ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bd4c69fd286a3fa1bae388a3d68ac007 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007 FromStructure(RC_bd4c69fd286a3fa1bae388a3d68ac007 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bd4c69fd286a3fa1bae388a3d68ac007(s, config);
}

}


