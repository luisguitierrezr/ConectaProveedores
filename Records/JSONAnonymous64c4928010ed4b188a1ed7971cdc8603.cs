using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeFolioCommentRecord
public class JSONRC_03baaf9011c29c7810216c701048afb6 : AbstractRESTStructure<RC_03baaf9011c29c7810216c701048afb6> {
[JsonProperty("CommentType")]
[JsonPropertyName("CommentType")]
public ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

[JsonProperty("FolioComment")]
[JsonPropertyName("FolioComment")]
public ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord AttrFolioComment;

public JSONRC_03baaf9011c29c7810216c701048afb6() { }

public JSONRC_03baaf9011c29c7810216c701048afb6 (RC_03baaf9011c29c7810216c701048afb6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
AttrFolioComment = ConvertToRestWithoutDefaults(s.ssENFolioComment, new EN_a75639301080da49357fc03810b8d65fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
AttrFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure(s.ssENFolioComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6, RC_03baaf9011c29c7810216c701048afb6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6 s) => ToStructure(s, config);
}
public static RC_03baaf9011c29c7810216c701048afb6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6 obj, IBehaviorsConfiguration config) { 
  RC_03baaf9011c29c7810216c701048afb6 s = new RC_03baaf9011c29c7810216c701048afb6();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType, config);
  s.ssENFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.ToStructure(obj.AttrFolioComment, config);
  }
  return s;
}

public static Func<RC_03baaf9011c29c7810216c701048afb6, ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03baaf9011c29c7810216c701048afb6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6 FromStructure(RC_03baaf9011c29c7810216c701048afb6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_03baaf9011c29c7810216c701048afb6(s, config);
}

}


