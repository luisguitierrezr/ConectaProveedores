using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioDetailInfoRecord
public class RESTRC_d69007668fd5133aa9666ff86ada7ddc : AbstractRESTStructure<RC_d69007668fd5133aa9666ff86ada7ddc> {
[JsonProperty("FolioDetailInfo")]
public ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure AttrFolioDetailInfo;

public RESTRC_d69007668fd5133aa9666ff86ada7ddc() { }

public RESTRC_d69007668fd5133aa9666ff86ada7ddc (RC_d69007668fd5133aa9666ff86ada7ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioDetailInfo = ConvertToRestWithoutDefaults(s.ssSTFolioDetailInfo, new ST_62dd5b695df6cdb1dddea5855e8718baStructure(), ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure.FromStructure, config);
  } else {
AttrFolioDetailInfo = ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure.FromStructure(s.ssSTFolioDetailInfo, config);
  }
}

public static RC_d69007668fd5133aa9666ff86ada7ddc ToStructure(ssConectaProveedores.RestRecords.RESTRC_d69007668fd5133aa9666ff86ada7ddc obj) { 
  RC_d69007668fd5133aa9666ff86ada7ddc s = new RC_d69007668fd5133aa9666ff86ada7ddc();
  if(obj != null) {
  s.ssSTFolioDetailInfo = ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure.ToStructure(obj.AttrFolioDetailInfo);
  }
  return s;
}

public static Func<RC_d69007668fd5133aa9666ff86ada7ddc, ssConectaProveedores.RestRecords.RESTRC_d69007668fd5133aa9666ff86ada7ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d69007668fd5133aa9666ff86ada7ddc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d69007668fd5133aa9666ff86ada7ddc FromStructure(RC_d69007668fd5133aa9666ff86ada7ddc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d69007668fd5133aa9666ff86ada7ddc(s, config);
}

}


