using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQRecord
public class JSONRC_b5715a31bd56ae3cc671ee9419cb6075 : AbstractRESTStructure<RC_b5715a31bd56ae3cc671ee9419cb6075> {
[JsonProperty("FolioQ")]
[JsonPropertyName("FolioQ")]
public ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure AttrFolioQ;

public JSONRC_b5715a31bd56ae3cc671ee9419cb6075() { }

public JSONRC_b5715a31bd56ae3cc671ee9419cb6075 (RC_b5715a31bd56ae3cc671ee9419cb6075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQ = ConvertToRestWithoutDefaults(s.ssSTFolioQ, new ST_118fe20454dd0bf1f0e6d925e7d7544bStructure(), ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure.FromStructure, config);
  } else {
AttrFolioQ = ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure.FromStructure(s.ssSTFolioQ, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075, RC_b5715a31bd56ae3cc671ee9419cb6075> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075 s) => ToStructure(s, config);
}
public static RC_b5715a31bd56ae3cc671ee9419cb6075 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075 obj, IBehaviorsConfiguration config) { 
  RC_b5715a31bd56ae3cc671ee9419cb6075 s = new RC_b5715a31bd56ae3cc671ee9419cb6075();
  if(obj != null) {
  s.ssSTFolioQ = ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure.ToStructure(obj.AttrFolioQ, config);
  }
  return s;
}

public static Func<RC_b5715a31bd56ae3cc671ee9419cb6075, ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b5715a31bd56ae3cc671ee9419cb6075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075 FromStructure(RC_b5715a31bd56ae3cc671ee9419cb6075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b5715a31bd56ae3cc671ee9419cb6075(s, config);
}

}


