using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeFolioCommentRecord
public class RESTRC_03baaf9011c29c7810216c701048afb6 : AbstractRESTStructure<RC_03baaf9011c29c7810216c701048afb6> {
[JsonProperty("CommentType")]
public ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

[JsonProperty("FolioComment")]
public ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord AttrFolioComment;

public RESTRC_03baaf9011c29c7810216c701048afb6() { }

public RESTRC_03baaf9011c29c7810216c701048afb6 (RC_03baaf9011c29c7810216c701048afb6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
AttrFolioComment = ConvertToRestWithoutDefaults(s.ssENFolioComment, new EN_a75639301080da49357fc03810b8d65fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
AttrFolioComment = ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure(s.ssENFolioComment, config);
  }
}

public static RC_03baaf9011c29c7810216c701048afb6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6 obj) { 
  RC_03baaf9011c29c7810216c701048afb6 s = new RC_03baaf9011c29c7810216c701048afb6();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType);
  s.ssENFolioComment = ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.ToStructure(obj.AttrFolioComment);
  }
  return s;
}

public static Func<RC_03baaf9011c29c7810216c701048afb6, ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03baaf9011c29c7810216c701048afb6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6 FromStructure(RC_03baaf9011c29c7810216c701048afb6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6(s, config);
}

}


