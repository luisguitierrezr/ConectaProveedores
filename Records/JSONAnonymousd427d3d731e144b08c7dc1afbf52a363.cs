using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioDetailInfoRecord
public class JSONRC_d69007668fd5133aa9666ff86ada7ddc : AbstractRESTStructure<RC_d69007668fd5133aa9666ff86ada7ddc> {
[JsonProperty("FolioDetailInfo")]
[JsonPropertyName("FolioDetailInfo")]
public ssConectaProveedores.RestRecords.JSONST_62dd5b695df6cdb1dddea5855e8718baStructure AttrFolioDetailInfo;

public JSONRC_d69007668fd5133aa9666ff86ada7ddc() { }

public JSONRC_d69007668fd5133aa9666ff86ada7ddc (RC_d69007668fd5133aa9666ff86ada7ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioDetailInfo = ConvertToRestWithoutDefaults(s.ssSTFolioDetailInfo, new ST_62dd5b695df6cdb1dddea5855e8718baStructure(), ssConectaProveedores.RestRecords.JSONST_62dd5b695df6cdb1dddea5855e8718baStructure.FromStructure, config);
  } else {
AttrFolioDetailInfo = ssConectaProveedores.RestRecords.JSONST_62dd5b695df6cdb1dddea5855e8718baStructure.FromStructure(s.ssSTFolioDetailInfo, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc, RC_d69007668fd5133aa9666ff86ada7ddc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc s) => ToStructure(s, config);
}
public static RC_d69007668fd5133aa9666ff86ada7ddc ToStructure(ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc obj, IBehaviorsConfiguration config) { 
  RC_d69007668fd5133aa9666ff86ada7ddc s = new RC_d69007668fd5133aa9666ff86ada7ddc();
  if(obj != null) {
  s.ssSTFolioDetailInfo = ssConectaProveedores.RestRecords.JSONST_62dd5b695df6cdb1dddea5855e8718baStructure.ToStructure(obj.AttrFolioDetailInfo, config);
  }
  return s;
}

public static Func<RC_d69007668fd5133aa9666ff86ada7ddc, ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d69007668fd5133aa9666ff86ada7ddc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc FromStructure(RC_d69007668fd5133aa9666ff86ada7ddc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d69007668fd5133aa9666ff86ada7ddc(s, config);
}

}


