using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataFolioOrderMainRecord
public class RESTRC_5777458deab7db32c7893b9baeff3dc9 : AbstractRESTStructure<RC_5777458deab7db32c7893b9baeff3dc9> {
[JsonProperty("FolioSAPData")]
public ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_5777458deab7db32c7893b9baeff3dc9() { }

public RESTRC_5777458deab7db32c7893b9baeff3dc9 (RC_5777458deab7db32c7893b9baeff3dc9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_5777458deab7db32c7893b9baeff3dc9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5777458deab7db32c7893b9baeff3dc9 obj) { 
  RC_5777458deab7db32c7893b9baeff3dc9 s = new RC_5777458deab7db32c7893b9baeff3dc9();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_5777458deab7db32c7893b9baeff3dc9, ssConectaProveedores.RestRecords.RESTRC_5777458deab7db32c7893b9baeff3dc9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5777458deab7db32c7893b9baeff3dc9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5777458deab7db32c7893b9baeff3dc9 FromStructure(RC_5777458deab7db32c7893b9baeff3dc9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5777458deab7db32c7893b9baeff3dc9(s, config);
}

}


