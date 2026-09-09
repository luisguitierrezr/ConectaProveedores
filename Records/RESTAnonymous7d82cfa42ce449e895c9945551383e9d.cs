using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataRecord
public class RESTRC_7fd286c48691331601c5027580ae5af5 : AbstractRESTStructure<RC_7fd286c48691331601c5027580ae5af5> {
[JsonProperty("FolioSAPData")]
public ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

public RESTRC_7fd286c48691331601c5027580ae5af5() { }

public RESTRC_7fd286c48691331601c5027580ae5af5 (RC_7fd286c48691331601c5027580ae5af5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
  }
}

public static RC_7fd286c48691331601c5027580ae5af5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7fd286c48691331601c5027580ae5af5 obj) { 
  RC_7fd286c48691331601c5027580ae5af5 s = new RC_7fd286c48691331601c5027580ae5af5();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData);
  }
  return s;
}

public static Func<RC_7fd286c48691331601c5027580ae5af5, ssConectaProveedores.RestRecords.RESTRC_7fd286c48691331601c5027580ae5af5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7fd286c48691331601c5027580ae5af5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7fd286c48691331601c5027580ae5af5 FromStructure(RC_7fd286c48691331601c5027580ae5af5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7fd286c48691331601c5027580ae5af5(s, config);
}

}


