using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQRecord
public class RESTRC_b5715a31bd56ae3cc671ee9419cb6075 : AbstractRESTStructure<RC_b5715a31bd56ae3cc671ee9419cb6075> {
[JsonProperty("FolioQ")]
public ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure AttrFolioQ;

public RESTRC_b5715a31bd56ae3cc671ee9419cb6075() { }

public RESTRC_b5715a31bd56ae3cc671ee9419cb6075 (RC_b5715a31bd56ae3cc671ee9419cb6075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQ = ConvertToRestWithoutDefaults(s.ssSTFolioQ, new ST_118fe20454dd0bf1f0e6d925e7d7544bStructure(), ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure.FromStructure, config);
  } else {
AttrFolioQ = ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure.FromStructure(s.ssSTFolioQ, config);
  }
}

public static RC_b5715a31bd56ae3cc671ee9419cb6075 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b5715a31bd56ae3cc671ee9419cb6075 obj) { 
  RC_b5715a31bd56ae3cc671ee9419cb6075 s = new RC_b5715a31bd56ae3cc671ee9419cb6075();
  if(obj != null) {
  s.ssSTFolioQ = ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure.ToStructure(obj.AttrFolioQ);
  }
  return s;
}

public static Func<RC_b5715a31bd56ae3cc671ee9419cb6075, ssConectaProveedores.RestRecords.RESTRC_b5715a31bd56ae3cc671ee9419cb6075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b5715a31bd56ae3cc671ee9419cb6075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b5715a31bd56ae3cc671ee9419cb6075 FromStructure(RC_b5715a31bd56ae3cc671ee9419cb6075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b5715a31bd56ae3cc671ee9419cb6075(s, config);
}

}


