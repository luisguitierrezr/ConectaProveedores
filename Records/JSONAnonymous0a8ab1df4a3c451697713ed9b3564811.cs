using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeRecord
public class JSONRC_2c1b3c205a8ef6cb9caa168a859ca828 : AbstractRESTStructure<RC_2c1b3c205a8ef6cb9caa168a859ca828> {
[JsonProperty("CommentType")]
[JsonPropertyName("CommentType")]
public ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

public JSONRC_2c1b3c205a8ef6cb9caa168a859ca828() { }

public JSONRC_2c1b3c205a8ef6cb9caa168a859ca828 (RC_2c1b3c205a8ef6cb9caa168a859ca828 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828, RC_2c1b3c205a8ef6cb9caa168a859ca828> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828 s) => ToStructure(s, config);
}
public static RC_2c1b3c205a8ef6cb9caa168a859ca828 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828 obj, IBehaviorsConfiguration config) { 
  RC_2c1b3c205a8ef6cb9caa168a859ca828 s = new RC_2c1b3c205a8ef6cb9caa168a859ca828();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType, config);
  }
  return s;
}

public static Func<RC_2c1b3c205a8ef6cb9caa168a859ca828, ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2c1b3c205a8ef6cb9caa168a859ca828 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828 FromStructure(RC_2c1b3c205a8ef6cb9caa168a859ca828 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2c1b3c205a8ef6cb9caa168a859ca828(s, config);
}

}


