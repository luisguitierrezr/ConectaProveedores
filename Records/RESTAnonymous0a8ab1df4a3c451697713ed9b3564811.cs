using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeRecord
public class RESTRC_2c1b3c205a8ef6cb9caa168a859ca828 : AbstractRESTStructure<RC_2c1b3c205a8ef6cb9caa168a859ca828> {
[JsonProperty("CommentType")]
public ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

public RESTRC_2c1b3c205a8ef6cb9caa168a859ca828() { }

public RESTRC_2c1b3c205a8ef6cb9caa168a859ca828 (RC_2c1b3c205a8ef6cb9caa168a859ca828 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
  }
}

public static RC_2c1b3c205a8ef6cb9caa168a859ca828 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2c1b3c205a8ef6cb9caa168a859ca828 obj) { 
  RC_2c1b3c205a8ef6cb9caa168a859ca828 s = new RC_2c1b3c205a8ef6cb9caa168a859ca828();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType);
  }
  return s;
}

public static Func<RC_2c1b3c205a8ef6cb9caa168a859ca828, ssConectaProveedores.RestRecords.RESTRC_2c1b3c205a8ef6cb9caa168a859ca828> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2c1b3c205a8ef6cb9caa168a859ca828 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2c1b3c205a8ef6cb9caa168a859ca828 FromStructure(RC_2c1b3c205a8ef6cb9caa168a859ca828 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2c1b3c205a8ef6cb9caa168a859ca828(s, config);
}

}


